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
	public partial class LiqCtaCte : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private String m_liqu_codigo;
		private Int32 m_ccct_codigo;
		private Nullable<Int16> m_lccc_item;
		private String m_audi_usrcrea;
		private DateTime m_auid_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase LiqCtaCte.
		/// </summary>
		public LiqCtaCte()
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
		/// Gets or sets el valor de: LIQU_Codigo.
		/// </summary>
		[DataMember]
		public String LIQU_Codigo
		{
			get { return m_liqu_codigo; }
			set
			{
				if (m_liqu_codigo != value)
				{
					m_liqu_codigo = value;
					OnPropertyChanged("LIQU_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCCT_Codigo.
		/// </summary>
		[DataMember]
		public Int32 CCCT_Codigo
		{
			get { return m_ccct_codigo; }
			set
			{
				if (m_ccct_codigo != value)
				{
					m_ccct_codigo = value;
					OnPropertyChanged("CCCT_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LCCC_Item.
		/// </summary>
		[DataMember]
		public Nullable<Int16> LCCC_Item
		{
			get { return m_lccc_item; }
			set
			{
				if (m_lccc_item != value)
				{
					m_lccc_item = value;
					OnPropertyChanged("LCCC_Item");
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
		/// Gets or sets el valor de: AUID_FecCrea.
		/// </summary>
		[DataMember]
		public DateTime AUID_FecCrea
		{
			get { return m_auid_feccrea; }
			set
			{
				if (m_auid_feccrea != value)
				{
					m_auid_feccrea = value;
					OnPropertyChanged("AUID_FecCrea");
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
		public void CopyTo(ref LiqCtaCte Item)
		{
			try
			{
				if (Item == null) { Item = new LiqCtaCte(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.LIQU_Codigo = this.LIQU_Codigo;
				Item.CCCT_Codigo = this.CCCT_Codigo;
				Item.LCCC_Item = this.LCCC_Item;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
