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
using Infrastructure.Aspect.BusinessEntity;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLcorrelativos
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<correlativos> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLcorrelativos(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<correlativos>();
			correlativos item = new correlativos();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private ObservableCollection<correlativos> SelectAll()
		{
			try
			{
				ObservableCollection<correlativos> items = new ObservableCollection<correlativos>();
				correlativos item = new correlativos();
				DataAccessEnterpriseSQL.DAAsignarProcedure("TGEN_SP_CONSULTAR_correlativos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new correlativos();
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
		private correlativos SelectOne(String CORR_ServerName, String CORR_CodCorr)
		{
			try
			{
				correlativos item = new correlativos();
				DataAccessEnterpriseSQL.DAAsignarProcedure("TGEN_SP_CONSULTAR_correlativos");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCORR_ServerName", CORR_ServerName, SqlDbType.VarChar, 50, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCORR_CodCorr", CORR_CodCorr, SqlDbType.VarChar, 10, ParameterDirection.Input);
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
		#endregion

		#region [ Metodos ]
		private bool Insert(ref correlativos item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TGEN_SP_INSERTAR_correlativos");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCORR_ServerName", item.CORR_ServerName, SqlDbType.VarChar, 50, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCORR_CodCorr", item.CORR_CodCorr, SqlDbType.VarChar, 10, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCORR_UltNum", item.CORR_UltNum, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCORR_Desc", item.CORR_Desc, SqlDbType.VarChar, 50, ParameterDirection.Input);
					
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
                  //String _CORR_ServerName;
                  //if (String.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchCORR_ServerName"].Value.ToString(), out _CORR_ServerName))
                  //{ item.CORR_ServerName = _CORR_ServerName; }
                  //String _CORR_CodCorr;
                  //if (String.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchCORR_CodCorr"].Value.ToString(), out _CORR_CodCorr))
                  //{ item.CORR_CodCorr = _CORR_CodCorr; }
						return true;
					}
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception ex)
			{ throw ex; }
		}
		private bool Update(ref correlativos item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TGEN_SP_ACTUALIZAR_correlativos");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCORR_ServerName", item.CORR_ServerName, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCORR_CodCorr", item.CORR_CodCorr, SqlDbType.VarChar, 10, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCORR_UltNum", item.CORR_UltNum, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCORR_Desc", item.CORR_Desc, SqlDbType.VarChar, 50, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCORR_UsrMod", item.CORR_UsrMod, SqlDbType.Char, 18, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception ex)
			{ throw ex; }
		}
		private bool Delete(ref correlativos item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TGEN_SP_ELIMINAR_correlativos");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCORR_ServerName", item.CORR_ServerName, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCORR_CodCorr", item.CORR_CodCorr, SqlDbType.VarChar, 10, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
