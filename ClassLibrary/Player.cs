namespace GenericGameFramework.ClassLibrary
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "anonymous";
        public Player(Guid id = new Guid(), string name = "anonymous")
        {
            Id = id;
            Name = name;
        }
    }
}