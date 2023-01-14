using System.Linq;
using UnityEngine;

//todo упростить, разделить логику
namespace Ziggurat
{
    public class Unit : MonoBehaviour
    {
        //public Event OnDeath;
        //todo добавить автомат состояний

        public UnitType _unitType;//тип юнита

        private UnitsStats _stats;//базовые статы юнита
        private float _hp;//текущий показатель hp


        private Transform _currentTarget;

        private Unit _targetUnit;

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

        private void Awake()
        {
            //temp
            _unitMovement = GetComponent<UnitMovement>();

            _timer = _seekTimeout;
        }
        private void OnEnable()
        {
            Respawn();
        }
        public void Respawn()
        {
            _stats = GameManager.instance._configurationAssistant.ReadCurrentUnitStats(_unitType);
            _hp = _stats.Health;

            _unitMovement.SetSpeed(_stats.MovementSpeed);//передаём скорость из статистики в навмеш
            _currentTarget = GameManager.instance._aiAssistant.DefaultTarget;

            _unitMovement.SetTarget(_currentTarget);
        }
        private void Update()
        {
            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {
                _timer = _seekTimeout;
                _targetUnit = TryFindNearestTarget(out bool isSuccess);
                _currentTarget = _targetUnit.transform;
                if (isSuccess)
                {
                    _unitMovement.SetTarget(_currentTarget);
                }


                //Debug.Log(this + "нашел врага" + _currentTarget);

                if (/*IsEnemy(_currentTarget)*/(Distance(_currentTarget) > 0.1) && TargetInAttackRange(_currentTarget))
                {
                    Attack();
                }
            }
        }

        private void Attack()
        {
            transform.LookAt(_currentTarget);
            float randomChance = UnityEngine.Random.value;

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

        public void WeaponTriggerDetected()
        {
            //Debug.Log("child collided");
            float damage;

            if (_fastAttack)
                damage = _stats.FastAttackDamage;
            else
                damage = _stats.StrongAttackDamage;

            float randomChance = UnityEngine.Random.value;

            if (_stats.CritChance > randomChance * 100)
                damage *= 2;

            randomChance = UnityEngine.Random.value;
            if (_stats.MissChance > randomChance * 100)
                damage *= 0;

            _targetUnit.TakeDamage(damage);
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
            {
                _currentTarget = GameManager.instance._aiAssistant.DefaultTarget;
                _unitMovement.SetTarget(_currentTarget);
                return this;
            }
                

            return result;
        }
        private bool IsEnemy(Unit target)
        {
            return target._unitType != this._unitType;
        }
        public void Death()
        {
            //_targetUnit= null;
            _unitMovement.StartAnimation("Die");
            //OnDeath();
        }

    }
    /*_nearestEnemy.GetComponent<EnemyController>().OnWinerMessage += AtackNearestEnemy;
        transform.LookAt(_nearestEnemy.transform);       

        return _nearestEnemy;*/
}