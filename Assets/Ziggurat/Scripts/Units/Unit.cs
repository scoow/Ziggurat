using System.Linq;
using UnityEngine;

//todo упростить, разделить логику
namespace Ziggurat
{
    public class Unit : MonoBehaviour
    {
        //todo добавить автомат

        public UnitType _unitType;//тип юнита
        private UnitsStats _stats;
        private Transform _target;

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

        private void Start()
        {
            _unitMovement = GetComponent<UnitMovement>();
            _stats = GameManager.instance._configurationAssistant.ReadCurrentUnitStats(_unitType);
            _timer = _seekTimeout;


            _target = FindObjectOfType<UnitsContainer>().transform;//temp
            _unitMovement.SetTarget(_target);

            //Debug.Log(_stats.Health);
        }
        private void Update()
        {
            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {
                _timer = _seekTimeout;
                _target = TryFindNearestTarget(out bool isSuccess);
                if (isSuccess)
                {
                    _unitMovement.SetTarget(_target);
                }


                //Debug.Log(this + "нашел врага" + _target);

                if (/*IsEnemy(_target)*/(Distance(_target) > 1) && TargetInAttackRange(_target))
                {
                    Attack();
                }
            }
        }

        private void Attack()
        {
            transform.LookAt(_target);
            float randomChance = Random.value;
            if ((randomChance * 100) > _stats.FastOrStrongAttackChance)
            {
                _unitMovement.StartAnim("Fast");
            }
            else
            {
                _unitMovement.StartAnim("Strong");//todo enum состояний
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

        public Transform TryFindNearestTarget(out bool isSuccess)
        {
            var result = GameManager.instance._aiAssistant.GetAllUnits().OrderBy(x => Distance(x.transform)).FirstOrDefault(x => IsEnemy(x) && TargetInSight(x.transform));
            isSuccess = result != null;

            if (!isSuccess)
                return this.transform;

            return result.transform;
        }

        private bool IsEnemy(Unit target)
        {
            return target._unitType != this._unitType;
        }

        private void Death()
        {
            _unitMovement.StartAnim("Die");
        }
    }

    /*_nearestEnemy.GetComponent<EnemyController>().OnWinerMessage += AtackNearestEnemy;
        transform.LookAt(_nearestEnemy.transform);       

        return _nearestEnemy;*/
}