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
	public partial class BLDet_Tarifa
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Det_Tarifa> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDet_Tarifa(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Det_Tarifa>();
			Det_Tarifa item = new Det_Tarifa();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private ObservableCollection<Det_Tarifa> SelectAll()
		{
			try
			{
				ObservableCollection<Det_Tarifa> items = new ObservableCollection<Det_Tarifa>();
				Det_Tarifa item = new Det_Tarifa();
				DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DTARSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Det_Tarifa();
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
		private Det_Tarifa SelectOne(Int32 CTAR_Codigo, String CTAR_Tipo, String DTAR_Item)
		{
			try
			{
				Det_Tarifa item = new Det_Tarifa();
				DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DTARSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintCTAR_Codigo", CTAR_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCTAR_Tipo", CTAR_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrDTAR_Item", DTAR_Item, SqlDbType.Char, 18, ParameterDirection.Input);
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
		private bool Insert(ref Det_Tarifa item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DTARSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCTAR_Codigo", item.CTAR_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCTAR_Tipo", item.CTAR_Tipo, SqlDbType.Char, 1, ParameterDirection.InputOutput);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinDTAR_Item", item.DTAR_Item, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", item.PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_CostoSada", item.DTAR_CostoSada, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_VentaSada", item.DTAR_VentaSada, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_Venta", item.DTAR_Venta, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_Peso", item.DTAR_Peso, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_Volumen", item.DTAR_Volumen, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_Minimo", item.DTAR_Minimo, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodBas", item.CONS_CodBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabBas", item.CONS_TabBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabZON", item.TIPO_TabZON, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodZONDestino", item.TIPO_CodZONDestino, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodZONOrigen", item.TIPO_CodZONOrigen, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDTAR_Roundtrip", item.DTAR_Roundtrip, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_Costo", item.DTAR_Costo, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_Profit", item.DTAR_Profit, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_ProfitMinimo", item.DTAR_ProfitMinimo, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTRA", item.CONS_CodTRA, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabTRA", item.CONS_TabTRA, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", item.TIPE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _CTAR_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCTAR_Codigo"].Value.ToString(), out _CTAR_Codigo))
						{ item.CTAR_Codigo = _CTAR_Codigo; }
                         item.CTAR_Tipo = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrCTAR_Tipo"].Value.ToString();
                         Int16 _DTAR_Item;
                         if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinDTAR_Item"].Value.ToString(), out _DTAR_Item))
                         { item.DTAR_Item = _DTAR_Item; }
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
		private bool Update(ref Det_Tarifa item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DTARSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCTAR_Codigo", item.CTAR_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCTAR_Tipo", item.CTAR_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinDTAR_Item", item.DTAR_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", item.PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_CostoSada", item.DTAR_CostoSada, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_VentaSada", item.DTAR_VentaSada, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_Venta", item.DTAR_Venta, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_Peso", item.DTAR_Peso, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_Volumen", item.DTAR_Volumen, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_Minimo", item.DTAR_Minimo, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodBas", item.CONS_CodBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabBas", item.CONS_TabBas, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabZON", item.TIPO_TabZON, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodZONDestino", item.TIPO_CodZONDestino, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodZONOrigen", item.TIPO_CodZONOrigen, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDTAR_Roundtrip", item.DTAR_Roundtrip, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_Costo", item.DTAR_Costo, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_Profit", item.DTAR_Profit, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDTAR_ProfitMinimo", item.DTAR_ProfitMinimo, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTRA", item.CONS_CodTRA, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabTRA", item.CONS_TabTRA, SqlDbType.Char, 3, ParameterDirection.Input);
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
		private bool Delete(ref Det_Tarifa item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DTARSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCTAR_Codigo", item.CTAR_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCTAR_Tipo", item.CTAR_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinDTAR_Item", item.DTAR_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					
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
