using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;

namespace Delfin.ServiceContracts
{
   public partial interface IDelfinServices
   {
      
      System.Data.DataTable PrintCotizacion(Int32 x_CCOT_Codigo);

       
       Boolean AprobarAnularCotizacion(Int32 x_CCOT_Codigo, String x_Estado, String x_AUDI_UsrMod);
   }
}
