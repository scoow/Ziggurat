using UnityEngine;

namespace Ziggurat
{
    public class UnitSpawner : MonoBehaviour
    {
        [SerializeField]
        private UnitType _spawnetType;
        public UnitType SpawnerType => _spawnetType;

        private UnitsStats _stats;

        private float _respawnCoolDown;

        private void Start()
        {
           
        }

        private void SpawnUnit()
        {
            //todo вызывать спавн через менеджер по таймеру
        }
    }

}
