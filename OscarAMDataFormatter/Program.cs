using System.Text;
using System.Text.Json;
var path = "C:\\Users\\Kerod\\Desktop\\AmharicNLP\\Amharic Datasets\\OscarAmharic\\am_meta.jsonl";

var jsons = File.ReadAllLines(path);

var sb = new StringBuilder();
var freq = jsons.Length / 100;
for (int i = 0; i < jsons.Length; i++)
{
    if (i % freq == 0)
    {
        Console.WriteLine($"{i*100/jsons.Length}%");
    }
    var obj = JsonSerializer.Deserialize<OscarEntry>(jsons[i]);
    sb.AppendLine(obj.content);
}
File.WriteAllText("C:\\Users\\Kerod\\Desktop\\AmharicNLP\\Amharic Datasets\\OscarAmharic\\oscar_am.txt", sb.ToString());
public class OscarEntry
{
    public string content { get; set; }
    public Warc_Headers warc_headers { get; set; }
    public Metadata metadata { get; set; }
}

public class Warc_Headers
{
    public string warcrefersto { get; set; }
    public string warcblockdigest { get; set; }
    public string contenttype { get; set; }
    public string warcrecordid { get; set; }
    public string warcidentifiedcontentlanguage { get; set; }
    public string contentlength { get; set; }
    public string warctargeturi { get; set; }
    public string warctype { get; set; }
    public DateTime warcdate { get; set; }
}

public class Metadata
{
    public Identification identification { get; set; }
    public float harmful_pp { get; set; }
    public string tlsh { get; set; }
    public string[] quality_warnings { get; set; }
    public object categories { get; set; }
    public Sentence_Identifications[] sentence_identifications { get; set; }
}

public class Identification
{
    public string label { get; set; }
    public float prob { get; set; }
}

public class Sentence_Identifications
{
    public string label { get; set; }
    public float prob { get; set; }
}
