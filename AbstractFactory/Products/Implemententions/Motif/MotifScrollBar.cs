using AbstractFactory.Products.Contracts;

namespace AbstractFactory.Products.Implemententions.Motif;

public class MotifScrollBar : IScrollBar
{
    public void Render()
    {
        Console.WriteLine("Rendring Motif ScrollBar");
    }
}
