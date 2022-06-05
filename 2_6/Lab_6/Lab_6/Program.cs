System.Console.InputEncoding = System.Text.Encoding.Unicode;
System.Console.OutputEncoding = System.Text.Encoding.Unicode;

int size = Input("Введіть кількість елементів: ");

int[] arr = InputArray(size);

Tree t = new Tree();

t.root = t.CreateTree(arr, 0);

Console.WriteLine();
Tree.Print(t.root);
Console.WriteLine();

Console.WriteLine($"Середнє арифметичне: {t.CountAverage()}.");


int Input(string text)
{
    while(true)
    {
        Console.Write(text);

        if (int.TryParse(Console.ReadLine(), out int result))
            return result;
        else
            Console.WriteLine("Введіть коректні дані!"); 
    }
}

int[] InputArray(int size)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
        result[i] = Input($"Введіть {i + 1}-й елемент: ");

    return result;
}
