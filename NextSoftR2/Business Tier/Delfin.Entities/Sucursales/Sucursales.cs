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
   public partial class Sucursales : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_sucr_codigo;
		private String m_sucr_desc;
		private String m_sucr_descc;
		private String m_sucr_ruc;
		private String m_sucr_direc;
		private Nullable<Int16> m_empr_codigo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private Nullable<DateTime> m_audi_fecmod;
		private String m_audi_usrmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Sucursales.
		/// </summary>
		public Sucursales()
		{  }
		#endregion

		#region [ Propiedades ]
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
		/// Gets or sets el valor de: SUCR_Desc.
		/// </summary>
		[DataMember]
		public String SUCR_Desc
		{
			get { return m_sucr_desc; }
			set
			{
				if (m_sucr_desc != value)
				{
					m_sucr_desc = value;
					OnPropertyChanged("SUCR_Desc");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SUCR_DescC.
		/// </summary>
		[DataMember]
		public String SUCR_DescC
		{
			get { return m_sucr_descc; }
			set
			{
				if (m_sucr_descc != value)
				{
					m_sucr_descc = value;
					OnPropertyChanged("SUCR_DescC");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SUCR_RUC.
		/// </summary>
		[DataMember]
		public String SUCR_RUC
		{
			get { return m_sucr_ruc; }
			set
			{
				if (m_sucr_ruc != value)
				{
					m_sucr_ruc = value;
					OnPropertyChanged("SUCR_RUC");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SUCR_Direc.
		/// </summary>
		[DataMember]
		public String SUCR_Direc
		{
			get { return m_sucr_direc; }
			set
			{
				if (m_sucr_direc != value)
				{
					m_sucr_direc = value;
					OnPropertyChanged("SUCR_Direc");
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
		public void CopyTo(ref Sucursales Item)
		{
			try
			{
				if (Item == null) { Item = new Sucursales(); }
				Item.SUCR_Codigo = this.SUCR_Codigo;
				Item.SUCR_Desc = this.SUCR_Desc;
				Item.SUCR_DescC = this.SUCR_DescC;
				Item.SUCR_RUC = this.SUCR_RUC;
				Item.SUCR_Direc = this.SUCR_Direc;
				Item.EMPR_Codigo = this.EMPR_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
