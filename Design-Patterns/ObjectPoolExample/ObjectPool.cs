using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolExample
{
    public class ObjectPool
    {
        private List<PooledObject> pool = new List<PooledObject>();

        public ObjectPool(int initialSize)
        {
            for (int i = 0; i < initialSize; i++)
            {
                pool.Add(new PooledObject());
            }
        }

        public PooledObject AcquireObject()
        {
            if (pool.Count > 0)
            {
                PooledObject obj = pool[pool.Count - 1];
                pool.RemoveAt(pool.Count - 1);
                return obj;
            }
            else
            {
                return new PooledObject();
            }
        }

        public void ReleaseObject(PooledObject obj)
        {
            pool.Add(obj);
        }
    }
}
