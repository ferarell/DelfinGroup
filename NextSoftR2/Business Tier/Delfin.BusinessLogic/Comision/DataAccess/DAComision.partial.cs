using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Infrastructure.Aspect.DataAccess;
using Infrastructure.Aspect.BusinessEntity;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLComision
	{
		#region [ Consultas ]
      private Boolean SelectValidar(Int32 COMI_Codigo, DateTime COMI_FecIni, DateTime COMI_FecFin)
      {
         try
         {
            ObservableCollection<Comision> items = new ObservableCollection<Comision>();
            Comision item = new Comision();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_COMISS_Validar");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOMI_Codigo", COMI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOMI_FecIni", COMI_FecIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOMI_FecFin", COMI_FecFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Comision();
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
                  items.Add(item);
               }
            }
            return (items == null || items.Count > 0);
         }
         catch (Exception)
         { throw; }
      }
		#endregion

		#region [ Metodos ]
      private Boolean UpdateComisiones(ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)//(Int32 NVIA_Codigo, String Usuario)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ACTUALIZAR_Cab_Cotizacion_OV_Comisiones");

            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }

            //DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            //DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
            

            DataAccessEnterpriseSQL.DAExecuteNonQuery();
            return true;
         }
         catch (Exception)
         { throw; }
      }
		#endregion
	}
}
