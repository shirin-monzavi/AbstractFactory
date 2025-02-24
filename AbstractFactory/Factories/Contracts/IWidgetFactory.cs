using AbstractFactory.Products.Contracts;

namespace AbstractFactory.Factories.Contracts;

public interface IWidgetFactory
{
    IScrollBar CreateScrollBar();

    IWindow CreateWindow();
}
