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
	public partial class BLDetNaveViaje
	{
		#region [ Consultas ]
      public ObservableCollection<DetNaveViaje> GetAllByNaveViaje(Int32 NVIA_Codigo)
      {
         try
         {
            return SelectAllByNaveViaje(NVIA_Codigo);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DetNaveViaje> GetAllAyuda(String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Int32 PUER_CodOrigen, Int32 PUER_CodDestino, DateTime CCOT_Fecha, String NVIA_NroViaje)
      {
         try
         {
            return SelectAllAyuda(CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, PUER_CodOrigen, PUER_CodDestino, CCOT_Fecha, NVIA_NroViaje);
         }
         catch (Exception)
         { throw; }
      }
      public DetNaveViaje GetOneByOV(String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Int32 PUER_CodOrigen, Int32 PUER_CodDestino, Int32 NVIA_Codigo)
      {
         try
         {
            return SelectOneByOV(CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, PUER_CodOrigen, PUER_CodDestino, NVIA_Codigo);
         }
         catch (Exception)
         { throw; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
