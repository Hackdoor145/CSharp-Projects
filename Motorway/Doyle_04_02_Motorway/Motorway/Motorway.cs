using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doyle_04_02_Motorway
{
    class Motorway
    {
        public string Name { get; set; }
        public string MotorwayType { get; set; }
        public char Direction { get; set; }
        public string Surface { get; set; }
        public int NumberOfLanes { get; set; }
        public bool Toll { get; set; }
        public string Maintenance { get; set; }

        public Motorway(string name, string type, char direction, string surface, int numOfLanes, bool toll, string maint)
        {
            Name = name;
            MotorwayType = type;
            Direction = direction;
            Surface = surface;
            NumberOfLanes = numOfLanes;
            Toll = toll;
            Maintenance = maint;
        }

        public Motorway(string name)
        {
            Name = name;
        }

        public Motorway(string name, bool toll)
        {
            Name = name;
            Toll = toll;
        }

        public Motorway(string name, int numOfLanes)
        {
            Name = name;
            NumberOfLanes = numOfLanes;
        }

        public override string ToString()
        {
            return $"Motorway Name: {Name}\n" +
                    $"Motorway Type: {MotorwayType}\n" +
                    $"Direction: {Direction}\n" +
                    $"Surface: {Surface}\n" +
                    $"Number Of Lanes: {NumberOfLanes}\n" +
                    $"Toll: {Toll}\n" +
                    $"Maintenance: {Maintenance}";
        }
    }
}
