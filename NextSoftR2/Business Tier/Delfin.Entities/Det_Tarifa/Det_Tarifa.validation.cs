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
	public partial class Det_Tarifa
	{
		#region [ Variables Validación ]
		private Boolean m_dtar_itemOK;
		private String m_dtar_itemMSGERROR;
		private Boolean m_pack_codigoOK;
		private String m_pack_codigoMSGERROR;
		private Boolean m_ctar_codigoOK;
		private String m_ctar_codigoMSGERROR;
		private Boolean m_ctar_tipoOK;
		private String m_ctar_tipoMSGERROR;
		private Boolean m_dtar_costosadaOK;
		private String m_dtar_costosadaMSGERROR;
		private Boolean m_dtar_ventasadaOK;
		private String m_dtar_ventasadaMSGERROR;
		private Boolean m_dtar_ventaOK;
		private String m_dtar_ventaMSGERROR;
		private Boolean m_dtar_pesoOK;
		private String m_dtar_pesoMSGERROR;
		private Boolean m_dtar_volumenOK;
		private String m_dtar_volumenMSGERROR;
		private Boolean m_dtar_minimoOK;
		private String m_dtar_minimoMSGERROR;
		private Boolean m_cons_codbasOK;
		private String m_cons_codbasMSGERROR;
		private Boolean m_cons_tabbasOK;
		private String m_cons_tabbasMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		private Boolean m_tipo_tabzonOK;
		private String m_tipo_tabzonMSGERROR;
		private Boolean m_tipo_codzondestinoOK;
		private String m_tipo_codzondestinoMSGERROR;
		private Boolean m_tipo_codzonorigenOK;
		private String m_tipo_codzonorigenMSGERROR;
		private Boolean m_dtar_roundtripOK;
		private String m_dtar_roundtripMSGERROR;
		private Boolean m_dtar_costoOK;
		private String m_dtar_costoMSGERROR;
		private Boolean m_dtar_profitOK;
		private String m_dtar_profitMSGERROR;
		private Boolean m_dtar_profitminimoOK;
		private String m_dtar_profitminimoMSGERROR;
		private Boolean m_cons_codtraOK;
		private String m_cons_codtraMSGERROR;
		private Boolean m_cons_tabtraOK;
		private String m_cons_tabtraMSGERROR;
		private Boolean m_entc_codigoOK;
		private String m_entc_codigoMSGERROR;
		private Boolean m_tipe_codigoOK;
		private String m_tipe_codigoMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: DTAR_Item.
		/// </summary>
		[DataMember]
		public Boolean DTAR_ItemOK
		{
			get { return m_dtar_itemOK; }
			set
			{
				if (m_dtar_itemOK != value)
				{
					m_dtar_itemOK = value;
					OnPropertyChanged("DTAR_ItemOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAR_Item.
		/// </summary>
		[DataMember]
		public String DTAR_ItemMSGERROR
		{
			get { return m_dtar_itemMSGERROR; }
			set
			{
				if (m_dtar_itemMSGERROR != value)
				{
					m_dtar_itemMSGERROR = value;
					OnPropertyChanged("DTAR_ItemMSGERROR");
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
		/// Gets or sets el valor de validación de: CTAR_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CTAR_CodigoOK
		{
			get { return m_ctar_codigoOK; }
			set
			{
				if (m_ctar_codigoOK != value)
				{
					m_ctar_codigoOK = value;
					OnPropertyChanged("CTAR_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_Codigo.
		/// </summary>
		[DataMember]
		public String CTAR_CodigoMSGERROR
		{
			get { return m_ctar_codigoMSGERROR; }
			set
			{
				if (m_ctar_codigoMSGERROR != value)
				{
					m_ctar_codigoMSGERROR = value;
					OnPropertyChanged("CTAR_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CTAR_Tipo.
		/// </summary>
		[DataMember]
		public Boolean CTAR_TipoOK
		{
			get { return m_ctar_tipoOK; }
			set
			{
				if (m_ctar_tipoOK != value)
				{
					m_ctar_tipoOK = value;
					OnPropertyChanged("CTAR_TipoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_Tipo.
		/// </summary>
		[DataMember]
		public String CTAR_TipoMSGERROR
		{
			get { return m_ctar_tipoMSGERROR; }
			set
			{
				if (m_ctar_tipoMSGERROR != value)
				{
					m_ctar_tipoMSGERROR = value;
					OnPropertyChanged("CTAR_TipoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAR_CostoSada.
		/// </summary>
		[DataMember]
		public Boolean DTAR_CostoSadaOK
		{
			get { return m_dtar_costosadaOK; }
			set
			{
				if (m_dtar_costosadaOK != value)
				{
					m_dtar_costosadaOK = value;
					OnPropertyChanged("DTAR_CostoSadaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAR_CostoSada.
		/// </summary>
		[DataMember]
		public String DTAR_CostoSadaMSGERROR
		{
			get { return m_dtar_costosadaMSGERROR; }
			set
			{
				if (m_dtar_costosadaMSGERROR != value)
				{
					m_dtar_costosadaMSGERROR = value;
					OnPropertyChanged("DTAR_CostoSadaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAR_VentaSada.
		/// </summary>
		[DataMember]
		public Boolean DTAR_VentaSadaOK
		{
			get { return m_dtar_ventasadaOK; }
			set
			{
				if (m_dtar_ventasadaOK != value)
				{
					m_dtar_ventasadaOK = value;
					OnPropertyChanged("DTAR_VentaSadaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAR_VentaSada.
		/// </summary>
		[DataMember]
		public String DTAR_VentaSadaMSGERROR
		{
			get { return m_dtar_ventasadaMSGERROR; }
			set
			{
				if (m_dtar_ventasadaMSGERROR != value)
				{
					m_dtar_ventasadaMSGERROR = value;
					OnPropertyChanged("DTAR_VentaSadaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAR_Venta.
		/// </summary>
		[DataMember]
		public Boolean DTAR_VentaOK
		{
			get { return m_dtar_ventaOK; }
			set
			{
				if (m_dtar_ventaOK != value)
				{
					m_dtar_ventaOK = value;
					OnPropertyChanged("DTAR_VentaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAR_Venta.
		/// </summary>
		[DataMember]
		public String DTAR_VentaMSGERROR
		{
			get { return m_dtar_ventaMSGERROR; }
			set
			{
				if (m_dtar_ventaMSGERROR != value)
				{
					m_dtar_ventaMSGERROR = value;
					OnPropertyChanged("DTAR_VentaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAR_Peso.
		/// </summary>
		[DataMember]
		public Boolean DTAR_PesoOK
		{
			get { return m_dtar_pesoOK; }
			set
			{
				if (m_dtar_pesoOK != value)
				{
					m_dtar_pesoOK = value;
					OnPropertyChanged("DTAR_PesoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAR_Peso.
		/// </summary>
		[DataMember]
		public String DTAR_PesoMSGERROR
		{
			get { return m_dtar_pesoMSGERROR; }
			set
			{
				if (m_dtar_pesoMSGERROR != value)
				{
					m_dtar_pesoMSGERROR = value;
					OnPropertyChanged("DTAR_PesoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAR_Volumen.
		/// </summary>
		[DataMember]
		public Boolean DTAR_VolumenOK
		{
			get { return m_dtar_volumenOK; }
			set
			{
				if (m_dtar_volumenOK != value)
				{
					m_dtar_volumenOK = value;
					OnPropertyChanged("DTAR_VolumenOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAR_Volumen.
		/// </summary>
		[DataMember]
		public String DTAR_VolumenMSGERROR
		{
			get { return m_dtar_volumenMSGERROR; }
			set
			{
				if (m_dtar_volumenMSGERROR != value)
				{
					m_dtar_volumenMSGERROR = value;
					OnPropertyChanged("DTAR_VolumenMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAR_Minimo.
		/// </summary>
		[DataMember]
		public Boolean DTAR_MinimoOK
		{
			get { return m_dtar_minimoOK; }
			set
			{
				if (m_dtar_minimoOK != value)
				{
					m_dtar_minimoOK = value;
					OnPropertyChanged("DTAR_MinimoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAR_Minimo.
		/// </summary>
		[DataMember]
		public String DTAR_MinimoMSGERROR
		{
			get { return m_dtar_minimoMSGERROR; }
			set
			{
				if (m_dtar_minimoMSGERROR != value)
				{
					m_dtar_minimoMSGERROR = value;
					OnPropertyChanged("DTAR_MinimoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodBas.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodBasOK
		{
			get { return m_cons_codbasOK; }
			set
			{
				if (m_cons_codbasOK != value)
				{
					m_cons_codbasOK = value;
					OnPropertyChanged("CONS_CodBasOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodBas.
		/// </summary>
		[DataMember]
		public String CONS_CodBasMSGERROR
		{
			get { return m_cons_codbasMSGERROR; }
			set
			{
				if (m_cons_codbasMSGERROR != value)
				{
					m_cons_codbasMSGERROR = value;
					OnPropertyChanged("CONS_CodBasMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabBas.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabBasOK
		{
			get { return m_cons_tabbasOK; }
			set
			{
				if (m_cons_tabbasOK != value)
				{
					m_cons_tabbasOK = value;
					OnPropertyChanged("CONS_TabBasOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabBas.
		/// </summary>
		[DataMember]
		public String CONS_TabBasMSGERROR
		{
			get { return m_cons_tabbasMSGERROR; }
			set
			{
				if (m_cons_tabbasMSGERROR != value)
				{
					m_cons_tabbasMSGERROR = value;
					OnPropertyChanged("CONS_TabBasMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabZON.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabZONOK
		{
			get { return m_tipo_tabzonOK; }
			set
			{
				if (m_tipo_tabzonOK != value)
				{
					m_tipo_tabzonOK = value;
					OnPropertyChanged("TIPO_TabZONOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabZON.
		/// </summary>
		[DataMember]
		public String TIPO_TabZONMSGERROR
		{
			get { return m_tipo_tabzonMSGERROR; }
			set
			{
				if (m_tipo_tabzonMSGERROR != value)
				{
					m_tipo_tabzonMSGERROR = value;
					OnPropertyChanged("TIPO_TabZONMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodZONDestino.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodZONDestinoOK
		{
			get { return m_tipo_codzondestinoOK; }
			set
			{
				if (m_tipo_codzondestinoOK != value)
				{
					m_tipo_codzondestinoOK = value;
					OnPropertyChanged("TIPO_CodZONDestinoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodZONDestino.
		/// </summary>
		[DataMember]
		public String TIPO_CodZONDestinoMSGERROR
		{
			get { return m_tipo_codzondestinoMSGERROR; }
			set
			{
				if (m_tipo_codzondestinoMSGERROR != value)
				{
					m_tipo_codzondestinoMSGERROR = value;
					OnPropertyChanged("TIPO_CodZONDestinoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodZONOrigen.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodZONOrigenOK
		{
			get { return m_tipo_codzonorigenOK; }
			set
			{
				if (m_tipo_codzonorigenOK != value)
				{
					m_tipo_codzonorigenOK = value;
					OnPropertyChanged("TIPO_CodZONOrigenOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodZONOrigen.
		/// </summary>
		[DataMember]
		public String TIPO_CodZONOrigenMSGERROR
		{
			get { return m_tipo_codzonorigenMSGERROR; }
			set
			{
				if (m_tipo_codzonorigenMSGERROR != value)
				{
					m_tipo_codzonorigenMSGERROR = value;
					OnPropertyChanged("TIPO_CodZONOrigenMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAR_Roundtrip.
		/// </summary>
		[DataMember]
		public Boolean DTAR_RoundtripOK
		{
			get { return m_dtar_roundtripOK; }
			set
			{
				if (m_dtar_roundtripOK != value)
				{
					m_dtar_roundtripOK = value;
					OnPropertyChanged("DTAR_RoundtripOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAR_Roundtrip.
		/// </summary>
		[DataMember]
		public String DTAR_RoundtripMSGERROR
		{
			get { return m_dtar_roundtripMSGERROR; }
			set
			{
				if (m_dtar_roundtripMSGERROR != value)
				{
					m_dtar_roundtripMSGERROR = value;
					OnPropertyChanged("DTAR_RoundtripMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAR_Costo.
		/// </summary>
		[DataMember]
		public Boolean DTAR_CostoOK
		{
			get { return m_dtar_costoOK; }
			set
			{
				if (m_dtar_costoOK != value)
				{
					m_dtar_costoOK = value;
					OnPropertyChanged("DTAR_CostoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAR_Costo.
		/// </summary>
		[DataMember]
		public String DTAR_CostoMSGERROR
		{
			get { return m_dtar_costoMSGERROR; }
			set
			{
				if (m_dtar_costoMSGERROR != value)
				{
					m_dtar_costoMSGERROR = value;
					OnPropertyChanged("DTAR_CostoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAR_Profit.
		/// </summary>
		[DataMember]
		public Boolean DTAR_ProfitOK
		{
			get { return m_dtar_profitOK; }
			set
			{
				if (m_dtar_profitOK != value)
				{
					m_dtar_profitOK = value;
					OnPropertyChanged("DTAR_ProfitOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAR_Profit.
		/// </summary>
		[DataMember]
		public String DTAR_ProfitMSGERROR
		{
			get { return m_dtar_profitMSGERROR; }
			set
			{
				if (m_dtar_profitMSGERROR != value)
				{
					m_dtar_profitMSGERROR = value;
					OnPropertyChanged("DTAR_ProfitMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DTAR_ProfitMinimo.
		/// </summary>
		[DataMember]
		public Boolean DTAR_ProfitMinimoOK
		{
			get { return m_dtar_profitminimoOK; }
			set
			{
				if (m_dtar_profitminimoOK != value)
				{
					m_dtar_profitminimoOK = value;
					OnPropertyChanged("DTAR_ProfitMinimoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DTAR_ProfitMinimo.
		/// </summary>
		[DataMember]
		public String DTAR_ProfitMinimoMSGERROR
		{
			get { return m_dtar_profitminimoMSGERROR; }
			set
			{
				if (m_dtar_profitminimoMSGERROR != value)
				{
					m_dtar_profitminimoMSGERROR = value;
					OnPropertyChanged("DTAR_ProfitMinimoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodTRA.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodTRAOK
		{
			get { return m_cons_codtraOK; }
			set
			{
				if (m_cons_codtraOK != value)
				{
					m_cons_codtraOK = value;
					OnPropertyChanged("CONS_CodTRAOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodTRA.
		/// </summary>
		[DataMember]
		public String CONS_CodTRAMSGERROR
		{
			get { return m_cons_codtraMSGERROR; }
			set
			{
				if (m_cons_codtraMSGERROR != value)
				{
					m_cons_codtraMSGERROR = value;
					OnPropertyChanged("CONS_CodTRAMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabTRA.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabTRAOK
		{
			get { return m_cons_tabtraOK; }
			set
			{
				if (m_cons_tabtraOK != value)
				{
					m_cons_tabtraOK = value;
					OnPropertyChanged("CONS_TabTRAOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabTRA.
		/// </summary>
		[DataMember]
		public String CONS_TabTRAMSGERROR
		{
			get { return m_cons_tabtraMSGERROR; }
			set
			{
				if (m_cons_tabtraMSGERROR != value)
				{
					m_cons_tabtraMSGERROR = value;
					OnPropertyChanged("CONS_TabTRAMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodigoOK
		{
			get { return m_entc_codigoOK; }
			set
			{
				if (m_entc_codigoOK != value)
				{
					m_entc_codigoOK = value;
					OnPropertyChanged("ENTC_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public String ENTC_CodigoMSGERROR
		{
			get { return m_entc_codigoMSGERROR; }
			set
			{
				if (m_entc_codigoMSGERROR != value)
				{
					m_entc_codigoMSGERROR = value;
					OnPropertyChanged("ENTC_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPE_Codigo.
		/// </summary>
		[DataMember]
		public Boolean TIPE_CodigoOK
		{
			get { return m_tipe_codigoOK; }
			set
			{
				if (m_tipe_codigoOK != value)
				{
					m_tipe_codigoOK = value;
					OnPropertyChanged("TIPE_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPE_Codigo.
		/// </summary>
		[DataMember]
		public String TIPE_CodigoMSGERROR
		{
			get { return m_tipe_codigoMSGERROR; }
			set
			{
				if (m_tipe_codigoMSGERROR != value)
				{
					m_tipe_codigoMSGERROR = value;
					OnPropertyChanged("TIPE_CodigoMSGERROR");
				}
			}
		}



        [DataMember]
        public String  DTAR_Costo20MSGERROR {get;set;}
        
        [DataMember]
        public String  DTAR_CostoSada20MSGERROR {get;set;}
        
        [DataMember]
        public String DTAR_Costo40MSGERROR  {get;set;}
        
        [DataMember]
        public String DTAR_CostoSada40MSGERROR {get;set;}
        
        [DataMember]
        public String DTAR_CostoHBLMSGERROR {get;set;}
        
        [DataMember]
        public String  DTAR_CostoSadaHBLMSGERROR {get;set;}
        
		#endregion

		#region [ Validacion ]
		private String m_mensajeError;
		
		[DataMember]
		public String MensajeError
		{
			get { return m_mensajeError; }
		}
		public Boolean Validar()
		{
			try
			{
				Boolean _isCorrect = true;
				m_mensajeError = "";
				DTAR_ItemOK  = true;
				DTAR_ItemMSGERROR  = "";
                //if( String.IsNullOrEmpty(DTAR_Item) )
                //{
                //    _isCorrect = false;
                //    DTAR_ItemOK  = false;
                //    DTAR_ItemMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DTAR_Item", "Det_Tarifa");
                //    m_mensajeError += "* Debe ingresar el campo DTAR_Item" + Environment.NewLine;
                //}
				CTAR_CodigoOK  = true;
				CTAR_CodigoMSGERROR  = "";
                //if( CTAR_Codigo == null)
                //{
                //    _isCorrect = false;
                //    CTAR_CodigoOK  = false;
                //    CTAR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CTAR_Codigo", "Det_Tarifa");
                //    m_mensajeError += "* Debe ingresar el campo CTAR_Codigo" + Environment.NewLine;
                //}

                
                switch (CTAR_Tipo)
                {
                    case "L": /*  Logistico  */
                        TIPE_CodigoMSGERROR = "";
                        if (TIPE_Codigo== null)
                        {
                            _isCorrect = false;
                            TIPE_CodigoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo Entidad", "Detalle Tarifa");
                            m_mensajeError += "* Debe seleccionar el campo Tipo Entidad" + Environment.NewLine;
                        }
                        ENTC_CodigoMSGERROR = "";
                        if (ENTC_Codigo ==null)
                        {
                            _isCorrect = false;
                            ENTC_CodigoMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Razón Social", "Detalle Tarifa");
                            m_mensajeError += "* Debe ingresar el campo Razón Social" + Environment.NewLine;
                        }
                        if (DTAR_Costo20 == 0 && DTAR_CostoSada20 == 0 && DTAR_Costo40 == 0 && DTAR_CostoSada40 == 0 && DTAR_CostoHBL == 0 && DTAR_CostoSadaHBL == 0)
                        {
                           m_mensajeError += "* Debe ingresar al menos un costo" + Environment.NewLine;
                           _isCorrect = false;
                        }
                        DTAR_Costo20MSGERROR = "";
                        //if (DTAR_Costo20==0)
                        //{
                        //    _isCorrect = false;
                        //    DTAR_Costo20MSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Costo de 20", "Detalle Tarifa");
                        //    m_mensajeError += "* Debe ingresar el campo Costo de 20" + Environment.NewLine;
                        //}
                        DTAR_CostoSada20MSGERROR = "";
                        //if (DTAR_CostoSada20 == 0)
                        //{
                        //    _isCorrect = false;
                        //    DTAR_CostoSada20MSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Costo Sada de 20", "Detalle Tarifa");
                        //    m_mensajeError += "* Debe ingresar el campo Costo Sada de 20" + Environment.NewLine;
                        //}
                        DTAR_Costo40MSGERROR = "";
                        //if (DTAR_Costo40 == 0)
                        //{
                        //    _isCorrect = false;
                        //    DTAR_Costo40MSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Costo de 40", "Detalle Tarifa");
                        //    m_mensajeError += "* Debe ingresar el campo Costo de 40" + Environment.NewLine;
                        //}
                        DTAR_CostoSada40MSGERROR = "";
                        //if (DTAR_CostoSada40 == 0)
                        //{
                        //    _isCorrect = false;
                        //    DTAR_CostoSada40MSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Costo Sada de 40", "Detalle Tarifa");
                        //    m_mensajeError += "* Debe ingresar el campo Costo Sada de 40" + Environment.NewLine;
                        //}
                        DTAR_CostoHBLMSGERROR = "";
                        DTAR_CostoSadaHBLMSGERROR = "";
                        //if (TIPE_Codigo!= null && TIPE_Codigo.Value.ToString(CultureInfo.InvariantCulture).Equals("13"))
                        //{
                        //    if (DTAR_CostoHBL == 0)
                        //    {
                        //        _isCorrect = false;
                        //        DTAR_CostoHBLMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Costo HBL", "Detalle Tarifa");
                        //        m_mensajeError += "* Debe ingresar el campo Costo HBL" + Environment.NewLine;
                        //    }
                        //    if (DTAR_CostoSadaHBL == 0)
                        //    {
                        //        _isCorrect = false;
                        //        DTAR_CostoSadaHBLMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Costo Sada HBL", "Detalle Tarifa");
                        //        m_mensajeError += "* Debe ingresar el campo Costo Sada HBL" + Environment.NewLine;
                        //    }   
                        //}
                        break;
                    case "A": /*  Aduanero  */
                        if (DTAR_Costo==0)
                        {
                            _isCorrect = false;
                            DTAR_CostoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Costo", "Detalle Tarifa");
                            m_mensajeError += "* Debe ingresar el campo Costo" + Environment.NewLine; 
                        }
                        if (String.IsNullOrEmpty(CONS_CodBas))
                        {
                            _isCorrect = false;
                            CONS_CodBasMSGERROR = String.Format("Debe seleccionar la {0} del {1}.", "Base", "Detalle Tarifa");
                            m_mensajeError += "* Debe seleccionar el campo Base" + Environment.NewLine;
                        }
                        break;
                    case "T": /*  Transportista  */

                        if (String.IsNullOrEmpty(CONS_CodTRA))
                        {
                            _isCorrect = false;
                            CONS_CodTRAMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo", "Detalle Tarifa");
                            m_mensajeError += "* Debe seleccionar el campo Tipo" + Environment.NewLine;
                        }
                        if (String.IsNullOrEmpty(TIPO_CodZONOrigen))
                        {
                            _isCorrect = false;
                            TIPO_CodZONOrigenMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Origen", "Detalle Tarifa");
                            m_mensajeError += "* Debe seleccionar el campo Origen" + Environment.NewLine;
                        }
                        if (String.IsNullOrEmpty(TIPO_CodZONDestino))
                        {
                            _isCorrect = false;
                            TIPO_CodZONDestinoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Destino", "Detalle Tarifa");
                            m_mensajeError += "* Debe seleccionar el campo Destino" + Environment.NewLine;
                        }
                         if (DTAR_Costo==null)
                        {
                            _isCorrect = false;
                            DTAR_CostoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Costo", "Detalle Tarifa");
                            m_mensajeError += "* Debe ingresar el campo Costo" + Environment.NewLine; 
                        }
                        if (String.IsNullOrEmpty(CONS_CodBas))
                        {
                            _isCorrect = false;
                            CONS_CodBasMSGERROR = String.Format("Debe seleccionar la {0} del {1}.", "Base", "Detalle Tarifa");
                            m_mensajeError += "* Debe seleccionar el campo Base" + Environment.NewLine;
                        }
                        break;
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

