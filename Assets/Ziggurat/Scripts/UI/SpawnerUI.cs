using UnityEngine;
using UnityEngine.EventSystems;

namespace Ziggurat
{
    public class SpawnerUI : ClickHandler<UnitSpawner>
    {
        protected override void OnEnable()
        {
            base.OnEnable();
            _unitType = _object.UnitType;
        }
    }
}