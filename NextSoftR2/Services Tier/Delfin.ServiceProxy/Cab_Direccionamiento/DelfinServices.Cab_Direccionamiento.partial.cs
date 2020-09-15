using System;
using System.Data;
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
      public Boolean SaveDepTemporal(DataTable _dt)
      {
         try
         {
            return BL_Cab_Direccionamiento.SaveDepTemporal(_dt);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public DataTable GetForward(String Buque, String Viaje)
      {
         try
         {
            return BL_Cab_Direccionamiento.GetForward(Buque, Viaje);
         }
         catch (Exception ex)
         { throw ex; }
      }
   }
}
