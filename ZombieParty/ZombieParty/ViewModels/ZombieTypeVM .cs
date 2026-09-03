using ZombieParty.Models;

namespace ZombieParty.ViewModels
{
    public class ZombieTypeVM
    {
        public ZombieType ZombieType { get; set; }
        public List<Zombie> ZombiesList { get; set; } = new List<Zombie>();
        //  Que devez-vous modifier afin de présenter le nombre de zombies et la moyenne des points de la liste de zombies pour chaque ZombieType?
        public int ZombiesCount { get; set; }
        public double PointsAverage { get; set; }


    }
}
