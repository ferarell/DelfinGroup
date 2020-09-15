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
      #region [ Tarifa ]
      
      Boolean SaveTarifa(Tarifa Item);

      
      Boolean SaveTarifas(ObservableCollection<Tarifa> Items);

      
      Tarifa GetOneTarifa(Int32 TARI_Codigo);

      
      ObservableCollection<Tarifa> GetAllTarifa();
      #endregion
   }
}
