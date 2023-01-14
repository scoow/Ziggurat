using UnityEngine;

namespace Ziggurat
{
    public class UnitSpawner : MonoBehaviour
    {
        [SerializeField]
        private UnitType _spawnerType;
        public UnitType SpawnerType => _spawnerType;
        [SerializeField]
        private float _spawnCooldown;
        private float _spawnTime = 0;
        private void Update()
        {
            SpawnUnit();
        }

        private void SpawnUnit()
        {
            _spawnTime -= Time.deltaTime;
            if (_spawnTime < 0)
            {
                _spawnTime = _spawnCooldown;
                GameManager.instance.SpawnAssistant.SpawnUnitOfType(_spawnerType);
            }
        }
    }
}