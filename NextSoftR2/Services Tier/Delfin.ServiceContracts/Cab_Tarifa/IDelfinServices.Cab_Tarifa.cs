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
      #region [ Cab_Tarifa ]
      
      Boolean SaveCab_Tarifa( ref Cab_Tarifa Item);

      
      Cab_Tarifa GetOneCab_Tarifa(String CTAR_Tipo, Int32 CTAR_Codigo);

      
      ObservableCollection<Cab_Tarifa> GetAllCab_Tarifa();
      #endregion
   }
}
