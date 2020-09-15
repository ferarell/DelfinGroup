using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessEntity;
using Infrastructure.Aspect.Collections;
using Infrastructure.Aspect.DataAccess;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLPreDocsVta : IBLPreDocsVta
   {
      #region [ Propiedades ]
      [Dependency]
      public IBLPreDetDocsVta BLPreDetDocsVta { get; set; }

      [Dependency]
      public IBLDet_Operacion BLDet_Operacion { get; set; }

      [Dependency]
      public IBLDet_Operacion_Servicio BLDet_Operacion_Servicio { get; set; }

      [Dependency]
      public IBLDet_Tarjas BLDet_Tarjas { get; set; }
      #endregion

      #region [ Consultas ]
      public ObservableCollection<PreDocsVta> GetAllPorFiltrosLView(String x_DOCV_Numero, DateTime x_DOCV_FechaEmisionIni, DateTime x_DOCV_FechaEmisionFin, Int32? x_ENTC_Codigo, String x_Estado)
      {
         try
         {
            return SelectAllPorFiltrosLView(x_DOCV_Numero, x_DOCV_FechaEmisionIni, x_DOCV_FechaEmisionFin, x_ENTC_Codigo, x_Estado);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public PreDocsVta GetOne(Int32 PDOC_Codigo)
      {
         try
         {
            if (PDOC_Codigo == null) { return null; }
            return SelectOne(PDOC_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public ObservableCollection<PreDocsVta> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectAllByFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean Save(ref PreDocsVta Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            DataAccessEnterpriseSQL.DABeginTransaction();
            switch (Item.Instance)
            {
               case InstanceEntity.Added:
                  m_isCorrect = Insert(ref Item);
                  if (m_isCorrect)
                  {
                     /* Items Detalle Documentos de Venta */
                     if (Item.ItemsPreDetDocsVta != null && Item.ItemsPreDetDocsVta.Count > 0)
                     {
                        foreach (var item in Item.ItemsPreDetDocsVta)
                        {
                           PreDetDocsVta itemPreDetDocsVta = item;
                           itemPreDetDocsVta.DOCV_Codigo = Item.PDOC_Codigo;
                           itemPreDetDocsVta.Trasanct = false;
                           m_isCorrect = BLPreDetDocsVta.Save(ref itemPreDetDocsVta);
                           if (m_isCorrect)
                           {
                              /* Items ItemsPreDetDocsVta_Det_Operacion */
                              if (Item.ItemsPreDetDocsVta_Det_Operacion != null && Item.ItemsPreDetDocsVta_Det_Operacion.Count > 0)
                              {
                                 if (!itemPreDetDocsVta.Tarjas)// Si es Operación
                                 {
                                    if (!String.IsNullOrEmpty(itemPreDetDocsVta.CTAR_Tipo)) // Servcios Logistico, aduanero y transporte)
                                    {
                                       foreach (var preDetDocsVtaDetOperacion in Item.ItemsPreDetDocsVta_Det_Operacion.Where(data => data.CTAR_Tipo == itemPreDetDocsVta.CTAR_Tipo && data.Agregar).ToObservableCollection())
                                       {
                                          PreDetDocsVta_Det_Operacion itemPreDetDocsVtaDetOperacion = preDetDocsVtaDetOperacion;
                                          itemPreDetDocsVtaDetOperacion.PDVO_Codigo = Item.PDOC_Codigo;
                                          if (!String.IsNullOrEmpty(itemPreDetDocsVtaDetOperacion.CTAR_Tipo))
                                          {
                                             // Servicios Log,Adu,Trans
                                             m_isCorrect = BLDet_Operacion.UpdateDetOperacionPreFactura(
                                             itemPreDetDocsVtaDetOperacion.COPE_Codigo,
                                             itemPreDetDocsVtaDetOperacion.DOPE_Item,
                                             itemPreDetDocsVta.PDDO_Item,
                                             itemPreDetDocsVta.DOCV_Codigo, "003"); // 003 => PreFacturada
                                          }
                                          if (!m_isCorrect) { break; }
                                       }
                                    }
                                    else
                                    {
                                       // Servicios Adicionales    
                                       var preDetDocsVtaDetOperacion = Item.ItemsPreDetDocsVta_Det_Operacion.FirstOrDefault(data => data.SOPE_Item == itemPreDetDocsVta.SOPE_Item);
                                       if (preDetDocsVtaDetOperacion != null)
                                          m_isCorrect = BLDet_Operacion_Servicio.UpdateDetServicioOperacionPreFactura(
                                          preDetDocsVtaDetOperacion.COPE_Codigo,
                                          preDetDocsVtaDetOperacion.SOPE_Item,
                                          itemPreDetDocsVta.PDDO_Item,
                                          itemPreDetDocsVta.DOCV_Codigo, "003"); // 003 => PreFacturada
                                       if (!m_isCorrect) { break; }
                                    }
                                 }
                                 else
                                 {
                                    // Es Tarjas
                                    foreach (var preDetDoc in Item.ItemsPreDetDocsVta_Det_Operacion.Where(data => data.Agregar).ToObservableCollection())
                                    {
                                       PreDetDocsVta_Det_Operacion itemPreDetDocsVtaDetOperacion = preDetDoc;
                                       itemPreDetDocsVtaDetOperacion.PDVO_Codigo = Item.PDOC_Codigo;
                                       m_isCorrect = BLDet_Tarjas.UpdateDetTarjasPreFacturacion(
                                       itemPreDetDocsVtaDetOperacion.TARJ_Codigo,
                                       itemPreDetDocsVtaDetOperacion.DTAJ_Item,
                                       itemPreDetDocsVta.PDDO_Item,
                                       itemPreDetDocsVta.DOCV_Codigo, "004"); // 004 => Facturada
                                       if (!m_isCorrect) { break; }
                                    }
                                 }
                              }
                           }
                           if (!m_isCorrect) { break; }
                        }
                     }
                  }
                  break;
               case InstanceEntity.Modified:
                  m_isCorrect = Update(ref Item);
                  if (m_isCorrect)
                  {
                     /* Items Detalle Documentos de Venta */
                     if (Item.ItemsPreDetDocsVta != null && Item.ItemsPreDetDocsVta.Count > 0)
                     {
                        /* Liberar todos Items Det_Operacion */
                        foreach (var item in Item.ItemsPreDetDocsVta)
                        {
                           PreDetDocsVta itemPreDetDocsVta = item;
                           //itemPreDetDocsVta.DOCV_Codigo = Item.PDOC_Codigo;
                           itemPreDetDocsVta.Trasanct = false;

                           /* Items ItemsPreDetDocsVta_Det_Operacion */
                           if (Item.ItemsPreDetDocsVta_Det_Operacion != null && Item.ItemsPreDetDocsVta_Det_Operacion.Count > 0)
                           {
                              if (!itemPreDetDocsVta.Tarjas)// Si es Operación
                              {
                                 if (!String.IsNullOrEmpty(itemPreDetDocsVta.CTAR_Tipo)) // Servcios Logistico, aduanero y transporte
                                 {
                                    /* Liberar Items Det_Operacion */
                                    foreach (var xitem in Item.ItemsPreDetDocsVta_Det_Operacion.Where(data => data.CTAR_Tipo == itemPreDetDocsVta.CTAR_Tipo).ToObservableCollection())
                                    {
                                       PreDetDocsVta_Det_Operacion itemPreDetDocsVtaDetOperacion = xitem;
                                       itemPreDetDocsVtaDetOperacion.PDVO_Codigo = Item.PDOC_Codigo;
                                       if (!String.IsNullOrEmpty(itemPreDetDocsVtaDetOperacion.CTAR_Tipo))
                                       {

                                          BLDet_Operacion.UpdateDetOperacionPreFactura(
                                          itemPreDetDocsVtaDetOperacion.COPE_Codigo,
                                          itemPreDetDocsVtaDetOperacion.DOPE_Item,
                                          0,
                                          0, "002"); // 002 => Terminada 
                                       }
                                    }
                                 }
                                 else
                                 {
                                    /* Liberar Item Det_OperacionServico  Servicio Adicional */
                                    var preDetDocsVtaDetOperacion = Item.ItemsPreDetDocsVta_Det_Operacion.FirstOrDefault(data => data.SOPE_Item == itemPreDetDocsVta.SOPE_Item);
                                    if (preDetDocsVtaDetOperacion != null)
                                       BLDet_Operacion_Servicio.UpdateDetServicioOperacionPreFactura(
                                       preDetDocsVtaDetOperacion.COPE_Codigo,
                                       preDetDocsVtaDetOperacion.SOPE_Item,
                                       0,
                                       0, "002"); // 002 => Terminada
                                 }
                              }
                              else  // Tarjas
                              {
                                 foreach (var preDetDoc in Item.ItemsPreDetDocsVta_Det_Operacion.Where(data => data.Agregar).ToObservableCollection())
                                 {
                                    PreDetDocsVta_Det_Operacion itemPreDetDocsVtaDetOperacion = preDetDoc;
                                    itemPreDetDocsVtaDetOperacion.PDVO_Codigo = Item.PDOC_Codigo;
                                    m_isCorrect = BLDet_Tarjas.UpdateDetTarjasPreFacturacion(
                                    itemPreDetDocsVtaDetOperacion.TARJ_Codigo,
                                    itemPreDetDocsVtaDetOperacion.DTAJ_Item,
                                    0,
                                    0, "004"); // 004 => Facturada
                                    if (!m_isCorrect) { break; }
                                 }
                              }
                           }
                        }
                        /* Eliminar PreDetDocVenta */
                        foreach (var item in Item.ItemsPreDetDocsVta)
                        {
                           if (item.DOCV_Codigo > 0)
                           {
                              item.Instance = InstanceEntity.Deleted;
                           }
                        }
                        ObservableCollection<PreDetDocsVta> itemsDeletePreDetDocsVta = Item.ItemsPreDetDocsVta.Where(data => data.DOCV_Codigo > 0).ToObservableCollection();
                        m_isCorrect = BLPreDetDocsVta.Save(ref itemsDeletePreDetDocsVta);

                        /* Guardamos de Nuevo Solo los Marcados */
                        foreach (var item in Item.ItemsPreDetDocsVta.Where(data => data.Agregar))
                        {
                           PreDetDocsVta itemPreDetDocsVta = item;
                           itemPreDetDocsVta.DOCV_Codigo = Item.PDOC_Codigo;
                           itemPreDetDocsVta.Trasanct = false;
                           itemPreDetDocsVta.Instance = InstanceEntity.Added;
                           itemPreDetDocsVta.AUDI_UsrCrea = Item.AUDI_UsrMod;
                           if (Item.AUDI_FecMod != null)
                              itemPreDetDocsVta.AUDI_FecCrea = Item.AUDI_FecMod.Value;
                           m_isCorrect = BLPreDetDocsVta.Save(ref itemPreDetDocsVta);
                           if (m_isCorrect)
                           {
                              /* Items ItemsPreDetDocsVta_Det_Operacion */
                              if (Item.ItemsPreDetDocsVta_Det_Operacion != null && Item.ItemsPreDetDocsVta_Det_Operacion.Count > 0)
                              {
                                 if (!itemPreDetDocsVta.Tarjas)// Si es Operación
                                 {
                                    if (!String.IsNullOrEmpty(itemPreDetDocsVta.CTAR_Tipo)) // Servcios Logistico, aduanero y transporte)
                                    {
                                       foreach (var preDetDocsVtaDetOperacion in Item.ItemsPreDetDocsVta_Det_Operacion.Where(data => data.CTAR_Tipo == itemPreDetDocsVta.CTAR_Tipo && data.Agregar).ToObservableCollection())
                                       {
                                          PreDetDocsVta_Det_Operacion itemPreDetDocsVtaDetOperacion = preDetDocsVtaDetOperacion;
                                          itemPreDetDocsVtaDetOperacion.PDVO_Codigo = Item.PDOC_Codigo;
                                          if (!String.IsNullOrEmpty(itemPreDetDocsVtaDetOperacion.CTAR_Tipo))
                                          {
                                             // Servicios Log,Adu,Trans
                                             m_isCorrect = BLDet_Operacion.UpdateDetOperacionPreFactura(
                                             itemPreDetDocsVtaDetOperacion.COPE_Codigo,
                                             itemPreDetDocsVtaDetOperacion.DOPE_Item,
                                             itemPreDetDocsVta.PDDO_Item,
                                             itemPreDetDocsVta.DOCV_Codigo, "003"); // 003 => PreFacturada
                                          }
                                          if (!m_isCorrect) { break; }
                                       }
                                    }
                                    else
                                    {
                                       // Servicios Adicionales    
                                       var preDetDocsVtaDetOperacion = Item.ItemsPreDetDocsVta_Det_Operacion.FirstOrDefault(data => data.SOPE_Item == itemPreDetDocsVta.SOPE_Item);
                                       if (preDetDocsVtaDetOperacion != null)
                                          m_isCorrect = BLDet_Operacion_Servicio.UpdateDetServicioOperacionPreFactura(
                                          preDetDocsVtaDetOperacion.COPE_Codigo,
                                          preDetDocsVtaDetOperacion.SOPE_Item,
                                          itemPreDetDocsVta.PDDO_Item,
                                          itemPreDetDocsVta.DOCV_Codigo, "003"); // 003 => PreFacturada
                                       if (!m_isCorrect) { break; }
                                    }
                                 }
                                 else
                                 {
                                    // Es Tarjas
                                    foreach (var preDetDoc in Item.ItemsPreDetDocsVta_Det_Operacion.Where(data => data.Agregar).ToObservableCollection())
                                    {
                                       PreDetDocsVta_Det_Operacion itemPreDetDocsVtaDetOperacion = preDetDoc;
                                       itemPreDetDocsVtaDetOperacion.PDVO_Codigo = Item.PDOC_Codigo;
                                       m_isCorrect = BLDet_Tarjas.UpdateDetTarjasPreFacturacion(
                                       itemPreDetDocsVtaDetOperacion.TARJ_Codigo,
                                       itemPreDetDocsVtaDetOperacion.DTAJ_Item,
                                       itemPreDetDocsVta.PDDO_Item,
                                       itemPreDetDocsVta.DOCV_Codigo, "004"); // 004 => Facturada
                                       if (!m_isCorrect) { break; }
                                    }
                                 }
                              }
                           }
                           if (!m_isCorrect) { break; }
                        }

                     }
                  }
                  break;
               case InstanceEntity.Deleted:
                  m_isCorrect = Delete(ref Item); break;
            }
            if (m_isCorrect)
            { DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
      public Boolean Save(ref ObservableCollection<PreDocsVta> Items)
      {
         try
         {
            Boolean m_isCorrect = true;
            DataAccessEnterpriseSQL.DABeginTransaction();
            for (int i = 0; i < Items.Count; i++)
            {
               var Item = Items.ElementAt(i);
               switch (Item.Instance)
               {
                  case InstanceEntity.Added:
                     m_isCorrect = Insert(ref Item); break;
                  case InstanceEntity.Modified:
                     m_isCorrect = Update(ref Item); break;
                  case InstanceEntity.Deleted:
                     m_isCorrect = Delete(ref Item); break;
               }
               if (!m_isCorrect)
               { DataAccessEnterpriseSQL.DARollbackTransaction(); return m_isCorrect; }
            }
            if (m_isCorrect)
            { DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
      public Boolean SaveAnulacion(PreDocsVta Item, String TipoPrefactura)
      {
         try
         {
            Boolean m_isCorrect = true;
            DataAccessEnterpriseSQL.DABeginTransaction();
            m_isCorrect = AnularPreDocsVta(ref Item, TipoPrefactura);
            if (m_isCorrect)
            { DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
      #endregion
   }
}
