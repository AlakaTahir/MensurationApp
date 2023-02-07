using Mensuration.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mensuration.Logic
{
    public class AreaLogic
    {
        public double CreateCircle(Circle_AreaModel model)
        {
            double Pi = 3.75;
            double result = model.Radius*model.Radius*Pi;
            return result;
        }

        public double Createrectangle(Rectangle_AreaModel model)
        {
            var result = model.Length * model.Breadth;
            return result;
        }

        public double CreateTriangle(Triangle_AreaModel model)
        {
            var result = (model.Base * model.Height) / 2;
            return result;
        }
    }
}
