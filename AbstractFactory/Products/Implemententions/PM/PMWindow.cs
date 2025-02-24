using AbstractFactory.Products.Contracts;

namespace AbstractFactory.Products.Implemententions.PM;

public class PMWindow : IWindow
{
    public void Render()
    {
        Console.WriteLine("Rendering PM Window");
    }
}
