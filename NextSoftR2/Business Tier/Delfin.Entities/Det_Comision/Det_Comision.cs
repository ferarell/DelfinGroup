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
	public partial class Det_Comision : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_comi_codigo;
		private Int32 m_dcom_item;
		private Int32 m_pack_codigo;
		private Decimal m_dcom_minprofit;
		private Decimal m_dcom_valor;
		private DateTime m_audi_feccrea;
		private String m_audi_usrcrea;
		private Nullable<DateTime> m_audi_fecmod;
		private String m_audi_usrmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Det_Comision.
		/// </summary>
		public Det_Comision()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: COMI_Codigo.
		/// </summary>
		[DataMember]
		public Int32 COMI_Codigo
		{
			get { return m_comi_codigo; }
			set
			{
				if (m_comi_codigo != value)
				{
					m_comi_codigo = value;
					OnPropertyChanged("COMI_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOM_Item.
		/// </summary>
		[DataMember]
		public Int32 DCOM_Item
		{
			get { return m_dcom_item; }
			set
			{
				if (m_dcom_item != value)
				{
					m_dcom_item = value;
					OnPropertyChanged("DCOM_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public Int32 PACK_Codigo
		{
			get { return m_pack_codigo; }
			set
			{
				if (m_pack_codigo != value)
				{
					m_pack_codigo = value;
					OnPropertyChanged("PACK_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOM_MinProfit.
		/// </summary>
		[DataMember]
		public Decimal DCOM_MinProfit
		{
			get { return m_dcom_minprofit; }
			set
			{
				if (m_dcom_minprofit != value)
				{
					m_dcom_minprofit = value;
					OnPropertyChanged("DCOM_MinProfit");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOM_Valor.
		/// </summary>
		[DataMember]
		public Decimal DCOM_Valor
		{
			get { return m_dcom_valor; }
			set
			{
				if (m_dcom_valor != value)
				{
					m_dcom_valor = value;
					OnPropertyChanged("DCOM_Valor");
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
		public void CopyTo(ref Det_Comision Item)
		{
			try
			{
				if (Item == null) { Item = new Det_Comision(); }
				Item.COMI_Codigo = this.COMI_Codigo;
				Item.DCOM_Item = this.DCOM_Item;
				Item.PACK_Codigo = this.PACK_Codigo;
				Item.DCOM_MinProfit = this.DCOM_MinProfit;
				Item.DCOM_Valor = this.DCOM_Valor;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
