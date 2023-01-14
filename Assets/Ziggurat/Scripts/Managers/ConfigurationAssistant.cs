using RotaryHeart.Lib.SerializableDictionary;
using System.Collections.Generic;
using UnityEngine;

namespace Ziggurat
{
    /// <summary>
    /// ����� ��� ���������� ������������� ������
    /// </summary>
    public class ConfigurationAssistant : MonoBehaviour
    {
        /// <summary>
        /// ������� � ����������� ������ ��� ������ ��-���������, �������� � ScriptableObject � ����� Ziggurat/Resources
        /// </summary>
        [SerializeField] private SerializableDictionaryBase<UnitType, UnitsStats> _defaultUnitsStats;
        /// <summary>
        /// ������� � ������������ ����������� ������ ��� ������
        /// </summary>
        private Dictionary<UnitType, UnitsStats> _currentUnitsStats;
        /// <summary>
        /// ��������� ��-��������� �������� �����������, �������� �� �����
        /// </summary>
        private void Awake()
        {
            _currentUnitsStats = new(_defaultUnitsStats);
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
}