using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingLibrary
{
    public class DuctUtils
    {
        public static MEPSystemType GetDuctSystemTypes(ExternalCommandData commandData)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;


            MEPSystemType DuctSystemTypes = new FilteredElementCollector(doc)
                                      .OfClass(typeof(MEPSystemType))
                                      .Cast<MEPSystemType>()
                                      .FirstOrDefault(m => m.SystemClassification == MEPSystemClassification.SupplyAir);
            return DuctSystemTypes;
        }
    }
}
