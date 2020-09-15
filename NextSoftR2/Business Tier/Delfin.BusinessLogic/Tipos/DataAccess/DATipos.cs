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
   public partial class BLTipos
   {
      #region [ Propiedades ]
      public IUnityContainer ContainerService { get; set; }
      public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Tipos> Loader { get; set; }
      #endregion

      #region [ Constructores ]
      public BLTipos(IUnityContainer container)
      {
         this.ContainerService = container;
         Loader = new BusinessEntityLoader<Tipos>();
         Tipos item = new Tipos();
         Loader.EntityType = item.GetType();
      }
      #endregion

      #region [ Consultas ]
      private ObservableCollection<Tipos> SelectAll()
      {
         try
         {
            ObservableCollection<Tipos> items = new ObservableCollection<Tipos>();
            Tipos item = new Tipos();
            DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_Tipos");
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Tipos();
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
      private Tipos SelectOne(String TIPO_CodTabla, String TIPO_CodTipo)
      {
         try
         {
            Tipos item = new Tipos();
            DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_Tipos");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTabla", TIPO_CodTabla, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTipo", TIPO_CodTipo, SqlDbType.Char, 3, ParameterDirection.Input);
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
      private System.Data.DataTable SelectAllByFilterDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            DataSet _ds = new DataSet();
            if (!String.IsNullOrEmpty(x_procedure))
            { DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
            else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("TIPOSS_TodosByFilters"); }
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }
            _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_ds != null && _ds.Tables.Count == 1)
            { _ds.Tables[0].TableName = "Tipos"; return _ds.Tables[0]; }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }
      private System.Data.DataSet SelectAllByFilterDS(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            DataSet _ds = new DataSet();
            if (!String.IsNullOrEmpty(x_procedure))
            { DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
            else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("TIPOSS_TodosByFilters"); }
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }
            _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_ds != null && _ds.Tables.Count > 0)
            { _ds.Tables[0].TableName = "Tipos"; return _ds; }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Metodos ]
      private bool Insert(ref Tipos item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_INSERTAR_Tipos");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTabla", item.TIPO_CodTabla, SqlDbType.Char, 3, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTipo", item.TIPO_CodTipo, SqlDbType.Char, 3, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTablaHijo", item.TIPO_CodTablaHijo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTipoHijo", item.TIPO_CodTipoHijo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTIPO_Desc1", item.TIPO_Desc1, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTIPO_Desc2", item.TIPO_Desc2, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTIPO_DescC", item.TIPO_DescC, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecTIPO_Num1", item.TIPO_Num1, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecTIPO_Num2", item.TIPO_Num2, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPO_Num3", item.TIPO_Num3, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPO_Num4", item.TIPO_Num4, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitTIPO_Activo", item.TIPO_Activo, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTIPO_Mascara", item.TIPO_Mascara, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTIPO_Desc3", item.TIPO_Desc3, SqlDbType.VarChar, 100, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               {
                  //String _TIPO_CodTabla;
                  //if (String.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrTIPO_CodTabla"].Value.ToString(), out _TIPO_CodTabla))
                  //{ item.TIPO_CodTabla = _TIPO_CodTabla; }
                  //String _TIPO_CodTipo;
                  //if (String.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pchrTIPO_CodTipo"].Value.ToString(), out _TIPO_CodTipo))
                  //{ item.TIPO_CodTipo = _TIPO_CodTipo; }
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
      private bool Update(ref Tipos item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_ACTUALIZAR_Tipos");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTabla", item.TIPO_CodTabla, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTipo", item.TIPO_CodTipo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTablaHijo", item.TIPO_CodTablaHijo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTipoHijo", item.TIPO_CodTipoHijo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTIPO_Desc1", item.TIPO_Desc1, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTIPO_Desc2", item.TIPO_Desc2, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTIPO_DescC", item.TIPO_DescC, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecTIPO_Num1", item.TIPO_Num1, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecTIPO_Num2", item.TIPO_Num2, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPO_Num3", item.TIPO_Num3, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPO_Num4", item.TIPO_Num4, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitTIPO_Activo", item.TIPO_Activo, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTIPO_Mascara", item.TIPO_Mascara, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTIPO_Desc3", item.TIPO_Desc3, SqlDbType.VarChar, 100, ParameterDirection.Input);

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
      private bool Delete(ref Tipos item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_ELIMINAR_Tipos");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTabla", item.TIPO_CodTabla, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTipo", item.TIPO_CodTipo, SqlDbType.Char, 3, ParameterDirection.Input);

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
