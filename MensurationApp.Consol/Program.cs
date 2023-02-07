using Mensuration.Logic;
using Mensuration.Model;
using System;

namespace MensurationApp.Consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaLogic _areaLogic = new AreaLogic();
            Circle_AreaModel modelum = new Circle_AreaModel();
            modelum.Radius = 5;


            Rectangle_AreaModel model = new Rectangle_AreaModel();
            model.Length = 5;
            model.Breadth = 6;

            Triangle_AreaModel modela = new Triangle_AreaModel();
            modela.Base = 5;
            modela.Height = 7;

            var result = _areaLogic.Createrectangle(model);
            Console.WriteLine(result);

            

            var resulting = _areaLogic.CreateTriangle(modela);
            Console.WriteLine(resulting);

            
            
            var resultof = _areaLogic.CreateCircle(modelum);
            Console.WriteLine(resultof);


        }
    }
}
