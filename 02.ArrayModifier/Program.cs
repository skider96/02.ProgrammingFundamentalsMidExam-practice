namespace _02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split(' ');
                int index1 = 0;
                int index2 = 0;
                if (arguments[0] == "swap")
                {
                    index1 = int.Parse(arguments[1]);
                    index2 = int.Parse(arguments[2]);
                    int copy = array[index1];
                    array[index1] = array[index2];
                    array[index2] = copy;
                }
                else if (arguments[0] == "multiply")
                {
                    index1 = int.Parse(arguments[1]);
                    index2 = int.Parse(arguments[2]);

                    int copy = array[index1];
                    copy = array[index2] * copy;
                    array[index1] = copy;
                }
                else if (arguments[0] == "decrease")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] -= 1;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}