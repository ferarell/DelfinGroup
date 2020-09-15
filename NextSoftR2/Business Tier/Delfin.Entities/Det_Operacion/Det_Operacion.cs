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
	public partial class Det_Operacion : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_dope_item;
		private Int32 m_cope_codigo;
		private Nullable<Int16> m_dtar_item;
		private Nullable<Int32> m_ctar_codigo;
		private String m_ctar_tipo;
		private Nullable<Int32> m_pack_codigo;
		private String m_cons_codbas;
		private String m_cons_tabbas;
		private Int16 m_dope_cantidad;
		private Decimal m_dope_preciounitcosto;
		private Decimal m_dope_preciototcosto;
		private Decimal m_dope_preciounitvta;
		private Decimal m_dope_preciototvta;
		private Decimal m_dope_minimo;
		private Nullable<Decimal> m_dope_peso;
		private Nullable<Decimal> m_dope_volumen;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_usr_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		private Decimal m_dope_costosada;
		private Decimal m_dope_costo;
		private Decimal m_dope_ventasada;
		private Decimal m_dope_venta;
		private String m_tipo_tabzon;
		private String m_tipo_codzonorigen;
		private String m_cons_codtra;
		private String m_cons_tabtra;
		private String m_tipo_codzondestino;
        private Int16? m_TIPE_Codigo;
        private Int32? m_ENTC_Codigo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Det_Operacion.
		/// </summary>
		public Det_Operacion()
		{  }
		#endregion

		#region [ Propiedades ]
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
		/// Gets or sets el valor de: DOPE_Cantidad.
		/// </summary>
		[DataMember]
		public Int16 DOPE_Cantidad
		{
			get { return m_dope_cantidad; }
			set
			{
				if (m_dope_cantidad != value)
				{
					m_dope_cantidad = value;
					OnPropertyChanged("DOPE_Cantidad");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOPE_PrecioUnitCosto.
		/// </summary>
		[DataMember]
		public Decimal DOPE_PrecioUnitCosto
		{
			get { return m_dope_preciounitcosto; }
			set
			{
				if (m_dope_preciounitcosto != value)
				{
					m_dope_preciounitcosto = value;
					OnPropertyChanged("DOPE_PrecioUnitCosto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOPE_PrecioTotCosto.
		/// </summary>
		[DataMember]
		public Decimal DOPE_PrecioTotCosto
		{
			get { return m_dope_preciototcosto; }
			set
			{
				if (m_dope_preciototcosto != value)
				{
					m_dope_preciototcosto = value;
					OnPropertyChanged("DOPE_PrecioTotCosto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOPE_PrecioUnitVta.
		/// </summary>
		[DataMember]
		public Decimal DOPE_PrecioUnitVta
		{
			get { return m_dope_preciounitvta; }
			set
			{
				if (m_dope_preciounitvta != value)
				{
					m_dope_preciounitvta = value;
					OnPropertyChanged("DOPE_PrecioUnitVta");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOPE_PrecioTotVta.
		/// </summary>
		[DataMember]
		public Decimal DOPE_PrecioTotVta
		{
			get { return m_dope_preciototvta; }
			set
			{
				if (m_dope_preciototvta != value)
				{
					m_dope_preciototvta = value;
					OnPropertyChanged("DOPE_PrecioTotVta");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOPE_Minimo.
		/// </summary>
		[DataMember]
		public Decimal DOPE_Minimo
		{
			get { return m_dope_minimo; }
			set
			{
				if (m_dope_minimo != value)
				{
					m_dope_minimo = value;
					OnPropertyChanged("DOPE_Minimo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOPE_Peso.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DOPE_Peso
		{
			get { return m_dope_peso; }
			set
			{
				if (m_dope_peso != value)
				{
					m_dope_peso = value;
					OnPropertyChanged("DOPE_Peso");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOPE_Volumen.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DOPE_Volumen
		{
			get { return m_dope_volumen; }
			set
			{
				if (m_dope_volumen != value)
				{
					m_dope_volumen = value;
					OnPropertyChanged("DOPE_Volumen");
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
		/// Gets or sets el valor de: USR_UsrMod.
		/// </summary>
		[DataMember]
		public String USR_UsrMod
		{
			get { return m_usr_usrmod; }
			set
			{
				if (m_usr_usrmod != value)
				{
					m_usr_usrmod = value;
					OnPropertyChanged("USR_UsrMod");
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
		/// Gets or sets el valor de: DOPE_CostoSada.
		/// </summary>
		[DataMember]
		public Decimal DOPE_CostoSada
		{
			get { return m_dope_costosada; }
			set
			{
				if (m_dope_costosada != value)
				{
					m_dope_costosada = value;
					OnPropertyChanged("DOPE_CostoSada");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOPE_Costo.
		/// </summary>
		[DataMember]
		public Decimal DOPE_Costo
		{
			get { return m_dope_costo; }
			set
			{
				if (m_dope_costo != value)
				{
					m_dope_costo = value;
					OnPropertyChanged("DOPE_Costo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOPE_VentaSada.
		/// </summary>
		[DataMember]
		public Decimal DOPE_VentaSada
		{
			get { return m_dope_ventasada; }
			set
			{
				if (m_dope_ventasada != value)
				{
					m_dope_ventasada = value;
					OnPropertyChanged("DOPE_VentaSada");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DOPE_Venta.
		/// </summary>
		[DataMember]
		public Decimal DOPE_Venta
		{
			get { return m_dope_venta; }
			set
			{
				if (m_dope_venta != value)
				{
					m_dope_venta = value;
					OnPropertyChanged("DOPE_Venta");
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

        [DataMember]
        public Int16? TIPE_Codigo
        {
            get { return m_TIPE_Codigo; }
            set { m_TIPE_Codigo = value; }
        }
        [DataMember]
        public Int32? ENTC_Codigo
        {
            get { return m_ENTC_Codigo; }
            set { m_ENTC_Codigo = value; }
        }
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Det_Operacion Item)
		{
			try
			{
				if (Item == null) { Item = new Det_Operacion(); }
				Item.DOPE_Item = this.DOPE_Item;
				Item.COPE_Codigo = this.COPE_Codigo;
				Item.DTAR_Item = this.DTAR_Item;
				Item.CTAR_Codigo = this.CTAR_Codigo;
				Item.CTAR_Tipo = this.CTAR_Tipo;
				Item.PACK_Codigo = this.PACK_Codigo;
				Item.CONS_CodBas = this.CONS_CodBas;
				Item.CONS_TabBas = this.CONS_TabBas;
				Item.DOPE_Cantidad = this.DOPE_Cantidad;
				Item.DOPE_PrecioUnitCosto = this.DOPE_PrecioUnitCosto;
				Item.DOPE_PrecioTotCosto = this.DOPE_PrecioTotCosto;
				Item.DOPE_PrecioUnitVta = this.DOPE_PrecioUnitVta;
				Item.DOPE_PrecioTotVta = this.DOPE_PrecioTotVta;
				Item.DOPE_Minimo = this.DOPE_Minimo;
				Item.DOPE_Peso = this.DOPE_Peso;
				Item.DOPE_Volumen = this.DOPE_Volumen;
				Item.DOPE_CostoSada = this.DOPE_CostoSada;
				Item.DOPE_Costo = this.DOPE_Costo;
				Item.DOPE_VentaSada = this.DOPE_VentaSada;
				Item.DOPE_Venta = this.DOPE_Venta;
				Item.TIPO_TabZON = this.TIPO_TabZON;
				Item.TIPO_CodZONOrigen = this.TIPO_CodZONOrigen;
				Item.CONS_CodTRA = this.CONS_CodTRA;
				Item.CONS_TabTRA = this.CONS_TabTRA;
				Item.TIPO_CodZONDestino = this.TIPO_CodZONDestino;
			}
			catch (Exception ex)
			{ throw ex; }
		}
      public Det_Operacion Clone()
      {
         return this.MemberwiseClone() as Det_Operacion;
      }

		#endregion


	}
}
