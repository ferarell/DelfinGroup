using System;
using System.Linq;
using System.Text;
using System.Data; 
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLCab_Seguimientos
	{
		#region [ Consultas ]
      public DataTable SendMail()
      {
         try
         {
            return EnviaCorreo();
         }
         catch (Exception ex)
         { throw ex; }
      }
		#endregion
		
		#region [ Metodos ]
		public bool GetExisteSeguimientoOperacion(Cab_Seguimientos item)
        {
            try
            {
                return ExisteOperacion(item);
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
	}
}
