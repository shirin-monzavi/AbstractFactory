using AbstractFactory.Factories.Contracts;
using AbstractFactory.Products.Contracts;
using AbstractFactory.Products.Implemententions.PM;

namespace AbstractFactory.Factories.Implementations;

public class PMWidgetFactory : IWidgetFactory
{
    public IScrollBar CreateScrollBar()
    {
        return new PMScrollBar();
    }

    public IWindow CreateWindow()
    {
        return new PMWindow();
    }
}
