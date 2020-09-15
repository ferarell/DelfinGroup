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
	public partial class Puerto
	{
		#region [ Variables Validación ]
		private Boolean m_puer_codigoOK;
		private String m_puer_codigoMSGERROR;
		private Boolean m_puer_codestandarOK;
		private String m_puer_codestandarMSGERROR;
		private Boolean m_cons_tabviaOK;
		private String m_cons_tabviaMSGERROR;
		private Boolean m_cons_codviaOK;
		private String m_cons_codviaMSGERROR;
		private Boolean m_puer_nombreOK;
		private String m_puer_nombreMSGERROR;
		private Boolean m_puer_favoritoOK;
		private String m_puer_favoritoMSGERROR;
		private Boolean m_tipo_tabpaisOK;
		private String m_tipo_tabpaisMSGERROR;
		private Boolean m_tipo_codpaisOK;
		private String m_tipo_codpaisMSGERROR;
		private Boolean m_puer_activoOK;
		private String m_puer_activoMSGERROR;
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
		/// Gets or sets el valor de validación de: PUER_Codigo.
		/// </summary>
		[DataMember]
		public Boolean PUER_CodigoOK
		{
			get { return m_puer_codigoOK; }
			set
			{
				if (m_puer_codigoOK != value)
				{
					m_puer_codigoOK = value;
					OnPropertyChanged("PUER_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PUER_Codigo.
		/// </summary>
		[DataMember]
		public String PUER_CodigoMSGERROR
		{
			get { return m_puer_codigoMSGERROR; }
			set
			{
				if (m_puer_codigoMSGERROR != value)
				{
					m_puer_codigoMSGERROR = value;
					OnPropertyChanged("PUER_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PUER_CodEstandar.
		/// </summary>
		[DataMember]
		public Boolean PUER_CodEstandarOK
		{
			get { return m_puer_codestandarOK; }
			set
			{
				if (m_puer_codestandarOK != value)
				{
					m_puer_codestandarOK = value;
					OnPropertyChanged("PUER_CodEstandarOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PUER_CodEstandar.
		/// </summary>
		[DataMember]
		public String PUER_CodEstandarMSGERROR
		{
			get { return m_puer_codestandarMSGERROR; }
			set
			{
				if (m_puer_codestandarMSGERROR != value)
				{
					m_puer_codestandarMSGERROR = value;
					OnPropertyChanged("PUER_CodEstandarMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabVia.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabViaOK
		{
			get { return m_cons_tabviaOK; }
			set
			{
				if (m_cons_tabviaOK != value)
				{
					m_cons_tabviaOK = value;
					OnPropertyChanged("CONS_TabViaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabVia.
		/// </summary>
		[DataMember]
		public String CONS_TabViaMSGERROR
		{
			get { return m_cons_tabviaMSGERROR; }
			set
			{
				if (m_cons_tabviaMSGERROR != value)
				{
					m_cons_tabviaMSGERROR = value;
					OnPropertyChanged("CONS_TabViaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodVia.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodViaOK
		{
			get { return m_cons_codviaOK; }
			set
			{
				if (m_cons_codviaOK != value)
				{
					m_cons_codviaOK = value;
					OnPropertyChanged("CONS_CodViaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodVia.
		/// </summary>
		[DataMember]
		public String CONS_CodViaMSGERROR
		{
			get { return m_cons_codviaMSGERROR; }
			set
			{
				if (m_cons_codviaMSGERROR != value)
				{
					m_cons_codviaMSGERROR = value;
					OnPropertyChanged("CONS_CodViaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PUER_Nombre.
		/// </summary>
		[DataMember]
		public Boolean PUER_NombreOK
		{
			get { return m_puer_nombreOK; }
			set
			{
				if (m_puer_nombreOK != value)
				{
					m_puer_nombreOK = value;
					OnPropertyChanged("PUER_NombreOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PUER_Nombre.
		/// </summary>
		[DataMember]
		public String PUER_NombreMSGERROR
		{
			get { return m_puer_nombreMSGERROR; }
			set
			{
				if (m_puer_nombreMSGERROR != value)
				{
					m_puer_nombreMSGERROR = value;
					OnPropertyChanged("PUER_NombreMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PUER_Favorito.
		/// </summary>
		[DataMember]
		public Boolean PUER_FavoritoOK
		{
			get { return m_puer_favoritoOK; }
			set
			{
				if (m_puer_favoritoOK != value)
				{
					m_puer_favoritoOK = value;
					OnPropertyChanged("PUER_FavoritoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PUER_Favorito.
		/// </summary>
		[DataMember]
		public String PUER_FavoritoMSGERROR
		{
			get { return m_puer_favoritoMSGERROR; }
			set
			{
				if (m_puer_favoritoMSGERROR != value)
				{
					m_puer_favoritoMSGERROR = value;
					OnPropertyChanged("PUER_FavoritoMSGERROR");
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
		/// <summary>
		/// Gets or sets el valor de validación de: PUER_Activo.
		/// </summary>
		[DataMember]
		public Boolean PUER_ActivoOK
		{
			get { return m_puer_activoOK; }
			set
			{
				if (m_puer_activoOK != value)
				{
					m_puer_activoOK = value;
					OnPropertyChanged("PUER_ActivoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PUER_Activo.
		/// </summary>
		[DataMember]
		public String PUER_ActivoMSGERROR
		{
			get { return m_puer_activoMSGERROR; }
			set
			{
				if (m_puer_activoMSGERROR != value)
				{
					m_puer_activoMSGERROR = value;
					OnPropertyChanged("PUER_ActivoMSGERROR");
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
				PUER_CodigoOK  = true;
				PUER_CodigoMSGERROR  = "";
				if( PUER_Codigo == null)
				{
					_isCorrect = false;
					PUER_CodigoOK  = false;
					PUER_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PUER_Codigo", "Puerto");
					m_mensajeError += "* Debe ingresar el campo PUER_Codigo" + Environment.NewLine;
				}
				PUER_CodEstandarOK  = true;
				PUER_CodEstandarMSGERROR  = "";
				if( String.IsNullOrEmpty(PUER_CodEstandar) )
				{
					_isCorrect = false;
					PUER_CodEstandarOK  = false;
					PUER_CodEstandarMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PUER_CodEstandar", "Puerto");
					m_mensajeError += "* Debe ingresar el campo PUER_CodEstandar" + Environment.NewLine;
				}
				CONS_TabViaOK  = true;
				CONS_TabViaMSGERROR  = "";
				if( String.IsNullOrEmpty(CONS_TabVia) )
				{
					_isCorrect = false;
					CONS_TabViaOK  = false;
					CONS_TabViaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONS_TabVia", "Puerto");
					m_mensajeError += "* Debe ingresar el campo CONS_TabVia" + Environment.NewLine;
				}
				CONS_CodViaOK  = true;
				CONS_CodViaMSGERROR  = "";
				if( String.IsNullOrEmpty(CONS_CodVia) )
				{
					_isCorrect = false;
					CONS_CodViaOK  = false;
					CONS_CodViaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONS_CodVia", "Puerto");
					m_mensajeError += "* Debe ingresar el campo CONS_CodVia" + Environment.NewLine;
				}
				PUER_NombreOK  = true;
				PUER_NombreMSGERROR  = "";
				if( String.IsNullOrEmpty(PUER_Nombre) )
				{
					_isCorrect = false;
					PUER_NombreOK  = false;
					PUER_NombreMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PUER_Nombre", "Puerto");
					m_mensajeError += "* Debe ingresar el campo PUER_Nombre" + Environment.NewLine;
				}
				PUER_FavoritoOK  = true;
				PUER_FavoritoMSGERROR  = "";
				if( PUER_Favorito == null)
				{
					_isCorrect = false;
					PUER_FavoritoOK  = false;
					PUER_FavoritoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PUER_Favorito", "Puerto");
					m_mensajeError += "* Debe ingresar el campo PUER_Favorito" + Environment.NewLine;
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
