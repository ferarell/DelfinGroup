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
      #region [ Cab_Seguimientos ]
      
      Boolean SaveCab_Seguimientos(ref Cab_Seguimientos Item);

      
      Cab_Seguimientos GetOneCab_Seguimientos(Int32 CSEG_Codigo);

       
       ObservableCollection<Cab_Seguimientos> GetAllByCabSeguimientoByFiltros(DateTime x_CSEG_FechaEmisionIni,DateTime x_CSEG_FechaEmisionFin, String x_Nave);

       #endregion
   }
}
