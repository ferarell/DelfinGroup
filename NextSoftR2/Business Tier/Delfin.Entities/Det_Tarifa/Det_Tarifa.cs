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
	public partial class Det_Tarifa : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_dtar_item;
		private Nullable<Int32> m_pack_codigo;
		private Int32 m_ctar_codigo;
		private String m_ctar_tipo;
		private Nullable<Decimal> m_dtar_costosada;
		private Nullable<Decimal> m_dtar_ventasada;
		private Nullable<Decimal> m_dtar_venta;
		private Nullable<Decimal> m_dtar_peso;
		private Nullable<Decimal> m_dtar_volumen;
		private Nullable<Decimal> m_dtar_minimo;
		private String m_cons_codbas;
		private String m_cons_tabbas;
		private String m_audi_usrcrea;
		private Nullable<DateTime> m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		private String m_tipo_tabzon;
		private String m_tipo_codzondestino;
		private String m_tipo_codzonorigen;
		private Nullable<Boolean> m_dtar_roundtrip;
		private Nullable<Decimal> m_dtar_costo;
		private Nullable<Decimal> m_dtar_profit;
		private Nullable<Decimal> m_dtar_profitminimo;
		private String m_cons_codtra;
		private String m_cons_tabtra;
		private Nullable<Int32> m_entc_codigo;
		private Nullable<Int16> m_tipe_codigo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Det_Tarifa.
		/// </summary>
		public Det_Tarifa()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: DTAR_Item.
		/// </summary>
		[DataMember]
		public Int16 DTAR_Item
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
		/// Gets or sets el valor de: DTAR_CostoSada.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DTAR_CostoSada
		{
			get { return m_dtar_costosada; }
			set
			{
				if (m_dtar_costosada != value)
				{
					m_dtar_costosada = value;
					OnPropertyChanged("DTAR_CostoSada");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DTAR_VentaSada.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DTAR_VentaSada
		{
			get { return m_dtar_ventasada; }
			set
			{
				if (m_dtar_ventasada != value)
				{
					m_dtar_ventasada = value;
					OnPropertyChanged("DTAR_VentaSada");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DTAR_Venta.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DTAR_Venta
		{
			get { return m_dtar_venta; }
			set
			{
				if (m_dtar_venta != value)
				{
					m_dtar_venta = value;
					OnPropertyChanged("DTAR_Venta");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DTAR_Peso.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DTAR_Peso
		{
			get { return m_dtar_peso; }
			set
			{
				if (m_dtar_peso != value)
				{
					m_dtar_peso = value;
					OnPropertyChanged("DTAR_Peso");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DTAR_Volumen.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DTAR_Volumen
		{
			get { return m_dtar_volumen; }
			set
			{
				if (m_dtar_volumen != value)
				{
					m_dtar_volumen = value;
					OnPropertyChanged("DTAR_Volumen");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DTAR_Minimo.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DTAR_Minimo
		{
			get { return m_dtar_minimo; }
			set
			{
				if (m_dtar_minimo != value)
				{
					m_dtar_minimo = value;
					OnPropertyChanged("DTAR_Minimo");
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
		/// Gets or sets el valor de: DTAR_Roundtrip.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> DTAR_Roundtrip
		{
			get { return m_dtar_roundtrip; }
			set
			{
				if (m_dtar_roundtrip != value)
				{
					m_dtar_roundtrip = value;
					OnPropertyChanged("DTAR_Roundtrip");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DTAR_Costo.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DTAR_Costo
		{
			get { return m_dtar_costo; }
			set
			{
				if (m_dtar_costo != value)
				{
					m_dtar_costo = value;
					OnPropertyChanged("DTAR_Costo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DTAR_Profit.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DTAR_Profit
		{
			get { return m_dtar_profit; }
			set
			{
				if (m_dtar_profit != value)
				{
					m_dtar_profit = value;
					OnPropertyChanged("DTAR_Profit");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DTAR_ProfitMinimo.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DTAR_ProfitMinimo
		{
			get { return m_dtar_profitminimo; }
			set
			{
				if (m_dtar_profitminimo != value)
				{
					m_dtar_profitminimo = value;
					OnPropertyChanged("DTAR_ProfitMinimo");
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Det_Tarifa Item)
		{
			try
			{
				if (Item == null) { Item = new Det_Tarifa(); }
				Item.DTAR_Item = this.DTAR_Item;
				Item.PACK_Codigo = this.PACK_Codigo;
				Item.CTAR_Codigo = this.CTAR_Codigo;
				Item.CTAR_Tipo = this.CTAR_Tipo;
				Item.DTAR_CostoSada = this.DTAR_CostoSada;
				Item.DTAR_VentaSada = this.DTAR_VentaSada;
				Item.DTAR_Venta = this.DTAR_Venta;
				Item.DTAR_Peso = this.DTAR_Peso;
				Item.DTAR_Volumen = this.DTAR_Volumen;
				Item.DTAR_Minimo = this.DTAR_Minimo;
				Item.CONS_CodBas = this.CONS_CodBas;
				Item.CONS_TabBas = this.CONS_TabBas;
				Item.TIPO_TabZON = this.TIPO_TabZON;
				Item.TIPO_CodZONDestino = this.TIPO_CodZONDestino;
				Item.TIPO_CodZONOrigen = this.TIPO_CodZONOrigen;
				Item.DTAR_Roundtrip = this.DTAR_Roundtrip;
				Item.DTAR_Costo = this.DTAR_Costo;
				Item.DTAR_Profit = this.DTAR_Profit;
				Item.DTAR_ProfitMinimo = this.DTAR_ProfitMinimo;
				Item.CONS_CodTRA = this.CONS_CodTRA;
				Item.CONS_TabTRA = this.CONS_TabTRA;
				Item.ENTC_Codigo = this.ENTC_Codigo;
				Item.TIPE_Codigo = this.TIPE_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
