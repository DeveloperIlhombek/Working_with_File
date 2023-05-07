using System.Text.Json;
class Program
{
    public static void Main(string[] args)
    {
        string lines = File.ReadAllText(@"C:\Users\E-MaxPCShop\Documents\.Net Vocabulary.txt");
        string[] words = lines.Split(' ');
        string[] result = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            result[i] = words[i].Trim();
        }
        string[] answer = result;

        string json = JsonSerializer.Serialize(answer);
        Console.WriteLine(json);

        StreamWriter sw = new StreamWriter("d://Documents/json.txt");
        sw.WriteLine(json);
        sw.Close();
    }
}