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
	public partial class DetCtaCteAsientos : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private Int32 m_ccct_codigo;
		private Int16 m_dcca_item;
		private String m_dcca_cuenta;
		private String m_dcca_glosa;
		private Decimal m_dcca_debeporc;
		private Decimal m_dcca_debemonto;
		private Decimal m_dcca_haberporc;
		private Decimal m_dcca_habermonto;
		private String m_cabp_ano;
		private String m_cabp_codigo;
		private Nullable<Int16> m_detp_item;
		private String m_cent_ano;
		private String m_cent_codigo;
		private String m_tipo_tabope;
		private String m_tipo_codope;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase DetCtaCteAsientos.
		/// </summary>
		public DetCtaCteAsientos()
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
		/// Gets or sets el valor de: DCCA_Item.
		/// </summary>
		[DataMember]
		public Int16 DCCA_Item
		{
			get { return m_dcca_item; }
			set
			{
				if (m_dcca_item != value)
				{
					m_dcca_item = value;
					OnPropertyChanged("DCCA_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCA_Cuenta.
		/// </summary>
		[DataMember]
		public String DCCA_Cuenta
		{
			get { return m_dcca_cuenta; }
			set
			{
				if (m_dcca_cuenta != value)
				{
					m_dcca_cuenta = value;
					OnPropertyChanged("DCCA_Cuenta");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCA_Glosa.
		/// </summary>
		[DataMember]
		public String DCCA_Glosa
		{
			get { return m_dcca_glosa; }
			set
			{
				if (m_dcca_glosa != value)
				{
					m_dcca_glosa = value;
					OnPropertyChanged("DCCA_Glosa");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCA_DebePorc.
		/// </summary>
		[DataMember]
		public Decimal DCCA_DebePorc
		{
			get { return m_dcca_debeporc; }
			set
			{
				if (m_dcca_debeporc != value)
				{
					m_dcca_debeporc = value;
					OnPropertyChanged("DCCA_DebePorc");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCA_DebeMonto.
		/// </summary>
		[DataMember]
		public Decimal DCCA_DebeMonto
		{
			get { return m_dcca_debemonto; }
			set
			{
				if (m_dcca_debemonto != value)
				{
					m_dcca_debemonto = value;
					OnPropertyChanged("DCCA_DebeMonto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCA_HaberPorc.
		/// </summary>
		[DataMember]
		public Decimal DCCA_HaberPorc
		{
			get { return m_dcca_haberporc; }
			set
			{
				if (m_dcca_haberporc != value)
				{
					m_dcca_haberporc = value;
					OnPropertyChanged("DCCA_HaberPorc");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCCA_HaberMonto.
		/// </summary>
		[DataMember]
		public Decimal DCCA_HaberMonto
		{
			get { return m_dcca_habermonto; }
			set
			{
				if (m_dcca_habermonto != value)
				{
					m_dcca_habermonto = value;
					OnPropertyChanged("DCCA_HaberMonto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CABP_Ano.
		/// </summary>
		[DataMember]
		public String CABP_Ano
		{
			get { return m_cabp_ano; }
			set
			{
				if (m_cabp_ano != value)
				{
					m_cabp_ano = value;
					OnPropertyChanged("CABP_Ano");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CABP_Codigo.
		/// </summary>
		[DataMember]
		public String CABP_Codigo
		{
			get { return m_cabp_codigo; }
			set
			{
				if (m_cabp_codigo != value)
				{
					m_cabp_codigo = value;
					OnPropertyChanged("CABP_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DETP_Item.
		/// </summary>
		[DataMember]
		public Nullable<Int16> DETP_Item
		{
			get { return m_detp_item; }
			set
			{
				if (m_detp_item != value)
				{
					m_detp_item = value;
					OnPropertyChanged("DETP_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CENT_Ano.
		/// </summary>
		[DataMember]
		public String CENT_Ano
		{
			get { return m_cent_ano; }
			set
			{
				if (m_cent_ano != value)
				{
					m_cent_ano = value;
					OnPropertyChanged("CENT_Ano");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CENT_Codigo.
		/// </summary>
		[DataMember]
		public String CENT_Codigo
		{
			get { return m_cent_codigo; }
			set
			{
				if (m_cent_codigo != value)
				{
					m_cent_codigo = value;
					OnPropertyChanged("CENT_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabOPE.
		/// </summary>
		[DataMember]
		public String TIPO_TabOPE
		{
			get { return m_tipo_tabope; }
			set
			{
				if (m_tipo_tabope != value)
				{
					m_tipo_tabope = value;
					OnPropertyChanged("TIPO_TabOPE");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodOPE.
		/// </summary>
		[DataMember]
		public String TIPO_CodOPE
		{
			get { return m_tipo_codope; }
			set
			{
				if (m_tipo_codope != value)
				{
					m_tipo_codope = value;
					OnPropertyChanged("TIPO_CodOPE");
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
		public void CopyTo(ref DetCtaCteAsientos Item)
		{
			try
			{
				if (Item == null) { Item = new DetCtaCteAsientos(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.CCCT_Codigo = this.CCCT_Codigo;
				Item.DCCA_Item = this.DCCA_Item;
				Item.DCCA_Cuenta = this.DCCA_Cuenta;
				Item.DCCA_Glosa = this.DCCA_Glosa;
				Item.DCCA_DebePorc = this.DCCA_DebePorc;
				Item.DCCA_DebeMonto = this.DCCA_DebeMonto;
				Item.DCCA_HaberPorc = this.DCCA_HaberPorc;
				Item.DCCA_HaberMonto = this.DCCA_HaberMonto;
				Item.CABP_Ano = this.CABP_Ano;
				Item.CABP_Codigo = this.CABP_Codigo;
				Item.DETP_Item = this.DETP_Item;
				Item.CENT_Ano = this.CENT_Ano;
				Item.CENT_Codigo = this.CENT_Codigo;
				Item.TIPO_TabOPE = this.TIPO_TabOPE;
				Item.TIPO_CodOPE = this.TIPO_CodOPE;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
