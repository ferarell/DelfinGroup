using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessEntity;
using Infrastructure.Aspect.DataAccess;
using Microsoft.Practices.Unity;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLTransferencia : IBLTransferencia
   {
      #region [ Propiedades ]

      [Dependency]
      public IBLMovimiento BL_Movimiento { get; set; }
      [Dependency]
      public IBLGastosBancarios BL_GastosBancarios { get; set; }

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
      public ObservableCollection<Transferencia> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectAllByFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Transferencia> GetAll()
      {
         try
         {
            return SelectAll();
         }
         catch (Exception)
         { throw; }
      }
      public Transferencia GetOne(Int16 EMPR_Codigo, Int32 TRAN_Codigo)
      {
         try
         {
            if (EMPR_Codigo == null || TRAN_Codigo == null) { return null; }
            Transferencia _transferencia = SelectOne(EMPR_Codigo, TRAN_Codigo);
            if (_transferencia != null)
            {
               /*
                * Cargar los detalles
                */
               ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> listFilters = new ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL>();
               listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@psinEMPR_Codigo", FilterValue = EMPR_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int16, FilterSize = 2 });
               listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pintTRAN_Codigo", FilterValue = TRAN_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int32, FilterSize = 4 });
               _transferencia.ListEgresos = BL_Movimiento.GetAllFilter("CAJ_MOVISS_EgresosPorTransferencia", listFilters);
               _transferencia.ListIngresos = BL_Movimiento.GetAllFilter("CAJ_MOVISS_IngresosPorTransferencia", listFilters);
               _transferencia.ListGastosBancarios = BL_GastosBancarios.GetAllFilter("CAJ_GBANSS_TodosPorTransferencia", listFilters);

            }
            return _transferencia;
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Metodos ]
      public Boolean Save(ref Transferencia Item)
      {
         try
         {
            DataAccessEnterpriseSQL.DABeginTransaction();
            Boolean m_isCorrect = true;
            String x_Usuario = "";
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  x_Usuario = Item.AUDI_UsrCrea;
                  m_isCorrect = Insert(ref Item);
                  foreach (Movimiento iMov in Item.ListIngresos)
                  { iMov.Instance = InstanceEntity.Added; iMov.AUDI_UsrCrea = x_Usuario; }
                  foreach (Movimiento iMov in Item.ListEgresos)
                  { iMov.Instance = InstanceEntity.Added; iMov.AUDI_UsrCrea = x_Usuario; }
                  foreach (GastosBancarios iGas in Item.ListGastosBancarios)
                  { iGas.Instance = InstanceEntity.Added; iGas.AUDI_UsrCrea = x_Usuario; }
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  x_Usuario = Item.AUDI_UsrMod;
                  m_isCorrect = Update(ref Item);
                  break;
                // case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                // m_isCorrect = Delete(ref Item);
                //break;
            }
            /*
             * Grabar Detalles
             */
            /*
             * Movimientos de Ingresos
             */
            foreach (Movimiento iMov in Item.ListIngresosEliminados)
            {
               Movimiento _mov = iMov;
               _mov.TRAN_Codigo = Item.TRAN_Codigo;
               _mov.EMPR_Codigo = Item.EMPR_Codigo;
               _mov.AUDI_UsrMod = x_Usuario;
               _mov.Instance = InstanceEntity.Deleted;
               BL_Movimiento.Save(ref _mov, Movimiento.TInterfazMovimiento.Transferencia);
            }
            foreach (Movimiento iMov in Item.ListIngresos)
            {
               Movimiento _mov = iMov;
               _mov.TRAN_Codigo = Item.TRAN_Codigo;
               _mov.EMPR_Codigo = Item.EMPR_Codigo;
               _mov.AUDI_UsrMod = x_Usuario;
               m_isCorrect = BL_Movimiento.Save(ref _mov, Movimiento.TInterfazMovimiento.Transferencia);
            }
            /*
             * Moviemientos de Egresos
             */
            foreach (Movimiento iMov in Item.ListEgresosEliminados)
            {
               Movimiento _mov = iMov;
               _mov.TRAN_Codigo = Item.TRAN_Codigo;
               _mov.EMPR_Codigo = Item.EMPR_Codigo;
               _mov.AUDI_UsrMod = x_Usuario;
               _mov.Instance = InstanceEntity.Deleted;
               BL_Movimiento.Save(ref _mov, Movimiento.TInterfazMovimiento.Transferencia);
            }
            foreach (Movimiento iMov in Item.ListEgresos)
            {
               Movimiento _mov = iMov;
               _mov.TRAN_Codigo = Item.TRAN_Codigo;
               _mov.EMPR_Codigo = Item.EMPR_Codigo;
               _mov.AUDI_UsrMod = x_Usuario;
               m_isCorrect = BL_Movimiento.Save(ref _mov, Movimiento.TInterfazMovimiento.Transferencia);
            }
            /*
             * Gastos Bancarios
             */
            foreach (GastosBancarios iGBan in Item.ListGastosBancariosEliminados)
            {
               GastosBancarios _gban = iGBan;
               _gban.Instance = InstanceEntity.Deleted;
               BL_GastosBancarios.Save(ref _gban);
            }
            foreach (GastosBancarios iGBan in Item.ListGastosBancarios)
            {
               GastosBancarios _gban = iGBan;
               _gban.TRAN_Codigo = Item.TRAN_Codigo;
               _gban.EMPR_Codigo = Item.EMPR_Codigo;
               switch (_gban.Instance)
               {
                  case InstanceEntity.Added:
                     _gban.AUDI_UsrCrea = x_Usuario;
                     break;
                  case InstanceEntity.Modified:
                     _gban.AUDI_UsrMod = x_Usuario;
                     break;
               }
               m_isCorrect = BL_GastosBancarios.Save(ref _gban);
            }

            if(m_isCorrect)
            {
               GAsientos genAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoTransferencia);
               genAsientos.ItemTransferencia = Item;
               genAsientos.GenerarAsientoBD(x_Usuario);
            }
               
            /*
             * Termninar la transacción
             */
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
      public Boolean Save(ref ObservableCollection<Transferencia> Items)
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
