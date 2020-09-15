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
	public partial class Entidad_Servicio
	{
		#region [ Variables Validación ]
		private Boolean m_eser_codigoOK;
		private String m_eser_codigoMSGERROR;
		private Boolean m_serv_codigoOK;
		private String m_serv_codigoMSGERROR;
		private Boolean m_eser_valorOK;
		private String m_eser_valorMSGERROR;
		private Boolean m_eser_exoneradoOK;
		private String m_eser_exoneradoMSGERROR;
		private Boolean m_entc_codigoOK;
		private String m_entc_codigoMSGERROR;
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
		/// Gets or sets el valor de validación de: ESER_Codigo.
		/// </summary>
		[DataMember]
		public Boolean ESER_CodigoOK
		{
			get { return m_eser_codigoOK; }
			set
			{
				if (m_eser_codigoOK != value)
				{
					m_eser_codigoOK = value;
					OnPropertyChanged("ESER_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ESER_Codigo.
		/// </summary>
		[DataMember]
		public String ESER_CodigoMSGERROR
		{
			get { return m_eser_codigoMSGERROR; }
			set
			{
				if (m_eser_codigoMSGERROR != value)
				{
					m_eser_codigoMSGERROR = value;
					OnPropertyChanged("ESER_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SERV_Codigo.
		/// </summary>
		[DataMember]
		public Boolean SERV_CodigoOK
		{
			get { return m_serv_codigoOK; }
			set
			{
				if (m_serv_codigoOK != value)
				{
					m_serv_codigoOK = value;
					OnPropertyChanged("SERV_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SERV_Codigo.
		/// </summary>
		[DataMember]
		public String SERV_CodigoMSGERROR
		{
			get { return m_serv_codigoMSGERROR; }
			set
			{
				if (m_serv_codigoMSGERROR != value)
				{
					m_serv_codigoMSGERROR = value;
					OnPropertyChanged("SERV_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ESER_Valor.
		/// </summary>
		[DataMember]
		public Boolean ESER_ValorOK
		{
			get { return m_eser_valorOK; }
			set
			{
				if (m_eser_valorOK != value)
				{
					m_eser_valorOK = value;
					OnPropertyChanged("ESER_ValorOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ESER_Valor.
		/// </summary>
		[DataMember]
		public String ESER_ValorMSGERROR
		{
			get { return m_eser_valorMSGERROR; }
			set
			{
				if (m_eser_valorMSGERROR != value)
				{
					m_eser_valorMSGERROR = value;
					OnPropertyChanged("ESER_ValorMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ESER_Exonerado.
		/// </summary>
		[DataMember]
		public Boolean ESER_ExoneradoOK
		{
			get { return m_eser_exoneradoOK; }
			set
			{
				if (m_eser_exoneradoOK != value)
				{
					m_eser_exoneradoOK = value;
					OnPropertyChanged("ESER_ExoneradoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ESER_Exonerado.
		/// </summary>
		[DataMember]
		public String ESER_ExoneradoMSGERROR
		{
			get { return m_eser_exoneradoMSGERROR; }
			set
			{
				if (m_eser_exoneradoMSGERROR != value)
				{
					m_eser_exoneradoMSGERROR = value;
					OnPropertyChanged("ESER_ExoneradoMSGERROR");
				}
			}
		}
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
				ESER_CodigoOK  = true;
				ESER_CodigoMSGERROR  = "";
				if( ESER_Codigo == null)
				{
					_isCorrect = false;
					ESER_CodigoOK  = false;
					ESER_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ESER_Codigo", "Entidad_Servicio");
					m_mensajeError += "* Debe ingresar el campo ESER_Codigo" + Environment.NewLine;
				}
				ESER_ValorOK  = true;
				ESER_ValorMSGERROR  = "";
				if( ESER_Valor == null)
				{
					_isCorrect = false;
					ESER_ValorOK  = false;
					ESER_ValorMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ESER_Valor", "Entidad_Servicio");
					m_mensajeError += "* Debe ingresar el campo ESER_Valor" + Environment.NewLine;
				}
				ESER_ExoneradoOK  = true;
				ESER_ExoneradoMSGERROR  = "";
				if( ESER_Exonerado == null)
				{
					_isCorrect = false;
					ESER_ExoneradoOK  = false;
					ESER_ExoneradoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ESER_Exonerado", "Entidad_Servicio");
					m_mensajeError += "* Debe ingresar el campo ESER_Exonerado" + Environment.NewLine;
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
