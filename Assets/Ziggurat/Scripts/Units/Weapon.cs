using UnityEngine;

namespace Ziggurat
{
    public class Weapon : MonoBehaviour
    {
        private Unit _owner;
        private void Start()
        {
            _owner = transform.parent.GetComponentInParent<Unit>();
        }
        private void OnTriggerEnter(Collider other)
        {
            _owner.WeaponTriggerDetected(this);
/*
            if (HitEnemyUnit(other))
                Debug.Log("SWORD");*/
        }

        private bool HitEnemyUnit(Collider unit)
        {
            Unit target = unit.GetComponentInParent<Unit>();
            bool targetIsEnemy = _owner._unitType != target._unitType;

            return targetIsEnemy;
        }
    }
}
