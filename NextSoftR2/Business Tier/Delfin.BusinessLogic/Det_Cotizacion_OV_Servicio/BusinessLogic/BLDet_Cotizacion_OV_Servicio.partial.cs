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
	public partial class BLDet_Cotizacion_OV_Servicio
	{
		#region [ Consultas ]
      public ObservableCollection<Det_Cotizacion_OV_Servicio> GetAllByCab_Cotizacion_OV(Int16 CCOT_Tipo, Int32 CCOT_Numero)
      {
         try
         {
            if (CCOT_Tipo == null || CCOT_Numero == null ) { return null; }
            return SelectAllByCab_Cotizacion_OV(CCOT_Tipo, CCOT_Numero);
         }
         catch (Exception ex)
         { throw ex; }
      }
		#endregion
		
		#region [ Metodos ]
      public Boolean SaveDocumento(ref Det_Cotizacion_OV_Servicio Item)
      {
         try
         {
            return UpdateDocumento(ref Item);
         }
         catch (Exception)
         { throw; }
      }
		#endregion
	}
}
