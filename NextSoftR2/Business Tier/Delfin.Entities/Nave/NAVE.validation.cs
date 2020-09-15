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
using Delfin.Entities;

namespace Delfin.Entities
{
	public partial class Nave
	{
		#region [ Variables Validación ]
		private Boolean m_NAVE_codigoOK;

		private String m_NAVE_codigoMSGERROR;
		private Boolean m_NAVE_nombreOK;
		private String m_NAVE_nombreMSGERROR;
		private Boolean m_entc_codtransportistaOK;
		private String m_entc_codtransportistaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: NAVE_Codigo.
		/// </summary>
		[DataMember]
		public Boolean NAVE_CodigoOK
		{
			get { return m_NAVE_codigoOK; }
			set
			{
				if (m_NAVE_codigoOK != value)
				{
					m_NAVE_codigoOK = value;
					OnPropertyChanged("NAVE_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: NAVE_Codigo.
		/// </summary>
		[DataMember]
		public String NAVE_CodigoMSGERROR
		{
			get { return m_NAVE_codigoMSGERROR; }
			set
			{
				if (m_NAVE_codigoMSGERROR != value)
				{
					m_NAVE_codigoMSGERROR = value;
					OnPropertyChanged("NAVE_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: NAVE_Nombre.
		/// </summary>
		[DataMember]
		public Boolean NAVE_NombreOK
		{
			get { return m_NAVE_nombreOK; }
			set
			{
				if (m_NAVE_nombreOK != value)
				{
					m_NAVE_nombreOK = value;
					OnPropertyChanged("NAVE_NombreOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: NAVE_Nombre.
		/// </summary>
		[DataMember]
		public String NAVE_NombreMSGERROR
		{
			get { return m_NAVE_nombreMSGERROR; }
			set
			{
				if (m_NAVE_nombreMSGERROR != value)
				{
					m_NAVE_nombreMSGERROR = value;
					OnPropertyChanged("NAVE_NombreMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodTransportista.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodTransportistaOK
		{
			get { return m_entc_codtransportistaOK; }
			set
			{
				if (m_entc_codtransportistaOK != value)
				{
					m_entc_codtransportistaOK = value;
					OnPropertyChanged("ENTC_CodTransportistaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodTransportista.
		/// </summary>
		[DataMember]
		public String ENTC_CodTransportistaMSGERROR
		{
			get { return m_entc_codtransportistaMSGERROR; }
			set
			{
				if (m_entc_codtransportistaMSGERROR != value)
				{
					m_entc_codtransportistaMSGERROR = value;
					OnPropertyChanged("ENTC_CodTransportistaMSGERROR");
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
				NAVE_CodigoOK  = true;
				NAVE_CodigoMSGERROR  = "";
				if( NAVE_Codigo == null)
				{
					_isCorrect = false;
					NAVE_CodigoOK  = false;
					NAVE_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "NAVE_Codigo", "NAVE");
					m_mensajeError += "* Debe ingresar el campo NAVE_Codigo" + Environment.NewLine;
				}
				NAVE_NombreOK  = true;
				NAVE_NombreMSGERROR  = "";
				if( String.IsNullOrEmpty(NAVE_Nombre) )
				{
					_isCorrect = false;
					NAVE_NombreOK  = false;
					NAVE_NombreMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "NAVE_Nombre", "NAVE");
					m_mensajeError += "* Debe ingresar el campo NAVE_Nombre" + Environment.NewLine;
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
