using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11WorkingWithTests
{
    public class Car
    {
        private static List<string> _allowedColors = new List<string> { "black", "white", "red", "blue" };
       
        private string _color = _allowedColors[0];
        private int _doors = 2;
        public string Color
        {
            get => _color;
            set
            {
                if (!_allowedColors.Contains(value.ToLower()))
                    throw new Exception($"Invalid color value of {value}");

                _color = value;
            }
        }

        public int Doors {
            get => _doors; 
            set {
                if (value == 2 || value == 4 || value == 5)
                {
                    _doors = value;
                    return;
                }

                throw new Exception($"Invalid doors value of {value}");

                } 
        }

        public override string ToString() => $"Color = {_color} & Doors = {_doors}";
        
    }
}
