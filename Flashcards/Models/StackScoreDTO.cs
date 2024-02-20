namespace Flashcards.Models;

public class StackScoreDTO
{
    public string name { get; set; }
    public Dictionary<string, double> scores { get; set; }

    public StackScoreDTO(string name, Dictionary<string, double> scores)
    {
        this.name = name;
        this.scores = scores;
    }
}