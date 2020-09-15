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

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLEntidad_Relacionados
   {
      #region [ Consultas ]
      private ObservableCollection<Entidad_Relacionados> SelectAllDepositoTemporalByCliente(Int32 ENTC_Codigo)
      {
         try
         {
            ObservableCollection<Entidad_Relacionados> items = new ObservableCollection<Entidad_Relacionados>();
            Entidad_Relacionados item = new Entidad_Relacionados();
            DataAccessEnterpriseSQL.DAAsignarProcedure("RELASS_DTECliente");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Entidad_Relacionados();
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

      private ObservableCollection<Entidad_Relacionados> SelectAllEntidadRelacionadosByCliente(Nullable<Int32> ENTC_Codigo, String RELA_Tipos)
      {
         try
         {
            ObservableCollection<Entidad_Relacionados> items = new ObservableCollection<Entidad_Relacionados>();
            Entidad_Relacionados item = new Entidad_Relacionados();
            DataAccessEnterpriseSQL.DAAsignarProcedure("RELASS_Cliente");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodPadre", ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrRELA_Tipos", RELA_Tipos, SqlDbType.Char, 3, ParameterDirection.Input);

            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Entidad_Relacionados();
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

      private ObservableCollection<Entidad_Relacionados> SelectAllEntidadRelacionadosByRelaTipos(String RELA_Tipos)
      {
         try
         {
            ObservableCollection<Entidad_Relacionados> items = new ObservableCollection<Entidad_Relacionados>();
            Entidad_Relacionados item = new Entidad_Relacionados();
            DataAccessEnterpriseSQL.DAAsignarProcedure("RELASS_TodosPorRelaTipo");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrRELA_Tipos", RELA_Tipos, SqlDbType.Char, 3, ParameterDirection.Input);

            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Entidad_Relacionados();
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

      private ObservableCollection<Entidad_Relacionados> SelectAll(Int32 ENTC_Codigo)
      {
         try
         {
            ObservableCollection<Entidad_Relacionados> items = new ObservableCollection<Entidad_Relacionados>();
            Entidad_Relacionados item = new Entidad_Relacionados();
            DataAccessEnterpriseSQL.DAAsignarProcedure("RELASS_TodosPorEntidadPadre");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodPadre", ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Entidad_Relacionados();
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
      private bool UpdateDTE(ref Entidad_Relacionados Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("RELASU_DTECliente");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintRELA_Codigo", Item.RELA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodPadre", Item.ENTC_CodPadre, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_CodPadre", Item.TIPE_CodPadre, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodHijo", Item.ENTC_CodHijo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_CodHijo", Item.TIPE_CodHijo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabRGM", Item.CONS_TabRGM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodRGM", Item.CONS_CodRGM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@Agregar", Item.Agregar, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitRELA_DepTemNegociaAgente", Item.RELA_DepTemNegociaAgente, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

               //if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               //{ return true; }
               //else
               //{ return false; }

               DataAccessEnterpriseSQL.DAExecuteNonQuery();
               return true;
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
