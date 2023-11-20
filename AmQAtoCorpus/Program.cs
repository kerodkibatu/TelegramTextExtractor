using System.Text.Json;
Console.OutputEncoding = System.Text.Encoding.UTF8;
var path = "C:\\Users\\Kerod\\Desktop\\AmharicNLP\\Amharic Datasets\\AmharicQA\\AmQA_Dataset.json";
var json = File.ReadAllText(path);

var obj = JsonSerializer.Deserialize<AmQA>(json);

Console.WriteLine(obj.data[0].paragraphs[0]);

public class AmQA
{
    public Datum[] data { get; set; }
    public string version { get; set; }
}

public class Datum
{
    public dynamic paragraphs { get; set; }
}
