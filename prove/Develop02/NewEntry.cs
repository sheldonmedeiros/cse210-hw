using System;

class NewEntry
{

    public string Prompt { get; set; }
    public string Respons { get; set; }
    public DateTime Date { get; set; }

    public NewEntry(string prompt, string response)
    {

        Prompt = prompt;
        response = response;
        Date = DateTime.Now;
    }
}