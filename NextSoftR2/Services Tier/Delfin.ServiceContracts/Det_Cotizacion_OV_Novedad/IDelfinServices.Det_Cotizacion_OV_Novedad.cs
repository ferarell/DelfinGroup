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
      #region [ Det_Cotizacion_OV_Novedad ]
      
      Boolean SaveDet_Cotizacion_OV_Novedad(Det_Cotizacion_OV_Novedad Item);

      
      Det_Cotizacion_OV_Novedad GetOneDet_Cotizacion_OV_Novedad(Int32 OVNO_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo);

      
      ObservableCollection<Det_Cotizacion_OV_Novedad> GetAllDet_Cotizacion_OV_Novedad();
      #endregion
   }
}
