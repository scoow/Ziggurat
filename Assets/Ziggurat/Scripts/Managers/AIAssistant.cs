using System.Collections.Generic;
using UnityEngine;

namespace Ziggurat
{
    public class AIAssistant : MonoBehaviour
    {
        private List<Unit> _activeUnits;
        private Transform _defaultTarget;
        public Transform DefaultTarget => _defaultTarget;
        private bool _hpBarEnabled;
        public bool HPBarEnabled => _hpBarEnabled;

        private void Awake()
        {
            _defaultTarget = FindObjectOfType<UnitsContainer>().transform;
            _activeUnits = new List<Unit>();
            _hpBarEnabled = false;
        }
        public void AddUnitToList(Unit unit)
        {
            _activeUnits.Add(unit);
        }
        public void RemoveUnitFromList(Unit unit)
        {
            _activeUnits.Remove(unit);
        }
        /// <summary>
        /// Получение списка активных юнитов
        /// </summary>
        /// <returns>список</returns>
        public List<Unit> GetAllUnits()
        {
            return _activeUnits;
        }
        /// <summary>
        /// Убить всех юнитов
        /// </summary>
        public void KillAll()
        {
            List<Unit> units = new(_activeUnits);
            foreach (Unit unit in units)
            {
                unit.Death();
            }
        }
        /// <summary>
        /// Показать или скрыть полоску HP
        /// </summary>
        public void ShowOrHideHPBar()
        {
            List<Unit> units = new(_activeUnits);
            foreach (Unit unit in units)
            {
                if (_hpBarEnabled)
                    unit.HPBar.Disable();
                else
                    unit.HPBar.Enable();
            }
            _hpBarEnabled = !_hpBarEnabled;
        }
    }
}