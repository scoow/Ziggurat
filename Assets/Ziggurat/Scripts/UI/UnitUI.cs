using UnityEngine;
using UnityEngine.EventSystems;

namespace Ziggurat
{
    public class UnitUI : MonoBehaviour
    {
        private Unit _unit;
        private void OnEnable()
        {
            _unit = GetComponent<Unit>();
        }
        public void OnPointerDown(PointerEventData _) => GameManager.instance.UIAssistant.OpenMenu(_unit.UnitType);
    }
}