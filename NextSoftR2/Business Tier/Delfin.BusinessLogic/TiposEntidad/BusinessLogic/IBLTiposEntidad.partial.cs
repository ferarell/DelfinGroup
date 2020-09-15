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

	   ObservableCollection<TiposEntidad> GetTodos();

	   #endregion

	   #region [ Metodos ]

	   #endregion
	}
}
