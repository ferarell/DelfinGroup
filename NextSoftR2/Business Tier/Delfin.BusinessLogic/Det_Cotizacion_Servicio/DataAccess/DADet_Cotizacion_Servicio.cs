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
	public partial class BLDet_Cotizacion_Servicio
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Det_Cotizacion_Servicio> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDet_Cotizacion_Servicio(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Det_Cotizacion_Servicio>();
			Det_Cotizacion_Servicio item = new Det_Cotizacion_Servicio();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
      private ObservableCollection<Det_Cotizacion_Servicio> SelectAllByCotizacion(Int32 x_CCOT_Codigo, String x_SCOT_Tipo)
		{
			try
			{
				ObservableCollection<Det_Cotizacion_Servicio> items = new ObservableCollection<Det_Cotizacion_Servicio>();
				Det_Cotizacion_Servicio item = new Det_Cotizacion_Servicio();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_SCOTSS_TodosByCotizacion");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Codigo", x_CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSCOT_Tipo", x_SCOT_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Det_Cotizacion_Servicio();
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
		private Det_Cotizacion_Servicio SelectOne(Int32 CCOT_Codigo, Int32 SCOT_Item)
		{
			try
			{
				Det_Cotizacion_Servicio item = new Det_Cotizacion_Servicio();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_SCOTSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Codigo", CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintSCOT_Item", SCOT_Item, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert(ref Det_Cotizacion_Servicio item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
                    DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_SCOTSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Codigo", item.CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSCOT_Item", item.SCOT_Item, SqlDbType.Int, 4, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSCOT_Tipo", item.SCOT_Tipo, SqlDbType.Char , 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinSCOT_Cantidad", item.SCOT_Cantidad, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSCOT_PrecioUni", item.SCOT_PrecioUni, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSCOT_ImporteIngreso", item.SCOT_ImporteIngreso, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSCOT_ImporteEgreso", item.SCOT_ImporteEgreso, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodBas", item.CONS_CodBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabBas", item.CONS_TabBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMnd", item.TIPO_TabMnd, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMnd", item.TIPO_CodMnd, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", item.TIPE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTMC", item.CONS_CodTMC, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabTMC", item.CONS_TabTMC, SqlDbType.Char, 3, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _CCOT_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCCOT_Codigo"].Value.ToString(), out _CCOT_Codigo))
						{ item.CCOT_Codigo = _CCOT_Codigo; }
						Int32 _SCOT_Item;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintSCOT_Item"].Value.ToString(), out _SCOT_Item))
						{ item.SCOT_Item = _SCOT_Item; }
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
		private bool Update(ref Det_Cotizacion_Servicio item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
                    DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_SCOTSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Codigo", item.CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSCOT_Item", item.SCOT_Item, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSCOT_Tipo", item.SCOT_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinSCOT_Cantidad", item.SCOT_Cantidad, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSCOT_PrecioUni", item.SCOT_PrecioUni, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTMC", item.CONS_CodTMC, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabTMC", item.CONS_TabTMC, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSCOT_ImporteIngreso", item.SCOT_ImporteIngreso, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSCOT_ImporteEgreso", item.SCOT_ImporteEgreso, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodBas", item.CONS_CodBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabBas", item.CONS_TabBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMnd", item.TIPO_TabMnd, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMnd", item.TIPO_CodMnd, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", item.TIPE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					
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
		private bool Delete(ref Det_Cotizacion_Servicio item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
                    DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_SCOTSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Codigo", item.CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSCOT_Item", item.SCOT_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
