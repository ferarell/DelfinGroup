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
	public partial class Det_Cotizacion_OV_Documento : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_ccot_numero;
		private Int32 m_doov_codigo;
		private Int16 m_ccot_tipo;
		private String m_doov_viaje;
		private String m_doov_feeder;
		private Nullable<DateTime> m_doov_eta;
		private Nullable<DateTime> m_doov_etdf;
		private Nullable<DateTime> m_doov_etdm;
		private String m_doov_cntr;
		private String m_doov_hbl;
		private String m_doov_mbl;
		private String m_doov_codreferencia;
		private String m_tipo_tabdtm;
		private String m_tipo_coddtm;
		private String m_tipo_tabvapor;
		private String m_tipo_codvapor;
		private String m_audi_usrcrea;
		private Nullable<DateTime> m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Det_Cotizacion_OV_Documento.
		/// </summary>
		public Det_Cotizacion_OV_Documento()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public Int32 CCOT_Numero
		{
			get { return m_ccot_numero; }
			set
			{
				if (m_ccot_numero != value)
				{
					m_ccot_numero = value;
					OnPropertyChanged("CCOT_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOOV_Codigo.
		/// </summary>
		[DataMember]
		public Int32 DOOV_Codigo
		{
			get { return m_doov_codigo; }
			set
			{
				if (m_doov_codigo != value)
				{
					m_doov_codigo = value;
					OnPropertyChanged("DOOV_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public Int16 CCOT_Tipo
		{
			get { return m_ccot_tipo; }
			set
			{
				if (m_ccot_tipo != value)
				{
					m_ccot_tipo = value;
					OnPropertyChanged("CCOT_Tipo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOOV_Viaje.
		/// </summary>
		[DataMember]
		public String DOOV_Viaje
		{
			get { return m_doov_viaje; }
			set
			{
				if (m_doov_viaje != value)
				{
					m_doov_viaje = value;
					OnPropertyChanged("DOOV_Viaje");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOOV_Feeder.
		/// </summary>
		[DataMember]
		public String DOOV_Feeder
		{
			get { return m_doov_feeder; }
			set
			{
				if (m_doov_feeder != value)
				{
					m_doov_feeder = value;
					OnPropertyChanged("DOOV_Feeder");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOOV_ETA.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> DOOV_ETA
		{
			get { return m_doov_eta; }
			set
			{
				if (m_doov_eta != value)
				{
					m_doov_eta = value;
					OnPropertyChanged("DOOV_ETA");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOOV_ETDF.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> DOOV_ETDF
		{
			get { return m_doov_etdf; }
			set
			{
				if (m_doov_etdf != value)
				{
					m_doov_etdf = value;
					OnPropertyChanged("DOOV_ETDF");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOOV_ETDM.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> DOOV_ETDM
		{
			get { return m_doov_etdm; }
			set
			{
				if (m_doov_etdm != value)
				{
					m_doov_etdm = value;
					OnPropertyChanged("DOOV_ETDM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOOV_Cntr.
		/// </summary>
		[DataMember]
		public String DOOV_Cntr
		{
			get { return m_doov_cntr; }
			set
			{
				if (m_doov_cntr != value)
				{
					m_doov_cntr = value;
					OnPropertyChanged("DOOV_Cntr");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOOV_HBL.
		/// </summary>
		[DataMember]
		public String DOOV_HBL
		{
			get { return m_doov_hbl; }
			set
			{
				if (m_doov_hbl != value)
				{
					m_doov_hbl = value;
					OnPropertyChanged("DOOV_HBL");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOOV_MBL.
		/// </summary>
		[DataMember]
		public String DOOV_MBL
		{
			get { return m_doov_mbl; }
			set
			{
				if (m_doov_mbl != value)
				{
					m_doov_mbl = value;
					OnPropertyChanged("DOOV_MBL");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOOV_CodReferencia.
		/// </summary>
		[DataMember]
		public String DOOV_CodReferencia
		{
			get { return m_doov_codreferencia; }
			set
			{
				if (m_doov_codreferencia != value)
				{
					m_doov_codreferencia = value;
					OnPropertyChanged("DOOV_CodReferencia");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabDTM.
		/// </summary>
		[DataMember]
		public String TIPO_TabDTM
		{
			get { return m_tipo_tabdtm; }
			set
			{
				if (m_tipo_tabdtm != value)
				{
					m_tipo_tabdtm = value;
					OnPropertyChanged("TIPO_TabDTM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodDTM.
		/// </summary>
		[DataMember]
		public String TIPO_CodDTM
		{
			get { return m_tipo_coddtm; }
			set
			{
				if (m_tipo_coddtm != value)
				{
					m_tipo_coddtm = value;
					OnPropertyChanged("TIPO_CodDTM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabVapor.
		/// </summary>
		[DataMember]
		public String TIPO_TabVapor
		{
			get { return m_tipo_tabvapor; }
			set
			{
				if (m_tipo_tabvapor != value)
				{
					m_tipo_tabvapor = value;
					OnPropertyChanged("TIPO_TabVapor");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodVapor.
		/// </summary>
		[DataMember]
		public String TIPO_CodVapor
		{
			get { return m_tipo_codvapor; }
			set
			{
				if (m_tipo_codvapor != value)
				{
					m_tipo_codvapor = value;
					OnPropertyChanged("TIPO_CodVapor");
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
		public Nullable<DateTime> AUDI_FecCrea
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
		public void CopyTo(ref Det_Cotizacion_OV_Documento Item)
		{
			try
			{
				if (Item == null) { Item = new Det_Cotizacion_OV_Documento(); }
				Item.CCOT_Numero = this.CCOT_Numero;
				Item.DOOV_Codigo = this.DOOV_Codigo;
				Item.CCOT_Tipo = this.CCOT_Tipo;
				Item.DOOV_Viaje = this.DOOV_Viaje;
				Item.DOOV_Feeder = this.DOOV_Feeder;
				Item.DOOV_ETA = this.DOOV_ETA;
				Item.DOOV_ETDF = this.DOOV_ETDF;
				Item.DOOV_ETDM = this.DOOV_ETDM;
				Item.DOOV_Cntr = this.DOOV_Cntr;
				Item.DOOV_HBL = this.DOOV_HBL;
				Item.DOOV_MBL = this.DOOV_MBL;
				Item.DOOV_CodReferencia = this.DOOV_CodReferencia;
				Item.TIPO_TabDTM = this.TIPO_TabDTM;
				Item.TIPO_CodDTM = this.TIPO_CodDTM;
				Item.TIPO_TabVapor = this.TIPO_TabVapor;
				Item.TIPO_CodVapor = this.TIPO_CodVapor;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
