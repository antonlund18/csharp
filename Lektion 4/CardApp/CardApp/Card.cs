using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApp
{
    class Card
    {
        public Cards Number { get; set; }
        public Colors Color { get; set; }

        public Card(int number, int color)
        {
            Number = (Cards)Enum.ToObject(typeof(Cards), number);
            Color = (Colors)Enum.ToObject(typeof(Colors), color);
        }

        public override string ToString()
        {
            return $"{Number} of {Color}";
        }
    }
}
