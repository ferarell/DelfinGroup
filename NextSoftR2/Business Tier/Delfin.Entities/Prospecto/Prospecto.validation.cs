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
	public partial class Prospecto
	{
		#region [ Variables Validación ]
		private Boolean m_pros_codigoOK;
		private String m_pros_codigoMSGERROR;
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_sucr_codigoOK;
		private String m_sucr_codigoMSGERROR;
		private Boolean m_entc_codclienteOK;
		private String m_entc_codclienteMSGERROR;
		private Boolean m_entc_codejecutivoOK;
		private String m_entc_codejecutivoMSGERROR;
		private Boolean m_entc_codcustomerOK;
		private String m_entc_codcustomerMSGERROR;
		private Boolean m_entc_codagentecargaOK;
		private String m_entc_codagentecargaMSGERROR;
		private Boolean m_pros_fecasignacionOK;
		private String m_pros_fecasignacionMSGERROR;
		private Boolean m_tipo_tabcdtOK;
		private String m_tipo_tabcdtMSGERROR;
		private Boolean m_tipo_codcdtOK;
		private String m_tipo_codcdtMSGERROR;
		private Boolean m_pros_activoOK;
		private String m_pros_activoMSGERROR;
		private Boolean m_conc_tabrgmOK;
		private String m_conc_tabrgmMSGERROR;
		private Boolean m_cons_codrgmOK;
		private String m_cons_codrgmMSGERROR;
		private Boolean m_pros_teusOK;
		private String m_pros_teusMSGERROR;
		private Boolean m_pros_porcentajeOK;
		private String m_pros_porcentajeMSGERROR;
		private Boolean m_pros_cntr20OK;
		private String m_pros_cntr20MSGERROR;
		private Boolean m_pros_cntr40OK;
		private String m_pros_cntr40MSGERROR;
      //private Boolean m_audi_usrcreaOK;
      //private String m_audi_usrcreaMSGERROR;
      //private Boolean m_audi_feccreaOK;
      //private String m_audi_feccreaMSGERROR;
      //private Boolean m_audi_usrmodOK;
      //private String m_audi_usrmodMSGERROR;
      //private Boolean m_audi_fecmodOK;
      //private String m_audi_fecmodMSGERROR;

      private Boolean m_entc_nomcompletoclienteok;
      private String m_entc_nomcompletoclientemsgerror;

		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: PROS_codigo.
		/// </summary>
		[DataMember]
		public Boolean PROS_codigoOK
		{
			get { return m_pros_codigoOK; }
			set
			{
				if (m_pros_codigoOK != value)
				{
					m_pros_codigoOK = value;
					OnPropertyChanged("PROS_codigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PROS_codigo.
		/// </summary>
		[DataMember]
		public String PROS_codigoMSGERROR
		{
			get { return m_pros_codigoMSGERROR; }
			set
			{
				if (m_pros_codigoMSGERROR != value)
				{
					m_pros_codigoMSGERROR = value;
					OnPropertyChanged("PROS_codigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EMPR_Codigo.
		/// </summary>
		[DataMember]
		public Boolean EMPR_CodigoOK
		{
			get { return m_empr_codigoOK; }
			set
			{
				if (m_empr_codigoOK != value)
				{
					m_empr_codigoOK = value;
					OnPropertyChanged("EMPR_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EMPR_Codigo.
		/// </summary>
		[DataMember]
		public String EMPR_CodigoMSGERROR
		{
			get { return m_empr_codigoMSGERROR; }
			set
			{
				if (m_empr_codigoMSGERROR != value)
				{
					m_empr_codigoMSGERROR = value;
					OnPropertyChanged("EMPR_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SUCR_Codigo.
		/// </summary>
		[DataMember]
		public Boolean SUCR_CodigoOK
		{
			get { return m_sucr_codigoOK; }
			set
			{
				if (m_sucr_codigoOK != value)
				{
					m_sucr_codigoOK = value;
					OnPropertyChanged("SUCR_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SUCR_Codigo.
		/// </summary>
		[DataMember]
		public String SUCR_CodigoMSGERROR
		{
			get { return m_sucr_codigoMSGERROR; }
			set
			{
				if (m_sucr_codigoMSGERROR != value)
				{
					m_sucr_codigoMSGERROR = value;
					OnPropertyChanged("SUCR_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodCliente.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodClienteOK
		{
			get { return m_entc_codclienteOK; }
			set
			{
				if (m_entc_codclienteOK != value)
				{
					m_entc_codclienteOK = value;
					OnPropertyChanged("ENTC_CodClienteOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodCliente.
		/// </summary>
		[DataMember]
		public String ENTC_CodClienteMSGERROR
		{
			get { return m_entc_codclienteMSGERROR; }
			set
			{
				if (m_entc_codclienteMSGERROR != value)
				{
					m_entc_codclienteMSGERROR = value;
					OnPropertyChanged("ENTC_CodClienteMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodEjecutivo.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodEjecutivoOK
		{
			get { return m_entc_codejecutivoOK; }
			set
			{
				if (m_entc_codejecutivoOK != value)
				{
					m_entc_codejecutivoOK = value;
					OnPropertyChanged("ENTC_CodEjecutivoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodEjecutivo.
		/// </summary>
		[DataMember]
		public String ENTC_CodEjecutivoMSGERROR
		{
			get { return m_entc_codejecutivoMSGERROR; }
			set
			{
				if (m_entc_codejecutivoMSGERROR != value)
				{
					m_entc_codejecutivoMSGERROR = value;
					OnPropertyChanged("ENTC_CodEjecutivoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodCustomer.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodCustomerOK
		{
			get { return m_entc_codcustomerOK; }
			set
			{
				if (m_entc_codcustomerOK != value)
				{
					m_entc_codcustomerOK = value;
					OnPropertyChanged("ENTC_CodCustomerOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodCustomer.
		/// </summary>
		[DataMember]
		public String ENTC_CodCustomerMSGERROR
		{
			get { return m_entc_codcustomerMSGERROR; }
			set
			{
				if (m_entc_codcustomerMSGERROR != value)
				{
					m_entc_codcustomerMSGERROR = value;
					OnPropertyChanged("ENTC_CodCustomerMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodAgenteCarga.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodAgenteCargaOK
		{
			get { return m_entc_codagentecargaOK; }
			set
			{
				if (m_entc_codagentecargaOK != value)
				{
					m_entc_codagentecargaOK = value;
					OnPropertyChanged("ENTC_CodAgenteCargaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodAgenteCarga.
		/// </summary>
		[DataMember]
		public String ENTC_CodAgenteCargaMSGERROR
		{
			get { return m_entc_codagentecargaMSGERROR; }
			set
			{
				if (m_entc_codagentecargaMSGERROR != value)
				{
					m_entc_codagentecargaMSGERROR = value;
					OnPropertyChanged("ENTC_CodAgenteCargaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PROS_FecAsignacion.
		/// </summary>
		[DataMember]
		public Boolean PROS_FecAsignacionOK
		{
			get { return m_pros_fecasignacionOK; }
			set
			{
				if (m_pros_fecasignacionOK != value)
				{
					m_pros_fecasignacionOK = value;
					OnPropertyChanged("PROS_FecAsignacionOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PROS_FecAsignacion.
		/// </summary>
		[DataMember]
		public String PROS_FecAsignacionMSGERROR
		{
			get { return m_pros_fecasignacionMSGERROR; }
			set
			{
				if (m_pros_fecasignacionMSGERROR != value)
				{
					m_pros_fecasignacionMSGERROR = value;
					OnPropertyChanged("PROS_FecAsignacionMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabCDT.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabCDTOK
		{
			get { return m_tipo_tabcdtOK; }
			set
			{
				if (m_tipo_tabcdtOK != value)
				{
					m_tipo_tabcdtOK = value;
					OnPropertyChanged("TIPO_TabCDTOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabCDT.
		/// </summary>
		[DataMember]
		public String TIPO_TabCDTMSGERROR
		{
			get { return m_tipo_tabcdtMSGERROR; }
			set
			{
				if (m_tipo_tabcdtMSGERROR != value)
				{
					m_tipo_tabcdtMSGERROR = value;
					OnPropertyChanged("TIPO_TabCDTMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodCDT.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodCDTOK
		{
			get { return m_tipo_codcdtOK; }
			set
			{
				if (m_tipo_codcdtOK != value)
				{
					m_tipo_codcdtOK = value;
					OnPropertyChanged("TIPO_CodCDTOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodCDT.
		/// </summary>
		[DataMember]
		public String TIPO_CodCDTMSGERROR
		{
			get { return m_tipo_codcdtMSGERROR; }
			set
			{
				if (m_tipo_codcdtMSGERROR != value)
				{
					m_tipo_codcdtMSGERROR = value;
					OnPropertyChanged("TIPO_CodCDTMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PROS_Activo.
		/// </summary>
		[DataMember]
		public Boolean PROS_ActivoOK
		{
			get { return m_pros_activoOK; }
			set
			{
				if (m_pros_activoOK != value)
				{
					m_pros_activoOK = value;
					OnPropertyChanged("PROS_ActivoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PROS_Activo.
		/// </summary>
		[DataMember]
		public String PROS_ActivoMSGERROR
		{
			get { return m_pros_activoMSGERROR; }
			set
			{
				if (m_pros_activoMSGERROR != value)
				{
					m_pros_activoMSGERROR = value;
					OnPropertyChanged("PROS_ActivoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONC_TabRGM.
		/// </summary>
		[DataMember]
		public Boolean CONC_TabRGMOK
		{
			get { return m_conc_tabrgmOK; }
			set
			{
				if (m_conc_tabrgmOK != value)
				{
					m_conc_tabrgmOK = value;
					OnPropertyChanged("CONC_TabRGMOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONC_TabRGM.
		/// </summary>
		[DataMember]
		public String CONC_TabRGMMSGERROR
		{
			get { return m_conc_tabrgmMSGERROR; }
			set
			{
				if (m_conc_tabrgmMSGERROR != value)
				{
					m_conc_tabrgmMSGERROR = value;
					OnPropertyChanged("CONC_TabRGMMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodRGM.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodRGMOK
		{
			get { return m_cons_codrgmOK; }
			set
			{
				if (m_cons_codrgmOK != value)
				{
					m_cons_codrgmOK = value;
					OnPropertyChanged("CONS_CodRGMOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodRGM.
		/// </summary>
		[DataMember]
		public String CONS_CodRGMMSGERROR
		{
			get { return m_cons_codrgmMSGERROR; }
			set
			{
				if (m_cons_codrgmMSGERROR != value)
				{
					m_cons_codrgmMSGERROR = value;
					OnPropertyChanged("CONS_CodRGMMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PROS_TEUS.
		/// </summary>
		[DataMember]
		public Boolean PROS_TEUSOK
		{
			get { return m_pros_teusOK; }
			set
			{
				if (m_pros_teusOK != value)
				{
					m_pros_teusOK = value;
					OnPropertyChanged("PROS_TEUSOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PROS_TEUS.
		/// </summary>
		[DataMember]
		public String PROS_TEUSMSGERROR
		{
			get { return m_pros_teusMSGERROR; }
			set
			{
				if (m_pros_teusMSGERROR != value)
				{
					m_pros_teusMSGERROR = value;
					OnPropertyChanged("PROS_TEUSMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PROS_Porcentaje.
		/// </summary>
		[DataMember]
		public Boolean PROS_PorcentajeOK
		{
			get { return m_pros_porcentajeOK; }
			set
			{
				if (m_pros_porcentajeOK != value)
				{
					m_pros_porcentajeOK = value;
					OnPropertyChanged("PROS_PorcentajeOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PROS_Porcentaje.
		/// </summary>
		[DataMember]
		public String PROS_PorcentajeMSGERROR
		{
			get { return m_pros_porcentajeMSGERROR; }
			set
			{
				if (m_pros_porcentajeMSGERROR != value)
				{
					m_pros_porcentajeMSGERROR = value;
					OnPropertyChanged("PROS_PorcentajeMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PROS_CNTR20.
		/// </summary>
		[DataMember]
		public Boolean PROS_CNTR20OK
		{
			get { return m_pros_cntr20OK; }
			set
			{
				if (m_pros_cntr20OK != value)
				{
					m_pros_cntr20OK = value;
					OnPropertyChanged("PROS_CNTR20OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PROS_CNTR20.
		/// </summary>
		[DataMember]
		public String PROS_CNTR20MSGERROR
		{
			get { return m_pros_cntr20MSGERROR; }
			set
			{
				if (m_pros_cntr20MSGERROR != value)
				{
					m_pros_cntr20MSGERROR = value;
					OnPropertyChanged("PROS_CNTR20MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PROS_CNTR40.
		/// </summary>
		[DataMember]
		public Boolean PROS_CNTR40OK
		{
			get { return m_pros_cntr40OK; }
			set
			{
				if (m_pros_cntr40OK != value)
				{
					m_pros_cntr40OK = value;
					OnPropertyChanged("PROS_CNTR40OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PROS_CNTR40.
		/// </summary>
		[DataMember]
		public String PROS_CNTR40MSGERROR
		{
			get { return m_pros_cntr40MSGERROR; }
			set
			{
				if (m_pros_cntr40MSGERROR != value)
				{
					m_pros_cntr40MSGERROR = value;
					OnPropertyChanged("PROS_CNTR40MSGERROR");
				}
			}
		}


      /// <summary>
      /// Gets or sets el valor de validación de: ENTC_NomCompletoCliente.
      /// </summary>
      [DataMember]
      public Boolean ENTC_NomCompletoClienteOK
      {
         get { return m_entc_nomcompletoclienteok; }
         set
         {
            if (m_entc_nomcompletoclienteok != value)
            {
               m_entc_nomcompletoclienteok = value;
               OnPropertyChanged("ENTC_NomCompletoClienteOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENTC_NomCompletoCliente.
      /// </summary>
      [DataMember]
      public String ENTC_NomCompletoClienteMSGERROR
      {
         get { return m_entc_nomcompletoclientemsgerror; }
         set
         {
            if (m_entc_nomcompletoclientemsgerror != value)
            {
               m_entc_nomcompletoclientemsgerror = value;
               OnPropertyChanged("ENTC_NomCompletoClienteMSGERROR");
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
				PROS_codigoOK  = true;
				PROS_codigoMSGERROR  = "";
				if( PROS_codigo == null)
				{
					_isCorrect = false;
					PROS_codigoOK  = false;
					PROS_codigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PROS_codigo", "Prospecto");
					m_mensajeError += "* Debe ingresar el campo PROS_codigo" + Environment.NewLine;
				}
				EMPR_CodigoOK  = true;
				EMPR_CodigoMSGERROR  = "";
				if( EMPR_Codigo == null)
				{
					_isCorrect = false;
					EMPR_CodigoOK  = false;
					EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "Prospecto");
					m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
				}
				SUCR_CodigoOK  = true;
				SUCR_CodigoMSGERROR  = "";
				if( SUCR_Codigo == null)
				{
					_isCorrect = false;
					SUCR_CodigoOK  = false;
					SUCR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SUCR_Codigo", "Prospecto");
					m_mensajeError += "* Debe ingresar el campo SUCR_Codigo" + Environment.NewLine;
				}
				ENTC_CodClienteOK  = true;
				ENTC_CodClienteMSGERROR  = "";
				if( ENTC_CodCliente == null)
				{
					_isCorrect = false;
					ENTC_CodClienteOK  = false;
					ENTC_CodClienteMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ENTC_CodCliente", "Prospecto");
					m_mensajeError += "* Debe ingresar el campo ENTC_CodCliente" + Environment.NewLine;
				}
				ENTC_CodEjecutivoOK  = true;
				ENTC_CodEjecutivoMSGERROR  = "";
				if( ENTC_CodEjecutivo == null)
				{
					_isCorrect = false;
					ENTC_CodEjecutivoOK  = false;
					ENTC_CodEjecutivoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ENTC_CodEjecutivo", "Prospecto");
					m_mensajeError += "* Debe ingresar el campo ENTC_CodEjecutivo" + Environment.NewLine;
				}
				PROS_FecAsignacionOK  = true;
				PROS_FecAsignacionMSGERROR  = "";
				if( PROS_FecAsignacion == null)
				{
					_isCorrect = false;
					PROS_FecAsignacionOK  = false;
					PROS_FecAsignacionMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PROS_FecAsignacion", "Prospecto");
					m_mensajeError += "* Debe ingresar el campo PROS_FecAsignacion" + Environment.NewLine;
				}
				PROS_ActivoOK  = true;
				PROS_ActivoMSGERROR  = "";
				if( PROS_Activo == null)
				{
					_isCorrect = false;
					PROS_ActivoOK  = false;
					PROS_ActivoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PROS_Activo", "Prospecto");
					m_mensajeError += "* Debe ingresar el campo PROS_Activo" + Environment.NewLine;
				}
				CONC_TabRGMOK  = true;
				CONC_TabRGMMSGERROR  = "";
				if( String.IsNullOrEmpty(CONS_TabRGM) )
				{
					_isCorrect = false;
					CONC_TabRGMOK  = false;
					CONC_TabRGMMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONC_TabRGM", "Prospecto");
					m_mensajeError += "* Debe ingresar el campo CONC_TabRGM" + Environment.NewLine;
				}
				CONS_CodRGMOK  = true;
				CONS_CodRGMMSGERROR  = "";
				if( String.IsNullOrEmpty(CONS_CodRGM) )
				{
					_isCorrect = false;
					CONS_CodRGMOK  = false;
					CONS_CodRGMMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONS_CodRGM", "Prospecto");
					m_mensajeError += "* Debe ingresar el campo CONS_CodRGM" + Environment.NewLine;
				}
				PROS_TEUSOK  = true;
				PROS_TEUSMSGERROR  = "";
				if( PROS_TEUS == null)
				{
					_isCorrect = false;
					PROS_TEUSOK  = false;
					PROS_TEUSMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PROS_TEUS", "Prospecto");
					m_mensajeError += "* Debe ingresar el campo PROS_TEUS" + Environment.NewLine;
				}
				PROS_PorcentajeOK  = true;
				PROS_PorcentajeMSGERROR  = "";
				if( PROS_Porcentaje == null)
				{
					_isCorrect = false;
					PROS_PorcentajeOK  = false;
					PROS_PorcentajeMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PROS_Porcentaje", "Prospecto");
					m_mensajeError += "* Debe ingresar el campo PROS_Porcentaje" + Environment.NewLine;
				}
				PROS_CNTR20OK  = true;
				PROS_CNTR20MSGERROR  = "";
				if( PROS_CNTR20 == null)
				{
					_isCorrect = false;
					PROS_CNTR20OK  = false;
					PROS_CNTR20MSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PROS_CNTR20", "Prospecto");
					m_mensajeError += "* Debe ingresar el campo PROS_CNTR20" + Environment.NewLine;
				}
				PROS_CNTR40OK  = true;
				PROS_CNTR40MSGERROR  = "";
				if( PROS_CNTR40 == null)
				{
					_isCorrect = false;
					PROS_CNTR40OK  = false;
					PROS_CNTR40MSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PROS_CNTR40", "Prospecto");
					m_mensajeError += "* Debe ingresar el campo PROS_CNTR40" + Environment.NewLine;
				}
				OnPropertyChanged("MensajeError");
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
      public Boolean ValidarImportacion()
      {
         try
         {
            Boolean _isCorrect = true;
            m_mensajeError = "";

            ENTC_NomCompletoClienteOK = true;
            ENTC_NomCompletoClienteMSGERROR = "";
            if (String.IsNullOrEmpty(ENTC_RazonSocialCliente))
            {
               _isCorrect = false;
               ENTC_NomCompletoClienteOK = false;
               ENTC_NomCompletoClienteMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "CONSIGNATARIO", "Prospecto");
               m_mensajeError += "* Debe ingresar el campo CONSIGNATARIO" + Environment.NewLine;
            }

            PROS_TEUSOK = true;
            PROS_TEUSMSGERROR = "";
            if (PROS_TEUS == null || PROS_TEUS < 0)
            {
               _isCorrect = false;
               PROS_TEUSOK = false;
               PROS_TEUSMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "TEUS", "Prospecto");
               m_mensajeError += "* Debe ingresar el campo TEUS" + Environment.NewLine;
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
