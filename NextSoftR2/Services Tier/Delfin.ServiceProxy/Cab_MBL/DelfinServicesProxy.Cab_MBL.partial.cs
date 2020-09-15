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
      public Cab_MBL GetOneCab_MBLByNumero(String CMBL_Numero)
      {
         try
         {
            return BL_Cab_MBL.GetOneByNumero(CMBL_Numero);
         }
         catch (Exception)
         { throw; }
      }
		#endregion

		#region [ Metodos ]
		#endregion
   }
}
