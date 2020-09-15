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
	public partial class BLDet_Tarifa
	{
		#region [ Consultas ]
        public ObservableCollection<Det_Tarifa> GetAllDet_TarifaByTarifario(Int32 x_CTAR_Codigo, String x_CTAR_Tipo)
        {
            try
            {
                return SelectAllByTarifa(x_CTAR_Codigo, x_CTAR_Tipo);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Det_Tarifa> GetAllTarifasByCotizacion(Int32? x_CTAR_CodigoLogistico, Int32? x_CTAR_CodigoAduanero, Int32? x_CTAR_CodigoTransporte,Boolean x_Filtros)
        {
            try
            {
                return SelectAllTarifasByCotizacion(x_CTAR_CodigoLogistico, x_CTAR_CodigoAduanero, x_CTAR_CodigoTransporte,x_Filtros);
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
