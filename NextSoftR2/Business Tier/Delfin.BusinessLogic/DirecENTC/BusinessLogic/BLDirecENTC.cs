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
   public partial class BLDirecENTC : IBLDirecENTC
   {
      #region [ Propiedades ]
      #endregion

      #region [ Consultas ]
      public ObservableCollection<DirecENTC> GetAll(Int32 x_ENTC_Codigo)
      {
         try
         {
            return SelectAll(x_ENTC_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public DirecENTC GetOne(Int32 ENTC_Codigo, Int16 DIRE_Codigo)
      {
         try
         {
            if (ENTC_Codigo == null || DIRE_Codigo == null) { return null; }
            return SelectOne(ENTC_Codigo, DIRE_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion

      #region [ Metodos ]
      public Boolean Save(ref DirecENTC Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            if (Item.Transaccion) { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction(); }
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = Insert(ref Item); break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = Update(ref Item); break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = Delete(ref Item); break;
            }
            if (m_isCorrect)
            { if (Item.Transaccion) { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); } }
            else
            { if (Item.Transaccion) { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); } }
            return m_isCorrect;
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
      public Boolean Save(ref ObservableCollection<DirecENTC> Items)
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
