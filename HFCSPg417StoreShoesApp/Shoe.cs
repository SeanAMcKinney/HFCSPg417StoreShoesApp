using System;
using System.Collections.Generic;
using System.Text;

namespace HFCSPg417StoreShoesApp
{
    public class Shoe
    {
        public ShoeStyle Style { get; private set; }
        public string Color { get; private set; }

        public Shoe(ShoeStyle style, string color)
        {
            Style = style;
            Color = color;
        }

        public string Description { get { return $"A {Color} {Style}"; } }
    }
}
