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
	public partial interface IBLTarifa
	{
		#region [ Consultas ]
      ObservableCollection<Entities.Tarifa> GetAllByContrato(Int32 CONT_Codigo);
      System.Data.DataTable GetAllByContratoGrilla(Nullable<Int32> CONT_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, String TIPO_TabMND, String TIPO_CodMND, Nullable<Int32> PACK_Codigo, String TIPO_TabPAI, String TIPO_CodPAI, Nullable<Int32> PUER_Codigo);
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
