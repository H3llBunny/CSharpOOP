namespace ObjectPoolExample
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Object Pool pattern is a creational design pattern that provides a way to 
            efficiently reuse and manage a pool of objects, rather than creating and destroying them on demand. 
            The main idea is to maintain a pool of initialized objects and provide clients 
            with a way to request an object from the pool, use it, and then return it to the pool for reuse.
            */

            ObjectPool objectPool = new ObjectPool(5);

            PooledObject obj = objectPool.AcquireObject();
            obj.DoSomething();

            objectPool.ReleaseObject(obj);

            PooledObject obj2 = objectPool.AcquireObject();
            obj2.DoSomething();

            objectPool.ReleaseObject(obj2);
        }
    }
}