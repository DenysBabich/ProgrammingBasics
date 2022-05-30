Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

Line P1 = new Line();
Line P2 = new Line(Input("Введіть координати с: "));
Line P3 = new Line(Input("Введіть координати a: "), Input("Введіть координати b: "), Input("Введіть координати c: "));

Console.WriteLine();

Console.WriteLine($"Перша пряма: {P1}");
Console.WriteLine($"Друга пряма: {P2}");
Console.WriteLine($"Третя пряма: {P3}");

Console.WriteLine();

if (P1 | P2)
    Console.WriteLine("P1 та P2 паралельні.");
else
    Console.WriteLine("P1 та P2 не паралельні.");

Console.WriteLine();

P3++;

Console.WriteLine($"Третя пряма після збільшення на 1 градус: {P3}");

Console.WriteLine();

Console.WriteLine($"Точка перетину з віссю Х: ({P3.IntersectionX}; 0).");
Console.WriteLine($"Точка перетину з віссю Y: (0; {P3.IntersectionY}).");

int Input(string text)
{
    while (true)
    {
        Console.Write(text);

        if (int.TryParse(Console.ReadLine(), out int result))
            return result;
        else
            Console.WriteLine("Введіть коректні дані!");
    }
}