using UnityEngine;

namespace Ziggurat
{
    public class UnitPool : BasePool<Unit>
    {
        public UnitPool(Unit prefab, Transform parent, int count = 1) : base(prefab, parent)
        {
            Init(count);
        }

/*        public override void Init(int count)
        {
            for (int i = 0; i < count; i++)
            {
                PoolUp(true);
            }
        }*/

        protected override Unit GetCreated() => Object.Instantiate(_prefab); //todo исправить

/*        protected Vector3 RandomSpawn()
        {
            float x = Random.Range(-50, 50);
            float z = Random.Range(-50, 50);
            return new Vector3(x, 2, z);
        }*/
    }
}
