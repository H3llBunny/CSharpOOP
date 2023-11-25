namespace ProxyExample
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Proxy design pattern is a structural pattern that involves creating a surrogate 
            or placeholder for another object to control access to it. This can be useful for 
            implementing various levels of control over the real object, such as lazy loading, access control, 
            logging, or monitoring.The Proxy pattern allows a class to stand in for another class.
            */

            IRealObject proxy = new Proxy();
            proxy.Request();
        }
    }
}