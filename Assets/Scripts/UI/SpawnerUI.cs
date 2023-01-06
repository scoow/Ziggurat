using UnityEngine;
using UnityEngine.EventSystems;

namespace Ziggurat
{
    public class SpawnerUI : MonoBehaviour, IPointerDownHandler
    {
        private UnitSpawner _unitSpawner;
        public void OnPointerDown(PointerEventData eventData)
        {
            Debug.Log("SpawnerUI");
        }
        public void GetStats()
        {
            //todo
        }
        private void Start()
        {
            _unitSpawner = GetComponent<UnitSpawner>();
        }
    }
}