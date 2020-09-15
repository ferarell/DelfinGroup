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
      #region [ Cab_Cotizacion ]
      Boolean SaveCab_Cotizacion(ref Cab_Cotizacion Item);
      
      Cab_Cotizacion GetOneCab_Cotizacion(Int32 CCOT_Codigo);
      ObservableCollection<Cab_Cotizacion> GetAllByFiltrosCab_Cotizacion(Int32? x_ENTC_Codigo, String x_CCOT_NumDoc, DateTime x_CCOT_FecEmiIni, DateTime x_CCOT_FecEmiFin);
      #endregion
   }
}
