using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Ziggurat
{
    public class SpawnAssistant : MonoBehaviour
    {
        /// <summary>
        /// Пул юнитов, разделенных по типу
        /// </summary>
        private Dictionary<UnitType, UnitPool> _unitPool = new();
        /// <summary>
        /// Родительский Transform для хранения юнитов
        /// </summary>
        private Transform _unitsContainer;

        /// <summary>
        /// Список зиккуратов
        /// </summary>
        private List<UnitSpawner> _unitSpawners = new();
        private Transform _blueUnitSpawner;
        private Transform _greenUnitSpawner;
        private Transform _redUnitSpawner;

        private void Start()
        {
            _unitsContainer = FindObjectOfType<UnitsContainer>().transform;

            _unitSpawners = FindObjectsOfType<UnitSpawner>().ToList();
            _blueUnitSpawner = _unitSpawners.First(x => x.SpawnerType == UnitType.Blue).transform;
            _greenUnitSpawner = _unitSpawners.First(x => x.SpawnerType == UnitType.Green).transform;
            _redUnitSpawner = _unitSpawners.First(x => x.SpawnerType == UnitType.Red).transform;

            InitUnitsPools();
        }
        /// <summary>
        /// Инициализация пула юнитов
        /// </summary>
        private void InitUnitsPools()
        {
            _unitPool.Add(UnitType.Blue, new(Resources.Load<Unit>("Model/RPGHeroPolyart_nav_blue"), UnitType.Blue, _unitsContainer));
            _unitPool.Add(UnitType.Green, new(Resources.Load<Unit>("Model/RPGHeroPolyart_nav_green"), UnitType.Green, _unitsContainer));
            _unitPool.Add(UnitType.Red, new(Resources.Load<Unit>("Model/RPGHeroPolyart_nav_red"), UnitType.Red, _unitsContainer));
        }
        /// <summary>
        /// Для теста - спавн на клавиши R G B
        /// </summary>
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                _unitPool[UnitType.Blue].GetAviableOrCreateNew(_blueUnitSpawner);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                _unitPool[UnitType.Green].GetAviableOrCreateNew(_greenUnitSpawner);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                _unitPool[UnitType.Red].GetAviableOrCreateNew(_redUnitSpawner);
            }
        }
        public void SpawnUnitOfType(UnitType unitType)
        {
            switch (unitType)
            {
                case UnitType.Blue:
                    _unitPool[UnitType.Blue].GetAviableOrCreateNew(_blueUnitSpawner);
                    break;
                case UnitType.Green:
                    _unitPool[UnitType.Green].GetAviableOrCreateNew(_greenUnitSpawner);
                    break;
                case UnitType.Red:
                    _unitPool[UnitType.Red].GetAviableOrCreateNew(_redUnitSpawner);
                    break;
                default:
                    break;
            }
        }
    }
}