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
	public partial class Parametros : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private Int16 m_sucr_codigo;
		private Int32 m_para_codigo;
		private String m_para_clave;
		private String m_para_desc;
		private String m_para_valor;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Parametros.
		/// </summary>
		public Parametros()
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
		/// Gets or sets el valor de: PARA_Codigo.
		/// </summary>
		[DataMember]
		public Int32 PARA_Codigo
		{
			get { return m_para_codigo; }
			set
			{
				if (m_para_codigo != value)
				{
					m_para_codigo = value;
					OnPropertyChanged("PARA_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PARA_Clave.
		/// </summary>
		[DataMember]
		public String PARA_Clave
		{
			get { return m_para_clave; }
			set
			{
				if (m_para_clave != value)
				{
					m_para_clave = value;
					OnPropertyChanged("PARA_Clave");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PARA_Desc.
		/// </summary>
		[DataMember]
		public String PARA_Desc
		{
			get { return m_para_desc; }
			set
			{
				if (m_para_desc != value)
				{
					m_para_desc = value;
					OnPropertyChanged("PARA_Desc");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PARA_Valor.
		/// </summary>
		[DataMember]
		public String PARA_Valor
		{
			get { return m_para_valor; }
			set
			{
				if (m_para_valor != value)
				{
					m_para_valor = value;
					OnPropertyChanged("PARA_Valor");
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
		public void CopyTo(ref Parametros Item)
		{
			try
			{
				if (Item == null) { Item = new Parametros(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.SUCR_Codigo = this.SUCR_Codigo;
				Item.PARA_Codigo = this.PARA_Codigo;
				Item.PARA_Clave = this.PARA_Clave;
				Item.PARA_Desc = this.PARA_Desc;
				Item.PARA_Valor = this.PARA_Valor;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
