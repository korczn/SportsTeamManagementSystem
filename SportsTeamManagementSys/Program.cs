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

// Interfejs z funkcjami statystyk drużyny
public interface ITeamStatistics
{
    void DisplayStatistics();  // Wyświetlanie statystyk metodą
    double CalculateAverageScore(); // Obliczanie średniej statystyk metodą
}

public class Team : ITeamStatistics
{
    private List<Player> players = new List<Player>(); // Lista graczy w drużynie
    public void AddPlayer(Player player)
    {
        players.Add(player); // Dodawanie gracza do listy
        Console.WriteLine($"Player {player.Name} added to the team.");
    }

    // Usuwanie gracza z drużyny po właściwości name
    public void RemovePlayer(string name)
    {
        var playerToRemove = players.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (playerToRemove != null)
        {
            players.Remove(playerToRemove); // Usuwanie gracza z listy
            Console.WriteLine($"Player {name} removed from the team.");
        }
        else
        {
            Console.WriteLine($"Player {name} not found in the team.");
        }
    }

    // Wyświetlanie listy graczy z drużyny
    public void DisplayTeam()
    {
        Console.WriteLine("Team Members:");
        foreach (var player in players)
        {
            Console.WriteLine(player);
        }
    }

    // Statystyki
    public void DisplayStatistics()
    {
        Console.WriteLine("\nTeam Statistics:");
        Console.WriteLine($"Total Players: {players.Count}");
        Console.WriteLine($"Total Score: {players.Sum(p => p.Score)}");
        Console.WriteLine($"Average Score: {CalculateAverageScore():F2}");
    }

    // Średni wynik
    public double CalculateAverageScore()
    {
        if (players.Count == 0) return 0;
        return players.Average(p => p.Score);
    }
}