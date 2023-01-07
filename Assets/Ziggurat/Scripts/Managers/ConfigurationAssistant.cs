using RotaryHeart.Lib.SerializableDictionary;
using System.Collections.Generic;
using UnityEngine;
using Ziggurat;

public class ConfigurationAssistant : MonoBehaviour
{
    /// <summary>
    /// Словарь с настройками статов для юнитов по-умолчанию, задаются в ScriptableObject в папке Ziggurat/Resources
    /// </summary>
    [SerializeField] private SerializableDictionaryBase<UnitType, UnitsStats> _defaultUnitsStats;
    /// <summary>
    /// Словарь с действующими настройками статов для юнитов
    /// </summary>
    private Dictionary<UnitType, UnitsStats> _currentUnitsStats = new();

    private void Start()
    {
        _currentUnitsStats = _defaultUnitsStats.Clone();
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