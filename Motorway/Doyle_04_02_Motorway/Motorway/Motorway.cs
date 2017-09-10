using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doyle_04_02_Motorway
{
    class Motorway
    {
        public enum IsToll
        {
            Yes,
            No,
            Na
        }

        public enum Directions
        {
            North,
            East,
            South,
            West,
            Na
        }

        public string Name { get; set; }
        public string MotorwayType { get; set; } = "Na";
        public char Direction { get; set; }
        public string Surface { get; set; } = "Na";
        public int? NumberOfLanes { get; set; }
        public bool? Toll { get; set; }
        public string Maintenance { get; set; } = "Na";

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

        private IsToll IsMotorwayToll()
        {
            switch (Toll)
            {
                case true:
                    return IsToll.Yes;
                case false:
                    return IsToll.No;
                default:
                    return IsToll.Na;

            }
        }

        private Directions GetDirections()
        {
            switch(Direction)
            {
                case 'N':
                    return Directions.North;
                case 'E':
                    return Directions.East;
                case 'S':
                    return Directions.South;
                case 'W':
                    return Directions.West;
                default:
                    return Directions.Na;
            }
        }

        private string HowManyLanes()
        {
            if (NumberOfLanes == null)
                return "Na";
            else
                return NumberOfLanes.ToString();
        }

        public override string ToString()
        {
            return $"Motorway Name: {Name}\n" +
                    $"Motorway Type: {MotorwayType}\n" +
                    $"Direction: {GetDirections()}\n" +
                    $"Surface: {Surface}\n" +
                    $"Number Of Lanes: {HowManyLanes()}\n" +
                    $"Toll: {IsMotorwayToll()}\n" +
                    $"Maintenance: {Maintenance}";
        }
    }
}
