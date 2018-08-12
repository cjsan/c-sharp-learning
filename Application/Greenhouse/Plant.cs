using System;
namespace Application
{
    public class Plant
    {
        public string _name;
        public int _amount;
        public double _height;

        public Plant(string name, int amount, double height)
        {
            _name = name;
            _amount = amount;
            _height = height;
        }
    }
}
