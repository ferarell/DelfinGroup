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
	public partial class DirecENTC
	{
		#region [ Variables Validación ]
		private Boolean m_entc_codigoOK;
		private String m_entc_codigoMSGERROR;
		private Boolean m_dire_codigoOK;
		private String m_dire_codigoMSGERROR;
		private Boolean m_dire_direccionOK;
		private String m_dire_direccionMSGERROR;
		private Boolean m_dire_facturarOK;
		private String m_dire_facturarMSGERROR;
		private Boolean m_dire_referenciaOK;
		private String m_dire_referenciaMSGERROR;
		private Boolean m_dire_activoOK;
		private String m_dire_activoMSGERROR;
		private Boolean m_ubig_codigoOK;
		private String m_ubig_codigoMSGERROR;
		private Boolean m_tipo_tabpaisOK;
		private String m_tipo_tabpaisMSGERROR;
		private Boolean m_tipo_codpaisOK;
		private String m_tipo_codpaisMSGERROR;
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
		/// Gets or sets el valor de validación de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodigoOK
		{
			get { return m_entc_codigoOK; }
			set
			{
				if (m_entc_codigoOK != value)
				{
					m_entc_codigoOK = value;
					OnPropertyChanged("ENTC_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public String ENTC_CodigoMSGERROR
		{
			get { return m_entc_codigoMSGERROR; }
			set
			{
				if (m_entc_codigoMSGERROR != value)
				{
					m_entc_codigoMSGERROR = value;
					OnPropertyChanged("ENTC_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DIRE_Codigo.
		/// </summary>
		[DataMember]
		public Boolean DIRE_CodigoOK
		{
			get { return m_dire_codigoOK; }
			set
			{
				if (m_dire_codigoOK != value)
				{
					m_dire_codigoOK = value;
					OnPropertyChanged("DIRE_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DIRE_Codigo.
		/// </summary>
		[DataMember]
		public String DIRE_CodigoMSGERROR
		{
			get { return m_dire_codigoMSGERROR; }
			set
			{
				if (m_dire_codigoMSGERROR != value)
				{
					m_dire_codigoMSGERROR = value;
					OnPropertyChanged("DIRE_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DIRE_Direccion.
		/// </summary>
		[DataMember]
		public Boolean DIRE_DireccionOK
		{
			get { return m_dire_direccionOK; }
			set
			{
				if (m_dire_direccionOK != value)
				{
					m_dire_direccionOK = value;
					OnPropertyChanged("DIRE_DireccionOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DIRE_Direccion.
		/// </summary>
		[DataMember]
		public String DIRE_DireccionMSGERROR
		{
			get { return m_dire_direccionMSGERROR; }
			set
			{
				if (m_dire_direccionMSGERROR != value)
				{
					m_dire_direccionMSGERROR = value;
					OnPropertyChanged("DIRE_DireccionMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DIRE_Facturar.
		/// </summary>
		[DataMember]
		public Boolean DIRE_FacturarOK
		{
			get { return m_dire_facturarOK; }
			set
			{
				if (m_dire_facturarOK != value)
				{
					m_dire_facturarOK = value;
					OnPropertyChanged("DIRE_FacturarOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DIRE_Facturar.
		/// </summary>
		[DataMember]
		public String DIRE_FacturarMSGERROR
		{
			get { return m_dire_facturarMSGERROR; }
			set
			{
				if (m_dire_facturarMSGERROR != value)
				{
					m_dire_facturarMSGERROR = value;
					OnPropertyChanged("DIRE_FacturarMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DIRE_Referencia.
		/// </summary>
		[DataMember]
		public Boolean DIRE_ReferenciaOK
		{
			get { return m_dire_referenciaOK; }
			set
			{
				if (m_dire_referenciaOK != value)
				{
					m_dire_referenciaOK = value;
					OnPropertyChanged("DIRE_ReferenciaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DIRE_Referencia.
		/// </summary>
		[DataMember]
		public String DIRE_ReferenciaMSGERROR
		{
			get { return m_dire_referenciaMSGERROR; }
			set
			{
				if (m_dire_referenciaMSGERROR != value)
				{
					m_dire_referenciaMSGERROR = value;
					OnPropertyChanged("DIRE_ReferenciaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DIRE_Activo.
		/// </summary>
		[DataMember]
		public Boolean DIRE_ActivoOK
		{
			get { return m_dire_activoOK; }
			set
			{
				if (m_dire_activoOK != value)
				{
					m_dire_activoOK = value;
					OnPropertyChanged("DIRE_ActivoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DIRE_Activo.
		/// </summary>
		[DataMember]
		public String DIRE_ActivoMSGERROR
		{
			get { return m_dire_activoMSGERROR; }
			set
			{
				if (m_dire_activoMSGERROR != value)
				{
					m_dire_activoMSGERROR = value;
					OnPropertyChanged("DIRE_ActivoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: UBIG_Codigo.
		/// </summary>
		[DataMember]
		public Boolean UBIG_CodigoOK
		{
			get { return m_ubig_codigoOK; }
			set
			{
				if (m_ubig_codigoOK != value)
				{
					m_ubig_codigoOK = value;
					OnPropertyChanged("UBIG_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: UBIG_Codigo.
		/// </summary>
		[DataMember]
		public String UBIG_CodigoMSGERROR
		{
			get { return m_ubig_codigoMSGERROR; }
			set
			{
				if (m_ubig_codigoMSGERROR != value)
				{
					m_ubig_codigoMSGERROR = value;
					OnPropertyChanged("UBIG_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabPais.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabPaisOK
		{
			get { return m_tipo_tabpaisOK; }
			set
			{
				if (m_tipo_tabpaisOK != value)
				{
					m_tipo_tabpaisOK = value;
					OnPropertyChanged("TIPO_TabPaisOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabPais.
		/// </summary>
		[DataMember]
		public String TIPO_TabPaisMSGERROR
		{
			get { return m_tipo_tabpaisMSGERROR; }
			set
			{
				if (m_tipo_tabpaisMSGERROR != value)
				{
					m_tipo_tabpaisMSGERROR = value;
					OnPropertyChanged("TIPO_TabPaisMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodPais.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodPaisOK
		{
			get { return m_tipo_codpaisOK; }
			set
			{
				if (m_tipo_codpaisOK != value)
				{
					m_tipo_codpaisOK = value;
					OnPropertyChanged("TIPO_CodPaisOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodPais.
		/// </summary>
		[DataMember]
		public String TIPO_CodPaisMSGERROR
		{
			get { return m_tipo_codpaisMSGERROR; }
			set
			{
				if (m_tipo_codpaisMSGERROR != value)
				{
					m_tipo_codpaisMSGERROR = value;
					OnPropertyChanged("TIPO_CodPaisMSGERROR");
				}
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
				ENTC_CodigoOK  = true;
				ENTC_CodigoMSGERROR  = "";
				if( ENTC_Codigo == null)
				{
					_isCorrect = false;
					ENTC_CodigoOK  = false;
					ENTC_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ENTC_Codigo", "DirecENTC");
					m_mensajeError += "* Debe ingresar el campo ENTC_Codigo" + Environment.NewLine;
				}
				DIRE_CodigoOK  = true;
				DIRE_CodigoMSGERROR  = "";
				if( DIRE_Codigo == null)
				{
					_isCorrect = false;
					DIRE_CodigoOK  = false;
					DIRE_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DIRE_Codigo", "DirecENTC");
					m_mensajeError += "* Debe ingresar el campo DIRE_Codigo" + Environment.NewLine;
				}
				DIRE_DireccionOK  = true;
				DIRE_DireccionMSGERROR  = "";
				if( String.IsNullOrEmpty(DIRE_Direccion) )
				{
					_isCorrect = false;
					DIRE_DireccionOK  = false;
					DIRE_DireccionMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DIRE_Direccion", "DirecENTC");
					m_mensajeError += "* Debe ingresar el campo DIRE_Direccion" + Environment.NewLine;
				}
				DIRE_FacturarOK  = true;
				DIRE_FacturarMSGERROR  = "";
				if( DIRE_Facturar == null)
				{
					_isCorrect = false;
					DIRE_FacturarOK  = false;
					DIRE_FacturarMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DIRE_Facturar", "DirecENTC");
					m_mensajeError += "* Debe ingresar el campo DIRE_Facturar" + Environment.NewLine;
				}
				DIRE_ActivoOK  = true;
				DIRE_ActivoMSGERROR  = "";
				if( DIRE_Activo == null)
				{
					_isCorrect = false;
					DIRE_ActivoOK  = false;
					DIRE_ActivoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DIRE_Activo", "DirecENTC");
					m_mensajeError += "* Debe ingresar el campo DIRE_Activo" + Environment.NewLine;
				}
				OnPropertyChanged("MensajeError");
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
