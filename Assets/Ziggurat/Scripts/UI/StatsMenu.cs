using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Ziggurat
{
    public class StatsMenu : MonoBehaviour
    {
        private UnitsStats _unitsStatsInMenu;
        private Canvas _canvas;
        private Image _image;
        private Vector3 _startPosition;
        private Vector3 _endPosition;

        [SerializeField]
        private TMP_InputField _UnitTypeText;
        [SerializeField]
        private TMP_InputField _hpText;
        [SerializeField]
        private TMP_InputField _MovementSpeedText;
        [SerializeField]
        private TMP_InputField _FastAttackDamageText;
        [SerializeField]
        private TMP_InputField _StrongAttackDamageText;
        [SerializeField]
        private TMP_InputField _MissChanceText;
        [SerializeField]
        private TMP_InputField _CritChanceText;
        [SerializeField]
        private TMP_InputField _FastOrStrongAttackChanceText;
        private void Start()
        {
            _canvas = GetComponent<Canvas>();
            _image = GetComponentInChildren<Image>();
            _startPosition = _image.rectTransform.position;
            _endPosition = _startPosition;
            _endPosition += new Vector3(0f, -_image.rectTransform.sizeDelta.y, 0f);
        }
        public void ReadStats(UnitType unitType)
        {
            _unitsStatsInMenu = GameManager.instance.ConfigurationAssistant.ReadCurrentUnitStats(unitType);
        }

        public void Hide()
        {
            StartCoroutine(SmoothMenuOpen(_startPosition, _endPosition, 2f));
        }
        public void Show()
        {
            StartCoroutine(SmoothMenuOpen(_endPosition, _startPosition, 2f));
            UpdateStatsMenu();
        }
        private void UpdateStatsMenu()
        {
            _UnitTypeText.text = _unitsStatsInMenu.UnitType.ToString();
            _hpText.text = _unitsStatsInMenu.Health.ToString();
            _MovementSpeedText.text = _unitsStatsInMenu.MovementSpeed.ToString();
            _FastAttackDamageText.text = _unitsStatsInMenu.FastAttackDamage.ToString();
            _StrongAttackDamageText.text = _unitsStatsInMenu.StrongAttackDamage.ToString();
            _MissChanceText.text = _unitsStatsInMenu.MissChance.ToString();
            _CritChanceText.text = _unitsStatsInMenu.CritChance.ToString();
            _FastOrStrongAttackChanceText.text = _unitsStatsInMenu.FastOrStrongAttackChance.ToString();
        }
        public void OnValueChanged_EDITOR()
        {
            try
            {
                UnitsStats newStats = ScriptableObject.CreateInstance<UnitsStats>();
                newStats.Init(_unitsStatsInMenu.UnitType,
                                                     float.Parse(_hpText.text),
                                                     float.Parse(_MovementSpeedText.text),
                                                     float.Parse(_FastAttackDamageText.text),
                                                     float.Parse(_StrongAttackDamageText.text),
                                                     float.Parse(_MissChanceText.text),
                                                     float.Parse(_CritChanceText.text),
                                                     float.Parse(_FastOrStrongAttackChanceText.text));
                GameManager.instance.ConfigurationAssistant.RewriteCurrentUnitStats(_unitsStatsInMenu.UnitType, newStats);
            }
            catch (FormatException)
            {
                Debug.LogError("Неправильные значения");
            }
        }
        public IEnumerator SmoothMenuOpen(Vector3 startPosition, Vector3 endPosition, float time)
        {
            float currentTime = 0f;

            while (currentTime < time)
            {
                _image.transform.position = Vector3.Lerp(startPosition, endPosition, currentTime / time);
                currentTime += Time.deltaTime;
                yield return null;
            }
            _image.transform.position = endPosition;
        }
    }
}