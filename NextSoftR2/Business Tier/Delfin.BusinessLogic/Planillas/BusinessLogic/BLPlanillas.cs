using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Delfin.BusinessLogic;
using Delfin.Entities;
using Infrastructure.Aspect.DataAccess;
using Infrastructure.Aspect.Constants;

namespace Delfin.BusinessLogic
{
   public partial class BLPlanillas : IBLPlanillas
   {
      #region [ Propiedades ]

      [Dependency]
      public IBLMovimiento BL_Movimiento { get; set; }
      [Dependency]
      public IBLDetCtaCte BL_DetCtaCte { get; set; }

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
      public ObservableCollection<Planillas> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectAllByFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Planillas> GetAll()
      {
         try
         {
            return SelectAll();
         }
         catch (Exception)
         { throw; }
      }
      public Planillas GetOne(Int16 EMPR_Codigo, String PLAN_Tipo, String PLAN_Codigo)
      {
         try
         {
            if (EMPR_Codigo == null || PLAN_Tipo == null || PLAN_Codigo == null) { return null; }
            Entities.Planillas _planilla = SelectOne(EMPR_Codigo, PLAN_Tipo, PLAN_Codigo);
            if (_planilla != null)
            {
               ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> _listFilters = new ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL>();
               _listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@psinEMPR_Codigo", FilterValue = _planilla.EMPR_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int16, FilterSize = 2 });
               _listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pchrPLAN_Tipo", FilterValue = _planilla.PLAN_Tipo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Varchar, FilterSize = 3 });
               _listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pvchPLAN_Codigo", FilterValue = _planilla.PLAN_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Varchar, FilterSize = 20 });

               _planilla.ListMovimiento = BL_Movimiento.GetAllFilter("CAJ_MOVISS_EgresosPorPlanilla", _listFilters);
               _planilla.ListDetCtaCte = BL_DetCtaCte.GetAllFilter("CAJ_DCCTSS_TodosPorPlanilla", _listFilters);

               _planilla.Monto = _planilla.ListDetCtaCte.Sum(Det => Det.CCCT_Pendiente).Value;
               
            }
            return _planilla;
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Metodos ]
      public Boolean Save(ref Planillas Item)
      {
         try
         {
            String x_usuario = "";
            DataAccessEnterpriseSQL.DABeginTransaction();
            Boolean m_isCorrect = true;
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = Insert(ref Item);
                  x_usuario = Item.AUDI_UsrCrea;
                  foreach (Entities.DetCtaCte item in Item.ListDetCtaCte)
                  { item.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added; }
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = Update(ref Item);
                  x_usuario = Item.AUDI_UsrMod;
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = Delete(ref Item); break;
            }
            /*
             * Grabar Detalle de las planillas
             */
            foreach (Movimiento item in Item.ListMovimiento)
            {
               item.AUDI_UsrMod = x_usuario;
               item.PLAN_Codigo = Item.PLAN_Codigo;
               item.PLAN_Tipo = Item.PLAN_Tipo;

               String _tipo = "";
               switch (Item.PLAN_Tipo)
               {
                  case "DET":
                     _tipo = Item.PLAN_Tipo;
                     break;
                  case "WWW":
                     _tipo = "BAN";
                     break;
                  default:
                     _tipo = Item.PLAN_Tipo;
                     break;
               }

               item.MOVI_Referencia = String.Format("[Cod. Pla.:{2}-{0}] {1}", Item.PLAN_Codigo, Item.PLAN_Concepto, _tipo);
               Entities.Movimiento _item = item;
               m_isCorrect = BL_Movimiento.Save(ref _item, Movimiento.TInterfazMovimiento.RegistroPlanilla);
               item.MOVI_Codigo = _item.MOVI_Codigo;
            }
            /*
             * Grabar detalle de Cta Cte
             */
            foreach (DetCtaCte iDetCtaCte in Item.ListDetCtaCte)
            {

               switch (iDetCtaCte.Instance)
               {
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged:
                     break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                     iDetCtaCte.AUDI_UsrCrea = x_usuario;
                     break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                     iDetCtaCte.AUDI_UsrMod = x_usuario;
                     break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                     break;
                  default:
                     break;
               }
               #region Guardar el detalle de Transacciones

               iDetCtaCte.EMPR_Codigo = Item.EMPR_Codigo;
               iDetCtaCte.MOVI_Codigo = Item.ListMovimiento[0].MOVI_Codigo;
               iDetCtaCte.TIPO_TabMND = Item.ItemCuentasBancarias.TIPO_TabMND;
               iDetCtaCte.TIPO_CodMND = Item.ItemCuentasBancarias.TIPO_CodMND;
               //iDetCtaCte.CCCT_TipoCambio = Item.TipoCambio;
               iDetCtaCte.DCCT_TipoCambio = iDetCtaCte.CCCT_TipoCambio.Value; //Item.TipoCambio;
               iDetCtaCte.DCCT_FechaTrans = DateTime.Now;
               iDetCtaCte.DCCT_PagoDetraccion = (Item.TPlanilla == Planillas.TipoPlanilla.Detracciones);

               Decimal TipoCambio = iDetCtaCte.DCCT_TipoCambio;

               #region Movimiento de Egreso
               /*
                      * Realizar las operaciones correspondientes para un Egreso
                      */
               iDetCtaCte.DCCT_MontoHaber = 0;
               iDetCtaCte.DCCT_MontoHaberD = 0;
               iDetCtaCte.CONS_TabTDC = Infrastructure.Aspect.Constants.Util.GetTTipoMovimientoDetCtaCte();
               iDetCtaCte.CONS_CodTDC = Infrastructure.Aspect.Constants.Util.GetTTipoMovimientoDetCtaCte(Infrastructure.Aspect.Constants.TTipoMovimientoDetCtaCte.Pago);
               /*
                * Verificar la Moneda de la Cuenta Bancaria
                */
               if (Item.ItemCuentasBancarias.TIPO_CodMND.Equals(Infrastructure.Aspect.Constants.Util.getMoneda(TMoneda.Soles)))
               {
                  /*
                   * Si la Moneda de la cuenta bancaria es S/. (Nuevos Soles)
                   * - Vericar la moneda del documento para realizar la conversión para los campos correspondientes
                   */
                  if (iDetCtaCte.TIPO_CodMND.Equals(Util.getMoneda(TMoneda.Soles)))
                  {
                     iDetCtaCte.DCCT_PPago = 0;
                     iDetCtaCte.DCCT_MontoDebe = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                     iDetCtaCte.DCCT_PPagoD = 0;
                     iDetCtaCte.DCCT_MontoDebeD = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) / TipoCambio, 2, MidpointRounding.AwayFromZero);
                  }
                  else if (iDetCtaCte.TIPO_CodMND.Equals(Util.getMoneda(TMoneda.Dolares)))
                  {
                     iDetCtaCte.DCCT_PPago = 0;
                     iDetCtaCte.DCCT_MontoDebe = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) * TipoCambio, 2, MidpointRounding.AwayFromZero);
                     iDetCtaCte.DCCT_PPagoD = 0;
                     iDetCtaCte.DCCT_MontoDebeD = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                  }
               }
               else if (Item.ItemCuentasBancarias.TIPO_CodMND.Equals(Infrastructure.Aspect.Constants.Util.getMoneda(TMoneda.Dolares)))
               {
                  /*
                   * Si la Moneda de la cuenta Bancaria es en US$ (Dolares Americanos)
                   * - Vericar la moneda del documento para realizar la conversión para los campos correspondientes
                   */
                  if (iDetCtaCte.TIPO_CodMND.Equals(Util.getMoneda(TMoneda.Soles)))
                  {
                     iDetCtaCte.DCCT_PPago = 0;
                     iDetCtaCte.DCCT_MontoDebe = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                     if (iDetCtaCte.CCCT_Pendiente.HasValue)
                     {
                        iDetCtaCte.DCCT_PPagoD = 0;
                        iDetCtaCte.DCCT_MontoDebeD = Math.Round(iDetCtaCte.CCCT_Pendiente.Value / TipoCambio, 2, MidpointRounding.AwayFromZero);
                     }
                  }
                  else if (iDetCtaCte.TIPO_CodMND.Equals(Util.getMoneda(TMoneda.Dolares)))
                  {
                     iDetCtaCte.DCCT_PPago = 0;
                     iDetCtaCte.DCCT_MontoDebe = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) * TipoCambio, 2, MidpointRounding.AwayFromZero);
                     iDetCtaCte.DCCT_PPagoD = 0;
                     iDetCtaCte.DCCT_MontoDebeD = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                  }
               }
               #endregion

               /*
                * Realizar la Operación de Grabado en la Base de datosm según la Instancia de la Clase
                */
               Entities.DetCtaCte _idetctacte = iDetCtaCte;
               BL_DetCtaCte.Save(ref _idetctacte);
               #endregion
            }
            #region [ Generar Asientos de los Movimientos Generados ]
                        
            foreach (Movimiento iMovi in Item.ListMovimiento)
            {
               GAsientos genAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCaja);
               genAsientos.ItemMovimiento = iMovi;
               genAsientos.GenerarAsientoBD(Item.AUDI_UsrCrea);
            }

            #endregion

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
      public Boolean Save(ref ObservableCollection<Planillas> Items)
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
