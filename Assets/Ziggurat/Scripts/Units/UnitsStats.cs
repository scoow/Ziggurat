using UnityEngine;

namespace Ziggurat
{
    [CreateAssetMenu(fileName = "New Configuration", menuName = "UnitStats")]
    public class UnitsStats : ScriptableObject
    {
        /// <summary>
        /// ��� �����
        /// </summary>
        private UnitType _unitType;
        /// <summary>
        /// ��������
        /// </summary>
        private float _health;
        /// <summary>
        /// �������� �����������
        /// </summary>
        private float _movementSpeed;
        /// <summary>
        /// ���� �� ������ �����
        /// </summary>
        private float _fastAttackDamage;
        /// <summary>
        /// ���� �� ��������� �����
        /// </summary>
        private float _strongAttackDamage;
        /// <summary>
        /// ����������� �������
        /// </summary>
        private float _missChance;
        /// <summary>
        /// ����������� ����������� �����
        /// </summary>
        private float _critChance;
        /// <summary>
        /// ���������� ����������� ����������� ������ � ������� ����
        /// </summary>
        private float _fastOrStrongAttackChance;

        public UnitsStats GetStats()
        {
            UnitsStats result = new UnitsStats();
            result._unitType= _unitType;
            result._health= _health;
            result._movementSpeed= _movementSpeed;
            result._fastAttackDamage= _fastAttackDamage;
            result._strongAttackDamage= _strongAttackDamage;
            result._missChance= _missChance;
            result._critChance= _critChance;
            result._fastOrStrongAttackChance = _fastOrStrongAttackChance;
            return result;
        }
    }
}