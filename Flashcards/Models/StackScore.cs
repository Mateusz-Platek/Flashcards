namespace Flashcards.Models;

public class StackScore
{
    public string name { get; set; }
    public Dictionary<string, double> scores { get; set; }

    public StackScore(string name, Dictionary<string, double> scores)
    {
        this.name = name;
        this.scores = scores;
    }
}