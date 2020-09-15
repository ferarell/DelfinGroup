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
		ObservableCollection<Ubigeos> GetAll();
		Ubigeos GetOne(String UBIG_Codigo, String TIPO_CodPais, String TIPO_TabPais);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Ubigeos Item);
		Boolean Save(ref ObservableCollection<Ubigeos> Items);
		#endregion
	}
}
