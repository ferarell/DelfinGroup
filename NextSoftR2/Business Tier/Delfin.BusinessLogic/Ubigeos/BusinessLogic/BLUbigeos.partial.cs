using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLUbigeos
	{
		#region [ Consultas ]
      public ObservableCollection<Ubigeos> GetAllUbigeosbyFilter(string x_codubigeo, string x_codpais, string x_tabpais)
      {
         try
         {
            return SelectAll(x_codubigeo, x_codpais, x_tabpais);
         }
         catch (Exception ex)
         { throw ex; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
