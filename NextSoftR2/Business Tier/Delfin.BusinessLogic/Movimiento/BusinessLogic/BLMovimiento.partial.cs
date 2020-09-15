using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Delfin.BusinessLogic;
using Delfin.Entities;
using Infrastructure.Aspect.BusinessEntity;
using Infrastructure.Aspect.DataAccess;

namespace Delfin.BusinessLogic
{
   public partial class BLMovimiento
   {
      #region [ Consultas ]

      public Movimiento GetOne(Int16 EMPR_Codigo, Int32 MOVI_Codigo, Entities.Movimiento.TInterfazMovimiento x_opcion)
      {
         try
         {
            if (EMPR_Codigo == null || MOVI_Codigo == null) { return null; }
            switch (x_opcion)
            {
               case Movimiento.TInterfazMovimiento.ChequeEnBlanco:
                  return SelectOne(EMPR_Codigo, MOVI_Codigo);

            }
            return null;
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]

      public Boolean Save(ref Movimiento Item, Entities.Movimiento.TInterfazMovimiento x_opcion)
      {
         try
         {
            Boolean m_isCorrect = true;

            switch (x_opcion)
            {
               case Movimiento.TInterfazMovimiento.ChequeEnBlanco:
                  m_isCorrect = SaveChequeEnBlanco(ref Item);
                  break;
               case Movimiento.TInterfazMovimiento.Transferencia:
                  m_isCorrect = SaveTransferencia(ref Item);
                  break;
               case Movimiento.TInterfazMovimiento.EjecutarDiferido:
                  m_isCorrect = SaveDiferido(ref Item);
                  break;
               case Movimiento.TInterfazMovimiento.RegistroPlanilla:
                  m_isCorrect = SavePlanilla(ref Item);
                  break;
               case Movimiento.TInterfazMovimiento.RediferirMovimiento:
                  m_isCorrect = SaveRediferirMovimiento(ref Item);
                  break;
               case Movimiento.TInterfazMovimiento.Anular:
                  m_isCorrect = SaveAnular(ref Item);
                  break;
               case Movimiento.TInterfazMovimiento.Extornar:
                  m_isCorrect = SaveExtornar(ref Item);
                  break;
            }

            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

      public Boolean Save(ref ObservableCollection<Movimiento> Items, Movimiento.TInterfazMovimientos x_opcion)
      {
         try
         {
            Boolean m_isCorrect = true;
            switch (x_opcion)
            {
               case Movimiento.TInterfazMovimientos.Conciliacion:
                  m_isCorrect = SaveConciliacion(ref Items);
                  break;
               default:
                  break;
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

      public Boolean SaveAnular(ref Movimiento Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            DataAccessEnterpriseSQL.DABeginTransaction();
            Item.SetEstado(Movimiento.Estado.Anulado);
            m_isCorrect = UpdateAnular(ref Item);
            if (Item != null && m_isCorrect)
            {
               ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> listFilters = new ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL>();
               listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@psinEMPR_Codigo", FilterValue = Item.EMPR_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int16, FilterSize = 2 });
               listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pintMOVI_Codigo", FilterValue = Item.MOVI_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int32, FilterSize = 4 });
               Item.ListDetCtaCte = BL_DetCtaCte.GetAllFilter("CAJ_DCCTSS_TodosPorMovimiento", listFilters);
               Item.TIPO_Movimiento = BL_Tipos.GetOne(Item.TIPO_TabMOV, Item.TIPO_CodMOV);

               foreach (DetCtaCte iDetCtaCte in Item.ListDetCtaCte)
               {
                  if (iDetCtaCte.DCCT_MontoDebe < iDetCtaCte.DCCT_MontoHaber)
                  {
                     iDetCtaCte.DCCT_MontoDebe = iDetCtaCte.DCCT_MontoHaber;
                     iDetCtaCte.DCCT_MontoHaber = 0;
                     iDetCtaCte.DCCT_MontoDebeD = iDetCtaCte.DCCT_MontoHaberD;
                     iDetCtaCte.DCCT_MontoHaberD = 0;
                  }
                  else if (iDetCtaCte.DCCT_MontoDebe > iDetCtaCte.DCCT_MontoHaber)
                  {
                     iDetCtaCte.DCCT_MontoHaber = iDetCtaCte.DCCT_MontoDebe;
                     iDetCtaCte.DCCT_MontoDebe = 0;
                     iDetCtaCte.DCCT_MontoHaberD = iDetCtaCte.DCCT_MontoDebeD;
                     iDetCtaCte.DCCT_MontoDebeD = 0;
                  }
                  iDetCtaCte.Instance = InstanceEntity.Added;
                  iDetCtaCte.AUDI_UsrCrea = Item.AUDI_UsrMod;
                  iDetCtaCte.CONS_TabTDC = Infrastructure.Aspect.Constants.Util.GetTTipoMovimientoDetCtaCte();
                  iDetCtaCte.CONS_CodTDC = Infrastructure.Aspect.Constants.Util.GetTTipoMovimientoDetCtaCte(Infrastructure.Aspect.Constants.TTipoMovimientoDetCtaCte.Extorno);

                  Entities.DetCtaCte _detCtaCte = iDetCtaCte;
                  BL_DetCtaCte.Save(ref _detCtaCte);
               }

               GAsientos genAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCaja);
               genAsientos.ItemMovimiento = Item;
               genAsientos.Anular(Item.AUDI_UsrMod, GAsientos.TipoItem.Movimiento);
            }
            if (m_isCorrect)
            { DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         {
            DataAccessEnterpriseSQL.DARollbackTransaction();
            throw;
         }
      }

      public Boolean SaveExtornar(ref Movimiento Item)
      {
         try
         {
            Boolean m_isCorrect = true;

            DataAccessEnterpriseSQL.DABeginTransaction();

            Item.MOVI_CodPadre = Item.MOVI_Codigo;
            Item.SetEstado(Movimiento.Estado.Ingresado);

            Item.Instance = InstanceEntity.Added;
            m_isCorrect = Insert(ref Item);

            if (Item != null && m_isCorrect)
            {
               ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> listFilters = new ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL>();
               listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@psinEMPR_Codigo", FilterValue = Item.EMPR_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int16, FilterSize = 2 });
               listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pintMOVI_Codigo", FilterValue = Item.MOVI_CodPadre, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int32, FilterSize = 4 });
               Item.ListDetCtaCte = BL_DetCtaCte.GetAllFilter("CAJ_DCCTSS_TodosPorMovimiento", listFilters);
               //Item.TIPO_Movimiento = BL_Tipos.GetOne(Item.TIPO_TabMOV, Item.TIPO_CodMOV);

               foreach (DetCtaCte iDetCtaCte in Item.ListDetCtaCte)
               {
                  if (iDetCtaCte.DCCT_MontoDebe > iDetCtaCte.DCCT_MontoHaber)
                  {
                     iDetCtaCte.DCCT_MontoHaber = iDetCtaCte.DCCT_MontoDebe;
                     iDetCtaCte.DCCT_MontoDebe = 0;
                     iDetCtaCte.DCCT_MontoHaberD = iDetCtaCte.DCCT_MontoDebeD;
                     iDetCtaCte.DCCT_MontoDebeD = 0;
                  }
                  else if (iDetCtaCte.DCCT_MontoDebe < iDetCtaCte.DCCT_MontoHaber)
                  {
                     iDetCtaCte.DCCT_MontoDebe = iDetCtaCte.DCCT_MontoHaber;
                     iDetCtaCte.DCCT_MontoHaber = 0;
                     iDetCtaCte.DCCT_MontoDebeD = iDetCtaCte.DCCT_MontoHaberD;
                     iDetCtaCte.DCCT_MontoHaberD = 0;
                  }

                  //iDetCtaCte.MOVI_Codigo = Item.MOVI_Codigo;
                  //if (Item.TIPO_Movimiento.TIPO_Desc2.Equals("I"))
                  //{
                  //   iDetCtaCte.DCCT_MontoDebe = iDetCtaCte.DCCT_MontoHaber;
                  //   iDetCtaCte.DCCT_MontoHaber = 0;
                  //}
                  //else if (Item.TIPO_Movimiento.TIPO_Desc2.Equals("E"))
                  //{
                  //   iDetCtaCte.DCCT_MontoHaber = iDetCtaCte.DCCT_MontoDebe;
                  //   iDetCtaCte.DCCT_MontoDebe = 0;
                  //}
                  iDetCtaCte.Instance = InstanceEntity.Added;
                  iDetCtaCte.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                  iDetCtaCte.CONS_TabTDC = Infrastructure.Aspect.Constants.Util.GetTTipoMovimientoDetCtaCte();
                  iDetCtaCte.CONS_CodTDC = Infrastructure.Aspect.Constants.Util.GetTTipoMovimientoDetCtaCte(Infrastructure.Aspect.Constants.TTipoMovimientoDetCtaCte.Extorno);
                  //iDetCtaCte.DCCT_TipoPago = 
                  Entities.DetCtaCte _detCtaCte = iDetCtaCte;
                  BL_DetCtaCte.Save(ref _detCtaCte);
               }
            }
            if (m_isCorrect)
            {
               DataAccessEnterpriseSQL.DACommitTransaction();
            }
            else
            {
               DataAccessEnterpriseSQL.DARollbackTransaction();
            }
            return m_isCorrect;
         }
         catch (Exception)
         {
            DataAccessEnterpriseSQL.DARollbackTransaction();
            throw;
         }
      }

      public Boolean SaveChequeEnBlanco(ref Movimiento Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = Insert(ref Item);
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = UpdateChequeBlanco(ref Item);
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = DeleteChequeBlanco(ref Item); break;
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

      public Boolean SaveTransferencia(ref Movimiento Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = Insert(ref Item);
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = UpdateTransferencia(ref Item);
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = Delete(ref Item);
                  break;
            }

            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

      public Boolean SaveDiferido(ref Movimiento Item)
      {
         try
         {
            DataAccessEnterpriseSQL.DABeginTransaction();
            Boolean m_isCorrect = true;
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = UpdateEjecutarDiferido(ref Item);
                  break;
            }

            #region [ Generar el asiento de Diferido ]

            GAsientos genAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCajaDiferido);
            genAsientos.ItemMovimiento = Item;
            genAsientos.GenerarAsientoBD(Item.AUDI_UsrMod);

            #endregion

            if (m_isCorrect) { DataAccessEnterpriseSQL.DACommitTransaction(); }
            else { DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }

      public Boolean SavePlanilla(ref Movimiento Item)
      {
         try
         {

            Boolean m_isCorrect = true;
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = Insert(ref Item);
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = UpdatePlanilla(ref Item);
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = Delete(ref Item);
                  break;
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

      public Boolean SaveRediferirMovimiento(ref Movimiento Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = UpdateRediferirMovimiento(ref Item);
                  break;
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

      public Boolean SaveConciliacion(ref ObservableCollection<Movimiento> Items)
      {
         try
         {
            DataAccessEnterpriseSQL.DABeginTransaction();
            Boolean m_isCorrect = true;
            for (int i = 0; i < Items.Count; i++)
            {
               Movimiento Item = Items.ElementAt(i);
               //m_isCorrect = UpdateConciliacion(ref Item);
               if (Item.Seleccionar)
               {
                  if (Item.ItemConciliacion.CONC_Codigo == null)
                  {
                     Item.ItemConciliacion.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                     Item.ItemConciliacion.Instance = InstanceEntity.Added;
                  }
                  else
                  {
                     Item.ItemConciliacion.AUDI_UsrMod = Item.AUDI_UsrCrea;
                     Item.ItemConciliacion.Instance = InstanceEntity.Modified;
                  }
               }
               else { Item.ItemConciliacion.Instance = InstanceEntity.Deleted; }

               Entities.Conciliacion _conciliacion = Item.ItemConciliacion;

               m_isCorrect = BL_Conciliacion.Save(ref _conciliacion);

               if (!m_isCorrect) { throw new Exception(String.Format("No se completo la operación , el registro con rno. operación {0} tiene errores", Item.MOVI_NroOperacion)); }
            }
            if (m_isCorrect) { DataAccessEnterpriseSQL.DACommitTransaction(); }
            else { DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         {
            DataAccessEnterpriseSQL.DARollbackTransaction();
            throw;
         }
      }

      #endregion
   }
}
