namespace GenericGameFramework.ClassLibrary;

/// <summary>
/// The BaseGame class contains the basic
/// functionality of a hostable game session.
/// </summary>
public abstract class BaseGame
{
    #region Properties and variables
    //Can anyone join, or do you need to know the ID of this session
    public bool IsPublic { get; set; }
    public Guid Id { get; set; }
    public string SessionName { get; set; } = "";
    public IEnumerable<Player> Players => GameRules.Players;
    protected BaseGameRules GameRules { get; set; } 
    #endregion
    protected BaseGame(BaseGameRules gameRules, Guid id = new Guid(), bool isPublic = true, string sessionName = "")
    {
        GameRules = gameRules;
        Id = id == Guid.Empty ? Guid.NewGuid() : id;
        IsPublic = isPublic;
        SessionName = string.IsNullOrEmpty(sessionName) ? $"{GameRules.GameName} {ShortUIDTool.CreateShortId()}" : sessionName;
    }

    public bool TryJoin(Player player) => GameRules.TryJoin(player);
    public virtual string Execute(GameAction action) => GameRules.Execute(action);

    override public string ToString() => $"{GameRules.GameName} {Players.Count()} players";
}