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
	public partial class BLPreDetDocsVta_Det_Operacion
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<PreDetDocsVta_Det_Operacion> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLPreDetDocsVta_Det_Operacion(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<PreDetDocsVta_Det_Operacion>();
			PreDetDocsVta_Det_Operacion item = new PreDetDocsVta_Det_Operacion();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private ObservableCollection<PreDetDocsVta_Det_Operacion> SelectAll()
		{
			try
			{
				ObservableCollection<PreDetDocsVta_Det_Operacion> items = new ObservableCollection<PreDetDocsVta_Det_Operacion>();
				PreDetDocsVta_Det_Operacion item = new PreDetDocsVta_Det_Operacion();
                DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDVOSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new PreDetDocsVta_Det_Operacion();
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
        private PreDetDocsVta_Det_Operacion SelectOne(Int32 PDVO_Codigo)
		{
			try
			{
				PreDetDocsVta_Det_Operacion item = new PreDetDocsVta_Det_Operacion();
                DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDVOSS_UnReg");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintPDVO_Codigo", PDVO_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert(ref PreDetDocsVta_Det_Operacion item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
                    DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDVOSI_UnReg");
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintPDVO_Codigo", item.PDVO_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSOPE_Item", item.SOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOPE_Item", item.DOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinPDDO_Item", item.PDDO_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", item.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _PDVO_Codigo;
                        if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintPDVO_Codigo"].Value.ToString(), out _PDVO_Codigo))
                        { item.PDVO_Codigo = _PDVO_Codigo; }
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
		private bool Update(ref PreDetDocsVta_Det_Operacion item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
                    DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDVOSU_UnReg");
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintPDVO_Codigo", item.PDVO_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSOPE_Item", item.SOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOPE_Item", item.DOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinPDDO_Item", item.PDDO_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
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
		private bool Delete(ref PreDetDocsVta_Det_Operacion item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
                    DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDVOSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintPDVO_Codigo", item.PDVO_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
