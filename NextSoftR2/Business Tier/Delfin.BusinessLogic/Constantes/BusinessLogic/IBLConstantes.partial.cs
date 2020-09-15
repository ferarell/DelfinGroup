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
	public partial interface IBLConstantes
	{
		#region [ Consultas ]
      ObservableCollection<Constantes> GetAllByConstanteTabla(String CONS_CodTabla);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
