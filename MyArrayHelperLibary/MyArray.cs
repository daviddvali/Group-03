namespace MyArrayHelperLibary
{
    public static class MyArray
    {
        public static void Sort(object[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (((MyComparable)array[j]).CompareTo(array[j + 1]) > 0)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void PrintArray<T>(T[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("┌─────┐");
                Console.WriteLine("│Empty│");
                Console.WriteLine("└─────┘");
                return;
            }

            string[] items = array.Select(x => x?.ToString() ?? "null").ToArray();

            int width = items
                .Select((item, index) => $"[{index + 1}] - {item}".Length)
                .Max();

            Console.WriteLine("┌" + new string('─', width + 2) + "┐");

            for (int i = 0; i < items.Length; i++)
            {
                string line = $"[{i + 1}] - {items[i]}";
                Console.WriteLine("│ " + line.PadRight(width) + " │");
            }

            Console.WriteLine("└" + new string('─', width + 2) + "┘");
        }
    }
}
