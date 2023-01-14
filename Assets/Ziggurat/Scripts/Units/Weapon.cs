using UnityEngine;

namespace Ziggurat
{
    public class Weapon : MonoBehaviour
    {
        private Unit _owner;//владелец оружия
        private void Start()
        {
            _owner = transform.parent.GetComponentInParent<Unit>();
        }
        private void OnTriggerEnter(Collider other)
        {
            _owner.WeaponTriggerDetected();
        }
    }
}