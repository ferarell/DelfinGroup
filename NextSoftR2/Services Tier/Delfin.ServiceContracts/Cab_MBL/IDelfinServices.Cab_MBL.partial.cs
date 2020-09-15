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
      Cab_MBL GetOneCab_MBLByNumero(String CMBL_Numero);
		#endregion

		#region [ Metodos ]
		#endregion
   }
}
