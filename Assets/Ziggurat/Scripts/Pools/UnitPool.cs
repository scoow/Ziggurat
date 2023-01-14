using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Ziggurat
{
    public class UnitPool : BasePool<Unit>
    {
        protected UnitType _unitType;

        public UnitPool(Unit prefab, UnitType unitType, Transform parent, int count = 1) : base(prefab, parent)
        {
            _unitType = unitType;
            Init(count);
        }
        protected override Unit GetCreated()
        {
            Unit newUnit = Object.Instantiate(_prefab);
            newUnit.UnitType = _unitType;
            return newUnit;
        }
        /// <summary>
        /// Конвертация словаря в список активных юнитов
        /// </summary>
        /// <returns>список активных юнитов</returns>
        public List<Unit> GetActiveUnits()
        {
            return _elements.Where(x => x.isActiveAndEnabled).ToList();
        }
    }
}