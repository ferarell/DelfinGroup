using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Delfin.BusinessLogic;
using Delfin.Entities;
using Infrastructure.Aspect.Collections;
using Infrastructure.Aspect.DataAccess;

namespace Delfin.BusinessLogic
{
   public partial class BLLiquidacion : IBLLiquidacion
   {
      #region [ Propiedades ]

      [Dependency]
      public IBLCtaCte BL_CtaCte { get; set; }
      [Dependency]
      public IBLLiqCtaCte BL_LiqCtaCte { get; set; }

      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectAllByFilterDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Liquidacion> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectAllByFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Liquidacion> GetAll()
      {
         try
         {
            return SelectAll();
         }
         catch (Exception)
         { throw; }
      }
      public Liquidacion GetOne(Int16 EMPR_Codigo, String LIQU_Codigo)
      {
         try
         {
            if (EMPR_Codigo == null || LIQU_Codigo == null) { return null; }
            return SelectOne(EMPR_Codigo, LIQU_Codigo);
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Metodos ]
      public Boolean Save(ref Liquidacion Item)
      {
         try
         {
            DataAccessEnterpriseSQL.DABeginTransaction();
            Boolean m_isCorrect = true;
            String x_usuario = "";
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = Insert(ref Item);
                  x_usuario = Item.AUDI_UsrCrea;
                  foreach (Entities.CtaCte iCtaCte in Item.ListCtaCte.Where(CCCT => CCCT.Seleccionar).ToObservableCollection())
                  {
                     iCtaCte.ItemLiqCtaCte = new LiqCtaCte();
                     iCtaCte.ItemLiqCtaCte.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added;
                  }
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = Update(ref Item);
                  x_usuario = Item.AUDI_UsrMod;
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = Delete(ref Item);
                  break;
               default:
                  x_usuario = String.IsNullOrEmpty(Item.AUDI_UsrMod) ? Item.AUDI_UsrCrea : Item.AUDI_UsrMod;
                  break;
            }
            /*
             * Grabar detalles
             */
            Item.ListCtaCteEliminados = Item.ListCtaCte.Where(Cta => !Cta.Seleccionar && Cta.LCCC_Item != null).ToObservableCollection();
            if (Item.ListCtaCteEliminados != null && Item.ListCtaCteEliminados.Count > 0)
            {
               foreach (Entities.CtaCte iCtaCte in Item.ListCtaCteEliminados)
               {
                  Entities.LiqCtaCte _item = new LiqCtaCte();
                  _item.CCCT_Codigo = iCtaCte.CCCT_Codigo;
                  _item.LIQU_Codigo = Item.LIQU_Codigo;
                  _item.EMPR_Codigo = Item.EMPR_Codigo;
                  _item.LCCC_Item = iCtaCte.LCCC_Item;
                  _item.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted;
                  m_isCorrect = BL_LiqCtaCte.Save(ref _item);
               }
            }
            if (Item.ListCtaCte != null && Item.ListCtaCte.Count > 0)
            {
               foreach (Entities.CtaCte iCtaCte in Item.ListCtaCte.Where(CCCT => CCCT.Seleccionar).ToObservableCollection())
               {
                  iCtaCte.ItemLiqCtaCte.CCCT_Codigo = iCtaCte.CCCT_Codigo;
                  iCtaCte.ItemLiqCtaCte.LIQU_Codigo = Item.LIQU_Codigo;
                  iCtaCte.ItemLiqCtaCte.EMPR_Codigo = Item.EMPR_Codigo;
                  if (iCtaCte.ItemLiqCtaCte.LCCC_Item == null) { iCtaCte.ItemLiqCtaCte.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added; }
                  switch (iCtaCte.ItemLiqCtaCte.Instance)
                  {
                     case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                        iCtaCte.ItemLiqCtaCte.AUDI_UsrCrea = x_usuario;
                        break;
                     case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                        iCtaCte.ItemLiqCtaCte.AUDI_UsrMod = x_usuario;
                        break;
                  }
                  Entities.LiqCtaCte _item = iCtaCte.ItemLiqCtaCte;
                  m_isCorrect = BL_LiqCtaCte.Save(ref _item);
               }
            }
            if (m_isCorrect)
            { DataAccessEnterpriseSQL.DACommitTransaction(); }
            else { DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         {
            DataAccessEnterpriseSQL.DARollbackTransaction();
            throw;
         }
      }
      public Boolean Save(ref ObservableCollection<Liquidacion> Items)
      {
         try
         {
            Boolean m_isCorrect = true;
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
               { return m_isCorrect; }
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
