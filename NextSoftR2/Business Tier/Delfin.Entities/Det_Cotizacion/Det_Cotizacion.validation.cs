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
	public partial class Det_Cotizacion
	{
		#region [ Variables Validación ]
		private Boolean m_ccot_codigoOK;
		private String m_ccot_codigoMSGERROR;
		private Boolean m_dcot_itemOK;
		private String m_dcot_itemMSGERROR;
		private Boolean m_dtar_itemOK;
		private String m_dtar_itemMSGERROR;
		private Boolean m_ctar_codigoOK;
		private String m_ctar_codigoMSGERROR;
		private Boolean m_ctar_tipoOK;
		private String m_ctar_tipoMSGERROR;
		private Boolean m_pack_codigoOK;
		private String m_pack_codigoMSGERROR;
		private Boolean m_dcot_cantidadOK;
		private String m_dcot_cantidadMSGERROR;
		private Boolean m_dcot_VentasadaOK;
		private String m_dcot_VentasadaMSGERROR;
		private Boolean m_dcot_VentaOK;
		private String m_dcot_VentaMSGERROR;
		private Boolean m_dcot_ventasadaOK;
		private String m_dcot_ventasadaMSGERROR;
		private Boolean m_dcot_ventaOK;
		private String m_dcot_ventaMSGERROR;
		private Boolean m_dcot_minimoOK;
		private String m_dcot_minimoMSGERROR;
		private Boolean m_cons_codbasOK;
		private String m_cons_codbasMSGERROR;
		private Boolean m_cons_tabbasOK;
		private String m_cons_tabbasMSGERROR;
		private Boolean m_dcot_pesoOK;
		private String m_dcot_pesoMSGERROR;
		private Boolean m_dcot_volumenOK;
		private String m_dcot_volumenMSGERROR;
		private Boolean m_tipe_codigoOK;
		private String m_tipe_codigoMSGERROR;
		private Boolean m_entc_codigoOK;
		private String m_entc_codigoMSGERROR;
		private Boolean m_tipo_tabzonOK;
		private String m_tipo_tabzonMSGERROR;
		private Boolean m_tipo_codzonorigenOK;
		private String m_tipo_codzonorigenMSGERROR;
		private Boolean m_tipo_codzondestinoOK;
		private String m_tipo_codzondestinoMSGERROR;
		private Boolean m_dcot_roudtripOK;
		private String m_dcot_roudtripMSGERROR;
		private Boolean m_dcot_profitOK;
		private String m_dcot_profitMSGERROR;
		private Boolean m_dcot_profitminimoOK;
		private String m_dcot_profitminimoMSGERROR;
		private Boolean m_cons_codtraOK;
		private String m_cons_codtraMSGERROR;
		private Boolean m_cons_tabtraOK;
		private String m_cons_tabtraMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CCOT_CodigoOK
		{
			get { return m_ccot_codigoOK; }
			set
			{
				if (m_ccot_codigoOK != value)
				{
					m_ccot_codigoOK = value;
					OnPropertyChanged("CCOT_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Codigo.
		/// </summary>
		[DataMember]
		public String CCOT_CodigoMSGERROR
		{
			get { return m_ccot_codigoMSGERROR; }
			set
			{
				if (m_ccot_codigoMSGERROR != value)
				{
					m_ccot_codigoMSGERROR = value;
					OnPropertyChanged("CCOT_CodigoMSGERROR");
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
		/// Gets or sets el valor de validación de: DCOT_VentaSada.
		/// </summary>
		[DataMember]
		public Boolean DCOT_VentaSadaOK
		{
			get { return m_dcot_VentasadaOK; }
			set
			{
				if (m_dcot_VentasadaOK != value)
				{
					m_dcot_VentasadaOK = value;
					OnPropertyChanged("DCOT_VentaSadaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_VentaSada.
		/// </summary>
		[DataMember]
		public String DCOT_VentaSadaMSGERROR
		{
			get { return m_dcot_VentasadaMSGERROR; }
			set
			{
				if (m_dcot_VentasadaMSGERROR != value)
				{
					m_dcot_VentasadaMSGERROR = value;
					OnPropertyChanged("DCOT_VentaSadaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_Venta.
		/// </summary>
		[DataMember]
		public Boolean DCOT_VentaOK
		{
			get { return m_dcot_VentaOK; }
			set
			{
				if (m_dcot_VentaOK != value)
				{
					m_dcot_VentaOK = value;
					OnPropertyChanged("DCOT_VentaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_Venta.
		/// </summary>
		[DataMember]
		public String DCOT_VentaMSGERROR
		{
			get { return m_dcot_VentaMSGERROR; }
			set
			{
				if (m_dcot_VentaMSGERROR != value)
				{
					m_dcot_VentaMSGERROR = value;
					OnPropertyChanged("DCOT_VentaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_VentaSada.
		/// </summary>
        //[DataMember]
        //public Boolean DCOT_VentaSadaOK
        //{
        //    get { return m_dcot_ventasadaOK; }
        //    set
        //    {
        //        if (m_dcot_ventasadaOK != value)
        //        {
        //            m_dcot_ventasadaOK = value;
        //            OnPropertyChanged("DCOT_VentaSadaOK");
        //        }
        //    }
        //}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_VentaSada.
		/// </summary>
        //[DataMember]
        //public String DCOT_VentaSadaMSGERROR
        //{
        //    get { return m_dcot_ventasadaMSGERROR; }
        //    set
        //    {
        //        if (m_dcot_ventasadaMSGERROR != value)
        //        {
        //            m_dcot_ventasadaMSGERROR = value;
        //            OnPropertyChanged("DCOT_VentaSadaMSGERROR");
        //        }
        //    }
        //}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_Venta.
		/// </summary>
        //[DataMember]
        //public Boolean DCOT_VentaOK
        //{
        //    get { return m_dcot_ventaOK; }
        //    set
        //    {
        //        if (m_dcot_ventaOK != value)
        //        {
        //            m_dcot_ventaOK = value;
        //            OnPropertyChanged("DCOT_VentaOK");
        //        }
        //    }
        //}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_Venta.
		/// </summary>
        //[DataMember]
        //public String DCOT_VentaMSGERROR
        //{
        //    get { return m_dcot_ventaMSGERROR; }
        //    set
        //    {
        //        if (m_dcot_ventaMSGERROR != value)
        //        {
        //            m_dcot_ventaMSGERROR = value;
        //            OnPropertyChanged("DCOT_VentaMSGERROR");
        //        }
        //    }
        //}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_Minimo.
		/// </summary>
		[DataMember]
		public Boolean DCOT_MinimoOK
		{
			get { return m_dcot_minimoOK; }
			set
			{
				if (m_dcot_minimoOK != value)
				{
					m_dcot_minimoOK = value;
					OnPropertyChanged("DCOT_MinimoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_Minimo.
		/// </summary>
		[DataMember]
		public String DCOT_MinimoMSGERROR
		{
			get { return m_dcot_minimoMSGERROR; }
			set
			{
				if (m_dcot_minimoMSGERROR != value)
				{
					m_dcot_minimoMSGERROR = value;
					OnPropertyChanged("DCOT_MinimoMSGERROR");
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
		/// Gets or sets el valor de validación de: DCOT_Roudtrip.
		/// </summary>
		[DataMember]
		public Boolean DCOT_RoudtripOK
		{
			get { return m_dcot_roudtripOK; }
			set
			{
				if (m_dcot_roudtripOK != value)
				{
					m_dcot_roudtripOK = value;
					OnPropertyChanged("DCOT_RoudtripOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_Roudtrip.
		/// </summary>
		[DataMember]
		public String DCOT_RoudtripMSGERROR
		{
			get { return m_dcot_roudtripMSGERROR; }
			set
			{
				if (m_dcot_roudtripMSGERROR != value)
				{
					m_dcot_roudtripMSGERROR = value;
					OnPropertyChanged("DCOT_RoudtripMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_Profit.
		/// </summary>
		[DataMember]
		public Boolean DCOT_ProfitOK
		{
			get { return m_dcot_profitOK; }
			set
			{
				if (m_dcot_profitOK != value)
				{
					m_dcot_profitOK = value;
					OnPropertyChanged("DCOT_ProfitOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_Profit.
		/// </summary>
		[DataMember]
		public String DCOT_ProfitMSGERROR
		{
			get { return m_dcot_profitMSGERROR; }
			set
			{
				if (m_dcot_profitMSGERROR != value)
				{
					m_dcot_profitMSGERROR = value;
					OnPropertyChanged("DCOT_ProfitMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCOT_ProfitMinimo.
		/// </summary>
		[DataMember]
		public Boolean DCOT_ProfitMinimoOK
		{
			get { return m_dcot_profitminimoOK; }
			set
			{
				if (m_dcot_profitminimoOK != value)
				{
					m_dcot_profitminimoOK = value;
					OnPropertyChanged("DCOT_ProfitMinimoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCOT_ProfitMinimo.
		/// </summary>
		[DataMember]
		public String DCOT_ProfitMinimoMSGERROR
		{
			get { return m_dcot_profitminimoMSGERROR; }
			set
			{
				if (m_dcot_profitminimoMSGERROR != value)
				{
					m_dcot_profitminimoMSGERROR = value;
					OnPropertyChanged("DCOT_ProfitMinimoMSGERROR");
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


        [DataMember]
        public String DCOT_Venta20MSGERROR { get; set; }

        [DataMember]
        public String DCOT_VentaSada20MSGERROR { get; set; }

        [DataMember]
        public String DCOT_Venta40MSGERROR { get; set; }

        [DataMember]
        public String DCOT_VentaSada40MSGERROR { get; set; }

        [DataMember]
        public String DCOT_VentaHBLMSGERROR { get; set; }

        [DataMember]
        public String DCOT_VentaSadaHBLMSGERROR { get; set; }

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
				CCOT_CodigoOK  = true;
				CCOT_CodigoMSGERROR  = "";
                //if( CCOT_Codigo == null)
                //{
                //    _isCorrect = false;
                //    CCOT_CodigoOK  = false;
                //    CCOT_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Codigo", "Det_Cotizacion");
                //    m_mensajeError += "* Debe ingresar el campo CCOT_Codigo" + Environment.NewLine;
                //}
				DCOT_ItemOK  = true;
				DCOT_ItemMSGERROR  = "";
                //if( DCOT_Item == null)
                //{
                //    _isCorrect = false;
                //    DCOT_ItemOK  = false;
                //    DCOT_ItemMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCOT_Item", "Det_Cotizacion");
                //    m_mensajeError += "* Debe ingresar el campo DCOT_Item" + Environment.NewLine;
                //}
				DCOT_CantidadOK  = true;
				DCOT_CantidadMSGERROR  = "";
                //if( DCOT_Cantidad == null)
                //{
                //    _isCorrect = false;
                //    DCOT_CantidadOK  = false;
                //    DCOT_CantidadMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCOT_Cantidad", "Det_Cotizacion");
                //    m_mensajeError += "* Debe ingresar el campo DCOT_Cantidad" + Environment.NewLine;
                //}
				DCOT_VentaSadaOK  = true;
				DCOT_VentaSadaMSGERROR  = "";
                //if( DCOT_VentaSada == null)
                //{
                //    _isCorrect = false;
                //    DCOT_VentaSadaOK  = false;
                //    DCOT_VentaSadaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCOT_VentaSada", "Det_Cotizacion");
                //    m_mensajeError += "* Debe ingresar el campo DCOT_VentaSada" + Environment.NewLine;
                //}
				DCOT_VentaOK  = true;
				DCOT_VentaMSGERROR  = "";
                //if( DCOT_Venta == null)
                //{
                //    _isCorrect = false;
                //    DCOT_VentaOK  = false;
                //    DCOT_VentaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCOT_Venta", "Det_Cotizacion");
                //    m_mensajeError += "* Debe ingresar el campo DCOT_Venta" + Environment.NewLine;
                //}
				DCOT_VentaSadaOK  = true;
				DCOT_VentaSadaMSGERROR  = "";
                //if( DCOT_VentaSada == null)
                //{
                //    _isCorrect = false;
                //    DCOT_VentaSadaOK  = false;
                //    DCOT_VentaSadaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCOT_VentaSada", "Det_Cotizacion");
                //    m_mensajeError += "* Debe ingresar el campo DCOT_VentaSada" + Environment.NewLine;
                //}
				DCOT_VentaOK  = true;
				DCOT_VentaMSGERROR  = "";
                //if( DCOT_Venta == null)
                //{
                //    _isCorrect = false;
                //    DCOT_VentaOK  = false;
                //    DCOT_VentaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCOT_Venta", "Det_Cotizacion");
                //    m_mensajeError += "* Debe ingresar el campo DCOT_Venta" + Environment.NewLine;
                //}
				DCOT_MinimoOK  = true;
				DCOT_MinimoMSGERROR  = "";
                //if( DCOT_Minimo == null)
                //{
                //    _isCorrect = false;
                //    DCOT_MinimoOK  = false;
                //    DCOT_MinimoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DCOT_Minimo", "Det_Cotizacion");
                //    m_mensajeError += "* Debe ingresar el campo DCOT_Minimo" + Environment.NewLine;
                //}

                switch (CTAR_Tipo)
                {
                    case "L": /*  Logistico  */
                        TIPE_CodigoMSGERROR = "";
                        if (TIPE_Codigo == null)
                        {
                            _isCorrect = false;
                            TIPE_CodigoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo Entidad", "Detalle Cotización");
                            m_mensajeError += "* Debe seleccionar el campo Tipo Entidad" + Environment.NewLine;
                        }
                        ENTC_CodigoMSGERROR = "";
                        if (ENTC_Codigo == null)
                        {
                            _isCorrect = false;
                            ENTC_CodigoMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Razón Social", "Detalle Cotización");
                            m_mensajeError += "* Debe ingresar el campo Razón Social" + Environment.NewLine;
                        }
                        DCOT_Venta20MSGERROR = "";
                        //if (DCOT_Venta20 == 0)
                        //{
                        //    _isCorrect = false;
                        //    DCOT_Venta20MSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Venta de 20", "Detalle Cotización");
                        //    m_mensajeError += "* Debe ingresar el campo Venta de 20" + Environment.NewLine;
                        //}
                        DCOT_VentaSada20MSGERROR = "";
                        //if (DCOT_VentaSada20 == 0)
                        //{
                        //    _isCorrect = false;
                        //    DCOT_VentaSada20MSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Venta Sada de 20", "Detalle Cotización");
                        //    m_mensajeError += "* Debe ingresar el campo Venta Sada de 20" + Environment.NewLine;
                        //}
                        DCOT_Venta40MSGERROR = "";
                        //if (DCOT_Venta40 == 0)
                        //{
                        //    _isCorrect = false;
                        //    DCOT_Venta40MSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Venta de 40", "Detalle Cotización");
                        //    m_mensajeError += "* Debe ingresar el campo Venta de 40" + Environment.NewLine;
                        //}
                        DCOT_VentaSada40MSGERROR = "";
                        //if (DCOT_VentaSada40 == 0)
                        //{
                        //    _isCorrect = false;
                        //    DCOT_VentaSada40MSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Venta Sada de 40", "Detalle Cotización");
                        //    m_mensajeError += "* Debe ingresar el campo Venta Sada de 40" + Environment.NewLine;
                        //}
                        DCOT_VentaHBLMSGERROR = "";
                        DCOT_VentaSadaHBLMSGERROR = "";
                        //if (TIPE_Codigo != null && TIPE_Codigo.Value.ToString(CultureInfo.InvariantCulture).Equals("13"))
                        //{
                        //    if (DCOT_VentaHBL == 0)
                        //    {
                        //        _isCorrect = false;
                        //        DCOT_VentaHBLMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Venta HBL", "Detalle Cotización");
                        //        m_mensajeError += "* Debe ingresar el campo Venta HBL" + Environment.NewLine;
                        //    }
                        //    if (DCOT_VentaSadaHBL == 0)
                        //    {
                        //        _isCorrect = false;
                        //        DCOT_VentaSadaHBLMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Venta Sada HBL", "Detalle Cotización");
                        //        m_mensajeError += "* Debe ingresar el campo Venta Sada HBL" + Environment.NewLine;
                        //    }
                        //}
                        break;
                    case "A": /*  Aduanero  */
                        if (DCOT_Venta == 0)
                        {
                            _isCorrect = false;
                            DCOT_VentaMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Comisión", "Detalle Cotización");
                            m_mensajeError += "* Debe ingresar el Comisión" + Environment.NewLine;
                        }
                        if (String.IsNullOrEmpty(CONS_CodBas))
                        {
                            _isCorrect = false;
                            CONS_CodBasMSGERROR = String.Format("Debe seleccionar la {0} del {1}.", "Base", "Detalle Cotización");
                            m_mensajeError += "* Debe seleccionar el campo Base" + Environment.NewLine;
                        }
                        break;
                    case "T": /*  Transportista  */

                        if (String.IsNullOrEmpty(CONS_CodTRA))
                        {
                            _isCorrect = false;
                            CONS_CodTRAMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo", "Detalle Cotización");
                            m_mensajeError += "* Debe seleccionar el campo Tipo" + Environment.NewLine;
                        }
                        if (String.IsNullOrEmpty(TIPO_CodZONOrigen))
                        {
                            _isCorrect = false;
                            TIPO_CodZONOrigenMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Origen", "Detalle Cotización");
                            m_mensajeError += "* Debe seleccionar el campo Origen" + Environment.NewLine;
                        }
                        if (String.IsNullOrEmpty(TIPO_CodZONDestino))
                        {
                            _isCorrect = false;
                            TIPO_CodZONDestinoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Destino", "Detalle Cotización");
                            m_mensajeError += "* Debe seleccionar el campo Destino" + Environment.NewLine;
                        }
                        if (DCOT_Venta == null)
                        {
                            _isCorrect = false;
                            DCOT_VentaMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Flete", "Detalle Cotización");
                            m_mensajeError += "* Debe ingresar el campo Flete" + Environment.NewLine;
                        }
                        if (String.IsNullOrEmpty(CONS_CodBas))
                        {
                            _isCorrect = false;
                            CONS_CodBasMSGERROR = String.Format("Debe seleccionar la {0} del {1}.", "Base", "Detalle Cotización");
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
