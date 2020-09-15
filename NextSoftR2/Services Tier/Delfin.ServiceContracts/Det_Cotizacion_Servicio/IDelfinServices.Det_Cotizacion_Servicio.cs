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
      #region [ Det_Cotizacion_Servicio ]
      
      Boolean SaveDet_Cotizacion_Servicio(ref Det_Cotizacion_Servicio Item);

      
      Det_Cotizacion_Servicio GetOneDet_Cotizacion_Servicio(Int32 CCOT_Codigo, Int32 SCOT_Item);

      
      ObservableCollection<Det_Cotizacion_Servicio> GetAllDet_Cotizacion_ServicioByCotizacion(Int32 x_CCOT_Codigo, String x_SCOT_Tipo);
      #endregion
   }
}
