using UnityEngine;

namespace Ziggurat
{
    [CreateAssetMenu(fileName = "New Configuration", menuName = "UnitStats")]
    public class UnitsStats : ScriptableObject
    {
        /// <summary>
        /// ��� �����
        /// </summary>
        [SerializeField] private UnitType _unitType;
        /// <summary>
        /// ��������
        /// </summary>
        [SerializeField] private float _health;
        /// <summary>
        /// �������� �����������
        /// </summary>
        [SerializeField] private float _movementSpeed;
        /// <summary>
        /// ���� �� ������ �����
        /// </summary>
        [SerializeField] private float _fastAttackDamage;
        /// <summary>
        /// ���� �� ��������� �����
        /// </summary>
        [SerializeField] private float _strongAttackDamage;
        /// <summary>
        /// ����������� �������
        /// </summary>
        [SerializeField] private float _missChance;
        /// <summary>
        /// ����������� ����������� �����
        /// </summary>
        [SerializeField] private float _critChance;
        /// <summary>
        /// ���������� ����������� ����������� ������ � ������� ����
        /// </summary>
        [SerializeField] private float _fastOrStrongAttackChance;
    }
}