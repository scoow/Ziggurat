using UnityEngine;

namespace Ziggurat
{
    public class UnitSpawner : MonoBehaviour
    {
        [SerializeField]
        private UnitType _spawnerType;
        public UnitType SpawnerType => _spawnerType;
    }
}