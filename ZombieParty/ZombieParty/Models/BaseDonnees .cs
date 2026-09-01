namespace ZombieParty.Models
{
    public class BaseDonnees
    {
        public List<ZombieType> ZombieTypes { get; set; }
        public List<Zombie> Zombies { get; set; }

        public BaseDonnees()
        {
            //Initialiser des listes vides
            Zombies = new List<Zombie>();
            //Remplir la liste des ZombieTypes
            ZombieTypes = new List<ZombieType>()
        {
            new ZombieType() { TypeName = "Virus", Id = 1 },
            new ZombieType() { TypeName = "Contact", Id = 2 },
            new ZombieType() { TypeName = "Radioactif", Id = 3 }
        };

            //Remplir la liste des Zombies
            Zombies.Add(new Zombie() { Name = "LeChuck", Point = 5, ZombieTypeId = 2 });
            Zombies.Add(new Zombie() { Name = "Lenore", Point = 4, ZombieTypeId = 2 });
            Zombies.Add(new Zombie() { Name = "Draugr", Point = 2, ZombieTypeId = 3 });
            Zombies.Add(new Zombie() { Name = "Ragamuffin", Point = 5, ZombieTypeId = 1 });
            Zombies.Add(new Zombie() { Name = "Taxidermy", Point = 1, ZombieTypeId = 2 });
            Zombies.Add(new Zombie() { Name = "Chien", Point = 7, ZombieTypeId = 1 });
            Zombies.Add(new Zombie() { Name = "Avogadro", Point = 9, ZombieTypeId = 3 });
        }

    }
}
