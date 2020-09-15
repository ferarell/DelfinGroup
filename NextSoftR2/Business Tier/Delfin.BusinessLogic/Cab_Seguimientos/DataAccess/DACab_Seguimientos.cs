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
	public partial class BLCab_Seguimientos
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Cab_Seguimientos> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLCab_Seguimientos(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Cab_Seguimientos>();
			Cab_Seguimientos item = new Cab_Seguimientos();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
        private ObservableCollection<Cab_Seguimientos> SelectAllByFiltros(DateTime x_CSEG_FechaEmisionIni, DateTime x_CSEG_FechaEmisionFin,String x_Nave)
		{
			try
			{
				ObservableCollection<Cab_Seguimientos> items = new ObservableCollection<Cab_Seguimientos>();
				Cab_Seguimientos item = new Cab_Seguimientos();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CSEGSS_TodosByFiltros");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCSEG_FechaEmisionIni", x_CSEG_FechaEmisionIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCSEG_FechaEmisionFin", x_CSEG_FechaEmisionFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchNave", x_Nave, SqlDbType.VarChar, 20, ParameterDirection.Input);
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Cab_Seguimientos();
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
		private Cab_Seguimientos SelectOne(Int32 CSEG_Codigo)
		{
			try
			{
				Cab_Seguimientos item = new Cab_Seguimientos();
				DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CSEGSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintCSEG_Codigo", CSEG_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					if (reader.Read())
					{
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
					}
				}
				return item;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		private bool Insert(ref Cab_Seguimientos item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CSEGSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCSEG_Codigo", item.CSEG_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCSEG_HBL", item.CSEG_HBL, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCSEG_FechaEmision", item.CSEG_FechaEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCDIR_Codigo", item.CDIR_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _CSEG_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCSEG_Codigo"].Value.ToString(), out _CSEG_Codigo))
						{ item.CSEG_Codigo = _CSEG_Codigo; }
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
		private bool Update(ref Cab_Seguimientos item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CSEGSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCSEG_Codigo", item.CSEG_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCSEG_HBL", item.CSEG_HBL, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCSEG_FechaEmision", item.CSEG_FechaEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCDIR_Codigo", item.CDIR_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
		private bool Delete(ref Cab_Seguimientos item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CSEGSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCSEG_Codigo", item.CSEG_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
