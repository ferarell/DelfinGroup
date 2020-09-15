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
	public partial class Contrato
	{
		#region [ Variables Validación ]
		private Boolean m_cont_codigoOK;
		private String m_cont_codigoMSGERROR;
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_cont_numeroOK;
		private String m_cont_numeroMSGERROR;
		private Boolean m_cont_descripOK;
		private String m_cont_descripMSGERROR;
		private Boolean m_cont_fecemiOK;
		private String m_cont_fecemiMSGERROR;
		private Boolean m_cont_feciniOK;
		private String m_cont_feciniMSGERROR;
		private Boolean m_cont_fecfinOK;
		private String m_cont_fecfinMSGERROR;
		private Boolean m_entc_codclienteOK;
		private String m_entc_codclienteMSGERROR;
		private Boolean m_entc_codtransportistaOK;
		private String m_entc_codtransportistaMSGERROR;
		private Boolean m_cons_taprgmOK;
		private String m_cons_taprgmMSGERROR;
		private Boolean m_cons_codrgmOK;
		private String m_cons_codrgmMSGERROR;
		private Boolean m_cons_tapviaOK;
		private String m_cons_tapviaMSGERROR;
		private Boolean m_cons_codviaOK;
		private String m_cons_codviaMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;

      private Boolean m_tipo_tabmndOK;
      private String m_tipo_tabmndMSGERROR;
      private Boolean m_tipo_codmndOK;
      private String m_tipo_codmndMSGERROR;
		#endregion

      #region [ Variables Adicionales Validacion ]
      private Boolean m_puer_codorigenOK;
      private String m_puer_codorigenMSGERROR;
      private Boolean m_puer_coddestinoOK;
      private String m_puer_coddestinoMSGERROR;
      #endregion

      #region [ Propiedades Validación ]
      /// <summary>
		/// Gets or sets el valor de validación de: CONT_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CONT_CodigoOK
		{
			get { return m_cont_codigoOK; }
			set
			{
				if (m_cont_codigoOK != value)
				{
					m_cont_codigoOK = value;
					OnPropertyChanged("CONT_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONT_Codigo.
		/// </summary>
		[DataMember]
		public String CONT_CodigoMSGERROR
		{
			get { return m_cont_codigoMSGERROR; }
			set
			{
				if (m_cont_codigoMSGERROR != value)
				{
					m_cont_codigoMSGERROR = value;
					OnPropertyChanged("CONT_CodigoMSGERROR");
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
		/// Gets or sets el valor de validación de: CONT_Numero.
		/// </summary>
		[DataMember]
		public Boolean CONT_NumeroOK
		{
			get { return m_cont_numeroOK; }
			set
			{
				if (m_cont_numeroOK != value)
				{
					m_cont_numeroOK = value;
					OnPropertyChanged("CONT_NumeroOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONT_Numero.
		/// </summary>
		[DataMember]
		public String CONT_NumeroMSGERROR
		{
			get { return m_cont_numeroMSGERROR; }
			set
			{
				if (m_cont_numeroMSGERROR != value)
				{
					m_cont_numeroMSGERROR = value;
					OnPropertyChanged("CONT_NumeroMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONT_Descrip.
		/// </summary>
		[DataMember]
		public Boolean CONT_DescripOK
		{
			get { return m_cont_descripOK; }
			set
			{
				if (m_cont_descripOK != value)
				{
					m_cont_descripOK = value;
					OnPropertyChanged("CONT_DescripOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONT_Descrip.
		/// </summary>
		[DataMember]
		public String CONT_DescripMSGERROR
		{
			get { return m_cont_descripMSGERROR; }
			set
			{
				if (m_cont_descripMSGERROR != value)
				{
					m_cont_descripMSGERROR = value;
					OnPropertyChanged("CONT_DescripMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONT_FecEmi.
		/// </summary>
		[DataMember]
		public Boolean CONT_FecEmiOK
		{
			get { return m_cont_fecemiOK; }
			set
			{
				if (m_cont_fecemiOK != value)
				{
					m_cont_fecemiOK = value;
					OnPropertyChanged("CONT_FecEmiOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONT_FecEmi.
		/// </summary>
		[DataMember]
		public String CONT_FecEmiMSGERROR
		{
			get { return m_cont_fecemiMSGERROR; }
			set
			{
				if (m_cont_fecemiMSGERROR != value)
				{
					m_cont_fecemiMSGERROR = value;
					OnPropertyChanged("CONT_FecEmiMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONT_FecIni.
		/// </summary>
		[DataMember]
		public Boolean CONT_FecIniOK
		{
			get { return m_cont_feciniOK; }
			set
			{
				if (m_cont_feciniOK != value)
				{
					m_cont_feciniOK = value;
					OnPropertyChanged("CONT_FecIniOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONT_FecIni.
		/// </summary>
		[DataMember]
		public String CONT_FecIniMSGERROR
		{
			get { return m_cont_feciniMSGERROR; }
			set
			{
				if (m_cont_feciniMSGERROR != value)
				{
					m_cont_feciniMSGERROR = value;
					OnPropertyChanged("CONT_FecIniMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONT_FecFin.
		/// </summary>
		[DataMember]
		public Boolean CONT_FecFinOK
		{
			get { return m_cont_fecfinOK; }
			set
			{
				if (m_cont_fecfinOK != value)
				{
					m_cont_fecfinOK = value;
					OnPropertyChanged("CONT_FecFinOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONT_FecFin.
		/// </summary>
		[DataMember]
		public String CONT_FecFinMSGERROR
		{
			get { return m_cont_fecfinMSGERROR; }
			set
			{
				if (m_cont_fecfinMSGERROR != value)
				{
					m_cont_fecfinMSGERROR = value;
					OnPropertyChanged("CONT_FecFinMSGERROR");
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
		/// Gets or sets el valor de validación de: ENTC_CodTransportista.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodTransportistaOK
		{
			get { return m_entc_codtransportistaOK; }
			set
			{
				if (m_entc_codtransportistaOK != value)
				{
					m_entc_codtransportistaOK = value;
					OnPropertyChanged("ENTC_CodTransportistaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodTransportista.
		/// </summary>
		[DataMember]
		public String ENTC_CodTransportistaMSGERROR
		{
			get { return m_entc_codtransportistaMSGERROR; }
			set
			{
				if (m_entc_codtransportistaMSGERROR != value)
				{
					m_entc_codtransportistaMSGERROR = value;
					OnPropertyChanged("ENTC_CodTransportistaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TapRGM.
		/// </summary>
		[DataMember]
		public Boolean CONS_TapRGMOK
		{
			get { return m_cons_taprgmOK; }
			set
			{
				if (m_cons_taprgmOK != value)
				{
					m_cons_taprgmOK = value;
					OnPropertyChanged("CONS_TapRGMOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TapRGM.
		/// </summary>
		[DataMember]
		public String CONS_TapRGMMSGERROR
		{
			get { return m_cons_taprgmMSGERROR; }
			set
			{
				if (m_cons_taprgmMSGERROR != value)
				{
					m_cons_taprgmMSGERROR = value;
					OnPropertyChanged("CONS_TapRGMMSGERROR");
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
		/// Gets or sets el valor de validación de: CONS_TapVia.
		/// </summary>
		[DataMember]
		public Boolean CONS_TapViaOK
		{
			get { return m_cons_tapviaOK; }
			set
			{
				if (m_cons_tapviaOK != value)
				{
					m_cons_tapviaOK = value;
					OnPropertyChanged("CONS_TapViaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TapVia.
		/// </summary>
		[DataMember]
		public String CONS_TapViaMSGERROR
		{
			get { return m_cons_tapviaMSGERROR; }
			set
			{
				if (m_cons_tapviaMSGERROR != value)
				{
					m_cons_tapviaMSGERROR = value;
					OnPropertyChanged("CONS_TapViaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodVia.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodViaOK
		{
			get { return m_cons_codviaOK; }
			set
			{
				if (m_cons_codviaOK != value)
				{
					m_cons_codviaOK = value;
					OnPropertyChanged("CONS_CodViaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodVia.
		/// </summary>
		[DataMember]
		public String CONS_CodViaMSGERROR
		{
			get { return m_cons_codviaMSGERROR; }
			set
			{
				if (m_cons_codviaMSGERROR != value)
				{
					m_cons_codviaMSGERROR = value;
					OnPropertyChanged("CONS_CodViaMSGERROR");
				}
			}
		}


      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_TabMND.
      /// </summary>
      [DataMember]
      public Boolean TIPO_TabMNDOK
      {
         get { return m_tipo_tabmndOK; }
         set
         {
            if (m_tipo_tabmndOK != value)
            {
               m_tipo_tabmndOK = value;
               OnPropertyChanged("TIPO_TabMNDOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_TabMND.
      /// </summary>
      [DataMember]
      public String TIPO_TabMNDMSGERROR
      {
         get { return m_tipo_tabmndMSGERROR; }
         set
         {
            if (m_tipo_tabmndMSGERROR != value)
            {
               m_tipo_tabmndMSGERROR = value;
               OnPropertyChanged("TIPO_TabMNDMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_CodMND.
      /// </summary>
      [DataMember]
      public Boolean TIPO_CodMNDOK
      {
         get { return m_tipo_codmndOK; }
         set
         {
            if (m_tipo_codmndOK != value)
            {
               m_tipo_codmndOK = value;
               OnPropertyChanged("TIPO_CodMNDOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_CodMND.
      /// </summary>
      [DataMember]
      public String TIPO_CodMNDMSGERROR
      {
         get { return m_tipo_codmndMSGERROR; }
         set
         {
            if (m_tipo_codmndMSGERROR != value)
            {
               m_tipo_codmndMSGERROR = value;
               OnPropertyChanged("TIPO_CodMNDMSGERROR");
            }
         }
      }
      #endregion

      #region [ Propiedades Validación Adicionales ]
      /// <summary>
      /// Gets or sets el valor de validación de: PUER_CodOrigen.
      /// </summary>
      [DataMember]
      public Boolean PUER_CodOrigenOK
      {
         get { return m_puer_codorigenOK; }
         set
         {
            if (m_puer_codorigenOK != value)
            {
               m_puer_codorigenOK = value;
               OnPropertyChanged("PUER_CodOrigenOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: PUER_CodOrigen.
      /// </summary>
      [DataMember]
      public String PUER_CodOrigenMSGERROR
      {
         get { return m_puer_codorigenMSGERROR; }
         set
         {
            if (m_puer_codorigenMSGERROR != value)
            {
               m_puer_codorigenMSGERROR = value;
               OnPropertyChanged("PUER_CodOrigenMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: PUER_CodDestino.
      /// </summary>
      [DataMember]
      public Boolean PUER_CodDestinoOK
      {
         get { return m_puer_coddestinoOK; }
         set
         {
            if (m_puer_coddestinoOK != value)
            {
               m_puer_coddestinoOK = value;
               OnPropertyChanged("PUER_CodDestinoOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: PUER_CodDestino.
      /// </summary>
      [DataMember]
      public String PUER_CodDestinoMSGERROR
      {
         get { return m_puer_coddestinoMSGERROR; }
         set
         {
            if (m_puer_coddestinoMSGERROR != value)
            {
               m_puer_coddestinoMSGERROR = value;
               OnPropertyChanged("PUER_CodDestinoMSGERROR");
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
				CONT_CodigoOK  = true;
				CONT_CodigoMSGERROR  = "";
            //if( CONT_Codigo == null)
            //{
            //   _isCorrect = false;
            //   CONT_CodigoOK  = false;
            //   CONT_CodigoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "CONT_Codigo", "Contrato");
            //   m_mensajeError += "* Debe ingresar el campo CONT_Codigo" + Environment.NewLine;
            //}
				CONT_NumeroOK  = true;
				CONT_NumeroMSGERROR  = "";
				if( String.IsNullOrEmpty(CONT_Numero) )
				{
					_isCorrect = false;
					CONT_NumeroOK  = false;
               CONT_NumeroMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Número", "Contrato");
					m_mensajeError += "* Debe ingresar el campo Número" + Environment.NewLine;
				}
				CONT_DescripOK  = true;
				CONT_DescripMSGERROR  = "";
				if( String.IsNullOrEmpty(CONT_Descrip) )
				{
					_isCorrect = false;
					CONT_DescripOK  = false;
               CONT_DescripMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Descripción", "Contrato");
					m_mensajeError += "* Debe ingresar el campo Descripción" + Environment.NewLine;
				}
				CONT_FecEmiOK  = true;
				CONT_FecEmiMSGERROR  = "";
				if( CONT_FecEmi == null)
				{
					_isCorrect = false;
					CONT_FecEmiOK  = false;
               CONT_FecEmiMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Fecha Emisión", "Contrato");
					m_mensajeError += "* Debe ingresar el campo Fecha Emisión" + Environment.NewLine;
				}
				CONT_FecIniOK  = true;
				CONT_FecIniMSGERROR  = "";
				if(!CONT_FecIni.HasValue)
				{
					_isCorrect = false;
					CONT_FecIniOK  = false;
               CONT_FecIniMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Fecha Inicio", "Contrato");
					m_mensajeError += "* Debe ingresar el campo Fecha Inicio" + Environment.NewLine;
				}
				CONT_FecFinOK  = true;
				CONT_FecFinMSGERROR  = "";
				if(!CONT_FecFin.HasValue)
				{
					_isCorrect = false;
					CONT_FecFinOK  = false;
               CONT_FecFinMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Fecha Fin", "Contrato");
					m_mensajeError += "* Debe ingresar el campo Fecha Fin" + Environment.NewLine;
				}
				ENTC_CodTransportistaOK  = true;
				ENTC_CodTransportistaMSGERROR  = "";
				if( ENTC_CodTransportista == null)
				{
					_isCorrect = false;
					ENTC_CodTransportistaOK  = false;
               ENTC_CodTransportistaMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Transportista", "Contrato");
					m_mensajeError += "* Debe ingresar el campo Transportista" + Environment.NewLine;
				}

            CONS_TapRGMOK = true;
            CONS_CodRGMOK = true;
            CONS_TapRGMMSGERROR = "";
            CONS_CodRGMMSGERROR = "";
            if (String.IsNullOrEmpty(CONS_TapRGM) || String.IsNullOrEmpty(CONS_CodRGM))
            {
               _isCorrect = false;
               CONS_TapRGMOK = false;
               CONS_CodRGMOK = false;
               CONS_TapRGMMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Régimen", "Contrato");
               CONS_CodRGMMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Régimen", "Contrato");
               m_mensajeError += "* Debe ingresar el campo Régimen" + Environment.NewLine;
            }
            CONS_TapViaOK = true;
            CONS_CodViaOK = true;
            CONS_TapViaMSGERROR = "";
            CONS_CodViaMSGERROR = "";
            if (String.IsNullOrEmpty(CONS_TapVia) || String.IsNullOrEmpty(CONS_CodVia))
            {
               _isCorrect = false;
               CONS_TapViaOK = false;
               CONS_CodViaOK = false;
               CONS_TapViaMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Vía", "Contrato");
               CONS_CodViaMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Vía", "Contrato");
               m_mensajeError += "* Debe ingresar el campo Vía" + Environment.NewLine;
            }

            TIPO_TabMNDOK = true;
            TIPO_CodMNDOK = true;
            TIPO_TabMNDMSGERROR = "";
            TIPO_CodMNDMSGERROR = "";
            if (String.IsNullOrEmpty(TIPO_TabMND) || String.IsNullOrEmpty(TIPO_CodMND))
            {
               _isCorrect = false;
               TIPO_TabMNDOK = false;
               TIPO_CodMNDOK = false;
               TIPO_TabMNDMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Moneda", "Contrato");
               TIPO_CodMNDMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Moneda", "Contrato");
               m_mensajeError += "* Debe ingresar el campo Moneda" + Environment.NewLine;
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
