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
	public partial class Cab_MBL
	{
		#region [ Variables Validación ]
		private Boolean m_cmbl_codigoOK;
		private String m_cmbl_codigoMSGERROR;
		private Boolean m_cmbl_numeroOK;
		private String m_cmbl_numeroMSGERROR;
		private Boolean m_cons_tabrgmOK;
		private String m_cons_tabrgmMSGERROR;
		private Boolean m_cons_codrgmOK;
		private String m_cons_codrgmMSGERROR;
		private Boolean m_entc_codtransportistaOK;
		private String m_entc_codtransportistaMSGERROR;
		private Boolean m_tipe_codtransportistaOK;
		private String m_tipe_codtransportistaMSGERROR;
		private Boolean m_cbml_fecemiOK;
		private String m_cbml_fecemiMSGERROR;
		private Boolean m_cmbl_pesobrutoOK;
		private String m_cmbl_pesobrutoMSGERROR;
		private Boolean m_cmbl_volumenOK;
		private String m_cmbl_volumenMSGERROR;
		private Boolean m_cmbl_cantbultosOK;
		private String m_cmbl_cantbultosMSGERROR;
		private Boolean m_cmbl_descOK;
		private String m_cmbl_descMSGERROR;
		private Boolean m_cmbl_marcasnumerosOK;
		private String m_cmbl_marcasnumerosMSGERROR;
		private Boolean m_cmbl_canthijosOK;
		private String m_cmbl_canthijosMSGERROR;
		private Boolean m_puer_codigoOK;
		private String m_puer_codigoMSGERROR;
		private Boolean m_tipo_tabpaqOK;
		private String m_tipo_tabpaqMSGERROR;
		private Boolean m_tipo_codpaqOK;
		private String m_tipo_codpaqMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: CMBL_codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CMBL_codigoOK
		{
			get { return m_cmbl_codigoOK; }
			set
			{
				if (m_cmbl_codigoOK != value)
				{ m_cmbl_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CMBL_codigo.
		/// </summary>
		[IgnoreDataMember]
		public String CMBL_codigoMSGERROR
		{
			get { return m_cmbl_codigoMSGERROR; }
			set
			{
				if (m_cmbl_codigoMSGERROR != value)
				{m_cmbl_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CMBL_Numero.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CMBL_NumeroOK
		{
			get { return m_cmbl_numeroOK; }
			set
			{
				if (m_cmbl_numeroOK != value)
				{ m_cmbl_numeroOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CMBL_Numero.
		/// </summary>
		[IgnoreDataMember]
		public String CMBL_NumeroMSGERROR
		{
			get { return m_cmbl_numeroMSGERROR; }
			set
			{
				if (m_cmbl_numeroMSGERROR != value)
				{m_cmbl_numeroMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabRGM.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CONS_TabRGMOK
		{
			get { return m_cons_tabrgmOK; }
			set
			{
				if (m_cons_tabrgmOK != value)
				{ m_cons_tabrgmOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabRGM.
		/// </summary>
		[IgnoreDataMember]
		public String CONS_TabRGMMSGERROR
		{
			get { return m_cons_tabrgmMSGERROR; }
			set
			{
				if (m_cons_tabrgmMSGERROR != value)
				{m_cons_tabrgmMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodRGM.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CONS_CodRGMOK
		{
			get { return m_cons_codrgmOK; }
			set
			{
				if (m_cons_codrgmOK != value)
				{ m_cons_codrgmOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodRGM.
		/// </summary>
		[IgnoreDataMember]
		public String CONS_CodRGMMSGERROR
		{
			get { return m_cons_codrgmMSGERROR; }
			set
			{
				if (m_cons_codrgmMSGERROR != value)
				{m_cons_codrgmMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodTransportista.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ENTC_CodTransportistaOK
		{
			get { return m_entc_codtransportistaOK; }
			set
			{
				if (m_entc_codtransportistaOK != value)
				{ m_entc_codtransportistaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodTransportista.
		/// </summary>
		[IgnoreDataMember]
		public String ENTC_CodTransportistaMSGERROR
		{
			get { return m_entc_codtransportistaMSGERROR; }
			set
			{
				if (m_entc_codtransportistaMSGERROR != value)
				{m_entc_codtransportistaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPE_CodTransportista.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPE_CodTransportistaOK
		{
			get { return m_tipe_codtransportistaOK; }
			set
			{
				if (m_tipe_codtransportistaOK != value)
				{ m_tipe_codtransportistaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPE_CodTransportista.
		/// </summary>
		[IgnoreDataMember]
		public String TIPE_CodTransportistaMSGERROR
		{
			get { return m_tipe_codtransportistaMSGERROR; }
			set
			{
				if (m_tipe_codtransportistaMSGERROR != value)
				{m_tipe_codtransportistaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CBML_FecEmi.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CBML_FecEmiOK
		{
			get { return m_cbml_fecemiOK; }
			set
			{
				if (m_cbml_fecemiOK != value)
				{ m_cbml_fecemiOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CBML_FecEmi.
		/// </summary>
		[IgnoreDataMember]
		public String CBML_FecEmiMSGERROR
		{
			get { return m_cbml_fecemiMSGERROR; }
			set
			{
				if (m_cbml_fecemiMSGERROR != value)
				{m_cbml_fecemiMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CMBL_PesoBruto.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CMBL_PesoBrutoOK
		{
			get { return m_cmbl_pesobrutoOK; }
			set
			{
				if (m_cmbl_pesobrutoOK != value)
				{ m_cmbl_pesobrutoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CMBL_PesoBruto.
		/// </summary>
		[IgnoreDataMember]
		public String CMBL_PesoBrutoMSGERROR
		{
			get { return m_cmbl_pesobrutoMSGERROR; }
			set
			{
				if (m_cmbl_pesobrutoMSGERROR != value)
				{m_cmbl_pesobrutoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CMBL_Volumen.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CMBL_VolumenOK
		{
			get { return m_cmbl_volumenOK; }
			set
			{
				if (m_cmbl_volumenOK != value)
				{ m_cmbl_volumenOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CMBL_Volumen.
		/// </summary>
		[IgnoreDataMember]
		public String CMBL_VolumenMSGERROR
		{
			get { return m_cmbl_volumenMSGERROR; }
			set
			{
				if (m_cmbl_volumenMSGERROR != value)
				{m_cmbl_volumenMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CMBL_CantBultos.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CMBL_CantBultosOK
		{
			get { return m_cmbl_cantbultosOK; }
			set
			{
				if (m_cmbl_cantbultosOK != value)
				{ m_cmbl_cantbultosOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CMBL_CantBultos.
		/// </summary>
		[IgnoreDataMember]
		public String CMBL_CantBultosMSGERROR
		{
			get { return m_cmbl_cantbultosMSGERROR; }
			set
			{
				if (m_cmbl_cantbultosMSGERROR != value)
				{m_cmbl_cantbultosMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CMBL_Desc.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CMBL_DescOK
		{
			get { return m_cmbl_descOK; }
			set
			{
				if (m_cmbl_descOK != value)
				{ m_cmbl_descOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CMBL_Desc.
		/// </summary>
		[IgnoreDataMember]
		public String CMBL_DescMSGERROR
		{
			get { return m_cmbl_descMSGERROR; }
			set
			{
				if (m_cmbl_descMSGERROR != value)
				{m_cmbl_descMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CMBL_MarcasNumeros.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CMBL_MarcasNumerosOK
		{
			get { return m_cmbl_marcasnumerosOK; }
			set
			{
				if (m_cmbl_marcasnumerosOK != value)
				{ m_cmbl_marcasnumerosOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CMBL_MarcasNumeros.
		/// </summary>
		[IgnoreDataMember]
		public String CMBL_MarcasNumerosMSGERROR
		{
			get { return m_cmbl_marcasnumerosMSGERROR; }
			set
			{
				if (m_cmbl_marcasnumerosMSGERROR != value)
				{m_cmbl_marcasnumerosMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CMBL_CantHijos.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CMBL_CantHijosOK
		{
			get { return m_cmbl_canthijosOK; }
			set
			{
				if (m_cmbl_canthijosOK != value)
				{ m_cmbl_canthijosOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CMBL_CantHijos.
		/// </summary>
		[IgnoreDataMember]
		public String CMBL_CantHijosMSGERROR
		{
			get { return m_cmbl_canthijosMSGERROR; }
			set
			{
				if (m_cmbl_canthijosMSGERROR != value)
				{m_cmbl_canthijosMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PUER_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PUER_CodigoOK
		{
			get { return m_puer_codigoOK; }
			set
			{
				if (m_puer_codigoOK != value)
				{ m_puer_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PUER_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String PUER_CodigoMSGERROR
		{
			get { return m_puer_codigoMSGERROR; }
			set
			{
				if (m_puer_codigoMSGERROR != value)
				{m_puer_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabPAQ.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_TabPAQOK
		{
			get { return m_tipo_tabpaqOK; }
			set
			{
				if (m_tipo_tabpaqOK != value)
				{ m_tipo_tabpaqOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabPAQ.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_TabPAQMSGERROR
		{
			get { return m_tipo_tabpaqMSGERROR; }
			set
			{
				if (m_tipo_tabpaqMSGERROR != value)
				{m_tipo_tabpaqMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodPAQ.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_CodPAQOK
		{
			get { return m_tipo_codpaqOK; }
			set
			{
				if (m_tipo_codpaqOK != value)
				{ m_tipo_codpaqOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodPAQ.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_CodPAQMSGERROR
		{
			get { return m_tipo_codpaqMSGERROR; }
			set
			{
				if (m_tipo_codpaqMSGERROR != value)
				{m_tipo_codpaqMSGERROR = value; }
			}
		}
		#endregion

		#region [ Validacion ]
		private String m_mensajeError;
		
		[DataMember]
		public String MensajeError
		{
			get { return m_mensajeError; }
		}
		public Boolean Validar()
		{
			try
			{
				Boolean _isCorrect = true;
				m_mensajeError = "";
				CMBL_codigoOK  = true;
				CMBL_codigoMSGERROR  = "";
				if( CMBL_codigo == 0)
				{
					_isCorrect = false;
					CMBL_codigoOK  = false;
               CMBL_codigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Código", "Cab_MBL");
					m_mensajeError += "* Debe ingresar el campo Código" + Environment.NewLine;
				}
				CMBL_DescOK  = true;
				CMBL_DescMSGERROR  = "";
				if( String.IsNullOrEmpty(CMBL_Desc) )
				{
					_isCorrect = false;
					CMBL_DescOK  = false;
               CMBL_DescMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Descripción de la Mercadería", "Cab_MBL");
					m_mensajeError += "* Debe ingresar el campo Descripción de la Mercadería" + Environment.NewLine;
				}
				CMBL_MarcasNumerosOK  = true;
				CMBL_MarcasNumerosMSGERROR  = "";
				if( String.IsNullOrEmpty(CMBL_MarcasNumeros) )
				{
					_isCorrect = false;
					CMBL_MarcasNumerosOK  = false;
               CMBL_MarcasNumerosMSGERROR = String.Format("Debe ingresar las {0} de la {1}.", "Marcas y Números", "Cab_MBL");
					m_mensajeError += "* Debe ingresar el campo Marcas y Números" + Environment.NewLine;
				}
				CMBL_CantHijosOK  = true;
				CMBL_CantHijosMSGERROR  = "";
				if( CMBL_CantHijos == null)
				{
					_isCorrect = false;
					CMBL_CantHijosOK  = false;
               CMBL_CantHijosMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Cantidad de Hijos", "Cab_MBL");
					m_mensajeError += "* Debe ingresar el campo Cantidad de Hijos" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
