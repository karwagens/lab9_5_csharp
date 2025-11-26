using System.Text;

namespace Lab9_Variant5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string inputPath = "input.txt";
            string outputPath = "output.txt";

            Console.WriteLine("=== Вариант 5: Сортировка строк ===");

            if (File.Exists(inputPath))
            {
                string[] lines = File.ReadAllLines(inputPath);

                // Сортировка массива строк по алфавиту
                Array.Sort(lines);

                File.WriteAllLines(outputPath, lines);
                Console.WriteLine($"Строки отсортированы и сохранены в '{outputPath}'.");
            }
            else
            {
                Console.WriteLine($"Файл '{inputPath}' не найден.");
            }

            Console.ReadKey();
        }
    }
}
