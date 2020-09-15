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
	public partial class CierresChangeControl : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private Int16 m_sucr_codigo;
		private Int16 m_chan_anio;
		private Int16 m_chan_mes;
		private String m_chan_estado;
		private String m_chan_usuariocierre;
		private Nullable<DateTime> m_chan_fechacierre;
		private String m_chan_usuarioapertura;
		private Nullable<DateTime> m_chan_fechaapertura;
		private String m_caba_ano;
		private String m_caba_mes;
		private String m_tipo_tabreg;
		private String m_tipo_codreg;
		private String m_caba_nrovoucher;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase CierresChangeControl.
		/// </summary>
		public CierresChangeControl()
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
		/// Gets or sets el valor de: CHAN_Anio.
		/// </summary>
		[DataMember]
		public Int16 CHAN_Anio
		{
			get { return m_chan_anio; }
			set
			{
				if (m_chan_anio != value)
				{
					m_chan_anio = value;
					OnPropertyChanged("CHAN_Anio");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CHAN_Mes.
		/// </summary>
		[DataMember]
		public Int16 CHAN_Mes
		{
			get { return m_chan_mes; }
			set
			{
				if (m_chan_mes != value)
				{
					m_chan_mes = value;
					OnPropertyChanged("CHAN_Mes");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CHAN_Estado.
		/// </summary>
		[DataMember]
		public String CHAN_Estado
		{
			get { return m_chan_estado; }
			set
			{
				if (m_chan_estado != value)
				{
					m_chan_estado = value;
					OnPropertyChanged("CHAN_Estado");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CHAN_UsuarioCierre.
		/// </summary>
		[DataMember]
		public String CHAN_UsuarioCierre
		{
			get { return m_chan_usuariocierre; }
			set
			{
				if (m_chan_usuariocierre != value)
				{
					m_chan_usuariocierre = value;
					OnPropertyChanged("CHAN_UsuarioCierre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CHAN_FechaCierre.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CHAN_FechaCierre
		{
			get { return m_chan_fechacierre; }
			set
			{
				if (m_chan_fechacierre != value)
				{
					m_chan_fechacierre = value;
					OnPropertyChanged("CHAN_FechaCierre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CHAN_UsuarioApertura.
		/// </summary>
		[DataMember]
		public String CHAN_UsuarioApertura
		{
			get { return m_chan_usuarioapertura; }
			set
			{
				if (m_chan_usuarioapertura != value)
				{
					m_chan_usuarioapertura = value;
					OnPropertyChanged("CHAN_UsuarioApertura");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CHAN_FechaApertura.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CHAN_FechaApertura
		{
			get { return m_chan_fechaapertura; }
			set
			{
				if (m_chan_fechaapertura != value)
				{
					m_chan_fechaapertura = value;
					OnPropertyChanged("CHAN_FechaApertura");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CABA_Ano.
		/// </summary>
		[DataMember]
		public String CABA_Ano
		{
			get { return m_caba_ano; }
			set
			{
				if (m_caba_ano != value)
				{
					m_caba_ano = value;
					OnPropertyChanged("CABA_Ano");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CABA_Mes.
		/// </summary>
		[DataMember]
		public String CABA_Mes
		{
			get { return m_caba_mes; }
			set
			{
				if (m_caba_mes != value)
				{
					m_caba_mes = value;
					OnPropertyChanged("CABA_Mes");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabREG.
		/// </summary>
		[DataMember]
		public String TIPO_TabREG
		{
			get { return m_tipo_tabreg; }
			set
			{
				if (m_tipo_tabreg != value)
				{
					m_tipo_tabreg = value;
					OnPropertyChanged("TIPO_TabREG");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodREG.
		/// </summary>
		[DataMember]
		public String TIPO_CodREG
		{
			get { return m_tipo_codreg; }
			set
			{
				if (m_tipo_codreg != value)
				{
					m_tipo_codreg = value;
					OnPropertyChanged("TIPO_CodREG");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CABA_NroVoucher.
		/// </summary>
		[DataMember]
		public String CABA_NroVoucher
		{
			get { return m_caba_nrovoucher; }
			set
			{
				if (m_caba_nrovoucher != value)
				{
					m_caba_nrovoucher = value;
					OnPropertyChanged("CABA_NroVoucher");
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
		public void CopyTo(ref CierresChangeControl Item)
		{
			try
			{
				if (Item == null) { Item = new CierresChangeControl(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.SUCR_Codigo = this.SUCR_Codigo;
				Item.CHAN_Anio = this.CHAN_Anio;
				Item.CHAN_Mes = this.CHAN_Mes;
				Item.CHAN_Estado = this.CHAN_Estado;
				Item.CHAN_UsuarioCierre = this.CHAN_UsuarioCierre;
				Item.CHAN_FechaCierre = this.CHAN_FechaCierre;
				Item.CHAN_UsuarioApertura = this.CHAN_UsuarioApertura;
				Item.CHAN_FechaApertura = this.CHAN_FechaApertura;
				Item.CABA_Ano = this.CABA_Ano;
				Item.CABA_Mes = this.CABA_Mes;
				Item.TIPO_TabREG = this.TIPO_TabREG;
				Item.TIPO_CodREG = this.TIPO_CodREG;
				Item.CABA_NroVoucher = this.CABA_NroVoucher;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
