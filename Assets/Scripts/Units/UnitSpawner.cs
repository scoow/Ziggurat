using UnityEngine;
using UnityEngine.EventSystems;

namespace Ziggurat
{
    public class UnitSpawner : MonoBehaviour, IPointerExitHandler//todo отделить спавн от UI
    {
        public SpawnerColor SpawnerColor { get; private set; }
        public void OnPointerExit(PointerEventData eventData)
        {
            throw new System.NotImplementedException();
        }
    }

    public enum SpawnerColor : byte
    {
        Blue,
        Green,
        Red
    }
}
