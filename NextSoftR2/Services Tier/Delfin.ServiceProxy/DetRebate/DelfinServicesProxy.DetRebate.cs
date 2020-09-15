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
      #region [ DetRebate ]
      public Boolean SaveDetRebate(DetRebate Item)
      {
         try
         { return base.Channel.SaveDetRebate(Item); }
         catch (Exception ex)
         { throw ex; }
      }

      public DetRebate GetOneDetRebate(Int32 DREB_Codigo)
      {
         try
         { return base.Channel.GetOneDetRebate(DREB_Codigo); }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<DetRebate> GetAllDetRebate()
      {
         try
         { return base.Channel.GetAllDetRebate(); }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
