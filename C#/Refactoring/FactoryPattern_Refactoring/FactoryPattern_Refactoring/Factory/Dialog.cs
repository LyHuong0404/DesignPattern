using FactoryPattern_Refactoring.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Refactoring.Factory
{
    public abstract class Dialog
    {
        public void RenderWindow()
        {
            IButton OkButton = CreateButton();
            OkButton.render();
        }

        public abstract IButton CreateButton();
    }
}
