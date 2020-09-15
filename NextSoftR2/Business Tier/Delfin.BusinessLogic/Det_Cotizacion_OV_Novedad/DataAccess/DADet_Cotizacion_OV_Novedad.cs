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
	public partial class BLDet_Cotizacion_OV_Novedad
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Det_Cotizacion_OV_Novedad> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDet_Cotizacion_OV_Novedad(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Det_Cotizacion_OV_Novedad>();
			Det_Cotizacion_OV_Novedad item = new Det_Cotizacion_OV_Novedad();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private ObservableCollection<Det_Cotizacion_OV_Novedad> SelectAll()
		{
			try
			{
				ObservableCollection<Det_Cotizacion_OV_Novedad> items = new ObservableCollection<Det_Cotizacion_OV_Novedad>();
				Det_Cotizacion_OV_Novedad item = new Det_Cotizacion_OV_Novedad();
				DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Det_Cotizacion_OV_Novedad");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Det_Cotizacion_OV_Novedad();
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
		private Det_Cotizacion_OV_Novedad SelectOne(Int32 OVNO_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo)
		{
			try
			{
				Det_Cotizacion_OV_Novedad item = new Det_Cotizacion_OV_Novedad();
				DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Det_Cotizacion_OV_Novedad");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintOVNO_Codigo", OVNO_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert(ref Det_Cotizacion_OV_Novedad item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_INSERTAR_Det_Cotizacion_OV_Novedad");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintOVNO_Codigo", item.OVNO_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmOVNO_Fecha", item.OVNO_Fecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchOVNO_Descrip", item.OVNO_Descrip, SqlDbType.VarChar, 1024, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitOVNO_Email", item.OVNO_Email, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabNot", item.CONS_TabNot, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodNot", item.CONS_CodNot, SqlDbType.Char, 3, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _OVNO_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintOVNO_Codigo"].Value.ToString(), out _OVNO_Codigo))
						{ item.OVNO_Codigo = _OVNO_Codigo; }
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
		private bool Update(ref Det_Cotizacion_OV_Novedad item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ACTUALIZAR_Det_Cotizacion_OV_Novedad");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintOVNO_Codigo", item.OVNO_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmOVNO_Fecha", item.OVNO_Fecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchOVNO_Descrip", item.OVNO_Descrip, SqlDbType.VarChar, 1024, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitOVNO_Email", item.OVNO_Email, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabNot", item.CONS_TabNot, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodNot", item.CONS_CodNot, SqlDbType.Char, 3, ParameterDirection.Input);
					
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
		private bool Delete(ref Det_Cotizacion_OV_Novedad item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ELIMINAR_Det_Cotizacion_OV_Novedad");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintOVNO_Codigo", item.OVNO_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
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
