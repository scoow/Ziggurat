using UnityEngine;
using UnityEngine.EventSystems;

namespace Ziggurat
{
    [RequireComponent(typeof(UnitSpawner))]
    public class SpawnerUI : MonoBehaviour, IPointerDownHandler
    {
        private UnitSpawner _unitSpawner;
        private void OnEnable()
        {
            _unitSpawner = GetComponent<UnitSpawner>();
        }
        public void OnPointerDown(PointerEventData eventData)
        {
            GameManager.instance.UIAssistant.OpenMenu(this._unitSpawner.SpawnerType);
        }
    }
}