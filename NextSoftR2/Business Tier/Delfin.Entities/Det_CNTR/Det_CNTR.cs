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
	public partial class Det_CNTR : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_ccot_numero;
		private Int16 m_ccot_tipo;
		private Nullable<Int32> m_cmbl_codigo;
		private Nullable<Int32> m_pack_codigo;
		private Nullable<Decimal> m_dhbl_pesobruto;
		private Nullable<Decimal> m_dhbl_volumen;
		private Nullable<Decimal> m_dhbl_cantbultos;
		private String m_dhbl_precinto;
		private String m_dhbl_descproducto;
		private String m_dhbl_marcasnumeros;
		private String m_tipo_tabimo;
		private String m_tipo_codimo;
		private Nullable<Boolean> m_dhbl_esimo;
		private String m_dhbl_contractnro;
		private Nullable<Boolean> m_dhbl_pp;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		private String m_cntr_numero;
      private Nullable<Int32> m_dhbl_item;
		private String m_tipo_tabcdt;
		private String m_tipo_codcdt;
		private String m_tipo_tabpac;
		private String m_tipo_codpac;
      private String m_dhbl_imoun;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Det_CNTR.
		/// </summary>
		public Det_CNTR()
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
		/// Gets or sets el valor de: CMBL_codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CMBL_codigo
		{
			get { return m_cmbl_codigo; }
			set
			{
				if (m_cmbl_codigo != value)
				{
					m_cmbl_codigo = value;
					OnPropertyChanged("CMBL_codigo");
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
		/// Gets or sets el valor de: DHBL_PesoBruto.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DHBL_PesoBruto
		{
			get { return m_dhbl_pesobruto; }
			set
			{
				if (m_dhbl_pesobruto != value)
				{
					m_dhbl_pesobruto = value;
					OnPropertyChanged("DHBL_PesoBruto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DHBL_Volumen.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DHBL_Volumen
		{
			get { return m_dhbl_volumen; }
			set
			{
				if (m_dhbl_volumen != value)
				{
					m_dhbl_volumen = value;
					OnPropertyChanged("DHBL_Volumen");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DHBL_CantBultos.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> DHBL_CantBultos
		{
			get { return m_dhbl_cantbultos; }
			set
			{
				if (m_dhbl_cantbultos != value)
				{
					m_dhbl_cantbultos = value;
					OnPropertyChanged("DHBL_CantBultos");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DHBL_Precinto.
		/// </summary>
		[DataMember]
		public String DHBL_Precinto
		{
			get { return m_dhbl_precinto; }
			set
			{
				if (m_dhbl_precinto != value)
				{
					m_dhbl_precinto = value;
					OnPropertyChanged("DHBL_Precinto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DHBL_DescProducto.
		/// </summary>
		[DataMember]
		public String DHBL_DescProducto
		{
			get { return m_dhbl_descproducto; }
			set
			{
				if (m_dhbl_descproducto != value)
				{
					m_dhbl_descproducto = value;
					OnPropertyChanged("DHBL_DescProducto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DHBL_MarcasNumeros.
		/// </summary>
		[DataMember]
		public String DHBL_MarcasNumeros
		{
			get { return m_dhbl_marcasnumeros; }
			set
			{
				if (m_dhbl_marcasnumeros != value)
				{
					m_dhbl_marcasnumeros = value;
					OnPropertyChanged("DHBL_MarcasNumeros");
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

            if (!String.IsNullOrEmpty(m_tipo_codimo))
            { TIPO_TabIMO = "IMO"; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DHBL_EsIMO.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> DHBL_EsIMO
		{
			get { return m_dhbl_esimo; }
			set
			{
				if (m_dhbl_esimo != value)
				{
					m_dhbl_esimo = value;
					OnPropertyChanged("DHBL_EsIMO");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DHBL_ContractNRO.
		/// </summary>
		[DataMember]
		public String DHBL_ContractNRO
		{
			get { return m_dhbl_contractnro; }
			set
			{
				if (m_dhbl_contractnro != value)
				{
					m_dhbl_contractnro = value;
					OnPropertyChanged("DHBL_ContractNRO");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DHBL_PP.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> DHBL_PP
		{
			get { return m_dhbl_pp; }
			set
			{
				if (m_dhbl_pp != value)
				{
					m_dhbl_pp = value;
					OnPropertyChanged("DHBL_PP");
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
					OnPropertyChanged("TIPO_CodCDT");
				}

            if (!String.IsNullOrEmpty(m_tipo_codcdt))
            { TIPO_TabCDT = "CDT"; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabPAC.
		/// </summary>
		[DataMember]
		public String TIPO_TabPAC
		{
			get { return m_tipo_tabpac; }
			set
			{
				if (m_tipo_tabpac != value)
				{
					m_tipo_tabpac = value;
					OnPropertyChanged("TIPO_TabPAC");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodPAC.
		/// </summary>
		[DataMember]
		public String TIPO_CodPAC
		{
			get { return m_tipo_codpac; }
			set
			{
				if (m_tipo_codpac != value)
				{
					m_tipo_codpac = value;
					OnPropertyChanged("TIPO_CodPAC");
				}

            if (!String.IsNullOrEmpty(m_tipo_codpac))
            { TIPO_TabPAC = "PAC"; }
			}
		}

      /// <summary>
      /// Gets or sets el valor de: DHBL_ImoUN.
      /// </summary>
      [DataMember]
      public String DHBL_ImoUN
      {
         get { return m_dhbl_imoun; }
         set
         {
            if (m_dhbl_imoun != value)
            {
               m_dhbl_imoun = value;
               OnPropertyChanged("DHBL_ImoUN");
            }

         }
      }
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Det_CNTR Item)
		{
			try
			{
				if (Item == null) { Item = new Det_CNTR(); }
				Item.CCOT_Numero = this.CCOT_Numero;
				Item.CCOT_Tipo = this.CCOT_Tipo;
				Item.CMBL_codigo = this.CMBL_codigo;
				Item.PACK_Codigo = this.PACK_Codigo;
				Item.DHBL_PesoBruto = this.DHBL_PesoBruto;
				Item.DHBL_Volumen = this.DHBL_Volumen;
				Item.DHBL_CantBultos = this.DHBL_CantBultos;
				Item.DHBL_Precinto = this.DHBL_Precinto;
				Item.DHBL_DescProducto = this.DHBL_DescProducto;
				Item.DHBL_MarcasNumeros = this.DHBL_MarcasNumeros;
				Item.TIPO_TabIMO = this.TIPO_TabIMO;
				Item.TIPO_CodIMO = this.TIPO_CodIMO;
				Item.DHBL_EsIMO = this.DHBL_EsIMO;
				Item.DHBL_ContractNRO = this.DHBL_ContractNRO;
				Item.DHBL_PP = this.DHBL_PP;
				Item.CNTR_Numero = this.CNTR_Numero;
				Item.DHBL_Item = this.DHBL_Item;
				Item.TIPO_TabCDT = this.TIPO_TabCDT;
				Item.TIPO_CodCDT = this.TIPO_CodCDT;
				Item.TIPO_TabPAC = this.TIPO_TabPAC;
				Item.TIPO_CodPAC = this.TIPO_CodPAC;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
