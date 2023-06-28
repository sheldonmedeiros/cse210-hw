class ScriptureLibrary
{
    private List<Scripture> scriptures;
    private Random random;

    public ScriptureLibrary()
    {
        scriptures = new List<Scripture>();
        random = new Random();
    }

    public void LoadScripturesFromFile(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                string reference = parts[0].Trim();
                string text = parts[1].Trim();
                scriptures.Add(new Scripture(reference, text));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading scriptures from file: " + ex.Message);
        }
    }

    public Scripture GetRandomScripture()
    {
        if (scriptures.Count > 0)
        {
            int index = random.Next(0, scriptures.Count);
            return scriptures[index];
        }
        else
        {
            return null;
        }
    }
}