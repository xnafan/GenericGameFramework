namespace GenericGameFramework.ClassLibrary;

/// <summary>
/// The GameAction class is for transporting
/// incoming messages (moves, etc.)
/// from a player to a specific game.
/// </summary>
public class GameAction
{
    public Guid GameId { get; set; }
    public Guid PlayerId { get; set; }
    public string Action { get; set; } = "";
}