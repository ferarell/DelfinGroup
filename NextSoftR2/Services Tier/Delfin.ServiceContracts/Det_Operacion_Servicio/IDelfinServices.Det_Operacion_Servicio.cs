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
      #region [ Det_Operacion_Servicio ]
      
      Boolean SaveDet_Operacion_Servicio(Det_Operacion_Servicio Item);

      
      Det_Operacion_Servicio GetOneDet_Operacion_Servicio(Int32 SOPE_Item, Int32 COPE_Codigo);

      
      ObservableCollection<Det_Operacion_Servicio> GetAllDet_Operacion_ServicioByOperacion(Int32 x_COPE_Codigo);
      #endregion
   }
}
