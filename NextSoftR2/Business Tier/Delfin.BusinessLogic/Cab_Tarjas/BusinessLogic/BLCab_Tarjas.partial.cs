using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;
using Infrastructure.Aspect.DataAccess;

namespace Delfin.BusinessLogic
{
	public partial class BLCab_Tarjas
	{
		#region [ Consultas ]
        public ObservableCollection<Cab_Tarjas> GetAllTarjasPorFiltros(DateTime x_FecIni, DateTime x_FecFin)
        {
            try
            {
                return SelectAllPorFiltros(x_FecIni,x_FecFin);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public DataTable GetAyudaTarjas()
        {
            try
            {
                return SelectAyudaTarjas();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public DataSet GetAllTarjasRebate(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, String x_COPE_HBL, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin)
        {
            try
            {
                return SelectAllTarjasRebate(x_ENTC_Codigo, x_COPE_NumDoc, x_COPE_HBL, x_COPE_FecEmiIni,x_COPE_FecEmiFin);
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
		
		#region [ Metodos ]
		
		#endregion
	}
}
