using TMPro;
using UnityEngine;

namespace Ziggurat
{
    public class HPBar : MonoBehaviour
    {
        private TextMeshProUGUI _hpText;//todo уменьшение полосы
        private HPBarImage _hpBar;

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
        private void Update()
        {
            transform.LookAt(GameManager.instance.CameraController.transform.position);
        }
    }
}