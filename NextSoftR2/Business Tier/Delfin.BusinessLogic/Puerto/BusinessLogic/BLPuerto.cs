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
   public partial class BLPuerto : IBLPuerto
   {
      #region [ Propiedades ]
      #endregion

      #region [ Consultas ]
      
      public String UsuarioPuertos { get; set; }

      private ObservableCollection<Puerto> CargarTablaXML()
      {
         try
         {
            Infrastructure.Aspect.CheckSUM.GenerarChekSum x_CargarTabla = new Infrastructure.Aspect.CheckSUM.GenerarChekSum(Infrastructure.Aspect.CheckSUM.GenerarChekSum.PathAppPublic, UsuarioPuertos);
            System.Data.DataTable dtTabla = x_CargarTabla.CargarXML(new Infrastructure.Aspect.CheckSUM.CHKS_Tablas() { CHKS_Tabla = "COM_Puerto" });
            ObservableCollection<Puerto> ListPuerto = new ObservableCollection<Puerto>();

            if (dtTabla != null)
            {
               ListPuerto = new ObservableCollection<Entities.Puerto>();
               foreach (System.Data.DataRow iRow in dtTabla.Rows)
               {
                  Entities.Puerto _tipos = new Entities.Puerto();
                  Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Entities.Puerto> Loader = new Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Entities.Puerto>();
                  Loader.LoadEntity(iRow, _tipos);
                  ListPuerto.Add(_tipos);
               }
            }
            else
            {
               return SelectAll();
            }
            return ListPuerto;
         }
         catch (Exception)
         { throw; }
      }

      public ObservableCollection<Puerto> GetAll()
      {
         try
         {
            return CargarTablaXML();
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Puerto GetOne(Int32 PUER_Codigo)
      {
         try
         {
            if (PUER_Codigo == null) { return null; }
            return SelectOne(PUER_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion

      #region [ Metodos ]
      public Boolean Save(ref Puerto Item)
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
                  m_isCorrect = Update(ref Item); break;
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
      public Boolean Save(ref ObservableCollection<Puerto> Items)
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
