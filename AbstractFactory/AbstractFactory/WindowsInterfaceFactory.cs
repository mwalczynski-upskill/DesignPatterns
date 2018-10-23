using AbstractFactory.Checkbox;
using AbstractFactory.Enum;
using AbstractFactory.Scrollbar;

namespace AbstractFactory.AbstractFactory
{
    public class WindowsInterfaceFactory : IInterfaceFactory
    {
        public InterfaceFactoryType Type => InterfaceFactoryType.Windows;

        public IScrollbar CreateScrollbar()
        {
            var scrollbar = new WindowsScrollbar();
            return scrollbar;
        }

        public ICheckbox CreateCheckbox()
        {
            var checkbox = new WindowsCheckbox();
            return checkbox;
        }
    }
}
