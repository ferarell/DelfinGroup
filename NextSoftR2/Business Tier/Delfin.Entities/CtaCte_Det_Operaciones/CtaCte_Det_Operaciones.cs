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
	public partial class CtaCte_Det_Operaciones : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_dcto_codigo;
		private Nullable<Int32> m_dope_item;
		private Nullable<Int32> m_cope_codigo;
		private Nullable<Int32> m_sope_item;
		private Nullable<Int32> m_ccct_codigo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase CtaCte_Det_Operaciones.
		/// </summary>
		public CtaCte_Det_Operaciones()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: DCTO_Codigo.
		/// </summary>
		[DataMember]
		public Int32 DCTO_Codigo
		{
			get { return m_dcto_codigo; }
			set
			{
				if (m_dcto_codigo != value)
				{
					m_dcto_codigo = value;
					OnPropertyChanged("DCTO_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOPE_Item.
		/// </summary>
		[DataMember]
		public Nullable<Int32> DOPE_Item
		{
			get { return m_dope_item; }
			set
			{
				if (m_dope_item != value)
				{
					m_dope_item = value;
					OnPropertyChanged("DOPE_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> COPE_Codigo
		{
			get { return m_cope_codigo; }
			set
			{
				if (m_cope_codigo != value)
				{
					m_cope_codigo = value;
					OnPropertyChanged("COPE_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SOPE_Item.
		/// </summary>
		[DataMember]
		public Nullable<Int32> SOPE_Item
		{
			get { return m_sope_item; }
			set
			{
				if (m_sope_item != value)
				{
					m_sope_item = value;
					OnPropertyChanged("SOPE_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCCT_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CCCT_Codigo
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref CtaCte_Det_Operaciones Item)
		{
			try
			{
				if (Item == null) { Item = new CtaCte_Det_Operaciones(); }
				Item.DCTO_Codigo = this.DCTO_Codigo;
				Item.DOPE_Item = this.DOPE_Item;
				Item.COPE_Codigo = this.COPE_Codigo;
				Item.SOPE_Item = this.SOPE_Item;
				Item.CCCT_Codigo = this.CCCT_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
