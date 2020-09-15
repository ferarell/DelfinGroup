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
	public partial class Chequera
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_cheq_codigoOK;
		private String m_cheq_codigoMSGERROR;
		private Boolean m_cuba_codigoOK;
		private String m_cuba_codigoMSGERROR;
		private Boolean m_cheq_nrofinalOK;
		private String m_cheq_nrofinalMSGERROR;
		private Boolean m_cheq_nroinicialOK;
		private String m_cheq_nroinicialMSGERROR;
		private Boolean m_cheq_nroactualOK;
		private String m_cheq_nroactualMSGERROR;
		private Boolean m_cheq_diferidoOK;
		private String m_cheq_diferidoMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
      private Boolean m_cheq_coordenadasOK;
      private String m_cheq_coordenadasMSGERROR;
      private Boolean m_cheq_estadoOK;
      private String m_cheq_estadoMSGERROR;
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
		/// Gets or sets el valor de validación de: CHEQ_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CHEQ_CodigoOK
		{
			get { return m_cheq_codigoOK; }
			set
			{
				if (m_cheq_codigoOK != value)
				{ m_cheq_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CHEQ_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String CHEQ_CodigoMSGERROR
		{
			get { return m_cheq_codigoMSGERROR; }
			set
			{
				if (m_cheq_codigoMSGERROR != value)
				{m_cheq_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CUBA_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CUBA_CodigoOK
		{
			get { return m_cuba_codigoOK; }
			set
			{
				if (m_cuba_codigoOK != value)
				{ m_cuba_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CUBA_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String CUBA_CodigoMSGERROR
		{
			get { return m_cuba_codigoMSGERROR; }
			set
			{
				if (m_cuba_codigoMSGERROR != value)
				{m_cuba_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CHEQ_NroFinal.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CHEQ_NroFinalOK
		{
			get { return m_cheq_nrofinalOK; }
			set
			{
				if (m_cheq_nrofinalOK != value)
				{ m_cheq_nrofinalOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CHEQ_NroFinal.
		/// </summary>
		[IgnoreDataMember]
		public String CHEQ_NroFinalMSGERROR
		{
			get { return m_cheq_nrofinalMSGERROR; }
			set
			{
				if (m_cheq_nrofinalMSGERROR != value)
				{m_cheq_nrofinalMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CHEQ_NroInicial.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CHEQ_NroInicialOK
		{
			get { return m_cheq_nroinicialOK; }
			set
			{
				if (m_cheq_nroinicialOK != value)
				{ m_cheq_nroinicialOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CHEQ_NroInicial.
		/// </summary>
		[IgnoreDataMember]
		public String CHEQ_NroInicialMSGERROR
		{
			get { return m_cheq_nroinicialMSGERROR; }
			set
			{
				if (m_cheq_nroinicialMSGERROR != value)
				{m_cheq_nroinicialMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CHEQ_NroActual.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CHEQ_NroActualOK
		{
			get { return m_cheq_nroactualOK; }
			set
			{
				if (m_cheq_nroactualOK != value)
				{ m_cheq_nroactualOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CHEQ_NroActual.
		/// </summary>
		[IgnoreDataMember]
		public String CHEQ_NroActualMSGERROR
		{
			get { return m_cheq_nroactualMSGERROR; }
			set
			{
				if (m_cheq_nroactualMSGERROR != value)
				{m_cheq_nroactualMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CHEQ_Diferido.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CHEQ_DiferidoOK
		{
			get { return m_cheq_diferidoOK; }
			set
			{
				if (m_cheq_diferidoOK != value)
				{ m_cheq_diferidoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CHEQ_Diferido.
		/// </summary>
		[IgnoreDataMember]
		public String CHEQ_DiferidoMSGERROR
		{
			get { return m_cheq_diferidoMSGERROR; }
			set
			{
				if (m_cheq_diferidoMSGERROR != value)
				{m_cheq_diferidoMSGERROR = value; }
			}
		}
      /// <summary>
      /// Gets or sets el valor de validación de: CHEQ_Coordenadas.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CHEQ_CoordenadasOK
      {
         get { return m_cheq_coordenadasOK; }
         set
         {
            if (m_cheq_coordenadasOK != value)
            { m_cheq_coordenadasOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CHEQ_Coordenadas.
      /// </summary>
      [IgnoreDataMember]
      public String CHEQ_CoordenadasMSGERROR
      {
         get { return m_cheq_coordenadasMSGERROR; }
         set
         {
            if (m_cheq_coordenadasMSGERROR != value)
            { m_cheq_coordenadasMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CHEQ_Estado.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CHEQ_EstadoOK
      {
         get { return m_cheq_estadoOK; }
         set
         {
            if (m_cheq_estadoOK != value)
            { m_cheq_estadoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CHEQ_Estado.
      /// </summary>
      [IgnoreDataMember]
      public String CHEQ_EstadoMSGERROR
      {
         get { return m_cheq_estadoMSGERROR; }
         set
         {
            if (m_cheq_estadoMSGERROR != value)
            { m_cheq_estadoMSGERROR = value; }
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
            //if( EMPR_Codigo == null)
            //{
            //   _isCorrect = false;
            //   EMPR_CodigoOK  = false;
            //   EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "Chequera");
            //   m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
            //}
				CHEQ_CodigoOK  = true;
				CHEQ_CodigoMSGERROR  = "";
				if( CHEQ_Codigo == 0)
				{
					_isCorrect = false;
					CHEQ_CodigoOK  = false;
					CHEQ_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Código de Chequera", "Chequera");
               m_mensajeError += "* Debe ingresar el campo Código de Chequera" + Environment.NewLine;
				}
				CUBA_CodigoOK  = true;
				CUBA_CodigoMSGERROR  = "";
            //if( String.IsNullOrEmpty(CUBA_Codigo) )
            //{
            //   _isCorrect = false;
            //   CUBA_CodigoOK  = false;
            //   CUBA_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Cuenta Bancaria", "Chequera");
            //   m_mensajeError += "* Debe ingresar el campo Cuenta Bancaria" + Environment.NewLine;
            //}
            CHEQ_NroInicialOK = true;
            CHEQ_NroInicialMSGERROR = "";
            if (!CHEQ_NroInicial.HasValue || CHEQ_NroInicial.Value <= 0)
            {
               _isCorrect = false;
               CHEQ_NroInicialOK = false;
               CHEQ_NroInicialMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Número Inicial", "Chequera");
               m_mensajeError += "* Debe ingresar el campo Número Inicial" + Environment.NewLine;
            }
            CHEQ_NroFinalOK  = true;
				CHEQ_NroFinalMSGERROR  = "";
				if(!CHEQ_NroFinal.HasValue || CHEQ_NroFinal.Value <= 0)
				{
					_isCorrect = false;
					CHEQ_NroFinalOK  = false;
					CHEQ_NroFinalMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Número Final", "Chequera");
               m_mensajeError += "* Debe ingresar el campo Número Final" + Environment.NewLine;
				}
				CHEQ_NroActualOK  = true;
				CHEQ_NroActualMSGERROR  = "";
            if (!CHEQ_NroActual.HasValue || CHEQ_NroActual.Value <= 0)
				{
					_isCorrect = false;
					CHEQ_NroActualOK  = false;
					CHEQ_NroActualMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Número Actual", "Chequera");
               m_mensajeError += "* Debe ingresar el campo Número Actual" + Environment.NewLine;
				}
				CHEQ_DiferidoOK  = true;
				CHEQ_DiferidoMSGERROR  = "";
            if (CHEQ_Diferido == null)
            {
               _isCorrect = false;
               CHEQ_DiferidoOK = false;
               CHEQ_DiferidoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de Cheque", "Chequera");
               m_mensajeError += "* Debe ingresar el campo Tipo de Cheque" + Environment.NewLine;
            }
            CHEQ_EstadoOK = true;
            CHEQ_EstadoMSGERROR = "";
            if (String.IsNullOrEmpty(CHEQ_Estado))
            {
               _isCorrect = false;
               CHEQ_EstadoOK = false;
               CHEQ_EstadoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Estado del Cheque", "Chequera");
               m_mensajeError += "* Debe ingresar el campo Estado del Cheque" + Environment.NewLine;
            }

				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
