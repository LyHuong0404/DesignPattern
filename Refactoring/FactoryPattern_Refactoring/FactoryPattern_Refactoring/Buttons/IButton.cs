using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Refactoring.Buttons
{
    public interface IButton
    {
        void render();
        void OnClick();
    }
}
