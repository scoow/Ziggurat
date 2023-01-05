using System.Collections.Generic;
using UnityEngine;
//using Zenject;

namespace Ziggurat
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public Dictionary<UnitType, UnitPool> _enemyPool = new();

        private void Awake()
        {
            instance = this;
        }
        private void Start()
        {
            InitEnemyPools();
        }

        private void InitEnemyPools()
        {
           /* _enemyPool.Add(EnemyType.Simple, new(Resources.Load<SimpleEnemy>("Prefabs/SimpleEnemy"), _enemyContainer.transform, 5));
            _enemyPool.Add(EnemyType.Big, new(Resources.Load<BigEnemy>("Prefabs/BigEnemy"), _enemyContainer.transform, 2));*/
        }

    }
}