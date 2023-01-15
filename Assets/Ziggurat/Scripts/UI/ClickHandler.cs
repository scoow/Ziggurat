using UnityEngine;
using UnityEngine.EventSystems;

namespace Ziggurat
{
    public abstract class ClickHandler<T> :  MonoBehaviour, IPointerDownHandler where T : MonoBehaviour
    {
        protected T _object;
        protected UnitType _unitType;

        protected virtual void OnEnable()
        {
            _object = GetComponent<T>();
        }

        public void OnPointerDown(PointerEventData pointerEventData)
        {
            GameManager.instance.UIAssistant.OpenMenu(_unitType);
        }
    }
}