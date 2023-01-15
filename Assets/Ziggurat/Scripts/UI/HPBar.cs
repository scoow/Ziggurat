using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Ziggurat
{
    public class HPBar : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _hpText;
        private Canvas _canvas;
        [SerializeField]
        private Image _image;
        private float _maxHP;
        private void Awake()
        {
            _canvas = GetComponent<Canvas>();
            _canvas.enabled = GameManager.instance.AIAssistant.HPBarEnabled;
        }
        public void SetHP(float value)
        {
            _hpText.text = value.ToString();
            _image.fillAmount= value/_maxHP;
        }
        public void SetMaxHP(float value)
        {
            _maxHP = value;
            _image.fillAmount = 1;
            _hpText.text = _maxHP.ToString();
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