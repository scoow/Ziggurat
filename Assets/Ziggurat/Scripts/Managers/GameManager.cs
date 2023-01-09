using UnityEngine;
//using Zenject;


/*TODO
 * 1. Добавить распознавание удара мечем
 * 2. Добавить рассчёт ХП и смерть
 * 3. Добавить влияние остальных характеристик на поведение
 * 4. Переделать пул
 * 5. Оптимизировать всё
 * 6. Добавить UI, его связь со статами
 */

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
        private void OnEnable()
        {
            _spawnAssistant = GetComponent<SpawnAssistant>();
            _configurationAssistant = GetComponent<ConfigurationAssistant>();
            _aiAssistant = GetComponent<AIAssistant>();
        }
    }
}