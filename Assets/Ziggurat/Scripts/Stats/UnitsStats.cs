using UnityEngine;

namespace Ziggurat
{
    [CreateAssetMenu(fileName = "New Configuration", menuName = "UnitStats")]
    public class UnitsStats : ScriptableObject
    {
        /// <summary>
        /// тип юнита
        /// </summary>
        [SerializeField] private UnitType _unitType;
        public UnitType UnitType => _unitType;
        /// <summary>
        /// здоровье
        /// </summary>
        [SerializeField] private float _health;
        public float Health => _health;
        /// <summary>
        /// скорость перемещения
        /// </summary>
        [SerializeField] private float _movementSpeed;
        public float MovementSpeed => _movementSpeed;
        /// <summary>
        /// урон от слабой атаки
        /// </summary>
        [SerializeField] private float _fastAttackDamage;
        public float FastAttackDamage => _fastAttackDamage;
        /// <summary>
        /// урон от медленной атаки
        /// </summary>
        [SerializeField] private float _strongAttackDamage;
        public float StrongAttackDamage => _strongAttackDamage;
        /// <summary>
        /// вероятность промаха
        /// </summary>
        [SerializeField] private float _missChance;
        public float MissChance => _missChance;
        /// <summary>
        /// вероятность двукратного урона
        /// </summary>
        [SerializeField] private float _critChance;
        public float CritChance => _critChance;
        /// <summary>
        /// процентное соотношение вероятности слабой и сильной атак
        /// </summary>
        [SerializeField] private float _fastOrStrongAttackChance;
        public float FastOrStrongAttackChance => _fastOrStrongAttackChance;
    }
}