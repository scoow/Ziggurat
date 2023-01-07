using System.Collections.Generic;
using System.Linq;
using UnityEngine;
//using Zenject;

namespace Ziggurat
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        private SpawnAssistant _spawnAssistant;

        private List<UnitsStats> _unitsStats = new();//

        private void Awake()
        {
            instance = this;
        }
        private void Start()
        {

        }


    }
}