using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

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
            //_canvasRenderer.SetMesh.
            //ReadStats();

            
        }

        public void ReadStats(UnitType unitType)
        {
            _unitsStats = GameManager.instance._configurationAssistant.ReadCurrentUnitStats(unitType);
        }

        public void HideOrShow()
        {
            _canvas.gameObject.SetActive(!gameObject.activeSelf);
            UpdateStatsMenu();
        }

        public void UpdateStatsMenu()
        {
            _UnitTypeText.text = "UnitType " + _unitsStats.UnitType;
            _hpText.text = "Health " + _unitsStats.Health;
            _MovementSpeedText.text = "MovementSpeed " + _unitsStats.MovementSpeed;
            _FastAttackDamageText.text = "FastAttackDamage " + _unitsStats.FastAttackDamage;
            _StrongAttackDamageText.text = "StrongAttackDamage " + _unitsStats.StrongAttackDamage;
            _MissChanceText.text = "MissChance " + _unitsStats.MissChance;
            _CritChanceText.text = "CritChance " + _unitsStats.CritChance;
            _FastOrStrongAttackChanceText.text = "FastOrStrongAttackChance " + _unitsStats.FastOrStrongAttackChance;
        }
    }
}