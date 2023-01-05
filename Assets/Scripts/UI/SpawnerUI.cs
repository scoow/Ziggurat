using UnityEngine;
using UnityEngine.EventSystems;

public class SpawnerUI : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("SpawnerUI");
    }

}
