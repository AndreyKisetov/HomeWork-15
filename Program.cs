namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            {
            Console.Clear();
            Console.WriteLine("Введите цифру, обозначающую день недели (от 1 до 7): ");
            int x = (Convert.ToInt32(Console.ReadLine()));
            string day = "";
            if( x == 1 || x == 2 || x == 3 || x == 4 || x == 5) day = "нет";
            if( x == 6 || x == 7) day = "да";
            Console.WriteLine($"-> {day}");
            }
        }
    }
}
