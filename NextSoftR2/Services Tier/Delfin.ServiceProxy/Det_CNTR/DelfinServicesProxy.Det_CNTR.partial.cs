using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.DataAccess;
using Delfin.ServiceContracts;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.ServiceProxy
{
   public partial class DelfinServicesProxy : IDelfinServices
   {
      #region [ Consultas ]
      public System.Data.DataTable GetAllDet_CntrByNaveViaje(Nullable<Int32> NVIA_Codigo, Int16 TIPO_Vobo, Nullable<Int32> CCOT_Codigo)
      {
         try
         {
            return BL_Det_CNTR.GetAllDet_CntrByNaveViaje(NVIA_Codigo, TIPO_Vobo, CCOT_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public System.Data.DataSet GetAllDet_CntrByPrintMatriz(Int16 CCOT_Tipo, Int32 CCOT_Numero)
      {
         try
         {
            return BL_Det_CNTR.GetAllByPrintMatriz(CCOT_Tipo, CCOT_Numero);
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Metodos ]
      #endregion
   }
}
