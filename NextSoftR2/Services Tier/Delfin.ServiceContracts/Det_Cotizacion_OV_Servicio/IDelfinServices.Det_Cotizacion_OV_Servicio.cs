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
      #region [ Det_Cotizacion_OV_Servicio ]
      
      Boolean SaveDet_Cotizacion_OV_Servicio(ref Det_Cotizacion_OV_Servicio Item, Boolean Tran);

      
      Det_Cotizacion_OV_Servicio GetOneDet_Cotizacion_OV_Servicio(Int16 CCOT_Tipo, Int32 CCOT_Numero, Int32 SCOT_Item);

      
      ObservableCollection<Det_Cotizacion_OV_Servicio> GetAllDet_Cotizacion_OV_Servicio();
      #endregion
   }
}
