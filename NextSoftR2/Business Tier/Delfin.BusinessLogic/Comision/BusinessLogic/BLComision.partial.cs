using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLComision
   {
      #region [ Consultas ]
      public Boolean GetValidar(Int32 COMI_Codigo, DateTime COMI_FecIni, DateTime COMI_FecFin)
      {
         try
         {
            return SelectValidar(COMI_Codigo, COMI_FecIni, COMI_FecFin);
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Metodos ]
      public Boolean SaveComisiones(ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters) //(Int32 NVIA_Codigo, String Usuario)
      {
         try
         {
            return UpdateComisiones(x_filters); //(NVIA_Codigo, Usuario);
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
