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
	public partial class BLTarifa
	{
		#region [ Consultas ]
      public ObservableCollection<Entities.Tarifa> GetAllByContrato(Int32 CONT_Codigo)
      {
         try
         {
            return SelectAllByContrato(CONT_Codigo);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataTable GetAllByContratoGrilla(Nullable<Int32> CONT_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, String TIPO_TabMND, String TIPO_CodMND, Nullable<Int32> PACK_Codigo, String TIPO_TabPAI, String TIPO_CodPAI, Nullable<Int32> PUER_Codigo)
      {
         try
         {
            return SelectAllByContratoGrilla(CONT_Codigo, CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, TIPO_TabMND, TIPO_CodMND, PACK_Codigo, TIPO_TabPAI, TIPO_CodPAI, PUER_Codigo);
         }
         catch (Exception)
         { throw; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
