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
    public partial class Cab_Seguimientos
	{
		#region [ Variables Validación ]
		private Boolean m_cseg_codigoOK;
		private String m_cseg_codigoMSGERROR;
		private Boolean m_cseg_hblOK;
		private String m_cseg_hblMSGERROR;
		private Boolean m_cseg_fechaemisionOK;
		private String m_cseg_fechaemisionMSGERROR;
		private Boolean m_cdir_codigoOK;
		private String m_cdir_codigoMSGERROR;
		private Boolean m_cope_codigoOK;
		private String m_cope_codigoMSGERROR;
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
		/// Gets or sets el valor de validación de: CSEG_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CSEG_CodigoOK
		{
			get { return m_cseg_codigoOK; }
			set
			{
				if (m_cseg_codigoOK != value)
				{
					m_cseg_codigoOK = value;
					OnPropertyChanged("CSEG_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CSEG_Codigo.
		/// </summary>
		[DataMember]
		public String CSEG_CodigoMSGERROR
		{
			get { return m_cseg_codigoMSGERROR; }
			set
			{
				if (m_cseg_codigoMSGERROR != value)
				{
					m_cseg_codigoMSGERROR = value;
					OnPropertyChanged("CSEG_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CSEG_HBL.
		/// </summary>
		[DataMember]
		public Boolean CSEG_HBLOK
		{
			get { return m_cseg_hblOK; }
			set
			{
				if (m_cseg_hblOK != value)
				{
					m_cseg_hblOK = value;
					OnPropertyChanged("CSEG_HBLOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CSEG_HBL.
		/// </summary>
		[DataMember]
		public String CSEG_HBLMSGERROR
		{
			get { return m_cseg_hblMSGERROR; }
			set
			{
				if (m_cseg_hblMSGERROR != value)
				{
					m_cseg_hblMSGERROR = value;
					OnPropertyChanged("CSEG_HBLMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CSEG_FechaEmision.
		/// </summary>
		[DataMember]
		public Boolean CSEG_FechaEmisionOK
		{
			get { return m_cseg_fechaemisionOK; }
			set
			{
				if (m_cseg_fechaemisionOK != value)
				{
					m_cseg_fechaemisionOK = value;
					OnPropertyChanged("CSEG_FechaEmisionOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CSEG_FechaEmision.
		/// </summary>
		[DataMember]
		public String CSEG_FechaEmisionMSGERROR
		{
			get { return m_cseg_fechaemisionMSGERROR; }
			set
			{
				if (m_cseg_fechaemisionMSGERROR != value)
				{
					m_cseg_fechaemisionMSGERROR = value;
					OnPropertyChanged("CSEG_FechaEmisionMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CDIR_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CDIR_CodigoOK
		{
			get { return m_cdir_codigoOK; }
			set
			{
				if (m_cdir_codigoOK != value)
				{
					m_cdir_codigoOK = value;
					OnPropertyChanged("CDIR_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CDIR_Codigo.
		/// </summary>
		[DataMember]
		public String CDIR_CodigoMSGERROR
		{
			get { return m_cdir_codigoMSGERROR; }
			set
			{
				if (m_cdir_codigoMSGERROR != value)
				{
					m_cdir_codigoMSGERROR = value;
					OnPropertyChanged("CDIR_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_Codigo.
		/// </summary>
		[DataMember]
		public Boolean COPE_CodigoOK
		{
			get { return m_cope_codigoOK; }
			set
			{
				if (m_cope_codigoOK != value)
				{
					m_cope_codigoOK = value;
					OnPropertyChanged("COPE_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_Codigo.
		/// </summary>
		[DataMember]
		public String COPE_CodigoMSGERROR
		{
			get { return m_cope_codigoMSGERROR; }
			set
			{
				if (m_cope_codigoMSGERROR != value)
				{
					m_cope_codigoMSGERROR = value;
					OnPropertyChanged("COPE_CodigoMSGERROR");
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
				CSEG_CodigoOK  = true;
				CSEG_CodigoMSGERROR  = "";
				
				CSEG_HBLMSGERROR  = "";
				if( String.IsNullOrEmpty(CSEG_HBL) )
				{
					_isCorrect = false;
					CSEG_HBLOK  = false;
					CSEG_HBLMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "HBL", "Seguimiento");
					m_mensajeError += "* Debe ingresar el campo HBL" + Environment.NewLine;
				}
                COPE_CodigoMSGERROR = "";
			    if (COPE_Codigo ==0)
			    {
                    _isCorrect = false;
                    COPE_CodigoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Importar un operativo", "Seguimiento");
                    m_mensajeError += "* Debe ingresar el campo Importar un operativo" + Environment.NewLine; 
			    }
                //if( CSEG_FechaEmision == null)
                //{
                //    _isCorrect = false;
                //    CSEG_FechaEmisionOK  = false;
                //    CSEG_FechaEmisionMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "CSEG_FechaEmision", "Seguimiento");
                //    m_mensajeError += "* Debe ingresar el campo CSEG_FechaEmision" + Environment.NewLine;
                //}
				OnPropertyChanged("MensajeError");
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
