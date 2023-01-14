using UnityEngine;
using UnityEngine.EventSystems;

namespace Ziggurat
{
    public class UnitUI : MonoBehaviour, IPointerDownHandler
    {
        private Unit _unit;
        private void OnEnable()
        {
            _unit = GetComponent<Unit>();
        }
        public void OnPointerDown(PointerEventData eventData) => GameManager.instance.UIAssistant.OpenMenu(_unit.UnitType);
    }
}