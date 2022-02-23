// See https://aka.ms/new-console-template for more information
/*Написать любое приложение, произвести его сборку с помощью MSBuild, осуществить декомпиляцию с помощью dotPeek, 
 внести правки в программный код и пересобрать приложение.*/

        Console.WriteLine("Введите число");
        int chislopolz = Convert.ToInt32(Console.ReadLine());
        int chislo = chislopolz % 2;
        if (chislo == 0)
        {
            Console.WriteLine($"Число четное");
        }
        else
        {
            Console.WriteLine($"Число нечетное");
        }
        Console.ReadKey();
