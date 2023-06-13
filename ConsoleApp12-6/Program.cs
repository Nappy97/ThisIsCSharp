namespace ConsoleApp12_6
{
    class FilterableException : Exception
    {
        public int ErrorNo { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Between 0~10");
            var input = Console.ReadLine();

            try
            {
                var num = Int32.Parse(input);

                if (num is < 0 or > 10)
                // if (num < 0 || num > 10)
                    throw new FilterableException() { ErrorNo = num };
                else
                    Console.WriteLine($"Output : {num}");
            }
            catch (FilterableException e) when (e.ErrorNo < 0)
            {
                Console.WriteLine(e);
            }
            catch (FilterableException e) when (e.ErrorNo > 10)
            {
                Console.WriteLine("Too big number is now allowed.");
            }
        }
    }
}