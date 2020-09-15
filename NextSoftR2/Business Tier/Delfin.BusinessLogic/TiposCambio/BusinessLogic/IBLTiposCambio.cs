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
   public partial interface IBLTiposCambio
   {
      #region [ Consultas ]
      ObservableCollection<TiposCambio> GetAll(String x_TIPC_AnoMes);
      TiposCambio GetOne(String TIPC_Fecha);
      #endregion

      #region [ Metodos ]
      Boolean Save( TiposCambio item);
      Boolean Save( ObservableCollection<TiposCambio> Items);
      #endregion
   }
}
