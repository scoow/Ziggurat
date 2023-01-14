using System;
using TMPro;
using UnityEngine;

namespace Ziggurat
{
    public class StatsMenu : MonoBehaviour
    {
        private UnitsStats _unitsStatsInMenu;
        private Canvas _canvas;

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
        [SerializeField]

        private void Start()
        {
            _canvas = GetComponent<Canvas>();
            _canvas.enabled= false;
        }
        public void ReadStats(UnitType unitType)
        {
            _unitsStatsInMenu = GameManager.instance.ConfigurationAssistant.ReadCurrentUnitStats(unitType);
        }

        public void Hide()
        {
            _canvas.enabled = false;
        }
        public void Show()
        {
            UpdateStatsMenu();

            _canvas.enabled = true;
        }

        private void UpdateStatsMenu()
        {
            _UnitTypeText.text = _unitsStatsInMenu.UnitType.ToString();
            _hpText.text =  _unitsStatsInMenu.Health.ToString();
            _MovementSpeedText.text =  _unitsStatsInMenu.MovementSpeed.ToString();
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
    }
}