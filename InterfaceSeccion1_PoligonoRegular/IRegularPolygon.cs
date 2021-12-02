using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSeccion1_PoligonoRegular
{
    public interface IRegularPolygon
    {
        //Estas propiedades y métodos son Public por defecto.
        int NumberOfSides { get; set; }
        int SideLength { get; set; }

        double GetPerimeter();
        double GetArea();
    }
}
