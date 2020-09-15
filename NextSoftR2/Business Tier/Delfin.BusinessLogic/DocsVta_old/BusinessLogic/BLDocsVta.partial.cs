using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.Constants;
using Infrastructure.Aspect.DataAccess;

namespace Delfin.BusinessLogic
{
   public partial class BLDocsVta
   {
      #region Propiedades

      [Dependency]
      public IBLCtaCte BL_CtaCte { get; set; }
      [Dependency]
      public IBLDetCtaCte BL_DetCtaCte { get; set; }
      [Dependency]
      public IBLDetDocsVta BL_DetDocsVta { get; set; }

      #endregion
      
      #region [ Consultas ]

      public DataSet GetAllImpresionFactura(Int32 x_DOCV_Codigo)
      {
         try
         {
            return SelectAllImpresionFactura(x_DOCV_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public DataSet GetDS(string x_procedure, List<object> filters)
      {
         try
         {
            return SelectDS(x_procedure, filters);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public DataSet GetDS(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, Boolean x_transaccion = false)
      {
         try
         {
            return SelectDS(x_procedure, x_filters, x_transaccion);
         }
         catch (Exception)
         { throw; }
      }

      public ObservableCollection<DocsVta> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectAllByFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }

      public DocsVta GetOne(Int16 EMPR_Codigo, Int32 DOCV_Codigo)
		{
			try
			{
				if (DOCV_Codigo == null) { return null; }
				Entities.DocsVta Item =  SelectOne(DOCV_Codigo);
            if (Item != null)
            {
               if (Item.CCCT_Codigo > 0)
               {
                  Item.ItemCtaCte = BL_CtaCte.GetOne(EMPR_Codigo, Item.CCCT_Codigo);
                  Item.ItemDetCtaCte = BL_DetCtaCte.GetOne(EMPR_Codigo, Item.CCCT_Codigo, 1);
               }
               ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> _listFilters = new ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL>();
               _listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@psinEMPR_Codigo", FilterValue = EMPR_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int16, FilterSize = 4 });
               _listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pintDOCV_Codigo", FilterValue = Item.DOCV_CodigoPadre, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int32, FilterSize = 4 });
               ObservableCollection<DetCtaCte> x_listDetCtaCte = BL_DetCtaCte.GetAllFilter("CAJ_DCCTSS_UnRegPorFactura", _listFilters);
               if (x_listDetCtaCte != null && x_listDetCtaCte.Count > 0)
               {
                  Item.ItemDetCtaCteFactura = x_listDetCtaCte[0];
               }
               //Item.ItemDetCtaCteFactura = BL_DetCtaCte.GetOne(EMPR_Codigo, Item.ItemDetCtaCte.CCCT_CodReferencia.Value, Item.ItemDetCtaCte.DCCT_ItemReferencia.Value);
            }
            return Item;
			}
			catch (Exception ex)
			{ throw ex; }
		}

      #endregion

      #region [ Metodos ]

      public DataSet GetImpresionDS(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, String x_usuario, Int16 x_sucr_codigo, Boolean x_transaccion = false)
      {
         DataSet dsResultado;
         try
         {
            Boolean m_iscorrect = true, m_generado = false;
            int CCCT_Codigo = 0; Int16 EMPR_Codigo = 0; String TIPO_CodFPG;
            DataAccessEnterpriseSQL.DABeginTransaction();

            dsResultado = SelectDS(x_procedure, x_filters, ref EMPR_Codigo, ref CCCT_Codigo, ref m_generado, false);
            if (dsResultado.Tables.Count > 0 && dsResultado.Tables[0].Rows.Count > 0 && m_generado)
            {
               GAsientos genAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoVenta);
               genAsientos.ItemCtaCte = new CtaCte();
               genAsientos.ItemCtaCte = BL_CtaCte.GetOne(EMPR_Codigo, CCCT_Codigo);
                              
               m_iscorrect = genAsientos.GenerarAsiento(x_usuario, x_sucr_codigo);
               if (m_iscorrect)
               { m_iscorrect = genAsientos.ActualizarCtaCte(x_usuario); }
            }
            if (m_iscorrect)
            { DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { throw new Exception("No se completo el proce de generación de documento"); }
         }
         catch (Exception)
         { DataAccessEnterpriseSQL.DARollbackTransaction(); dsResultado = null; throw; }
         return dsResultado;
      }

      public Boolean SaveFacturacion(DocsVta Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
            m_isCorrect = Facturar(Item);
            if (m_isCorrect)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }

      /// <summary>
      /// Anular documento generados par SLI
      /// </summary>
      /// <param name="item">The item.</param>
      /// <returns></returns>
      public bool AnularDocsVtaFacturacion(DocsVta item)
      {
         try
         {
            Boolean m_isCorrect = true;
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
            m_isCorrect = AnularDocsVta(item);

            // Anular Asiento de Venta
            GAsientos genAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoVenta);
            genAsientos.ItemDocsVta = item;
            m_isCorrect = genAsientos.Anular(item.AUDI_UsrMod, GAsientos.TipoItem.DocVta);

            if (m_isCorrect)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;

         }
         catch (Exception ex)
         { throw ex; }
      }

      public Boolean Save(ref DocsVta Item, Entities.DocsVta.TInterfazDocsVta x_opcion)
      {
         try
         {
            Boolean m_isCorrect = true;
            switch (x_opcion)
            {
               case DocsVta.TInterfazDocsVta.Normal:
                  m_isCorrect = Save(ref Item);
                  break;
               case DocsVta.TInterfazDocsVta.NotaCredito:
                  m_isCorrect = SaveNotaCredito(ref Item);
                  break;
               case DocsVta.TInterfazDocsVta.AnularNotaCredito:
                  m_isCorrect = Save(ref Item);
                  break;
               case DocsVta.TInterfazDocsVta.AnularFactura:
                  m_isCorrect = SaveAnularFactura(ref Item);
                  break;
               case DocsVta.TInterfazDocsVta.ActualizarFormaPago:
                  m_isCorrect = SaveFormaPagoFactura(ref Item);
                  break;
               case DocsVta.TInterfazDocsVta.RegenerarDocumentoVenta:
                  m_isCorrect = SaveRenegerar(ref Item);
                  break;
               case DocsVta.TInterfazDocsVta.FacturacionLibre:
                  m_isCorrect = SaveFacturacionLibre(ref Item);
                  break;
               case DocsVta.TInterfazDocsVta.ActualizarFactura:
                  m_isCorrect = SaveActualizarFactura(Item);
                  break;
               default:
                  break;
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }
      #region Grabar

      private void getCtaCte(ref DocsVta Item)
      {
         try
         {
            if (Item.ItemCtaCte == null) { Item.ItemCtaCte = new CtaCte(); }
            Item.ItemCtaCte.TIPO_CodTDO = Item.TIPO_CodTDO;
            Item.ItemCtaCte.TIPO_TabTDO = Item.TIPO_TabTDO;
            Item.ItemCtaCte.CCCT_FechaEmision = Item.DOCV_FechaEmision;
            Item.ItemCtaCte.CCCT_TipoCambio = Item.DOCV_TipoCambio;
            Item.ItemCtaCte.CCCT_Serie = Item.DOCV_Serie;
            Item.ItemCtaCte.CCCT_Numero = Item.DOCV_Numero;
            Item.ItemCtaCte.CCCT_FechaVcto = Item.DOCV_FechaVcmto;
            Item.ItemCtaCte.DOCV_Codigo = Item.DOCV_Codigo;
            //Item.ItemCtaCte.CCCT_Pendiente = Item.CCCT_Pendiente;
            if (Item.TIPO_CodMND.Equals(Infrastructure.Aspect.Constants.Util.getMoneda(TMoneda.Soles)))
            {
               Item.ItemCtaCte.CCCT_ValVta = Item.DOCV_ValorTotal;
               Item.ItemCtaCte.CCCT_Imp1 = Item.DOCV_Impuesto1;
               Item.ItemCtaCte.CCCT_Monto = Item.DOCV_ValorVtaTotal;
            }
            else if (Item.TIPO_CodMND.Equals(Infrastructure.Aspect.Constants.Util.getMoneda(TMoneda.Dolares)))
            {
               Item.ItemCtaCte.CCCT_ValVta = Item.DOCV_ValorTotalD;
               Item.ItemCtaCte.CCCT_Imp1 = Item.DOCV_Impuesto1D;
               Item.ItemCtaCte.CCCT_Monto = Item.DOCV_ValorVtaTotalD;
            }
            //Item.ItemCtaCte.TIPE_Codigo = Item.tip
            Item.ItemCtaCte.ENTC_Codigo = Item.ENTC_Codigo;
            Item.ItemCtaCte.TIPO_CodMND = Item.TIPO_CodMND;
            Item.ItemCtaCte.TIPO_TabMND = Item.TIPO_TabMND;
            Item.ItemCtaCte.TIPO_CodFPG = Item.TIPO_CodFPG;
            Item.ItemCtaCte.TIPO_TabFPG = Item.TIPO_TabFPG;

         }
         catch (Exception)
         { throw; }
      }

      private void getDocsVta(ref DocsVta Item)
      {
         try
         {            
            DocsVta x_item = GetOne(Item.DOCV_Codigo);
            if (Item.DOCV_ValorTotalD != x_item.DOCV_ValorTotalD)
            {
               Item.DOCV_PrecVtaTotal = x_item.DOCV_PrecVtaTotal;
               Item.DOCV_PrecVtaTotalD = x_item.DOCV_PrecVtaTotalD;
               Item.DOCV_ValorTotal = x_item.DOCV_ValorTotal;
               Item.DOCV_ValorTotalD = x_item.DOCV_ValorTotalD;
               Item.DOCV_ValorVtaTotal = x_item.DOCV_ValorVtaTotal;
               Item.DOCV_ValorVtaTotalD = x_item.DOCV_ValorVtaTotalD;
               Item.DOCV_Impuesto1 = x_item.DOCV_Impuesto1;
               Item.DOCV_Impuesto1D = x_item.DOCV_Impuesto1D;
            }
         }
         catch (Exception)
         { throw; }
      }

      /// <summary>
      /// Permite guardar el documento nota de credito, realizando las respectivas operaciones para completar el proceso en finanzas
      /// </summary>
      /// <param name="Item"></param>
      /// <returns></returns>
      public Boolean SaveNotaCredito(ref DocsVta Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            String x_usuario = "";
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = InsertNotaCredito(ref Item);
                  x_usuario = Item.AUDI_UsrCrea;
                  /* CtaCte */
                  getCtaCte(ref Item);
                  Item.ItemCtaCte.AUDI_UsrCrea = x_usuario;
                  Item.ItemCtaCte.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added;
                  Item.ItemDetCtaCte.AUDI_UsrCrea = x_usuario;
                  Item.ItemDetCtaCte.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added;
                  Item.ItemDetCtaCteFactura.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added;
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = UpdateNotaCredito(ref Item);
                  x_usuario = Item.AUDI_UsrMod;
                  getDocsVta(ref Item);
                  if (Item.ItemCtaCte != null)
                  {
                     getCtaCte(ref Item);
                     Item.ItemCtaCte.AUDI_UsrMod = x_usuario;
                     Item.ItemDetCtaCte.AUDI_UsrMod = x_usuario;
                  }
                  Item.ItemDetCtaCteFactura.AUDI_UsrMod = x_usuario;
                  if (Item.ItemDetCtaCteFactura.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
                  { Item.ItemDetCtaCteFactura.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified; }
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = Delete(ref Item); break;
            }
            /* CtaCte */
            Entities.CtaCte _itemCtaCte = Item.ItemCtaCte;
            if (_itemCtaCte!= null && BL_CtaCte.Save(ref _itemCtaCte))
            {
               Entities.DetCtaCte _itemDetCtaCte = Item.ItemDetCtaCte;
               _itemDetCtaCte.CCCT_Codigo = _itemCtaCte.CCCT_Codigo;
               _itemDetCtaCte.DCCT_MontoDebe = 0;
               _itemDetCtaCte.DCCT_MontoDebeD = 0;
               _itemDetCtaCte.DCCT_MontoHaber = Item.DOCV_ValorVtaTotal;
               _itemDetCtaCte.DCCT_MontoHaberD = Item.DOCV_ValorVtaTotalD;
               _itemDetCtaCte.CONS_TabTDC = Infrastructure.Aspect.Constants.Util.GetTTipoMovimientoDetCtaCte();
               _itemDetCtaCte.CONS_CodTDC = Infrastructure.Aspect.Constants.Util.GetTTipoMovimientoDetCtaCte(Infrastructure.Aspect.Constants.TTipoMovimientoDetCtaCte.Provision);
               _itemDetCtaCte.DCCT_TipoCambio = Item.DOCV_TipoCambio;
               _itemDetCtaCte.TIPO_CodMND = Item.TIPO_CodMND;
               _itemDetCtaCte.TIPO_TabMND = Item.TIPO_TabMND;
               _itemDetCtaCte.DCCT_FechaTrans = Item.DOCV_FechaEmision.Value;
               _itemDetCtaCte.CCCT_CodReferencia = null;
               _itemDetCtaCte.DCCT_ItemReferencia = null;

               m_isCorrect = BL_DetCtaCte.Save(ref _itemDetCtaCte);
               Item.ItemDetCtaCte = _itemDetCtaCte;
            }

            /* Canjes en la Factura *

            if (m_isCorrect && Item.ItemDetCtaCteFactura.CCCT_Pendiente.HasValue && Item.ItemDetCtaCteFactura.CCCT_Pendiente > 0 && Item.ItemDetCtaCte != null)
            {
               Entities.DetCtaCte _itemDetCtaCte = Item.ItemDetCtaCteFactura;
               _itemDetCtaCte.DCCT_MontoDebe = 0;
               _itemDetCtaCte.DCCT_MontoDebeD = 0;
               _itemDetCtaCte.DCCT_MontoHaber = Item.DOCV_ValorVtaTotal;
               _itemDetCtaCte.DCCT_MontoHaberD = Item.DOCV_ValorVtaTotalD;
               _itemDetCtaCte.CONS_TabTDC = Infrastructure.Aspect.Constants.Util.GetTTipoMovimientoDetCtaCte();
               _itemDetCtaCte.CONS_CodTDC = Infrastructure.Aspect.Constants.Util.GetTTipoMovimientoDetCtaCte(Infrastructure.Aspect.Constants.TTipoMovimientoDetCtaCte.Canje);
               _itemDetCtaCte.DCCT_TipoCambio = Item.DOCV_TipoCambio;
               _itemDetCtaCte.TIPO_CodMND = Item.TIPO_CodMND;
               _itemDetCtaCte.TIPO_TabMND = Item.TIPO_TabMND;
               _itemDetCtaCte.DCCT_FechaTrans = Item.DOCV_FechaEmision.Value;
               _itemDetCtaCte.CCCT_CodReferencia = Item.ItemCtaCte.CCCT_Codigo;
               _itemDetCtaCte.AUDI_UsrCrea = x_usuario;

               m_isCorrect = BL_DetCtaCte.Save(ref _itemDetCtaCte);
               Item.ItemDetCtaCteFactura = _itemDetCtaCte;
            }

            if (m_isCorrect && Item.ItemDetCtaCteFactura.CCCT_Pendiente.HasValue && Item.ItemDetCtaCteFactura.CCCT_Pendiente > 0 && Item.ItemDetCtaCte!= null)
            {
               Entities.DetCtaCte _itemDetCtaCte = Item.ItemDetCtaCte;
               _itemDetCtaCte.DCCT_MontoDebe = Item.DOCV_ValorVtaTotal;
               _itemDetCtaCte.DCCT_MontoDebeD = Item.DOCV_ValorVtaTotalD;
               _itemDetCtaCte.DCCT_MontoHaber = 0;
               _itemDetCtaCte.DCCT_MontoHaberD = 0;
               _itemDetCtaCte.CONS_TabTDC = Infrastructure.Aspect.Constants.Util.GetTTipoMovimientoDetCtaCte();
               _itemDetCtaCte.CONS_CodTDC = Infrastructure.Aspect.Constants.Util.GetTTipoMovimientoDetCtaCte(Infrastructure.Aspect.Constants.TTipoMovimientoDetCtaCte.Canje);
               _itemDetCtaCte.DCCT_TipoCambio = Item.DOCV_TipoCambio;
               _itemDetCtaCte.TIPO_CodMND = Item.TIPO_CodMND;
               _itemDetCtaCte.TIPO_TabMND = Item.TIPO_TabMND;
               _itemDetCtaCte.CCCT_CodReferencia = Item.ItemDetCtaCteFactura.CCCT_Codigo;
               _itemDetCtaCte.DCCT_ItemReferencia = Item.ItemDetCtaCteFactura.DCCT_Item;
               _itemDetCtaCte.DCCT_FechaTrans = Item.DOCV_FechaEmision.Value;
               _itemDetCtaCte.AUDI_UsrCrea = x_usuario;

               m_isCorrect = BL_DetCtaCte.Save(ref _itemDetCtaCte, DetCtaCte.TInterfazDetCtaCte.Canje);
            }
            */
            if (m_isCorrect)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;

         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }

      /// <summary>
      /// Permite actualizar la forma de pago del documento de venta seleccionado
      /// </summary>
      /// <param name="Item"></param>
      /// <returns></returns>
      public Boolean SaveFormaPagoFactura(ref DocsVta Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();

            m_isCorrect = UpdateFormaPagoFactura(ref Item); 
            
            if (m_isCorrect)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }

      /// <summary>
      /// Procedimiento para que un documento anulado pueda se activado, los pasos son los siguientes
      /// - Crear una copia del documento, con estado anulado
      /// - Activar el documento de venta actual para que el documento no pierda las relaciones y pueda utilizarse, tambien se tiene que 
      ///   inicializar el numero del documento para permitirle generar un nuevo numero e imprimirlo desde la interfaz de facturación.
      /// </summary>
      /// <param name="Item"></param>
      /// <returns></returns>
      public Boolean SaveRenegerar(ref DocsVta Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();

            m_isCorrect = RegenerarDocumentoVenta(ref Item);

            if (m_isCorrect)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }

      /// <summary>
      /// Grabar registros de Facturación Libre
      /// </summary>
      /// <param name="Item"></param>
      /// <returns></returns>
      public Boolean SaveFacturacionLibre(ref DocsVta Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = Insert(ref Item);
                  if (m_isCorrect)
                  {
                     foreach (Entities.DetDocsVta iDetDocVta in Item.ItemsDetDocsVta)
                     {
                        iDetDocVta.DOCV_Codigo = Item.DOCV_Codigo;
                        iDetDocVta.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                        iDetDocVta.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added;
                     }
                  }
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = Update(ref Item);
                  foreach (Entities.DetDocsVta iDetDocVta in Item.ItemsDetDocsVta)
                  {
                     iDetDocVta.AUDI_UsrMod = Item.AUDI_UsrMod;
                  }
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = Delete(ref Item); break;
            }

            foreach (Entities.DetDocsVta iDetDocVta in Item.ItemsDetDocsVtaEliminados)
            {
               m_isCorrect = BL_DetDocsVta.Save(iDetDocVta);
            }

            foreach (Entities.DetDocsVta iDetDocVta in Item.ItemsDetDocsVta)
            {
               m_isCorrect = BL_DetDocsVta.Save(iDetDocVta);
               if (!m_isCorrect) { break; }
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

      /// <summary>
      /// Permite anular el documento de venta actual
      /// </summary>
      /// <param name="Item"></param>
      /// <returns></returns>
      public Boolean SaveAnularFactura(ref DocsVta Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();

            m_isCorrect = UpdateAnularFactura(ref Item);
             
            // Anular Asiento de Venta
            GAsientos genAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoVenta);
            genAsientos.ItemDocsVta = Item;
            m_isCorrect = genAsientos.Anular(Item.AUDI_UsrMod, GAsientos.TipoItem.DocVta);
            
            if (m_isCorrect)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }


      public Boolean SaveActualizarFactura(DocsVta Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();

            m_isCorrect = UpdateFactura(Item);

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
      #endregion
   }
}
