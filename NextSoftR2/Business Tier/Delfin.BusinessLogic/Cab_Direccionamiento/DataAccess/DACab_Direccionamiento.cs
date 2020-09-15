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
	public partial class BLCab_Direccionamiento
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Cab_Direccionamiento> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLCab_Direccionamiento(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Cab_Direccionamiento>();
			Cab_Direccionamiento item = new Cab_Direccionamiento();
			Loader.EntityType = item.GetType();
		}
		#endregion 

		#region [ Consultas ]
      private DataTable SelectAll(DateTime CDIR_FecEmisionInicio, DateTime CDIR_FecEmisionFin, Nullable<DateTime> CDIR_FecArriboInicio, Nullable<DateTime> CDIR_FecArriboFin,
                                                         String CDIR_HBL, String CDIR_MBL, Int32 ENTC_CodCliente, Int32 ENTC_CodLinea, Int32 ENTC_CodTemporal, Int16 NAVE_Codigo)
		{
			try
			{
				ObservableCollection<Cab_Direccionamiento> items = new ObservableCollection<Cab_Direccionamiento>();
				Cab_Direccionamiento item = new Cab_Direccionamiento();
				DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CDIRSS_Todos");
            DataAccessEnterpriseSQL.DAAgregarParametro("@CDIR_FecEmisionInicio", CDIR_FecEmisionInicio, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CDIR_FecEmisionFin", CDIR_FecEmisionFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CDIR_FecArriboInicio", CDIR_FecArriboInicio, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CDIR_FecArriboFin", CDIR_FecArriboFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CDIR_HBL", CDIR_HBL, SqlDbType.VarChar, 20, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CDIR_MBL", CDIR_MBL, SqlDbType.VarChar, 20, ParameterDirection.Input);
            if (ENTC_CodCliente==0)
               DataAccessEnterpriseSQL.DAAgregarParametro("@ENTC_CodCliente", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
            else
               DataAccessEnterpriseSQL.DAAgregarParametro("@ENTC_CodCliente", ENTC_CodCliente, SqlDbType.Int, 4, ParameterDirection.Input);
            if(ENTC_CodLinea==0)
               DataAccessEnterpriseSQL.DAAgregarParametro("@ENTC_CodLinea", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
            else
               DataAccessEnterpriseSQL.DAAgregarParametro("@ENTC_CodLinea", ENTC_CodLinea, SqlDbType.Int, 4, ParameterDirection.Input);
            if(ENTC_CodTemporal==0)
               DataAccessEnterpriseSQL.DAAgregarParametro("@ENTC_CodTemporal", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
            else
               DataAccessEnterpriseSQL.DAAgregarParametro("@ENTC_CodTemporal", ENTC_CodTemporal, SqlDbType.Int, 4, ParameterDirection.Input);

            if (NAVE_Codigo == 0)
               DataAccessEnterpriseSQL.DAAgregarParametro("@NAVE_Codigo", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
            else
               DataAccessEnterpriseSQL.DAAgregarParametro("@NAVE_Codigo", NAVE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

            System.Data.DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (ds != null && ds.Tables.Count > 0)
            { return ds.Tables[0]; }
            else
            { return null; }

            //using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            //{
            //   while (reader.Read())
            //   {
            //      item = new Cab_Direccionamiento();
            //      Loader.LoadEntity(reader, item);
            //      item.Instance = InstanceEntity.Unchanged;
            //      items.Add(item);
            //   }
            //}
            //return items;
			}
			catch (Exception ex)
			{ throw ex; }
		}


		private Cab_Direccionamiento SelectOne(Int32 CDIR_Codigo)
		{
			try
			{
				Cab_Direccionamiento item = new Cab_Direccionamiento();
				DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CDIRSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintCDIR_Codigo", CDIR_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert(ref Cab_Direccionamiento item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CDIRSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCDIR_Codigo", item.CDIR_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCDIR_HBL", item.CDIR_HBL, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCDIR_MBL", item.CDIR_MBL, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCDIR_FecArribo", item.CDIR_FecArribo, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCDIR_Observaciones", item.CDIR_Observaciones, SqlDbType.VarChar, 1024, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCliente", item.ENTC_CodCliente, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodLinea", item.ENTC_CodLinea, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTemporal", item.ENTC_CodTemporal, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCDIR_FecEmision", item.CDIR_FecEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCDIR_Nave", item.CDIR_Nave, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCDIR_Viaje", item.CDIR_Viaje, SqlDbType.VarChar, 100, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
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
		private bool Update( Cab_Direccionamiento item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CDIRSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCDIR_Codigo", item.CDIR_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCDIR_HBL", item.CDIR_HBL, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCDIR_MBL", item.CDIR_MBL, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCDIR_FecArribo", item.CDIR_FecArribo, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCDIR_Observaciones", item.CDIR_Observaciones, SqlDbType.VarChar, 1024, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodCliente", item.ENTC_CodCliente, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodLinea", item.ENTC_CodLinea, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTemporal", item.ENTC_CodTemporal, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCDIR_FecEmision", item.CDIR_FecEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCDIR_Nave", item.CDIR_Nave, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCDIR_Viaje", item.CDIR_Nave, SqlDbType.VarChar, 100, ParameterDirection.Input);
					
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
		private bool Delete( Cab_Direccionamiento item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CDIRSD_UnReg");
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
