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
	public partial class Det_Cotizacion : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_ccot_codigo;
		private Int32 m_dcot_item;
		private Nullable<Int16> m_dtar_item;
		private Nullable<Int32> m_ctar_codigo;
		private String m_ctar_tipo;
		private Nullable<Int32> m_pack_codigo;
		private Int16 m_dcot_cantidad;
		private Decimal m_dcot_costosada;
		private Decimal m_dcot_costo;
		private Decimal m_dcot_ventasada;
		private Decimal m_dcot_venta;
		private Decimal m_dcot_minimo;
		private String m_cons_codbas;
		private String m_cons_tabbas;
		private Nullable<Decimal> m_dcot_peso;
		private Nullable<Decimal> m_dcot_volumen;
		private Nullable<Int16> m_tipe_codigo;
		private Nullable<Int32> m_entc_codigo;
		private String m_tipo_tabzon;
		private String m_tipo_codzonorigen;
		private String m_tipo_codzondestino;
		private Nullable<Boolean> m_dcot_roudtrip;
		private Nullable<Decimal> m_dcot_profit;
		private Nullable<Decimal> m_dcot_profitminimo;
		private String m_cons_codtra;
		private String m_cons_tabtra;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Det_Cotizacion.
		/// </summary>
		public Det_Cotizacion()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CCOT_Codigo.
		/// </summary>
		[DataMember]
		public Int32 CCOT_Codigo
		{
			get { return m_ccot_codigo; }
			set
			{
				if (m_ccot_codigo != value)
				{
					m_ccot_codigo = value;
					OnPropertyChanged("CCOT_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_Item.
		/// </summary>
		[DataMember]
		public Int32 DCOT_Item
		{
			get { return m_dcot_item; }
			set
			{
				if (m_dcot_item != value)
				{
					m_dcot_item = value;
					OnPropertyChanged("DCOT_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DTAR_Item.
		/// </summary>
		[DataMember]
		public Nullable<Int16> DTAR_Item
		{
			get { return m_dtar_item; }
			set
			{
				if (m_dtar_item != value)
				{
					m_dtar_item = value;
					OnPropertyChanged("DTAR_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CTAR_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CTAR_Codigo
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
		/// Gets or sets el valor de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> PACK_Codigo
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
		/// Gets or sets el valor de: DCOT_Cantidad.
		/// </summary>
		[DataMember]
		public Int16 DCOT_Cantidad
		{
			get { return m_dcot_cantidad; }
			set
			{
				if (m_dcot_cantidad != value)
				{
					m_dcot_cantidad = value;
					OnPropertyChanged("DCOT_Cantidad");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_CostoSada.
		/// </summary>
		[DataMember]
		public Decimal DCOT_CostoSada
		{
			get { return m_dcot_costosada; }
			set
			{
				if (m_dcot_costosada != value)
				{
					m_dcot_costosada = value;
					OnPropertyChanged("DCOT_CostoSada");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_Costo.
		/// </summary>
		[DataMember]
		public Decimal DCOT_Costo
		{
			get { return m_dcot_costo; }
			set
			{
				if (m_dcot_costo != value)
				{
					m_dcot_costo = value;
					OnPropertyChanged("DCOT_Costo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_VentaSada.
		/// </summary>
		[DataMember]
		public Decimal DCOT_VentaSada
		{
			get { return m_dcot_ventasada; }
			set
			{
				if (m_dcot_ventasada != value)
				{
					m_dcot_ventasada = value;
					OnPropertyChanged("DCOT_VentaSada");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_Venta.
		/// </summary>
		[DataMember]
		public Decimal DCOT_Venta
		{
			get { return m_dcot_venta; }
			set
			{
				if (m_dcot_venta != value)
				{
					m_dcot_venta = value;
					OnPropertyChanged("DCOT_Venta");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_Minimo.
		/// </summary>
		[DataMember]
		public Decimal DCOT_Minimo
		{
			get { return m_dcot_minimo; }
			set
			{
				if (m_dcot_minimo != value)
				{
					m_dcot_minimo = value;
					OnPropertyChanged("DCOT_Minimo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodBas.
		/// </summary>
		[DataMember]
		public String CONS_CodBas
		{
			get { return m_cons_codbas; }
			set
			{
				if (m_cons_codbas != value)
				{
					m_cons_codbas = value;
					OnPropertyChanged("CONS_CodBas");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabBas.
		/// </summary>
		[DataMember]
		public String CONS_TabBas
		{
			get { return m_cons_tabbas; }
			set
			{
				if (m_cons_tabbas != value)
				{
					m_cons_tabbas = value;
					OnPropertyChanged("CONS_TabBas");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_Peso.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DCOT_Peso
		{
			get { return m_dcot_peso; }
			set
			{
				if (m_dcot_peso != value)
				{
					m_dcot_peso = value;
					OnPropertyChanged("DCOT_Peso");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_Volumen.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DCOT_Volumen
		{
			get { return m_dcot_volumen; }
			set
			{
				if (m_dcot_volumen != value)
				{
					m_dcot_volumen = value;
					OnPropertyChanged("DCOT_Volumen");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPE_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> TIPE_Codigo
		{
			get { return m_tipe_codigo; }
			set
			{
				if (m_tipe_codigo != value)
				{
					m_tipe_codigo = value;
					OnPropertyChanged("TIPE_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_Codigo
		{
			get { return m_entc_codigo; }
			set
			{
				if (m_entc_codigo != value)
				{
					m_entc_codigo = value;
					OnPropertyChanged("ENTC_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabZON.
		/// </summary>
		[DataMember]
		public String TIPO_TabZON
		{
			get { return m_tipo_tabzon; }
			set
			{
				if (m_tipo_tabzon != value)
				{
					m_tipo_tabzon = value;
					OnPropertyChanged("TIPO_TabZON");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodZONOrigen.
		/// </summary>
		[DataMember]
		public String TIPO_CodZONOrigen
		{
			get { return m_tipo_codzonorigen; }
			set
			{
				if (m_tipo_codzonorigen != value)
				{
					m_tipo_codzonorigen = value;
					OnPropertyChanged("TIPO_CodZONOrigen");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodZONDestino.
		/// </summary>
		[DataMember]
		public String TIPO_CodZONDestino
		{
			get { return m_tipo_codzondestino; }
			set
			{
				if (m_tipo_codzondestino != value)
				{
					m_tipo_codzondestino = value;
					OnPropertyChanged("TIPO_CodZONDestino");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_Roudtrip.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> DCOT_Roudtrip
		{
			get { return m_dcot_roudtrip; }
			set
			{
				if (m_dcot_roudtrip != value)
				{
					m_dcot_roudtrip = value;
					OnPropertyChanged("DCOT_Roudtrip");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_Profit.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DCOT_Profit
		{
			get { return m_dcot_profit; }
			set
			{
				if (m_dcot_profit != value)
				{
					m_dcot_profit = value;
					OnPropertyChanged("DCOT_Profit");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_ProfitMinimo.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DCOT_ProfitMinimo
		{
			get { return m_dcot_profitminimo; }
			set
			{
				if (m_dcot_profitminimo != value)
				{
					m_dcot_profitminimo = value;
					OnPropertyChanged("DCOT_ProfitMinimo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodTRA.
		/// </summary>
		[DataMember]
		public String CONS_CodTRA
		{
			get { return m_cons_codtra; }
			set
			{
				if (m_cons_codtra != value)
				{
					m_cons_codtra = value;
					OnPropertyChanged("CONS_CodTRA");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabTRA.
		/// </summary>
		[DataMember]
		public String CONS_TabTRA
		{
			get { return m_cons_tabtra; }
			set
			{
				if (m_cons_tabtra != value)
				{
					m_cons_tabtra = value;
					OnPropertyChanged("CONS_TabTRA");
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
		public void CopyTo(ref Det_Cotizacion Item)
		{
			try
			{
				if (Item == null) { Item = new Det_Cotizacion(); }
				Item.CCOT_Codigo = this.CCOT_Codigo;
				Item.DCOT_Item = this.DCOT_Item;
				Item.DTAR_Item = this.DTAR_Item;
				Item.CTAR_Codigo = this.CTAR_Codigo;
				Item.CTAR_Tipo = this.CTAR_Tipo;
				Item.PACK_Codigo = this.PACK_Codigo;
				Item.DCOT_Cantidad = this.DCOT_Cantidad;
				Item.DCOT_CostoSada = this.DCOT_CostoSada;
				Item.DCOT_Costo = this.DCOT_Costo;
				Item.DCOT_VentaSada = this.DCOT_VentaSada;
				Item.DCOT_Venta = this.DCOT_Venta;
				Item.DCOT_Minimo = this.DCOT_Minimo;
				Item.CONS_CodBas = this.CONS_CodBas;
				Item.CONS_TabBas = this.CONS_TabBas;
				Item.DCOT_Peso = this.DCOT_Peso;
				Item.DCOT_Volumen = this.DCOT_Volumen;
				Item.TIPE_Codigo = this.TIPE_Codigo;
				Item.ENTC_Codigo = this.ENTC_Codigo;
				Item.TIPO_TabZON = this.TIPO_TabZON;
				Item.TIPO_CodZONOrigen = this.TIPO_CodZONOrigen;
				Item.TIPO_CodZONDestino = this.TIPO_CodZONDestino;
				Item.DCOT_Roudtrip = this.DCOT_Roudtrip;
				Item.DCOT_Profit = this.DCOT_Profit;
				Item.DCOT_ProfitMinimo = this.DCOT_ProfitMinimo;
				Item.CONS_CodTRA = this.CONS_CodTRA;
				Item.CONS_TabTRA = this.CONS_TabTRA;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
