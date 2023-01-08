Console.WriteLine("Введите число: ");
        string x = Console.ReadLine();
        if (int.TryParse(x, out int N))
        {
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
                
        }
           else
        {
            Console.WriteLine("Вы ввели неверные символы");
        }