using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Ziggurat
{
    public class Unit : MonoBehaviour
    {
        public UnitType _unitType;//
        private UnitsStats _stats;
        Transform _target;

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
        }
        private void Update()
        {
            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {
                _timer = _seekTimeout;
                _target = FindNearestTarget();
                _unitMovement.SetTarget(_target);
                Debug.Log(this + "нашел врага" + _target);
            }
        }

        private bool IsTargetInSight(Transform target)//
        {
            return Distance(target.transform) < _sightDistance;
        }

        private bool IsTargetInAttackRange(Transform target)
        {
            return Distance(target.transform) < _attackRange;
        }

        private float Distance(Transform target)
        {
            return Vector3.Distance(transform.position, target.position);
        }

        public Transform FindNearestTarget()
        {
            return GameManager.instance._aiAssistant.GetAllUnits().OrderBy(x => Distance(x.transform)).FirstOrDefault(x => IsEnemy(x)).transform;
        }

        private bool IsEnemy(Unit target)
        {
            return target._unitType != this._unitType;
        }

        private IEnumerator WaitAndSeek(float delay)
        {
            while (true)
            {
                yield return new WaitForSeconds(delay);
            }
        }
    }
}