using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_shoes
{
    class Shoe
    {
        public EStyle Style { get; private set; }

        public string Color { get; private set; }

        public Shoe(EStyle style, string color)
        {
            Style = style;
            Color = color;
        }

        public string Description
        {
            get
            {
                return $"{Color} {Style}";
            }
        }
    }
}
