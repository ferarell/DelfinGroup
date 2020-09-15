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
      System.Data.DataTable GetOneAnexosPrint(Int16 CCOT_Tipo, Int32 CCOT_Numero, Int16 ANEX_Item);
		#endregion

		#region [ Metodos ]
		#endregion
   }
}
