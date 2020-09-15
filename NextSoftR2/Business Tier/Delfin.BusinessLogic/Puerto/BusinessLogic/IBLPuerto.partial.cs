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
	public partial interface IBLPuerto
	{
      String UsuarioPuertos { get; set; }

		#region [ Consultas ]
      ObservableCollection<Puerto> GetAllByVia(String CONS_TabVia, String CONS_CodVia);
      Puerto GetOneByCodEstandar(String CONS_TabVia, String CONS_CodVia, String PUER_CodEstandar);
      ObservableCollection<Puerto> GetAllByAyuda(String CONS_TabVia, String CONS_CodVia, String TIPO_TabPais, String TIPO_CodPais, String PUER_CodEstandar, String PUER_Nombre);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
