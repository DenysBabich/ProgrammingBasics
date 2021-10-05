#include <iostream>
#include <cmath>
#include <Windows.h>

double validation();

int main()
{

    SetConsoleCP(1251);                                //Встановлення кодування Windows-1251 для вводу
    SetConsoleOutputCP(1251);                        //Встановелння кодування Windows-1251 для виводу

    double area_of_outer = validation();             //Перевірка на правильність введених даних

    double diameter = pow(area_of_outer, 0.5);      //Діаметер кола

    double square_inner = diameter / sqrt(2);       //Сторона квадрата, який вписаний у коло

    double area_of_inner = pow(square_inner, 2);         //Площа вписаного у коло квадрата

    std::cout << area_of_inner / area_of_outer << std::endl;        //У скільки разів площа вписаного більша, ніж описаного

    std::cin >> end;
}

double validation()
{
    double number;

    while (true)
    {
        try
        {
            std::cout << "Введіть площу квадрата: ";
            std::cin >> number;

            if (std::cin.good())        //Якщо ввід є правильним
            {
                if (number < 0)
                {
                    std::cout << "Площа квадрата не може бути від'ємним числом!" << std::endl;
                    continue;
                }
                else if (number == 0)
                {
                    std::cout << "Площа квадрата не може дорвінювати 0!" << std::endl;
                    continue;
                }
            }
            else
            {
                std::cout << "Введіть саме число!" << std::endl;
                std::cin.clear();                                       //Очищення буферу вводу
                std::cin.ignore(32767, '\n');
                continue;
            }
        }
        catch (std::exception e)
        {
            std::cout << e.what() << std::endl;
        }
        return number;
    }
}

