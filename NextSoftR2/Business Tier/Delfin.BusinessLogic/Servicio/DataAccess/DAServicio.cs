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
   public partial class BLServicio
   {
      #region [ Propiedades ]
      public IUnityContainer ContainerService { get; set; }
      public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Servicio> Loader { get; set; }
      #endregion

      #region [ Constructores ]
      public BLServicio(IUnityContainer container)
      {
         this.ContainerService = container;
         Loader = new BusinessEntityLoader<Servicio>();
         Servicio item = new Servicio();
         Loader.EntityType = item.GetType();
      }
      #endregion

      #region [ Consultas ]
      private ObservableCollection<Servicio> SelectAll()
      {
         try
         {
            ObservableCollection<Servicio> items = new ObservableCollection<Servicio>();
            Servicio item = new Servicio();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Servicio");
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Servicio();
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
      private Servicio SelectOne(Int32 SERV_Codigo)
      {
         try
         {
            Servicio item = new Servicio();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Servicio");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               if (reader.Read())
               {
                  Loader.LoadEntity(reader, item);
                  item.ServiciosDocumentos = GetAllServiciosDocumentosByServCodigo(item.SERV_Codigo);
                  item.ServiciosLineaNegocio = GetAllServiciosLineaNegocioByServCodigo(item.SERV_Codigo);
                        //item.ServiciosRegimenVia = GetAllServiciosRegimenViaByServCodigo(item.SERV_Codigo);
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

      private DataTable SelectServiciosAdicionales(Int32 SERV_Codigo)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_ServicioAdicional");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
            {
               return _dt.Tables[0];
            }
            return null;
         }
         catch (Exception ex)
         { throw ex; }
      }


      #endregion

      #region [ Metodos ]
      private bool Insert(ref Servicio item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("COM_SERVSI_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_Nombre_SPA", item.SERV_Nombre_SPA, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_Nombre_ENG", item.SERV_Nombre_ENG, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_AfeIgv", item.SERV_AfeIgv, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_Flete", item.SERV_Flete, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_ExcesoFlete", item.SERV_ExcesoFlete, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_AfeDet", item.SERV_AfeDet, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", item.CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", item.CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_Activo", item.SERV_Activo, SqlDbType.Bit, 1, ParameterDirection.Input);
               //DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CueVta", item.SERV_CueVta, SqlDbType.VarChar, 20, ParameterDirection.Input);
               //DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CueGas", item.SERV_CueGas, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_Agrup1", item.SERV_Agrup1, SqlDbType.VarChar, 5, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_Agrup2", item.SERV_Agrup2, SqlDbType.VarChar, 5, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSERV_PorDet", item.SERV_PorDet, SqlDbType.Decimal, 5, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSERV_Tipo", item.SERV_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSERV_Valor", item.SERV_Valor, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSERV_CobMin", item.SERV_CobMin, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_Autom", item.SERV_Autom, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSERV_FrecFac", item.SERV_FrecFac, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabUNT", item.TIPO_TabUNT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodUNT", item.TIPO_CodUNT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuenIngreso", item.SERV_CuenIngreso, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuenCosto", item.SERV_CuenCosto, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuenPuente", item.SERV_CuenPuente, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabDET", item.TIPO_TabDET, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodDET", item.TIPO_CodDET, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_NombreCorto", item.SERV_NombreCorto, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_Glosa", item.SERV_Glosa, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_Observaciones", item.SERV_Observaciones, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_DefinidoPor", item.SERV_DefinidoPor, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSERV_TipoMov", item.SERV_TipoMov, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabBAS", item.CONS_TabBAS, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodBAS", item.CONS_CodBAS, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabLNG", item.CONS_TabLNG, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodLNG", item.CONS_CodLNG, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCENT_Ano", item.CENT_Ano, SqlDbType.Char, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCENT_Codigo", item.CENT_Codigo, SqlDbType.VarChar, 17, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabOPE", item.TIPO_TabOPE, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodOPE", item.TIPO_CodOPE, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabOPE_Costo", item.TIPO_TabOPE_Costo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodOPE_Costo", item.TIPO_CodOPE_Costo, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);



                    //mcomun SAP
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_Agrupado", item.SERV_Agrupado, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_CodUnificador", item.SERV_CodUnificador, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_CodAgrupador", item.SERV_CodAgrupador, SqlDbType.Int, 4, ParameterDirection.Input);

                    if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               {
                  Int32 _SERV_Codigo;
                  if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintSERV_Codigo"].Value.ToString(), out _SERV_Codigo))
                  { item.SERV_Codigo = _SERV_Codigo; }
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
      private bool Update(ref Servicio item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("COM_SERVSU_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_Nombre_SPA", item.SERV_Nombre_SPA, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_Nombre_ENG", item.SERV_Nombre_ENG, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_AfeIgv", item.SERV_AfeIgv, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_Flete", item.SERV_Flete, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_ExcesoFlete", item.SERV_ExcesoFlete, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_AfeDet", item.SERV_AfeDet, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", item.CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", item.CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_Activo", item.SERV_Activo, SqlDbType.Bit, 1, ParameterDirection.Input);
               //DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CueVta", item.SERV_CueVta, SqlDbType.VarChar, 20, ParameterDirection.Input);
               //DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CueGas", item.SERV_CueGas, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_Agrup1", item.SERV_Agrup1, SqlDbType.VarChar, 5, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_Agrup2", item.SERV_Agrup2, SqlDbType.VarChar, 5, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSERV_PorDet", item.SERV_PorDet, SqlDbType.Decimal, 5, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSERV_Tipo", item.SERV_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSERV_Valor", item.SERV_Valor, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSERV_CobMin", item.SERV_CobMin, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_Autom", item.SERV_Autom, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSERV_FrecFac", item.SERV_FrecFac, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabUNT", item.TIPO_TabUNT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodUNT", item.TIPO_CodUNT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuenIngreso", item.SERV_CuenIngreso, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuenCosto", item.SERV_CuenCosto, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_CuenPuente", item.SERV_CuenPuente, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabDET", item.TIPO_TabDET, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodDET", item.TIPO_CodDET, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_NombreCorto", item.SERV_NombreCorto, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_Glosa", item.SERV_Glosa, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_Observaciones", item.SERV_Observaciones, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_DefinidoPor", item.SERV_DefinidoPor, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSERV_TipoMov", item.SERV_TipoMov, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabBAS", item.CONS_TabBAS, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodBAS", item.CONS_CodBAS, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMND", item.TIPO_TabMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", item.TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabLNG", item.CONS_TabLNG, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodLNG", item.CONS_CodLNG, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCENT_Ano", item.CENT_Ano, SqlDbType.Char, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCENT_Codigo", item.CENT_Codigo, SqlDbType.VarChar, 17, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabOPE", item.TIPO_TabOPE, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodOPE", item.TIPO_CodOPE, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabOPE_Costo", item.TIPO_TabOPE_Costo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodOPE_Costo", item.TIPO_CodOPE_Costo, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
                        

                    //mcomun SAP
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_Agrupado", item.SERV_Agrupado, SqlDbType.Bit, 1, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_CodUnificador", item.SERV_CodUnificador, SqlDbType.Int, 4, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_CodAgrupador", item.SERV_CodAgrupador, SqlDbType.Int, 4, ParameterDirection.Input);


                    Boolean m_UpdateServicio = false;
               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { m_UpdateServicio = true; }

               if (m_UpdateServicio)
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
      private bool Delete(ref Servicio item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("COM_SERVSD_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

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
