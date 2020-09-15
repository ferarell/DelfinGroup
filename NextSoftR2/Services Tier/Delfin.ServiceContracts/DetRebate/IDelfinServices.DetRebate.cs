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
      #region [ DetRebate ]
      
      Boolean SaveDetRebate(DetRebate Item);

      
      DetRebate GetOneDetRebate(Int32 DREB_Codigo);

      
      ObservableCollection<DetRebate> GetAllDetRebate();
      #endregion
   }
}
