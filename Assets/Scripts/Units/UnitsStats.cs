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
    }
}