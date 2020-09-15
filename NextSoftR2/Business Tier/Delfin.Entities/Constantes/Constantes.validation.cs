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
	public partial class Constantes
	{
		#region [ Variables Validación ]
		private Boolean m_cons_codtablaOK;
		private String m_cons_codtablaMSGERROR;
		private Boolean m_cons_codtipoOK;
		private String m_cons_codtipoMSGERROR;
		private Boolean m_cons_desc_spaOK;
		private String m_cons_desc_spaMSGERROR;
		private Boolean m_cons_desc_engOK;
		private String m_cons_desc_engMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodTabla.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodTablaOK
		{
			get { return m_cons_codtablaOK; }
			set
			{
				if (m_cons_codtablaOK != value)
				{
					m_cons_codtablaOK = value;
					OnPropertyChanged("CONS_CodTablaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodTabla.
		/// </summary>
		[DataMember]
		public String CONS_CodTablaMSGERROR
		{
			get { return m_cons_codtablaMSGERROR; }
			set
			{
				if (m_cons_codtablaMSGERROR != value)
				{
					m_cons_codtablaMSGERROR = value;
					OnPropertyChanged("CONS_CodTablaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodTipo.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodTipoOK
		{
			get { return m_cons_codtipoOK; }
			set
			{
				if (m_cons_codtipoOK != value)
				{
					m_cons_codtipoOK = value;
					OnPropertyChanged("CONS_CodTipoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodTipo.
		/// </summary>
		[DataMember]
		public String CONS_CodTipoMSGERROR
		{
			get { return m_cons_codtipoMSGERROR; }
			set
			{
				if (m_cons_codtipoMSGERROR != value)
				{
					m_cons_codtipoMSGERROR = value;
					OnPropertyChanged("CONS_CodTipoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_Desc_SPA.
		/// </summary>
		[DataMember]
		public Boolean CONS_Desc_SPAOK
		{
			get { return m_cons_desc_spaOK; }
			set
			{
				if (m_cons_desc_spaOK != value)
				{
					m_cons_desc_spaOK = value;
					OnPropertyChanged("CONS_Desc_SPAOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_Desc_SPA.
		/// </summary>
		[DataMember]
		public String CONS_Desc_SPAMSGERROR
		{
			get { return m_cons_desc_spaMSGERROR; }
			set
			{
				if (m_cons_desc_spaMSGERROR != value)
				{
					m_cons_desc_spaMSGERROR = value;
					OnPropertyChanged("CONS_Desc_SPAMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_Desc_ENG.
		/// </summary>
		[DataMember]
		public Boolean CONS_Desc_ENGOK
		{
			get { return m_cons_desc_engOK; }
			set
			{
				if (m_cons_desc_engOK != value)
				{
					m_cons_desc_engOK = value;
					OnPropertyChanged("CONS_Desc_ENGOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_Desc_ENG.
		/// </summary>
		[DataMember]
		public String CONS_Desc_ENGMSGERROR
		{
			get { return m_cons_desc_engMSGERROR; }
			set
			{
				if (m_cons_desc_engMSGERROR != value)
				{
					m_cons_desc_engMSGERROR = value;
					OnPropertyChanged("CONS_Desc_ENGMSGERROR");
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
				CONS_CodTablaOK  = true;
				CONS_CodTablaMSGERROR  = "";
				if( String.IsNullOrEmpty(CONS_CodTabla) )
				{
					_isCorrect = false;
					CONS_CodTablaOK  = false;
					CONS_CodTablaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONS_CodTabla", "Constantes");
					m_mensajeError += "* Debe ingresar el campo CONS_CodTabla" + Environment.NewLine;
				}
				CONS_CodTipoOK  = true;
				CONS_CodTipoMSGERROR  = "";
				if( String.IsNullOrEmpty(CONS_CodTipo) )
				{
					_isCorrect = false;
					CONS_CodTipoOK  = false;
					CONS_CodTipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONS_CodTipo", "Constantes");
					m_mensajeError += "* Debe ingresar el campo CONS_CodTipo" + Environment.NewLine;
				}
				CONS_Desc_SPAOK  = true;
				CONS_Desc_SPAMSGERROR  = "";
				if( String.IsNullOrEmpty(CONS_Desc_SPA) )
				{
					_isCorrect = false;
					CONS_Desc_SPAOK  = false;
					CONS_Desc_SPAMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONS_Desc_SPA", "Constantes");
					m_mensajeError += "* Debe ingresar el campo CONS_Desc_SPA" + Environment.NewLine;
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
