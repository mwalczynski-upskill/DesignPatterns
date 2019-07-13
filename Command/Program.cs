namespace Command
{
    using System;
    using Commands;

    class Program
    {
        static void Main(string[] args)
        {
            var light = new Light();

            var onCommand = new LightOnCommand(light);
            var offCommand = new LightOffCommand(light);
            var noCommand = new NoCommandCommand();

            var invoker = new Invoker(onCommand, offCommand, noCommand, noCommand);

            invoker.ClickOn();

            Console.ReadKey();
        }
    }
}
