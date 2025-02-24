using AbstractFactory.Factories.Contracts;
using AbstractFactory.Products.Contracts;
using AbstractFactory.Products.Implemententions.Motif;

namespace AbstractFactory.Factories.Implementations;

public class MotifWidgetFactory : IWidgetFactory
{
    public IScrollBar CreateScrollBar()
    {
        return new MotifScrollBar();
    }

    public IWindow CreateWindow()
    {
        return new MotifWindow();
    }
}
