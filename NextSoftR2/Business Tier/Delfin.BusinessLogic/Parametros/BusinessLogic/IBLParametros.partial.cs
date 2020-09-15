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
	public partial interface IBLParametros
	{
		#region [ Consultas ]
      
      String UsuarioParametros { get; set; }

      Parametros GetOneByClave(String PARA_Clave);

      ObservableCollection<Parametros> GetAllByClave(String PARA_Clave);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
