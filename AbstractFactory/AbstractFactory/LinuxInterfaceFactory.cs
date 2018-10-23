using AbstractFactory.Checkbox;
using AbstractFactory.Enum;
using AbstractFactory.Scrollbar;

namespace AbstractFactory.AbstractFactory
{
    public class LinuxInterfaceFactory : IInterfaceFactory
    {
        public InterfaceFactoryType Type => InterfaceFactoryType.Linux;

        public IScrollbar CreateScrollbar()
        {
            var scrollbar = new LinuxScrollbar();
            return scrollbar;
        }

        public ICheckbox CreateCheckbox()
        {
            var checkbox = new LinuxCheckbox();
            return checkbox;
        }
    }
}