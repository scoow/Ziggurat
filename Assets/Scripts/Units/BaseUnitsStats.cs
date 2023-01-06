using UnityEngine;

namespace Ziggurat
{
    public class BaseUnitsStats : ScriptableObject
    {
        /// <summary>
        /// здоровье
        /// </summary>
        public float Health { get; set; }
        /// <summary>
        /// скорость перемещения
        /// </summary>
        public float MovementSpeed { get; set; }
        /// <summary>
        /// урон от слабой атаки
        /// </summary>
        public float FastAttackDamage { get; set; }
        /// <summary>
        /// урон от медленной атаки
        /// </summary>
        public float StrongAttackDamage { get; set; }
        /// <summary>
        /// вероятность промаха
        /// </summary>
        public float MissChance { get; set; }
        /// <summary>
        /// вероятность двукратного урона
        /// </summary>
        public float CritChance { get; set; }
        /// <summary>
        /// процентное соотношение вероятности слабой и сильной атак
        /// </summary>
        public float FastOrStrongAttackChance { get; set; }
    }
}