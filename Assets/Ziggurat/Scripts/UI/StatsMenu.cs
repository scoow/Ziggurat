using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

namespace Ziggurat
{
    public class StatsMenu : MonoBehaviour
    {
        private UnitsStats _unitsStats;
        private UnitType _currentUnitType;
        private CanvasRenderer _canvasRenderer;

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
            _canvasRenderer = GetComponent<CanvasRenderer>();
            //_canvasRenderer.SetMesh.
            _currentUnitType = UnitType.Blue;//todo
            _unitsStats = GameManager.instance._configurationAssistant.ReadCurrentUnitStats(_currentUnitType);

            UpdateStatsMenu();
        }
        public void UpdateStatsMenu()
        {
            _UnitTypeText.text += " " + _unitsStats.UnitType;
            _hpText.text += " " + _unitsStats.Health;
            _MovementSpeedText.text += " " + _unitsStats.MovementSpeed;
            _FastAttackDamageText.text += " " + _unitsStats.FastAttackDamage;
            _StrongAttackDamageText.text += " " + _unitsStats.StrongAttackDamage;
            _MissChanceText.text += " " + _unitsStats.MissChance;
            _CritChanceText.text += " " + _unitsStats.CritChance;
            _FastOrStrongAttackChanceText.text += " " + _unitsStats.FastOrStrongAttackChance;
        }
    }
}
