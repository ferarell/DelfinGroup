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
      #region [ Det_Cotizacion_OV_Archivo ]
      
      Boolean SaveDet_Cotizacion_OV_Archivo(Det_Cotizacion_OV_Archivo Item);

      
      Det_Cotizacion_OV_Archivo GetOneDet_Cotizacion_OV_Archivo(Int32 OVAR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo);

      
      ObservableCollection<Det_Cotizacion_OV_Archivo> GetAllDet_Cotizacion_OV_Archivo();
      #endregion
   }
}
