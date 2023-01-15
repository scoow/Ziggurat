using UnityEngine;

namespace Ziggurat
{
    public class UIAssistant : MonoBehaviour
    {
        [SerializeField]
        private StatsMenu _statsMenu;
        private void Start()
        {
            _statsMenu= FindObjectOfType<StatsMenu>();
        }
        public void OpenMenu(UnitType unitType)
        {
            _statsMenu.ReadStats(unitType);
            _statsMenu.Show();
        }
    }
}