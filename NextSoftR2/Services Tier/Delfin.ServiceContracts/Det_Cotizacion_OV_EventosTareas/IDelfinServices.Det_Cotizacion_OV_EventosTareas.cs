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
      #region [ Det_Cotizacion_OV_EventosTareas ]
      
      Boolean SaveDet_Cotizacion_OV_EventosTareas(Det_Cotizacion_OV_EventosTareas Item);

      Boolean SaveDet_Cotizacion_OV_EventosTareas(ObservableCollection<Det_Cotizacion_OV_EventosTareas> Items);

      Det_Cotizacion_OV_EventosTareas GetOneDet_Cotizacion_OV_EventosTareas(Int32 CCOT_Numero, Int16 CCOT_Tipo, Int16 EVEN_Item);

      
      ObservableCollection<Det_Cotizacion_OV_EventosTareas> GetAllDet_Cotizacion_OV_EventosTareas();
      #endregion
   }
}
