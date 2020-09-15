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
	public partial class BLDet_Operacion
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Det_Operacion> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDet_Operacion(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Det_Operacion>();
			Det_Operacion item = new Det_Operacion();
			Loader.EntityType = item.GetType();

		}
		#endregion

		#region [ Consultas ]
       
        private ObservableCollection<Det_Operacion> SelectAllByOperacion(Int32 x_COPE_Codigo)
		{
			try
			{
				ObservableCollection<Det_Operacion> items = new ObservableCollection<Det_Operacion>();
				Det_Operacion item = new Det_Operacion();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DOPESS_TodosByOperacion");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", x_COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Det_Operacion();
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
		private Det_Operacion SelectOne(Int32 DOPE_Item, Int32 COPE_Codigo)
		{
			try
			{
				Det_Operacion item = new Det_Operacion();
				DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DOPESS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOPE_Item", DOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert( Det_Operacion item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DOPESI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOPE_Item", item.DOPE_Item, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDTAR_Item", item.DTAR_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCTAR_Codigo", item.CTAR_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCTAR_Tipo", item.CTAR_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", item.PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodBas", item.CONS_CodBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabBas", item.CONS_TabBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDOPE_Cantidad", item.DOPE_Cantidad, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_PrecioUnitCosto", item.DOPE_PrecioUnitCosto, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_PrecioTotCosto", item.DOPE_PrecioTotCosto, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_PrecioUnitVta", item.DOPE_PrecioUnitVta, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_PrecioTotVta", item.DOPE_PrecioTotVta, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_Minimo", item.DOPE_Minimo, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDOPE_Peso", item.DOPE_Peso, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDOPE_Volumen", item.DOPE_Volumen, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_CostoSada", item.DOPE_CostoSada, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_Costo", item.DOPE_Costo, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_VentaSada", item.DOPE_VentaSada, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_Venta", item.DOPE_Venta, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabZON", item.TIPO_TabZON, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodZONOrigen", item.TIPO_CodZONOrigen, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTRA", item.CONS_CodTRA, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabTRA", item.CONS_TabTRA, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodZONDestino", item.TIPO_CodZONDestino, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", item.TIPE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", item.CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEST", item.CONS_TabEST, SqlDbType.Char, 3, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _DOPE_Item;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintDOPE_Item"].Value.ToString(), out _DOPE_Item))
						{ item.DOPE_Item = _DOPE_Item; }
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
		private bool Update( Det_Operacion item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DOPESU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOPE_Item", item.DOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDTAR_Item", item.DTAR_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCTAR_Codigo", item.CTAR_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCTAR_Tipo", item.CTAR_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", item.PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodBas", item.CONS_CodBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabBas", item.CONS_TabBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDOPE_Cantidad", item.DOPE_Cantidad, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_PrecioUnitCosto", item.DOPE_PrecioUnitCosto, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_PrecioTotCosto", item.DOPE_PrecioTotCosto, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_PrecioUnitVta", item.DOPE_PrecioUnitVta, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_PrecioTotVta", item.DOPE_PrecioTotVta, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_Minimo", item.DOPE_Minimo, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDOPE_Peso", item.DOPE_Peso, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDOPE_Volumen", item.DOPE_Volumen, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_CostoSada", item.DOPE_CostoSada, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_Costo", item.DOPE_Costo, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_VentaSada", item.DOPE_VentaSada, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDOPE_Venta", item.DOPE_Venta, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabZON", item.TIPO_TabZON, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodZONOrigen", item.TIPO_CodZONOrigen, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTRA", item.CONS_CodTRA, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabTRA", item.CONS_TabTRA, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodZONDestino", item.TIPO_CodZONDestino, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", item.TIPE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", item.CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEST", item.CONS_TabEST, SqlDbType.Char, 3, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUSR_UsrMod", item.USR_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
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
		private bool Delete( Det_Operacion item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DOPESD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOPE_Item", item.DOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAExecuteNonQuery();
					return true; 
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
