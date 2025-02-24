using AbstractFactory.Products.Contracts;

namespace AbstractFactory.Products.Implemententions.Motif;

public class MotifWindow : IWindow
{
    public void Render()
    {
        Console.WriteLine("Rendering Motif Window");
    }
}
