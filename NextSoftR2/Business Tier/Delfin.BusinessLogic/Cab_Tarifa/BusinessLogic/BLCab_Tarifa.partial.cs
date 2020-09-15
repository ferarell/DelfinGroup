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
	public partial class BLCab_Tarifa
	{
		#region [ Consultas ]
        public ObservableCollection<Cab_Tarifa> GetAllByFiltros(Int32? LineaNaviera, Int32? AgMaritimo, Int32? DepTemporal,
        Int32? DepVacio, Int32? AgAduana, Int32? Transporte, DateTime FecEmiDesde, DateTime FecEmiHasta,String TipoTarifa)
        {
            try
            {
                return SelectAllByFiltros(LineaNaviera, AgMaritimo, DepTemporal, DepVacio, AgAduana, Transporte, FecEmiDesde, FecEmiHasta,TipoTarifa);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public DataTable GetAllAyudaTarifa(String x_NroTarifa, String x_DescripTarifa, String x_CTAR_Tipo, Int32 x_CTAR_Codigo)
        {
            try
            {
                return SelectAllAyudaTarifa(x_NroTarifa, x_DescripTarifa, x_CTAR_Tipo, x_CTAR_Codigo);
            }
            catch (Exception ex)
            { throw ex; }
        }

		#endregion
		
		#region [ Metodos ]
        public Boolean ValidarCopiaTarifa(DateTime x_CTAR_FecIni, DateTime x_CTAR_FecFin, String x_CONS_CodReg, String x_TIPO_CodMnd, Int32 x_ENTC_CodigoLineaNaviera)
        {
            try
            {
                bool mIsCorrect = ValidarCopia(x_CTAR_FecIni, x_CTAR_FecFin, x_CONS_CodReg, x_TIPO_CodMnd, x_ENTC_CodigoLineaNaviera);
                return mIsCorrect;
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
	}
}
