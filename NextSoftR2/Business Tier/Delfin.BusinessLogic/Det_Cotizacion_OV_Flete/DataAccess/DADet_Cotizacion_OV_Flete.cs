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
	public partial class BLDet_Cotizacion_OV_Flete
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Det_Cotizacion_OV_Flete> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDet_Cotizacion_OV_Flete(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Det_Cotizacion_OV_Flete>();
			Det_Cotizacion_OV_Flete item = new Det_Cotizacion_OV_Flete();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private ObservableCollection<Det_Cotizacion_OV_Flete> SelectAll()
		{
			try
			{
				ObservableCollection<Det_Cotizacion_OV_Flete> items = new ObservableCollection<Det_Cotizacion_OV_Flete>();
				Det_Cotizacion_OV_Flete item = new Det_Cotizacion_OV_Flete();
				DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Det_Cotizacion_OV_Flete");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Det_Cotizacion_OV_Flete();
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
		private Det_Cotizacion_OV_Flete SelectOne(Int32 CCOT_Numero, Int32 DCOT_Item, Int16 CCOT_Tipo)
		{
			try
			{
				Det_Cotizacion_OV_Flete item = new Det_Cotizacion_OV_Flete();
				DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Det_Cotizacion_OV_Flete");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintDCOT_Item", DCOT_Item, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
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
		private bool Insert(ref Det_Cotizacion_OV_Flete item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_INSERTAR_Det_Cotizacion_OV_Flete");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintDCOT_Item", item.DCOT_Item, SqlDbType.Int, 4, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", item.PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDCOT_Producto", item.DCOT_Producto, SqlDbType.VarChar, 150, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDCOT_Cantidad", item.DCOT_Cantidad, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCOT_PrecioUniCosto", item.DCOT_PrecioUniCosto, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCOT_TotalUniCosto", item.DCOT_TotalUniCosto, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCOT_TotalUniVenta", item.DCOT_TotalUniVenta, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCOT_PrecioUniVenta", item.DCOT_PrecioUniVenta, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCOT_Importe", item.DCOT_Importe, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDCOT_Peso", item.DCOT_Peso, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDCOT_Volumen", item.DCOT_Volumen, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDCOT_Bultos", item.DCOT_Bultos, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDCOT_Largo", item.DCOT_Largo, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDCOT_Ancho", item.DCOT_Ancho, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDCOT_Alto", item.DCOT_Alto, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabUnm", item.TIPO_TabUnm, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodUnm", item.TIPO_CodUnm, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabCDT", item.TIPO_TabCDT, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodCDT", item.TIPO_CodCDT, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintTARI_Codigo", item.TARI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _DCOT_Item;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintDCOT_Item"].Value.ToString(), out _DCOT_Item))
						{ item.DCOT_Item = _DCOT_Item; }
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
		private bool Update(ref Det_Cotizacion_OV_Flete item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ACTUALIZAR_Det_Cotizacion_OV_Flete");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDCOT_Item", item.DCOT_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", item.PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDCOT_Producto", item.DCOT_Producto, SqlDbType.VarChar, 150, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDCOT_Cantidad", item.DCOT_Cantidad, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCOT_PrecioUniCosto", item.DCOT_PrecioUniCosto, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCOT_TotalUniCosto", item.DCOT_TotalUniCosto, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCOT_TotalUniVenta", item.DCOT_TotalUniVenta, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCOT_PrecioUniVenta", item.DCOT_PrecioUniVenta, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDCOT_Importe", item.DCOT_Importe, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDCOT_Peso", item.DCOT_Peso, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDCOT_Volumen", item.DCOT_Volumen, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDCOT_Bultos", item.DCOT_Bultos, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDCOT_Largo", item.DCOT_Largo, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDCOT_Ancho", item.DCOT_Ancho, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pnumDCOT_Alto", item.DCOT_Alto, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabUnm", item.TIPO_TabUnm, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodUnm", item.TIPO_CodUnm, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabCDT", item.TIPO_TabCDT, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodCDT", item.TIPO_CodCDT, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintTARI_Codigo", item.TARI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
		private bool Delete(ref Det_Cotizacion_OV_Flete item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ELIMINAR_Det_Cotizacion_OV_Flete");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDCOT_Item", item.DCOT_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					
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
