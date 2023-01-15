namespace Ziggurat
{
    public class UnitUI : ClickHandler<Unit>
    {
        protected override void OnEnable()
        {
            base.OnEnable();
            _unitType = _object.UnitType;
        }
    }
}