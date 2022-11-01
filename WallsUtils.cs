using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Plumbing;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingLibrary
{
    public class WallsUtils
    {
        public static List<Wall> GetWallSystems(ExternalCommandData commandData) 
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            List<Wall> WallSystemTypes = new FilteredElementCollector(doc)
                                                     .OfClass(typeof(Wall))
                                                     .Cast<Wall>()
                                                     .ToList();
            return WallSystemTypes;
        }
    }
}
