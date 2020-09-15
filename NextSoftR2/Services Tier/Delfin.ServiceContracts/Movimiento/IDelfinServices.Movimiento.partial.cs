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
      #region [ Consultas ]

      
      Movimiento GetOneMovimiento(Int16 EMPR_Codigo, Int32 MOVI_Codigo, Entities.Movimiento.TInterfazMovimiento x_opcion);

      #endregion

      #region [ Metodos ]
            
      Boolean SaveMovimientoAnular(ref Movimiento Item);
            
      Boolean SaveMovimiento(ref Movimiento Item, Entities.Movimiento.TInterfazMovimiento x_opcion);

      Boolean SaveMovimiento(ref ObservableCollection<Movimiento> Items, Movimiento.TInterfazMovimientos x_opcion);

      #endregion
   }
}
