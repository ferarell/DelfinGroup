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
	public partial class Det_Operacion
	{
		#region [ Variables Validación ]
		private Boolean m_dope_itemOK;
		private String m_dope_itemMSGERROR;
		private Boolean m_cope_codigoOK;
		private String m_cope_codigoMSGERROR;
		private Boolean m_dtar_itemOK;
		private String m_dtar_itemMSGERROR;
		private Boolean m_ctar_codigoOK;
		private String m_ctar_codigoMSGERROR;
		private Boolean m_ctar_tipoOK;
		private String m_ctar_tipoMSGERROR;
		private Boolean m_pack_codigoOK;
		private String m_pack_codigoMSGERROR;
		private Boolean m_cons_codbasOK;
		private String m_cons_codbasMSGERROR;
		private Boolean m_cons_tabbasOK;
		private String m_cons_tabbasMSGERROR;
		private Boolean m_dope_cantidadOK;
		private String m_dope_cantidadMSGERROR;
		private Boolean m_dope_preciounitcostoOK;
		private String m_dope_preciounitcostoMSGERROR;
		private Boolean m_dope_preciototcostoOK;
		private String m_dope_preciototcostoMSGERROR;
		private Boolean m_dope_preciounitvtaOK;
		private String m_dope_preciounitvtaMSGERROR;
		private Boolean m_dope_preciototvtaOK;
		private String m_dope_preciototvtaMSGERROR;
		private Boolean m_dope_minimoOK;
		private String m_dope_minimoMSGERROR;
		private Boolean m_dope_pesoOK;
		private String m_dope_pesoMSGERROR;
		private Boolean m_dope_volumenOK;
		private String m_dope_volumenMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_usr_usrmodOK;
		private String m_usr_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		private Boolean m_dope_costosadaOK;
		private String m_dope_costosadaMSGERROR;
		private Boolean m_dope_costoOK;
		private String m_dope_costoMSGERROR;
		private Boolean m_dope_ventasadaOK;
		private String m_dope_ventasadaMSGERROR;
		private Boolean m_dope_ventaOK;
		private String m_dope_ventaMSGERROR;
		private Boolean m_tipo_tabzonOK;
		private String m_tipo_tabzonMSGERROR;
		private Boolean m_tipo_codzonorigenOK;
		private String m_tipo_codzonorigenMSGERROR;
		private Boolean m_cons_codtraOK;
		private String m_cons_codtraMSGERROR;
		private Boolean m_cons_tabtraOK;
		private String m_cons_tabtraMSGERROR;
		private Boolean m_tipo_codzondestinoOK;
		private String m_tipo_codzondestinoMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: DOPE_Item.
		/// </summary>
		[DataMember]
		public Boolean DOPE_ItemOK
		{
			get { return m_dope_itemOK; }
			set
			{
				if (m_dope_itemOK != value)
				{
					m_dope_itemOK = value;
					OnPropertyChanged("DOPE_ItemOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOPE_Item.
		/// </summary>
		[DataMember]
		public String DOPE_ItemMSGERROR
		{
			get { return m_dope_itemMSGERROR; }
			set
			{
				if (m_dope_itemMSGERROR != value)
				{
					m_dope_itemMSGERROR = value;
					OnPropertyChanged("DOPE_ItemMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_Codigo.
		/// </summary>
		[DataMember]
		public Boolean COPE_CodigoOK
		{
			get { return m_cope_codigoOK; }
			set
			{
				if (m_cope_codigoOK != value)
				{
					m_cope_codigoOK = value;
					OnPropertyChanged("COPE_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_Codigo.
		/// </summary>
		[DataMember]
		public String COPE_CodigoMSGERROR
		{
			get { return m_cope_codigoMSGERROR; }
			set
			{
				if (m_cope_codigoMSGERROR != value)
				{
					m_cope_codigoMSGERROR = value;
					OnPropertyChanged("COPE_CodigoMSGERROR");
				}
			}
		}
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
		/// Gets or sets el valor de validación de: DOPE_Cantidad.
		/// </summary>
		[DataMember]
		public Boolean DOPE_CantidadOK
		{
			get { return m_dope_cantidadOK; }
			set
			{
				if (m_dope_cantidadOK != value)
				{
					m_dope_cantidadOK = value;
					OnPropertyChanged("DOPE_CantidadOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOPE_Cantidad.
		/// </summary>
		[DataMember]
		public String DOPE_CantidadMSGERROR
		{
			get { return m_dope_cantidadMSGERROR; }
			set
			{
				if (m_dope_cantidadMSGERROR != value)
				{
					m_dope_cantidadMSGERROR = value;
					OnPropertyChanged("DOPE_CantidadMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOPE_PrecioUnitCosto.
		/// </summary>
		[DataMember]
		public Boolean DOPE_PrecioUnitCostoOK
		{
			get { return m_dope_preciounitcostoOK; }
			set
			{
				if (m_dope_preciounitcostoOK != value)
				{
					m_dope_preciounitcostoOK = value;
					OnPropertyChanged("DOPE_PrecioUnitCostoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOPE_PrecioUnitCosto.
		/// </summary>
		[DataMember]
		public String DOPE_PrecioUnitCostoMSGERROR
		{
			get { return m_dope_preciounitcostoMSGERROR; }
			set
			{
				if (m_dope_preciounitcostoMSGERROR != value)
				{
					m_dope_preciounitcostoMSGERROR = value;
					OnPropertyChanged("DOPE_PrecioUnitCostoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOPE_PrecioTotCosto.
		/// </summary>
		[DataMember]
		public Boolean DOPE_PrecioTotCostoOK
		{
			get { return m_dope_preciototcostoOK; }
			set
			{
				if (m_dope_preciototcostoOK != value)
				{
					m_dope_preciototcostoOK = value;
					OnPropertyChanged("DOPE_PrecioTotCostoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOPE_PrecioTotCosto.
		/// </summary>
		[DataMember]
		public String DOPE_PrecioTotCostoMSGERROR
		{
			get { return m_dope_preciototcostoMSGERROR; }
			set
			{
				if (m_dope_preciototcostoMSGERROR != value)
				{
					m_dope_preciototcostoMSGERROR = value;
					OnPropertyChanged("DOPE_PrecioTotCostoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOPE_PrecioUnitVta.
		/// </summary>
		[DataMember]
		public Boolean DOPE_PrecioUnitVtaOK
		{
			get { return m_dope_preciounitvtaOK; }
			set
			{
				if (m_dope_preciounitvtaOK != value)
				{
					m_dope_preciounitvtaOK = value;
					OnPropertyChanged("DOPE_PrecioUnitVtaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOPE_PrecioUnitVta.
		/// </summary>
		[DataMember]
		public String DOPE_PrecioUnitVtaMSGERROR
		{
			get { return m_dope_preciounitvtaMSGERROR; }
			set
			{
				if (m_dope_preciounitvtaMSGERROR != value)
				{
					m_dope_preciounitvtaMSGERROR = value;
					OnPropertyChanged("DOPE_PrecioUnitVtaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOPE_PrecioTotVta.
		/// </summary>
		[DataMember]
		public Boolean DOPE_PrecioTotVtaOK
		{
			get { return m_dope_preciototvtaOK; }
			set
			{
				if (m_dope_preciototvtaOK != value)
				{
					m_dope_preciototvtaOK = value;
					OnPropertyChanged("DOPE_PrecioTotVtaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOPE_PrecioTotVta.
		/// </summary>
		[DataMember]
		public String DOPE_PrecioTotVtaMSGERROR
		{
			get { return m_dope_preciototvtaMSGERROR; }
			set
			{
				if (m_dope_preciototvtaMSGERROR != value)
				{
					m_dope_preciototvtaMSGERROR = value;
					OnPropertyChanged("DOPE_PrecioTotVtaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOPE_Minimo.
		/// </summary>
		[DataMember]
		public Boolean DOPE_MinimoOK
		{
			get { return m_dope_minimoOK; }
			set
			{
				if (m_dope_minimoOK != value)
				{
					m_dope_minimoOK = value;
					OnPropertyChanged("DOPE_MinimoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOPE_Minimo.
		/// </summary>
		[DataMember]
		public String DOPE_MinimoMSGERROR
		{
			get { return m_dope_minimoMSGERROR; }
			set
			{
				if (m_dope_minimoMSGERROR != value)
				{
					m_dope_minimoMSGERROR = value;
					OnPropertyChanged("DOPE_MinimoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOPE_Peso.
		/// </summary>
		[DataMember]
		public Boolean DOPE_PesoOK
		{
			get { return m_dope_pesoOK; }
			set
			{
				if (m_dope_pesoOK != value)
				{
					m_dope_pesoOK = value;
					OnPropertyChanged("DOPE_PesoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOPE_Peso.
		/// </summary>
		[DataMember]
		public String DOPE_PesoMSGERROR
		{
			get { return m_dope_pesoMSGERROR; }
			set
			{
				if (m_dope_pesoMSGERROR != value)
				{
					m_dope_pesoMSGERROR = value;
					OnPropertyChanged("DOPE_PesoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOPE_Volumen.
		/// </summary>
		[DataMember]
		public Boolean DOPE_VolumenOK
		{
			get { return m_dope_volumenOK; }
			set
			{
				if (m_dope_volumenOK != value)
				{
					m_dope_volumenOK = value;
					OnPropertyChanged("DOPE_VolumenOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOPE_Volumen.
		/// </summary>
		[DataMember]
		public String DOPE_VolumenMSGERROR
		{
			get { return m_dope_volumenMSGERROR; }
			set
			{
				if (m_dope_volumenMSGERROR != value)
				{
					m_dope_volumenMSGERROR = value;
					OnPropertyChanged("DOPE_VolumenMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOPE_CostoSada.
		/// </summary>
		[DataMember]
		public Boolean DOPE_CostoSadaOK
		{
			get { return m_dope_costosadaOK; }
			set
			{
				if (m_dope_costosadaOK != value)
				{
					m_dope_costosadaOK = value;
					OnPropertyChanged("DOPE_CostoSadaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOPE_CostoSada.
		/// </summary>
		[DataMember]
		public String DOPE_CostoSadaMSGERROR
		{
			get { return m_dope_costosadaMSGERROR; }
			set
			{
				if (m_dope_costosadaMSGERROR != value)
				{
					m_dope_costosadaMSGERROR = value;
					OnPropertyChanged("DOPE_CostoSadaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOPE_Costo.
		/// </summary>
		[DataMember]
		public Boolean DOPE_CostoOK
		{
			get { return m_dope_costoOK; }
			set
			{
				if (m_dope_costoOK != value)
				{
					m_dope_costoOK = value;
					OnPropertyChanged("DOPE_CostoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOPE_Costo.
		/// </summary>
		[DataMember]
		public String DOPE_CostoMSGERROR
		{
			get { return m_dope_costoMSGERROR; }
			set
			{
				if (m_dope_costoMSGERROR != value)
				{
					m_dope_costoMSGERROR = value;
					OnPropertyChanged("DOPE_CostoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOPE_VentaSada.
		/// </summary>
		[DataMember]
		public Boolean DOPE_VentaSadaOK
		{
			get { return m_dope_ventasadaOK; }
			set
			{
				if (m_dope_ventasadaOK != value)
				{
					m_dope_ventasadaOK = value;
					OnPropertyChanged("DOPE_VentaSadaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOPE_VentaSada.
		/// </summary>
		[DataMember]
		public String DOPE_VentaSadaMSGERROR
		{
			get { return m_dope_ventasadaMSGERROR; }
			set
			{
				if (m_dope_ventasadaMSGERROR != value)
				{
					m_dope_ventasadaMSGERROR = value;
					OnPropertyChanged("DOPE_VentaSadaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOPE_Venta.
		/// </summary>
		[DataMember]
		public Boolean DOPE_VentaOK
		{
			get { return m_dope_ventaOK; }
			set
			{
				if (m_dope_ventaOK != value)
				{
					m_dope_ventaOK = value;
					OnPropertyChanged("DOPE_VentaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOPE_Venta.
		/// </summary>
		[DataMember]
		public String DOPE_VentaMSGERROR
		{
			get { return m_dope_ventaMSGERROR; }
			set
			{
				if (m_dope_ventaMSGERROR != value)
				{
					m_dope_ventaMSGERROR = value;
					OnPropertyChanged("DOPE_VentaMSGERROR");
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

        [DataMember]
        public String DOPE_Cantidad20MSGERROR { get; set; }

        [DataMember]
        public String DOPE_Cantidad40MSGERROR { get; set; }

        [DataMember]
        public String TIPE_CodigoMSGERROR { set; get; }

        [DataMember]
        public String ENTC_CodigoMSGERROR { set; get; }

        [DataMember]
        public String DOPE_Venta20MSGERROR { set; get; }

        [DataMember]
        public String DOPE_Venta40MSGERROR { set; get; }

        [DataMember]
        public String DOPE_VentaSada20MSGERROR { set; get; }

        [DataMember]
        public String DOPE_VentaSada40MSGERROR { set; get; }

        [DataMember]
        public String DOPE_VentaHBLMSGERROR { set; get; }

        [DataMember]
        public String DOPE_VentaSadaHBLMSGERROR { set; get; }

        [DataMember]
        public String CONS_CodESTMSGERROR { set; get; }

        [DataMember]
        public String CONS_TabESTMSGERROR { set; get; }
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
				DOPE_ItemOK  = true;
				DOPE_ItemMSGERROR  = "";
                //if( DOPE_Item == null)
                //{
                //    _isCorrect = false;
                //    DOPE_ItemOK  = false;
                //    DOPE_ItemMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DOPE_Item", "Det_Operacion");
                //    m_mensajeError += "* Debe ingresar el campo DOPE_Item" + Environment.NewLine;
                //}
				COPE_CodigoOK  = true;
				COPE_CodigoMSGERROR  = "";
                //if( COPE_Codigo == null)
                //{
                //    _isCorrect = false;
                //    COPE_CodigoOK  = false;
                //    COPE_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "COPE_Codigo", "Det_Operacion");
                //    m_mensajeError += "* Debe ingresar el campo COPE_Codigo" + Environment.NewLine;
                //}
				DOPE_CantidadOK  = true;
				DOPE_CantidadMSGERROR  = "";
                //if( DOPE_Cantidad == null)
                //{
                //    _isCorrect = false;
                //    DOPE_CantidadOK  = false;
                //    DOPE_CantidadMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DOPE_Cantidad", "Det_Operacion");
                //    m_mensajeError += "* Debe ingresar el campo DOPE_Cantidad" + Environment.NewLine;
                //}
				DOPE_PrecioUnitCostoOK  = true;
				DOPE_PrecioUnitCostoMSGERROR  = "";
                //if( DOPE_PrecioUnitCosto == null)
                //{
                //    _isCorrect = false;
                //    DOPE_PrecioUnitCostoOK  = false;
                //    DOPE_PrecioUnitCostoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DOPE_PrecioUnitCosto", "Det_Operacion");
                //    m_mensajeError += "* Debe ingresar el campo DOPE_PrecioUnitCosto" + Environment.NewLine;
                //}
				DOPE_PrecioTotCostoOK  = true;
				DOPE_PrecioTotCostoMSGERROR  = "";
                //if( DOPE_PrecioTotCosto == null)
                //{
                //    _isCorrect = false;
                //    DOPE_PrecioTotCostoOK  = false;
                //    DOPE_PrecioTotCostoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DOPE_PrecioTotCosto", "Det_Operacion");
                //    m_mensajeError += "* Debe ingresar el campo DOPE_PrecioTotCosto" + Environment.NewLine;
                //}
				DOPE_PrecioUnitVtaOK  = true;
				DOPE_PrecioUnitVtaMSGERROR  = "";
                //if( DOPE_PrecioUnitVta == null)
                //{
                //    _isCorrect = false;
                //    DOPE_PrecioUnitVtaOK  = false;
                //    DOPE_PrecioUnitVtaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DOPE_PrecioUnitVta", "Det_Operacion");
                //    m_mensajeError += "* Debe ingresar el campo DOPE_PrecioUnitVta" + Environment.NewLine;
                //}
				DOPE_PrecioTotVtaOK  = true;
				DOPE_PrecioTotVtaMSGERROR  = "";
                //if( DOPE_PrecioTotVta == null)
                //{
                //    _isCorrect = false;
                //    DOPE_PrecioTotVtaOK  = false;
                //    DOPE_PrecioTotVtaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DOPE_PrecioTotVta", "Det_Operacion");
                //    m_mensajeError += "* Debe ingresar el campo DOPE_PrecioTotVta" + Environment.NewLine;
                //}
				DOPE_MinimoOK  = true;
				DOPE_MinimoMSGERROR  = "";
                //if( DOPE_Minimo == null)
                //{
                //    _isCorrect = false;
                //    DOPE_MinimoOK  = false;
                //    DOPE_MinimoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DOPE_Minimo", "Det_Operacion");
                //    m_mensajeError += "* Debe ingresar el campo DOPE_Minimo" + Environment.NewLine;
                //}
				DOPE_VentaSadaOK  = true;
				DOPE_VentaSadaMSGERROR  = "";
                //if( DOPE_VentaSada == null)
                //{
                //    _isCorrect = false;
                //    DOPE_VentaSadaOK  = false;
                //    DOPE_VentaSadaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DOPE_VentaSada", "Det_Operacion");
                //    m_mensajeError += "* Debe ingresar el campo DOPE_VentaSada" + Environment.NewLine;
                //}
				DOPE_VentaOK  = true;
				DOPE_VentaMSGERROR  = "";
                //if( DOPE_Venta == null)
                //{
                //    _isCorrect = false;
                //    DOPE_VentaOK  = false;
                //    DOPE_VentaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DOPE_Venta", "Det_Operacion");
                //    m_mensajeError += "* Debe ingresar el campo DOPE_Venta" + Environment.NewLine;
                //}

			    CONS_CodESTMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_CodEST))
			    {
                    _isCorrect = false;
                    CONS_CodESTMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Estado", "Detalle Operación");
                    m_mensajeError += "* Debe ingresar el campo Estado" + Environment.NewLine; 
			    }
                switch (CTAR_Tipo)
                {
                    case "L": /*  Logistico  */
                        TIPE_CodigoMSGERROR = "";
                        if (TIPE_Codigo == null)
                        {
                            _isCorrect = false;
                            TIPE_CodigoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo Entidad", "Detalle Operación");
                            m_mensajeError += "* Debe seleccionar el campo Tipo Entidad" + Environment.NewLine;
                        }
                        ENTC_CodigoMSGERROR = "";
                        if (ENTC_Codigo == null)
                        {
                            _isCorrect = false;
                            ENTC_CodigoMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Razón Social", "Detalle Operación");
                            m_mensajeError += "* Debe ingresar el campo Razón Social" + Environment.NewLine;
                        }
                        if (DOPE_Cantidad20 == 0 && DOPE_Cantidad40 == 0)
                        {
                            _isCorrect = false;
                            m_mensajeError += "* Debe ingresar el campo Cantidad de 20 o de 40 " + Environment.NewLine;
                        }

                        DOPE_Cantidad20MSGERROR = "";
                        //if (DOPE_Cantidad20 == 0)
                        //{
                        //    _isCorrect = false;
                        //    DOPE_Cantidad20MSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Cantidad de 20", "Detalle Operación");
                        //    m_mensajeError += "* Debe ingresar el campo Cantidad de 20" + Environment.NewLine;
                        //}
                        DOPE_Cantidad40MSGERROR = "";
                        //if (DOPE_Cantidad40 == 0)
                        //{
                        //    _isCorrect = false;
                        //    DOPE_Cantidad40MSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Cantidad de 40", "Detalle Operación");
                        //    m_mensajeError += "* Debe ingresar el campo Cantidad de 40" + Environment.NewLine;
                        //}
                        DOPE_Venta20MSGERROR = "";
                        //if (DOPE_Venta20 == 0)
                        //{
                        //    _isCorrect = false;
                        //    DOPE_Venta20MSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Venta de 20", "Detalle Operación");
                        //    m_mensajeError += "* Debe ingresar el campo Venta de 20" + Environment.NewLine;
                        //}
                        DOPE_VentaSada20MSGERROR = "";
                        //if (DOPE_VentaSada20 == 0)
                        //{
                        //    _isCorrect = false;
                        //    DOPE_VentaSada20MSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Venta Sada de 20", "Detalle Operación");
                        //    m_mensajeError += "* Debe ingresar el campo Venta Sada de 20" + Environment.NewLine;
                        //}
                        DOPE_Venta40MSGERROR = "";
                        //if (DOPE_Venta40 == 0)
                        //{
                        //    _isCorrect = false;
                        //    DOPE_Venta40MSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Venta de 40", "Detalle Operación");
                        //    m_mensajeError += "* Debe ingresar el campo Venta de 40" + Environment.NewLine;
                        //}
                        DOPE_VentaSada40MSGERROR = "";
                        //if (DOPE_VentaSada40 == 0)
                        //{
                        //    _isCorrect = false;
                        //    DOPE_VentaSada40MSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Venta Sada de 40", "Detalle Operación");
                        //    m_mensajeError += "* Debe ingresar el campo Venta Sada de 40" + Environment.NewLine;
                        //}
                        DOPE_VentaHBLMSGERROR = "";
                        DOPE_VentaSadaHBLMSGERROR = "";
                        if (TIPE_Codigo != null && TIPE_Codigo.Value.ToString(CultureInfo.InvariantCulture).Equals("13"))
                        {
                            //if (DOPE_VentaHBL == 0)
                            //{
                            //    _isCorrect = false;
                            //    DOPE_VentaHBLMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Venta HBL", "Detalle Operación");
                            //    m_mensajeError += "* Debe ingresar el campo Venta HBL" + Environment.NewLine;
                            //}
                            //if (DOPE_VentaSadaHBL == 0)
                            //{
                            //    _isCorrect = false;
                            //    DOPE_VentaSadaHBLMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Venta Sada HBL", "Detalle Operación");
                            //    m_mensajeError += "* Debe ingresar el campo Venta Sada HBL" + Environment.NewLine;
                            //}
                        }
                        break;
                    case "A": /*  Aduanero  */
                        if (DOPE_Venta == 0)
                        {
                            _isCorrect = false;
                            DOPE_VentaMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Comisión", "Detalle Operación");
                            m_mensajeError += "* Debe ingresar el Comisión" + Environment.NewLine;
                        }
                        if (String.IsNullOrEmpty(CONS_CodBas))
                        {
                            _isCorrect = false;
                            CONS_CodBasMSGERROR = String.Format("Debe seleccionar la {0} del {1}.", "Base", "Detalle Operación");
                            m_mensajeError += "* Debe seleccionar el campo Base" + Environment.NewLine;
                        }
                        break;
                    case "T": /*  Transportista  */

                        if (String.IsNullOrEmpty(CONS_CodTRA))
                        {
                            _isCorrect = false;
                            CONS_CodTRAMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo", "Detalle Operación");
                            m_mensajeError += "* Debe seleccionar el campo Tipo" + Environment.NewLine;
                        }
                        if (String.IsNullOrEmpty(TIPO_CodZONOrigen))
                        {
                            _isCorrect = false;
                            TIPO_CodZONOrigenMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Origen", "Detalle Operación");
                            m_mensajeError += "* Debe seleccionar el campo Origen" + Environment.NewLine;
                        }
                        if (String.IsNullOrEmpty(TIPO_CodZONDestino))
                        {
                            _isCorrect = false;
                            TIPO_CodZONDestinoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Destino", "Detalle Operación");
                            m_mensajeError += "* Debe seleccionar el campo Destino" + Environment.NewLine;
                        }
                        if (DOPE_Venta == null)
                        {
                            _isCorrect = false;
                            DOPE_VentaMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Flete", "Detalle Operación");
                            m_mensajeError += "* Debe ingresar el campo Flete" + Environment.NewLine;
                        }
                        if (String.IsNullOrEmpty(CONS_CodBas))
                        {
                            _isCorrect = false;
                            CONS_CodBasMSGERROR = String.Format("Debe seleccionar la {0} del {1}.", "Base", "Detalle Operación");
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
