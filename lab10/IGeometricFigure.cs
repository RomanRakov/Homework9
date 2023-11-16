using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    interface IGeometricFigure
    {
        void MoveHorizontal(double distance);
        void MoveVertical(double distance);
        void ChangeColor(string color);
        bool IsVisible();
        void DisplayState();
    }

}
