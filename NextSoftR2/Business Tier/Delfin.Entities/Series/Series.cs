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
	public partial class Series : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private String m_seri_serie;
		private String m_tipo_tabtdo;
		private String m_tipo_codtdo;
		private Nullable<Int16> m_sucr_codigo;
      private Nullable<Int32> m_seri_ultnumero;
      private Nullable<Int16> m_seri_maxitems;
      private Nullable<Int16> m_seri_numinicial;
		private Nullable<Int16> m_seri_numfinal;
		private String m_seri_desc;
		private Nullable<Boolean> m_seri_activo;
		private String m_seri_unidadnegocio;
		private String m_seri_impresora;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Series.
		/// </summary>
		public Series()
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
		/// Gets or sets el valor de: SERI_Serie.
		/// </summary>
		[DataMember]
		public String SERI_Serie
		{
			get { return m_seri_serie; }
			set
			{
				if (m_seri_serie != value)
				{
					m_seri_serie = value;
					OnPropertyChanged("SERI_Serie");
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
		/// Gets or sets el valor de: SUCR_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> SUCR_Codigo
		{
			get { return m_sucr_codigo; }
			set
			{
				if (m_sucr_codigo != value)
				{
					m_sucr_codigo = value;
					OnPropertyChanged("SUCR_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SERI_UltNumero.
		/// </summary>
		[DataMember]
      public Nullable<Int32> SERI_UltNumero
		{
			get { return m_seri_ultnumero; }
			set
			{
				if (m_seri_ultnumero != value)
				{
					m_seri_ultnumero = value;
					OnPropertyChanged("SERI_UltNumero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SERI_MaxItems.
		/// </summary>
		[DataMember]
		public Nullable<Int16> SERI_MaxItems
		{
			get { return m_seri_maxitems; }
			set
			{
				if (m_seri_maxitems != value)
				{
					m_seri_maxitems = value;
					OnPropertyChanged("SERI_MaxItems");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SERI_NumInicial.
		/// </summary>
		[DataMember]
		public Nullable<Int16> SERI_NumInicial
		{
			get { return m_seri_numinicial; }
			set
			{
				if (m_seri_numinicial != value)
				{
					m_seri_numinicial = value;
					OnPropertyChanged("SERI_NumInicial");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SERI_NumFinal.
		/// </summary>
		[DataMember]
		public Nullable<Int16> SERI_NumFinal
		{
			get { return m_seri_numfinal; }
			set
			{
				if (m_seri_numfinal != value)
				{
					m_seri_numfinal = value;
					OnPropertyChanged("SERI_NumFinal");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SERI_Desc.
		/// </summary>
		[DataMember]
		public String SERI_Desc
		{
			get { return m_seri_desc; }
			set
			{
				if (m_seri_desc != value)
				{
					m_seri_desc = value;
					OnPropertyChanged("SERI_Desc");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SERI_Activo.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> SERI_Activo
		{
			get { return m_seri_activo; }
			set
			{
				if (m_seri_activo != value)
				{
					m_seri_activo = value;
					OnPropertyChanged("SERI_Activo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SERI_UnidadNegocio.
		/// </summary>
		[DataMember]
		public String SERI_UnidadNegocio
		{
			get { return m_seri_unidadnegocio; }
			set
			{
				if (m_seri_unidadnegocio != value)
				{
					m_seri_unidadnegocio = value;
					OnPropertyChanged("SERI_UnidadNegocio");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SERI_Impresora.
		/// </summary>
		[DataMember]
		public String SERI_Impresora
		{
			get { return m_seri_impresora; }
			set
			{
				if (m_seri_impresora != value)
				{
					m_seri_impresora = value;
					OnPropertyChanged("SERI_Impresora");
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
		public void CopyTo(ref Series Item)
		{
			try
			{
				if (Item == null) { Item = new Series(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.SERI_Serie = this.SERI_Serie;
				Item.TIPO_TabTDO = this.TIPO_TabTDO;
				Item.TIPO_CodTDO = this.TIPO_CodTDO;
				Item.SUCR_Codigo = this.SUCR_Codigo;
				Item.SERI_UltNumero = this.SERI_UltNumero;
				Item.SERI_MaxItems = this.SERI_MaxItems;
				Item.SERI_NumInicial = this.SERI_NumInicial;
				Item.SERI_NumFinal = this.SERI_NumFinal;
				Item.SERI_Desc = this.SERI_Desc;
				Item.SERI_Activo = this.SERI_Activo;
				Item.SERI_UnidadNegocio = this.SERI_UnidadNegocio;
				Item.SERI_Impresora = this.SERI_Impresora;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
