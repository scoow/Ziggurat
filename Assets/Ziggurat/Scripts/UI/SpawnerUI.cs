using UnityEngine;
using UnityEngine.EventSystems;

namespace Ziggurat
{
    public class SpawnerUI : MonoBehaviour, IPointerDownHandler
    {
        private UnitSpawner _unitSpawner;
        public void OnPointerDown(PointerEventData eventData)
        {
            //Debug.Log("SpawnerUI");
            GameManager.instance._uiAssistant.OpenMenu(this._unitSpawner.SpawnerType);
        }
        public void GetStats()
        {
            //todo реализация?
        }
        private void OnEnable()
        {
            _unitSpawner = GetComponent<UnitSpawner>();
        }
    }
}