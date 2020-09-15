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
	public partial class BLDetDocsVta_Det_Operacion
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<DetDocsVta_Det_Operacion> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDetDocsVta_Det_Operacion(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<DetDocsVta_Det_Operacion>();
			DetDocsVta_Det_Operacion item = new DetDocsVta_Det_Operacion();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private ObservableCollection<DetDocsVta_Det_Operacion> SelectAll()
		{
			try
			{
				ObservableCollection<DetDocsVta_Det_Operacion> items = new ObservableCollection<DetDocsVta_Det_Operacion>();
				DetDocsVta_Det_Operacion item = new DetDocsVta_Det_Operacion();
                DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DDVOSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new DetDocsVta_Det_Operacion();
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
		private DetDocsVta_Det_Operacion SelectOne(Int32 DDVO_Codigo)
		{
			try
			{
				DetDocsVta_Det_Operacion item = new DetDocsVta_Det_Operacion();
                DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DDVOSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintDDVO_Codigo", DDVO_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert(ref DetDocsVta_Det_Operacion item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
                    DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DDVOSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDDVO_Codigo", item.DDVO_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOPE_Item", item.DOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSOPE_Item", item.SOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDDOV_Item", item.DDOV_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", item.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _DDVO_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintDDVO_Codigo"].Value.ToString(), out _DDVO_Codigo))
						{ item.DDVO_Codigo = _DDVO_Codigo; }
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
		private bool Update(ref DetDocsVta_Det_Operacion item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
                    DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DDVOSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDDVO_Codigo", item.DDVO_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOPE_Item", item.DOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSOPE_Item", item.SOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinDDOV_Item", item.DDOV_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", item.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
					
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
		private bool Delete(ref DetDocsVta_Det_Operacion item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
                    DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DDVOSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDDVO_Codigo", item.DDVO_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
