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
	public partial class BLDet_Seguimientos
	{
		#region [ Consultas ]
        public ObservableCollection<Det_Seguimientos> GetAllByCabSeguimiento(Int32 x_CSEG_Codigo)
        {
            try
            {
                return SelectAllByCabSeguimiento(x_CSEG_Codigo);
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
