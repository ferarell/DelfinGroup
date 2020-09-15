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
	public partial interface IBLDet_Seguimientos
	{
		#region [ Consultas ]

	    ObservableCollection<Det_Seguimientos> GetAllByCabSeguimiento(Int32 x_CSEG_Codigo);

	    #endregion

	    #region [ Metodos ]

	    #endregion
	}
}
