using AbstractFactory.Checkbox;
using AbstractFactory.Enum;
using AbstractFactory.Scrollbar;

namespace AbstractFactory.AbstractFactory
{
    public interface IInterfaceFactory
    {
        InterfaceFactoryType Type { get; }

        IScrollbar CreateScrollbar();

        ICheckbox CreateCheckbox();
    }
}
