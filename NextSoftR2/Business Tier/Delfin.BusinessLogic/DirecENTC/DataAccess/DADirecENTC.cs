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
	public partial class BLDirecENTC
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<DirecENTC> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDirecENTC(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<DirecENTC>();
			DirecENTC item = new DirecENTC();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
        private ObservableCollection<DirecENTC> SelectAll(Int32 x_ENTC_Codigo)
		{
			try
			{
				ObservableCollection<DirecENTC> items = new ObservableCollection<DirecENTC>();
				DirecENTC item = new DirecENTC();
                DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_DirecENTC_PorEntidad");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", x_ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new DirecENTC();
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
		private DirecENTC SelectOne(Int32 ENTC_Codigo, Int16 DIRE_Codigo)
		{
			try
			{
				DirecENTC item = new DirecENTC();
				DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_DirecENTC");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinDIRE_Codigo", DIRE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
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
		private bool Insert(ref DirecENTC item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
               DataAccessEnterpriseSQL.DAAsignarProcedure("DIRESI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDIRE_Codigo", item.DIRE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDIRE_Direccion", item.DIRE_Direccion, SqlDbType.VarChar, 250, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDIRE_Facturar", item.DIRE_Facturar, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDIRE_Referencia", item.DIRE_Referencia, SqlDbType.VarChar, 250, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDIRE_Activo", item.DIRE_Activo, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUBIG_Codigo", item.UBIG_Codigo, SqlDbType.VarChar, 10, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabPais", item.TIPO_TabPais, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodPais", item.TIPO_CodPais, SqlDbType.Char, 3, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _ENTC_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintENTC_Codigo"].Value.ToString(), out _ENTC_Codigo))
						{ item.ENTC_Codigo = _ENTC_Codigo; }
						Int16 _DIRE_Codigo;
						if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinDIRE_Codigo"].Value.ToString(), out _DIRE_Codigo))
						{ item.DIRE_Codigo = _DIRE_Codigo; }
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
		private bool Update(ref DirecENTC item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
               DataAccessEnterpriseSQL.DAAsignarProcedure("DIRESU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDIRE_Codigo", item.DIRE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDIRE_Direccion", item.DIRE_Direccion, SqlDbType.VarChar, 250, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDIRE_Facturar", item.DIRE_Facturar, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDIRE_Referencia", item.DIRE_Referencia, SqlDbType.VarChar, 250, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDIRE_Activo", item.DIRE_Activo, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUBIG_Codigo", item.UBIG_Codigo, SqlDbType.VarChar, 10, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabPais", item.TIPO_TabPais, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodPais", item.TIPO_CodPais, SqlDbType.Char, 3, ParameterDirection.Input);
					
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
		private bool Delete(ref DirecENTC item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
               DataAccessEnterpriseSQL.DAAsignarProcedure("DIRESD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDIRE_Codigo", item.DIRE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					
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
