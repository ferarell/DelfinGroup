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
      #region [ Cab_Cotizacion_OV ]

      Cab_Cotizacion_OV SaveCab_Cotizacion_OV(Cab_Cotizacion_OV Item, ref String CCOT_MensajeError);
      Cab_Cotizacion_OV SaveCab_Cotizacion_OV(Cab_Cotizacion_OV Item, ref String CCOT_MensajeError, Cab_Cotizacion_OV.TipoInterfaz x_opcion);
      
      Cab_Cotizacion_OV GetOneCab_Cotizacion_OV(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo);

      
      ObservableCollection<Cab_Cotizacion_OV> GetAllCab_Cotizacion_OV(Int16 EMPR_Codigo, Int16 SUCR_Codigo);
      #endregion
   }
}
