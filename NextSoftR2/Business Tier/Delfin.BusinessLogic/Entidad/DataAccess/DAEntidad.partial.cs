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
   public partial class BLEntidad
   {
      #region [ Consultas ]

      //private ObservableCollection<Entidad> SelectAllByNomCompleto(String ENTC_NomCompleto)
      //{
      //   try
      //   {
      //      ObservableCollection<Entidad> items = new ObservableCollection<Entidad>();
      //      Entidad item = new Entidad();
      //      DataAccessEnterprise.DAAsignarProcedure("T_SP_CONSULTAR_Entidad");
      //      DataAccessEnterprise.DAAgregarParametro("@pvchENTC_NomCompleto", ENTC_NomCompleto, SqlDbType.VarChar, 100, ParameterDirection.Input);
      //      using (IDataReader reader = DataAccessEnterprise.DAExecuteReader())
      //      {
      //         while (reader.Read())
      //         {
      //            item = new Entidad();
      //            Loader.LoadEntity(reader, item);
      //            item.Instance = InstanceEntity.Unchanged;
      //            items.Add(item);
      //         }
      //      }
      //      return items;
      //   }
      //   catch (Exception ex)
      //   { throw ex; }
      //}
      private DataTable SelectTodosEntidadByTIPE_Codigo(Nullable<Int16> x_TIPE_Codigo)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("[T_SP_CONSULTAR_EntidadPorTipoEntidad]");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psmallintTIPE_Codigo", x_TIPE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
            {
               return _dt.Tables[0];
            }
            else
            {
               return null;
            }
         }
         catch (Exception ex)
         { throw ex; }
      }

      private ObservableCollection<Entidad> SelectAllByTipoEntidadAndText(Int16 TIPE_CODIGO, string Text, Boolean Activo, String ENTC_DOCIDEN)
      {
         try
         {
            ObservableCollection<Entidad> items = new ObservableCollection<Entidad>();
            Entidad item = new Entidad();
            DataAccessEnterpriseSQL.DAAsignarProcedure("ENTCSS_ByTipoEntidadAndText");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", TIPE_CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_NomCompleto", Text, SqlDbType.VarChar, 150, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_Activo", Activo, SqlDbType.Bit, 1, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_DocIden", ENTC_DOCIDEN, SqlDbType.VarChar, 4, ParameterDirection.Input);

            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Entidad();
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

      /// <summary>
      /// Clientes por nave viaje 
      /// Cristhian Jose Apaza Arhuata
      /// </summary>
      /// <returns></returns>
      private ObservableCollection<Entidad> SelectAllEntidadByNVIA_Codigo(Int32 NVIA_codigo, Int32 TIPO_correo)
      {
         try
         {
            ObservableCollection<Entidad> items = new ObservableCollection<Entidad>();
            Entidad item = new Entidad();
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_entidades");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", NVIA_codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintTIPO_Correo", TIPO_correo, SqlDbType.Int, 4, ParameterDirection.Input);

            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Entidad();
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

      private ObservableCollection<Entidad> SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            ObservableCollection<Entidad> items = new ObservableCollection<Entidad>();
            Entidad item = new Entidad();
            if (!String.IsNullOrEmpty(x_procedure))
            { DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
            else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("ENTCSS_TodosByFilters"); }
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Entidad();
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

      /// <summary>
      /// Procedimiento para obtener el limite de credito que tiene la entidad
      /// </summary>
      /// <param name="EMPR_Codigo">Código de empresa</param>
      /// <param name="ENTC_Codigo">Código de entidad</param>
      /// <param name="Monto">Monto del credito</param>
      /// <param name="DiasDuracion">Dias de duración del credito</param>
      /// <returns></returns>
      private Boolean SelectLimiteCredito(Int16 EMPR_Codigo, Int32 ENTC_Codigo, ref Decimal Monto, ref Int16 DiasDuracion)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("ENTCSS_ObtenerLimiteCredito");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@Monto", Monto, SqlDbType.Decimal, 15, 2, ParameterDirection.InputOutput);
            DataAccessEnterpriseSQL.DAAgregarParametro("@DiasDuracion", DiasDuracion, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
            //DataAccessEnterpriseSQL.DAAgregarParametro("@DiasDuracion", DiasDuracion, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
            DataAccessEnterpriseSQL.DAExecuteNonQuery();

            Decimal _Monto;
            if (Decimal.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@Monto"].Value.ToString(), out _Monto))
            { Monto = _Monto; }
            Int16 _DiasDuracion;
            if (Int16.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@DiasDuracion"].Value.ToString(), out _DiasDuracion))
            { DiasDuracion = _DiasDuracion; }
            return Monto > 0;
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]

      private Entidad ValidarDocIden(Int32 ENTC_Codigo, String TIPO_TabTDI, String TIPO_CodTDI, String ENTC_DocIden)
      {
         try
         {
            ObservableCollection<Entidad> items = new ObservableCollection<Entidad>();
            Entidad item = new Entidad();
            DataAccessEnterpriseSQL.DAAsignarProcedure("ENTCSS_ValdiarDocIden");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTDI", TIPO_TabTDI, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDI", TIPO_CodTDI, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_DocIden", ENTC_DocIden, SqlDbType.VarChar, 25, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               if (reader.Read())
               {
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
                  return item;
               }
            }
            return null;
         }
         catch (Exception ex)
         { throw ex; }
      }
      private Entidad SelectOnePorRuc(String x_ENTC_DocIden, Nullable<Int16> x_TIPE_Codigo)
      {
         try
         {
            Entidad item = new Entidad();
            DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_EntidadPorRuc");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_DocIden", x_ENTC_DocIden, SqlDbType.VarChar, 25, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psmlTIPE_Codigo", x_TIPE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               if (reader.Read())
               {
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
   }
}
