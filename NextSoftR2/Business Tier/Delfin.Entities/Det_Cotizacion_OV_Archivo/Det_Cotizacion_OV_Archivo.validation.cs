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
	public partial class Det_Cotizacion_OV_Archivo
	{
		#region [ Variables Validación ]
		private Boolean m_ovar_codigoOK;
		private String m_ovar_codigoMSGERROR;
		private Boolean m_ccot_numeroOK;
		private String m_ccot_numeroMSGERROR;
		private Boolean m_ccot_tipoOK;
		private String m_ccot_tipoMSGERROR;
		private Boolean m_ovar_descripOK;
		private String m_ovar_descripMSGERROR;
		private Boolean m_ovar_fecemiOK;
		private String m_ovar_fecemiMSGERROR;
		private Boolean m_ovar_archivoOK;
		private String m_ovar_archivoMSGERROR;
      private Boolean m_ovar_observacionOK;
      private String m_ovar_observacionMSGERROR;
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
		/// Gets or sets el valor de validación de: OVAR_Codigo.
		/// </summary>
		[DataMember]
		public Boolean OVAR_CodigoOK
		{
			get { return m_ovar_codigoOK; }
			set
			{
				if (m_ovar_codigoOK != value)
				{
					m_ovar_codigoOK = value;
					OnPropertyChanged("OVAR_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: OVAR_Codigo.
		/// </summary>
		[DataMember]
		public String OVAR_CodigoMSGERROR
		{
			get { return m_ovar_codigoMSGERROR; }
			set
			{
				if (m_ovar_codigoMSGERROR != value)
				{
					m_ovar_codigoMSGERROR = value;
					OnPropertyChanged("OVAR_CodigoMSGERROR");
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
		/// Gets or sets el valor de validación de: OVAR_Descrip.
		/// </summary>
		[DataMember]
		public Boolean OVAR_DescripOK
		{
			get { return m_ovar_descripOK; }
			set
			{
				if (m_ovar_descripOK != value)
				{
					m_ovar_descripOK = value;
					OnPropertyChanged("OVAR_DescripOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: OVAR_Descrip.
		/// </summary>
		[DataMember]
		public String OVAR_DescripMSGERROR
		{
			get { return m_ovar_descripMSGERROR; }
			set
			{
				if (m_ovar_descripMSGERROR != value)
				{
					m_ovar_descripMSGERROR = value;
					OnPropertyChanged("OVAR_DescripMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: OVAR_FecEmi.
		/// </summary>
		[DataMember]
		public Boolean OVAR_FecEmiOK
		{
			get { return m_ovar_fecemiOK; }
			set
			{
				if (m_ovar_fecemiOK != value)
				{
					m_ovar_fecemiOK = value;
					OnPropertyChanged("OVAR_FecEmiOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: OVAR_FecEmi.
		/// </summary>
		[DataMember]
		public String OVAR_FecEmiMSGERROR
		{
			get { return m_ovar_fecemiMSGERROR; }
			set
			{
				if (m_ovar_fecemiMSGERROR != value)
				{
					m_ovar_fecemiMSGERROR = value;
					OnPropertyChanged("OVAR_FecEmiMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: OVAR_Archivo.
		/// </summary>
		[DataMember]
		public Boolean OVAR_ArchivoOK
		{
			get { return m_ovar_archivoOK; }
			set
			{
				if (m_ovar_archivoOK != value)
				{
					m_ovar_archivoOK = value;
					OnPropertyChanged("OVAR_ArchivoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: OVAR_Archivo.
		/// </summary>
		[DataMember]
		public String OVAR_ArchivoMSGERROR
		{
			get { return m_ovar_archivoMSGERROR; }
			set
			{
				if (m_ovar_archivoMSGERROR != value)
				{
					m_ovar_archivoMSGERROR = value;
					OnPropertyChanged("OVAR_ArchivoMSGERROR");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de validación de: OVAR_Observacion.
      /// </summary>
      [DataMember]
      public Boolean OVAR_ObservacionOK
      {
         get { return m_ovar_observacionOK; }
         set
         {
            if (m_ovar_observacionOK != value)
            {
               m_ovar_observacionOK = value;
               OnPropertyChanged("OVAR_ObservacionOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: OVAR_Observacion.
      /// </summary>
      [DataMember]
      public String OVAR_ObservacionMSGERROR
      {
         get { return m_ovar_observacionMSGERROR; }
         set
         {
            if (m_ovar_observacionMSGERROR != value)
            {
               m_ovar_observacionMSGERROR = value;
               OnPropertyChanged("OVAR_ObservacionMSGERROR");
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
				OVAR_CodigoOK  = true;
				OVAR_CodigoMSGERROR  = "";
				if( OVAR_Codigo == null)
				{
					_isCorrect = false;
					OVAR_CodigoOK  = false;
					OVAR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "OVAR_Codigo", "Det_Cotizacion_OV_Archivo");
					m_mensajeError += "* Debe ingresar el campo OVAR_Codigo" + Environment.NewLine;
				}
				CCOT_NumeroOK  = true;
				CCOT_NumeroMSGERROR  = "";
				if( CCOT_Numero == null)
				{
					_isCorrect = false;
					CCOT_NumeroOK  = false;
					CCOT_NumeroMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Numero", "Det_Cotizacion_OV_Archivo");
					m_mensajeError += "* Debe ingresar el campo CCOT_Numero" + Environment.NewLine;
				}
				CCOT_TipoOK  = true;
				CCOT_TipoMSGERROR  = "";
				if( CCOT_Tipo == null)
				{
					_isCorrect = false;
					CCOT_TipoOK  = false;
					CCOT_TipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Tipo", "Det_Cotizacion_OV_Archivo");
					m_mensajeError += "* Debe ingresar el campo CCOT_Tipo" + Environment.NewLine;
				}
				OVAR_DescripOK  = true;
				OVAR_DescripMSGERROR  = "";
				if( String.IsNullOrEmpty(OVAR_Descrip) )
				{
					_isCorrect = false;
					OVAR_DescripOK  = false;
					OVAR_DescripMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "OVAR_Descrip", "Det_Cotizacion_OV_Archivo");
					m_mensajeError += "* Debe ingresar el campo OVAR_Descrip" + Environment.NewLine;
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
