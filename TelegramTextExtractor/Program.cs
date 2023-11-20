using System.Text;
using System.Text.Json;
while (true)
{
    Console.Write("Path to json: ");
    var path = Console.ReadLine()!;
    Extract(path);
}
void Extract(string path)
{
    if (path.StartsWith('"'))
        path = path.Substring(1, path.Length - 2);
    if (!Path.Exists(path))
    {
        Console.WriteLine("Path doesnt exist!");
        return;
    }
    var json = new StreamReader(path).ReadToEnd();
    var channel = JsonSerializer.Deserialize<Channel>(json);
    if (channel == null)
    {
        Console.WriteLine("The file is not in correct format!");
        return;
    }
    var saveTo = Path.Combine("C:\\Users\\Kerod\\Desktop\\Amharic Datasets\\Telegram", channel.name.Replace("/", "").Replace(".", "").Replace("|", "") + ".txt");
    var corpus = new StringBuilder();
    if (Path.Exists(saveTo))
    {
        Console.WriteLine("The data already exists!\nSkipping...");
        return;
    }
    foreach (var message in channel.messages)
    {
        foreach (var item in message.text_entities)
        {
            if (item.type == "plain" && !string.IsNullOrEmpty(item.text))
                corpus.Append(item.text);
        }
    }
    File.WriteAllText(Path.Combine(saveTo), corpus.ToString());
    Console.WriteLine("Done!");
}