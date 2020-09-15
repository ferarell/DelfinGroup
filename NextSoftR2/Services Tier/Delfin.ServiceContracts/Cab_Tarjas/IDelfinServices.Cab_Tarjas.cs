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
      #region [ Cab_Tarjas ]
      
       Boolean SaveCab_Tarjas(ref Cab_Tarjas Item);

      
      Cab_Tarjas GetOneCab_Tarjas(Int32 TARJ_Codigo);

      
      ObservableCollection<Cab_Tarjas> GetAllCab_Tarjas();
      #endregion
   }
}
