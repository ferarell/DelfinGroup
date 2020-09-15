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
      #region [ Det_Cotizacion_OV_Flete ]
      
      Boolean SaveDet_Cotizacion_OV_Flete(Det_Cotizacion_OV_Flete Item);

      
      Det_Cotizacion_OV_Flete GetOneDet_Cotizacion_OV_Flete(Int32 CCOT_Numero, Int32 DCOT_Item, Int16 CCOT_Tipo);

      
      ObservableCollection<Det_Cotizacion_OV_Flete> GetAllDet_Cotizacion_OV_Flete();
      #endregion
   }
}
