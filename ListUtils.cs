using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingLibrary
{
    public class ListUtils
    {
        public static List<ViewSheet> GetSheet(Document doc) 
        {
            var TitleBlocks = new FilteredElementCollector(doc)
               .OfCategory(BuiltInCategory.OST_TitleBlocks)
               .WhereElementIsElementType()
               .OfType<FamilySymbol>()
               .ToList();
        }
           
    }
}
