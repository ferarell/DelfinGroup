using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.Constants;
using Microsoft.Practices.Unity;
using Delfin.BusinessLogic;
using Delfin.Entities;

using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Infrastructure.Aspect.DataAccess;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.BusinessLogic
{
   public partial class BLMovimiento : IBLMovimiento
   {
      #region [ Propiedades ]

      [Dependency]
      public IBLDetCtaCte BL_DetCtaCte { get; set; }
      [Dependency]
      public IBLCtaCte BL_CtaCte { get; set; }
      [Dependency]
      public IBLTipos BL_Tipos { get; set; }
      [Dependency]
      public IBLParametros BL_Parametros { get; set; }
      [Dependency]
      public IBLConciliacion BL_Conciliacion { get; set; }
      [Dependency]
      public IBLMovimientoFlujo BL_MovimientoFlujo { get; set; }
      [Dependency]
      public IBLLiquidacion BL_Liquidacion { get; set; }
      [Dependency]
      public IBLTipificaciones BL_Tipificaciones { get; set; }

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
      public ObservableCollection<Movimiento> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectAllByFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Movimiento> GetAll()
      {
         try
         {
            return SelectAll();
         }
         catch (Exception)
         { throw; }
      }

      /// <summary>
      /// Metodo utilizado para el Movimiento de tipo Ingresos y Egresos
      /// </summary>
      /// <param name="EMPR_Codigo">Código de Empresa</param>
      /// <param name="MOVI_Codigo">Código del Movimiento consultado</param>
      /// <returns></returns>
      public Movimiento GetOne(Int16 EMPR_Codigo, Int32 MOVI_Codigo)
      {
         try
         {
            if (EMPR_Codigo == null || MOVI_Codigo == null) { return null; }
            Entities.Movimiento _movimiento = SelectOne(EMPR_Codigo, MOVI_Codigo);
            if (_movimiento != null)
            {
               ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> listFilters = new ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL>();
               listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@psinEMPR_Codigo", FilterValue = EMPR_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int16, FilterSize = 2 });
               listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pintMOVI_Codigo", FilterValue = MOVI_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int32, FilterSize = 4 });

               if (_movimiento.TMovimiento.Equals("I"))
               { _movimiento.ListDetCtaCte = BL_DetCtaCte.GetAllFilter("CAJ_DCCTSS_TodosPorMovimiento", listFilters); }
               else if (_movimiento.TMovimiento.Equals("E"))
               {
                  _movimiento.ListDetCtaCte = BL_DetCtaCte.GetAllFilter("CAJ_DCCTSS_TodosPorMovimiento", listFilters);
                  _movimiento.ItemPlanillas = GetOnePlanilla(_movimiento.EMPR_Codigo, _movimiento.PLAN_Tipo, _movimiento.PLAN_Codigo);
               }

               if (_movimiento.TieneDescuadre)
               {
                  ObservableCollection<Entities.CtaCte> Lctacte = BL_CtaCte.GetAllFilter("CAJ_CCCTSS_UnRegPorDescuadre", listFilters);
                  if (Lctacte != null && Lctacte.Count > 0)
                  {
                     _movimiento.ItemCtaCteDescuadre = Lctacte[0];
                  }
                  else { _movimiento.ItemCtaCteDescuadre = new CtaCte(); _movimiento.ItemCtaCteDescuadre.Instance = InstanceEntity.Added; }
               }
               _movimiento.ListFlujos = BL_MovimientoFlujo.GetAllFilter("CAJ_MFLUSS_UnReg", listFilters);
               _movimiento.ListFlujosEliminados = new ObservableCollection<MovimientoFlujo>();

               _movimiento.ListConciliacion = BL_Conciliacion.GetAllFilter("CAJ_MOVISS_TodosConciliados", listFilters);

               _movimiento.ListTipificaciones = BL_Tipificaciones.GetAllFilter("CAJ_TIPDSS_TodosPorMovimiento", listFilters);
               _movimiento.ListTipificacionesEliminados = new ObservableCollection<Tipificaciones>();

               return _movimiento;
            }
            return null;
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]

      public Boolean Save(ref Movimiento Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            DataAccessEnterpriseSQL.DABeginTransaction();
            String x_Usuario = "";
            GAsientos genAsientos;
            #region [ Cabecera de Movimiento ]
            genAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCaja);

            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = Insert(ref Item);
                  if (Item.ListDetCtaCte != null)
                  {
                     foreach (Entities.DetCtaCte item in Item.ListDetCtaCte)
                     {
                        item.CCCT_Pendiente = Math.Abs(item.CCCT_Pendiente.Value);
                        item.Instance = InstanceEntity.Added;
                     }
                  }
                  Item.ItemCtaCteDescuadre = new CtaCte();
                  Item.ItemCtaCteDescuadre.Instance = InstanceEntity.Added;
                  Item.ItemCtaCteDescuadre.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                  Item.ItemCtaCteDescuadre.ItemDetCtaCte = new DetCtaCte();
                  Item.ItemCtaCteDescuadre.ItemDetCtaCte.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                  Item.ItemCtaCteDescuadre.CCCT_FechaEmision = Item.MOVI_FecEmision;
                  x_Usuario = Item.AUDI_UsrCrea;

                  if (Item.ListFlujos != null && Item.ListFlujos.Count > 0)
                  {
                     foreach (Entities.MovimientoFlujo _movimientoFlujo in Item.ListFlujos)
                     {
                        MovimientoFlujo movimientoFlujo = _movimientoFlujo;
                        movimientoFlujo.EMPR_Codigo = Item.EMPR_Codigo;
                        movimientoFlujo.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                        movimientoFlujo.MOVI_Codigo = Item.MOVI_Codigo;
                        //iMovimientoFlujo.CUBA_Codigo = Item.CUBA_Codigo;
                        _movimientoFlujo.Instance = InstanceEntity.Added;
                        m_isCorrect = BL_MovimientoFlujo.Save(ref movimientoFlujo);
                        if (!m_isCorrect)
                        { //Item.SetMensajeError(String.Format("* No se puede grabar la Chequera Numero {0}.", iMovimientoFlujo.MFLU_Item)); break; 
                        }
                     }
                  }

                  if (Item.ListTipificaciones != null && Item.ListTipificaciones.Count > 0)
                  {
                     foreach (Entities.Tipificaciones iTipificacion in Item.ListTipificaciones)
                     {
                        Tipificaciones _tipificacion = iTipificacion;
                        _tipificacion.EMPR_Codigo = Item.EMPR_Codigo;
                        _tipificacion.MOVI_Codigo = Item.MOVI_Codigo;
                        _tipificacion.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                        _tipificacion.Instance = InstanceEntity.Added;
                        m_isCorrect = BL_Tipificaciones.Save(ref _tipificacion);
                     }
                  }
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = Update(ref Item);
                  foreach (Entities.DetCtaCte item in Item.ListDetCtaCte)
                  { item.CCCT_Pendiente = Math.Abs(item.CCCT_Pendiente.Value); }
                  if (Item.ItemCtaCteDescuadre == null)
                  {
                     Item.ItemCtaCteDescuadre = new CtaCte();
                     Item.ItemCtaCteDescuadre.Instance = InstanceEntity.Added;
                  }
                  Item.ItemCtaCteDescuadre.AUDI_UsrMod = Item.AUDI_UsrMod;
                  x_Usuario = Item.AUDI_UsrMod;

                  #region [ Flujos ]
                  
                  /* Eliminar los registros */
                  if (Item.ListFlujosEliminados != null && Item.ListFlujosEliminados.Count > 0)
                  {
                     foreach (Entities.MovimientoFlujo iMovimientoFlujo in Item.ListFlujosEliminados)
                     {
                        MovimientoFlujo MovimientoFlujo = iMovimientoFlujo;
                        MovimientoFlujo.Instance = InstanceEntity.Deleted;
                        BL_MovimientoFlujo.Save(ref MovimientoFlujo);
                     }
                  }
                  /* Agregar o actualizar los registros */
                  if (Item.ListFlujos != null && Item.ListFlujos.Count > 0)
                  {
                     foreach (Entities.MovimientoFlujo iMovimientoFlujo in Item.ListFlujos)
                     {
                        MovimientoFlujo MovimientoFlujo = iMovimientoFlujo;
                        MovimientoFlujo.EMPR_Codigo = Item.EMPR_Codigo;
                        if (MovimientoFlujo.Instance == InstanceEntity.Added)
                        { MovimientoFlujo.AUDI_UsrCrea = Item.AUDI_UsrCrea; }
                        else if (MovimientoFlujo.Instance == InstanceEntity.Modified)
                        { MovimientoFlujo.AUDI_UsrMod = Item.AUDI_UsrMod; }
                        MovimientoFlujo.MOVI_Codigo = Item.MOVI_Codigo;
                        m_isCorrect = BL_MovimientoFlujo.Save(ref MovimientoFlujo);
                        if (!m_isCorrect)
                        {// Item.SetMensajeError(String.Format("* No se puede grabar la Chequera Numero {0}.", _iChequera.CHEQ_Codigo)); break;
                        }
                     }
                  }

                  #endregion

                  #region [ Tipificaciones ]

                  if (Item.ListTipificacionesEliminados != null && Item.ListTipificacionesEliminados.Count > 0)
                  {
                     foreach (Entities.Tipificaciones iTipEli in Item.ListTipificacionesEliminados)
                     {
                        Tipificaciones _tipificacion = iTipEli;
                        _tipificacion.Instance = InstanceEntity.Deleted;
                        BL_Tipificaciones.Save(ref _tipificacion);
                     }
                  }

                  if (Item.ListTipificaciones != null && Item.ListTipificaciones.Count > 0)
                  {
                     foreach (Entities.Tipificaciones iTipificacion in Item.ListTipificaciones)
                     {
                        Tipificaciones _tipificacion = iTipificacion;
                        _tipificacion.EMPR_Codigo = Item.EMPR_Codigo;
                        if (_tipificacion.Instance == InstanceEntity.Added)
                        { _tipificacion.AUDI_UsrCrea = Item.AUDI_UsrMod; }
                        else if (_tipificacion.Instance == InstanceEntity.Modified)
                        { _tipificacion.AUDI_UsrMod = Item.AUDI_UsrMod; }
                        _tipificacion.MOVI_Codigo = Item.MOVI_Codigo;
                        m_isCorrect = BL_Tipificaciones.Save(ref _tipificacion);
                     }
                  }

                  #endregion


                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = Delete(ref Item); break;
            }

            #endregion

            #region Detalles de CtaCte

            if (Item.ListDetCtaCteEliminados != null && Item.ListDetCtaCteEliminados.Count > 0)
            {
               foreach (Entities.DetCtaCte iDetCtaCte in Item.ListDetCtaCteEliminados)
               {
                  Entities.DetCtaCte _idetctacte = iDetCtaCte;
                  _idetctacte.Instance = InstanceEntity.Deleted;
                  BL_DetCtaCte.Save(ref _idetctacte);
               }
            }
            if (Item.ListDetCtaCte != null && Item.ListDetCtaCte.Count > 0)
            {
               foreach (Entities.DetCtaCte iDetCtaCte in Item.ListDetCtaCte)
               {
                  switch (iDetCtaCte.Instance)
                  {
                     case InstanceEntity.Unchanged:
                        break;
                     case InstanceEntity.Added:
                        iDetCtaCte.AUDI_UsrCrea = x_Usuario;
                        break;
                     case InstanceEntity.Modified:
                        iDetCtaCte.AUDI_UsrMod = x_Usuario;
                        break;
                     case InstanceEntity.Deleted:
                        break;
                     default:
                        break;
                  }
                  #region Guardar el detalle de Transacciones

                  iDetCtaCte.EMPR_Codigo = Item.EMPR_Codigo;
                  iDetCtaCte.MOVI_Codigo = Item.MOVI_Codigo;
                  iDetCtaCte.TIPO_TabMND = Item.ItemCuentasBancarias.TIPO_TabMND;
                  iDetCtaCte.TIPO_CodMND = Item.ItemCuentasBancarias.TIPO_CodMND;
                  iDetCtaCte.CCCT_TipoCambio = Item.MOVI_TipoCambio;
                  iDetCtaCte.DCCT_FechaTrans = DateTime.Now;
                  String TipoMovimiento = Item.TIPO_Movimiento.TIPO_Desc2;
                  if (Item.TIPO_Movimiento.TIPO_Desc2.Equals("I"))
                  {
                     if (iDetCtaCte.TipoCtaCte.Equals("-"))
                     {
                        if (iDetCtaCte.TIPO_CodTDO.Equals(Entities.Tipos.GetTipo(Entities.Tipos.TipoTDO.NotaCredito)))
                        { Item.TIPO_Movimiento.TIPO_Desc2 = "E"; }
                        else { Item.TIPO_Movimiento.TIPO_Desc2 = "E"; }
                     }

                  }
                  else if (Item.TIPO_Movimiento.TIPO_Desc2.Equals("E"))
                  {
                     if (iDetCtaCte.TipoCtaCte.Equals("-"))
                     {
                        if (iDetCtaCte.TIPO_CodTDO.Equals(Entities.Tipos.GetTipo(Entities.Tipos.TipoTDO.NotaCredito)))
                        { Item.TIPO_Movimiento.TIPO_Desc2 = "I"; }
                        else { Item.TIPO_Movimiento.TIPO_Desc2 = "I"; }
                     }
                  }

                  Decimal TipoCambio = iDetCtaCte.DCCT_TipoCambio;
                  if (Item.TIPO_Movimiento.TIPO_Desc2.Equals("E"))
                  {
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
                           #region Realizar ajustes si es Diferido - DEBE
                           /* Cambio - Cheques Diferidos - 02/05/2016 - Por Proceso Incompleto - El diferido debe grabarse igual que un cheque normal */
                           if (Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.EgresosChequeDiferido)) || Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.IngresosDiferidos)))
                           {
                              iDetCtaCte.DCCT_PPago = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                              //iDetCtaCte.DCCT_MontoDebe = 0;
                              iDetCtaCte.DCCT_PPagoD = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) / TipoCambio, 2, MidpointRounding.AwayFromZero);
                              //iDetCtaCte.DCCT_MontoDebeD = 0;
                           }
                           else
                           {
                              iDetCtaCte.DCCT_PPago = 0;
                              //iDetCtaCte.DCCT_MontoDebe = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                              iDetCtaCte.DCCT_PPagoD = 0;
                              //iDetCtaCte.DCCT_MontoDebeD = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) / TipoCambio, 2, MidpointRounding.AwayFromZero);
                           }

                           iDetCtaCte.DCCT_MontoDebe = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                           iDetCtaCte.DCCT_MontoDebeD = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) / TipoCambio, 2, MidpointRounding.AwayFromZero);
                           /* Fin de Cambio - Cheques Diferidos - 02/05/2016 */
                           #endregion
                        }
                        else if (iDetCtaCte.TIPO_CodMND.Equals(Util.getMoneda(TMoneda.Dolares)))
                        {
                           #region Realizar ajustes si es Diferido - DEBE
                           /* Cambio - Cheques Diferidos - 02/05/2016 - Por Proceso Incompleto - El diferido debe grabarse igual que un cheque normal */
                           if (Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.EgresosChequeDiferido)) || Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.IngresosDiferidos)))
                           {
                              iDetCtaCte.DCCT_PPago = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) * TipoCambio, 2, MidpointRounding.AwayFromZero);
                              //iDetCtaCte.DCCT_MontoDebe = 0;
                              iDetCtaCte.DCCT_PPagoD = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                              //iDetCtaCte.DCCT_MontoDebeD = 0;
                           }
                           else
                           {
                              iDetCtaCte.DCCT_PPago = 0;
                              //iDetCtaCte.DCCT_MontoDebe = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) * TipoCambio, 2, MidpointRounding.AwayFromZero);
                              iDetCtaCte.DCCT_PPagoD = 0;
                              //iDetCtaCte.DCCT_MontoDebeD = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                           }
                           iDetCtaCte.DCCT_MontoDebe = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) * TipoCambio, 2, MidpointRounding.AwayFromZero);
                           iDetCtaCte.DCCT_MontoDebeD = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                           /* Fin de Cambio - Cheques Diferidos - 02/05/2016 */
                           #endregion
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
                           #region Realizar ajustes si es Diferido - DEBE
                           /* Cambio - Cheques Diferidos - 02/05/2016 - Por Proceso Incompleto - El diferido debe grabarse igual que un cheque normal */
                           if (Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.EgresosChequeDiferido)) || Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.IngresosDiferidos)))
                           {
                              iDetCtaCte.DCCT_PPago = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                              //iDetCtaCte.DCCT_MontoDebe = 0;
                              if (iDetCtaCte.CCCT_Pendiente.HasValue)
                              {
                                 iDetCtaCte.DCCT_PPagoD = Math.Round(iDetCtaCte.CCCT_Pendiente.Value / TipoCambio, 2, MidpointRounding.AwayFromZero);
                                 //iDetCtaCte.DCCT_MontoDebeD = 0;
                              }
                           }
                           else
                           {
                              iDetCtaCte.DCCT_PPago = 0;
                              //iDetCtaCte.DCCT_MontoDebe = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                              if (iDetCtaCte.CCCT_Pendiente.HasValue)
                              {
                                 iDetCtaCte.DCCT_PPagoD = 0;
                                 //iDetCtaCte.DCCT_MontoDebeD = Math.Round(iDetCtaCte.CCCT_Pendiente.Value / TipoCambio, 2, MidpointRounding.AwayFromZero);
                              }
                           }
                           iDetCtaCte.DCCT_MontoDebe = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                           if (iDetCtaCte.CCCT_Pendiente.HasValue)
                           {
                              iDetCtaCte.DCCT_MontoDebeD = Math.Round(iDetCtaCte.CCCT_Pendiente.Value / TipoCambio, 2, MidpointRounding.AwayFromZero);
                           }
                           /* Fin de Cambio - Cheques Diferidos - 02/05/2016 */
                           #endregion
                        }
                        else if (iDetCtaCte.TIPO_CodMND.Equals(Util.getMoneda(TMoneda.Dolares)))
                        {
                           #region Realizar ajustes si es Diferido - DEBE
                           /* Cambio - Cheques Diferidos - 02/05/2016 - Por Proceso Incompleto - El diferido debe grabarse igual que un cheque normal */
                           if (Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.EgresosChequeDiferido)) || Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.IngresosDiferidos)))
                           {
                              iDetCtaCte.DCCT_PPago = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) * TipoCambio, 2, MidpointRounding.AwayFromZero);
                              //iDetCtaCte.DCCT_MontoDebe = 0;
                              iDetCtaCte.DCCT_PPagoD = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                              //iDetCtaCte.DCCT_MontoDebeD = 0;
                           }
                           else
                           {
                              iDetCtaCte.DCCT_PPago = 0;
                              //iDetCtaCte.DCCT_MontoDebe = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) * TipoCambio, 2, MidpointRounding.AwayFromZero);
                              iDetCtaCte.DCCT_PPagoD = 0;
                              //iDetCtaCte.DCCT_MontoDebeD = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                           }
                           iDetCtaCte.DCCT_MontoDebe = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) * TipoCambio, 2, MidpointRounding.AwayFromZero);
                           iDetCtaCte.DCCT_MontoDebeD = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                           /* Fin de Cambio - Cheques Diferidos - 02/05/2016 */
                           #endregion
                        }
                     }
                     #endregion
                  }
                  else if (Item.TIPO_Movimiento.TIPO_Desc2.Equals("I"))
                  {
                     #region Movimiento de Ingreso
                     /*
                      * Realizar las operaciones correspondientes para un Ingreso
                      */
                     iDetCtaCte.DCCT_MontoDebe = 0;
                     iDetCtaCte.DCCT_MontoDebeD = 0;
                     iDetCtaCte.CONS_TabTDC = Infrastructure.Aspect.Constants.Util.GetTTipoMovimientoDetCtaCte();
                     iDetCtaCte.CONS_CodTDC = Infrastructure.Aspect.Constants.Util.GetTTipoMovimientoDetCtaCte(Infrastructure.Aspect.Constants.TTipoMovimientoDetCtaCte.Provision);
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
                           TipoCambio = iDetCtaCte.DCCT_TipoCambio;

                           #region Realizar ajustes si es Diferido - HABER
                           /* Cambio - Cheques Diferidos - 02/05/2016 - Por Proceso Incompleto */
                           if (Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.IngresosDiferidos)) || Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.EgresosChequeDiferido)))
                           {
                              iDetCtaCte.DCCT_PPago = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                              //iDetCtaCte.DCCT_MontoHaber = 0;
                           }
                           else
                           {
                              iDetCtaCte.DCCT_PPago = 0;
                              //iDetCtaCte.DCCT_MontoHaber = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                           }
                           iDetCtaCte.DCCT_MontoHaber = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                           /* Fin de Cambio - Cheques Diferidos - 02/05/2016 */
                           #endregion

                           if (iDetCtaCte.CCCT_Pendiente.HasValue)
                           {
                              #region Realizar ajustes si es Diferido - HABER
                              /* Cambio - Cheques Diferidos - 02/05/2016 - Por Proceso Incompleto - El diferido debe grabarse igual que un cheque normal */
                              if (Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.IngresosDiferidos)) || Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.EgresosChequeDiferido)))
                              {
                                 iDetCtaCte.DCCT_PPagoD = Math.Round(iDetCtaCte.CCCT_Pendiente.Value / TipoCambio, 2, MidpointRounding.AwayFromZero);
                                 //iDetCtaCte.DCCT_MontoHaberD = 0;
                              }
                              else
                              {
                                 iDetCtaCte.DCCT_PPagoD = 0;
                                 //iDetCtaCte.DCCT_MontoHaberD = Math.Round(iDetCtaCte.CCCT_Pendiente.Value / TipoCambio, 2, MidpointRounding.AwayFromZero);
                              }
                              iDetCtaCte.DCCT_MontoHaberD = Math.Round(iDetCtaCte.CCCT_Pendiente.Value / TipoCambio, 2, MidpointRounding.AwayFromZero);
                              /* Fin de Cambio - Cheques Diferidos - 02/05/2016 */
                              #endregion
                           }
                        }
                        else if (iDetCtaCte.TIPO_CodMND.Equals(Util.getMoneda(TMoneda.Dolares)))
                        {
                           TipoCambio = iDetCtaCte.DCCT_TipoCambio;
                           #region Realizar ajustes si es Diferido - HABER
                           /* Cambio - Cheques Diferidos - 02/05/2016 - Por Proceso Incompleto - El diferido debe grabarse igual que un cheque normal */
                           if (Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.IngresosDiferidos)) || Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.EgresosChequeDiferido)))
                           {
                              //iDetCtaCte.DCCT_MontoHaber = 0;
                              //iDetCtaCte.DCCT_MontoHaberD = 0;
                              iDetCtaCte.DCCT_PPago = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) * TipoCambio, 2, MidpointRounding.AwayFromZero);
                              iDetCtaCte.DCCT_PPagoD = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                           }
                           else
                           {
                              //iDetCtaCte.DCCT_MontoHaber = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) * TipoCambio, 2, MidpointRounding.AwayFromZero);
                              //iDetCtaCte.DCCT_MontoHaberD = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                              iDetCtaCte.DCCT_PPago = 0;
                              iDetCtaCte.DCCT_PPagoD = 0;
                           }
                           iDetCtaCte.DCCT_MontoHaber = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) * TipoCambio, 2, MidpointRounding.AwayFromZero);
                           iDetCtaCte.DCCT_MontoHaberD = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                           /* Fin de Cambio - Cheques Diferidos - 02/05/2016 */
                           #endregion
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
                           TipoCambio = iDetCtaCte.DCCT_TipoCambio;
                           #region Realizar ajustes si es Diferido - HABER
                           /* Cambio - Cheques Diferidos - 02/05/2016 - Por Proceso Incompleto - El diferido debe grabarse igual que un cheque normal */
                           if (Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.IngresosDiferidos)) || Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.EgresosChequeDiferido)))
                           {
                              iDetCtaCte.DCCT_PPago = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                              //iDetCtaCte.DCCT_MontoHaber = 0;
                              if (iDetCtaCte.CCCT_Pendiente.HasValue)
                              {
                                 iDetCtaCte.DCCT_PPagoD = Math.Round(iDetCtaCte.CCCT_Pendiente.Value / TipoCambio, 2, MidpointRounding.AwayFromZero);
                                 //iDetCtaCte.DCCT_MontoHaberD = 0;
                              }
                           }
                           else
                           {
                              iDetCtaCte.DCCT_PPago = 0;
                              //iDetCtaCte.DCCT_MontoHaber = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                              if (iDetCtaCte.CCCT_Pendiente.HasValue)
                              {
                                 iDetCtaCte.DCCT_PPagoD = 0;
                                 //iDetCtaCte.DCCT_MontoHaberD = Math.Round(iDetCtaCte.CCCT_Pendiente.Value / TipoCambio, 2, MidpointRounding.AwayFromZero);
                              }
                           }
                           iDetCtaCte.DCCT_MontoHaber = (iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0);
                           if (iDetCtaCte.CCCT_Pendiente.HasValue)
                           {
                              iDetCtaCte.DCCT_MontoHaberD = Math.Round(iDetCtaCte.CCCT_Pendiente.Value / TipoCambio, 2, MidpointRounding.AwayFromZero);
                           }
                           /* Fin de Cambio - Cheques Diferidos - 02/05/2016 */
                           #endregion
                        }
                        else if (iDetCtaCte.TIPO_CodMND.Equals(Util.getMoneda(TMoneda.Dolares)))
                        {
                           TipoCambio = iDetCtaCte.DCCT_TipoCambio;
                           #region Realizar ajustes si es Diferido - HABER
                           /* Cambio - Cheques Diferidos - 02/05/2016 - Por Proceso Incompleto - El diferido debe grabarse igual que un cheque normal */
                           if (Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.IngresosDiferidos)) || Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.EgresosChequeDiferido)))
                           {
                              iDetCtaCte.DCCT_PPago = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) * TipoCambio, 2, MidpointRounding.AwayFromZero);
                              //iDetCtaCte.DCCT_MontoHaber = 0;
                              if (iDetCtaCte.CCCT_Pendiente.HasValue)
                              {
                                 iDetCtaCte.DCCT_PPagoD = iDetCtaCte.CCCT_Pendiente.Value;
                                 //iDetCtaCte.DCCT_MontoHaberD = 0;
                              }
                           }
                           else
                           {
                              iDetCtaCte.DCCT_PPago = 0;
                              //iDetCtaCte.DCCT_MontoHaber = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) * TipoCambio, 2, MidpointRounding.AwayFromZero);
                              if (iDetCtaCte.CCCT_Pendiente.HasValue)
                              {
                                 iDetCtaCte.DCCT_PPagoD = 0;
                                 //iDetCtaCte.DCCT_MontoHaberD = iDetCtaCte.CCCT_Pendiente.Value;
                              }
                           }
                           iDetCtaCte.DCCT_MontoHaber = Math.Round((iDetCtaCte.CCCT_Pendiente.HasValue ? iDetCtaCte.CCCT_Pendiente.Value : 0) * TipoCambio, 2, MidpointRounding.AwayFromZero);
                           if (iDetCtaCte.CCCT_Pendiente.HasValue)
                           {
                              iDetCtaCte.DCCT_MontoHaberD = iDetCtaCte.CCCT_Pendiente.Value;
                           }
                           /* Fin de Cambio - Cheques Diferidos - 02/05/2016 */
                           #endregion
                        }
                     }
                     #endregion
                  }
                  /*
                   * Realizar la Operación de Grabado en la Base de datosm según la Instancia de la Clase
                   */
                  Entities.DetCtaCte _idetctacte = iDetCtaCte;
                  BL_DetCtaCte.Save(ref _idetctacte);
                  Item.TIPO_Movimiento.TIPO_Desc2 = TipoMovimiento;
                  #endregion

               }
               #region Liquidacion - Terminar

               if (Item.EsLiquidacion)
               {
                  Entities.Liquidacion _itemLiquidacion = new Liquidacion();
                  _itemLiquidacion.EMPR_Codigo = Item.EMPR_Codigo;
                  _itemLiquidacion.LIQU_Codigo = Item.Liquidacion.LIQU_Codigo;
                  _itemLiquidacion.AUDI_UsrMod = x_Usuario;
                  _itemLiquidacion.SetEstado(Liquidacion.Estado.Liquidado);
                  m_isCorrect = BL_Liquidacion.Save(ref _itemLiquidacion, Liquidacion.TOperacion.Liquidar);
               }

               #endregion
            }

            #region Guardar Si existe un Descuadre

            m_isCorrect = GuardarDescuadre(ref Item, x_Usuario);

            #endregion

            #endregion

            #region Grabar Flujos

            #endregion

            #region [ Generar Asiento Contable ]

            if (m_isCorrect)
            {
               genAsientos.ItemMovimiento = Item;
               switch (Item.Instance)
               {
                  case InstanceEntity.Unchanged:
                     break;
                  case InstanceEntity.Added:
                     genAsientos.GenerarAsientoBD(x_Usuario);
                     //m_isCorrect = genAsientos.GenerarAsiento(x_Usuario, Item.SUCR_Codigo);
                     //if (m_isCorrect)
                     //{ genAsientos.ActualizarMovimiento(x_Usuario); }
                     break;
                  case InstanceEntity.Modified:
                     genAsientos.GenerarAsientoBD(x_Usuario);
                     //m_isCorrect = genAsientos.ActualizarAsiento(Item.AUDI_UsrMod, Item.SUCR_Codigo);
                     break;
                  case InstanceEntity.Deleted:
                     break;
                  default:
                     break;
               }

            }

            #endregion

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

      public Boolean Save(ref ObservableCollection<Movimiento> Items)
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

      #region [ Metodos Adicionales ]

      private Boolean GuardarDescuadre(ref Movimiento Item, String x_Usuario)
      {
         try
         {
            if (Item.TieneDescuadre && Item.GeneraCtaCte)
            {
               /*
                * Completar las propiedades correspondientes para guardar el Registro en la Base de Datos
                */
               CtaCte ItemCtaCteDescuadre = Item.ItemCtaCteDescuadre;
               ItemCtaCteDescuadre.EMPR_Codigo = Item.EMPR_Codigo;
               ItemCtaCteDescuadre.SUCR_Codigo = Item.SUCR_Codigo;
               ItemCtaCteDescuadre.TIPE_Codigo = Item.TIPE_Codigo;
               ItemCtaCteDescuadre.ENTC_Codigo = Item.ENTC_Codigo;
               //ItemCtaCteDescuadre.TIPO_CodTDO = TIPO_CodTDO;
               //ItemCtaCteDescuadre.TIPO_TabTDO = TIPO_TabTDO;
               ItemCtaCteDescuadre.TIPO_TabMND = Item.ItemCuentasBancarias.TIPO_TabMND;
               ItemCtaCteDescuadre.TIPO_CodMND = Item.ItemCuentasBancarias.TIPO_CodMND;
               //ItemCtaCteDescuadre.CCCT_Serie = TIPO_CodTDO;
               //ItemCtaCteDescuadre.CCCT_Numero
               ItemCtaCteDescuadre.CCCT_TipoCambio = Item.MOVI_TipoCambio;
               ItemCtaCteDescuadre.CCCT_ValVta = Item.MOVI_MontoDescuadre;
               ItemCtaCteDescuadre.CCCT_Imp1 = 0;
               ItemCtaCteDescuadre.CCCT_Monto = Item.MOVI_MontoDescuadre;
               ItemCtaCteDescuadre.AUDI_UsrCrea = x_Usuario;

               ItemCtaCteDescuadre.CCCT_Monto = Item.MOVI_MontoDescuadre;
               ItemCtaCteDescuadre.MOVI_Codigo = Item.MOVI_Codigo;
               ItemCtaCteDescuadre.TIPO_TabDES = Item.TIPO_TabDES;
               ItemCtaCteDescuadre.TIPO_CodDES = Item.TIPO_CodDES;

               if (Item.TIPO_CodMOV.Equals(Item.GetTipoMovimiento(Entities.Movimiento.TipoMovimiento.EgresosChequeDiferido)))
               { ItemCtaCteDescuadre.Diferido = true; }
               else { ItemCtaCteDescuadre.Diferido = false; }

               if (BL_CtaCte.Save(ref ItemCtaCteDescuadre, CtaCte.TInterfazCtaCte.RegistroDescuadre))
               {
                  Item.ItemCtaCteDescuadre = ItemCtaCteDescuadre;
                  return true;
               }
            }
            else
            {
               if (Item.ItemCtaCteDescuadre != null && Item.ItemCtaCteDescuadre.CCCT_Codigo > 0)
               {
                  Item.ItemCtaCteDescuadre.Instance = InstanceEntity.Deleted;
                  Entities.CtaCte ItemCtaCteDescuadre = Item.ItemCtaCteDescuadre;
                  if (BL_CtaCte.Save(ref ItemCtaCteDescuadre, CtaCte.TInterfazCtaCte.RegistroDescuadre))
                  {
                     return true;
                  }
               }
               return true;
            }
            return false;
         }
         catch (Exception)
         { throw; }
      }

      public Planillas GetOnePlanilla(Int16 EMPR_Codigo, String PLAN_Tipo, String PLAN_Codigo)
      {
         try
         {
            if (EMPR_Codigo == null || PLAN_Tipo == null || PLAN_Codigo == null) { return null; }
            Entities.Planillas _planilla = SelectOnePlanillas(EMPR_Codigo, PLAN_Tipo, PLAN_Codigo);
            return _planilla;
         }
         catch (Exception)
         { throw; }
      }

      #endregion
   }
}
