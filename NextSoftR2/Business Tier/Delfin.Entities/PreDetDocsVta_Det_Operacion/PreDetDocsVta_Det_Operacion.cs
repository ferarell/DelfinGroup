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
	public partial class PreDetDocsVta_Det_Operacion : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_PDVO_Codigo;
		private Int32 m_sope_item;
		private Int32 m_cope_codigo;
		private Int32 m_dope_item;
		private Int16 m_pddo_item;
		private Int32 m_docv_codigo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase PreDetDocsVta_Det_Operacion.
		/// </summary>
		public PreDetDocsVta_Det_Operacion()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: PDVO_Codigo.
		/// </summary>
		[DataMember]
		public Int32 PDVO_Codigo
		{
			get { return m_PDVO_Codigo; }
			set
			{
				if (m_PDVO_Codigo != value)
				{
					m_PDVO_Codigo = value;
					OnPropertyChanged("PDVO_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SOPE_Item.
		/// </summary>
		[DataMember]
		public Int32 SOPE_Item
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
		/// Gets or sets el valor de: COPE_Codigo.
		/// </summary>
		[DataMember]
		public Int32 COPE_Codigo
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
		/// Gets or sets el valor de: DOPE_Item.
		/// </summary>
		[DataMember]
		public Int32 DOPE_Item
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
		/// Gets or sets el valor de: PDDO_Item.
		/// </summary>
		[DataMember]
		public Int16 PDDO_Item
		{
			get { return m_pddo_item; }
			set
			{
				if (m_pddo_item != value)
				{
					m_pddo_item = value;
					OnPropertyChanged("PDDO_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOCV_Codigo.
		/// </summary>
		[DataMember]
		public Int32 DOCV_Codigo
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref PreDetDocsVta_Det_Operacion Item)
		{
			try
			{
				if (Item == null) { Item = new PreDetDocsVta_Det_Operacion(); }
				Item.PDVO_Codigo = this.PDVO_Codigo;
				Item.SOPE_Item = this.SOPE_Item;
				Item.COPE_Codigo = this.COPE_Codigo;
				Item.DOPE_Item = this.DOPE_Item;
				Item.PDDO_Item = this.PDDO_Item;
				Item.DOCV_Codigo = this.DOCV_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
