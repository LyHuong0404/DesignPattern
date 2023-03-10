using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Refactoring.Buttons
{
    public class HtmlButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("Click! Button says - 'Hello World!'");
        }

        public void render()
        {
            Console.WriteLine("<button>Test Button</button>");
            OnClick();
        }
    }
}
