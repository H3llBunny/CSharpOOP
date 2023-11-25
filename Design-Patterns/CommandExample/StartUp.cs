namespace CommandExample
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*
            The Command pattern is a behavioral design pattern that turns a request into a 
            standalone object, containing all the information about the request. 
            This transformation allows for parameterization of clients with different requests, queuing of requests, 
            and logging of the parameters, among other uses.
            */

            Light light = new Light();

            ICommand lightOnCommand = new LightOnCommand(light);
            ICommand lightOffCommand = new LightOffCommand(light);

            RemoteControl remote = new RemoteControl();

            remote.SetCommand(lightOnCommand);
            remote.PressButton();

            remote.SetCommand(lightOffCommand);
            remote.PressButton();
        }
    }
}