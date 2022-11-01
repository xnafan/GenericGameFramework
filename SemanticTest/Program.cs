using GenericGameFramework.ClassLibrary;
using SemanticTest.Implementation;

//server syntax check
Player player1 = new Player(new Guid(), "Anna");
Player player2 = new Player(new Guid(), "Bob");
Player player3 = new Player(new Guid(), "Clarissa");
Player player4 = new Player(new Guid(), "Dennis");
Player player5 = new Player(new Guid(), "Erica");

Ludo ludo = new Ludo(new Guid(), isPublic: true, "");
ludo.TryJoin(player1);
ludo.TryJoin(player2);
ludo.TryJoin(player3);
ludo.TryJoin(player4);
ludo.TryJoin(player5);
Console.WriteLine("Number of players: " +  ludo.Players.Count());
Console.WriteLine(ludo.SessionName);