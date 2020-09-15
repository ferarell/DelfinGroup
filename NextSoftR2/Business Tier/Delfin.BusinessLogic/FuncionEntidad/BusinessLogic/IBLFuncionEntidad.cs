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
	public partial interface IBLFuncionEntidad
	{
		#region [ Consultas ]
		ObservableCollection<FuncionEntidad> GetAll();
		FuncionEntidad GetOne(Int32 ENTC_Codigo, Int16 TIPE_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref FuncionEntidad Item);
		Boolean Save(ref ObservableCollection<FuncionEntidad> Items);
		#endregion
	}
}
