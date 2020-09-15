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
	public partial class DepVacioEntidad
	{
		#region [ Variables Validación ]
		private Boolean m_deva_codigoOK;
		private String m_deva_codigoMSGERROR;
		private Boolean m_entc_codpadreOK;
		private String m_entc_codpadreMSGERROR;
		private Boolean m_entc_codhijoOK;
		private String m_entc_codhijoMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: DEVA_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DEVA_CodigoOK
		{
			get { return m_deva_codigoOK; }
			set
			{
				if (m_deva_codigoOK != value)
				{ m_deva_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DEVA_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String DEVA_CodigoMSGERROR
		{
			get { return m_deva_codigoMSGERROR; }
			set
			{
				if (m_deva_codigoMSGERROR != value)
				{m_deva_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodPadre.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ENTC_CodPadreOK
		{
			get { return m_entc_codpadreOK; }
			set
			{
				if (m_entc_codpadreOK != value)
				{ m_entc_codpadreOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodPadre.
		/// </summary>
		[IgnoreDataMember]
		public String ENTC_CodPadreMSGERROR
		{
			get { return m_entc_codpadreMSGERROR; }
			set
			{
				if (m_entc_codpadreMSGERROR != value)
				{m_entc_codpadreMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodHijo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ENTC_CodHijoOK
		{
			get { return m_entc_codhijoOK; }
			set
			{
				if (m_entc_codhijoOK != value)
				{ m_entc_codhijoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodHijo.
		/// </summary>
		[IgnoreDataMember]
		public String ENTC_CodHijoMSGERROR
		{
			get { return m_entc_codhijoMSGERROR; }
			set
			{
				if (m_entc_codhijoMSGERROR != value)
				{m_entc_codhijoMSGERROR = value; }
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
				DEVA_CodigoOK  = true;
				DEVA_CodigoMSGERROR  = "";
				if( DEVA_Codigo == 0)
				{
					_isCorrect = false;
					DEVA_CodigoOK  = false;
					DEVA_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DEVA_Codigo", "DepVacioEntidad");
					m_mensajeError += "* Debe ingresar el campo DEVA_Codigo" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
