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
	public partial class BLUbigeos
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Ubigeos> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLUbigeos(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Ubigeos>();
			Ubigeos item = new Ubigeos();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private ObservableCollection<Ubigeos> SelectAll()
		{
			try
			{
				ObservableCollection<Ubigeos> items = new ObservableCollection<Ubigeos>();
				Ubigeos item = new Ubigeos();
				DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_Ubigeos");
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
		private Ubigeos SelectOne(String UBIG_Codigo, String TIPO_CodPais, String TIPO_TabPais)
		{
			try
			{
				Ubigeos item = new Ubigeos();
				DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_Ubigeos");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUBIG_Codigo", UBIG_Codigo, SqlDbType.VarChar, 10, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodPais", TIPO_CodPais, SqlDbType.Char, 3, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabPais", TIPO_TabPais, SqlDbType.Char, 3, ParameterDirection.Input);
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
		private bool Insert(ref Ubigeos item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_INSERTAR_Ubigeos");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUBIG_Codigo", item.UBIG_Codigo, SqlDbType.VarChar, 10, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodPais", item.TIPO_CodPais, SqlDbType.Char, 3, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabPais", item.TIPO_TabPais, SqlDbType.Char, 3, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUBIG_Desc", item.UBIG_Desc, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUBIG_DescC", item.UBIG_DescC, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUBIG_CodPadre", item.UBIG_CodPadre, SqlDbType.VarChar, 10, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
                  //String _UBIG_Codigo;
                  //if (String.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchUBIG_Codigo"].Value.ToString(), out _UBIG_Codigo))
                  //{ item.UBIG_Codigo = _UBIG_Codigo; }
                  //String _TIPO_CodPais;
                  //if (String.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrTIPO_CodPais"].Value.ToString(), out _TIPO_CodPais))
                  //{ item.TIPO_CodPais = _TIPO_CodPais; }
                  //String _TIPO_TabPais;
                  //if (String.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrTIPO_TabPais"].Value.ToString(), out _TIPO_TabPais))
                  //{ item.TIPO_TabPais = _TIPO_TabPais; }
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
		private bool Update(ref Ubigeos item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_ACTUALIZAR_Ubigeos");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUBIG_Codigo", item.UBIG_Codigo, SqlDbType.VarChar, 10, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodPais", item.TIPO_CodPais, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabPais", item.TIPO_TabPais, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUBIG_Desc", item.UBIG_Desc, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUBIG_DescC", item.UBIG_DescC, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUBIG_CodPadre", item.UBIG_CodPadre, SqlDbType.VarChar, 10, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
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
		private bool Delete(ref Ubigeos item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_ELIMINAR_Ubigeos");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUBIG_Codigo", item.UBIG_Codigo, SqlDbType.VarChar, 10, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodPais", item.TIPO_CodPais, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabPais", item.TIPO_TabPais, SqlDbType.Char, 3, ParameterDirection.Input);
					
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
