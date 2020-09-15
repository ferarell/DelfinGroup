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
	public partial class Conciliacion
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_movi_codigoOK;
		private String m_movi_codigoMSGERROR;
		private Boolean m_conc_codigoOK;
		private String m_conc_codigoMSGERROR;
		private Boolean m_conc_periodoOK;
		private String m_conc_periodoMSGERROR;
		private Boolean m_conc_montobcoOK;
		private String m_conc_montobcoMSGERROR;
		private Boolean m_conc_fecconciliacionOK;
		private String m_conc_fecconciliacionMSGERROR;
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
		/// Gets or sets el valor de validación de: EMPR_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean EMPR_CodigoOK
		{
			get { return m_empr_codigoOK; }
			set
			{
				if (m_empr_codigoOK != value)
				{ m_empr_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EMPR_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String EMPR_CodigoMSGERROR
		{
			get { return m_empr_codigoMSGERROR; }
			set
			{
				if (m_empr_codigoMSGERROR != value)
				{m_empr_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: MOVI_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean MOVI_CodigoOK
		{
			get { return m_movi_codigoOK; }
			set
			{
				if (m_movi_codigoOK != value)
				{ m_movi_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: MOVI_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String MOVI_CodigoMSGERROR
		{
			get { return m_movi_codigoMSGERROR; }
			set
			{
				if (m_movi_codigoMSGERROR != value)
				{m_movi_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONC_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CONC_CodigoOK
		{
			get { return m_conc_codigoOK; }
			set
			{
				if (m_conc_codigoOK != value)
				{ m_conc_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONC_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String CONC_CodigoMSGERROR
		{
			get { return m_conc_codigoMSGERROR; }
			set
			{
				if (m_conc_codigoMSGERROR != value)
				{m_conc_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONC_Periodo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CONC_PeriodoOK
		{
			get { return m_conc_periodoOK; }
			set
			{
				if (m_conc_periodoOK != value)
				{ m_conc_periodoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONC_Periodo.
		/// </summary>
		[IgnoreDataMember]
		public String CONC_PeriodoMSGERROR
		{
			get { return m_conc_periodoMSGERROR; }
			set
			{
				if (m_conc_periodoMSGERROR != value)
				{m_conc_periodoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONC_MontoBCO.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CONC_MontoBCOOK
		{
			get { return m_conc_montobcoOK; }
			set
			{
				if (m_conc_montobcoOK != value)
				{ m_conc_montobcoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONC_MontoBCO.
		/// </summary>
		[IgnoreDataMember]
		public String CONC_MontoBCOMSGERROR
		{
			get { return m_conc_montobcoMSGERROR; }
			set
			{
				if (m_conc_montobcoMSGERROR != value)
				{m_conc_montobcoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONC_FecConciliacion.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CONC_FecConciliacionOK
		{
			get { return m_conc_fecconciliacionOK; }
			set
			{
				if (m_conc_fecconciliacionOK != value)
				{ m_conc_fecconciliacionOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONC_FecConciliacion.
		/// </summary>
		[IgnoreDataMember]
		public String CONC_FecConciliacionMSGERROR
		{
			get { return m_conc_fecconciliacionMSGERROR; }
			set
			{
				if (m_conc_fecconciliacionMSGERROR != value)
				{m_conc_fecconciliacionMSGERROR = value; }
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
				EMPR_CodigoOK  = true;
				EMPR_CodigoMSGERROR  = "";
				if( EMPR_Codigo == null)
				{
					_isCorrect = false;
					EMPR_CodigoOK  = false;
					EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "Conciliacion");
					m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
				}
				MOVI_CodigoOK  = true;
				MOVI_CodigoMSGERROR  = "";
				if( MOVI_Codigo == 0)
				{
					_isCorrect = false;
					MOVI_CodigoOK  = false;
					MOVI_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "MOVI_Codigo", "Conciliacion");
					m_mensajeError += "* Debe ingresar el campo MOVI_Codigo" + Environment.NewLine;
				}
				CONC_CodigoOK  = true;
				CONC_CodigoMSGERROR  = "";
				if( CONC_Codigo == 0)
				{
					_isCorrect = false;
					CONC_CodigoOK  = false;
					CONC_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONC_Codigo", "Conciliacion");
					m_mensajeError += "* Debe ingresar el campo CONC_Codigo" + Environment.NewLine;
				}
				CONC_PeriodoOK  = true;
				CONC_PeriodoMSGERROR  = "";
				if( String.IsNullOrEmpty(CONC_Periodo) )
				{
					_isCorrect = false;
					CONC_PeriodoOK  = false;
					CONC_PeriodoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONC_Periodo", "Conciliacion");
					m_mensajeError += "* Debe ingresar el campo CONC_Periodo" + Environment.NewLine;
				}
				CONC_MontoBCOOK  = true;
				CONC_MontoBCOMSGERROR  = "";
				if( CONC_MontoBCO == 0)
				{
					_isCorrect = false;
					CONC_MontoBCOOK  = false;
					CONC_MontoBCOMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONC_MontoBCO", "Conciliacion");
					m_mensajeError += "* Debe ingresar el campo CONC_MontoBCO" + Environment.NewLine;
				}
				CONC_FecConciliacionOK  = true;
				CONC_FecConciliacionMSGERROR  = "";
				if( CONC_FecConciliacion == null)
				{
					_isCorrect = false;
					CONC_FecConciliacionOK  = false;
					CONC_FecConciliacionMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONC_FecConciliacion", "Conciliacion");
					m_mensajeError += "* Debe ingresar el campo CONC_FecConciliacion" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
