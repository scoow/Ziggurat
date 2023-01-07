using UnityEngine;
//using Zenject;

namespace Ziggurat
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        public SpawnAssistant _spawnAssistant;
        public ConfigurationAssistant _configurationAssistant;
        public AIAssistant _aiAssistant;//


        private void Awake()
        {
            instance = this;
        }
        private void Start()
        {
            _spawnAssistant = GetComponent<SpawnAssistant>();
            _configurationAssistant = GetComponent<ConfigurationAssistant>();
            _aiAssistant = GetComponent<AIAssistant>();
        }
    }
}