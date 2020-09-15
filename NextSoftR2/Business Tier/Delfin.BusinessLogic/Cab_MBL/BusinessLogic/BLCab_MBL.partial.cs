using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLCab_MBL
	{
		#region [ Consultas ]
      public Cab_MBL GetOneByNumero(String CMBL_Numero)
      {
         try
         {
            return SelectOneByNumero(CMBL_Numero);
         }
         catch (Exception)
         { throw; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
