using RotaryHeart.Lib.SerializableDictionary;
using System.Collections.Generic;
using UnityEngine;
using Ziggurat;

public class ConfigurationAssistant : MonoBehaviour
{
    /// <summary>
    /// ������� � ����������� ������ ��� ������ ��-���������, �������� � ScriptableObject � ����� Ziggurat/Resources
    /// </summary>
    [SerializeField] private SerializableDictionaryBase<UnitType, UnitsStats> _defaultUnitsStats;
    /// <summary>
    /// ������� � ������������ ����������� ������ ��� ������
    /// </summary>
    private Dictionary<UnitType, UnitsStats> _currentUnitsStats = new();

    private void Start()
    {
        _currentUnitsStats = _defaultUnitsStats.Clone();
    }
    /// <summary>
    /// ������ ������ ����� �� ���������
    /// </summary>
    /// <param name="unitType">��� �����</param>
    /// <returns>UnitsStats ��� ����������� ���� �����</returns>
    public UnitsStats ReadCurrentUnitStats(UnitType unitType)
    {
        return _currentUnitsStats[unitType];
    }
    /// <summary>
    /// ���������� ������ ����� � ���������
    /// </summary>
    /// <param name="unitType">��� �����</param>
    /// <param name="unitsStats">����� �����</param>
    public void RewriteCurrentUnitStats(UnitType unitType, UnitsStats unitsStats)
    {
        _currentUnitsStats[unitType] = unitsStats;
    }
}