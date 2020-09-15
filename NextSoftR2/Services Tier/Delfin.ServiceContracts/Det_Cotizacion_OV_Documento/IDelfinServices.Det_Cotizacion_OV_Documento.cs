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
      #region [ Det_Cotizacion_OV_Documento ]
      
      Boolean SaveDet_Cotizacion_OV_Documento(Det_Cotizacion_OV_Documento Item);

      
      Det_Cotizacion_OV_Documento GetOneDet_Cotizacion_OV_Documento(Int32 CCOT_Numero, Int32 DOOV_Codigo, Int16 CCOT_Tipo);

      
      ObservableCollection<Det_Cotizacion_OV_Documento> GetAllDet_Cotizacion_OV_Documento();
      #endregion
   }
}
