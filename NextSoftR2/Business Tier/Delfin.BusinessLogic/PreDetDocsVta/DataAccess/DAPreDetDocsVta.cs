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
	public partial class BLPreDetDocsVta
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<PreDetDocsVta> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLPreDetDocsVta(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<PreDetDocsVta>();
			PreDetDocsVta item = new PreDetDocsVta();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
        private ObservableCollection<PreDetDocsVta> SelectAllPorDOCV_Codigo(Int32 x_DOCV_Codigo)
		{
			try
			{
				ObservableCollection<PreDetDocsVta> items = new ObservableCollection<PreDetDocsVta>();
				PreDetDocsVta item = new PreDetDocsVta();
                DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDDOSS_TodosPorDOCV_Codigo");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", x_DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new PreDetDocsVta();
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
		private PreDetDocsVta SelectOne(Int16 PDDO_Item, Int32 DOCV_Codigo)
		{
			try
			{
				PreDetDocsVta item = new PreDetDocsVta();
				DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDDOSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@psinPDDO_Item", PDDO_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert(ref PreDetDocsVta item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDDOSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinPDDO_Item", item.PDDO_Item, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", item.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Cantidad", item.DDOV_Cantidad, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_PrecioUnitario", item.DDOV_PrecioUnitario, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_PrecioUnitarioD", item.DDOV_PrecioUnitarioD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_ValorVenta", item.DDOV_ValorVenta, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_ValorVentaD", item.DDOV_ValorVentaD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto1", item.DDOV_Impuesto1, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto1D", item.DDOV_Impuesto1D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto2", item.DDOV_Impuesto2, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto2D", item.DDOV_Impuesto2D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto3", item.DDOV_Impuesto3, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto3D", item.DDOV_Impuesto3D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto4", item.DDOV_Impuesto4, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto4D", item.DDOV_Impuesto4D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDOV_Notas", item.DDOV_Notas, SqlDbType.VarChar, 1000, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDOV_Descripcion", item.DDOV_Descripcion, SqlDbType.VarChar, 100, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_ValorTotal", item.DDOV_ValorTotal, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_ValorTotalD", item.DDOV_ValorTotalD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int16 _PDDO_Item;
						if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@psinPDDO_Item"].Value.ToString(), out _PDDO_Item))
						{ item.PDDO_Item = _PDDO_Item; }
						Int32 _DOCV_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintDOCV_Codigo"].Value.ToString(), out _DOCV_Codigo))
						{ item.DOCV_Codigo = _DOCV_Codigo; }
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
		private bool Update(ref PreDetDocsVta item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDDOSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinPDDO_Item", item.PDDO_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", item.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Cantidad", item.DDOV_Cantidad, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_PrecioUnitario", item.DDOV_PrecioUnitario, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_PrecioUnitarioD", item.DDOV_PrecioUnitarioD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_ValorVenta", item.DDOV_ValorVenta, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_ValorVentaD", item.DDOV_ValorVentaD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto1", item.DDOV_Impuesto1, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto1D", item.DDOV_Impuesto1D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto2", item.DDOV_Impuesto2, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto2D", item.DDOV_Impuesto2D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto3", item.DDOV_Impuesto3, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto3D", item.DDOV_Impuesto3D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto4", item.DDOV_Impuesto4, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_Impuesto4D", item.DDOV_Impuesto4D, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDOV_Notas", item.DDOV_Notas, SqlDbType.VarChar, 1000, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDDOV_Descripcion", item.DDOV_Descripcion, SqlDbType.VarChar, 100, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_ValorTotal", item.DDOV_ValorTotal, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdecDDOV_ValorTotalD", item.DDOV_ValorTotalD, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);

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
		private bool Delete(ref PreDetDocsVta item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDDOSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@psinPDDO_Item", item.PDDO_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", item.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return true; }
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
