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
	public partial interface IBLTiposEntidad
	{
		#region [ Consultas ]
		ObservableCollection<TiposEntidad> GetAll();
		TiposEntidad GetOne(Int16 TIPE_Codigo);
        ObservableCollection<TiposEntidad> GetAllTIPE_Relacionados();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref TiposEntidad Item);
		Boolean Save(ref ObservableCollection<TiposEntidad> Items);
		#endregion
	}
}
