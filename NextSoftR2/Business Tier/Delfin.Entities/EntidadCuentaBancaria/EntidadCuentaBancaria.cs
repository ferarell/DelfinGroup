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
	public partial class EntidadCuentaBancaria : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_entc_codigo;
		private String m_tipo_tabbco;
		private String m_tipo_codbco;
		private String m_encb_tipocuenta;
		private String m_encb_nrocuentasol;
		private String m_encb_nrocuentadol;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase EntidadCuentaBancaria.
		/// </summary>
		public EntidadCuentaBancaria()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Int32 ENTC_Codigo
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
		/// Gets or sets el valor de: TIPO_TabBCO.
		/// </summary>
		[DataMember]
		public String TIPO_TabBCO
		{
			get { return m_tipo_tabbco; }
			set
			{
				if (m_tipo_tabbco != value)
				{
					m_tipo_tabbco = value;
					OnPropertyChanged("TIPO_TabBCO");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodBCO.
		/// </summary>
		[DataMember]
		public String TIPO_CodBCO
		{
			get { return m_tipo_codbco; }
			set
			{
				if (m_tipo_codbco != value)
				{
					m_tipo_codbco = value;
					OnPropertyChanged("TIPO_CodBCO");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENCB_TipoCuenta.
		/// </summary>
		[DataMember]
		public String ENCB_TipoCuenta
		{
			get { return m_encb_tipocuenta; }
			set
			{
				if (m_encb_tipocuenta != value)
				{
					m_encb_tipocuenta = value;
					OnPropertyChanged("ENCB_TipoCuenta");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENCB_NroCuentaSol.
		/// </summary>
		[DataMember]
		public String ENCB_NroCuentaSol
		{
			get { return m_encb_nrocuentasol; }
			set
			{
				if (m_encb_nrocuentasol != value)
				{
					m_encb_nrocuentasol = value;
					OnPropertyChanged("ENCB_NroCuentaSol");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENCB_NroCuentaDol.
		/// </summary>
		[DataMember]
		public String ENCB_NroCuentaDol
		{
			get { return m_encb_nrocuentadol; }
			set
			{
				if (m_encb_nrocuentadol != value)
				{
					m_encb_nrocuentadol = value;
					OnPropertyChanged("ENCB_NroCuentaDol");
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
		public void CopyTo(ref EntidadCuentaBancaria Item)
		{
			try
			{
				if (Item == null) { Item = new EntidadCuentaBancaria(); }
				Item.ENTC_Codigo = this.ENTC_Codigo;
				Item.TIPO_TabBCO = this.TIPO_TabBCO;
				Item.TIPO_CodBCO = this.TIPO_CodBCO;
				Item.ENCB_TipoCuenta = this.ENCB_TipoCuenta;
				Item.ENCB_NroCuentaSol = this.ENCB_NroCuentaSol;
				Item.ENCB_NroCuentaDol = this.ENCB_NroCuentaDol;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
