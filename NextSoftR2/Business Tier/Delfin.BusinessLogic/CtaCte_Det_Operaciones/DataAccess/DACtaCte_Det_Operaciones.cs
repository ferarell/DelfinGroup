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
	public partial class BLCtaCte_Det_Operaciones
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<CtaCte_Det_Operaciones> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLCtaCte_Det_Operaciones(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<CtaCte_Det_Operaciones>();
			CtaCte_Det_Operaciones item = new CtaCte_Det_Operaciones();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private ObservableCollection<CtaCte_Det_Operaciones> SelectAll()
		{
			try
			{
				ObservableCollection<CtaCte_Det_Operaciones> items = new ObservableCollection<CtaCte_Det_Operaciones>();
				CtaCte_Det_Operaciones item = new CtaCte_Det_Operaciones();
				DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DCTOSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new CtaCte_Det_Operaciones();
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
		private CtaCte_Det_Operaciones SelectOne(Int32 DCTO_Codigo)
		{
			try
			{
				CtaCte_Det_Operaciones item = new CtaCte_Det_Operaciones();
				DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DCTOSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintDCTO_Codigo", DCTO_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert(ref CtaCte_Det_Operaciones item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DCTOSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDCTO_Codigo", item.DCTO_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOPE_Item", item.DOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSOPE_Item", item.SOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", item.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _DCTO_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintDCTO_Codigo"].Value.ToString(), out _DCTO_Codigo))
						{ item.DCTO_Codigo = _DCTO_Codigo; }
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
		private bool Update(ref CtaCte_Det_Operaciones item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DCTOSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDCTO_Codigo", item.DCTO_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOPE_Item", item.DOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSOPE_Item", item.SOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", item.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
					
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
		private bool Delete(ref CtaCte_Det_Operaciones item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_DCTOSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDCTO_Codigo", item.DCTO_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
