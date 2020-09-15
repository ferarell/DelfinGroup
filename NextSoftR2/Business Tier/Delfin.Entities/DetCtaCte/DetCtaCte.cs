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
	[Serializable()]
	public partial class DetCtaCte : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private Int32 m_ccct_codigo;
		private Int16 m_dcct_item;
		private Nullable<Int32> m_movi_codigo;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private String m_cons_tabtdc;
		private String m_cons_codtdc;
		private Nullable<Int32> m_ccct_codreferencia;
		private Nullable<Int16> m_dcct_itemreferencia;
		private String m_dcct_tipopago;
		private DateTime m_dcct_fechatrans;
		private Decimal m_dcct_tipocambio;
		private Decimal m_dcct_montodebe;
		private Decimal m_dcct_montohaber;
		private Decimal m_dcct_montodebed;
		private Decimal m_dcct_montohaberd;
		private Nullable<Decimal> m_dcct_ppago;
		private Nullable<Decimal> m_dcct_ppagod;
		private Nullable<Boolean> m_dcct_pagodetraccion;
      private String m_tipo_tabdes;
      private String m_tipo_coddes;
      private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase DetCtaCte.
		/// </summary>
		public DetCtaCte()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: EMPR_Codigo.
		/// </summary>
		[DataMember]
		public Int16 EMPR_Codigo
		{
			get { return m_empr_codigo; }
			set
			{
				if (m_empr_codigo != value)
				{
					m_empr_codigo = value;
					OnPropertyChanged("EMPR_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCCT_Codigo.
		/// </summary>
		[DataMember]
		public Int32 CCCT_Codigo
		{
			get { return m_ccct_codigo; }
			set
			{
				if (m_ccct_codigo != value)
				{
					m_ccct_codigo = value;
					OnPropertyChanged("CCCT_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCT_Item.
		/// </summary>
		[DataMember]
		public Int16 DCCT_Item
		{
			get { return m_dcct_item; }
			set
			{
				if (m_dcct_item != value)
				{
					m_dcct_item = value;
					OnPropertyChanged("DCCT_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: MOVI_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> MOVI_Codigo
		{
			get { return m_movi_codigo; }
			set
			{
				if (m_movi_codigo != value)
				{
					m_movi_codigo = value;
					OnPropertyChanged("MOVI_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabMND.
		/// </summary>
		[DataMember]
		public String TIPO_TabMND
		{
			get { return m_tipo_tabmnd; }
			set
			{
				if (m_tipo_tabmnd != value)
				{
					m_tipo_tabmnd = value;
					OnPropertyChanged("TIPO_TabMND");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodMND.
		/// </summary>
		[DataMember]
		public String TIPO_CodMND
		{
			get { return m_tipo_codmnd; }
			set
			{
				if (m_tipo_codmnd != value)
				{
					m_tipo_codmnd = value;
					OnPropertyChanged("TIPO_CodMND");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabTDC.
		/// </summary>
		[DataMember]
		public String CONS_TabTDC
		{
			get { return m_cons_tabtdc; }
			set
			{
				if (m_cons_tabtdc != value)
				{
					m_cons_tabtdc = value;
					OnPropertyChanged("CONS_TabTDC");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodTDC.
		/// </summary>
		[DataMember]
		public String CONS_CodTDC
		{
			get { return m_cons_codtdc; }
			set
			{
				if (m_cons_codtdc != value)
				{
					m_cons_codtdc = value;
					OnPropertyChanged("CONS_CodTDC");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCCT_CodReferencia.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CCCT_CodReferencia
		{
			get { return m_ccct_codreferencia; }
			set
			{
				if (m_ccct_codreferencia != value)
				{
					m_ccct_codreferencia = value;
					OnPropertyChanged("CCCT_CodReferencia");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCT_ItemReferencia.
		/// </summary>
		[DataMember]
		public Nullable<Int16> DCCT_ItemReferencia
		{
			get { return m_dcct_itemreferencia; }
			set
			{
				if (m_dcct_itemreferencia != value)
				{
					m_dcct_itemreferencia = value;
					OnPropertyChanged("DCCT_ItemReferencia");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCT_TipoPago.
		/// </summary>
		[DataMember]
		public String DCCT_TipoPago
		{
			get { return m_dcct_tipopago; }
			set
			{
				if (m_dcct_tipopago != value)
				{
					m_dcct_tipopago = value;
					OnPropertyChanged("DCCT_TipoPago");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCT_FechaTrans.
		/// </summary>
		[DataMember]
		public DateTime DCCT_FechaTrans
		{
			get { return m_dcct_fechatrans; }
			set
			{
				if (m_dcct_fechatrans != value)
				{
					m_dcct_fechatrans = value;
					OnPropertyChanged("DCCT_FechaTrans");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCT_TipoCambio.
		/// </summary>
		[DataMember]
		public Decimal DCCT_TipoCambio
		{
			get { return m_dcct_tipocambio; }
			set
			{
				if (m_dcct_tipocambio != value)
				{
					m_dcct_tipocambio = value;
					OnPropertyChanged("DCCT_TipoCambio");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCT_MontoDebe.
		/// </summary>
		[DataMember]
		public Decimal DCCT_MontoDebe
		{
			get { return m_dcct_montodebe; }
			set
			{
				if (m_dcct_montodebe != value)
				{
					m_dcct_montodebe = value;
					OnPropertyChanged("DCCT_MontoDebe");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCT_MontoHaber.
		/// </summary>
		[DataMember]
		public Decimal DCCT_MontoHaber
		{
			get { return m_dcct_montohaber; }
			set
			{
				if (m_dcct_montohaber != value)
				{
					m_dcct_montohaber = value;
					OnPropertyChanged("DCCT_MontoHaber");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCT_MontoDebeD.
		/// </summary>
		[DataMember]
		public Decimal DCCT_MontoDebeD
		{
			get { return m_dcct_montodebed; }
			set
			{
				if (m_dcct_montodebed != value)
				{
					m_dcct_montodebed = value;
					OnPropertyChanged("DCCT_MontoDebeD");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCT_MontoHaberD.
		/// </summary>
		[DataMember]
		public Decimal DCCT_MontoHaberD
		{
			get { return m_dcct_montohaberd; }
			set
			{
				if (m_dcct_montohaberd != value)
				{
					m_dcct_montohaberd = value;
					OnPropertyChanged("DCCT_MontoHaberD");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCT_PPago.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DCCT_PPago
		{
			get { return m_dcct_ppago; }
			set
			{
				if (m_dcct_ppago != value)
				{
					m_dcct_ppago = value;
					OnPropertyChanged("DCCT_PPago");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCT_PPagoD.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DCCT_PPagoD
		{
			get { return m_dcct_ppagod; }
			set
			{
				if (m_dcct_ppagod != value)
				{
					m_dcct_ppagod = value;
					OnPropertyChanged("DCCT_PPagoD");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCT_PagoDetraccion.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> DCCT_PagoDetraccion
		{
			get { return m_dcct_pagodetraccion; }
			set
			{
				if (m_dcct_pagodetraccion != value)
				{
					m_dcct_pagodetraccion = value;
					OnPropertyChanged("DCCT_PagoDetraccion");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabDES.
      /// </summary>
      [DataMember]
      public String TIPO_TabDES
      {
         get { return m_tipo_tabdes; }
         set
         {
            if (m_tipo_tabdes != value)
            {
               m_tipo_tabdes = value;
               OnPropertyChanged("TIPO_TabDES");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodDES.
      /// </summary>
      [DataMember]
      public String TIPO_CodDES
      {
         get { return m_tipo_coddes; }
         set
         {
            if (m_tipo_coddes != value)
            {
               m_tipo_coddes = value;
               OnPropertyChanged("TIPO_CodDES");
            }
         }
      }
		/// <summary>
		/// Gets or sets el valor de: AUDI_UsrCrea.
		/// </summary>
		[DataMember]
		public String AUDI_UsrCrea
		{
			get { return m_audi_usrcrea; }
			set
			{
				if (m_audi_usrcrea != value)
				{
					m_audi_usrcrea = value;
					OnPropertyChanged("AUDI_UsrCrea");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_FecCrea.
		/// </summary>
		[DataMember]
		public DateTime AUDI_FecCrea
		{
			get { return m_audi_feccrea; }
			set
			{
				if (m_audi_feccrea != value)
				{
					m_audi_feccrea = value;
					OnPropertyChanged("AUDI_FecCrea");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_UsrMod.
		/// </summary>
		[DataMember]
		public String AUDI_UsrMod
		{
			get { return m_audi_usrmod; }
			set
			{
				if (m_audi_usrmod != value)
				{
					m_audi_usrmod = value;
					OnPropertyChanged("AUDI_UsrMod");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_FecMod.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> AUDI_FecMod
		{
			get { return m_audi_fecmod; }
			set
			{
				if (m_audi_fecmod != value)
				{
					m_audi_fecmod = value;
					OnPropertyChanged("AUDI_FecMod");
				}
			}
		}
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref DetCtaCte Item)
		{
			try
			{
				if (Item == null) { Item = new DetCtaCte(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.CCCT_Codigo = this.CCCT_Codigo;
				Item.DCCT_Item = this.DCCT_Item;
				Item.MOVI_Codigo = this.MOVI_Codigo;
				Item.TIPO_TabMND = this.TIPO_TabMND;
				Item.TIPO_CodMND = this.TIPO_CodMND;
				Item.CONS_TabTDC = this.CONS_TabTDC;
				Item.CONS_CodTDC = this.CONS_CodTDC;
				Item.CCCT_CodReferencia = this.CCCT_CodReferencia;
				Item.DCCT_ItemReferencia = this.DCCT_ItemReferencia;
				Item.DCCT_TipoPago = this.DCCT_TipoPago;
				Item.DCCT_FechaTrans = this.DCCT_FechaTrans;
				Item.DCCT_TipoCambio = this.DCCT_TipoCambio;
				Item.DCCT_MontoDebe = this.DCCT_MontoDebe;
				Item.DCCT_MontoHaber = this.DCCT_MontoHaber;
				Item.DCCT_MontoDebeD = this.DCCT_MontoDebeD;
				Item.DCCT_MontoHaberD = this.DCCT_MontoHaberD;
				Item.DCCT_PPago = this.DCCT_PPago;
				Item.DCCT_PPagoD = this.DCCT_PPagoD;
				Item.DCCT_PagoDetraccion = this.DCCT_PagoDetraccion;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
