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
	public partial interface IBLUbigeos
	{
		#region [ Consultas ]
      ObservableCollection<Ubigeos> GetAllUbigeosbyFilter(string x_codubigeo, string x_codpais, string x_tabpais);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
