namespace GenericGameFramework.ClassLibrary;
public abstract class BaseGameRules
{
    #region Properties and variables
    private object _lockObject = new();
    protected int MaxPlayers { get; set; }
    public string GameName { get; }
    private List<Player> _players = new List<Player>();
    public IEnumerable<Player> Players
    {
        get
        {
            foreach (var player in _players)
            {
                yield return player;
            }
        }
    }

    #endregion
    
    #region Constructor
    protected BaseGameRules(string gameName) => GameName = gameName;

    #endregion

    #region Methods
    public virtual bool TryJoin(Player player)
    {
        lock (_lockObject)
        {
            if (_players.Count < MaxPlayers)
            {
                _players.Add(player);
                return true;
            }
            return false;
        }

    }
    #endregion

    #region Strategy Pattern implementation
    public virtual string Execute(GameAction action)
    {
        lock (_lockObject)
        {
            return ConcreteExecute(action);
        }
    }
    public abstract string ConcreteExecute(GameAction action); 
    #endregion
}