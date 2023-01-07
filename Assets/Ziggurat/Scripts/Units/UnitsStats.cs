using UnityEngine;

namespace Ziggurat
{
    [CreateAssetMenu(fileName = "New Configuration", menuName = "UnitStats")]
    public class UnitsStats : ScriptableObject
    {
        /// <summary>
        /// тип юнита
        /// </summary>
        private UnitType _unitType;
        /// <summary>
        /// здоровье
        /// </summary>
        private float _health;
        /// <summary>
        /// скорость перемещения
        /// </summary>
        private float _movementSpeed;
        /// <summary>
        /// урон от слабой атаки
        /// </summary>
        private float _fastAttackDamage;
        /// <summary>
        /// урон от медленной атаки
        /// </summary>
        private float _strongAttackDamage;
        /// <summary>
        /// вероятность промаха
        /// </summary>
        private float _missChance;
        /// <summary>
        /// вероятность двукратного урона
        /// </summary>
        private float _critChance;
        /// <summary>
        /// процентное соотношение вероятности слабой и сильной атак
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