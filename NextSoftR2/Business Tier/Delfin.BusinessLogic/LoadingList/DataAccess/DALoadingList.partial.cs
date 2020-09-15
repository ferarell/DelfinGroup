using System;
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
using Infrastructure.Aspect.Collections;

using Delfin.Entities;
using System.Data.SqlClient;

namespace Delfin.BusinessLogic
{
	public partial class BLLoadingList
	{
		#region [ Consultas ]
        private LoadingList SelectALoadingListByLoad_Codigo(Nullable<Int32>LOAD_Codigo)
        {
            try
            {

                DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSU_Codigo");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                
               
                LoadingList item = new LoadingList();
                using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new LoadingList();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                }

                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion

		#region [ Metodos ]
      private Boolean ImportResumido(DataTable dtImportacion, String LOAD_CargaUsuario, DateTime LOAD_CargaFecha, String CONS_TabVIA, String CONS_CodVIA, ref String LOAD_MensajeError)
      {
         try
         {
            DataAccessEnterpriseSQL.DABeginTransaction();
            DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSI_ImportacionResumido");

            DataAccessEnterpriseSQL.DAAgregarParametro("@LoadingListResumido", dtImportacion, SqlDbType.Structured);
            //DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_CargaUsuario", LOAD_CargaUsuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_CargaFecha", LOAD_CargaFecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", CONS_CodVIA, SqlDbType.Char, 3, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_MensajeError", LOAD_MensajeError, SqlDbType.VarChar, 100, ParameterDirection.InputOutput);

            //ObservableCollection<LoadingList> items = new ObservableCollection<LoadingList>();
            //LoadingList item = new LoadingList();
            System.Data.DataSet _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();

            if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchLOAD_MensajeError"].Value != null && DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchLOAD_MensajeError"].Value != DBNull.Value && !String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchLOAD_MensajeError"].Value.ToString()))
            { 
               LOAD_MensajeError = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchLOAD_MensajeError"].Value.ToString();
               DataAccessEnterpriseSQL.DARollbackTransaction();
               return false; 
            }

            if (String.IsNullOrEmpty(LOAD_MensajeError))
            {
               if (_ds != null && _ds.Tables.Count > 0 && _ds.Tables[0].Rows.Count > 0)
               {
                  //LOAD_MensajeError = "Debe ingresar los siguientes puertos en el sistema antes de Importar el Archivo Seleccionado: ";
                  LOAD_MensajeError = "Los siguientes puertos no se encuentran registrados en el sistema: ";
                  Boolean _primero = true;
                  foreach (DataRow _row in _ds.Tables[0].Rows)
                  {
                     if (!_primero) { LOAD_MensajeError += ", "; }
                     LOAD_MensajeError += String.Format("{0}", _row[0].ToString());
                     _primero = false;
                  }
                  //DataAccessEnterpriseSQL.DARollbackTransaction();
                  //return false;

                  DataAccessEnterpriseSQL.DACommitTransaction();
                  return true;
               }
            }

            DataAccessEnterpriseSQL.DACommitTransaction();
            return true;
            
            //return SelectImportResumido(Item.NVIA_Codigo);

            //LOAD_Mensajeerror

         }
         catch (Exception)
         {
            DataAccessEnterpriseSQL.DARollbackTransaction();
            throw; 
         }
      }
      private ObservableCollection<LoadingList> SelectImportResumido(DateTime LOAD_CargaFecha)
      {
         try
         {

            DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSS_ImportacionResumido");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_CargaFecha", LOAD_CargaFecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
            

            ObservableCollection<LoadingList> items = new ObservableCollection<LoadingList>();
            LoadingList item = new LoadingList();
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new LoadingList();
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

      private Boolean ImportDetallado(DataTable dtImportacion, String LOAD_CargaUsuario, DateTime LOAD_CargaFecha, String CONS_TabVIA, String CONS_CodVIA, ref String LOAD_MensajeError)
      {
         try
         {
            DataAccessEnterpriseSQL.DABeginTransaction();
            DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSI_ImportacionDetallado");

            DataAccessEnterpriseSQL.DAAgregarParametro("@LoadingListDetallado", dtImportacion, SqlDbType.Structured);
            //DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", Item.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_CargaUsuario", LOAD_CargaUsuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_CargaFecha", LOAD_CargaFecha, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVIA", CONS_TabVIA, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVIA", CONS_CodVIA, SqlDbType.Char, 3, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_MensajeError", LOAD_MensajeError, SqlDbType.VarChar, 100, ParameterDirection.InputOutput);

            //ObservableCollection<LoadingList> items = new ObservableCollection<LoadingList>();
            //LoadingList item = new LoadingList();
            System.Data.DataSet _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();

            if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchLOAD_MensajeError"].Value != null && DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchLOAD_MensajeError"].Value != DBNull.Value && !String.IsNullOrEmpty(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchLOAD_MensajeError"].Value.ToString()))
            { 
               LOAD_MensajeError = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchLOAD_MensajeError"].Value.ToString();
               DataAccessEnterpriseSQL.DARollbackTransaction();
               return false; 
            }

            if (String.IsNullOrEmpty(LOAD_MensajeError))
            {
               if (_ds != null && _ds.Tables.Count > 0 && _ds.Tables[0].Rows.Count > 0)
               {
                  //LOAD_MensajeError = "Debe ingresar los siguientes puertos en el sistema antes de Importar el Archivo Seleccionado: ";
                  LOAD_MensajeError = "Los siguientes puertos no se encuentran registrados en el sistema: ";
                  Boolean _primero = true;
                  foreach (DataRow _row in _ds.Tables[0].Rows)
                  {
                     if (!_primero) { LOAD_MensajeError += ", "; }
                     LOAD_MensajeError += String.Format("{0}", _row[0].ToString());
                     _primero = false;
                  }
                  //DataAccessEnterpriseSQL.DARollbackTransaction();
                  //return false;
                  // Se muestra mensaje de puertos
                  DataAccessEnterpriseSQL.DACommitTransaction();
                  return true;
               }
            }

            DataAccessEnterpriseSQL.DACommitTransaction();
            return true;
            //return SelectImportResumido(Item.NVIA_Codigo);
         }
         catch (Exception)
         {
            DataAccessEnterpriseSQL.DARollbackTransaction();
            throw; 
         }
      }
      private ObservableCollection<LoadingListDetallado> SelectImportDetallado(DateTime LOAD_CargaFecha)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSS_ImportacionDetallado");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_CargaFecha", LOAD_CargaFecha, SqlDbType.DateTime, 8, ParameterDirection.Input);

            BusinessEntityLoader<LoadingListDetallado> LoaderLoadingListDetallado = new BusinessEntityLoader<LoadingListDetallado>();
            LoadingListDetallado _item = new LoadingListDetallado();
            LoaderLoadingListDetallado.EntityType = _item.GetType();
            
            ObservableCollection<LoadingListDetallado> _items = new ObservableCollection<LoadingListDetallado>();
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  _item = new LoadingListDetallado();
                  LoaderLoadingListDetallado.LoadEntity(reader, _item);
                  //_item.Instance = InstanceEntity.Unchanged;
                  _items.Add(_item);
               }
            }

            return _items;
         }
         catch (Exception)
         { throw; }
      }

      private Boolean UpdateCorreoPreAlerta(Int32 LOAD_Codigo, Boolean LOAD_EnvioCorreo, String LOAD_EnvioCorreoUsr)
      {
          try
          {
              DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADSU_Correo");
              DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
              DataAccessEnterpriseSQL.DAAgregarParametro("@pbitLOAD_EnvioCorreo", LOAD_EnvioCorreo, SqlDbType.Bit, 1, ParameterDirection.Input);
              DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_EnvioCorreoUsuario", LOAD_EnvioCorreoUsr, SqlDbType.VarChar, 20, ParameterDirection.Input);

              if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
              { return true; }
              else
              { return false; }
          }
          catch (Exception ex)
          { throw ex; }
      }
      private bool InsertControlDoc(ref LoadingList item)
      {
          try
          {
              if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
              {
                  DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADIU_Pre_Alerta");
                  DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", item.LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_HBL", item.LOAD_HBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_MBL", item.LOAD_MBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_CargaUsuario", item.LOAD_CargaUsuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

                 
                  if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
                  {
                      Int32 _LOAD_Codigo;
                      if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintLOAD_Codigo"].Value.ToString(), out _LOAD_Codigo))
                      { item.LOAD_Codigo = _LOAD_Codigo; }
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
                     (String.Format("# El Número de HBL ya existe en la Base de Datos. #" + ex.Message, ex));
              }
              else
              {
                  throw;
              }
          }
          catch (Exception ex)
          { throw ex; }
      }

      private Boolean UpdateControlDoc(ref LoadingList item)
      {
          try
          {
              DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADUU_Pre_Alerta");
              DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", item.LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
              DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_HBL", item.LOAD_HBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
              DataAccessEnterpriseSQL.DAAgregarParametro("@pvchLOAD_MBL", item.LOAD_MBL, SqlDbType.VarChar, 50, ParameterDirection.Input);
              DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmLOAD_FecDevolucion", item.LOAD_FecDevolucion, SqlDbType.DateTime, 8, ParameterDirection.Input);
              //DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
              
              if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
              { return true; }
              else
              { return false; }
          }
          catch (SqlException ex)
          {
              if (ex.Number == 2627)
              {
                  throw new Exception
                     (String.Format("# El Número de HBL ya existe en la Base de Datos. #" + ex.Message, ex));
              }
              else
              {
                  throw;
              }
          }
          catch (Exception ex)
          { throw ex; }
      }

      private Boolean DeleteControlDoc(ref LoadingList item)
      {
          try
          {
              if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
              {
                  DataAccessEnterpriseSQL.DAAsignarProcedure("OPE_LOADDU_Pre_Alerta");
                  DataAccessEnterpriseSQL.DAAgregarParametro("@pintLOAD_Codigo", item.LOAD_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

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
              if (ex.Number == 547)
              {
                  throw new Exception
                     (String.Format("# No se puede Eliminar esta Item por tener relaciones activas con otros Registros. #" + ex.Message, ex));
              }
              else
              {
                  throw;
              }
          }
          catch (Exception)
          { throw; }
      }
		#endregion
	}
}
