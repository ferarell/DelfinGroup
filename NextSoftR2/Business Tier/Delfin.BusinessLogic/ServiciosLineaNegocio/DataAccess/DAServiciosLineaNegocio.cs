﻿using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Infrastructure.Aspect.DataAccess;
using Infrastructure.Aspect.BusinessEntity;

using Delfin.Entities;
using System.Data.SqlClient;

namespace Delfin.BusinessLogic
{
	public partial class BLServiciosLineaNegocio
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<ServiciosLineaNegocio> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLServiciosLineaNegocio(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<ServiciosLineaNegocio>();
            ServiciosLineaNegocio Item = new ServiciosLineaNegocio();
			Loader.EntityType = Item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private System.Data.DataTable SelectAllByFilterDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				DataSet _ds = new DataSet();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("SEDOSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				_ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
				if (_ds != null && _ds.Tables.Count == 1)
				{ _ds.Tables[0].TableName = "ServiciosLineaNegocio"; return _ds.Tables[0]; }
				else
				{ return null; }
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<ServiciosLineaNegocio> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				ObservableCollection<ServiciosLineaNegocio> items = new ObservableCollection<ServiciosLineaNegocio>();
                ServiciosLineaNegocio item = new ServiciosLineaNegocio();
				if (!String.IsNullOrEmpty(x_procedure))
				{ DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
				else
				{ DataAccessEnterpriseSQL.DAAsignarProcedure("SEDOSS_TodosByFilters"); }
				if (x_filters != null && x_filters.Count > 0)
				{
					foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
					{ DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
				}
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new ServiciosLineaNegocio();
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
						items.Add(item);
					}
				}
				return items;
			}
			catch (Exception)
			{ throw; }
		}
		private ObservableCollection<ServiciosLineaNegocio> SelectAll()
		{
			try
			{
				ObservableCollection<ServiciosLineaNegocio> items = new ObservableCollection<ServiciosLineaNegocio>();
                ServiciosLineaNegocio item = new ServiciosLineaNegocio();
				DataAccessEnterpriseSQL.DAAsignarProcedure("SEDOSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new ServiciosLineaNegocio();
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
						items.Add(item);
					}
				}
				return items;
			}
			catch (Exception)
			{ throw; }
		}
		private ServiciosLineaNegocio SelectOne(Int32 SERV_Codigo)
		{
			try
			{
                ServiciosLineaNegocio item = new ServiciosLineaNegocio();
				DataAccessEnterpriseSQL.DAAsignarProcedure("SEDOSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
			catch (Exception)
			{ throw; }
		}
		#endregion

		#region [ Metodos ]
		public bool Insert(ref ServiciosLineaNegocio Item)
		{
			try
			{
                if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SELNSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", Item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabLNG", Item.CONS_TabLNG, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodLNG", Item.CONS_CodLNG, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSLNG_Remarks", Item.SLNG_Remarks, SqlDbType.VarChar, 255, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", Item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", Item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", Item.CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", Item.CONS_CodVIA, SqlDbType.Char, 3, ParameterDirection.Input);


                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuentaIngreso", Item.SERV_CuentaIngreso, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuentaCosto", Item.SERV_CuentaCosto, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuentaIngresoSAP", Item.SERV_CuentaIngresoSAP, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuentaCostoSAP", Item.SERV_CuentaCostoSAP, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", Item.TIPE_Codigo, SqlDbType.SmallInt, 4, ParameterDirection.Input);
                                       
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_AfeIgv", Item.SERV_AfeIgv, SqlDbType.Bit, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_AfeReembolso", Item.SERV_AfeReembolso, SqlDbType.Bit, 4, ParameterDirection.Input);

					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    //DataAccessEnterpriseSQL.DAAgregarParametro("@pdttAUDI_FecCrea", Item.AUDI_FecCrea, SqlDbType.DateTime,10, ParameterDirection.Input);
                    //DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    //DataAccessEnterpriseSQL.DAAgregarParametro("@pdttAUDI_FecMod", Item.AUDI_FecMod, SqlDbType.DateTime, 10, ParameterDirection.Input);

                    if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _SERV_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintSERV_Codigo"].Value.ToString(), out _SERV_Codigo))
						{ Item.SERV_Codigo = _SERV_Codigo; }
						return true;
					}
					else
					{ return false; }
				}
				else
				{ return true; }
			}
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    throw new Exception
                       (String.Format("# Hay mas de un registro con el mismo Documento y el Tipo de Mov.(I/C) #" + ex.Message, ex));
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            { throw ex; }
		}
		public bool Update(ref ServiciosLineaNegocio Item)
		{
			try
			{
                if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SELNSU_UnReg");
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", Item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabLNG", Item.CONS_TabLNG, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodLNG", Item.CONS_CodLNG, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSLNG_Remarks", Item.SLNG_Remarks, SqlDbType.VarChar, 255, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", Item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", Item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", Item.CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", Item.CONS_CodVIA, SqlDbType.Char, 3, ParameterDirection.Input);


                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuentaIngreso", Item.SERV_CuentaIngreso, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuentaCosto", Item.SERV_CuentaCosto, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuentaIngresoSAP", Item.SERV_CuentaIngresoSAP, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuentaCostoSAP", Item.SERV_CuentaCostoSAP, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", Item.TIPE_Codigo, SqlDbType.SmallInt, 4, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_AfeIgv", Item.SERV_AfeIgv, SqlDbType.Bit, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_AfeReembolso", Item.SERV_AfeReembolso, SqlDbType.Bit, 4, ParameterDirection.Input);

					//DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					//DataAccessEnterpriseSQL.DAAgregarParametro("@pdttAUDI_FecCrea", Item.AUDI_FecCrea, SqlDbType.DateTime, 10, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    //DataAccessEnterpriseSQL.DAAgregarParametro("@pdttAUDI_FecMod", Item.AUDI_FecMod, SqlDbType.DateTime, 10, ParameterDirection.Input);


                    if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
				}
				else
				{ return true; }
			}
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    throw new Exception
                       (String.Format("# Hay mas de un registro con el mismo Documento y el Tipo de Mov.(I/C) #" + ex.Message, ex));
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            { throw ex; }
		}
		public bool Delete(ref ServiciosLineaNegocio Item)
		{
			try
			{
				if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted) //&& Item.SEDO_Seleccionar == 0)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SELNSD_UnReg");
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", Item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabLNG", Item.CONS_TabLNG, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodLNG", Item.CONS_CodLNG, SqlDbType.Char, 3, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", Item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", Item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", Item.CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", Item.CONS_CodVIA, SqlDbType.Char, 3, ParameterDirection.Input);


                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSLNG_Remarks", Item.SLNG_Remarks, SqlDbType.VarChar, 255, ParameterDirection.Input);


                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuentaIngreso", Item.SERV_CuentaIngreso, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuentaCosto", Item.SERV_CuentaCosto, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuentaIngresoSAP", Item.SERV_CuentaIngresoSAP, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuentaCostoSAP", Item.SERV_CuentaCostoSAP, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", Item.TIPE_Codigo, SqlDbType.SmallInt, 4, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_AfeIgv", Item.SERV_AfeIgv, SqlDbType.Bit, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_AfeReembolso", Item.SERV_AfeReembolso, SqlDbType.Bit, 4, ParameterDirection.Input);

					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdttAUDI_FecCrea", Item.AUDI_FecCrea, SqlDbType.DateTime, 10, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdttAUDI_FecMod", Item.AUDI_FecMod, SqlDbType.DateTime, 10, ParameterDirection.Input);

                    if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception)
			{ throw; }
		}
		#endregion
	}
}
