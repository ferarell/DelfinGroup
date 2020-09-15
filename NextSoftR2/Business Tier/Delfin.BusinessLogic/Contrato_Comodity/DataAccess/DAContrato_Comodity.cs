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
	public partial class BLContrato_Comodity
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Contrato_Comodity> Loader { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLContrato_Comodity(IUnityContainer container)
		{
			this.ContainerService = container;
			Loader = new BusinessEntityLoader<Contrato_Comodity>();
			Contrato_Comodity item = new Contrato_Comodity();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		private ObservableCollection<Contrato_Comodity> SelectAll()
		{
			try
			{
				ObservableCollection<Contrato_Comodity> items = new ObservableCollection<Contrato_Comodity>();
				Contrato_Comodity item = new Contrato_Comodity();
				DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Contrato_Comodity");
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Contrato_Comodity();
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
		private Contrato_Comodity SelectOne(Int32 CONT_Codigo, String TIPO_TabCDT, String TIPO_CodCDT)
		{
			try
			{
				Contrato_Comodity item = new Contrato_Comodity();
				DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Contrato_Comodity");
				DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabCDT", TIPO_TabCDT, SqlDbType.Char, 3, ParameterDirection.Input);
				DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodCDT", TIPO_CodCDT, SqlDbType.Char, 3, ParameterDirection.Input);
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
		private bool Insert(ref Contrato_Comodity item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_INSERTAR_Contrato_Comodity");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", item.CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabCDT", item.TIPO_TabCDT, SqlDbType.Char, 3, ParameterDirection.InputOutput);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodCDT", item.TIPO_CodCDT, SqlDbType.Char, 3, ParameterDirection.InputOutput);
					
					DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);
					
					if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
					{
						Int32 _CONT_Codigo;
						if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintCONT_Codigo"].Value.ToString(), out _CONT_Codigo))
						{ item.CONT_Codigo = _CONT_Codigo; }
                  //String _TIPO_TabCDT;
                  //if (String.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrTIPO_TabCDT"].Value.ToString(), out _TIPO_TabCDT))
                  //{ item.TIPO_TabCDT = _TIPO_TabCDT; }
                  //String _TIPO_CodCDT;
                  //if (String.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrTIPO_CodCDT"].Value.ToString(), out _TIPO_CodCDT))
                  //{ item.TIPO_CodCDT = _TIPO_CodCDT; }
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
		private bool Update(ref Contrato_Comodity item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ACTUALIZAR_Contrato_Comodity");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", item.CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabCDT", item.TIPO_TabCDT, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodCDT", item.TIPO_CodCDT, SqlDbType.Char, 3, ParameterDirection.Input);
					
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
		private bool Delete(ref Contrato_Comodity item)
		{
			try
			{
				if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
				{
					DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ELIMINAR_Contrato_Comodity");
					DataAccessEnterpriseSQL.DAAgregarParametro("@pintCONT_Codigo", item.CONT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabCDT", item.TIPO_TabCDT, SqlDbType.Char, 3, ParameterDirection.Input);
					DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodCDT", item.TIPO_CodCDT, SqlDbType.Char, 3, ParameterDirection.Input);
					
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
