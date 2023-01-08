using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace Ziggurat
{
    public class AIAssistant : MonoBehaviour
    {
        private List<Unit> _activeUnits;

        private void Start()
        {
            _activeUnits = new List<Unit>();
            CreateListOfActiveUnitsInPool();
        }

        private void CreateListOfActiveUnitsInPool()
        {
            _activeUnits = GameManager.instance._spawnAssistant._unitPool[UnitType.Blue].GetActiveUnits();
            _activeUnits.AddRange(GameManager.instance._spawnAssistant._unitPool[UnitType.Green].GetActiveUnits());
            _activeUnits.AddRange(GameManager.instance._spawnAssistant._unitPool[UnitType.Red].GetActiveUnits());
        }

        public List<Unit> GetAllUnits()
        {
            CreateListOfActiveUnitsInPool();
            return _activeUnits;
        }

    }
}
