using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.DataAccess;

namespace Delfin.ServiceProxy
{
   using Delfin.ServiceContracts;
   using Delfin.BusinessLogic;
   using Delfin.Entities;

   public partial class DelfinServicesProxy : IDelfinServices
   {

      public System.Data.DataTable PrintCotizacion(Int32 x_CCOT_Codigo)
      {
         try
         {
            return BL_Cab_Cotizacion.PrintCotizacion(x_CCOT_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
       public Boolean AprobarAnularCotizacion(Int32 x_CCOT_Codigo, String x_Estado, String x_AUDI_UsrMod)
       {
           try
           {
               return BL_Cab_Cotizacion.AprobarAnularCotizacion(x_CCOT_Codigo, x_Estado, x_AUDI_UsrMod);  
           }
           catch (Exception ex)
           { throw ex; }
       }
   }
}
