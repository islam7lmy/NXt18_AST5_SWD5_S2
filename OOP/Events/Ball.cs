using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Events
{

    struct Location
    {
        public Location(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public override string ToString() => $"({X} , {Y} , {Z})";

    }
    internal class Ball
    {

        public int Id { get; set; }
        private Location location;

        public Ball(int id)
        {
            Id = id;
        }

        public Location Location
        {
            get => location;
            set
            {
                if (!location.Equals(value))
                {
                    location = value;
                    //LocationChanged(value);
                    OnLocationChanged(value);
                }
            }
        }

        //public Action<Location> LocationChanged;
        public event Action<Location> LocationChanged;

        protected virtual void OnLocationChanged(Location location)
        {
            LocationChanged.Invoke(location);
        }

    }

    class Ball02 : Ball
    {
        public Ball02(int id) : base(id) { }

        //void OnLocationCahnged(Location location)
        //{
        //    base.LocationChanged.Invoke(location);
        //}
        protected override void OnLocationChanged(Location location)
        {
            base.OnLocationChanged(location);
        }
    }

    class Player
    {
        public Player(string name, string team)
        {
            Name = name;
            Team = team;
        }

        public string Name { get; set; }
        public string Team { get; set; }

        public override string ToString() => $"Player : {Name} in team : {Team}";

        public void Run(Location newlocation)
        {
            Console.WriteLine($"{this.ToString()} is Running Towards >>>>> {newlocation}");
        }

    }

    class Refree
    {
        public Refree(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string ToString() => $"Refree : {Name}";

        public void Look(Location newlocation)
        {
            Console.WriteLine($"{this.ToString()} is looking at >>>> {newlocation}");
        }

    }
}
