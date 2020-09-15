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
      public System.Data.DataTable GetOneAnexosPrint(Int16 CCOT_Tipo, Int32 CCOT_Numero, Int16 ANEX_Item)
      {
         try
         {
            return BL_Anexos.GetOnePrint(CCOT_Tipo, CCOT_Numero, ANEX_Item);
         }
         catch (Exception)
         { throw; }
      }
		#endregion

		#region [ Metodos ]
		#endregion
   }
}
