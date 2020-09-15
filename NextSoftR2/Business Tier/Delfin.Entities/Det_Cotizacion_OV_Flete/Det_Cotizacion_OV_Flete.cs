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
	public partial class Det_Cotizacion_OV_Flete : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_ccot_numero;
		private Int32 m_dcot_item;
		private Int16 m_ccot_tipo;
		private Int32 m_pack_codigo;
		private String m_dcot_producto;
		private Decimal m_dcot_cantidad;
		private Decimal m_dcot_preciounicosto;
		private Decimal m_dcot_totalunicosto;
		private Decimal m_dcot_totaluniventa;
		private Decimal m_dcot_preciouniventa;
		private Decimal m_dcot_importe;
		private Nullable<Decimal> m_dcot_peso;
		private Nullable<Decimal> m_dcot_volumen;
		private Int16 m_dcot_bultos;
		private Nullable<Decimal> m_dcot_largo;
		private Nullable<Decimal> m_dcot_ancho;
		private Nullable<Decimal> m_dcot_alto;
		private String m_tipo_tabunm;
		private String m_tipo_codunm;
		private String m_tipo_tabcdt;
		private String m_tipo_codcdt;
		private Nullable<Int32> m_tari_codigo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		private Nullable<Int32> m_serv_codigo;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Det_Cotizacion_OV_Flete.
		/// </summary>
		public Det_Cotizacion_OV_Flete()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public Int32 CCOT_Numero
		{
			get { return m_ccot_numero; }
			set
			{
				if (m_ccot_numero != value)
				{
					m_ccot_numero = value;
					OnPropertyChanged("CCOT_Numero");
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
		/// Gets or sets el valor de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public Int16 CCOT_Tipo
		{
			get { return m_ccot_tipo; }
			set
			{
				if (m_ccot_tipo != value)
				{
					m_ccot_tipo = value;
					OnPropertyChanged("CCOT_Tipo");
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
		/// Gets or sets el valor de: DCOT_Producto.
		/// </summary>
		[DataMember]
		public String DCOT_Producto
		{
			get { return m_dcot_producto; }
			set
			{
				if (m_dcot_producto != value)
				{
					m_dcot_producto = value;
					OnPropertyChanged("DCOT_Producto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_Cantidad.
		/// </summary>
		[DataMember]
		public Decimal DCOT_Cantidad
		{
			get { return m_dcot_cantidad; }
			set
			{
				if (m_dcot_cantidad != value)
				{
					m_dcot_cantidad = value;
					OnPropertyChanged("DCOT_Cantidad");
				}
            CalcularTotales();
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_PrecioUniCosto.
		/// </summary>
		[DataMember]
		public Decimal DCOT_PrecioUniCosto
		{
			get { return m_dcot_preciounicosto; }
			set
			{
				if (m_dcot_preciounicosto != value)
				{
					m_dcot_preciounicosto = value;
					OnPropertyChanged("DCOT_PrecioUniCosto");
				}
            CalcularTotales();
			}
		}
      /// <summary>
      /// Gets or sets el valor de: DCOT_PrecioUniVenta.
      /// </summary>
      [DataMember]
      public Decimal DCOT_PrecioUniVenta
      {
         get { return m_dcot_preciouniventa; }
         set
         {
            if (m_dcot_preciouniventa != value)
            {
               m_dcot_preciouniventa = value;
               OnPropertyChanged("DCOT_PrecioUniVenta");
            }
            CalcularTotales();
         }
      }
      /// <summary>
		/// Gets or sets el valor de: DCOT_TotalUniCosto.
		/// </summary>
		[DataMember]
		public Decimal DCOT_TotalUniCosto
		{
			get { return m_dcot_totalunicosto; }
			set
			{
				if (m_dcot_totalunicosto != value)
				{
					m_dcot_totalunicosto = value;
					OnPropertyChanged("DCOT_TotalUniCosto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_TotalUniVenta.
		/// </summary>
		[DataMember]
		public Decimal DCOT_TotalUniVenta
		{
			get { return m_dcot_totaluniventa; }
			set
			{
				if (m_dcot_totaluniventa != value)
				{
					m_dcot_totaluniventa = value;
					OnPropertyChanged("DCOT_TotalUniVenta");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_Importe.
		/// </summary>
		[DataMember]
		public Decimal DCOT_Importe
		{
			get { return m_dcot_importe; }
			set
			{
				if (m_dcot_importe != value)
				{
					m_dcot_importe = value;
					OnPropertyChanged("DCOT_Importe");
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
		/// Gets or sets el valor de: DCOT_Bultos.
		/// </summary>
		[DataMember]
		public Int16 DCOT_Bultos
		{
			get { return m_dcot_bultos; }
			set
			{
				if (m_dcot_bultos != value)
				{
					m_dcot_bultos = value;
					OnPropertyChanged("DCOT_Bultos");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_Largo.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DCOT_Largo
		{
			get { return m_dcot_largo; }
			set
			{
				if (m_dcot_largo != value)
				{
					m_dcot_largo = value;
					OnPropertyChanged("DCOT_Largo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_Ancho.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DCOT_Ancho
		{
			get { return m_dcot_ancho; }
			set
			{
				if (m_dcot_ancho != value)
				{
					m_dcot_ancho = value;
					OnPropertyChanged("DCOT_Ancho");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DCOT_Alto.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DCOT_Alto
		{
			get { return m_dcot_alto; }
			set
			{
				if (m_dcot_alto != value)
				{
					m_dcot_alto = value;
					OnPropertyChanged("DCOT_Alto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabUnm.
		/// </summary>
		[DataMember]
		public String TIPO_TabUnm
		{
			get { return m_tipo_tabunm; }
			set
			{
				if (m_tipo_tabunm != value)
				{
					m_tipo_tabunm = value;
					OnPropertyChanged("TIPO_TabUnm");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodUnm.
		/// </summary>
		[DataMember]
		public String TIPO_CodUnm
		{
			get { return m_tipo_codunm; }
			set
			{
				if (m_tipo_codunm != value)
				{
					m_tipo_codunm = value;
               if (!String.IsNullOrEmpty(m_tipo_codunm))
               { TIPO_TabUnm = "UNM"; }
					OnPropertyChanged("TIPO_CodUnm");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabCDT.
		/// </summary>
		[DataMember]
		public String TIPO_TabCDT
		{
			get { return m_tipo_tabcdt; }
			set
			{
				if (m_tipo_tabcdt != value)
				{
					m_tipo_tabcdt = value;
					OnPropertyChanged("TIPO_TabCDT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodCDT.
		/// </summary>
		[DataMember]
		public String TIPO_CodCDT
		{
			get { return m_tipo_codcdt; }
			set
			{
				if (m_tipo_codcdt != value)
				{
					m_tipo_codcdt = value;
               if (!String.IsNullOrEmpty(m_tipo_codcdt))
               { TIPO_TabCDT = "CDT"; }
					OnPropertyChanged("TIPO_CodCDT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TARI_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> TARI_Codigo
		{
			get { return m_tari_codigo; }
			set
			{
				if (m_tari_codigo != value)
				{
					m_tari_codigo = value;
					OnPropertyChanged("TARI_Codigo");
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Det_Cotizacion_OV_Flete Item)
		{
			try
			{
				if (Item == null) { Item = new Det_Cotizacion_OV_Flete(); }
				Item.CCOT_Numero = this.CCOT_Numero;
				Item.DCOT_Item = this.DCOT_Item;
				Item.CCOT_Tipo = this.CCOT_Tipo;
				Item.PACK_Codigo = this.PACK_Codigo;
				Item.DCOT_Producto = this.DCOT_Producto;
				Item.DCOT_Cantidad = this.DCOT_Cantidad;
				Item.DCOT_PrecioUniCosto = this.DCOT_PrecioUniCosto;
				Item.DCOT_TotalUniCosto = this.DCOT_TotalUniCosto;
				Item.DCOT_TotalUniVenta = this.DCOT_TotalUniVenta;
				Item.DCOT_PrecioUniVenta = this.DCOT_PrecioUniVenta;
				Item.DCOT_Importe = this.DCOT_Importe;
				Item.DCOT_Peso = this.DCOT_Peso;
				Item.DCOT_Volumen = this.DCOT_Volumen;
				Item.DCOT_Bultos = this.DCOT_Bultos;
				Item.DCOT_Largo = this.DCOT_Largo;
				Item.DCOT_Ancho = this.DCOT_Ancho;
				Item.DCOT_Alto = this.DCOT_Alto;
				Item.TIPO_TabUnm = this.TIPO_TabUnm;
				Item.TIPO_CodUnm = this.TIPO_CodUnm;
				Item.TIPO_TabCDT = this.TIPO_TabCDT;
				Item.TIPO_CodCDT = this.TIPO_CodCDT;
				Item.TARI_Codigo = this.TARI_Codigo;
				Item.SERV_Codigo = this.SERV_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
