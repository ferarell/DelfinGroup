using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial interface IBLCab_Operacion
   {
      #region [ Consultas ]

      ObservableCollection<Cab_Operacion> GetAllByFiltros(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin, Int32 x_FacCliente, Int32 x_FacProveedor, Nullable<Int32> x_COPE_Codigo);
      Cab_Operacion GetOne(Int32 COPE_Codigo);
      #endregion

      #region [ Metodos ]
      Boolean Save(ref Cab_Operacion Item);
      Boolean Save(ref ObservableCollection<Cab_Operacion> Items);
      #endregion
   }
}
