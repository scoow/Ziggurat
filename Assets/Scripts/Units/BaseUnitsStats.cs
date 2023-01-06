using UnityEngine;

namespace Ziggurat
{
    public class BaseUnitsStats : ScriptableObject
    {
        /// <summary>
        /// ��������
        /// </summary>
        public float Health { get; set; }
        /// <summary>
        /// �������� �����������
        /// </summary>
        public float MovementSpeed { get; set; }
        /// <summary>
        /// ���� �� ������ �����
        /// </summary>
        public float FastAttackDamage { get; set; }
        /// <summary>
        /// ���� �� ��������� �����
        /// </summary>
        public float StrongAttackDamage { get; set; }
        /// <summary>
        /// ����������� �������
        /// </summary>
        public float MissChance { get; set; }
        /// <summary>
        /// ����������� ����������� �����
        /// </summary>
        public float CritChance { get; set; }
        /// <summary>
        /// ���������� ����������� ����������� ������ � ������� ����
        /// </summary>
        public float FastOrStrongAttackChance { get; set; }
    }
}