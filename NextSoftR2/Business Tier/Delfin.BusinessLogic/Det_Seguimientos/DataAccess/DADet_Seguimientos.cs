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
	public partial class BLDet_Seguimientos
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Det_Seguimientos> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDet_Seguimientos(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Det_Seguimientos>();
			Det_Seguimientos item = new Det_Seguimientos();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private ObservableCollection<Det_Seguimientos> SelectAll()
		{
			try
			{
				ObservableCollection<Det_Seguimientos> items = new ObservableCollection<Det_Seguimientos>();
				Det_Seguimientos item = new Det_Seguimientos();
				DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DSEGSS_Todos");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Det_Seguimientos();
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
		private Det_Seguimientos SelectOne(Int32 CSEG_Codigo)
		{
			try
			{
				Det_Seguimientos item = new Det_Seguimientos();
				DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DSEGSS_UnReg");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintCSEG_Codigo", CSEG_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		private bool Insert( Det_Seguimientos item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DSEGSI_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCSEG_Codigo", item.CSEG_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintDSEG_Item", item.DSEG_Item, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDSEG_FechaArribo", item.DSEG_FechaArribo, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDSEG_FecIngresoDep", item.DSEG_FecIngresoDep, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDSEG_FecRetiroDep", item.DSEG_FecRetiroDep, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDSEG_FecPago", item.DSEG_FecPago, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDSEG_NroContenedor", item.DSEG_NroContenedor, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDSEG_Tarja", item.DSEG_Tarja, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodESS", item.CONS_CodESS, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabESS", item.CONS_TabESS, SqlDbType.Char, 3, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);

                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", item.PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _CSEG_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCSEG_Codigo"].Value.ToString(), out _CSEG_Codigo))
						{ item.CSEG_Codigo = _CSEG_Codigo; }

                        Int32 DSEG_Item;
                        if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintDSEG_Item"].Value.ToString(), out DSEG_Item))
                        { item.DSEG_Item = DSEG_Item; }
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
		private bool Update( Det_Seguimientos item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DSEGSU_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCSEG_Codigo", item.CSEG_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintDSEG_Item", item.DSEG_Item, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDSEG_FechaArribo", item.DSEG_FechaArribo, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDSEG_FecIngresoDep", item.DSEG_FecIngresoDep, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDSEG_FecRetiroDep", item.DSEG_FecRetiroDep, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmDSEG_FecPago", item.DSEG_FecPago, SqlDbType.DateTime, 8, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDSEG_NroContenedor", item.DSEG_NroContenedor, SqlDbType.VarChar, 20, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pbitDSEG_Tarja", item.DSEG_Tarja, SqlDbType.Bit, 1, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodESS", item.CONS_CodESS, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabESS", item.CONS_TabESS, SqlDbType.Char, 3, ParameterDirection.Input);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintPACK_Codigo", item.PACK_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
		private bool Delete( Det_Seguimientos item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DSEGSD_UnReg");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCSEG_Codigo", item.CSEG_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					
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
