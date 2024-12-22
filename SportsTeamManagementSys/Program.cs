using System;
using System.Collections.Generic;
using System.Linq;

// Tworzenie klasy Player z właściwościami
public class Player 
{
    public string Name { get; set; }
    public int Score { get; set; }
    public string Position { get; set; }

    // Konstruktor inicjalizujący obiekt Player
    public Player(string name, int score, string position)
    {
        Name = name;
        Score = score;
        Position = position;
    }

    // Nadpisanie metody ToString(), aby zwrócić obiekt Player jako tekst
    public override string ToString()
    {
        return $"Name: {Name}, Score: {Score}, Position: {Position}";
    }
}