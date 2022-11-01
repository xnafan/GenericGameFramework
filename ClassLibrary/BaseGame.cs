using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericGameFramework.ClassLibrary
{
    public abstract class BaseGame
    {
        //Can anyone join, or do you need to know the ID of this session
        public bool IsPublic { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public string SessionName { get; set; }
        protected BaseGameRules GameRules { get; set; }

        protected BaseGame(BaseGameRules gameRules)
        {
            GameRules = gameRules;
        }
        protected BaseGame(BaseGameRules gameRules, Guid id = new Guid(), bool isPublic = true, string sessionName = ""):this(gameRules)
        {
            Id = id;
            IsPublic = isPublic;
            SessionName = String.IsNullOrEmpty(sessionName) ? $"{GameRules.GameName} {ShortUIDTool.CreateNewShortId()}" : sessionName;
        }

        public IEnumerable<Player> Players => GameRules.Players; 
        public bool TryJoin(Player player) => GameRules.TryJoin(player);
        public virtual string Execute(string action) => GameRules.Execute(action);
    }
}