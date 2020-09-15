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
	public partial class BLPuerto
	{
		#region [ Consultas ]
      private ObservableCollection<Puerto> SelectAllByVia(String CONS_TabVia, String CONS_CodVia)
      {
         try
         {
            ObservableCollection<Puerto> items = new ObservableCollection<Puerto>();
            Puerto item = new Puerto();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Puerto");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Puerto();
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
      private Puerto SelectOneByCodEstandar(String CONS_TabVia, String CONS_CodVia, String PUER_CodEstandar)
      {
         try
         {
            Puerto item = new Puerto();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_PuertoCodEstandar");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrPUER_CodEstandar", PUER_CodEstandar, SqlDbType.Char, 7, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               if (reader.Read())
               {
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
               }
               else
               { throw new Exception("No se encontro el registro."); }
            }
            return item;
         }
         catch (Exception ex)
         { throw ex; }
      }
      private ObservableCollection<Puerto> SelectAllByAyuda(String CONS_TabVia, String CONS_CodVia, String TIPO_TabPais, String TIPO_CodPais, String PUER_CodEstandar, String PUER_Nombre)
      {
         try
         {
            ObservableCollection<Puerto> items = new ObservableCollection<Puerto>();
            Puerto item = new Puerto();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_PuertoAyuda");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrPUER_CodEstandar", PUER_CodEstandar, SqlDbType.Char, 7, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPUER_Nombre", PUER_Nombre, SqlDbType.VarChar, 100, ParameterDirection.Input);

            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Puerto();
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
