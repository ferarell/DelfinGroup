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
	public partial class BLDet_Operacion_Servicio
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Det_Operacion_Servicio> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDet_Operacion_Servicio(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Det_Operacion_Servicio>();
			Det_Operacion_Servicio item = new Det_Operacion_Servicio();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
        private ObservableCollection<Det_Operacion_Servicio> SelectAllByOperacion(Int32 x_COPE_Codigo)
		{
			try
			{
				ObservableCollection<Det_Operacion_Servicio> items = new ObservableCollection<Det_Operacion_Servicio>();
				Det_Operacion_Servicio item = new Det_Operacion_Servicio();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_SOPESS_TodosbyOperacion");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", x_COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Det_Operacion_Servicio();
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
		private Det_Operacion_Servicio SelectOne(Int32 SOPE_Item, Int32 COPE_Codigo)
		{
			try
			{
				Det_Operacion_Servicio item = new Det_Operacion_Servicio();
				DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_SOPESS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintSOPE_Item", SOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert( Det_Operacion_Servicio item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_SOPESI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSOPE_Item", item.SOPE_Item, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSOPE_Tipo", item.SOPE_Tipo, SqlDbType.Char , 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodBas", item.CONS_CodBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabBas", item.CONS_TabBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMnd", item.TIPO_TabMnd, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMnd", item.TIPO_CodMnd, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", item.TIPE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinSOPE_Cantidad", item.SOPE_Cantidad, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSOPE_PrecioUni", item.SOPE_PrecioUni, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSOPE_ImporteIngreso", item.SOPE_ImporteIngreso, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSOPE_ImporteEgreso", item.SOPE_ImporteEgreso, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSOPE_Costo", item.SOPE_Costo, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTMC", item.CONS_CodTMC, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabTMC", item.CONS_TabTMC, SqlDbType.Char, 3, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", item.CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEST", item.CONS_TabEST, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodLNG", item.CONS_CodLNG, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabLNG", item.CONS_TabLNG, SqlDbType.Char, 3, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _SOPE_Item;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintSOPE_Item"].Value.ToString(), out _SOPE_Item))
						{ item.SOPE_Item = _SOPE_Item; }
						Int32 _COPE_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCOPE_Codigo"].Value.ToString(), out _COPE_Codigo))
						{ item.COPE_Codigo = _COPE_Codigo; }
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
		private bool Update( Det_Operacion_Servicio item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_SOPESU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSOPE_Item", item.SOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSOPE_Tipo", item.SOPE_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodBas", item.CONS_CodBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabBas", item.CONS_TabBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMnd", item.TIPO_TabMnd, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMnd", item.TIPO_CodMnd, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", item.TIPE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinSOPE_Cantidad", item.SOPE_Cantidad, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSOPE_PrecioUni", item.SOPE_PrecioUni, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSOPE_ImporteIngreso", item.SOPE_ImporteIngreso, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSOPE_ImporteEgreso", item.SOPE_ImporteEgreso, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSOPE_Costo", item.SOPE_Costo, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTMC", item.CONS_CodTMC, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabTMC", item.CONS_TabTMC, SqlDbType.Char, 3, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", item.CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEST", item.CONS_TabEST, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodLNG", item.CONS_CodLNG, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabLNG", item.CONS_TabLNG, SqlDbType.Char, 3, ParameterDirection.Input);

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
		private bool Delete( Det_Operacion_Servicio item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_SOPESD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSOPE_Item", item.SOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
