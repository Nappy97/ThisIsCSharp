class MyClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("종료 조건(숫자)를 입력하세요 : ");

        var input = Console.ReadLine();
        var input_number = Convert.ToInt32(input);

        var exit_number = 0;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    if (exit_number++ == input_number)
                        goto EXIT_FOR;

                    Console.WriteLine(exit_number);
                }
            }
        }

        goto EXIT_PROGRAM;

        EXIT_FOR:
        Console.WriteLine("\nExit nested for...");

        EXIT_PROGRAM:
        Console.WriteLine("Exit Program ... ");
    }
}