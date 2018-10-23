using AbstractFactory.Checkbox;
using AbstractFactory.Enum;
using AbstractFactory.Scrollbar;

namespace AbstractFactory.AbstractFactory
{
    public class MacInterfaceFactory : IInterfaceFactory
    {
        public InterfaceFactoryType Type => InterfaceFactoryType.Mac;

        public IScrollbar CreateScrollbar()
        {
            var scrollbar = new MacScrollbar();
            return scrollbar;
        }

        public ICheckbox CreateCheckbox()
        {
            var checkbox = new MacCheckbox();
            return checkbox;
        }
    }
}