using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Ziggurat
{
    public class UnitPool : BasePool<Unit>
    {
        private UnitType _unitType;
        public UnitPool(Unit prefab, UnitType unitType, Transform parent, int count = 1) : base(prefab, parent)
        {
            _unitType = unitType;
            Init(count);
        }

        protected override Unit GetCreated()
        {
            var result = Object.Instantiate(_prefab); //todo добавить загрузку статов
            result._unitType = _unitType;
            return result;
        }

        public List<Unit> GetActiveUnits()
        {
            return _elements.Where(x => x.enabled == true).ToList();
        }
    }
}