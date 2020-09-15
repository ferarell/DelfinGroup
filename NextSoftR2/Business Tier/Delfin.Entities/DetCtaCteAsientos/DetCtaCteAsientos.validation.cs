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
	public partial class DetCtaCteAsientos
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_ccct_codigoOK;
		private String m_ccct_codigoMSGERROR;
		private Boolean m_dcca_itemOK;
		private String m_dcca_itemMSGERROR;
		private Boolean m_dcca_cuentaOK;
		private String m_dcca_cuentaMSGERROR;
		private Boolean m_dcca_glosaOK;
		private String m_dcca_glosaMSGERROR;
		private Boolean m_dcca_debeporcOK;
		private String m_dcca_debeporcMSGERROR;
		private Boolean m_dcca_debemontoOK;
		private String m_dcca_debemontoMSGERROR;
		private Boolean m_dcca_haberporcOK;
		private String m_dcca_haberporcMSGERROR;
		private Boolean m_dcca_habermontoOK;
		private String m_dcca_habermontoMSGERROR;
		private Boolean m_cabp_anoOK;
		private String m_cabp_anoMSGERROR;
		private Boolean m_cabp_codigoOK;
		private String m_cabp_codigoMSGERROR;
		private Boolean m_detp_itemOK;
		private String m_detp_itemMSGERROR;
		private Boolean m_cent_anoOK;
		private String m_cent_anoMSGERROR;
		private Boolean m_cent_codigoOK;
		private String m_cent_codigoMSGERROR;
		private Boolean m_tipo_tabopeOK;
		private String m_tipo_tabopeMSGERROR;
		private Boolean m_tipo_codopeOK;
		private String m_tipo_codopeMSGERROR;
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
		/// Gets or sets el valor de validación de: CCCT_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CCCT_CodigoOK
		{
			get { return m_ccct_codigoOK; }
			set
			{
				if (m_ccct_codigoOK != value)
				{ m_ccct_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCCT_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String CCCT_CodigoMSGERROR
		{
			get { return m_ccct_codigoMSGERROR; }
			set
			{
				if (m_ccct_codigoMSGERROR != value)
				{m_ccct_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCA_Item.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DCCA_ItemOK
		{
			get { return m_dcca_itemOK; }
			set
			{
				if (m_dcca_itemOK != value)
				{ m_dcca_itemOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCA_Item.
		/// </summary>
		[IgnoreDataMember]
		public String DCCA_ItemMSGERROR
		{
			get { return m_dcca_itemMSGERROR; }
			set
			{
				if (m_dcca_itemMSGERROR != value)
				{m_dcca_itemMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCA_Cuenta.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DCCA_CuentaOK
		{
			get { return m_dcca_cuentaOK; }
			set
			{
				if (m_dcca_cuentaOK != value)
				{ m_dcca_cuentaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCA_Cuenta.
		/// </summary>
		[IgnoreDataMember]
		public String DCCA_CuentaMSGERROR
		{
			get { return m_dcca_cuentaMSGERROR; }
			set
			{
				if (m_dcca_cuentaMSGERROR != value)
				{m_dcca_cuentaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCA_Glosa.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DCCA_GlosaOK
		{
			get { return m_dcca_glosaOK; }
			set
			{
				if (m_dcca_glosaOK != value)
				{ m_dcca_glosaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCA_Glosa.
		/// </summary>
		[IgnoreDataMember]
		public String DCCA_GlosaMSGERROR
		{
			get { return m_dcca_glosaMSGERROR; }
			set
			{
				if (m_dcca_glosaMSGERROR != value)
				{m_dcca_glosaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCA_DebePorc.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DCCA_DebePorcOK
		{
			get { return m_dcca_debeporcOK; }
			set
			{
				if (m_dcca_debeporcOK != value)
				{ m_dcca_debeporcOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCA_DebePorc.
		/// </summary>
		[IgnoreDataMember]
		public String DCCA_DebePorcMSGERROR
		{
			get { return m_dcca_debeporcMSGERROR; }
			set
			{
				if (m_dcca_debeporcMSGERROR != value)
				{m_dcca_debeporcMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCA_DebeMonto.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DCCA_DebeMontoOK
		{
			get { return m_dcca_debemontoOK; }
			set
			{
				if (m_dcca_debemontoOK != value)
				{ m_dcca_debemontoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCA_DebeMonto.
		/// </summary>
		[IgnoreDataMember]
		public String DCCA_DebeMontoMSGERROR
		{
			get { return m_dcca_debemontoMSGERROR; }
			set
			{
				if (m_dcca_debemontoMSGERROR != value)
				{m_dcca_debemontoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCA_HaberPorc.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DCCA_HaberPorcOK
		{
			get { return m_dcca_haberporcOK; }
			set
			{
				if (m_dcca_haberporcOK != value)
				{ m_dcca_haberporcOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCA_HaberPorc.
		/// </summary>
		[IgnoreDataMember]
		public String DCCA_HaberPorcMSGERROR
		{
			get { return m_dcca_haberporcMSGERROR; }
			set
			{
				if (m_dcca_haberporcMSGERROR != value)
				{m_dcca_haberporcMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DCCA_HaberMonto.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DCCA_HaberMontoOK
		{
			get { return m_dcca_habermontoOK; }
			set
			{
				if (m_dcca_habermontoOK != value)
				{ m_dcca_habermontoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DCCA_HaberMonto.
		/// </summary>
		[IgnoreDataMember]
		public String DCCA_HaberMontoMSGERROR
		{
			get { return m_dcca_habermontoMSGERROR; }
			set
			{
				if (m_dcca_habermontoMSGERROR != value)
				{m_dcca_habermontoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CABP_Ano.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CABP_AnoOK
		{
			get { return m_cabp_anoOK; }
			set
			{
				if (m_cabp_anoOK != value)
				{ m_cabp_anoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CABP_Ano.
		/// </summary>
		[IgnoreDataMember]
		public String CABP_AnoMSGERROR
		{
			get { return m_cabp_anoMSGERROR; }
			set
			{
				if (m_cabp_anoMSGERROR != value)
				{m_cabp_anoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CABP_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CABP_CodigoOK
		{
			get { return m_cabp_codigoOK; }
			set
			{
				if (m_cabp_codigoOK != value)
				{ m_cabp_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CABP_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String CABP_CodigoMSGERROR
		{
			get { return m_cabp_codigoMSGERROR; }
			set
			{
				if (m_cabp_codigoMSGERROR != value)
				{m_cabp_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DETP_Item.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DETP_ItemOK
		{
			get { return m_detp_itemOK; }
			set
			{
				if (m_detp_itemOK != value)
				{ m_detp_itemOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DETP_Item.
		/// </summary>
		[IgnoreDataMember]
		public String DETP_ItemMSGERROR
		{
			get { return m_detp_itemMSGERROR; }
			set
			{
				if (m_detp_itemMSGERROR != value)
				{m_detp_itemMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CENT_Ano.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CENT_AnoOK
		{
			get { return m_cent_anoOK; }
			set
			{
				if (m_cent_anoOK != value)
				{ m_cent_anoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CENT_Ano.
		/// </summary>
		[IgnoreDataMember]
		public String CENT_AnoMSGERROR
		{
			get { return m_cent_anoMSGERROR; }
			set
			{
				if (m_cent_anoMSGERROR != value)
				{m_cent_anoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CENT_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CENT_CodigoOK
		{
			get { return m_cent_codigoOK; }
			set
			{
				if (m_cent_codigoOK != value)
				{ m_cent_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CENT_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String CENT_CodigoMSGERROR
		{
			get { return m_cent_codigoMSGERROR; }
			set
			{
				if (m_cent_codigoMSGERROR != value)
				{m_cent_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabOPE.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_TabOPEOK
		{
			get { return m_tipo_tabopeOK; }
			set
			{
				if (m_tipo_tabopeOK != value)
				{ m_tipo_tabopeOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabOPE.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_TabOPEMSGERROR
		{
			get { return m_tipo_tabopeMSGERROR; }
			set
			{
				if (m_tipo_tabopeMSGERROR != value)
				{m_tipo_tabopeMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodOPE.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_CodOPEOK
		{
			get { return m_tipo_codopeOK; }
			set
			{
				if (m_tipo_codopeOK != value)
				{ m_tipo_codopeOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodOPE.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_CodOPEMSGERROR
		{
			get { return m_tipo_codopeMSGERROR; }
			set
			{
				if (m_tipo_codopeMSGERROR != value)
				{m_tipo_codopeMSGERROR = value; }
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
					EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "DetCtaCteAsientos");
					m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
				}
				CCCT_CodigoOK  = true;
				CCCT_CodigoMSGERROR  = "";
				if( CCCT_Codigo == 0)
				{
               //_isCorrect = false;
               //CCCT_CodigoOK  = false;
               //CCCT_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCCT_Codigo", "DetCtaCteAsientos");
               //m_mensajeError += "* Debe ingresar el campo CCCT_Codigo" + Environment.NewLine;
				}
				DCCA_ItemOK  = true;
				DCCA_ItemMSGERROR  = "";
				if( DCCA_Item == null)
				{
					_isCorrect = false;
					DCCA_ItemOK  = false;
					DCCA_ItemMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Item", "Detalle del Asiento");
               m_mensajeError += "* Debe ingresar el campo Detalle del Asiento" + Environment.NewLine;
				}
				DCCA_CuentaOK  = true;
				DCCA_CuentaMSGERROR  = "";
				if( String.IsNullOrEmpty(DCCA_Cuenta) )
				{
					_isCorrect = false;
					DCCA_CuentaOK  = false;
               DCCA_CuentaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Número de Cuenta", "Detalle del Asiento");
               m_mensajeError += "* Debe ingresar el campo Número de Cuenta" + Environment.NewLine;
				}

            if (DCCA_DebePorc + DCCA_HaberPorc == 0)
            {
               _isCorrect = false;
               m_mensajeError += String.Format("* Debe ingresar un porcentaje valido para el Item {1}{0}", Environment.NewLine, DCCA_Item);
            }

            TIPO_CodOPEOK = true;
            TIPO_CodOPEMSGERROR = "";
            if (String.IsNullOrEmpty(TIPO_CodOPE.Trim()))
            {
               _isCorrect = false;
               DCCA_CuentaOK = false;
               DCCA_CuentaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de Operacion", "Detalle del Asiento");
               m_mensajeError += "* Debe ingresar el campo Tipo de Operacion" + Environment.NewLine;
            }

            DCCA_GlosaOK = true;
            DCCA_GlosaMSGERROR = "";
            if (String.IsNullOrEmpty(DCCA_Glosa))
            {
               _isCorrect = false;
               DCCA_GlosaOK = false;
               DCCA_GlosaMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Glosa", "Detalle del Asiento");
               m_mensajeError += "* Debe ingresar el campo Glosa" + Environment.NewLine;
            }

            if (ValidarCentroCto)
            {
               CENT_CodigoOK = true;
               CENT_CodigoMSGERROR = "";
               if (String.IsNullOrEmpty(CENT_Codigo))
               {
                  _isCorrect = false;
                  CENT_CodigoOK = false;
                  CENT_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Centro de Costo", "Detalle del Asiento");
                  m_mensajeError += "* Debe ingresar el campo Centro de Costo" + Environment.NewLine;
               }
            }

				DCCA_DebePorcOK  = true;
				DCCA_DebePorcMSGERROR  = "";
				if( DCCA_DebePorc == 0)
				{
               //_isCorrect = false;
               //DCCA_DebePorcOK  = false;
               //DCCA_DebePorcMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "DCCA_DebePorc", "Detalle del Asiento");
               //m_mensajeError += "* Debe ingresar el campo DCCA_DebePorc" + Environment.NewLine;
				}
				DCCA_DebeMontoOK  = true;
				DCCA_DebeMontoMSGERROR  = "";
				if( DCCA_DebeMonto == 0)
				{
               //_isCorrect = false;
               //DCCA_DebeMontoOK  = false;
               //DCCA_DebeMontoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "DCCA_DebeMonto", "Detalle del Asiento");
               //m_mensajeError += "* Debe ingresar el campo DCCA_DebeMonto" + Environment.NewLine;
				}
				DCCA_HaberPorcOK  = true;
				DCCA_HaberPorcMSGERROR  = "";
				if( DCCA_HaberPorc == 0)
				{
               //_isCorrect = false;
               //DCCA_HaberPorcOK  = false;
               //DCCA_HaberPorcMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "DCCA_HaberPorc", "Detalle del Asiento");
               //m_mensajeError += "* Debe ingresar el campo DCCA_HaberPorc" + Environment.NewLine;
				}
				DCCA_HaberMontoOK  = true;
				DCCA_HaberMontoMSGERROR  = "";
				if( DCCA_HaberMonto == 0)
				{
               //_isCorrect = false;
               //DCCA_HaberMontoOK  = false;
               //DCCA_HaberMontoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "DCCA_HaberMonto", "Detalle del Asiento");
               //m_mensajeError += "* Debe ingresar el campo DCCA_HaberMonto" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
