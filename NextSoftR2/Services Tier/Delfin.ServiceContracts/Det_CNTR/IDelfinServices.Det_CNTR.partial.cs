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
      System.Data.DataTable GetAllDet_CntrByNaveViaje(Nullable<Int32> NVIA_Codigo, Int16 TIPO_Vobo, Nullable<Int32> CCOT_Codigo);
      System.Data.DataSet GetAllDet_CntrByPrintMatriz(Int16 CCOT_Tipo, Int32 CCOT_Numero);
      #endregion

      #region [ Metodos ]
      #endregion
   }
}