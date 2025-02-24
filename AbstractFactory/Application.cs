using AbstractFactory.Factories.Contracts;
using AbstractFactory.Products.Contracts;

namespace AbstractFactory;

public class Application
{
    #region Fields
    private readonly IScrollBar _scrollBar;
    private readonly IWindow _window;
    #endregion

    public Application(IWidgetFactory widgetFactory)
    {
        _scrollBar = widgetFactory.CreateScrollBar();
        _window = widgetFactory.CreateWindow();
    }

    public void Run()
    {
        _scrollBar.Render();
        _window.Render();
    }
}
