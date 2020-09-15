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
	public partial interface IBLDetNaveViaje
	{
		#region [ Consultas ]
      ObservableCollection<DetNaveViaje> GetAllByNaveViaje(Int32 NVIA_Codigo);
      ObservableCollection<DetNaveViaje> GetAllAyuda(String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Int32 PUER_CodOrigen, Int32 PUER_CodDestino, DateTime CCOT_Fecha, String NVIA_NroViaje);
      DetNaveViaje GetOneByOV(String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Int32 PUER_CodOrigen, Int32 PUER_CodDestino, Int32 NVIA_Codigo);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
