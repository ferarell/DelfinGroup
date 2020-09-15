using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Collections.ObjectModel;

namespace Delfin.ServiceProxy
{
   using Delfin.Entities;

   public partial class DelfinServicesProxy : ClientBase<ServiceContracts.IDelfinServices>, ServiceContracts.IDelfinServices
   {
      #region [ correlativos ]
      public Boolean Savecorrelativos(correlativos Item)
      {
         try
         { return base.Channel.Savecorrelativos(Item); }
         catch (Exception ex)
         { throw ex; }
      }

      public correlativos GetOnecorrelativos(String CORR_ServerName, String CORR_CodCorr)
      {
         try
         { return base.Channel.GetOnecorrelativos(CORR_ServerName, CORR_CodCorr); }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<correlativos> GetAllcorrelativos()
      {
         try
         { return base.Channel.GetAllcorrelativos(); }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
