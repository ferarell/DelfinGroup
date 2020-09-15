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
      #region [ Cab_Operacion ]
      
      Boolean SaveCab_Operacion( ref Cab_Operacion Item);

      
      Cab_Operacion GetOneCab_Operacion(Int32 COPE_Codigo);


      ObservableCollection<Cab_Operacion> GetAllOperacionByFiltros(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin, Int32 x_FacCliente, Int32 x_FacProveedor, Nullable<Int32> x_COPE_Codigo);
      #endregion
   }
}
