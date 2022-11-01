namespace GenericGameFramework.ClassLibrary
{
    public abstract class BaseGameRules
    {
        private Object _lockObject = new();
        protected int MaxPlayers { get; set; }
        public string GameName { get; }
        private List<Player> _players = new List<Player>();
        public IEnumerable<Player> Players
        {
            get{
                foreach (var player in _players)
                {
                    yield return player;
                }
            }
        }

        protected BaseGameRules(string gameName) => GameName = gameName;
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
        public abstract string Execute(string action);
    }
}