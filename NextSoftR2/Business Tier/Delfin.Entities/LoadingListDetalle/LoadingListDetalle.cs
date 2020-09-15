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
	public partial class LoadingListDetalle : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private String m_lode_cargatipo;
		private String m_cntr_numero;
		private Nullable<Decimal> m_lode_pesobruto;
		private Nullable<Decimal> m_lode_volumen;
		private Nullable<Decimal> m_lode_cantbultos;
		private String m_lode_precinto;
		private String m_lode_desccarga;
		private String m_lode_marcasnumeros;
		private String m_lode_tipotamanio;
		private Boolean m_lode_cargapeligrosa;
		private String m_tipo_tabimo;
		private String m_tipo_codimo;
		private String m_lode_tipocnt;
		private Int16 m_lode_tamaniocnt;
		private Int32 m_load_codigo;
		private Int16 m_lode_item;
		private Nullable<Int32> m_dhbl_item;
		private Nullable<Int16> m_ccot_tipo;
		private Nullable<Int32> m_ccot_numero;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase LoadingListDetalle.
		/// </summary>
		public LoadingListDetalle()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: LODE_CargaTipo.
		/// </summary>
		[DataMember]
		public String LODE_CargaTipo
		{
			get { return m_lode_cargatipo; }
			set
			{
				if (m_lode_cargatipo != value)
				{
					m_lode_cargatipo = value;
					OnPropertyChanged("LODE_CargaTipo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CNTR_Numero.
		/// </summary>
		[DataMember]
		public String CNTR_Numero
		{
			get { return m_cntr_numero; }
			set
			{
				if (m_cntr_numero != value)
				{
					m_cntr_numero = value;
					OnPropertyChanged("CNTR_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LODE_PesoBruto.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> LODE_PesoBruto
		{
			get { return m_lode_pesobruto; }
			set
			{
				if (m_lode_pesobruto != value)
				{
					m_lode_pesobruto = value;
					OnPropertyChanged("LODE_PesoBruto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LODE_Volumen.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> LODE_Volumen
		{
			get { return m_lode_volumen; }
			set
			{
				if (m_lode_volumen != value)
				{
					m_lode_volumen = value;
					OnPropertyChanged("LODE_Volumen");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LODE_CantBultos.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> LODE_CantBultos
		{
			get { return m_lode_cantbultos; }
			set
			{
				if (m_lode_cantbultos != value)
				{
					m_lode_cantbultos = value;
					OnPropertyChanged("LODE_CantBultos");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LODE_Precinto.
		/// </summary>
		[DataMember]
		public String LODE_Precinto
		{
			get { return m_lode_precinto; }
			set
			{
				if (m_lode_precinto != value)
				{
					m_lode_precinto = value;
					OnPropertyChanged("LODE_Precinto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LODE_DescCarga.
		/// </summary>
		[DataMember]
		public String LODE_DescCarga
		{
			get { return m_lode_desccarga; }
			set
			{
				if (m_lode_desccarga != value)
				{
					m_lode_desccarga = value;
					OnPropertyChanged("LODE_DescCarga");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LODE_MarcasNumeros.
		/// </summary>
		[DataMember]
		public String LODE_MarcasNumeros
		{
			get { return m_lode_marcasnumeros; }
			set
			{
				if (m_lode_marcasnumeros != value)
				{
					m_lode_marcasnumeros = value;
					OnPropertyChanged("LODE_MarcasNumeros");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LODE_TipoTamanio.
		/// </summary>
		[DataMember]
		public String LODE_TipoTamanio
		{
			get { return m_lode_tipotamanio; }
			set
			{
				if (m_lode_tipotamanio != value)
				{
					m_lode_tipotamanio = value;
					OnPropertyChanged("LODE_TipoTamanio");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LODE_CargaPeligrosa.
		/// </summary>
		[DataMember]
		public Boolean LODE_CargaPeligrosa
		{
			get { return m_lode_cargapeligrosa; }
			set
			{
				if (m_lode_cargapeligrosa != value)
				{
					m_lode_cargapeligrosa = value;
					OnPropertyChanged("LODE_CargaPeligrosa");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabIMO.
		/// </summary>
		[DataMember]
		public String TIPO_TabIMO
		{
			get { return m_tipo_tabimo; }
			set
			{
				if (m_tipo_tabimo != value)
				{
					m_tipo_tabimo = value;
					OnPropertyChanged("TIPO_TabIMO");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodIMO.
		/// </summary>
		[DataMember]
		public String TIPO_CodIMO
		{
			get { return m_tipo_codimo; }
			set
			{
				if (m_tipo_codimo != value)
				{
					m_tipo_codimo = value;
					OnPropertyChanged("TIPO_CodIMO");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LODE_TipoCNT.
		/// </summary>
		[DataMember]
		public String LODE_TipoCNT
		{
			get { return m_lode_tipocnt; }
			set
			{
				if (m_lode_tipocnt != value)
				{
					m_lode_tipocnt = value;
					OnPropertyChanged("LODE_TipoCNT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LODE_TamanioCNT.
		/// </summary>
		[DataMember]
		public Int16 LODE_TamanioCNT
		{
			get { return m_lode_tamaniocnt; }
			set
			{
				if (m_lode_tamaniocnt != value)
				{
					m_lode_tamaniocnt = value;
					OnPropertyChanged("LODE_TamanioCNT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_Codigo.
		/// </summary>
		[DataMember]
		public Int32 LOAD_Codigo
		{
			get { return m_load_codigo; }
			set
			{
				if (m_load_codigo != value)
				{
					m_load_codigo = value;
					OnPropertyChanged("LOAD_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LODE_Item.
		/// </summary>
		[DataMember]
		public Int16 LODE_Item
		{
			get { return m_lode_item; }
			set
			{
				if (m_lode_item != value)
				{
					m_lode_item = value;
					OnPropertyChanged("LODE_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DHBL_Item.
		/// </summary>
		[DataMember]
		public Nullable<Int32> DHBL_Item
		{
			get { return m_dhbl_item; }
			set
			{
				if (m_dhbl_item != value)
				{
					m_dhbl_item = value;
					OnPropertyChanged("DHBL_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> CCOT_Tipo
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
		/// Gets or sets el valor de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CCOT_Numero
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref LoadingListDetalle Item)
		{
			try
			{
				if (Item == null) { Item = new LoadingListDetalle(); }
				Item.LODE_CargaTipo = this.LODE_CargaTipo;
				Item.CNTR_Numero = this.CNTR_Numero;
				Item.LODE_PesoBruto = this.LODE_PesoBruto;
				Item.LODE_Volumen = this.LODE_Volumen;
				Item.LODE_CantBultos = this.LODE_CantBultos;
				Item.LODE_Precinto = this.LODE_Precinto;
				Item.LODE_DescCarga = this.LODE_DescCarga;
				Item.LODE_MarcasNumeros = this.LODE_MarcasNumeros;
				Item.LODE_TipoTamanio = this.LODE_TipoTamanio;
				Item.LODE_CargaPeligrosa = this.LODE_CargaPeligrosa;
				Item.TIPO_TabIMO = this.TIPO_TabIMO;
				Item.TIPO_CodIMO = this.TIPO_CodIMO;
				Item.LODE_TipoCNT = this.LODE_TipoCNT;
				Item.LODE_TamanioCNT = this.LODE_TamanioCNT;
				Item.LOAD_Codigo = this.LOAD_Codigo;
				Item.LODE_Item = this.LODE_Item;
				Item.DHBL_Item = this.DHBL_Item;
				Item.CCOT_Tipo = this.CCOT_Tipo;
				Item.CCOT_Numero = this.CCOT_Numero;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
