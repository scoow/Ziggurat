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
        /// <summary>
        /// здоровье
        /// </summary>
        [SerializeField] private float _health;
        /// <summary>
        /// скорость перемещения
        /// </summary>
        [SerializeField] private float _movementSpeed;
        /// <summary>
        /// урон от слабой атаки
        /// </summary>
        [SerializeField] private float _fastAttackDamage;
        /// <summary>
        /// урон от медленной атаки
        /// </summary>
        [SerializeField] private float _strongAttackDamage;
        /// <summary>
        /// вероятность промаха
        /// </summary>
        [SerializeField] private float _missChance;
        /// <summary>
        /// вероятность двукратного урона
        /// </summary>
        [SerializeField] private float _critChance;
        /// <summary>
        /// процентное соотношение вероятности слабой и сильной атак
        /// </summary>
        [SerializeField] private float _fastOrStrongAttackChance;
    }
}