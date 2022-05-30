namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.InputEncoding = System.Text.Encoding.UTF8;
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;

            TSeries[] series = new TSeries[Input("Введіть кількість прогресій: ")];

            FillProgressions(series);

            int numToCompare = Input("Введіть елемент прогресії для порівяння: ");

            PrintSeries(series, numToCompare);

            int selectedProgression = FindMax(numToCompare);

            Console.WriteLine($"У {selectedProgression+1}-й послідовності {numToCompare} елемент є найбільшим і дорівнює: {series[selectedProgression].GetElement(numToCompare)}.");

            int numSum = Input("Введіть кількість елементів прогресії для знаходження суми: ");

            Console.WriteLine($"Сума елементів послідовності дорівнює: {series[selectedProgression].SumElement(numSum)}");






            int FindMax(int n)
            {
                double max = series[0].GetElement(n);
                int result = 0;

                for (int i = 1; i < series.Length; i++)
                {
                    if(max < series[i].GetElement(n))
                    {
                        max = series[i].GetElement(n);
                        result = i;
                    }
                }
                return result;
            }

            int Input(string text)
            {
                while (true)
                {
                    Console.Write(text);

                    if (int.TryParse(Console.ReadLine(), out int n))
                        return n;
                    else
                    {
                        Console.WriteLine("Введіть коректні дані!");
                        continue;
                    }
                }
            }

            void FillProgressions(TSeries[] series, int firstELementLower = 1, int firstELementUpper = 50, int differenceMin = 2, int differenceMax = 10)
            {
                for (int i = 0; i < series.Length; i++)
                {
                    if (i % 2 == 0)
                        series[i] = new GeometricProgression(new Random().Next(firstELementLower, firstELementUpper), new Random().Next(differenceMin, differenceMax));
                    else
                        series[i] = new ArithmeticProgression(new Random().Next(firstELementLower, firstELementUpper), new Random().Next(differenceMin, differenceMax));
                }
            }

            void PrintSeries(TSeries[] series, int maxNum)
            {
                for (int i = 0; i < series.Length; i++)
                    series[i].PrintSeries(maxNum);
            }
        }
    }
}