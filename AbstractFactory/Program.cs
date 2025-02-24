using AbstractFactory;
using AbstractFactory.Factories.Contracts;
using AbstractFactory.Factories.Implementations;

Console.WriteLine("Please Enter Name Of Widgets:");

var widgetName = Console.ReadLine()?.Trim().ToLower();

IWidgetFactory factory = widgetName switch
{
    "pm" => new PMWidgetFactory(),
    "motif" => new MotifWidgetFactory(),
    _ => throw new ArgumentException("Unsupported type.")
};

Application app = new(factory);

app.Run();
