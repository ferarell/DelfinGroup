using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using Infrastructure.Aspect;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.Entities
{
   public partial class Cab_Cotizacion_OV
   {
      #region [ Variables ]
      private String m_tipo_desctrf;

      public enum TipoInterfaz
      {
         OVC_Normal = 0, OVC_Prefacturada = 1
      }

      #endregion

      #region [ Propiedades ]
      /// <summary>
      /// Gets or sets el valor de: CCOT_NumDocVersion.
      /// </summary>
      [DataMember]
      public String CCOT_NumDocVersion
      {
         get { return CCOT_NumDoc + (CCOT_Version.HasValue ? " / " + CCOT_Version.Value.ToString() : ""); }
      }

      /// <summary>
      /// Gets or sets el valor de: CCOT_NumDocCOT.
      /// </summary>
      [DataMember]
      public String CCOT_NumDocCOT { get; set; }

      /// <summary>
      /// Gets or sets el valor de: CONT_Numero.
      /// </summary>
      [DataMember]
      public String CONT_Numero { get; set; }

      /// <summary>
      /// Gets or sets el valor de: CONT_Descrip.
      /// </summary>
      [DataMember]
      public String CONT_Descrip { get; set; }

      /// <summary>
      /// Gets or sets el valor de: TIPO_TabPAIOrigen.
      /// </summary>
      [DataMember]
      public String TIPO_TabPAIOrigen { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodPAIOrigen.
      /// </summary>
      [DataMember]
      public String TIPO_CodPAIOrigen { get; set; }
      /// <summary>
      /// Gets or sets el valor de: PUER_NombreOrigen.
      /// </summary>
      [DataMember]
      public String PUER_NombreOrigen { get; set; }

      /// <summary>
      /// Gets or sets el valor de: TIPO_TabPAITrasbordo.
      /// </summary>
      [DataMember]
      public String TIPO_TabPAITrasbordo { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodPAITrasbordo.
      /// </summary>
      [DataMember]
      public String TIPO_CodPAITrasbordo { get; set; }
      /// <summary>
      /// Gets or sets el valor de: PUER_NombreTrasbordo.
      /// </summary>
      [DataMember]
      public String PUER_NombreTrasbordo { get; set; }

      /// <summary>
      /// Gets or sets el valor de: TIPO_TabPAIDestino.
      /// </summary>
      [DataMember]
      public String TIPO_TabPAIDestino { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodPAIDestino.
      /// </summary>
      [DataMember]
      public String TIPO_CodPAIDestino { get; set; }
      /// <summary>
      /// Gets or sets el valor de: PUER_NombreDestino.
      /// </summary>
      [DataMember]
      public String PUER_NombreDestino { get; set; }

      #region [ Cliente ]
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomCliente.
      /// </summary>
      [DataMember]
      public String ENTC_NomCliente { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_EmailCliente.
      /// </summary>
      [DataMember]
      public String ENTC_EmailCliente { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel1Cliente.
      /// </summary>
      [DataMember]
      public String ENTC_Tel1Cliente { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel2Cliente.
      /// </summary>
      [DataMember]
      public String ENTC_Tel2Cliente { get; set; }

      /// <summary>
      /// Gets or sets el valor de: ENTC_CodContacto.
      /// </summary>
      [DataMember]
      public String ENTC_CodContacto { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomContacto.
      /// </summary>
      [DataMember]
      public String ENTC_NomContacto { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_EmailContacto.
      /// </summary>
      [DataMember]
      public String ENTC_EmailContacto { get; set; }

      /// <summary>
      /// Get or sets el valor de: ENTC_DocIdenCliente
      /// </summary>
      [DataMember]
      public String ENTC_DocIdenCliente { get; set; }
      #endregion

      #region [ Transportista ]
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomTransportista.
      /// </summary>
      [DataMember]
      public String ENTC_NomTransportista { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_EmailTransportista.
      /// </summary>
      [DataMember]
      public String ENTC_EmailTransportista { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel1Transportista.
      /// </summary>
      [DataMember]
      public String ENTC_Tel1Transportista { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel2Transportista.
      /// </summary>
      [DataMember]
      public String ENTC_Tel2Transportista { get; set; }
      #endregion

      #region [ Broker ]
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomBroker.
      /// </summary>
      [DataMember]
      public String ENTC_NomBroker { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_EmailBroker.
      /// </summary>
      [DataMember]
      public String ENTC_EmailBroker { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel1Broker.
      /// </summary>
      [DataMember]
      public String ENTC_Tel1Broker { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel2Broker.
      /// </summary>
      [DataMember]
      public String ENTC_Tel2Broker { get; set; }
      #endregion

      #region [ Agente ]
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomAgente.
      /// </summary>
      [DataMember]
      public String ENTC_NomAgente { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_DirAgente.
      /// </summary>
      [DataMember]
      public String ENTC_DirAgente { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_EmailAgente.
      /// </summary>
      [DataMember]
      public String ENTC_EmailAgente { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel1Agente.
      /// </summary>
      [DataMember]
      public String ENTC_Tel1Agente { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel2Agente.
      /// </summary>
      [DataMember]
      public String ENTC_Tel2Agente { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_ContactAgente.
      /// </summary>
      [DataMember]
      public String ENTC_ContactAgente { get; set; }
      #endregion

      #region [ Customer ]
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomCustomer.
      /// </summary>
      [DataMember]
      public String ENTC_NomCustomer { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_EmailCustomer.
      /// </summary>
      [DataMember]
      public String ENTC_EmailCustomer { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel1Customer.
      /// </summary>
      [DataMember]
      public String ENTC_Tel1Customer { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel2Customer.
      /// </summary>
      [DataMember]
      public String ENTC_Tel2Customer { get; set; }
      #endregion

      #region [ Ejecutivo ]
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomEjecutivo.
      /// </summary>
      [DataMember]
      public String ENTC_NomEjecutivo { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_EmailEjecutivo.
      /// </summary>
      [DataMember]
      public String ENTC_EmailEjecutivo { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel1Ejecutivo.
      /// </summary>
      [DataMember]
      public String ENTC_Tel1Ejecutivo { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel2Ejecutivo.
      /// </summary>
      [DataMember]
      public String ENTC_Tel2Ejecutivo { get; set; }
      #endregion

      #region [ Shipper ]
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomShipper.
      /// </summary>
      [DataMember]
      public String ENTC_NomShipper { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_DirShipper.
      /// </summary>
      [DataMember]
      public String ENTC_DirShipper { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_EmailShipper.
      /// </summary>
      [DataMember]
      public String ENTC_EmailShipper { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel1Shipper.
      /// </summary>
      [DataMember]
      public String ENTC_Tel1Shipper { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel2Shipper.
      /// </summary>
      [DataMember]
      public String ENTC_Tel2Shipper { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_ContactShipper.
      /// </summary>
      [DataMember]
      public String ENTC_ContactShipper { get; set; }
      #endregion

      #region [ Consignee ]
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomConsignee.
      /// </summary>
      [DataMember]
      public String ENTC_NomConsignee { get; set; }
      /// <summary>
      /// Gets or sets el valor de: CONS_DescTFT.
      /// </summary>
      [DataMember]
      public String ENTC_DirConsignee { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_EmailConsignee.
      /// </summary>
      [DataMember]
      public String ENTC_EmailConsignee { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel1Consignee.
      /// </summary>
      [DataMember]
      public String ENTC_Tel1Consignee { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel2Consignee.
      /// </summary>
      [DataMember]
      public String ENTC_Tel2Consignee { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_ContactConsignee.
      /// </summary>
      [DataMember]
      public String ENTC_ContactConsignee { get; set; }
      #endregion

      #region [ Ejecutivo ]
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomNotify.
      /// </summary>
      [DataMember]
      public String ENTC_NomNotify { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_EmailNotify.
      /// </summary>
      [DataMember]
      public String ENTC_EmailNotify { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel1Notify.
      /// </summary>
      [DataMember]
      public String ENTC_Tel1Notify { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel2Notify.
      /// </summary>
      [DataMember]
      public String ENTC_Tel2Notify { get; set; }
      #endregion

      #region[ Deposito Temporal ]
      /// <summary>
      /// Gets or sets el valor de: ENTC_CodDTE.
      /// </summary>
      [DataMember]
      public Int32 ENTC_CodDTE { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomDTE.
      /// </summary>
      [DataMember]
      public String ENTC_NomDTE { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_EmailDTE.
      /// </summary>
      [DataMember]
      public String ENTC_EmailDTE { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel1DTE.
      /// </summary>
      [DataMember]
      public String ENTC_Tel1DTE { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Tel2DTE.
      /// </summary>
      [DataMember]
      public String ENTC_Tel2DTE { get; set; }
      #endregion

      /// <summary>
      /// Gets or sets el valor de: TIPO_DescINC.
      /// </summary>
      [DataMember]
      public String TIPO_DescINC { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescIMO.
      /// </summary>
      [DataMember]
      public String TIPO_DescIMO { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescTRF.
      /// </summary>
      [DataMember]
      public String TIPO_DescTRF
      {
         get { return m_tipo_desctrf; }
         set
         {
            if (m_tipo_desctrf != null)
            { m_tipo_desctrf = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescMOT.
      /// </summary>
      [DataMember]
      public String TIPO_DescMOT { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescMND.
      /// </summary>
      [DataMember]
      public String TIPO_DescMND { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescCMND.
      /// </summary>
      [DataMember]
      public String TIPO_DescCMND { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescDTM.
      /// </summary>
      [DataMember]
      public String TIPO_DescDTM { get; set; }

      /// <summary>
      /// Gets or sets el valor de: CONS_DescRGM.
      /// </summary>
      [DataMember]
      public String CONS_DescRGM { get; set; }
      /// <summary>
      /// Gets or sets el valor de: CONS_DescVia.
      /// </summary>
      [DataMember]
      public String CONS_DescVia { get; set; }
      /// <summary>
      /// Gets or sets el valor de: CONS_DescFLE.
      /// </summary>
      [DataMember]
      public String CONS_DescFLE { get; set; }
      /// <summary>
      /// Gets or sets el valor de: CONS_DescEST.
      /// </summary>
      [DataMember]
      public String CONS_DescEST { get; set; }
      /// <summary>
      /// Gets or sets el valor de: CONS_DescTFT.
      /// </summary>
      [DataMember]
      public String CONS_DescTFT { get; set; }

      /// <summary>
      /// Gets or sets el valor de: PACK_DescC.
      /// </summary>
      [DataMember]
      public String PACK_DescC { get; set; }
      /// <summary>
      /// Gets or sets el valor de: DCOT_Cantidad.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> DCOT_Cantidad { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_DescCDT.
      /// </summary>
      [DataMember]
      public String TIPO_DescCDT { get; set; }
      /// <summary>
      /// Gets or sets el valor de: DCOT_Peso.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> DCOT_Peso { get; set; }
      /// <summary>
      /// Gets or sets el valor de: DCOT_Volumen.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> DCOT_Volumen { get; set; }
      /// <summary>
      /// Gets or sets el valor de: DCOT_Bultos.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> DCOT_Bultos { get; set; }
      /// <summary>
      /// Gets or sets el valor de: DCOT_Producto.
      /// </summary>
      [DataMember]
      public String DCOT_Producto { get; set; }
      /// <summary>
      /// Gets or sets el valor de: DCOT_PrecioUniVenta.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> DCOT_PrecioUniVenta { get; set; }

      /// <summary>
      /// Gets or sets el valor de: NAVE_Nombre.
      /// </summary>
      [DataMember]
      public String NAVE_Nombre { get; set; }
      /// <summary>
      /// Gets or sets el valor de: NVIA_FecETDMaster.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> NVIA_FecETDMaster { get; set; }
      /// <summary>
      /// Gets or sets el valor de: NVIA_FecCutOff.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> NVIA_FecCutOff { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ENTC_NomAgentePort.
      /// </summary>
      [DataMember]
      public String ENTC_NomAgentePort { get; set; }
      /// <summary>
      /// Gets or sets el valor de: CNTR_Numero.
      /// </summary>
      [DataMember]
      public String CNTR_Numero { get; set; }

      /// <summary>
      /// Gets or sets el valor de: NVIA_NroViaje.
      /// </summary>
      [DataMember]
      public String NVIA_NroViaje { get; set; }

      /// <summary>
      /// Gets or sets el valor de: ENTC_NomConsignatario.
      /// </summary>
      [DataMember]
      public String ENTC_NomConsignatario { get; set; }
      /// <summary>
      /// Gets or sets el valor de: PUER_NomEmbarque.
      /// </summary>
      [DataMember]
      public String PUER_NomEmbarque { get; set; }
      /// <summary>
      /// Gets or sets el valor de: PUER_NomOrigen.
      /// </summary>
      [DataMember]
      public String PUER_NomOrigen { get; set; }
      /// <summary>
      /// Gets or sets el valor de: PUER_NomDestino.
      /// </summary>
      [DataMember]
      public String PUER_NomDestino { get; set; }
      #endregion
   }
}