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
	public partial class GastosBancarios : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private Int32 m_tran_codigo;
		private Int32 m_gban_codigo;
		private Decimal m_gban_tipocambio;
		private Decimal m_gban_montodebe;
		private Decimal m_gban_montohaber;
		private String m_gban_estado;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase GastosBancarios.
		/// </summary>
		public GastosBancarios()
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
		/// Gets or sets el valor de: TRAN_Codigo.
		/// </summary>
		[DataMember]
		public Int32 TRAN_Codigo
		{
			get { return m_tran_codigo; }
			set
			{
				if (m_tran_codigo != value)
				{
					m_tran_codigo = value;
					OnPropertyChanged("TRAN_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GBAN_Codigo.
		/// </summary>
		[DataMember]
		public Int32 GBAN_Codigo
		{
			get { return m_gban_codigo; }
			set
			{
				if (m_gban_codigo != value)
				{
					m_gban_codigo = value;
					OnPropertyChanged("GBAN_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GBAN_TipoCambio.
		/// </summary>
		[DataMember]
		public Decimal GBAN_TipoCambio
		{
			get { return m_gban_tipocambio; }
			set
			{
				if (m_gban_tipocambio != value)
				{
					m_gban_tipocambio = value;
					OnPropertyChanged("GBAN_TipoCambio");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GBAN_MontoDebe.
		/// </summary>
		[DataMember]
		public Decimal GBAN_MontoDebe
		{
			get { return m_gban_montodebe; }
			set
			{
				if (m_gban_montodebe != value)
				{
					m_gban_montodebe = value;
					OnPropertyChanged("GBAN_MontoDebe");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GBAN_MontoHaber.
		/// </summary>
		[DataMember]
		public Decimal GBAN_MontoHaber
		{
			get { return m_gban_montohaber; }
			set
			{
				if (m_gban_montohaber != value)
				{
					m_gban_montohaber = value;
					OnPropertyChanged("GBAN_MontoHaber");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: GBAN_Estado.
		/// </summary>
		[DataMember]
		public String GBAN_Estado
		{
			get { return m_gban_estado; }
			set
			{
				if (m_gban_estado != value)
				{
					m_gban_estado = value;
					OnPropertyChanged("GBAN_Estado");
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
		public void CopyTo(ref GastosBancarios Item)
		{
			try
			{
				if (Item == null) { Item = new GastosBancarios(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.TRAN_Codigo = this.TRAN_Codigo;
				Item.GBAN_Codigo = this.GBAN_Codigo;
				Item.GBAN_TipoCambio = this.GBAN_TipoCambio;
				Item.GBAN_MontoDebe = this.GBAN_MontoDebe;
				Item.GBAN_MontoHaber = this.GBAN_MontoHaber;
				Item.GBAN_Estado = this.GBAN_Estado;
				Item.TIPO_TabMND = this.TIPO_TabMND;
				Item.TIPO_CodMND = this.TIPO_CodMND;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
