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
		Contrato m_itemContrato;
		ObservableCollection<Contrato> m_listContrato;
		Empresa m_itemEmpresa;
		ObservableCollection<Empresa> m_listEmpresa;
		Sucursales m_itemSucursales;
		ObservableCollection<Sucursales> m_listSucursales;

      private Nave m_itemNave;
      private NaveViaje m_itemNaveViaje;
      private DetNaveViaje m_itemDetNaveViaje;

      ObservableCollection<Det_Cotizacion_OV_Flete> m_listItemsFlete;
      ObservableCollection<Det_Cotizacion_OV_Flete> m_listItemsFleteDeleted;
      ObservableCollection<Det_Cotizacion_OV_Servicio> m_listItemsServicio;
        ObservableCollection<Det_Cotizacion_OV_Servicio> m_listItemsSeguro;
      ObservableCollection<Det_Cotizacion_OV_Servicio> m_listItemsServicioDeleted;
        ObservableCollection<Det_Cotizacion_OV_Servicio> m_listItemsSeguroDeleted;
        ObservableCollection<Det_Cotizacion_OV_Archivo> m_listItemsArchivo;
      ObservableCollection<Det_Cotizacion_OV_Archivo> m_listItemsArchivoDeleted;
      ObservableCollection<Det_Cotizacion_OV_Documento> m_listItemsDocumento;
      ObservableCollection<Det_Cotizacion_OV_Documento> m_listItemsDocumentoDeleted;
      ObservableCollection<Det_Cotizacion_OV_Novedad> m_listItemsNovedad;
      ObservableCollection<Det_Cotizacion_OV_Novedad> m_listItemsNovedadDeleted;
      ObservableCollection<Det_Cotizacion_OV_EventosTareas> m_ItemsEventosTareas;
      ObservableCollection<Det_Cotizacion_OV_EventosTareas> m_ItemsEventosTareasDeleted;

      ObservableCollection<Det_Cotizacion_OV_Servicio> m_listItemsServicioChangeControl;
      ObservableCollection<Det_Cotizacion_OV_Servicio> m_listItemsServicioChangeControlDeleted;

      ObservableCollection<Det_CNTR> m_listItemsDet_CNTR;
      ObservableCollection<Det_CNTR> m_listItemsDet_CNTRDeleted;

      Cab_MBL m_itemCab_MBL;

      ObservableCollection<Anexos> m_listItemsAnexos;
      ObservableCollection<Anexos> m_listItemsAnexosDeleted;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Contrato.
		/// </summary>
		[DataMember]
		public Contrato ItemContrato
		{
			get { return  m_itemContrato; }
			set {  m_itemContrato = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Contrato.
		/// </summary>
		[DataMember]
		public ObservableCollection<Contrato> ListContrato
		{
			get { return  m_listContrato; }
			set {  m_listContrato = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Empresa.
		/// </summary>
		[DataMember]
		public Empresa ItemEmpresa
		{
			get { return  m_itemEmpresa; }
			set {  m_itemEmpresa = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Empresa.
		/// </summary>
		[DataMember]
		public ObservableCollection<Empresa> ListEmpresa
		{
			get { return  m_listEmpresa; }
			set {  m_listEmpresa = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Sucursales.
		/// </summary>
		[DataMember]
		public Sucursales ItemSucursales
		{
			get { return  m_itemSucursales; }
			set {  m_itemSucursales = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Sucursales.
		/// </summary>
		[DataMember]
		public ObservableCollection<Sucursales> ListSucursales
		{
			get { return  m_listSucursales; }
			set {  m_listSucursales = value; }
		}

      /// <summary>
      /// Gets or sets el valor de: ItemNave.
      /// </summary>
      [DataMember]
      public Nave ItemNave
      {
         get { return m_itemNave; }
         set { m_itemNave = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ItemNaveViaje.
      /// </summary>
      [DataMember]
      public NaveViaje ItemNaveViaje
      {
         get { return m_itemNaveViaje; }
         set { m_itemNaveViaje = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ItemDetNaveViaje.
      /// </summary>
      [DataMember]
      public DetNaveViaje ItemDetNaveViaje
      {
         get { return m_itemDetNaveViaje; }
         set { m_itemDetNaveViaje = value; }
      }
      
      /// <summary>
      /// Gets or sets el valor de: ItemsFlete.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_Cotizacion_OV_Flete> ItemsFlete
      {
         get
         {
            if (m_listItemsFlete == null) { m_listItemsFlete = new ObservableCollection<Det_Cotizacion_OV_Flete>(); }
            return m_listItemsFlete;
         }
         set { m_listItemsFlete = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ItemsFleteDeleted.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_Cotizacion_OV_Flete> ItemsFleteDeleted
      {
         get
         {
            if (m_listItemsFleteDeleted == null) { m_listItemsFleteDeleted = new ObservableCollection<Det_Cotizacion_OV_Flete>(); }
            return m_listItemsFleteDeleted;
         }
         set { m_listItemsFleteDeleted = value; }
      }
      
      /// <summary>
      /// Gets or sets el valor de: ItemsServicio.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_Cotizacion_OV_Servicio> ItemsServicio
      {
         get
         {
            if (m_listItemsServicio == null) { m_listItemsServicio = new ObservableCollection<Det_Cotizacion_OV_Servicio>(); }
            return m_listItemsServicio;
         }
         set { m_listItemsServicio = value; }
      }

        /// <summary>
        /// Gets or sets el valor de: ItemsSeguro.
        /// </summary>
        [DataMember]
        public ObservableCollection<Det_Cotizacion_OV_Servicio> ItemsSeguro
        {
            get
            {
                if (m_listItemsSeguro == null) { m_listItemsSeguro = new ObservableCollection<Det_Cotizacion_OV_Servicio>(); }
                return m_listItemsSeguro;
            }
            set { m_listItemsSeguro = value; }
        }

        /// <summary>
        /// Gets or sets el valor de: ItemsServicioDeleted.
        /// </summary>
        [DataMember]
        public ObservableCollection<Det_Cotizacion_OV_Servicio> ItemsServicioDeleted
        {
            get
            {
                if (m_listItemsServicioDeleted == null) { m_listItemsServicioDeleted = new ObservableCollection<Det_Cotizacion_OV_Servicio>(); }
                return m_listItemsServicioDeleted;
            }
            set { m_listItemsServicioDeleted = value; }
        }

        /// <summary>
        /// Gets or sets el valor de: ItemsSeguroDeleted.
        /// </summary>
        [DataMember]
        public ObservableCollection<Det_Cotizacion_OV_Servicio> ItemsSeguroDeleted
        {
            get
            {
                if (m_listItemsSeguroDeleted == null) { m_listItemsSeguroDeleted = new ObservableCollection<Det_Cotizacion_OV_Servicio>(); }
                return m_listItemsSeguroDeleted;
            }
            set { m_listItemsSeguroDeleted = value; }
        }
        
        /// <summary>
        /// Gets or sets el valor de: ItemsArchivo.
        /// </summary>
        [DataMember]
      public ObservableCollection<Det_Cotizacion_OV_Archivo> ItemsArchivo
      {
         get
         {
            if (m_listItemsArchivo == null) { m_listItemsArchivo = new ObservableCollection<Det_Cotizacion_OV_Archivo>(); }
            return m_listItemsArchivo;
         }
         set { m_listItemsArchivo = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ItemsArchivoDeleted.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_Cotizacion_OV_Archivo> ItemsArchivoDeleted
      {
         get
         {
            if (m_listItemsArchivoDeleted == null) { m_listItemsArchivoDeleted = new ObservableCollection<Det_Cotizacion_OV_Archivo>(); }
            return m_listItemsArchivoDeleted;
         }
         set { m_listItemsArchivoDeleted = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ItemsDocumento.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_Cotizacion_OV_Documento> ItemsDocumento
      {
         get
         {
            if (m_listItemsDocumento == null) { m_listItemsDocumento = new ObservableCollection<Det_Cotizacion_OV_Documento>(); }
            return m_listItemsDocumento;
         }
         set { m_listItemsDocumento = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ItemsDocumentoDeleted.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_Cotizacion_OV_Documento> ItemsDocumentoDeleted
      {
         get
         {
            if (m_listItemsDocumentoDeleted == null) { m_listItemsDocumentoDeleted = new ObservableCollection<Det_Cotizacion_OV_Documento>(); }
            return m_listItemsDocumentoDeleted;
         }
         set { m_listItemsDocumentoDeleted = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ItemsFlete.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_Cotizacion_OV_Novedad> ItemsNovedad
      {
         get
         {
            if (m_listItemsNovedad == null) { m_listItemsNovedad = new ObservableCollection<Det_Cotizacion_OV_Novedad>(); }
            return m_listItemsNovedad;
         }
         set { m_listItemsNovedad = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ItemsNovedadDeleted.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_Cotizacion_OV_Novedad> ItemsNovedadDeleted
      {
         get
         {
            if (m_listItemsNovedadDeleted == null) { m_listItemsNovedadDeleted = new ObservableCollection<Det_Cotizacion_OV_Novedad>(); }
            return m_listItemsNovedadDeleted;
         }
         set { m_listItemsNovedadDeleted = value; }
      }

      /// <summary>
      /// Gets or sets el valor de: ItemsFlete.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_Cotizacion_OV_EventosTareas> ItemsEventosTareas
      {
         get
         {
            if (m_ItemsEventosTareas == null) { m_ItemsEventosTareas = new ObservableCollection<Det_Cotizacion_OV_EventosTareas>(); }
            return m_ItemsEventosTareas;
         }
         set { m_ItemsEventosTareas = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ItemsNovedadDeleted.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_Cotizacion_OV_EventosTareas> ItemsEventosTareasDeleted
      {
         get
         {
            if (m_ItemsEventosTareasDeleted == null) { m_ItemsEventosTareasDeleted = new ObservableCollection<Det_Cotizacion_OV_EventosTareas>(); }
            return m_ItemsEventosTareasDeleted;
         }
         set { m_ItemsEventosTareasDeleted = value; }
      }

      /// <summary>
      /// Gets or sets el valor de: ItemsServicioChangeControl.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_Cotizacion_OV_Servicio> ItemsServicioChangeControl
      {
         get
         {
            if (m_listItemsServicioChangeControl == null) { m_listItemsServicioChangeControl = new ObservableCollection<Det_Cotizacion_OV_Servicio>(); }
            return m_listItemsServicioChangeControl;
         }
         set { m_listItemsServicioChangeControl = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ItemsServicioChangeControlDeleted.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_Cotizacion_OV_Servicio> ItemsServicioChangeControlDeleted
      {
         get
         {
            if (m_listItemsServicioChangeControlDeleted == null) { m_listItemsServicioChangeControlDeleted = new ObservableCollection<Det_Cotizacion_OV_Servicio>(); }
            return m_listItemsServicioChangeControlDeleted;
         }
         set { m_listItemsServicioChangeControlDeleted = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ItemsDet_CNTR.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_CNTR> ItemsDet_CNTR
      {
         get
         {
            if (m_listItemsDet_CNTR == null) { m_listItemsDet_CNTR = new ObservableCollection<Det_CNTR>(); }
            return m_listItemsDet_CNTR;
         }
         set { m_listItemsDet_CNTR = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ItemsDet_CNTRDeleted.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_CNTR> ItemsDet_CNTRDeleted
      {
         get
         {
            if (m_listItemsDet_CNTRDeleted == null) { m_listItemsDet_CNTRDeleted = new ObservableCollection<Det_CNTR>(); }
            return m_listItemsDet_CNTRDeleted;
         }
         set { m_listItemsDet_CNTRDeleted = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ItemsAnexos.
      /// </summary>
      [DataMember]
      public ObservableCollection<Anexos> ItemsAnexos
      {
         get
         {
            if (m_listItemsAnexos == null) { m_listItemsAnexos = new ObservableCollection<Anexos>(); }
            return m_listItemsAnexos;
         }
         set { m_listItemsAnexos = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ItemsAnexosDeleted.
      /// </summary>
      [DataMember]
      public ObservableCollection<Anexos> ItemsAnexosDeleted
      {
         get
         {
            if (m_listItemsAnexosDeleted == null) { m_listItemsAnexosDeleted = new ObservableCollection<Anexos>(); }
            return m_listItemsAnexosDeleted;
         }
         set { m_listItemsAnexosDeleted = value; }
      }

      /// <summary>
      /// Gets or sets el valor de: ItemsAnexosDeleted.
      /// </summary>
      [DataMember]
      public Cab_MBL ItemCab_MBL
      {
         get { return m_itemCab_MBL; }
         set {
            if (m_itemCab_MBL != value)
            { m_itemCab_MBL = value; }
         }
      }
      
      #endregion
	}
}
