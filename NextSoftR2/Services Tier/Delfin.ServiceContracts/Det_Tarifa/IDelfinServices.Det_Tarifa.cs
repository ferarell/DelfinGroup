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
      #region [ Det_Tarifa ]
      
      Boolean SaveDet_Tarifa( ref Det_Tarifa Item);

      
      Boolean SavesDet_Tarifa(ref ObservableCollection<Det_Tarifa> Items);

      
      Det_Tarifa GetOneDet_Tarifa(Int32 CTAR_Codigo, String CTAR_Tipo, String DTAR_Item);

      
      ObservableCollection<Det_Tarifa> GetAllDet_Tarifa();
      #endregion
   }
}
