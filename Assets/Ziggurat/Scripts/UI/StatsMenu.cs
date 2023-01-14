using TMPro;
using UnityEngine;

namespace Ziggurat
{
    public class StatsMenu : MonoBehaviour
    {
        private UnitsStats _unitsStats;
        private Canvas _canvas;

        [SerializeField]
        private TextMeshProUGUI _UnitTypeText;
        [SerializeField]
        private TextMeshProUGUI _hpText;
        [SerializeField]
        private TextMeshProUGUI _MovementSpeedText;
        [SerializeField]
        private TextMeshProUGUI _FastAttackDamageText;
        [SerializeField]
        private TextMeshProUGUI _StrongAttackDamageText;
        [SerializeField]
        private TextMeshProUGUI _MissChanceText;
        [SerializeField]
        private TextMeshProUGUI _CritChanceText;
        [SerializeField]
        private TextMeshProUGUI _FastOrStrongAttackChanceText;
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
    }
}