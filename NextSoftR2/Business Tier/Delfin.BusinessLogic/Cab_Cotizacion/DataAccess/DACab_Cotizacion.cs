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
	public partial class BLCab_Cotizacion
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Cab_Cotizacion> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLCab_Cotizacion(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Cab_Cotizacion>();
			Cab_Cotizacion item = new Cab_Cotizacion();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
        private ObservableCollection<Cab_Cotizacion> SelectAllByFiltros(Int32? x_ENTC_Codigo, String x_CCOT_NumDoc, DateTime x_CCOT_FecEmiIni, DateTime x_CCOT_FecEmiFin)
        {
            try
            {
                ObservableCollection<Cab_Cotizacion> items = new ObservableCollection<Cab_Cotizacion>();
                Cab_Cotizacion item = new Cab_Cotizacion();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CCOTSS_TodosByFiltros");
                if (x_ENTC_Codigo != null)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", x_ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                if (!String.IsNullOrEmpty(x_CCOT_NumDoc))
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", x_CCOT_NumDoc, SqlDbType.VarChar, 11, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", DBNull.Value, SqlDbType.VarChar, 11, ParameterDirection.Input);
                }
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecEmiIni", x_CCOT_FecEmiIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecEmiFin", x_CCOT_FecEmiFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
                using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Cab_Cotizacion();
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


		private Cab_Cotizacion SelectOne(Int32 CCOT_Codigo)
		{
			try
			{
				Cab_Cotizacion item = new Cab_Cotizacion();
				DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CCOTSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Codigo", CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert(ref Cab_Cotizacion item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CCOTSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Codigo", item.CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", item.CCOT_NumDoc, SqlDbType.VarChar, 11, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecEmi", item.CCOT_FecEmi, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecVcto", item.CCOT_FecVcto, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_Observaciones", item.CCOT_Observaciones, SqlDbType.VarChar, 1024, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_HoraLibre", item.CCOT_HoraLibre, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEstado", item.CONS_CodEstado, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEstado", item.CONS_TabEstado, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodReg", item.CONS_CodReg, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabReg", item.CONS_TabReg, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAduana", item.ENTC_CodAduana, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodLogistico", item.ENTC_CodLogistico, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransporte", item.ENTC_CodTransporte, SqlDbType.Int, 4, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _CCOT_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCCOT_Codigo"].Value.ToString(), out _CCOT_Codigo))
						{ item.CCOT_Codigo = _CCOT_Codigo; }
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
		private bool Update(ref Cab_Cotizacion item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CCOTSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Codigo", item.CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", item.CCOT_NumDoc, SqlDbType.VarChar, 11, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecEmi", item.CCOT_FecEmi, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCCOT_FecVcto", item.CCOT_FecVcto, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_Observaciones", item.CCOT_Observaciones, SqlDbType.VarChar, 1024, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_HoraLibre", item.CCOT_HoraLibre, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEstado", item.CONS_CodEstado, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEstado", item.CONS_TabEstado, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodReg", item.CONS_CodReg, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabReg", item.CONS_TabReg, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodAduana", item.ENTC_CodAduana, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodLogistico", item.ENTC_CodLogistico, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTransporte", item.ENTC_CodTransporte, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
		private bool Delete(ref Cab_Cotizacion item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CCOTSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Codigo", item.CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
