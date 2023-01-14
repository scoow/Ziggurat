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
        public UnitType UnitType => _unitType;
        /// <summary>
        /// ��������
        /// </summary>
        [SerializeField] private float _health;
        public float Health => _health;
        /// <summary>
        /// �������� �����������
        /// </summary>
        [SerializeField] private float _movementSpeed;
        public float MovementSpeed => _movementSpeed;
        /// <summary>
        /// ���� �� ������ �����
        /// </summary>
        [SerializeField] private float _fastAttackDamage;
        public float FastAttackDamage => _fastAttackDamage;
        /// <summary>
        /// ���� �� ��������� �����
        /// </summary>
        [SerializeField] private float _strongAttackDamage;
        public float StrongAttackDamage => _strongAttackDamage;
        /// <summary>
        /// ����������� �������
        /// </summary>
        [SerializeField] private float _missChance;
        public float MissChance => _missChance;
        /// <summary>
        /// ����������� ����������� �����
        /// </summary>
        [SerializeField] private float _critChance;
        public float CritChance => _critChance;
        /// <summary>
        /// ���������� ����������� ����������� ������ � ������� ����
        /// </summary>
        [SerializeField] private float _fastOrStrongAttackChance;
        public float FastOrStrongAttackChance => _fastOrStrongAttackChance;

        public void Init(UnitType unitType, float health, float movementSpeed, float fastAttackDamage, float strongAttackDamage, float missChance, float critChance, float fastOrStrongAttackChance)
        {
            _unitType= unitType;
            _health= health;
            _movementSpeed= movementSpeed;
            _fastAttackDamage= fastAttackDamage;
            _strongAttackDamage= strongAttackDamage;
            _missChance= missChance;
            _critChance= critChance;
            _fastOrStrongAttackChance = fastOrStrongAttackChance;
        }
    }
}