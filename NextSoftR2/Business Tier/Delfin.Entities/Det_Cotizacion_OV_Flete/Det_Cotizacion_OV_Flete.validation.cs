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
	public partial class Det_Cotizacion_OV_Flete
	{
		#region [ Variables Validación ]
		private Boolean m_ccot_numeroOK;
		private String m_ccot_numeroMSGERROR;
		private Boolean m_dcot_itemOK;
		private String m_dcot_itemMSGERROR;
		private Boolean m_ccot_tipoOK;
		private String m_ccot_tipoMSGERROR;
		private Boolean m_pack_codigoOK;
		private String m_pack_codigoMSGERROR;
		private Boolean m_dcot_productoOK;
		private String m_dcot_productoMSGERROR;
		private Boolean m_dcot_cantidadOK;
		private String m_dcot_cantidadMSGERROR;
		private Boolean m_dcot_preciounicostoOK;
		private String m_dcot_preciounicostoMSGERROR;
		private Boolean m_dcot_totalunicostoOK;
		private String m_dcot_totalunicostoMSGERROR;
		private Boolean m_dcot_totaluniventaOK;
		private String m_dcot_totaluniventaMSGERROR;
		private Boolean m_dcot_preciouniventaOK;
		private String m_dcot_preciouniventaMSGERROR;
		private Boolean m_dcot_importeOK;
		private String m_dcot_importeMSGERROR;
		private Boolean m_dcot_pesoOK;
		private String m_dcot_pesoMSGERROR;
		private Boolean m_dcot_volumenOK;
		private String m_dcot_volumenMSGERROR;
		private Boolean m_dcot_bultosOK;
		private String m_dcot_bultosMSGERROR;
		private Boolean m_dcot_largoOK;
		private String m_dcot_largoMSGERROR;
		private Boolean m_dcot_anchoOK;
		private String m_dcot_anchoMSGERROR;
		private Boolean m_dcot_altoOK;
		private String m_dcot_altoMSGERROR;
		private Boolean m_tipo_tabunmOK;
		private String m_tipo_tabunmMSGERROR;
		private Boolean m_tipo_codunmOK;
		private String m_tipo_codunmMSGERROR;
		private Boolean m_tipo_tabcdtOK;
		private String m_tipo_tabcdtMSGERROR;
		private Boolean m_tipo_codcdtOK;
		private String m_tipo_codcdtMSGERROR;
		private Boolean m_tari_codigoOK;
		private String m_tari_codigoMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		private Boolean m_serv_codigoOK;
		private String m_serv_codigoMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public Boolean CCOT_NumeroOK
		{
			get { return m_ccot_numeroOK; }
			set
			{
				if (m_ccot_numeroOK != value)
				{
					m_ccot_numeroOK = value;
					OnPropertyChanged("CCOT_NumeroOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public String CCOT_NumeroMSGERROR
		{
			get { return m_ccot_numeroMSGERROR; }
			set
			{
				if (m_ccot_numeroMSGERROR != value)
				{
					m_ccot_numeroMSGERROR = value;
					OnPropertyChanged("CCOT_NumeroMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_Item.
		/// </summary>
		[DataMember]
		public Boolean DCOT_ItemOK
		{
			get { return m_dcot_itemOK; }
			set
			{
				if (m_dcot_itemOK != value)
				{
					m_dcot_itemOK = value;
					OnPropertyChanged("DCOT_ItemOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_Item.
		/// </summary>
		[DataMember]
		public String DCOT_ItemMSGERROR
		{
			get { return m_dcot_itemMSGERROR; }
			set
			{
				if (m_dcot_itemMSGERROR != value)
				{
					m_dcot_itemMSGERROR = value;
					OnPropertyChanged("DCOT_ItemMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public Boolean CCOT_TipoOK
		{
			get { return m_ccot_tipoOK; }
			set
			{
				if (m_ccot_tipoOK != value)
				{
					m_ccot_tipoOK = value;
					OnPropertyChanged("CCOT_TipoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public String CCOT_TipoMSGERROR
		{
			get { return m_ccot_tipoMSGERROR; }
			set
			{
				if (m_ccot_tipoMSGERROR != value)
				{
					m_ccot_tipoMSGERROR = value;
					OnPropertyChanged("CCOT_TipoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public Boolean PACK_CodigoOK
		{
			get { return m_pack_codigoOK; }
			set
			{
				if (m_pack_codigoOK != value)
				{
					m_pack_codigoOK = value;
					OnPropertyChanged("PACK_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public String PACK_CodigoMSGERROR
		{
			get { return m_pack_codigoMSGERROR; }
			set
			{
				if (m_pack_codigoMSGERROR != value)
				{
					m_pack_codigoMSGERROR = value;
					OnPropertyChanged("PACK_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_Producto.
		/// </summary>
		[DataMember]
		public Boolean DCOT_ProductoOK
		{
			get { return m_dcot_productoOK; }
			set
			{
				if (m_dcot_productoOK != value)
				{
					m_dcot_productoOK = value;
					OnPropertyChanged("DCOT_ProductoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_Producto.
		/// </summary>
		[DataMember]
		public String DCOT_ProductoMSGERROR
		{
			get { return m_dcot_productoMSGERROR; }
			set
			{
				if (m_dcot_productoMSGERROR != value)
				{
					m_dcot_productoMSGERROR = value;
					OnPropertyChanged("DCOT_ProductoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_Cantidad.
		/// </summary>
		[DataMember]
		public Boolean DCOT_CantidadOK
		{
			get { return m_dcot_cantidadOK; }
			set
			{
				if (m_dcot_cantidadOK != value)
				{
					m_dcot_cantidadOK = value;
					OnPropertyChanged("DCOT_CantidadOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_Cantidad.
		/// </summary>
		[DataMember]
		public String DCOT_CantidadMSGERROR
		{
			get { return m_dcot_cantidadMSGERROR; }
			set
			{
				if (m_dcot_cantidadMSGERROR != value)
				{
					m_dcot_cantidadMSGERROR = value;
					OnPropertyChanged("DCOT_CantidadMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_PrecioUniCosto.
		/// </summary>
		[DataMember]
		public Boolean DCOT_PrecioUniCostoOK
		{
			get { return m_dcot_preciounicostoOK; }
			set
			{
				if (m_dcot_preciounicostoOK != value)
				{
					m_dcot_preciounicostoOK = value;
					OnPropertyChanged("DCOT_PrecioUniCostoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_PrecioUniCosto.
		/// </summary>
		[DataMember]
		public String DCOT_PrecioUniCostoMSGERROR
		{
			get { return m_dcot_preciounicostoMSGERROR; }
			set
			{
				if (m_dcot_preciounicostoMSGERROR != value)
				{
					m_dcot_preciounicostoMSGERROR = value;
					OnPropertyChanged("DCOT_PrecioUniCostoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_TotalUniCosto.
		/// </summary>
		[DataMember]
		public Boolean DCOT_TotalUniCostoOK
		{
			get { return m_dcot_totalunicostoOK; }
			set
			{
				if (m_dcot_totalunicostoOK != value)
				{
					m_dcot_totalunicostoOK = value;
					OnPropertyChanged("DCOT_TotalUniCostoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_TotalUniCosto.
		/// </summary>
		[DataMember]
		public String DCOT_TotalUniCostoMSGERROR
		{
			get { return m_dcot_totalunicostoMSGERROR; }
			set
			{
				if (m_dcot_totalunicostoMSGERROR != value)
				{
					m_dcot_totalunicostoMSGERROR = value;
					OnPropertyChanged("DCOT_TotalUniCostoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_TotalUniVenta.
		/// </summary>
		[DataMember]
		public Boolean DCOT_TotalUniVentaOK
		{
			get { return m_dcot_totaluniventaOK; }
			set
			{
				if (m_dcot_totaluniventaOK != value)
				{
					m_dcot_totaluniventaOK = value;
					OnPropertyChanged("DCOT_TotalUniVentaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_TotalUniVenta.
		/// </summary>
		[DataMember]
		public String DCOT_TotalUniVentaMSGERROR
		{
			get { return m_dcot_totaluniventaMSGERROR; }
			set
			{
				if (m_dcot_totaluniventaMSGERROR != value)
				{
					m_dcot_totaluniventaMSGERROR = value;
					OnPropertyChanged("DCOT_TotalUniVentaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_PrecioUniVenta.
		/// </summary>
		[DataMember]
		public Boolean DCOT_PrecioUniVentaOK
		{
			get { return m_dcot_preciouniventaOK; }
			set
			{
				if (m_dcot_preciouniventaOK != value)
				{
					m_dcot_preciouniventaOK = value;
					OnPropertyChanged("DCOT_PrecioUniVentaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_PrecioUniVenta.
		/// </summary>
		[DataMember]
		public String DCOT_PrecioUniVentaMSGERROR
		{
			get { return m_dcot_preciouniventaMSGERROR; }
			set
			{
				if (m_dcot_preciouniventaMSGERROR != value)
				{
					m_dcot_preciouniventaMSGERROR = value;
					OnPropertyChanged("DCOT_PrecioUniVentaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_Importe.
		/// </summary>
		[DataMember]
		public Boolean DCOT_ImporteOK
		{
			get { return m_dcot_importeOK; }
			set
			{
				if (m_dcot_importeOK != value)
				{
					m_dcot_importeOK = value;
					OnPropertyChanged("DCOT_ImporteOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_Importe.
		/// </summary>
		[DataMember]
		public String DCOT_ImporteMSGERROR
		{
			get { return m_dcot_importeMSGERROR; }
			set
			{
				if (m_dcot_importeMSGERROR != value)
				{
					m_dcot_importeMSGERROR = value;
					OnPropertyChanged("DCOT_ImporteMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_Peso.
		/// </summary>
		[DataMember]
		public Boolean DCOT_PesoOK
		{
			get { return m_dcot_pesoOK; }
			set
			{
				if (m_dcot_pesoOK != value)
				{
					m_dcot_pesoOK = value;
					OnPropertyChanged("DCOT_PesoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_Peso.
		/// </summary>
		[DataMember]
		public String DCOT_PesoMSGERROR
		{
			get { return m_dcot_pesoMSGERROR; }
			set
			{
				if (m_dcot_pesoMSGERROR != value)
				{
					m_dcot_pesoMSGERROR = value;
					OnPropertyChanged("DCOT_PesoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_Volumen.
		/// </summary>
		[DataMember]
		public Boolean DCOT_VolumenOK
		{
			get { return m_dcot_volumenOK; }
			set
			{
				if (m_dcot_volumenOK != value)
				{
					m_dcot_volumenOK = value;
					OnPropertyChanged("DCOT_VolumenOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_Volumen.
		/// </summary>
		[DataMember]
		public String DCOT_VolumenMSGERROR
		{
			get { return m_dcot_volumenMSGERROR; }
			set
			{
				if (m_dcot_volumenMSGERROR != value)
				{
					m_dcot_volumenMSGERROR = value;
					OnPropertyChanged("DCOT_VolumenMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_Bultos.
		/// </summary>
		[DataMember]
		public Boolean DCOT_BultosOK
		{
			get { return m_dcot_bultosOK; }
			set
			{
				if (m_dcot_bultosOK != value)
				{
					m_dcot_bultosOK = value;
					OnPropertyChanged("DCOT_BultosOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_Bultos.
		/// </summary>
		[DataMember]
		public String DCOT_BultosMSGERROR
		{
			get { return m_dcot_bultosMSGERROR; }
			set
			{
				if (m_dcot_bultosMSGERROR != value)
				{
					m_dcot_bultosMSGERROR = value;
					OnPropertyChanged("DCOT_BultosMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_Largo.
		/// </summary>
		[DataMember]
		public Boolean DCOT_LargoOK
		{
			get { return m_dcot_largoOK; }
			set
			{
				if (m_dcot_largoOK != value)
				{
					m_dcot_largoOK = value;
					OnPropertyChanged("DCOT_LargoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_Largo.
		/// </summary>
		[DataMember]
		public String DCOT_LargoMSGERROR
		{
			get { return m_dcot_largoMSGERROR; }
			set
			{
				if (m_dcot_largoMSGERROR != value)
				{
					m_dcot_largoMSGERROR = value;
					OnPropertyChanged("DCOT_LargoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_Ancho.
		/// </summary>
		[DataMember]
		public Boolean DCOT_AnchoOK
		{
			get { return m_dcot_anchoOK; }
			set
			{
				if (m_dcot_anchoOK != value)
				{
					m_dcot_anchoOK = value;
					OnPropertyChanged("DCOT_AnchoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_Ancho.
		/// </summary>
		[DataMember]
		public String DCOT_AnchoMSGERROR
		{
			get { return m_dcot_anchoMSGERROR; }
			set
			{
				if (m_dcot_anchoMSGERROR != value)
				{
					m_dcot_anchoMSGERROR = value;
					OnPropertyChanged("DCOT_AnchoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_Alto.
		/// </summary>
		[DataMember]
		public Boolean DCOT_AltoOK
		{
			get { return m_dcot_altoOK; }
			set
			{
				if (m_dcot_altoOK != value)
				{
					m_dcot_altoOK = value;
					OnPropertyChanged("DCOT_AltoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_Alto.
		/// </summary>
		[DataMember]
		public String DCOT_AltoMSGERROR
		{
			get { return m_dcot_altoMSGERROR; }
			set
			{
				if (m_dcot_altoMSGERROR != value)
				{
					m_dcot_altoMSGERROR = value;
					OnPropertyChanged("DCOT_AltoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabUnm.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabUnmOK
		{
			get { return m_tipo_tabunmOK; }
			set
			{
				if (m_tipo_tabunmOK != value)
				{
					m_tipo_tabunmOK = value;
					OnPropertyChanged("TIPO_TabUnmOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabUnm.
		/// </summary>
		[DataMember]
		public String TIPO_TabUnmMSGERROR
		{
			get { return m_tipo_tabunmMSGERROR; }
			set
			{
				if (m_tipo_tabunmMSGERROR != value)
				{
					m_tipo_tabunmMSGERROR = value;
					OnPropertyChanged("TIPO_TabUnmMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodUnm.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodUnmOK
		{
			get { return m_tipo_codunmOK; }
			set
			{
				if (m_tipo_codunmOK != value)
				{
					m_tipo_codunmOK = value;
					OnPropertyChanged("TIPO_CodUnmOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodUnm.
		/// </summary>
		[DataMember]
		public String TIPO_CodUnmMSGERROR
		{
			get { return m_tipo_codunmMSGERROR; }
			set
			{
				if (m_tipo_codunmMSGERROR != value)
				{
					m_tipo_codunmMSGERROR = value;
					OnPropertyChanged("TIPO_CodUnmMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabCDT.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabCDTOK
		{
			get { return m_tipo_tabcdtOK; }
			set
			{
				if (m_tipo_tabcdtOK != value)
				{
					m_tipo_tabcdtOK = value;
					OnPropertyChanged("TIPO_TabCDTOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabCDT.
		/// </summary>
		[DataMember]
		public String TIPO_TabCDTMSGERROR
		{
			get { return m_tipo_tabcdtMSGERROR; }
			set
			{
				if (m_tipo_tabcdtMSGERROR != value)
				{
					m_tipo_tabcdtMSGERROR = value;
					OnPropertyChanged("TIPO_TabCDTMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodCDT.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodCDTOK
		{
			get { return m_tipo_codcdtOK; }
			set
			{
				if (m_tipo_codcdtOK != value)
				{
					m_tipo_codcdtOK = value;
					OnPropertyChanged("TIPO_CodCDTOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodCDT.
		/// </summary>
		[DataMember]
		public String TIPO_CodCDTMSGERROR
		{
			get { return m_tipo_codcdtMSGERROR; }
			set
			{
				if (m_tipo_codcdtMSGERROR != value)
				{
					m_tipo_codcdtMSGERROR = value;
					OnPropertyChanged("TIPO_CodCDTMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TARI_Codigo.
		/// </summary>
		[DataMember]
		public Boolean TARI_CodigoOK
		{
			get { return m_tari_codigoOK; }
			set
			{
				if (m_tari_codigoOK != value)
				{
					m_tari_codigoOK = value;
					OnPropertyChanged("TARI_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARI_Codigo.
		/// </summary>
		[DataMember]
		public String TARI_CodigoMSGERROR
		{
			get { return m_tari_codigoMSGERROR; }
			set
			{
				if (m_tari_codigoMSGERROR != value)
				{
					m_tari_codigoMSGERROR = value;
					OnPropertyChanged("TARI_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SERV_Codigo.
		/// </summary>
		[DataMember]
		public Boolean SERV_CodigoOK
		{
			get { return m_serv_codigoOK; }
			set
			{
				if (m_serv_codigoOK != value)
				{
					m_serv_codigoOK = value;
					OnPropertyChanged("SERV_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SERV_Codigo.
		/// </summary>
		[DataMember]
		public String SERV_CodigoMSGERROR
		{
			get { return m_serv_codigoMSGERROR; }
			set
			{
				if (m_serv_codigoMSGERROR != value)
				{
					m_serv_codigoMSGERROR = value;
					OnPropertyChanged("SERV_CodigoMSGERROR");
				}
			}
		}
		#endregion

		#region [ Validacion ]
		private String m_mensajeError;
		
		[DataMember]
		public String MensajeError
		{
			get { return m_mensajeError; }
		}
      public Boolean ValidarFlete(ref Boolean _FleteNegativo, int _CCOT_Tipo, string _FCLLCL, String CONS_CodRGM, String CCOT_PagoMBL, String CCOT_PagoHBL)
        {
            try
            {
                Boolean _isCorrect = true;
                m_mensajeError = "";
                CCOT_NumeroOK = true;
                CCOT_NumeroMSGERROR = "";
                //if( CCOT_Numero == null)
                //{
                //   _isCorrect = false;
                //   CCOT_NumeroOK  = false;
                //   CCOT_NumeroMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Numero", "Det_Cotizacion_OV_Flete");
                //   m_mensajeError += "* Debe ingresar el campo CCOT_Numero" + Environment.NewLine;
                //}
                DCOT_ItemOK = true;
                DCOT_ItemMSGERROR = "";
                if (DCOT_Item == null)
                {
                    _isCorrect = false;
                    DCOT_ItemOK = false;
                    DCOT_ItemMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Item", "Det_Cotizacion_OV_Flete");
                    m_mensajeError += "* Debe ingresar el campo Item" + Environment.NewLine;
                }
                CCOT_TipoOK = true;
                CCOT_TipoMSGERROR = "";
                //if( CCOT_Tipo == null)
                //{
                //   _isCorrect = false;
                //   CCOT_TipoOK  = false;
                //   CCOT_TipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Tipo", "Det_Cotizacion_OV_Flete");
                //   m_mensajeError += "* Debe ingresar el campo CCOT_Tipo" + Environment.NewLine;
                //}
                PACK_CodigoOK = true;
                PACK_CodigoMSGERROR = "";
                if (PACK_Codigo == null)
                {
                    _isCorrect = false;
                    PACK_CodigoOK = false;
                    PACK_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo Paquete", "Det_Cotizacion_OV_Flete");
                    m_mensajeError += "* Debe ingresar el campo Tipo Paquete" + Environment.NewLine;
                }
                DCOT_CantidadOK = true;
                DCOT_CantidadMSGERROR = "";
                if (DCOT_Cantidad == null)
                {
                    _isCorrect = false;
                    DCOT_CantidadOK = false;
                    DCOT_CantidadMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Cantidad", "Det_Cotizacion_OV_Flete");
                    m_mensajeError += "* Debe ingresar el campo Cantidad" + Environment.NewLine;
                }
                DCOT_ProductoOK = true;
                DCOT_ProductoMSGERROR = "";
                //if (String.IsNullOrEmpty(DCOT_Producto))
                //{
                //   _isCorrect = false;
                //   DCOT_ProductoOK = false;
                //   DCOT_ProductoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Producto", "Det_Cotizacion_OV_Flete");
                //   m_mensajeError += "* Debe ingresar el campo Producto" + Environment.NewLine;
                //}
                DCOT_PrecioUniCostoOK = true;
                DCOT_PrecioUniCostoMSGERROR = "";
                if (DCOT_PrecioUniCosto == null)
                {
                   _isCorrect = false;
                   DCOT_PrecioUniCostoOK = false;
                   DCOT_PrecioUniCostoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Precio Unitario Costo", "Det_Cotizacion_OV_Flete");
                   m_mensajeError += "* Debe ingresar el campo Precio Unitario Costo" + Environment.NewLine;
                }
                else if (DCOT_PrecioUniCosto == 0 && CCOT_PagoMBL.Equals("C") && (CCOT_PagoHBL.Equals("C") || (CCOT_PagoHBL.Equals("P"))) && CONS_CodRGM.Equals("001"))
                {
                   _isCorrect = false;
                   DCOT_PrecioUniCostoOK = false;
                   DCOT_PrecioUniCostoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Precio Unitario Costo", "Det_Cotizacion_OV_Flete");
                   m_mensajeError += "* Debe ingresar el campo Precio Unitario Costo" + Environment.NewLine;
                }

                else if (DCOT_PrecioUniCosto == 0 && CCOT_PagoMBL.Equals("P") && (CCOT_PagoHBL.Equals("C") || (CCOT_PagoHBL.Equals("P"))) && CONS_CodRGM.Equals("002"))
                {
                   _isCorrect = false;
                   DCOT_PrecioUniCostoOK = false;
                   DCOT_PrecioUniCostoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Precio Unitario Costo", "Det_Cotizacion_OV_Flete");
                   m_mensajeError += "* Debe ingresar el campo Precio Unitario Costo" + Environment.NewLine;
                }


                DCOT_PrecioUniVentaOK = true;
                DCOT_PrecioUniVentaMSGERROR = "";
                if (DCOT_PrecioUniVenta == null)
                {
                    _isCorrect = false;
                    DCOT_PrecioUniVentaOK = false;
                    DCOT_PrecioUniVentaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Precio Unitario Venta", "Det_Cotizacion_OV_Flete");
                    m_mensajeError += "* Debe ingresar el campo Precio Unitario Venta" + Environment.NewLine;
                }
                else if (DCOT_PrecioUniVenta == 0 && CCOT_PagoHBL.Equals("C") && (CCOT_PagoMBL.Equals("C") || (CCOT_PagoMBL.Equals("P"))) && CONS_CodRGM.Equals("001"))
                {
                   _isCorrect = false;
                   DCOT_PrecioUniVentaOK = false;
                   DCOT_PrecioUniVentaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Precio Unitario Venta", "Det_Cotizacion_OV_Flete");
                   m_mensajeError += "* Debe ingresar el campo Precio Unitario Venta" + Environment.NewLine;
                }
                else if (DCOT_PrecioUniVenta == 0 && CCOT_PagoHBL.Equals("P") && (CCOT_PagoMBL.Equals("C") || (CCOT_PagoMBL.Equals("P"))) && CONS_CodRGM.Equals("002"))
                {
                   _isCorrect = false;
                   DCOT_PrecioUniVentaOK = false;
                   DCOT_PrecioUniVentaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Precio Unitario Venta", "Det_Cotizacion_OV_Flete");
                   m_mensajeError += "* Debe ingresar el campo Precio Unitario Venta" + Environment.NewLine;
                }

                DCOT_PrecioUniVentaOK = true;
                DCOT_PrecioUniVentaMSGERROR = "";
                if (DCOT_PrecioUniVenta < (DCOT_PrecioUniCosto + (Decimal)50) && _CCOT_Tipo == 2 && _FCLLCL != "001")
                {
                    _FleteNegativo = true;
                    //_isCorrect = false;
                    //DCOT_PrecioUniVentaOK = false;
                    //DCOT_PrecioUniVentaMSGERROR = String.Format("Debe ingresar el {0} mayor al {1} de la {2}.", "Precio Unitario Venta", "Precio Unitario Costo", "Det_Cotizacion_OV_Flete");
                    //m_mensajeError += String.Format("* Debe ingresar el {0} mayor al {1} de la {2}.", "Precio Unitario Venta", "Precio Unitario Costo", "Det_Cotizacion_OV_Flete") + Environment.NewLine;
                }

                DCOT_TotalUniCostoOK = true;
                DCOT_TotalUniCostoMSGERROR = "";
                if (DCOT_TotalUniCosto == null)
                {
                    _isCorrect = false;
                    DCOT_TotalUniCostoOK = false;
                    DCOT_TotalUniCostoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Total Costo", "Det_Cotizacion_OV_Flete");
                    m_mensajeError += "* Debe ingresar el campo Total Costo" + Environment.NewLine;
                }
                DCOT_TotalUniVentaOK = true;
                DCOT_TotalUniVentaMSGERROR = "";
                if (DCOT_TotalUniVenta == null)
                {
                    _isCorrect = false;
                    DCOT_TotalUniVentaOK = false;
                    DCOT_TotalUniVentaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Total Venta", "Det_Cotizacion_OV_Flete");
                    m_mensajeError += "* Debe ingresar el campo Total Venta" + Environment.NewLine;
                }

                DCOT_TotalUniVentaOK = true;
                DCOT_TotalUniVentaMSGERROR = "";
                if (DCOT_TotalUniVenta < (DCOT_TotalUniCosto + (Decimal)50) && _CCOT_Tipo == 2 && _FCLLCL != "001")
                {
                    _FleteNegativo = true;
                //    _isCorrect = false;
                //    DCOT_TotalUniVentaOK = false;
                //    DCOT_TotalUniVentaMSGERROR = String.Format("Debe ingresar el {0} mayor al {1} de la {2}.", "Total Venta", "Total Costo", "Det_Cotizacion_OV_Flete");
                //    m_mensajeError += String.Format("* Debe ingresar el {0} mayor al {1} de la {2}.", "Total Venta", "Total Costo", "Det_Cotizacion_OV_Flete") + Environment.NewLine;
                }

                DCOT_ImporteOK = true;
                DCOT_ImporteMSGERROR = "";
                //if( DCOT_Importe == null)
                //{
                //   _isCorrect = false;
                //   DCOT_ImporteOK  = false;
                //   DCOT_ImporteMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCOT_Importe", "Det_Cotizacion_OV_Flete");
                //   m_mensajeError += "* Debe ingresar el campo DCOT_Importe" + Environment.NewLine;
                //}
                DCOT_BultosOK = true;
                DCOT_BultosMSGERROR = "";
                //if( DCOT_Bultos == null)
                //{
                //   _isCorrect = false;
                //   DCOT_BultosOK  = false;
                //   DCOT_BultosMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCOT_Bultos", "Det_Cotizacion_OV_Flete");
                //   m_mensajeError += "* Debe ingresar el campo DCOT_Bultos" + Environment.NewLine;
                //}
                OnPropertyChanged("MensajeError");
                return _isCorrect;
            }
            catch (Exception ex)
            { throw ex; }
        }
      public Boolean ValidarEmbarque()
      {
         try
         {
            Boolean _isCorrect = true;
            m_mensajeError = "";
            CCOT_NumeroOK = true;
            CCOT_NumeroMSGERROR = "";
            //if( CCOT_Numero == null)
            //{
            //   _isCorrect = false;
            //   CCOT_NumeroOK  = false;
            //   CCOT_NumeroMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Numero", "Det_Cotizacion_OV_Flete");
            //   m_mensajeError += "* Debe ingresar el campo CCOT_Numero" + Environment.NewLine;
            //}
            DCOT_ItemOK = true;
            DCOT_ItemMSGERROR = "";
            if (DCOT_Item == null)
            {
               _isCorrect = false;
               DCOT_ItemOK = false;
               DCOT_ItemMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Item", "Det_Cotizacion_OV_Flete");
               m_mensajeError += "* Debe ingresar el campo Item" + Environment.NewLine;
            }
            CCOT_TipoOK = true;
            CCOT_TipoMSGERROR = "";
            //if( CCOT_Tipo == null)
            //{
            //   _isCorrect = false;
            //   CCOT_TipoOK  = false;
            //   CCOT_TipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Tipo", "Det_Cotizacion_OV_Flete");
            //   m_mensajeError += "* Debe ingresar el campo CCOT_Tipo" + Environment.NewLine;
            //}
            PACK_CodigoOK = true;
            PACK_CodigoMSGERROR = "";
            //if (PACK_Codigo == null)
            //{
            //   _isCorrect = false;
            //   PACK_CodigoOK = false;
            //   PACK_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo Paquete", "Det_Cotizacion_OV_Flete");
            //   m_mensajeError += "* Debe ingresar el campo Tipo Paquete" + Environment.NewLine;
            //}
            DCOT_ProductoOK = true;
            DCOT_ProductoMSGERROR = "";
            if (String.IsNullOrEmpty(DCOT_Producto))
            {
               _isCorrect = false;
               DCOT_ProductoOK = false;
               DCOT_ProductoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Producto", "Det_Cotizacion_OV_Flete");
               m_mensajeError += "* Debe ingresar el campo Producto" + Environment.NewLine;
            }
            DCOT_PrecioUniCostoOK = true;
            DCOT_PrecioUniCostoMSGERROR = "";
            //if (DCOT_PrecioUniCosto == null)
            //{
            //   _isCorrect = false;
            //   DCOT_PrecioUniCostoOK = false;
            //   DCOT_PrecioUniCostoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "DCOT_PrecioUniCosto", "Det_Cotizacion_OV_Flete");
            //   m_mensajeError += "* Debe ingresar el campo DCOT_PrecioUniCosto" + Environment.NewLine;
            //}
            DCOT_TotalUniCostoOK = true;
            DCOT_TotalUniCostoMSGERROR = "";
            //if (DCOT_TotalUniCosto == null)
            //{
            //   _isCorrect = false;
            //   DCOT_TotalUniCostoOK = false;
            //   DCOT_TotalUniCostoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "DCOT_TotalUniCosto", "Det_Cotizacion_OV_Flete");
            //   m_mensajeError += "* Debe ingresar el campo DCOT_TotalUniCosto" + Environment.NewLine;
            //}
            DCOT_TotalUniVentaOK = true;
            DCOT_TotalUniVentaMSGERROR = "";
            //if (DCOT_TotalUniVenta == null)
            //{
            //   _isCorrect = false;
            //   DCOT_TotalUniVentaOK = false;
            //   DCOT_TotalUniVentaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "DCOT_TotalUniVenta", "Det_Cotizacion_OV_Flete");
            //   m_mensajeError += "* Debe ingresar el campo DCOT_TotalUniVenta" + Environment.NewLine;
            //}
            DCOT_PrecioUniVentaOK = true;
            DCOT_PrecioUniVentaMSGERROR = "";
            //if (DCOT_PrecioUniVenta == null)
            //{
            //   _isCorrect = false;
            //   DCOT_PrecioUniVentaOK = false;
            //   DCOT_PrecioUniVentaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "DCOT_PrecioUniVenta", "Det_Cotizacion_OV_Flete");
            //   m_mensajeError += "* Debe ingresar el campo DCOT_PrecioUniVenta" + Environment.NewLine;
            //}
            DCOT_ImporteOK = true;
            DCOT_ImporteMSGERROR = "";
            //if (DCOT_Importe == null)
            //{
            //   _isCorrect = false;
            //   DCOT_ImporteOK = false;
            //   DCOT_ImporteMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "DCOT_Importe", "Det_Cotizacion_OV_Flete");
            //   m_mensajeError += "* Debe ingresar el campo DCOT_Importe" + Environment.NewLine;
            //}
            DCOT_BultosOK = true;
            DCOT_BultosMSGERROR = "";
            if (DCOT_Bultos == null)
            {
               _isCorrect = false;
               DCOT_BultosOK = false;
               DCOT_BultosMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Bultos", "Det_Cotizacion_OV_Flete");
               m_mensajeError += "* Debe ingresar el campo Bultos" + Environment.NewLine;
            }
            OnPropertyChanged("MensajeError");
            return _isCorrect;
         }
         catch (Exception ex)
         { throw ex; }
      }
		#endregion
	}
}
