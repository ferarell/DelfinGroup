using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; 
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
      public DataTable SendMail()
      {
         {
            try
            {
               return BL_Cab_Seguimientos.SendMail();
            }
            catch (Exception ex)
            { throw ex; }
         }
      }

      public bool GetExisteSeguimientoOperacion(Cab_Seguimientos item)
      {
          try
          {
              return BL_Cab_Seguimientos.GetExisteSeguimientoOperacion(item);
          }
          catch (Exception ex)
          { throw ex; }
      }
   }
}
