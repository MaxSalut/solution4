using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal interface IGeographicalObject
{
   public double X { get; set; }
   public double Y { get; set; }
   public string Name { get; set; }
   public string Description { get; set; }
   public string GetInformationSource();
   public void printInfo();
}

