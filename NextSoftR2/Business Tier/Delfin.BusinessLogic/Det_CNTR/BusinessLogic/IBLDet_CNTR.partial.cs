using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial interface IBLDet_CNTR
   {
      #region [ Consultas ]
      System.Data.DataTable GetAllDet_CntrByNaveViaje(Nullable<Int32> NVIA_Codigo, Int16 TIPO_Vobo, Nullable<Int32> CCOT_Codigo);
      System.Data.DataSet GetAllByPrintMatriz(Int16 CCOT_Tipo, Int32 CCOT_Numero);
      #endregion

      #region [ Metodos ]

      #endregion
   }
}