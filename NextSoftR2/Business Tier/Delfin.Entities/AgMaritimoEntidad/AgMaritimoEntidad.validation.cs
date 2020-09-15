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
	public partial class AgMaritimoEntidad
	{
		#region [ Variables Validación ]
		private Boolean m_agma_codigoOK;
		private String m_agma_codigoMSGERROR;
		private Boolean m_entc_codpadreOK;
		private String m_entc_codpadreMSGERROR;
		private Boolean m_entc_codhijoOK;
		private String m_entc_codhijoMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: AGMA_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean AGMA_CodigoOK
		{
			get { return m_agma_codigoOK; }
			set
			{
				if (m_agma_codigoOK != value)
				{ m_agma_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: AGMA_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String AGMA_CodigoMSGERROR
		{
			get { return m_agma_codigoMSGERROR; }
			set
			{
				if (m_agma_codigoMSGERROR != value)
				{m_agma_codigoMSGERROR = value; }
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
				AGMA_CodigoOK  = true;
				AGMA_CodigoMSGERROR  = "";
				if( AGMA_Codigo == 0)
				{
					_isCorrect = false;
					AGMA_CodigoOK  = false;
					AGMA_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "AGMA_Codigo", "AgMaritimoEntidad");
					m_mensajeError += "* Debe ingresar el campo AGMA_Codigo" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
