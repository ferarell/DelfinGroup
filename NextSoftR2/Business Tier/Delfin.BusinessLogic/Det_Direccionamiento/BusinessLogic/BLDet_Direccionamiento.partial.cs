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
	public partial class BLDet_Direccionamiento
	{
		#region [ Consultas ]
      public System.Data.DataTable GetDetalleForward(Int32 _Operacion)
      {
         try
         {
            return SelectDetalleForward(_Operacion);
         }
         catch (Exception ex)
         { throw ex; }
      }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
