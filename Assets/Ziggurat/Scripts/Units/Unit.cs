using System.Linq;
using UnityEngine;

//todo упростить, разделить логику
namespace Ziggurat
{
    public class Unit : MonoBehaviour
    {
        //todo добавить автомат состояний

        public UnitType _unitType;//тип юнита

        private UnitsStats _stats;

        private float _hp;

        private Transform _targetTransform;
        private Unit _targetUnit;

        private Collider _unitCollider;
        private Collider _swordCollider;

        private UnitMovement _unitMovement;

        /// <summary>
        /// Дальность взгляда (обнаружения)
        /// </summary>
        [SerializeField]
        private float _sightDistance = 5;
        /// <summary>
        /// Дальность атаки
        /// </summary>
        [SerializeField]
        private float _attackRange = 2;

        [SerializeField]
        private float _seekTimeout = 4;//кд до поиска противника

        private float _timer;//время до поиска противника
        private bool _fastAttack;

        private void Start()
        {
            _unitCollider = GetComponent<CapsuleCollider>();//Capsule
            _swordCollider = GetComponentInChildren<BoxCollider>();

            

            _unitMovement = GetComponent<UnitMovement>();
            _stats = GameManager.instance._configurationAssistant.ReadCurrentUnitStats(_unitType);
            _timer = _seekTimeout;

            _hp = _stats.Health;//hp

            _unitMovement.SetSpeed(_stats.MovementSpeed);//передаём скорость из статистики в навмеш
            _targetTransform = FindObjectOfType<UnitsContainer>().transform;//temp
            _unitMovement.SetTarget(_targetTransform);

            //Debug.Log(_stats.Health);
        }
        private void Update()
        {
            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {
                _timer = _seekTimeout;
                _targetUnit = TryFindNearestTarget(out bool isSuccess);
                _targetTransform = _targetUnit.transform;
                if (isSuccess)
                {
                    _unitMovement.SetTarget(_targetTransform);
                }


                //Debug.Log(this + "нашел врага" + _targetTransform);

                if (/*IsEnemy(_targetTransform)*/(Distance(_targetTransform) > 0.1) && TargetInAttackRange(_targetTransform))
                {
                    Attack();
                }
            }
        }

        private void Attack()
        {
            transform.LookAt(_targetTransform);
            float randomChance = Random.value;

            _fastAttack = (randomChance * 100) > _stats.FastOrStrongAttackChance;

            if (_fastAttack)
            {
                _unitMovement.StartAnimation("Fast");
            }
            else
            {
                _unitMovement.StartAnimation("Strong");//todo enum состояний
            }
        }

        public void WeaponTriggerDetected(Weapon weapon)
        {
            //Debug.Log("child collided");
            if (_fastAttack)
            {
                _targetUnit.TakeDamage(_stats.FastAttackDamage);

            }
                
            else
            {
                _targetUnit.TakeDamage(_stats.StrongAttackDamage);
            }
                
        }

        public void TakeDamage(float damage)
        {
            _hp -= damage;
            Debug.Log(this.ToString() + _hp);

            if (_hp <= 0)
            {
                Death();
            }
        }


        private bool TargetInSight(Transform target)//
        {
            return Distance(target.transform) < _sightDistance;
        }

        private bool TargetInAttackRange(Transform target)
        {
            return Distance(target.transform) < _attackRange;
        }

        private float Distance(Transform target)
        {
            return Vector3.Distance(transform.position, target.position);
        }

        public Unit TryFindNearestTarget(out bool isSuccess)
        {
            var result = GameManager.instance._aiAssistant.GetAllUnits().OrderBy(x => Distance(x.transform)).FirstOrDefault(x => IsEnemy(x) && TargetInSight(x.transform));
            isSuccess = result != null;

            if (!isSuccess)//todo убрать заглушку
                return this;

            return result;
        }

        private bool IsEnemy(Unit target)
        {
            return target._unitType != this._unitType;
        }

        private void Death()
        {
            _unitMovement.StartAnimation("Die");
        }
    }

    /*_nearestEnemy.GetComponent<EnemyController>().OnWinerMessage += AtackNearestEnemy;
        transform.LookAt(_nearestEnemy.transform);       

        return _nearestEnemy;*/
}