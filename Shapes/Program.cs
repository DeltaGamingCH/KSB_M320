namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle("A rectangle", 10, 10, 4);
            Rectangle r2 = new Rectangle(System.Drawing.Color.AliceBlue);
            Rectangle r3 = new Rectangle(15, 10);

            r1.Enabled = true;
            r1.Name = "My Rectangle";

            Console.WriteLine(
                $"Rectangle: {r1.Name}\n" +
                $"{r1.SizeAsString}"
            );
        }
    }
}