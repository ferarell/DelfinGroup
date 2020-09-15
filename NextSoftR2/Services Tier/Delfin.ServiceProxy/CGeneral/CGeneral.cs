using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.DataAccess;
using Delfin.ServiceContracts;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.ServiceProxy
{

   public partial class DelfinServicesProxy : IDelfinServices
   {
      #region [ Propiedades ]
      [Dependency]
      public ICGeneral BL_CGeneral { get; set; }
      #endregion

      public DateTime GetFecha()
      {
         try
         {
            return BL_CGeneral.GetFecha();
         }
         catch (Exception)
         { throw; }
      }

      public String getNameServer()
      {
         try
         {
            return BL_CGeneral.getNameServer();
         }
         catch (Exception)
         { throw; }
      }

      public String getNameInstancia()
      {
         try
         {
            return BL_CGeneral.getNameInstancia();
         }
         catch (Exception)
         { throw; }
      }

      public String getNameDataBase()
      {
         try
         {
            return BL_CGeneral.getNameDataBase();
         }
         catch (Exception)
         { throw; }
      }
   }
}
