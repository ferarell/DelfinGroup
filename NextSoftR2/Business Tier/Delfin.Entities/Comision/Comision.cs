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
	public partial class Comision : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private Int16 m_sucr_codigo;
		private Int32 m_comi_codigo;
      private Nullable<DateTime> m_comi_fecini;
      private Nullable<DateTime> m_comi_fecfin;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private DateTime m_audi_feccrea;
		private String m_audi_usrcrea;
		private Nullable<DateTime> m_audi_fecmod;
		private String m_audi_usrmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Comision.
		/// </summary>
		public Comision()
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
		/// Gets or sets el valor de: SUCR_Codigo.
		/// </summary>
		[DataMember]
		public Int16 SUCR_Codigo
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
		/// Gets or sets el valor de: COMI_Codigo.
		/// </summary>
		[DataMember]
		public Int32 COMI_Codigo
		{
			get { return m_comi_codigo; }
			set
			{
				if (m_comi_codigo != value)
				{
					m_comi_codigo = value;
					OnPropertyChanged("COMI_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COMI_FecIni.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> COMI_FecIni
		{
			get { return m_comi_fecini; }
			set
			{
				if (m_comi_fecini != value)
				{
					m_comi_fecini = value;
					OnPropertyChanged("COMI_FecIni");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COMI_FecFin.
		/// </summary>
		[DataMember]
      public Nullable<DateTime> COMI_FecFin
		{
			get { return m_comi_fecfin; }
			set
			{
				if (m_comi_fecfin != value)
				{
					m_comi_fecfin = value;
					OnPropertyChanged("COMI_FecFin");
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Comision Item)
		{
			try
			{
				if (Item == null) { Item = new Comision(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.SUCR_Codigo = this.SUCR_Codigo;
				Item.COMI_Codigo = this.COMI_Codigo;
				Item.COMI_FecIni = this.COMI_FecIni;
				Item.COMI_FecFin = this.COMI_FecFin;
				Item.TIPO_TabMND = this.TIPO_TabMND;
				Item.TIPO_CodMND = this.TIPO_CodMND;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
