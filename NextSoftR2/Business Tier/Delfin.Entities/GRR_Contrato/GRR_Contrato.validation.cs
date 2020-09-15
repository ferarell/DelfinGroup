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
	public partial class GRR_Contrato
	{
		#region [ Variables Validación ]
		private Boolean m_reba_tipoOK;
		private String m_reba_tipoMSGERROR;
		private Boolean m_reba_codigoOK;
		private String m_reba_codigoMSGERROR;
		private Boolean m_CONT_NumeroOK;
		private String m_CONT_NumeroMSGERROR;
      private Boolean m_CONT_NumeroEquivalenteOK;
      private String m_CONT_NumeroEquivalenteMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: REBA_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean REBA_TipoOK
		{
			get { return m_reba_tipoOK; }
			set
			{
				if (m_reba_tipoOK != value)
				{ m_reba_tipoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: REBA_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public String REBA_TipoMSGERROR
		{
			get { return m_reba_tipoMSGERROR; }
			set
			{
				if (m_reba_tipoMSGERROR != value)
				{m_reba_tipoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: REBA_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean REBA_CodigoOK
		{
			get { return m_reba_codigoOK; }
			set
			{
				if (m_reba_codigoOK != value)
				{ m_reba_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: REBA_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String REBA_CodigoMSGERROR
		{
			get { return m_reba_codigoMSGERROR; }
			set
			{
				if (m_reba_codigoMSGERROR != value)
				{m_reba_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONT_Numero.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CONT_NumeroOK
		{
			get { return m_CONT_NumeroOK; }
			set
			{
				if (m_CONT_NumeroOK != value)
				{ m_CONT_NumeroOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONT_Numero.
		/// </summary>
		[IgnoreDataMember]
		public String CONT_NumeroMSGERROR
		{
			get { return m_CONT_NumeroMSGERROR; }
			set
			{
				if (m_CONT_NumeroMSGERROR != value)
				{m_CONT_NumeroMSGERROR = value; }
			}
		}
      /// <summary>
      /// Gets or sets el valor de validación de: CONT_NumeroEquivalente.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CONT_NumeroEquivalenteOK
      {
         get { return m_CONT_NumeroEquivalenteOK; }
         set
         {
            if (m_CONT_NumeroEquivalenteOK != value)
            { m_CONT_NumeroEquivalenteOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CONT_NumeroEquivalente.
      /// </summary>
      [IgnoreDataMember]
      public String CONT_NumeroEquivalenteMSGERROR
      {
         get { return m_CONT_NumeroEquivalenteMSGERROR; }
         set
         {
            if (m_CONT_NumeroEquivalenteMSGERROR != value)
            { m_CONT_NumeroEquivalenteMSGERROR = value; }
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
				REBA_TipoOK  = true;
				REBA_TipoMSGERROR  = "";
				if( String.IsNullOrEmpty(REBA_Tipo) )
				{
					_isCorrect = false;
					REBA_TipoOK  = false;
					REBA_TipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "REBA_Tipo", "GRR_Contrato");
					m_mensajeError += "* Debe ingresar el campo REBA_Tipo" + Environment.NewLine;
				}
				REBA_CodigoOK  = true;
				REBA_CodigoMSGERROR  = "";
				if( REBA_Codigo == 0)
				{
					_isCorrect = false;
					REBA_CodigoOK  = false;
					REBA_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "REBA_Codigo", "GRR_Contrato");
					m_mensajeError += "* Debe ingresar el campo REBA_Codigo" + Environment.NewLine;
				}
				CONT_NumeroOK  = true;
				CONT_NumeroMSGERROR  = "";
				if(String.IsNullOrEmpty(CONT_Numero))
				{
					_isCorrect = false;
					CONT_NumeroOK  = false;
					CONT_NumeroMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONT_Numero", "GRR_Contrato");
					m_mensajeError += "* Debe ingresar el campo CONT_Numero" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
