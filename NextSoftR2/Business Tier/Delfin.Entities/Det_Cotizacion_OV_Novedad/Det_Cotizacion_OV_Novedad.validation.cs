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
	public partial class Det_Cotizacion_OV_Novedad
	{
		#region [ Variables Validación ]
		private Boolean m_ovno_codigoOK;
		private String m_ovno_codigoMSGERROR;
		private Boolean m_ccot_numeroOK;
		private String m_ccot_numeroMSGERROR;
		private Boolean m_ccot_tipoOK;
		private String m_ccot_tipoMSGERROR;
		private Boolean m_ovno_fechaOK;
		private String m_ovno_fechaMSGERROR;
		private Boolean m_ovno_descripOK;
		private String m_ovno_descripMSGERROR;
		private Boolean m_ovno_emailOK;
		private String m_ovno_emailMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		private Boolean m_cons_tabnotOK;
		private String m_cons_tabnotMSGERROR;
		private Boolean m_cons_codnotOK;
		private String m_cons_codnotMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: OVNO_Codigo.
		/// </summary>
		[DataMember]
		public Boolean OVNO_CodigoOK
		{
			get { return m_ovno_codigoOK; }
			set
			{
				if (m_ovno_codigoOK != value)
				{
					m_ovno_codigoOK = value;
					OnPropertyChanged("OVNO_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: OVNO_Codigo.
		/// </summary>
		[DataMember]
		public String OVNO_CodigoMSGERROR
		{
			get { return m_ovno_codigoMSGERROR; }
			set
			{
				if (m_ovno_codigoMSGERROR != value)
				{
					m_ovno_codigoMSGERROR = value;
					OnPropertyChanged("OVNO_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public Boolean CCOT_NumeroOK
		{
			get { return m_ccot_numeroOK; }
			set
			{
				if (m_ccot_numeroOK != value)
				{
					m_ccot_numeroOK = value;
					OnPropertyChanged("CCOT_NumeroOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public String CCOT_NumeroMSGERROR
		{
			get { return m_ccot_numeroMSGERROR; }
			set
			{
				if (m_ccot_numeroMSGERROR != value)
				{
					m_ccot_numeroMSGERROR = value;
					OnPropertyChanged("CCOT_NumeroMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public Boolean CCOT_TipoOK
		{
			get { return m_ccot_tipoOK; }
			set
			{
				if (m_ccot_tipoOK != value)
				{
					m_ccot_tipoOK = value;
					OnPropertyChanged("CCOT_TipoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public String CCOT_TipoMSGERROR
		{
			get { return m_ccot_tipoMSGERROR; }
			set
			{
				if (m_ccot_tipoMSGERROR != value)
				{
					m_ccot_tipoMSGERROR = value;
					OnPropertyChanged("CCOT_TipoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: OVNO_Fecha.
		/// </summary>
		[DataMember]
		public Boolean OVNO_FechaOK
		{
			get { return m_ovno_fechaOK; }
			set
			{
				if (m_ovno_fechaOK != value)
				{
					m_ovno_fechaOK = value;
					OnPropertyChanged("OVNO_FechaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: OVNO_Fecha.
		/// </summary>
		[DataMember]
		public String OVNO_FechaMSGERROR
		{
			get { return m_ovno_fechaMSGERROR; }
			set
			{
				if (m_ovno_fechaMSGERROR != value)
				{
					m_ovno_fechaMSGERROR = value;
					OnPropertyChanged("OVNO_FechaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: OVNO_Descrip.
		/// </summary>
		[DataMember]
		public Boolean OVNO_DescripOK
		{
			get { return m_ovno_descripOK; }
			set
			{
				if (m_ovno_descripOK != value)
				{
					m_ovno_descripOK = value;
					OnPropertyChanged("OVNO_DescripOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: OVNO_Descrip.
		/// </summary>
		[DataMember]
		public String OVNO_DescripMSGERROR
		{
			get { return m_ovno_descripMSGERROR; }
			set
			{
				if (m_ovno_descripMSGERROR != value)
				{
					m_ovno_descripMSGERROR = value;
					OnPropertyChanged("OVNO_DescripMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: OVNO_Email.
		/// </summary>
		[DataMember]
		public Boolean OVNO_EmailOK
		{
			get { return m_ovno_emailOK; }
			set
			{
				if (m_ovno_emailOK != value)
				{
					m_ovno_emailOK = value;
					OnPropertyChanged("OVNO_EmailOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: OVNO_Email.
		/// </summary>
		[DataMember]
		public String OVNO_EmailMSGERROR
		{
			get { return m_ovno_emailMSGERROR; }
			set
			{
				if (m_ovno_emailMSGERROR != value)
				{
					m_ovno_emailMSGERROR = value;
					OnPropertyChanged("OVNO_EmailMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabNot.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabNotOK
		{
			get { return m_cons_tabnotOK; }
			set
			{
				if (m_cons_tabnotOK != value)
				{
					m_cons_tabnotOK = value;
					OnPropertyChanged("CONS_TabNotOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabNot.
		/// </summary>
		[DataMember]
		public String CONS_TabNotMSGERROR
		{
			get { return m_cons_tabnotMSGERROR; }
			set
			{
				if (m_cons_tabnotMSGERROR != value)
				{
					m_cons_tabnotMSGERROR = value;
					OnPropertyChanged("CONS_TabNotMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodNot.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodNotOK
		{
			get { return m_cons_codnotOK; }
			set
			{
				if (m_cons_codnotOK != value)
				{
					m_cons_codnotOK = value;
					OnPropertyChanged("CONS_CodNotOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodNot.
		/// </summary>
		[DataMember]
		public String CONS_CodNotMSGERROR
		{
			get { return m_cons_codnotMSGERROR; }
			set
			{
				if (m_cons_codnotMSGERROR != value)
				{
					m_cons_codnotMSGERROR = value;
					OnPropertyChanged("CONS_CodNotMSGERROR");
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
				OVNO_CodigoOK  = true;
				OVNO_CodigoMSGERROR  = "";
				if( OVNO_Codigo == null)
				{
					_isCorrect = false;
					OVNO_CodigoOK  = false;
					OVNO_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "OVNO_Codigo", "Det_Cotizacion_OV_Novedad");
					m_mensajeError += "* Debe ingresar el campo OVNO_Codigo" + Environment.NewLine;
				}
				CCOT_NumeroOK  = true;
				CCOT_NumeroMSGERROR  = "";
				if( CCOT_Numero == null)
				{
					_isCorrect = false;
					CCOT_NumeroOK  = false;
					CCOT_NumeroMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Numero", "Det_Cotizacion_OV_Novedad");
					m_mensajeError += "* Debe ingresar el campo CCOT_Numero" + Environment.NewLine;
				}
				CCOT_TipoOK  = true;
				CCOT_TipoMSGERROR  = "";
				if( CCOT_Tipo == null)
				{
					_isCorrect = false;
					CCOT_TipoOK  = false;
					CCOT_TipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Tipo", "Det_Cotizacion_OV_Novedad");
					m_mensajeError += "* Debe ingresar el campo CCOT_Tipo" + Environment.NewLine;
				}
				OVNO_DescripOK  = true;
				OVNO_DescripMSGERROR  = "";
				if( String.IsNullOrEmpty(OVNO_Descrip) )
				{
					_isCorrect = false;
					OVNO_DescripOK  = false;
					OVNO_DescripMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "OVNO_Descrip", "Det_Cotizacion_OV_Novedad");
					m_mensajeError += "* Debe ingresar el campo OVNO_Descrip" + Environment.NewLine;
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
