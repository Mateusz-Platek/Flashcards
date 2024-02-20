namespace Flashcards.Models;

public class StackSession
{
    public string name { get; set; }
    public Dictionary<string, int> sessions { get; set; }

    public StackSession(string name, Dictionary<string, int> sessions)
    {
        this.name = name;
        this.sessions = sessions;
    }
}