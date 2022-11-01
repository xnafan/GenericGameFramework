namespace GenericGameFramework.ClassLibrary;
public class Player
{
    #region Properties
    public Guid Id { get; set; }
    public string Name { get; set; } = "anonymous";
	#endregion    
    public Player(Guid id = new Guid(), string name = "anonymous")
    {
        Id = id == Guid.Empty ? Guid.NewGuid() : id;
        Name = name;
    }
    public override string ToString() => $"Player Id:{Id}, Name:{Name}";
}