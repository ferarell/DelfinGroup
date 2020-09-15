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
      #region [ Det_Operacion ]
      
      Boolean SaveDet_Operacion(Det_Operacion Item);

      
      Det_Operacion GetOneDet_Operacion(Int32 DOPE_Item, Int32 COPE_Codigo);

      
      ObservableCollection<Det_Operacion> GetAllDet_OperacionByOperacion(Int32 x_COPE_Codigo);
      #endregion
   }
}
