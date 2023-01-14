using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace Ziggurat
{
    public class HPBar : MonoBehaviour
    {
        private TextMeshProUGUI _hpText;//todo уменьшение полосы
        private HPBarImage _hpBar;
        private Canvas _canvas;

        private void Awake()
        {
            _canvas = GetComponent<Canvas>();
            _hpBar = GetComponentInChildren<HPBarImage>();
            _hpText = GetComponentInChildren<TextMeshProUGUI>();
        }

        public void Enable()
        {
            _canvas.enabled = true;
        }
        public void Disable()
        {
            _canvas.enabled = false;
        }
        private void Update()
        {
            transform.LookAt(GameManager.instance.CameraController.transform.position);
        }
    }
}