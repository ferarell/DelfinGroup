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
   [KnownType(typeof(MasterBusinessEntity))]
	public partial class Empresa : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private String m_empr_razonsocial;
		private String m_empr_razoncomercial;
		private String m_empr_ruc;
		private String m_empr_direccion;
		private DateTime m_audi_feccrea;
		private String m_audi_usrcrea;
		private Nullable<DateTime> m_audi_fecmod;
		private String m_audi_usrmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Empresa.
		/// </summary>
		public Empresa()
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
		/// Gets or sets el valor de: EMPR_RazonSocial.
		/// </summary>
		[DataMember]
		public String EMPR_RazonSocial
		{
			get { return m_empr_razonsocial; }
			set
			{
				if (m_empr_razonsocial != value)
				{
					m_empr_razonsocial = value;
					OnPropertyChanged("EMPR_RazonSocial");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EMPR_RazonComercial.
		/// </summary>
		[DataMember]
		public String EMPR_RazonComercial
		{
			get { return m_empr_razoncomercial; }
			set
			{
				if (m_empr_razoncomercial != value)
				{
					m_empr_razoncomercial = value;
					OnPropertyChanged("EMPR_RazonComercial");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EMPR_RUC.
		/// </summary>
		[DataMember]
		public String EMPR_RUC
		{
			get { return m_empr_ruc; }
			set
			{
				if (m_empr_ruc != value)
				{
					m_empr_ruc = value;
					OnPropertyChanged("EMPR_RUC");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EMPR_Direccion.
		/// </summary>
		[DataMember]
		public String EMPR_Direccion
		{
			get { return m_empr_direccion; }
			set
			{
				if (m_empr_direccion != value)
				{
					m_empr_direccion = value;
					OnPropertyChanged("EMPR_Direccion");
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
		public void CopyTo(ref Empresa Item)
		{
			try
			{
				if (Item == null) { Item = new Empresa(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.EMPR_RazonSocial = this.EMPR_RazonSocial;
				Item.EMPR_RazonComercial = this.EMPR_RazonComercial;
				Item.EMPR_RUC = this.EMPR_RUC;
				Item.EMPR_Direccion = this.EMPR_Direccion;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
