namespace GenericGameFramework.ClassLibrary;

/// <summary>
/// The GameRequest class is for transporting
/// incoming messages (moves, etc.)
/// from a player to a specific game.
/// </summary>
public class GameRequest
{
    public Guid GameId { get; set; }
    public Guid PlayerId { get; set; }
    public string Action { get; set; } = "";
}