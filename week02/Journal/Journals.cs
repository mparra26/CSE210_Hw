public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        File.WriteAllLines(filename, entries.Select(e => e.ToFileString()));
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        foreach (var line in File.ReadAllLines(filename))
        {
            entries.Add(Entry.FromFileString(line));
        }
    }
}