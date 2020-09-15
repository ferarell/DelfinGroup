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
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLNave
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Nave> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLNave(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Nave>();
			Nave item = new Nave();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
        private ObservableCollection<Nave> SelectAll(string x_ENTC_CodTransportista)
		{
			try
			{
				ObservableCollection<Nave> items = new ObservableCollection<Nave>();
				Nave item = new Nave();
                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_NAVE_By_Filtros");
            if(x_ENTC_CodTransportista == null)
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
            else
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista",  x_ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Nave();
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
		private Nave SelectOne(Int16 NAVE_Codigo)
		{
			try
			{
				Nave item = new Nave();
				DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Nave");
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinNave_Codigo", NAVE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
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
		private bool Insert(ref Nave item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_INSERTAR_Nave");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinNave_Codigo", item.NAVE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNave_Nombre", item.NAVE_Nombre, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", item.ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", item.CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", item.CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pNAVE_Matricula", item.NAVE_Matricula, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pNAVE_EntidadEmisora", item.NAVE_EntidadEmisora, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pCONS_TabEntEmi", item.CONS_TabEntEmi, SqlDbType.Char, 3, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int16 _NAVE_Codigo;
                        if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinNave_Codigo"].Value.ToString(), out  _NAVE_Codigo))
						{ item.NAVE_Codigo = _NAVE_Codigo; }
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
		private bool Update(ref Nave item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ACTUALIZAR_Nave");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinNave_Codigo", item.NAVE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNave_Nombre", item.NAVE_Nombre, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransportista", item.ENTC_CodTransportista, SqlDbType.Int, 4, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", item.CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", item.CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pNAVE_Matricula", item.NAVE_Matricula, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pNAVE_EntidadEmisora", item.NAVE_EntidadEmisora, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pCONS_TabEntEmi", item.CONS_TabEntEmi, SqlDbType.Char, 3, ParameterDirection.Input);

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
		private bool Delete(ref Nave item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ELIMINAR_Nave");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinNave_Codigo", item.NAVE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					
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
