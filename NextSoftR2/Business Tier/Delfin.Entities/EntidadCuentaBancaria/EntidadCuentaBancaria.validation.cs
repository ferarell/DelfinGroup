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
	public partial class EntidadCuentaBancaria
	{
		#region [ Variables Validación ]
		private Boolean m_entc_codigoOK;
		private String m_entc_codigoMSGERROR;
		private Boolean m_tipo_tabbcoOK;
		private String m_tipo_tabbcoMSGERROR;
		private Boolean m_tipo_codbcoOK;
		private String m_tipo_codbcoMSGERROR;
		private Boolean m_encb_tipocuentaOK;
		private String m_encb_tipocuentaMSGERROR;
		private Boolean m_encb_nrocuentasolOK;
		private String m_encb_nrocuentasolMSGERROR;
		private Boolean m_encb_nrocuentadolOK;
		private String m_encb_nrocuentadolMSGERROR;
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
		[IgnoreDataMember]
		public Boolean ENTC_CodigoOK
		{
			get { return m_entc_codigoOK; }
			set
			{
				if (m_entc_codigoOK != value)
				{ m_entc_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String ENTC_CodigoMSGERROR
		{
			get { return m_entc_codigoMSGERROR; }
			set
			{
				if (m_entc_codigoMSGERROR != value)
				{m_entc_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabBCO.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_TabBCOOK
		{
			get { return m_tipo_tabbcoOK; }
			set
			{
				if (m_tipo_tabbcoOK != value)
				{ m_tipo_tabbcoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabBCO.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_TabBCOMSGERROR
		{
			get { return m_tipo_tabbcoMSGERROR; }
			set
			{
				if (m_tipo_tabbcoMSGERROR != value)
				{m_tipo_tabbcoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodBCO.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_CodBCOOK
		{
			get { return m_tipo_codbcoOK; }
			set
			{
				if (m_tipo_codbcoOK != value)
				{ m_tipo_codbcoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodBCO.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_CodBCOMSGERROR
		{
			get { return m_tipo_codbcoMSGERROR; }
			set
			{
				if (m_tipo_codbcoMSGERROR != value)
				{m_tipo_codbcoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENCB_TipoCuenta.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ENCB_TipoCuentaOK
		{
			get { return m_encb_tipocuentaOK; }
			set
			{
				if (m_encb_tipocuentaOK != value)
				{ m_encb_tipocuentaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENCB_TipoCuenta.
		/// </summary>
		[IgnoreDataMember]
		public String ENCB_TipoCuentaMSGERROR
		{
			get { return m_encb_tipocuentaMSGERROR; }
			set
			{
				if (m_encb_tipocuentaMSGERROR != value)
				{m_encb_tipocuentaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENCB_NroCuentaSol.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ENCB_NroCuentaSolOK
		{
			get { return m_encb_nrocuentasolOK; }
			set
			{
				if (m_encb_nrocuentasolOK != value)
				{ m_encb_nrocuentasolOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENCB_NroCuentaSol.
		/// </summary>
		[IgnoreDataMember]
		public String ENCB_NroCuentaSolMSGERROR
		{
			get { return m_encb_nrocuentasolMSGERROR; }
			set
			{
				if (m_encb_nrocuentasolMSGERROR != value)
				{m_encb_nrocuentasolMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENCB_NroCuentaDol.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ENCB_NroCuentaDolOK
		{
			get { return m_encb_nrocuentadolOK; }
			set
			{
				if (m_encb_nrocuentadolOK != value)
				{ m_encb_nrocuentadolOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENCB_NroCuentaDol.
		/// </summary>
		[IgnoreDataMember]
		public String ENCB_NroCuentaDolMSGERROR
		{
			get { return m_encb_nrocuentadolMSGERROR; }
			set
			{
				if (m_encb_nrocuentadolMSGERROR != value)
				{m_encb_nrocuentadolMSGERROR = value; }
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
            //if( ENTC_Codigo == 0)
            //{
            //   _isCorrect = false;
            //   ENTC_CodigoOK  = false;
            //   ENTC_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ENTC_Codigo", "EntidadCuentaBancaria");
            //   m_mensajeError += "* Debe ingresar el campo ENTC_Codigo" + Environment.NewLine;
            //}
				TIPO_TabBCOOK  = true;
				TIPO_TabBCOMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_TabBCO) )
				{
					_isCorrect = false;
					TIPO_TabBCOOK  = false;
               TIPO_TabBCOMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Banco", "Entidad Cuenta Bancaria");
					m_mensajeError += "* Debe ingresar el campo Banco" + Environment.NewLine;
				}
				TIPO_CodBCOOK  = true;
				TIPO_CodBCOMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodBCO) )
				{
					_isCorrect = false;
					TIPO_CodBCOOK  = false;
               TIPO_CodBCOMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Banco", "Entidad Cuenta Bancaria");
               m_mensajeError += "* Debe ingresar el campo Banco" + Environment.NewLine;
				}
				ENCB_TipoCuentaOK  = true;
				ENCB_TipoCuentaMSGERROR  = "";
				if( String.IsNullOrEmpty(ENCB_TipoCuenta) )
				{
					_isCorrect = false;
					ENCB_TipoCuentaOK  = false;
               ENCB_TipoCuentaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "ENCB_TipoCuenta", "Entidad Cuenta Bancaria");
					m_mensajeError += "* Debe ingresar el campo ENCB_TipoCuenta" + Environment.NewLine;
				}

            ENCB_NroCuentaSolOK = true;
            ENCB_NroCuentaDolOK = true;
            ENCB_NroCuentaSolMSGERROR = "";
            ENCB_NroCuentaDolMSGERROR = "";
            if (String.IsNullOrEmpty(ENCB_NroCuentaSol) && String.IsNullOrEmpty(ENCB_NroCuentaDol))
            {
               if (String.IsNullOrEmpty(ENCB_NroCuentaSol))
               {
                  _isCorrect = false;
                  ENCB_NroCuentaSolOK = false;
                  ENCB_NroCuentaSolMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Cuenta S/.",
                     "Entidad Cuenta Bancaria");
                  m_mensajeError += "* Debe ingresar el campo Cuenta S/." + Environment.NewLine;
               }
               if (String.IsNullOrEmpty(ENCB_NroCuentaSol))
               {
                  _isCorrect = false;
                  ENCB_NroCuentaDolOK = false;
                  ENCB_NroCuentaDolMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Cuenta US$.",
                     "Entidad Cuenta Bancaria");
                  m_mensajeError += "* Debe ingresar el campo Cuenta US$." + Environment.NewLine;
               }
            }

				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
