using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Infrastructure.Aspect.DataAccess;
using Delfin.Entities;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.BusinessLogic
{
	public partial class BLUbigeos
	{
		#region [ Consultas ]
      private ObservableCollection<Ubigeos> SelectAll(string x_codubigeo, string x_codpais, string x_tabpais)
      {
         try
         {
            ObservableCollection<Ubigeos> items = new ObservableCollection<Ubigeos>();
            Ubigeos item = new Ubigeos();
            DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_Ubigeos");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUBIG_Codigo", x_codubigeo, SqlDbType.VarChar, 10, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodPais", x_codpais, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabPais", x_tabpais, SqlDbType.Char, 3, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Ubigeos();
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
                  items.Add(item);
               }
            }
            return items;
         }
         catch (Exception ex)
         { throw ex; }
      }
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
