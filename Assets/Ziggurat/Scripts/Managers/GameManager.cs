using System.Collections.Generic;
using System.Linq;
using UnityEngine;
//using Zenject;

namespace Ziggurat
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public Dictionary<UnitType, UnitPool> _unitPool = new();
        public Transform _unitsContainer;

        private List<UnitSpawner> _unitSpawners= new();
        private Transform _blueUnitSpawner;
        private Transform _greenUnitSpawner;
        private Transform _redUnitSpawner;

        [SerializeField]
        private Material _redUnitMaterial;
        [SerializeField]
        private Material _greenUnitMaterial;
        [SerializeField]
        public Material _blueUnitMaterial;

        private List<UnitsStats> _unitsStats = new();//

        private void Awake()
        {
            instance = this;
        }
        private void Start()
        {
            _unitsContainer = FindObjectOfType<UnitsContainer>().transform;

            _unitSpawners = FindObjectsOfType<UnitSpawner>().ToList();
            _blueUnitSpawner = _unitSpawners.First(x => x.SpawnerType == UnitType.Blue).transform;
            _greenUnitSpawner  = _unitSpawners.First(x => x.SpawnerType == UnitType.Green).transform;
            _redUnitSpawner = _unitSpawners.First(x => x.SpawnerType == UnitType.Red).transform;

            InitUnitsPools();
        }

        private void InitUnitsPools()
        {
            _unitPool.Add(UnitType.Blue, new(Resources.Load<Unit>("Model/RPGHeroPolyart_nav_blue"), _unitsContainer));
            _unitPool.Add(UnitType.Green, new(Resources.Load<Unit>("Model/RPGHeroPolyart_nav_green"), _unitsContainer));
            _unitPool.Add(UnitType.Red, new(Resources.Load<Unit>("Model/RPGHeroPolyart_nav_red"), _unitsContainer));

        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _unitPool[UnitType.Blue].GetAviableOrCreateNew(_blueUnitSpawner);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                _unitPool[UnitType.Green].GetAviableOrCreateNew(_greenUnitSpawner);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                _unitPool[UnitType.Red].GetAviableOrCreateNew(_redUnitSpawner);
            }
        }
    }
}