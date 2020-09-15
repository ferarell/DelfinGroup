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
	public partial class Cab_Cotizacion : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_ccot_codigo;
		private String m_ccot_numdoc;
		private Nullable<DateTime> m_ccot_fecemi;
		private Nullable<DateTime> m_ccot_fecvcto;
		private String m_ccot_observaciones;
		private Int32 m_ccot_horalibre;
		private Int32? m_entc_codigo;
		private String m_cons_codestado;
		private String m_cons_tabestado;
		private String m_cons_codreg;
		private String m_cons_tabreg;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private Nullable<Int32> m_entc_codaduana;
		private Nullable<Int32> m_entc_codlogistico;
		private Nullable<Int32> m_entc_codtransporte;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Cab_Cotizacion.
		/// </summary>
		public Cab_Cotizacion()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CCOT_Codigo.
		/// </summary>
		[DataMember]
		public Int32 CCOT_Codigo
		{
			get { return m_ccot_codigo; }
			set
			{
				if (m_ccot_codigo != value)
				{
					m_ccot_codigo = value;
					OnPropertyChanged("CCOT_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_NumDoc.
		/// </summary>
		[DataMember]
		public String CCOT_NumDoc
		{
			get { return m_ccot_numdoc; }
			set
			{
				if (m_ccot_numdoc != value)
				{
					m_ccot_numdoc = value;
					OnPropertyChanged("CCOT_NumDoc");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_FecEmi.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CCOT_FecEmi
		{
			get { return m_ccot_fecemi; }
			set
			{
				if (m_ccot_fecemi != value)
				{
					m_ccot_fecemi = value;
					OnPropertyChanged("CCOT_FecEmi");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_FecVcto.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CCOT_FecVcto
		{
			get { return m_ccot_fecvcto; }
			set
			{
				if (m_ccot_fecvcto != value)
				{
					m_ccot_fecvcto = value;
					OnPropertyChanged("CCOT_FecVcto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Observaciones.
		/// </summary>
		[DataMember]
		public String CCOT_Observaciones
		{
			get { return m_ccot_observaciones; }
			set
			{
				if (m_ccot_observaciones != value)
				{
					m_ccot_observaciones = value;
					OnPropertyChanged("CCOT_Observaciones");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_HoraLibre.
		/// </summary>
		[DataMember]
		public Int32 CCOT_HoraLibre
		{
			get { return m_ccot_horalibre; }
			set
			{
				if (m_ccot_horalibre != value)
				{
					m_ccot_horalibre = value;
					OnPropertyChanged("CCOT_HoraLibre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Int32? ENTC_Codigo
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
		/// Gets or sets el valor de: CONS_CodEstado.
		/// </summary>
		[DataMember]
		public String CONS_CodEstado
		{
			get { return m_cons_codestado; }
			set
			{
				if (m_cons_codestado != value)
				{
					m_cons_codestado = value;
					OnPropertyChanged("CONS_CodEstado");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabEstado.
		/// </summary>
		[DataMember]
		public String CONS_TabEstado
		{
			get { return m_cons_tabestado; }
			set
			{
				if (m_cons_tabestado != value)
				{
					m_cons_tabestado = value;
					OnPropertyChanged("CONS_TabEstado");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodReg.
		/// </summary>
		[DataMember]
		public String CONS_CodReg
		{
			get { return m_cons_codreg; }
			set
			{
				if (m_cons_codreg != value)
				{
					m_cons_codreg = value;
					OnPropertyChanged("CONS_CodReg");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabReg.
		/// </summary>
		[DataMember]
		public String CONS_TabReg
		{
			get { return m_cons_tabreg; }
			set
			{
				if (m_cons_tabreg != value)
				{
					m_cons_tabreg = value;
					OnPropertyChanged("CONS_TabReg");
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
		/// Gets or sets el valor de: ENTC_CodAduana.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodAduana
		{
			get { return m_entc_codaduana; }
			set
			{
				if (m_entc_codaduana != value)
				{
					m_entc_codaduana = value;
					OnPropertyChanged("ENTC_CodAduana");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodLogistico.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodLogistico
		{
			get { return m_entc_codlogistico; }
			set
			{
				if (m_entc_codlogistico != value)
				{
					m_entc_codlogistico = value;
					OnPropertyChanged("ENTC_CodLogistico");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodTransporte.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodTransporte
		{
			get { return m_entc_codtransporte; }
			set
			{
				if (m_entc_codtransporte != value)
				{
					m_entc_codtransporte = value;
					OnPropertyChanged("ENTC_CodTransporte");
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
		public void CopyTo(ref Cab_Cotizacion Item)
		{
			try
			{
				if (Item == null) { Item = new Cab_Cotizacion(); }
				Item.CCOT_Codigo = this.CCOT_Codigo;
				Item.CCOT_NumDoc = this.CCOT_NumDoc;
				Item.CCOT_FecEmi = this.CCOT_FecEmi;
				Item.CCOT_FecVcto = this.CCOT_FecVcto;
				Item.CCOT_Observaciones = this.CCOT_Observaciones;
				Item.CCOT_HoraLibre = this.CCOT_HoraLibre;
				Item.ENTC_Codigo = this.ENTC_Codigo;
				Item.CONS_CodEstado = this.CONS_CodEstado;
				Item.CONS_TabEstado = this.CONS_TabEstado;
				Item.CONS_CodReg = this.CONS_CodReg;
				Item.CONS_TabReg = this.CONS_TabReg;
				Item.TIPO_TabMND = this.TIPO_TabMND;
				Item.TIPO_CodMND = this.TIPO_CodMND;
				Item.ENTC_CodAduana = this.ENTC_CodAduana;
				Item.ENTC_CodLogistico = this.ENTC_CodLogistico;
				Item.ENTC_CodTransporte = this.ENTC_CodTransporte;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
