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
	public partial interface IBLDetDocsVta
	{
		#region [ Consultas ]
		ObservableCollection<DetDocsVta> GetAll();
		DetDocsVta GetOne(Int16 DDOV_Item, Int32 DOCV_Codigo);
		#endregion
		
		#region [ Metodos ]
		Boolean Save( DetDocsVta Item);
		Boolean Save(ref ObservableCollection<DetDocsVta> Items);
		#endregion
	}
}
