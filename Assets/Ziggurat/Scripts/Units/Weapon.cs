using UnityEngine;

namespace Ziggurat
{
    public class Weapon : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            transform.parent.GetComponentInParent<Unit>().WeaponTriggerDetected(this);
            Debug.Log("SWORD");
        }
    }
}
