namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (DataGridViewColumn column in dgwProgramLicense.Columns)
            {
                Console.WriteLine($"Kolon Adı: {column.DataPropertyName}");
            }
        }
    }
}
