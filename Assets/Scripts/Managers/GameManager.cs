using System.Collections.Generic;
using UnityEngine;
//using Zenject;

namespace Ziggurat
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public Dictionary<UnitType, UnitPool> _unitPool = new();
        public Transform _unitsContainer;

        private void Awake()
        {
            instance = this;
        }
        private void Start()
        {
            _unitsContainer = FindObjectOfType<UnitsContainer>().transform;
            InitUnitsPools();
        }

        private void InitUnitsPools()
        {
            _unitPool.Add(UnitType.Blue, new(Resources.Load<Unit>("Model/RPGHeroPolyart_nav"), _unitsContainer, 5));
            _unitPool.Add(UnitType.Green, new(Resources.Load<Unit>("Model/RPGHeroPolyart_nav"), _unitsContainer, 5));
            _unitPool.Add(UnitType.Red, new(Resources.Load<Unit>("Model/RPGHeroPolyart_nav"), _unitsContainer, 5));
        }
    }
}