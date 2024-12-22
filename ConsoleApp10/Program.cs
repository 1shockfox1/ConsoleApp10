try
{
    Console.WriteLine("Добро пожаловать выберите для каких цифр вы хотите проверить\r\n  1)a1 = -13, b1 = -3.5\r\n  2)a2 = 5.8, b2 = 37\r\n  3)a3 = 8, b3 = -15\r\n");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("ваш выбор: " +x);
    switch(x)
    {
            case 1:
            double a1 = -13, b1 = -3.5;
            Console.WriteLine($"Исходные значения: A = {a1}, B = {b1}");
            if ((a1 < 0 && b1 > 0) || (a1 > 0 && b1 < 0))
            {
                a1 = -a1;
                b1 = -b1;
            }
            else
            {
                a1 = 0;
                b1 = 0;
            }
            Console.WriteLine($"Результат: A = {a1}, B = {b1}"); break;

            case 2:
            double a2 = 5.8, b2 = 37;
            Console.WriteLine($"Исходные значения: A = {a2}, B = {b2}");
            if ((a2 < 0 && b2 > 0) || (a2 > 0 && b2 < 0))
            {
                a2 = -a2;
                b2 = -b2;
            }
            else
            {
                a2 = 0;
                b2 = 0;
            }
            Console.WriteLine($"Результат: A = {a2}, B = {b2}n"); break;
            case 3: double a3 = 8, b3 = -15;
            Console.WriteLine($"Исходные значения: A = {a3}, B = {b3}");
            if ((a3 < 0 && b3 > 0) || (a3 > 0 && b3 < 0))
            {
                a3 = -a3;
                b3 = -b3;
            }
            else
            {
                a3 = 0;
                b3 = 0;
            }
            Console.WriteLine($"Результат: A = {a3}, B = {b3}n"); break;
    }
}
catch
{
    Console.WriteLine("ошибочка 404...");
}
