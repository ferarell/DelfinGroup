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
	public partial class BLTarifa
	{
		#region [ Consultas ]
      private ObservableCollection<Tarifa> SelectAllByContrato(Int32 CONT_Codigo)
      {
         try
         {
            ObservableCollection<Tarifa> items = new ObservableCollection<Tarifa>();
            Tarifa item = new Tarifa();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Tarifa");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Tarifa();
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
      private DataTable SelectAllByContratoGrilla(Nullable<Int32> CONT_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, String TIPO_TabMND, String TIPO_CodMND, Nullable<Int32> PACK_Codigo, String TIPO_TabPAI, String TIPO_CodPAI, Nullable<Int32> PUER_Codigo)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Tarifa_Contrato");
            
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", CONS_CodVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabPAI", TIPO_TabPAI, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodPAI", TIPO_CodPAI, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_Codigo", PUER_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

            DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (ds != null && ds.Tables.Count > 0)
            { return ds.Tables[0]; }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
