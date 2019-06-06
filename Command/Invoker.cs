namespace Command
{
    using Commands;

    internal class Invoker
    {
        private readonly ICommand _on;
        private readonly ICommand _off;
        private readonly ICommand _up;
        private readonly ICommand _down;

        public Invoker(ICommand on, ICommand off, ICommand up, ICommand down)
        {
            _on = on;
            _off = off;
            _up = up;
            _down = down;
        }

        public void ClickOn()
        {
            _on.Execute();
        }
        public void ClickOff()
        {
            _off.Execute();
        }
        public void ClickUp()
        {
            _up.Execute();
        }
        public void ClickDown()
        {
            _down.Execute();
        }
    }
}
