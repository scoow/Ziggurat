using UnityEngine;
//using Zenject;


/*TODO
 * 1. Добавить распознавание удара мечем DONE
 * 2. Добавить рассчёт ХП и смерть DONE
 * 3. Добавить влияние остальных характеристик на поведение DONE
 * 4. Переделать пул
 * 5. Оптимизировать всё
 * 6. Добавить UI, его связь со статами
 * 7. Поиграться со слоями
 * 8. Сделать точку сбора
 * 
 * 
 * Дополнительные требования

Расширить возможности игрока, добавив дополнительную панель управления, на которой:
Кнопка “Убить всех” - уничтожает всех живых юнитов;
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

        public SpawnAssistant _spawnAssistant;
        public ConfigurationAssistant _configurationAssistant;
        public AIAssistant _aiAssistant;//
        public UIAssistant _uiAssistant;

        private void Awake()
        {
            instance = this;
        }
        private void OnEnable()
        {
            _spawnAssistant = GetComponent<SpawnAssistant>();
            _configurationAssistant = GetComponent<ConfigurationAssistant>();
            _aiAssistant = GetComponent<AIAssistant>();
            _uiAssistant = GetComponent<UIAssistant>();
        }
    }
}