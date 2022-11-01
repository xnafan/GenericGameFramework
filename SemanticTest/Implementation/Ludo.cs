using GenericGameFramework.ClassLibrary;

namespace SemanticTest.Implementation
{
    public class Ludo : BaseGame
    {
        public Ludo() : base(new LudoGamerules()){}

        public Ludo(Guid id = default, bool isPublic = true, string sessionName = "") : base(new LudoGamerules(), id, isPublic, sessionName){}

        private class LudoGamerules : BaseGameRules
        {
            public LudoGamerules() : base("Ludo") { MaxPlayers = 4; }

            public override string Execute(string action) => "done";
        }
    }

}