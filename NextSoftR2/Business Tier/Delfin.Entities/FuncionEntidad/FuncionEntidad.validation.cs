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
	public partial class FuncionEntidad
	{
		#region [ Variables Validación ]
		private Boolean m_entc_codigoOK;
		private String m_entc_codigoMSGERROR;
		private Boolean m_tipe_codigoOK;
		private String m_tipe_codigoMSGERROR;
		private Boolean m_fent_activoOK;
		private String m_fent_activoMSGERROR;
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
		/// Gets or sets el valor de validación de: TIPE_Codigo.
		/// </summary>
		[DataMember]
		public Boolean TIPE_CodigoOK
		{
			get { return m_tipe_codigoOK; }
			set
			{
				if (m_tipe_codigoOK != value)
				{
					m_tipe_codigoOK = value;
					OnPropertyChanged("TIPE_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPE_Codigo.
		/// </summary>
		[DataMember]
		public String TIPE_CodigoMSGERROR
		{
			get { return m_tipe_codigoMSGERROR; }
			set
			{
				if (m_tipe_codigoMSGERROR != value)
				{
					m_tipe_codigoMSGERROR = value;
					OnPropertyChanged("TIPE_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: FENT_Activo.
		/// </summary>
		[DataMember]
		public Boolean FENT_ActivoOK
		{
			get { return m_fent_activoOK; }
			set
			{
				if (m_fent_activoOK != value)
				{
					m_fent_activoOK = value;
					OnPropertyChanged("FENT_ActivoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: FENT_Activo.
		/// </summary>
		[DataMember]
		public String FENT_ActivoMSGERROR
		{
			get { return m_fent_activoMSGERROR; }
			set
			{
				if (m_fent_activoMSGERROR != value)
				{
					m_fent_activoMSGERROR = value;
					OnPropertyChanged("FENT_ActivoMSGERROR");
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
					ENTC_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ENTC_Codigo", "FuncionEntidad");
					m_mensajeError += "* Debe ingresar el campo ENTC_Codigo" + Environment.NewLine;
				}
				TIPE_CodigoOK  = true;
				TIPE_CodigoMSGERROR  = "";
				if( TIPE_Codigo == null)
				{
					_isCorrect = false;
					TIPE_CodigoOK  = false;
					TIPE_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPE_Codigo", "FuncionEntidad");
					m_mensajeError += "* Debe ingresar el campo TIPE_Codigo" + Environment.NewLine;
				}
				FENT_ActivoOK  = true;
				FENT_ActivoMSGERROR  = "";
				if( FENT_Activo == null)
				{
					_isCorrect = false;
					FENT_ActivoOK  = false;
					FENT_ActivoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "FENT_Activo", "FuncionEntidad");
					m_mensajeError += "* Debe ingresar el campo FENT_Activo" + Environment.NewLine;
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
