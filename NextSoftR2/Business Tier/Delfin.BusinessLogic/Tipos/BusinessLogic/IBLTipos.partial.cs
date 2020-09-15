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
	public partial interface IBLTipos
	{
		#region [ Consultas ]
      String UsuarioTipos { get; set; }
      ObservableCollection<Tipos> GetAllByTipoCodTabla(String TIPO_CodTabla);
      ObservableCollection<Tipos> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
