using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLDet_CNTR
   {
      #region [ Consultas ]
      public System.Data.DataTable GetAllDet_CntrByNaveViaje(Nullable<Int32> NVIA_Codigo, Int16 TIPO_Vobo, Nullable<Int32> CCOT_Codigo)
      {
         try
         {
            return SelectAllDet_CntrByNaveViaje(NVIA_Codigo, TIPO_Vobo, CCOT_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public System.Data.DataSet GetAllByPrintMatriz(Int16 CCOT_Tipo, Int32 CCOT_Numero)
      {
         try
         {
            return SelectAllByPrintMatriz(CCOT_Tipo, CCOT_Numero);
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Metodos ]

      #endregion
   }
}