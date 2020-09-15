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
	public partial class Tipificaciones : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_movi_codigo;
		private Int16 m_empr_codigo;
		private Int16 m_tipd_item;
		private Decimal m_tipd_tipocambio;
		private Decimal m_tipd_montodebe;
		private Decimal m_tipd_montohaber;
		private String m_tipd_tipo;
		private Boolean m_tipd_generactacte;
		private String m_tipd_cuenta;
		private String m_cent_ano;
		private String m_cent_codigo;
		private String m_tipo_tabdes;
		private String m_tipo_coddes;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private String m_tipo_tabtdo;
		private String m_tipo_codtdo;
		private Nullable<Int16> m_tipe_codigo;
		private Nullable<Int32> m_entc_codigo;
		private Nullable<Int32> m_ccct_codigo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Tipificaciones.
		/// </summary>
		public Tipificaciones()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: MOVI_Codigo.
		/// </summary>
		[DataMember]
		public Int32 MOVI_Codigo
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
		/// Gets or sets el valor de: TIPD_Item.
		/// </summary>
		[DataMember]
		public Int16 TIPD_Item
		{
			get { return m_tipd_item; }
			set
			{
				if (m_tipd_item != value)
				{
					m_tipd_item = value;
					OnPropertyChanged("TIPD_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPD_TipoCambio.
		/// </summary>
		[DataMember]
		public Decimal TIPD_TipoCambio
		{
			get { return m_tipd_tipocambio; }
			set
			{
				if (m_tipd_tipocambio != value)
				{
					m_tipd_tipocambio = value;
					OnPropertyChanged("TIPD_TipoCambio");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPD_MontoDebe.
		/// </summary>
		[DataMember]
		public Decimal TIPD_MontoDebe
		{
			get { return m_tipd_montodebe; }
			set
			{
				if (m_tipd_montodebe != value)
				{
					m_tipd_montodebe = value;
					OnPropertyChanged("TIPD_MontoDebe");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPD_MontoHaber.
		/// </summary>
		[DataMember]
		public Decimal TIPD_MontoHaber
		{
			get { return m_tipd_montohaber; }
			set
			{
				if (m_tipd_montohaber != value)
				{
					m_tipd_montohaber = value;
					OnPropertyChanged("TIPD_MontoHaber");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPD_Tipo.
		/// </summary>
		[DataMember]
		public String TIPD_Tipo
		{
			get { return m_tipd_tipo; }
			set
			{
				if (m_tipd_tipo != value)
				{
					m_tipd_tipo = value;
					OnPropertyChanged("TIPD_Tipo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPD_GeneraCtaCte.
		/// </summary>
		[DataMember]
		public Boolean TIPD_GeneraCtaCte
		{
			get { return m_tipd_generactacte; }
			set
			{
				if (m_tipd_generactacte != value)
				{
					m_tipd_generactacte = value;
					OnPropertyChanged("TIPD_GeneraCtaCte");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPD_Cuenta.
		/// </summary>
		[DataMember]
		public String TIPD_Cuenta
		{
			get { return m_tipd_cuenta; }
			set
			{
				if (m_tipd_cuenta != value)
				{
					m_tipd_cuenta = value;
					OnPropertyChanged("TIPD_Cuenta");
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
		/// Gets or sets el valor de: TIPO_TabTDO.
		/// </summary>
		[DataMember]
		public String TIPO_TabTDO
		{
			get { return m_tipo_tabtdo; }
			set
			{
				if (m_tipo_tabtdo != value)
				{
					m_tipo_tabtdo = value;
					OnPropertyChanged("TIPO_TabTDO");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodTDO.
		/// </summary>
		[DataMember]
		public String TIPO_CodTDO
		{
			get { return m_tipo_codtdo; }
			set
			{
				if (m_tipo_codtdo != value)
				{
					m_tipo_codtdo = value;
					OnPropertyChanged("TIPO_CodTDO");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPE_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> TIPE_Codigo
		{
			get { return m_tipe_codigo; }
			set
			{
				if (m_tipe_codigo != value)
				{
					m_tipe_codigo = value;
					OnPropertyChanged("TIPE_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_Codigo
		{
			get { return m_entc_codigo; }
			set
			{
				if (m_entc_codigo != value)
				{
					m_entc_codigo = value;
					OnPropertyChanged("ENTC_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCCT_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CCCT_Codigo
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
		public void CopyTo(ref Tipificaciones Item)
		{
			try
			{
				if (Item == null) { Item = new Tipificaciones(); }
				Item.MOVI_Codigo = this.MOVI_Codigo;
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.TIPD_Item = this.TIPD_Item;
				Item.TIPD_TipoCambio = this.TIPD_TipoCambio;
				Item.TIPD_MontoDebe = this.TIPD_MontoDebe;
				Item.TIPD_MontoHaber = this.TIPD_MontoHaber;
				Item.TIPD_Tipo = this.TIPD_Tipo;
				Item.TIPD_GeneraCtaCte = this.TIPD_GeneraCtaCte;
				Item.TIPD_Cuenta = this.TIPD_Cuenta;
				Item.CENT_Ano = this.CENT_Ano;
				Item.CENT_Codigo = this.CENT_Codigo;
				Item.TIPO_TabDES = this.TIPO_TabDES;
				Item.TIPO_CodDES = this.TIPO_CodDES;
				Item.TIPO_TabMND = this.TIPO_TabMND;
				Item.TIPO_CodMND = this.TIPO_CodMND;
				Item.TIPO_TabTDO = this.TIPO_TabTDO;
				Item.TIPO_CodTDO = this.TIPO_CodTDO;
				Item.TIPE_Codigo = this.TIPE_Codigo;
				Item.ENTC_Codigo = this.ENTC_Codigo;
				Item.CCCT_Codigo = this.CCCT_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
