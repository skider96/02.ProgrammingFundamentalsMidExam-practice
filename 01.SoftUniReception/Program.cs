namespace _01.SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficency = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int hour = 1;

            int fullEfficency = firstEmployeeEfficency + secondEmployeeEfficency + thirdEmployeeEfficency;

            for (int i = 1; i <= int.MaxValue; i++)
            {
                studentsCount -= fullEfficency;
                if (hour % 4 == 0)
                {
                    hour += 1;
                }
                if (studentsCount <= 0)
                {

                    Console.WriteLine($"Time needed: {hour}h.");
                    return;
                }
                hour++;
            }
        }
    }
}