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
	public partial class BLConstantes
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Constantes> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLConstantes(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Constantes>();
			Constantes item = new Constantes();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private ObservableCollection<Constantes> SelectAll()
		{
			try
			{
				ObservableCollection<Constantes> items = new ObservableCollection<Constantes>();
				Constantes item = new Constantes();
				DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_Constantes");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Constantes();
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
		private Constantes SelectOne(String CONS_CodTabla, String CONS_CodTipo)
		{
			try
			{
				Constantes item = new Constantes();
				DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_Constantes");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTabla", CONS_CodTabla, SqlDbType.Char, 3, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTipo", CONS_CodTipo, SqlDbType.Char, 3, ParameterDirection.Input);
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
		private bool Insert(ref Constantes item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_INSERTAR_Constantes");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTabla", item.CONS_CodTabla, SqlDbType.Char, 3, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTipo", item.CONS_CodTipo, SqlDbType.Char, 3, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCONS_Desc_SPA", item.CONS_Desc_SPA, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_Desc_ENG", item.CONS_Desc_ENG, SqlDbType.Char, 18, ParameterDirection.Input);
					
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
                  //String _CONS_CodTabla;
                  //if (String.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrCONS_CodTabla"].Value.ToString(), out _CONS_CodTabla))
                  //{ item.CONS_CodTabla = _CONS_CodTabla; }
                  //String _CONS_CodTipo;
                  //if (String.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrCONS_CodTipo"].Value.ToString(), out _CONS_CodTipo))
                  //{ item.CONS_CodTipo = _CONS_CodTipo; }
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
		private bool Update(ref Constantes item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_ACTUALIZAR_Constantes");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTabla", item.CONS_CodTabla, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTipo", item.CONS_CodTipo, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCONS_Desc_SPA", item.CONS_Desc_SPA, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_Desc_ENG", item.CONS_Desc_ENG, SqlDbType.Char, 18, ParameterDirection.Input);
					
					
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
		private bool Delete(ref Constantes item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_ELIMINAR_Constantes");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTabla", item.CONS_CodTabla, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTipo", item.CONS_CodTipo, SqlDbType.Char, 3, ParameterDirection.Input);
					
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
