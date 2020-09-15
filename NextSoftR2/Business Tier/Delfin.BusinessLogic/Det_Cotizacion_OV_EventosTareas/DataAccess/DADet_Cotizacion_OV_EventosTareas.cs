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
	public partial class BLDet_Cotizacion_OV_EventosTareas
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
      public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Det_Cotizacion_OV_EventosTareas> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDet_Cotizacion_OV_EventosTareas(IUnityContainer container)
		{
			this.ContainerService = container;
         Loader = new BusinessEntityLoader<Det_Cotizacion_OV_EventosTareas>();
         Det_Cotizacion_OV_EventosTareas item = new Det_Cotizacion_OV_EventosTareas();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
      private ObservableCollection<Det_Cotizacion_OV_EventosTareas> SelectAll()
		{
			try
			{
            ObservableCollection<Det_Cotizacion_OV_EventosTareas> items = new ObservableCollection<Det_Cotizacion_OV_EventosTareas>();
            Det_Cotizacion_OV_EventosTareas item = new Det_Cotizacion_OV_EventosTareas();
				DataAccessEnterpriseSQL.DAAsignarProcedure("COM_EVENSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
                  item = new Det_Cotizacion_OV_EventosTareas();
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
      private Det_Cotizacion_OV_EventosTareas SelectOne(Int32 CCOT_Numero, Int16 CCOT_Tipo, Int16 EVEN_Item)
		{
			try
			{
            Det_Cotizacion_OV_EventosTareas item = new Det_Cotizacion_OV_EventosTareas();
				DataAccessEnterpriseSQL.DAAsignarProcedure("COM_EVENSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinEVEN_Item", EVEN_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
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
      private bool Insert(ref Det_Cotizacion_OV_EventosTareas item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("COM_EVENSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEVEN_Item", item.EVEN_Item, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmEVEN_Fecha", item.EVEN_Fecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitEVEN_Cumplida", item.EVEN_Cumplida, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchEVEN_Usuario", item.EVEN_Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchEVEN_Observaciones", item.EVEN_Observaciones, SqlDbType.VarChar, 8000, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabEVE", item.TIPO_TabEVE, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodEVE", item.TIPO_CodEVE, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabMOD", item.CONS_TabMOD, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodMOD", item.CONS_CodMOD, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitEVEN_Manual", item.EVEN_Manual, SqlDbType.Bit, 1, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
                  //Int32 _CCOT_Numero;
                  //if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCCOT_Numero"].Value.ToString(), out _CCOT_Numero))
                  //{ item.CCOT_Numero = _CCOT_Numero; }
                  //Int16 _CCOT_Tipo;
                  //if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinCCOT_Tipo"].Value.ToString(), out _CCOT_Tipo))
                  //{ item.CCOT_Tipo = _CCOT_Tipo; }
						Int16 _EVEN_Item;
						if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinEVEN_Item"].Value.ToString(), out _EVEN_Item))
						{ item.EVEN_Item = _EVEN_Item; }
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
      private bool Update(ref Det_Cotizacion_OV_EventosTareas item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("COM_EVENSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEVEN_Item", item.EVEN_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmEVEN_Fecha", item.EVEN_Fecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitEVEN_Cumplida", item.EVEN_Cumplida, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchEVEN_Usuario", item.EVEN_Usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchEVEN_Observaciones", item.EVEN_Observaciones, SqlDbType.VarChar, 8000, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabEVE", item.TIPO_TabEVE, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodEVE", item.TIPO_CodEVE, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabMOD", item.CONS_TabMOD, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodMOD", item.CONS_CodMOD, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitEVEN_Manual", item.EVEN_Manual, SqlDbType.Bit, 1, ParameterDirection.Input);

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
      private bool Delete(ref Det_Cotizacion_OV_EventosTareas item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("COM_EVENSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinEVEN_Item", item.EVEN_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					
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
