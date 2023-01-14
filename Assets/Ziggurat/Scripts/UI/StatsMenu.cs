using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Ziggurat
{
    public class StatsMenu : MonoBehaviour
    {
        private UnitsStats _unitsStats;
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
            //убрать меню при старте игры
           
        }

        public void ReadStats(UnitType unitType)
        {
            _unitsStats = GameManager.instance._configurationAssistant.ReadCurrentUnitStats(unitType);
        }

        public void HideOrShow()
        {
            _canvas.enabled = !_canvas.enabled;
            UpdateStatsMenu();
        }

        public void UpdateStatsMenu()
        {
            _UnitTypeText.text = _unitsStats.UnitType.ToString();
            _hpText.text =  _unitsStats.Health.ToString();
            _MovementSpeedText.text =  _unitsStats.MovementSpeed.ToString();
            _FastAttackDamageText.text = _unitsStats.FastAttackDamage.ToString();
            _StrongAttackDamageText.text = _unitsStats.StrongAttackDamage.ToString();
            _MissChanceText.text = _unitsStats.MissChance.ToString();
            _CritChanceText.text = _unitsStats.CritChance.ToString();
            _FastOrStrongAttackChanceText.text = _unitsStats.FastOrStrongAttackChance.ToString();
        }
        private void OnValueChanged()//event
        {
            UnitsStats newStats = new(_unitsStats.UnitType,
                                                 float.Parse(_hpText.text),
                                                 float.Parse(_MovementSpeedText.text),
                                                 float.Parse(_FastAttackDamageText.text),
                                                 float.Parse(_StrongAttackDamageText.text),
                                                 float.Parse(_MissChanceText.text),
                                                 float.Parse(_CritChanceText.text),
                                                 float.Parse(_FastOrStrongAttackChanceText.text));
            GameManager.instance._configurationAssistant.RewriteCurrentUnitStats(_unitsStats.UnitType, newStats);
        }
    }
}