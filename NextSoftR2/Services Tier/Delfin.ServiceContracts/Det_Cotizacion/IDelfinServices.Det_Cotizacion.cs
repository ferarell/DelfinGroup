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
      #region [ Det_Cotizacion ]
      
      Boolean SaveDet_Cotizacion(ref Det_Cotizacion Item);

      
      Det_Cotizacion GetOneDet_Cotizacion(Int32 CCOT_Codigo, Int32 DCOT_Item);

      
      ObservableCollection<Det_Cotizacion> GetAllDet_CotizacionByCotizacion(Int32 x_CCOT_Codigo, String x_CTAR_Tipo);
      #endregion
   }
}
