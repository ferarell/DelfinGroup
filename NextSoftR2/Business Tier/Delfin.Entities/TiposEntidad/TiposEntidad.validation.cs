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
	public partial class TiposEntidad
	{
		#region [ Variables Validación ]
		private Boolean m_tipe_codigoOK;
		private String m_tipe_codigoMSGERROR;
		private Boolean m_tipe_descripcionOK;
		private String m_tipe_descripcionMSGERROR;
		private Boolean m_tipe_nivelOK;
		private String m_tipe_nivelMSGERROR;
		private Boolean m_tipe_padreOK;
		private String m_tipe_padreMSGERROR;
		private Boolean m_tipe_activoOK;
		private String m_tipe_activoMSGERROR;
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
		/// Gets or sets el valor de validación de: TIPE_Descripcion.
		/// </summary>
		[DataMember]
		public Boolean TIPE_DescripcionOK
		{
			get { return m_tipe_descripcionOK; }
			set
			{
				if (m_tipe_descripcionOK != value)
				{
					m_tipe_descripcionOK = value;
					OnPropertyChanged("TIPE_DescripcionOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPE_Descripcion.
		/// </summary>
		[DataMember]
		public String TIPE_DescripcionMSGERROR
		{
			get { return m_tipe_descripcionMSGERROR; }
			set
			{
				if (m_tipe_descripcionMSGERROR != value)
				{
					m_tipe_descripcionMSGERROR = value;
					OnPropertyChanged("TIPE_DescripcionMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPE_Nivel.
		/// </summary>
		[DataMember]
		public Boolean TIPE_NivelOK
		{
			get { return m_tipe_nivelOK; }
			set
			{
				if (m_tipe_nivelOK != value)
				{
					m_tipe_nivelOK = value;
					OnPropertyChanged("TIPE_NivelOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPE_Nivel.
		/// </summary>
		[DataMember]
		public String TIPE_NivelMSGERROR
		{
			get { return m_tipe_nivelMSGERROR; }
			set
			{
				if (m_tipe_nivelMSGERROR != value)
				{
					m_tipe_nivelMSGERROR = value;
					OnPropertyChanged("TIPE_NivelMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPE_Padre.
		/// </summary>
		[DataMember]
		public Boolean TIPE_PadreOK
		{
			get { return m_tipe_padreOK; }
			set
			{
				if (m_tipe_padreOK != value)
				{
					m_tipe_padreOK = value;
					OnPropertyChanged("TIPE_PadreOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPE_Padre.
		/// </summary>
		[DataMember]
		public String TIPE_PadreMSGERROR
		{
			get { return m_tipe_padreMSGERROR; }
			set
			{
				if (m_tipe_padreMSGERROR != value)
				{
					m_tipe_padreMSGERROR = value;
					OnPropertyChanged("TIPE_PadreMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPE_Activo.
		/// </summary>
		[DataMember]
		public Boolean TIPE_ActivoOK
		{
			get { return m_tipe_activoOK; }
			set
			{
				if (m_tipe_activoOK != value)
				{
					m_tipe_activoOK = value;
					OnPropertyChanged("TIPE_ActivoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPE_Activo.
		/// </summary>
		[DataMember]
		public String TIPE_ActivoMSGERROR
		{
			get { return m_tipe_activoMSGERROR; }
			set
			{
				if (m_tipe_activoMSGERROR != value)
				{
					m_tipe_activoMSGERROR = value;
					OnPropertyChanged("TIPE_ActivoMSGERROR");
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
				TIPE_CodigoOK  = true;
				TIPE_CodigoMSGERROR  = "";
				if( TIPE_Codigo == null)
				{
					_isCorrect = false;
					TIPE_CodigoOK  = false;
					TIPE_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPE_Codigo", "TiposEntidad");
					m_mensajeError += "* Debe ingresar el campo TIPE_Codigo" + Environment.NewLine;
				}
				TIPE_DescripcionOK  = true;
				TIPE_DescripcionMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPE_Descripcion) )
				{
					_isCorrect = false;
					TIPE_DescripcionOK  = false;
					TIPE_DescripcionMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPE_Descripcion", "TiposEntidad");
					m_mensajeError += "* Debe ingresar el campo TIPE_Descripcion" + Environment.NewLine;
				}
				TIPE_ActivoOK  = true;
				TIPE_ActivoMSGERROR  = "";
				if( TIPE_Activo == null)
				{
					_isCorrect = false;
					TIPE_ActivoOK  = false;
					TIPE_ActivoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPE_Activo", "TiposEntidad");
					m_mensajeError += "* Debe ingresar el campo TIPE_Activo" + Environment.NewLine;
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
