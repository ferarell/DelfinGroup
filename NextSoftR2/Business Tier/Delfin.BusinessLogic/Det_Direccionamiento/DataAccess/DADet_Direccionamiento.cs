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
	public partial class BLDet_Direccionamiento
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Det_Direccionamiento> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDet_Direccionamiento(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Det_Direccionamiento>();
			Det_Direccionamiento item = new Det_Direccionamiento();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private ObservableCollection<Det_Direccionamiento> SelectAll()
		{
			try
			{
				ObservableCollection<Det_Direccionamiento> items = new ObservableCollection<Det_Direccionamiento>();
				Det_Direccionamiento item = new Det_Direccionamiento();
				DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DDIRSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Det_Direccionamiento();
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
		private DataTable SelectOne(Int32 DDIR_Item, Int32 CDIR_Codigo)
		{
			try
			{
				DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DDIRSS_UnReg");
            if(DDIR_Item==0)
				   DataAccessEnterpriseSQL.DAAgregarParametro("@pintDDIR_Item", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
            else
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintDDIR_Item", DDIR_Item, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintCDIR_Codigo", CDIR_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            System.Data.DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (ds != null && ds.Tables.Count > 0)
            { return ds.Tables[0]; }
            else
            { return null; }
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		private bool Insert( Det_Direccionamiento item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DDIRSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDDIR_Item", item.DDIR_Item, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCDIR_Codigo", item.CDIR_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDDIR_Cantidad", item.DDIR_Cantidad, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDDIR_Tarja", item.DDIR_Tarja, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDDIR_Rebate", item.DDIR_Rebate, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDIR_Contenedor", item.DDIR_Contenedor, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDDIR_Estado", item.DDIR_Estado, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", item.PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDIR_MontoTarja", item.DDIR_MontoTarja, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDIR_MontoRebate", item.DDIR_MontoRebate, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _DDIR_Item;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintDDIR_Item"].Value.ToString(), out _DDIR_Item))
						{ item.DDIR_Item = _DDIR_Item; }
						Int32 _CDIR_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCDIR_Codigo"].Value.ToString(), out _CDIR_Codigo))
						{ item.CDIR_Codigo = _CDIR_Codigo; }
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
		private bool Update( Det_Direccionamiento item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DDIRSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDDIR_Item", item.DDIR_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCDIR_Codigo", item.CDIR_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDDIR_Cantidad", item.DDIR_Cantidad, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDDIR_Tarja", item.DDIR_Tarja, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDDIR_Rebate", item.DDIR_Rebate, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDIR_Contenedor", item.DDIR_Contenedor, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDDIR_Estado", item.DDIR_Estado, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", item.PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDIR_MontoTarja", item.DDIR_MontoTarja, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDIR_MontoRebate", item.DDIR_MontoRebate, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					
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
		private bool Delete( Det_Direccionamiento item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DDIRSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDDIR_Item", item.DDIR_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCDIR_Codigo", item.CDIR_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
