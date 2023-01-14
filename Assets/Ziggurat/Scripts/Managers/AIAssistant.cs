using System.Collections.Generic;
using UnityEngine;

namespace Ziggurat
{
    public class AIAssistant : MonoBehaviour
    {
        private List<Unit> _activeUnits;
        private Transform _defaultTarget;
        public Transform DefaultTarget => _defaultTarget;

        private void Awake()
        {
            _defaultTarget = FindObjectOfType<UnitsContainer>().transform;
        }

        private void Start()
        {
            _activeUnits = new List<Unit>();
            CreateListOfActiveUnitsInPool();
        }
        /// <summary>
        /// Добавление живых активных юнитов в список
        /// </summary>
        private void CreateListOfActiveUnitsInPool()
        {
            _activeUnits = GameManager.instance.SpawnAssistant._unitPool[UnitType.Blue].GetActiveUnits();
            _activeUnits.AddRange(GameManager.instance.SpawnAssistant._unitPool[UnitType.Green].GetActiveUnits());
            _activeUnits.AddRange(GameManager.instance.SpawnAssistant._unitPool[UnitType.Red].GetActiveUnits());
        }

        public List<Unit> GetAllUnits()
        {
            CreateListOfActiveUnitsInPool();//todo событие при создании юнита в пуле или при смерти
            return _activeUnits;
        }
        public void KillAll()
        {
            CreateListOfActiveUnitsInPool();
            foreach (Unit unit in _activeUnits)
            {
                unit.Death();
            }
            _activeUnits.Clear();
        }
    }
}