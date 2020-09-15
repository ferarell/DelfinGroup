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
	public partial interface IBLContrato_Comodity
	{
		#region [ Consultas ]
		ObservableCollection<Contrato_Comodity> GetAll();
		Contrato_Comodity GetOne(Int32 CONT_Codigo, String TIPO_TabCDT, String TIPO_CodCDT);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Contrato_Comodity Item);
		Boolean Save(ref ObservableCollection<Contrato_Comodity> Items);
		#endregion
	}
}
