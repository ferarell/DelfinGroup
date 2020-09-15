using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLDocsVta : IBLDocsVta
   {
      #region [ Propiedades ]
      #endregion

      #region [ Consultas ]
      public ObservableCollection<DocsVta> GetAllPorFiltrosLView(String x_DOCV_Numero, DateTime x_DOCV_FechaEmisionIni, DateTime x_DOCV_FechaEmisionFin, Int32? x_ENTC_Codigo, String x_Estado)
      {
         try
         {
            return SelectAllPorFiltrosLView(x_DOCV_Numero, x_DOCV_FechaEmisionIni, x_DOCV_FechaEmisionFin, x_ENTC_Codigo, x_Estado);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public DocsVta GetOne(Int32 DOCV_Codigo)
      {
         try
         {
            if (DOCV_Codigo == null) { return null; }
            return SelectOne(DOCV_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion

      #region [ Metodos ]
      public Boolean ModificarCliente(Int32 x_DOCV_Codigo, Int32 x_ENTC_Codigo, String x_AUDI_UsrMod, Int16 x_TIPE_Codigo)
      {
         try
         {
            Boolean m_isCorrect = true;
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
            m_isCorrect = UpdateCliente(x_DOCV_Codigo, x_ENTC_Codigo, x_AUDI_UsrMod, x_TIPE_Codigo);
            if (m_isCorrect)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }

      }
      public Boolean Save(ref DocsVta Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = Insert(ref Item); break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = UpdateCliente(Item.DOCV_Codigo, Item.ENTC_Codigo.Value, Item.AUDI_UsrMod, Item.TIPE_Codigo); break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = Delete(ref Item); break;
            }
            if (m_isCorrect)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
      public Boolean Save(ref ObservableCollection<DocsVta> Items)
      {
         try
         {
            Boolean m_isCorrect = true;
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
            for (int i = 0; i < Items.Count; i++)
            {
               var Item = Items.ElementAt(i);
               switch (Item.Instance)
               {
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                     m_isCorrect = Insert(ref Item); break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                     m_isCorrect = Update(ref Item); break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                     m_isCorrect = Delete(ref Item); break;
               }
               if (!m_isCorrect)
               { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return m_isCorrect; }
            }
            if (m_isCorrect)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
      #endregion
   }
}
