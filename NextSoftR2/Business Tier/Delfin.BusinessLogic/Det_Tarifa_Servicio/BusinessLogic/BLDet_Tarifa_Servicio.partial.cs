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
	public partial class BLDet_Tarifa_Servicio
	{
		#region [ Consultas ]
        public  ObservableCollection<Det_Tarifa_Servicio> GetAllDet_ServicioByTarifario(Int32 x_CTAR_Codigo, String x_CTAR_Tipo)
        {
            try
            {
                return SelectAllByTarifario(x_CTAR_Codigo, x_CTAR_Tipo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Det_Tarifa_Servicio> GetAllServiciosTarifaByCotizacion(Int32? x_CTAR_CodigoLogistico, Int32? x_CTAR_CodigoAduanero)
        {
            try
            {
                return SelectAllServiciosTarifaByCotizacion(x_CTAR_CodigoLogistico, x_CTAR_CodigoAduanero);        
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
