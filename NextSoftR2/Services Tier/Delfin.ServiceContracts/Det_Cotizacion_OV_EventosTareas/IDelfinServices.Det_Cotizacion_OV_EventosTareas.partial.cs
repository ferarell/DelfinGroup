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
      ObservableCollection<Det_Cotizacion_OV_EventosTareas> GetAllDet_Cotizacion_OV_EventosTareasByCotizacion_OV(Int32 CCOT_Numero, Int16 CCOT_Tipo);
   }
}
