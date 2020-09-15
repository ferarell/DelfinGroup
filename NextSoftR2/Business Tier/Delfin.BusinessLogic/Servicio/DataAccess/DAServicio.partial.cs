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
using Delfin.Entities;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.BusinessLogic
{
    public partial class BLServicio
    {
        #region [ Consultas ]
        private ObservableCollection<Servicio> SelectAllByViaRegimen(String CONS_TabVia, String CONS_CodVia, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabLNG, String CONS_CodLNG)
        {
            try
            {
                ObservableCollection<Servicio> items = new ObservableCollection<Servicio>();
                Servicio item = new Servicio();
                DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Servicio_ByViaRegimen");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabLNG", CONS_TabLNG, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodLNG", CONS_CodLNG, SqlDbType.Char, 3, ParameterDirection.Input);
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

        /// <summary>
        /// CRISTHIAN JOSE APAZA ARHUATA.
        /// BUSQUEDA POR NUEVOS FILTROS
        /// </summary>
        private ObservableCollection<Servicio> SelectAllByFiltros(Boolean AcceptNulls, String CONS_TabVia, String CONS_CodVia, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabLNG, String CONS_CodLNG, String SERV_TipoMov, Boolean SERV_AfeIgv, Boolean SERV_AfeDet)
        {
            try
            {
                ObservableCollection<Servicio> items = new ObservableCollection<Servicio>();

                //ObservableCollection<ServiciosDocumentos> itemsServiciosDocumentos = new ObservableCollection<ServiciosDocumentos>();

                Servicio item = new Servicio();

                //ServiciosDocumentos itemServiciosDocumentos = new ServiciosDocumentos();

                DataAccessEnterpriseSQL.DAAsignarProcedure("COM_SERVSS_Todos");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabLNG", CONS_TabLNG, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodLNG", CONS_CodLNG, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSERV_TipoMov", SERV_TipoMov, SqlDbType.Char, 1, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_AfeIgv", SERV_AfeIgv, SqlDbType.Bit, 1, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSERV_AfeDet", SERV_AfeDet, SqlDbType.Bit, 1, ParameterDirection.Input);


                using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Servicio();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                        //item.ServiciosDocumentos = GetAllServiciosDocumentosByServCodigo(item.SERV_Codigo);
                    }
                }
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }

        private System.Data.DataTable SelectAllDTByFilters(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
        {
            try
            {
                if (String.IsNullOrEmpty(x_procedure))
                { DataAccessEnterpriseSQL.DAAsignarProcedure("COM_SERVSS_Ayuda"); }
                else
                { DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }

                foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _filter in x_filters)
                { DataAccessEnterpriseSQL.DAAgregarParametro(_filter.FilterName, _filter.FilterValue, _filter.FilterSQLType, _filter.FilterSize, ParameterDirection.Input); }

                System.Data.DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                { return ds.Tables[0]; }
                else
                { return null; }

            }
            catch (Exception ex)
            { throw ex; }
        }
        private string VerificaServicioFlete(Servicio x_Item)
        {
            try
            {
                string l_Mensaje = null;
                DataAccessEnterpriseSQL.DAAsignarProcedure("COM_SERVSS_VerificaServicio");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", x_Item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSERV_Mensaje", l_Mensaje, SqlDbType.VarChar, 2024, ParameterDirection.InputOutput);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabVia", x_Item.CONS_TabVia, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodVia", x_Item.CONS_CodVia, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", x_Item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", x_Item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabLNG", x_Item.CONS_TabLNG, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodLNG", x_Item.CONS_CodLNG, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSERV_TipoMov", x_Item.SERV_TipoMov, SqlDbType.Char, 3, ParameterDirection.Input);

                DataAccessEnterpriseSQL.DAExecuteNonQuery();

                if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchSERV_Mensaje"].Value != DBNull.Value)
                { l_Mensaje = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pvchSERV_Mensaje"].Value.ToString(); }

                return l_Mensaje;
            }
            catch (Exception ex)
            { throw ex; }
        }

        private ObservableCollection<Servicio> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
        {
           try
           {
              ObservableCollection<Servicio> items = new ObservableCollection<Servicio>();
              Servicio item = new Servicio();
              if (!String.IsNullOrEmpty(x_procedure))
              { DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
              else
              { DataAccessEnterpriseSQL.DAAsignarProcedure("COM_SERVSS_TodosByFilters"); }
              if (x_filters != null && x_filters.Count > 0)
              {
                 foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
                 { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
              }
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
           catch (Exception)
           { throw; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}