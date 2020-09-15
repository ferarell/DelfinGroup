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
	public partial class BLLoadingList
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<LoadingList> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLLoadingList(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<LoadingList>();
			LoadingList Item = new LoadingList();
			Loader.EntityType = Item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private System.Data.DataTable SelectAllByFilterDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				DataSet _ds = new DataSet();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "LoadingList"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<LoadingList> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<LoadingList> items = new ObservableCollection<LoadingList>();
				LoadingList item = new LoadingList();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new LoadingList();
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
						items.Add(item);
					}
				}
				return items;
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<LoadingList> SelectAll()
		{
			try
			{
				ObservableCollection<LoadingList> items = new ObservableCollection<LoadingList>();
				LoadingList item = new LoadingList();
				DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new LoadingList();
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
						items.Add(item);
					}
				}
				return items;
			}
			catch (Exception)
			{ throw; }
		}
		private LoadingList SelectOne(Int32 LOAD_Codigo)
		{
			try
			{
				LoadingList item = new LoadingList();
				DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
			catch (Exception)
			{ throw; }
		}
		#endregion

		#region [ Metodos ]
		private bool Insert(ref LoadingList Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", Item.LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_Shipper", Item.LOAD_Shipper, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_Consignee", Item.LOAD_Consignee, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_Notify", Item.LOAD_Notify, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_Carrier", Item.LOAD_Carrier, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_Booking", Item.LOAD_Booking, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_MBL", Item.LOAD_MBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_HBL", Item.LOAD_HBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_ETA", Item.LOAD_ETA, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_ETD", Item.LOAD_ETD, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrLOAD_Payment", Item.LOAD_Payment, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_NaveViaje", Item.LOAD_NaveViaje, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", Item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", Item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_ContractNRO", Item.LOAD_ContractNRO, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_PrimerUsuario", Item.LOAD_PrimerUsuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitLOAD_SegundoOK", Item.LOAD_SegundoOK, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_SegundoUsuario", Item.LOAD_SegundoUsuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_CargaUsuario", Item.LOAD_CargaUsuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitLOAD_PrimerOK", Item.LOAD_PrimerOK, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitLOAD_Error", Item.LOAD_Error, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitLOAD_EnvioCorreo", Item.LOAD_EnvioCorreo, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_EnvioCorreoFecha", Item.LOAD_EnvioCorreoFecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_EnvioCorreoUsuario", Item.LOAD_EnvioCorreoUsuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_ErrorDescripcion", Item.LOAD_ErrorDescripcion, SqlDbType.VarChar, 1024, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_CargaFecha", Item.LOAD_CargaFecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodOrigen", Item.PUER_CodOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodDestino", Item.PUER_CodDestino, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_FecPrimerOK", Item.LOAD_FecPrimerOK, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_FecSegundoOK", Item.LOAD_FecSegundoOK, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", Item.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _LOAD_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintLOAD_Codigo"].Value.ToString(), out _LOAD_Codigo))
						{ Item.LOAD_Codigo = _LOAD_Codigo; }
						return true;
					}
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception)
			{ throw; }
		}
		private bool Update(ref LoadingList Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", Item.LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_Shipper", Item.LOAD_Shipper, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_Consignee", Item.LOAD_Consignee, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_Notify", Item.LOAD_Notify, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_Carrier", Item.LOAD_Carrier, SqlDbType.VarChar, 100, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_Booking", Item.LOAD_Booking, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_MBL", Item.LOAD_MBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_HBL", Item.LOAD_HBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_ETA", Item.LOAD_ETA, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_ETD", Item.LOAD_ETD, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrLOAD_Payment", Item.LOAD_Payment, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_NaveViaje", Item.LOAD_NaveViaje, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", Item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", Item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_ContractNRO", Item.LOAD_ContractNRO, SqlDbType.VarChar, 50, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_PrimerUsuario", Item.LOAD_PrimerUsuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitLOAD_SegundoOK", Item.LOAD_SegundoOK, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_SegundoUsuario", Item.LOAD_SegundoUsuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_CargaUsuario", Item.LOAD_CargaUsuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitLOAD_PrimerOK", Item.LOAD_PrimerOK, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitLOAD_Error", Item.LOAD_Error, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitLOAD_EnvioCorreo", Item.LOAD_EnvioCorreo, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_EnvioCorreoFecha", Item.LOAD_EnvioCorreoFecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_EnvioCorreoUsuario", Item.LOAD_EnvioCorreoUsuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_ErrorDescripcion", Item.LOAD_ErrorDescripcion, SqlDbType.VarChar, 1024, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_CargaFecha", Item.LOAD_CargaFecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodOrigen", Item.PUER_CodOrigen, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPUER_CodDestino", Item.PUER_CodDestino, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_FecPrimerOK", Item.LOAD_FecPrimerOK, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_FecSegundoOK", Item.LOAD_FecSegundoOK, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", Item.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception)
			{ throw; }
		}
		private bool Delete(ref LoadingList Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", Item.LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception)
			{ throw; }
		}
		#endregion
	}
}
