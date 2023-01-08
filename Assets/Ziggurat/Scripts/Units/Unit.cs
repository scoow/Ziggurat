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
        private void OnEnable()
        {

            //todo исправить _stats = GameManager.instance._configurationAssistant.ReadCurrentUnitStats(_unitType);
            //StartCoroutine(WaitAndSeek(3f));

        }
        private void Start()
        {
            _unitMovement = GetComponent<UnitMovement>();
            //_stats = GetComponent<UnitsStats>();

        }
        private void Update()
        {
            _target = FindNearestTarget();
            _unitMovement.SetTarget(_target);
        }

        private bool IsTargetInSight(Transform target)//
        {
            //return (this.transform.position + target).magnitude < _sightDistance;
            return Distance(target.transform) < _sightDistance;
        }

        private float Distance(Transform target)
        {
            return Vector3.Distance(transform.position, target.position);
        }

        public Transform FindNearestTarget()//todo вынести в другой класс
        {
            /*var minDistance = GameManager.instance._aiAssistant.GetAllUnits.Except(new List<Unit>() { this }).Min(x => Distance(x.transform)); //todo проверка на дружественность
            return GameManager.instance._aiAssistant.GetAllUnits.Except(new List<Unit>() { this }).FirstOrDefault(x => Distance(x.transform) <= minDistance).transform ?? transform;*/
            //var minDistance = GameManager.instance._aiAssistant.GetAllUnits.Except(new List<Unit>().Where(x => x._unitType == this._unitType)).Min(x => Distance(x.transform)); //todo проверка на дружественность
            // return GameManager.instance._aiAssistant.GetAllUnits.Except(new List<Unit>().Where(x => x._unitType == this._unitType)).Min(x => Distance(x.transform));// ?? transform;
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