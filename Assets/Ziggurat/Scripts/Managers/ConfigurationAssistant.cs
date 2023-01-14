using RotaryHeart.Lib.SerializableDictionary;
using System.Collections.Generic;
using UnityEngine;

namespace Ziggurat
{
    /// <summary>
    /// Класс для управления конфигурацией юнитов
    /// </summary>
    public class ConfigurationAssistant : MonoBehaviour
    {
        /// <summary>
        /// Словарь с настройками статов для юнитов по-умолчанию, задаются в ScriptableObject в папке Ziggurat/Resources
        /// </summary>
        [SerializeField] private SerializableDictionaryBase<UnitType, UnitsStats> _defaultUnitsStats;
        /// <summary>
        /// Словарь с действующими настройками статов для юнитов
        /// </summary>
        private Dictionary<UnitType, UnitsStats> _currentUnitsStats;
        /// <summary>
        /// Настройки по-умолчанию остаются неизменными, создаётся их копия
        /// </summary>
        private void Awake()
        {
            _currentUnitsStats = new(_defaultUnitsStats);
        }
        /// <summary>
        /// Чтение статов юнита из хранилища
        /// </summary>
        /// <param name="unitType">тип юнита</param>
        /// <returns>UnitsStats для конкретного типа юнита</returns>
        public UnitsStats ReadCurrentUnitStats(UnitType unitType)
        {
            return _currentUnitsStats[unitType];
        }
        /// <summary>
        /// Перезапись статов юнита в хранилище
        /// </summary>
        /// <param name="unitType">тип юнита</param>
        /// <param name="unitsStats">новые статы</param>
        public void RewriteCurrentUnitStats(UnitType unitType, UnitsStats unitsStats)
        {
            _currentUnitsStats[unitType] = unitsStats;
        }
    }
}