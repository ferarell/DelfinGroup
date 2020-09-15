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
	public partial class PreFacturacion : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private String m_pfac_numero;
		private Nullable<DateTime> m_pfac_fecemi;
		private String m_pfac_estado;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		private Nullable<DateTime> m_pfac_fecaprobacion;
		private Nullable<DateTime> m_pfac_feccancelacion;
		private String m_pfac_usrcancelacion;
		private String m_pfac_usraprobacion;
		private Nullable<Int32> m_nvia_codigo;
		private Nullable<Int32> m_ccot_numero;
		private Nullable<Int16> m_ccot_tipo;
		private Nullable<Int16> m_empr_codigo;
		private Nullable<Int16> m_sucr_codigo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase PreFacturacion.
		/// </summary>
		public PreFacturacion()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: PFAC_Numero.
		/// </summary>
		[DataMember]
		public String PFAC_Numero
		{
			get { return m_pfac_numero; }
			set
			{
				if (m_pfac_numero != value)
				{
					m_pfac_numero = value;
					OnPropertyChanged("PFAC_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PFAC_FecEmi.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> PFAC_FecEmi
		{
			get { return m_pfac_fecemi; }
			set
			{
				if (m_pfac_fecemi != value)
				{
					m_pfac_fecemi = value;
					OnPropertyChanged("PFAC_FecEmi");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PFAC_Estado.
		/// </summary>
		[DataMember]
		public String PFAC_Estado
		{
			get { return m_pfac_estado; }
			set
			{
				if (m_pfac_estado != value)
				{
					m_pfac_estado = value;
					OnPropertyChanged("PFAC_Estado");
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
		/// <summary>
		/// Gets or sets el valor de: PFAC_FecAprobacion.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> PFAC_FecAprobacion
		{
			get { return m_pfac_fecaprobacion; }
			set
			{
				if (m_pfac_fecaprobacion != value)
				{
					m_pfac_fecaprobacion = value;
					OnPropertyChanged("PFAC_FecAprobacion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PFAC_FecCancelacion.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> PFAC_FecCancelacion
		{
			get { return m_pfac_feccancelacion; }
			set
			{
				if (m_pfac_feccancelacion != value)
				{
					m_pfac_feccancelacion = value;
					OnPropertyChanged("PFAC_FecCancelacion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PFAC_UsrCancelacion.
		/// </summary>
		[DataMember]
		public String PFAC_UsrCancelacion
		{
			get { return m_pfac_usrcancelacion; }
			set
			{
				if (m_pfac_usrcancelacion != value)
				{
					m_pfac_usrcancelacion = value;
					OnPropertyChanged("PFAC_UsrCancelacion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PFAC_UsrAprobacion.
		/// </summary>
		[DataMember]
		public String PFAC_UsrAprobacion
		{
			get { return m_pfac_usraprobacion; }
			set
			{
				if (m_pfac_usraprobacion != value)
				{
					m_pfac_usraprobacion = value;
					OnPropertyChanged("PFAC_UsrAprobacion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NVIA_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> NVIA_Codigo
		{
			get { return m_nvia_codigo; }
			set
			{
				if (m_nvia_codigo != value)
				{
					m_nvia_codigo = value;
					OnPropertyChanged("NVIA_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CCOT_Numero
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
		/// Gets or sets el valor de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> CCOT_Tipo
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
		/// Gets or sets el valor de: EMPR_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> EMPR_Codigo
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref PreFacturacion Item)
		{
			try
			{
				if (Item == null) { Item = new PreFacturacion(); }
				Item.PFAC_Numero = this.PFAC_Numero;
				Item.PFAC_FecEmi = this.PFAC_FecEmi;
				Item.PFAC_Estado = this.PFAC_Estado;
				Item.PFAC_FecAprobacion = this.PFAC_FecAprobacion;
				Item.PFAC_FecCancelacion = this.PFAC_FecCancelacion;
				Item.PFAC_UsrCancelacion = this.PFAC_UsrCancelacion;
				Item.PFAC_UsrAprobacion = this.PFAC_UsrAprobacion;
				Item.NVIA_Codigo = this.NVIA_Codigo;
				Item.CCOT_Numero = this.CCOT_Numero;
				Item.CCOT_Tipo = this.CCOT_Tipo;
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.SUCR_Codigo = this.SUCR_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
