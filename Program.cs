Console.Write("Введите целое число ");
double N = Convert.ToInt32(Console.ReadLine());
double M = Convert.ToInt32(0);

while (M <= N)
    {
        if (M % 2 == 0)
            {
                Console.Write($" {M},");
                M = M + 1;
            }
        else
            {
                M = M + 1;
            }

    }