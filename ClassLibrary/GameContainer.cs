namespace GenericGameFramework.ClassLibrary;
/// <summary>
/// Class which contains all running games. 
/// GameContainer allows for joining games, 
/// creating new games and making
/// requests (moves, state changes) to specific games
/// </summary>
public class GameContainer
{
    private Dictionary<Guid, BaseGame> _games = new();
    public Guid JoinGame<T>(Player player) where T : BaseGame, new()
    {
        T? openGame = (T?)_games.Values.FirstOrDefault(game => game.IsPublic && game.TryJoin(player));
        if (openGame != default) { return openGame.Id; }

        openGame = new T() { IsPublic = true };
        openGame.TryJoin(player);
        _games.Add(openGame.Id, openGame);
        return openGame.Id;
    }
    public IEnumerable<BaseGame>? GetGames<T>() where T : BaseGame
    {
        return _games.Where(game => game is T).Cast<T>();
    }
    public string? Execute(GameRequest request)
    {
        if(_games.TryGetValue(request.GameId, out var game))
        {
            return game.Execute(request.Action);
        }
        return null;
    }
}