using UnityEngine;
//using Zenject;


/*TODO
 * 1. Добавить распознавание удара мечем DONE
 * 2. Добавить рассчёт ХП и смерть DONE
 * 3. Добавить влияние остальных характеристик на поведение DONE
 * 4. Оптимизировать всё
 * 5. Добавить UI, его связь со статами DONE
 * 
 * 
 * Дополнительные требования

Расширить возможности игрока, добавив дополнительную панель управления, на которой:
Кнопка “Убить всех” - уничтожает всех живых юнитов; DONE
Кнопка “Отобразить здоровье” - открывает/скрывает шкалы здоровья над каждым юнитом.
Добавить логику блуждания для ботов, в случае, если в центре карты нет противников;
Добавить панель со статистикой по Зиккуратам:
Количество живых юнитов;
Количество убитых юнитов;
Оставшееся время до создания нового юнита;
Кнопка “Очистить” - сбрасывающая счетчик убитых юнитов.
 */

namespace Ziggurat
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        private ConfigurationAssistant _configurationAssistant;
        public ConfigurationAssistant ConfigurationAssistant => _configurationAssistant;
        private SpawnAssistant _spawnAssistant;
        public SpawnAssistant SpawnAssistant => _spawnAssistant;
        private AIAssistant _aiAssistant;
        public AIAssistant AIAssistant => _aiAssistant;
        private UIAssistant _uiAssistant;
        public UIAssistant UIAssistant => _uiAssistant;
        private AnimationAssistant _animationAssistant;
        public AnimationAssistant AnimationAssistant => _animationAssistant;
        private CameraController _cameraController;
        public CameraController CameraController => _cameraController;
        private void Awake()
        {
            instance = this;
        }
        private void OnEnable()
        {
            _configurationAssistant = GetComponent<ConfigurationAssistant>();

            _spawnAssistant = GetComponent<SpawnAssistant>();
           
            _aiAssistant = GetComponent<AIAssistant>();

            _uiAssistant = GetComponent<UIAssistant>();

            _animationAssistant= GetComponent<AnimationAssistant>();

            _cameraController = FindObjectOfType<CameraController>();
        }
    }
}