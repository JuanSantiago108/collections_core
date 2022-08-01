int start = 0;
int end = 9;

for (int i = start; i <= end; i++)
{
    Console.WriteLine(i);
}

string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara" };

bool[] boolArry = new bool[10];

for (int idx = 0; idx < boolArry.Length; idx++)
{
    if (idx % 2 == 0) 
    {
        boolArry[idx] = true;
    } else{
        boolArry[idx] = false;
    }

}
foreach (bool val in boolArry)
{
    Console.WriteLine(val);
}

List<string> flavors = new List<string>();
flavors.Add("chocolate");
flavors.Add("vanilla");
flavors.Add("oreo");
flavors.Add("banana");
flavors.Add("mint");
flavors.Add("mango");
flavors.Add("red velvet");
flavors.Add("gras");
flavors.Add("brown");
flavors.Add("blue");

Console.WriteLine($"{flavors.Count}");
Console.WriteLine($"{flavors[2]}");
flavors.RemoveAt(2);
Console.WriteLine($"{flavors.Count}");


Dictionary<string,string> profile = new Dictionary<string, string>();
Random rand = new Random();
for (int i = 0; i<names.Length; i++)
{
    int radIdx = rand.Next(0,flavors.Count);
    profile.Add(names[i],flavors[radIdx]);
}

foreach(KeyValuePair<string,string> entry in profile)
{
    Console.WriteLine($" {entry.Key} {entry.Value} ");
}