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
	public partial class Det_Tarifa_Servicio : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_ctar_codigo;
		private String m_ctar_tipo;
		private Int32 m_dtas_item;
		private Nullable<Int32> m_serv_codigo;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private Nullable<Decimal> m_dtas_costo;
		private Nullable<Decimal> m_dtas_venta;
		private Nullable<Decimal> m_dtas_profit;
		private String m_audi_usrcrea;
		private Nullable<DateTime> m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		private Nullable<Boolean> m_dtas_igv;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Det_Tarifa_Servicio.
		/// </summary>
		public Det_Tarifa_Servicio()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CTAR_Codigo.
		/// </summary>
		[DataMember]
		public Int32 CTAR_Codigo
		{
			get { return m_ctar_codigo; }
			set
			{
				if (m_ctar_codigo != value)
				{
					m_ctar_codigo = value;
					OnPropertyChanged("CTAR_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CTAR_Tipo.
		/// </summary>
		[DataMember]
		public String CTAR_Tipo
		{
			get { return m_ctar_tipo; }
			set
			{
				if (m_ctar_tipo != value)
				{
					m_ctar_tipo = value;
					OnPropertyChanged("CTAR_Tipo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DTAS_Item.
		/// </summary>
		[DataMember]
		public Int32 DTAS_Item
		{
			get { return m_dtas_item; }
			set
			{
				if (m_dtas_item != value)
				{
					m_dtas_item = value;
					OnPropertyChanged("DTAS_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SERV_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> SERV_Codigo
		{
			get { return m_serv_codigo; }
			set
			{
				if (m_serv_codigo != value)
				{
					m_serv_codigo = value;
					OnPropertyChanged("SERV_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabMnd.
		/// </summary>
		[DataMember]
		public String TIPO_TabMnd
		{
			get { return m_tipo_tabmnd; }
			set
			{
				if (m_tipo_tabmnd != value)
				{
					m_tipo_tabmnd = value;
					OnPropertyChanged("TIPO_TabMnd");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodMnd.
		/// </summary>
		[DataMember]
		public String TIPO_CodMnd
		{
			get { return m_tipo_codmnd; }
			set
			{
				if (m_tipo_codmnd != value)
				{
					m_tipo_codmnd = value;
					OnPropertyChanged("TIPO_CodMnd");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DTAS_Costo.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DTAS_Costo
		{
			get { return m_dtas_costo; }
			set
			{
				if (m_dtas_costo != value)
				{
					m_dtas_costo = value;
					OnPropertyChanged("DTAS_Costo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DTAS_Venta.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DTAS_Venta
		{
			get { return m_dtas_venta; }
			set
			{
				if (m_dtas_venta != value)
				{
					m_dtas_venta = value;
					OnPropertyChanged("DTAS_Venta");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DTAS_Profit.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DTAS_Profit
		{
			get { return m_dtas_profit; }
			set
			{
				if (m_dtas_profit != value)
				{
					m_dtas_profit = value;
					OnPropertyChanged("DTAS_Profit");
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
		public Nullable<DateTime> AUDI_FecCrea
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
		/// <summary>
		/// Gets or sets el valor de: DTAS_IGV.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> DTAS_IGV
		{
			get { return m_dtas_igv; }
			set
			{
				if (m_dtas_igv != value)
				{
					m_dtas_igv = value;
					OnPropertyChanged("DTAS_IGV");
				}
			}
		}
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Det_Tarifa_Servicio Item)
		{
			try
			{
				if (Item == null) { Item = new Det_Tarifa_Servicio(); }
				Item.CTAR_Codigo = this.CTAR_Codigo;
				Item.CTAR_Tipo = this.CTAR_Tipo;
				Item.DTAS_Item = this.DTAS_Item;
				Item.SERV_Codigo = this.SERV_Codigo;
				Item.TIPO_TabMnd = this.TIPO_TabMnd;
				Item.TIPO_CodMnd = this.TIPO_CodMnd;
				Item.DTAS_Costo = this.DTAS_Costo;
				Item.DTAS_Venta = this.DTAS_Venta;
				Item.DTAS_Profit = this.DTAS_Profit;
				Item.DTAS_IGV = this.DTAS_IGV;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
