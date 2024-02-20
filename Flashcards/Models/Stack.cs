﻿namespace Flashcards.Models;

public class Stack
{
    public int stackId { get; set; }
    public string name { get; set; }

    public Stack(int stackId, string name)
    {
        this.stackId = stackId;
        this.name = name;
    }

    public StackDTO ToStackDTO()
    {
        return new StackDTO(name);
    }
}