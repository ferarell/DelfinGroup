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
	public partial class BLCierresChangeControl
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<CierresChangeControl> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLCierresChangeControl(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<CierresChangeControl>();
			CierresChangeControl Item = new CierresChangeControl();
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
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CHANSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "CierresChangeControl"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<CierresChangeControl> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<CierresChangeControl> items = new ObservableCollection<CierresChangeControl>();
				CierresChangeControl item = new CierresChangeControl();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CHANSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new CierresChangeControl();
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
		private ObservableCollection<CierresChangeControl> SelectAll()
		{
			try
			{
				ObservableCollection<CierresChangeControl> items = new ObservableCollection<CierresChangeControl>();
				CierresChangeControl item = new CierresChangeControl();
				DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CHANSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new CierresChangeControl();
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
		private CierresChangeControl SelectOne(Int16 EMPR_Codigo, Int16 SUCR_Codigo, String CHAN_Anio, String CHAN_Mes)
		{
			try
			{
				CierresChangeControl item = new CierresChangeControl();
				DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CHANSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCHAN_Anio", CHAN_Anio, SqlDbType.Char, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCHAN_Mes", CHAN_Mes, SqlDbType.Char, 2, ParameterDirection.Input);
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
		private bool Cerrar(ref CierresChangeControl Item, ref String MensajeError)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
               DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CHANSI_Cerrar");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", Item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCHAN_Anio", Item.CHAN_Anio, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCHAN_Mes", Item.CHAN_Mes, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCHAN_Estado", Item.CHAN_Estado, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCHAN_UsuarioCierre", Item.CHAN_UsuarioCierre, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCHAN_FechaCierre", Item.CHAN_FechaCierre, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCHAN_UsuarioApertura", Item.CHAN_UsuarioApertura, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCHAN_FechaApertura", Item.CHAN_FechaApertura, SqlDbType.DateTime, 8, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMensajeError", MensajeError, SqlDbType.VarChar, 1024, ParameterDirection.InputOutput);

					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAExecuteNonQuery();
               if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchMensajeError"].Value != DBNull.Value && !String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchMensajeError"].Value.ToString()))
               { MensajeError = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchMensajeError"].Value.ToString(); }

               if (String.IsNullOrEmpty(MensajeError))
					{ return true;	}
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception)
			{ throw; }
		}
      private bool Aperturar(ref CierresChangeControl Item, ref String MensajeError)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
               DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CHANSU_Aperturar");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", Item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCHAN_Anio", Item.CHAN_Anio, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCHAN_Mes", Item.CHAN_Mes, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCHAN_Estado", Item.CHAN_Estado, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCHAN_UsuarioCierre", Item.CHAN_UsuarioCierre, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCHAN_FechaCierre", Item.CHAN_FechaCierre, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCHAN_UsuarioApertura", Item.CHAN_UsuarioApertura, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCHAN_FechaApertura", Item.CHAN_FechaApertura, SqlDbType.DateTime, 8, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMensajeError", MensajeError, SqlDbType.VarChar, 1024, ParameterDirection.InputOutput);

					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAExecuteNonQuery();
               if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchMensajeError"].Value != DBNull.Value && !String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchMensajeError"].Value.ToString()))
               { MensajeError = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchMensajeError"].Value.ToString(); }

               if (String.IsNullOrEmpty(MensajeError))
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
      //private bool Delete(ref CierresChangeControl Item)
      //{
      //   try
      //   {
      //      if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
      //      {
      //         DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_CHANSD_UnReg");
      //         DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
      //         DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", Item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
      //         DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCHAN_Anio", Item.CHAN_Anio, SqlDbType.Char, 4, ParameterDirection.Input);
      //         DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCHAN_Mes", Item.CHAN_Mes, SqlDbType.Char, 2, ParameterDirection.Input);
					
      //         if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
      //         { return true; }
      //         else
      //         { return false; }
      //      }
      //      else
      //      { return true; }
      //   }
      //   catch (Exception)
      //   { throw; }
      //}
		#endregion
	}
}
