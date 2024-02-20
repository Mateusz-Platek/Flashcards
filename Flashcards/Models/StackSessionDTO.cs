namespace Flashcards.Models;

public class StackSessionDTO
{
    public string name { get; set; }
    public Dictionary<string, int> sessions { get; set; }

    public StackSessionDTO(string name, Dictionary<string, int> sessions)
    {
        this.name = name;
        this.sessions = sessions;
    }
}