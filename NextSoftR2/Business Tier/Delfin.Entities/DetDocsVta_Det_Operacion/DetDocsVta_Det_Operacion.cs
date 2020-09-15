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
	public partial class DetDocsVta_Det_Operacion : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Nullable<Int32> m_dope_item;
		private Nullable<Int32> m_cope_codigo;
		private Nullable<Int32> m_sope_item;
		private Nullable<Int16> m_ddov_item;
		private Nullable<Int32> m_docv_codigo;
		private Int32 m_DDVO_Codigo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase DetDocsVta_Det_Operacion.
		/// </summary>
		public DetDocsVta_Det_Operacion()
		{  }
		#endregion

		#region [ Propiedades ]
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
		/// Gets or sets el valor de: DDOV_Item.
		/// </summary>
		[DataMember]
		public Nullable<Int16> DDOV_Item
		{
			get { return m_ddov_item; }
			set
			{
				if (m_ddov_item != value)
				{
					m_ddov_item = value;
					OnPropertyChanged("DDOV_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> DOCV_Codigo
		{
			get { return m_docv_codigo; }
			set
			{
				if (m_docv_codigo != value)
				{
					m_docv_codigo = value;
					OnPropertyChanged("DOCV_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DDVO_Codigo.
		/// </summary>
		[DataMember]
		public Int32 DDVO_Codigo
		{
			get { return m_DDVO_Codigo; }
			set
			{
				if (m_DDVO_Codigo != value)
				{
					m_DDVO_Codigo = value;
					OnPropertyChanged("DDVO_Codigo");
				}
			}
		}
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref DetDocsVta_Det_Operacion Item)
		{
			try
			{
				if (Item == null) { Item = new DetDocsVta_Det_Operacion(); }
				Item.DOPE_Item = this.DOPE_Item;
				Item.COPE_Codigo = this.COPE_Codigo;
				Item.SOPE_Item = this.SOPE_Item;
				Item.DDOV_Item = this.DDOV_Item;
				Item.DOCV_Codigo = this.DOCV_Codigo;
				Item.DDVO_Codigo = this.DDVO_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
