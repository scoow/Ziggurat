using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Ziggurat
{
    public class AIAssistant : MonoBehaviour
    {
        private List<Unit> _activeUnits;
        private Transform _defaultTarget;
        public Transform DefaultTarget => _defaultTarget;
        private bool _hpBarEnabled = true;

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
            CreateListOfActiveUnitsInPool();
            return _activeUnits;
        }
        /// <summary>
        /// Убить всех юнитов
        /// </summary>
        public void KillAll_EDITOR()
        {
            CreateListOfActiveUnitsInPool();
            foreach (Unit unit in _activeUnits)
            {
                unit.Death();
            }
            _activeUnits.Clear();
        }
        /// <summary>
        /// Показать или скрыть полоску HP
        /// </summary>
        public void ShowOrHideHPBar_EDITOR()
        {
            foreach (HPBar hPBar in FindObjectsOfType<HPBar>().ToList())
            {
                if (_hpBarEnabled)
                    hPBar.Disable();                  
                else
                    hPBar.Enable();
            }
            _hpBarEnabled = !_hpBarEnabled;
        }
    }
}