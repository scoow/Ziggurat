using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Ziggurat
{
    public class HPBar : MonoBehaviour
    {
        private TextMeshProUGUI _hpText;
        private HPBarImage _hpBar;
        //private Image 

        private void Awake()
        {
            _hpBar = GetComponentInChildren<HPBarImage>();
            _hpText = GetComponentInChildren<TextMeshProUGUI>();
        }

        public void Enable()
        {
            this.enabled = true;
        }
        public void Disable()
        {
            this.enabled = false;
        }
        public void LookAt(Transform target)
        {

        }
    }
}