using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;
 using System.Data;
namespace Delfin.BusinessLogic
{
	public partial interface IBLCab_Tarifa
	{
		#region [ Consultas ]
        ObservableCollection<Cab_Tarifa> GetAllByFiltros(Int32? LineaNaviera, Int32? AgMaritimo, Int32? DepTemporal,
        Int32? DepVacio, Int32? AgAduana, Int32? Transporte, DateTime FecEmiDesde, DateTime FecEmiHasta, String TipoTarifa);
        DataTable GetAllAyudaTarifa(String x_NroTarifa, String x_DescripTarifa, String x_CTAR_Tipo, Int32 x_CTAR_Codigo);
		#endregion
		
		#region [ Metodos ]
	    Boolean ValidarCopiaTarifa(DateTime x_CTAR_FecIni, DateTime x_CTAR_FecFin, String x_CONS_CodReg, String x_TIPO_CodMnd, Int32 x_ENTC_CodigoLineaNaviera);

	    #endregion
	}
}
