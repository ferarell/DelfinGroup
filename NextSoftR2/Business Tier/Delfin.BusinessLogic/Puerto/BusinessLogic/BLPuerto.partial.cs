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
	public partial class BLPuerto
	{
		#region [ Consultas ]
      public ObservableCollection<Puerto> GetAllByVia(String CONS_TabVia, String CONS_CodVia)
      {
         try
         {
            return SelectAllByVia(CONS_TabVia, CONS_CodVia);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public Puerto GetOneByCodEstandar(String CONS_TabVia, String CONS_CodVia, String PUER_CodEstandar)
      {
         try
         {
            return SelectOneByCodEstandar(CONS_TabVia, CONS_CodVia, PUER_CodEstandar);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Puerto> GetAllByAyuda(String CONS_TabVia, String CONS_CodVia, String TIPO_TabPais, String TIPO_CodPais, String PUER_CodEstandar, String PUER_Nombre)
      {
         try
         {
            return SelectAllByAyuda(CONS_TabVia, CONS_CodVia, TIPO_TabPais, TIPO_CodPais, PUER_CodEstandar, PUER_Nombre);
         }
         catch (Exception)
         { throw; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
