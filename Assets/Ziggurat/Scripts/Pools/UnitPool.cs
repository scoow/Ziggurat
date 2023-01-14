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
            var result = Object.Instantiate(_prefab); //todo �������� �������� ������
            result._unitType = _unitType;
            result.Respawn();
            return result;
        }
        /// <summary>
        /// ����������� ������� � ������ �������� ������
        /// </summary>
        /// <returns>������ �������� ������</returns>
        public List<Unit> GetActiveUnits()
        {
            return _elements.Where(x => x.isActiveAndEnabled).ToList();//todo ������, ����� �� �������� �������� ������ ������ ������������
        }
    }
}