namespace ZombieParty.Models
{
    public class Zombie
    {
        public string Name { get; set; }
        public int ZombieTypeId { get; set; }
        public ZombieType ZombieType { get; set; }

        public int Point { get; set; }
    }
}
