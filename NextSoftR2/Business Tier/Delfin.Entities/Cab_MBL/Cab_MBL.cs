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
	public partial class Cab_MBL : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_cmbl_codigo;
		private String m_cmbl_numero;
		private String m_cons_tabrgm;
		private String m_cons_codrgm;
		private Nullable<Int32> m_entc_codtransportista;
		private Nullable<Int16> m_tipe_codtransportista;
		private Nullable<DateTime> m_cbml_fecemi;
		private Nullable<Decimal> m_cmbl_pesobruto;
		private Nullable<Decimal> m_cmbl_volumen;
		private Nullable<Decimal> m_cmbl_cantbultos;
		private String m_cmbl_desc;
		private String m_cmbl_marcasnumeros;
      private Nullable<Int16> m_cmbl_canthijos;
		private Nullable<Int32> m_puer_codigo;
		private String m_tipo_tabpaq;
		private String m_tipo_codpaq;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Cab_MBL.
		/// </summary>
		public Cab_MBL()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CMBL_codigo.
		/// </summary>
		[DataMember]
		public Int32 CMBL_codigo
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
		/// Gets or sets el valor de: CMBL_Numero.
		/// </summary>
		[DataMember]
		public String CMBL_Numero
		{
			get { return m_cmbl_numero; }
			set
			{
				if (m_cmbl_numero != value)
				{
					m_cmbl_numero = value;
					OnPropertyChanged("CMBL_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabRGM.
		/// </summary>
		[DataMember]
		public String CONS_TabRGM
		{
			get { return m_cons_tabrgm; }
			set
			{
				if (m_cons_tabrgm != value)
				{
					m_cons_tabrgm = value;
					OnPropertyChanged("CONS_TabRGM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodRGM.
		/// </summary>
		[DataMember]
		public String CONS_CodRGM
		{
			get { return m_cons_codrgm; }
			set
			{
				if (m_cons_codrgm != value)
				{
					m_cons_codrgm = value;
					OnPropertyChanged("CONS_CodRGM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodTransportista.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodTransportista
		{
			get { return m_entc_codtransportista; }
			set
			{
				if (m_entc_codtransportista != value)
				{
					m_entc_codtransportista = value;
					OnPropertyChanged("ENTC_CodTransportista");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPE_CodTransportista.
		/// </summary>
		[DataMember]
		public Nullable<Int16> TIPE_CodTransportista
		{
			get { return m_tipe_codtransportista; }
			set
			{
				if (m_tipe_codtransportista != value)
				{
					m_tipe_codtransportista = value;
					OnPropertyChanged("TIPE_CodTransportista");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CBML_FecEmi.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CBML_FecEmi
		{
			get { return m_cbml_fecemi; }
			set
			{
				if (m_cbml_fecemi != value)
				{
					m_cbml_fecemi = value;
					OnPropertyChanged("CBML_FecEmi");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CMBL_PesoBruto.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> CMBL_PesoBruto
		{
			get { return m_cmbl_pesobruto; }
			set
			{
				if (m_cmbl_pesobruto != value)
				{
					m_cmbl_pesobruto = value;
					OnPropertyChanged("CMBL_PesoBruto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CMBL_Volumen.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> CMBL_Volumen
		{
			get { return m_cmbl_volumen; }
			set
			{
				if (m_cmbl_volumen != value)
				{
					m_cmbl_volumen = value;
					OnPropertyChanged("CMBL_Volumen");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CMBL_CantBultos.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> CMBL_CantBultos
		{
			get { return m_cmbl_cantbultos; }
			set
			{
				if (m_cmbl_cantbultos != value)
				{
					m_cmbl_cantbultos = value;
					OnPropertyChanged("CMBL_CantBultos");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CMBL_Desc.
		/// </summary>
		[DataMember]
		public String CMBL_Desc
		{
			get { return m_cmbl_desc; }
			set
			{
				if (m_cmbl_desc != value)
				{
					m_cmbl_desc = value;
					OnPropertyChanged("CMBL_Desc");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CMBL_MarcasNumeros.
		/// </summary>
		[DataMember]
		public String CMBL_MarcasNumeros
		{
			get { return m_cmbl_marcasnumeros; }
			set
			{
				if (m_cmbl_marcasnumeros != value)
				{
					m_cmbl_marcasnumeros = value;
					OnPropertyChanged("CMBL_MarcasNumeros");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CMBL_CantHijos.
		/// </summary>
		[DataMember]
		public Nullable<Int16> CMBL_CantHijos
		{
			get { return m_cmbl_canthijos; }
			set
			{
				if (m_cmbl_canthijos != value)
				{
					m_cmbl_canthijos = value;
					OnPropertyChanged("CMBL_CantHijos");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PUER_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> PUER_Codigo
		{
			get { return m_puer_codigo; }
			set
			{
				if (m_puer_codigo != value)
				{
					m_puer_codigo = value;
					OnPropertyChanged("PUER_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabPAQ.
		/// </summary>
		[DataMember]
		public String TIPO_TabPAQ
		{
			get { return m_tipo_tabpaq; }
			set
			{
				if (m_tipo_tabpaq != value)
				{
					m_tipo_tabpaq = value;
					OnPropertyChanged("TIPO_TabPAQ");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodPAQ.
		/// </summary>
		[DataMember]
		public String TIPO_CodPAQ
		{
			get { return m_tipo_codpaq; }
			set
			{
				if (m_tipo_codpaq != value)
				{
					m_tipo_codpaq = value;
					OnPropertyChanged("TIPO_CodPAQ");
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
		public void CopyTo(ref Cab_MBL Item)
		{
			try
			{
				if (Item == null) { Item = new Cab_MBL(); }
				Item.CMBL_codigo = this.CMBL_codigo;
				Item.CMBL_Numero = this.CMBL_Numero;
				Item.CONS_TabRGM = this.CONS_TabRGM;
				Item.CONS_CodRGM = this.CONS_CodRGM;
				Item.ENTC_CodTransportista = this.ENTC_CodTransportista;
				Item.TIPE_CodTransportista = this.TIPE_CodTransportista;
				Item.CBML_FecEmi = this.CBML_FecEmi;
				Item.CMBL_PesoBruto = this.CMBL_PesoBruto;
				Item.CMBL_Volumen = this.CMBL_Volumen;
				Item.CMBL_CantBultos = this.CMBL_CantBultos;
				Item.CMBL_Desc = this.CMBL_Desc;
				Item.CMBL_MarcasNumeros = this.CMBL_MarcasNumeros;
				Item.CMBL_CantHijos = this.CMBL_CantHijos;
				Item.PUER_Codigo = this.PUER_Codigo;
				Item.TIPO_TabPAQ = this.TIPO_TabPAQ;
				Item.TIPO_CodPAQ = this.TIPO_CodPAQ;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
