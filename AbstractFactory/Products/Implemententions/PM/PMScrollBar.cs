using AbstractFactory.Products.Contracts;

namespace AbstractFactory.Products.Implemententions.PM;

public class PMScrollBar : IScrollBar
{
    public void Render()
    {
        Console.WriteLine("Rendring PM ScrollBar");
    }
}
