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
	public partial class Tipificaciones
	{
		#region [ Variables Validación ]
		private Boolean m_movi_codigoOK;
		private String m_movi_codigoMSGERROR;
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_tipd_itemOK;
		private String m_tipd_itemMSGERROR;
		private Boolean m_tipd_tipocambioOK;
		private String m_tipd_tipocambioMSGERROR;
		private Boolean m_tipd_montodebeOK;
		private String m_tipd_montodebeMSGERROR;
		private Boolean m_tipd_montohaberOK;
		private String m_tipd_montohaberMSGERROR;
		private Boolean m_tipd_tipoOK;
		private String m_tipd_tipoMSGERROR;
		private Boolean m_tipd_generactacteOK;
		private String m_tipd_generactacteMSGERROR;
		private Boolean m_tipd_cuentaOK;
		private String m_tipd_cuentaMSGERROR;
		private Boolean m_cent_anoOK;
		private String m_cent_anoMSGERROR;
		private Boolean m_cent_codigoOK;
		private String m_cent_codigoMSGERROR;
		private Boolean m_tipo_tabdesOK;
		private String m_tipo_tabdesMSGERROR;
		private Boolean m_tipo_coddesOK;
		private String m_tipo_coddesMSGERROR;
		private Boolean m_tipo_tabmndOK;
		private String m_tipo_tabmndMSGERROR;
		private Boolean m_tipo_codmndOK;
		private String m_tipo_codmndMSGERROR;
		private Boolean m_tipo_tabtdoOK;
		private String m_tipo_tabtdoMSGERROR;
		private Boolean m_tipo_codtdoOK;
		private String m_tipo_codtdoMSGERROR;
		private Boolean m_tipe_codigoOK;
		private String m_tipe_codigoMSGERROR;
		private Boolean m_entc_codigoOK;
		private String m_entc_codigoMSGERROR;
		private Boolean m_ccct_codigoOK;
		private String m_ccct_codigoMSGERROR;
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
		/// Gets or sets el valor de validación de: TIPD_Item.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPD_ItemOK
		{
			get { return m_tipd_itemOK; }
			set
			{
				if (m_tipd_itemOK != value)
				{ m_tipd_itemOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPD_Item.
		/// </summary>
		[IgnoreDataMember]
		public String TIPD_ItemMSGERROR
		{
			get { return m_tipd_itemMSGERROR; }
			set
			{
				if (m_tipd_itemMSGERROR != value)
				{m_tipd_itemMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPD_TipoCambio.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPD_TipoCambioOK
		{
			get { return m_tipd_tipocambioOK; }
			set
			{
				if (m_tipd_tipocambioOK != value)
				{ m_tipd_tipocambioOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPD_TipoCambio.
		/// </summary>
		[IgnoreDataMember]
		public String TIPD_TipoCambioMSGERROR
		{
			get { return m_tipd_tipocambioMSGERROR; }
			set
			{
				if (m_tipd_tipocambioMSGERROR != value)
				{m_tipd_tipocambioMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPD_MontoDebe.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPD_MontoDebeOK
		{
			get { return m_tipd_montodebeOK; }
			set
			{
				if (m_tipd_montodebeOK != value)
				{ m_tipd_montodebeOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPD_MontoDebe.
		/// </summary>
		[IgnoreDataMember]
		public String TIPD_MontoDebeMSGERROR
		{
			get { return m_tipd_montodebeMSGERROR; }
			set
			{
				if (m_tipd_montodebeMSGERROR != value)
				{m_tipd_montodebeMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPD_MontoHaber.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPD_MontoHaberOK
		{
			get { return m_tipd_montohaberOK; }
			set
			{
				if (m_tipd_montohaberOK != value)
				{ m_tipd_montohaberOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPD_MontoHaber.
		/// </summary>
		[IgnoreDataMember]
		public String TIPD_MontoHaberMSGERROR
		{
			get { return m_tipd_montohaberMSGERROR; }
			set
			{
				if (m_tipd_montohaberMSGERROR != value)
				{m_tipd_montohaberMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPD_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPD_TipoOK
		{
			get { return m_tipd_tipoOK; }
			set
			{
				if (m_tipd_tipoOK != value)
				{ m_tipd_tipoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPD_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public String TIPD_TipoMSGERROR
		{
			get { return m_tipd_tipoMSGERROR; }
			set
			{
				if (m_tipd_tipoMSGERROR != value)
				{m_tipd_tipoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPD_GeneraCtaCte.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPD_GeneraCtaCteOK
		{
			get { return m_tipd_generactacteOK; }
			set
			{
				if (m_tipd_generactacteOK != value)
				{ m_tipd_generactacteOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPD_GeneraCtaCte.
		/// </summary>
		[IgnoreDataMember]
		public String TIPD_GeneraCtaCteMSGERROR
		{
			get { return m_tipd_generactacteMSGERROR; }
			set
			{
				if (m_tipd_generactacteMSGERROR != value)
				{m_tipd_generactacteMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPD_Cuenta.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPD_CuentaOK
		{
			get { return m_tipd_cuentaOK; }
			set
			{
				if (m_tipd_cuentaOK != value)
				{ m_tipd_cuentaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPD_Cuenta.
		/// </summary>
		[IgnoreDataMember]
		public String TIPD_CuentaMSGERROR
		{
			get { return m_tipd_cuentaMSGERROR; }
			set
			{
				if (m_tipd_cuentaMSGERROR != value)
				{m_tipd_cuentaMSGERROR = value; }
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
		/// Gets or sets el valor de validación de: TIPO_TabDES.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_TabDESOK
		{
			get { return m_tipo_tabdesOK; }
			set
			{
				if (m_tipo_tabdesOK != value)
				{ m_tipo_tabdesOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabDES.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_TabDESMSGERROR
		{
			get { return m_tipo_tabdesMSGERROR; }
			set
			{
				if (m_tipo_tabdesMSGERROR != value)
				{m_tipo_tabdesMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodDES.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_CodDESOK
		{
			get { return m_tipo_coddesOK; }
			set
			{
				if (m_tipo_coddesOK != value)
				{ m_tipo_coddesOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodDES.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_CodDESMSGERROR
		{
			get { return m_tipo_coddesMSGERROR; }
			set
			{
				if (m_tipo_coddesMSGERROR != value)
				{m_tipo_coddesMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabMND.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_TabMNDOK
		{
			get { return m_tipo_tabmndOK; }
			set
			{
				if (m_tipo_tabmndOK != value)
				{ m_tipo_tabmndOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabMND.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_TabMNDMSGERROR
		{
			get { return m_tipo_tabmndMSGERROR; }
			set
			{
				if (m_tipo_tabmndMSGERROR != value)
				{m_tipo_tabmndMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodMND.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_CodMNDOK
		{
			get { return m_tipo_codmndOK; }
			set
			{
				if (m_tipo_codmndOK != value)
				{ m_tipo_codmndOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodMND.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_CodMNDMSGERROR
		{
			get { return m_tipo_codmndMSGERROR; }
			set
			{
				if (m_tipo_codmndMSGERROR != value)
				{m_tipo_codmndMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabTDO.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_TabTDOOK
		{
			get { return m_tipo_tabtdoOK; }
			set
			{
				if (m_tipo_tabtdoOK != value)
				{ m_tipo_tabtdoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabTDO.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_TabTDOMSGERROR
		{
			get { return m_tipo_tabtdoMSGERROR; }
			set
			{
				if (m_tipo_tabtdoMSGERROR != value)
				{m_tipo_tabtdoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodTDO.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_CodTDOOK
		{
			get { return m_tipo_codtdoOK; }
			set
			{
				if (m_tipo_codtdoOK != value)
				{ m_tipo_codtdoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodTDO.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_CodTDOMSGERROR
		{
			get { return m_tipo_codtdoMSGERROR; }
			set
			{
				if (m_tipo_codtdoMSGERROR != value)
				{m_tipo_codtdoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPE_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPE_CodigoOK
		{
			get { return m_tipe_codigoOK; }
			set
			{
				if (m_tipe_codigoOK != value)
				{ m_tipe_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPE_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String TIPE_CodigoMSGERROR
		{
			get { return m_tipe_codigoMSGERROR; }
			set
			{
				if (m_tipe_codigoMSGERROR != value)
				{m_tipe_codigoMSGERROR = value; }
			}
		}
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
				MOVI_CodigoOK  = true;
				MOVI_CodigoMSGERROR  = "";
            //if( MOVI_Codigo == 0)
            //{
            //   _isCorrect = false;
            //   MOVI_CodigoOK  = false;
            //   MOVI_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "MOVI_Codigo", "Tipificaciones");
            //   m_mensajeError += "* Debe ingresar el campo MOVI_Codigo" + Environment.NewLine;
            //}

            if (TIPD_GeneraCtaCte)
            {
               ENTC_CodigoOK = true;
               ENTC_CodigoMSGERROR = "";
               if (ENTC_Codigo == null || ENTC_Codigo == 0)
               {
                  _isCorrect = false;
                  ENTC_CodigoOK = false;
                  ENTC_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Entidad", "Tipificaciones");
                  m_mensajeError += "* Debe ingresar el campo Entidad, es obligatoria cuando se genera un registro de Cta. Cte." + Environment.NewLine;
               }
            }

				EMPR_CodigoOK  = true;
				EMPR_CodigoMSGERROR  = "";
            //if( EMPR_Codigo == null)
            //{
            //   _isCorrect = false;
            //   EMPR_CodigoOK  = false;
            //   EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "Tipificaciones");
            //   m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
            //}
				TIPD_ItemOK  = true;
				TIPD_ItemMSGERROR  = "";
            //if( TIPD_Item == null)
            //{
            //   _isCorrect = false;
            //   TIPD_ItemOK  = false;
            //   TIPD_ItemMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPD_Item", "Tipificaciones");
            //   m_mensajeError += "* Debe ingresar el campo TIPD_Item" + Environment.NewLine;
            //}
				TIPD_TipoCambioOK  = true;
				TIPD_TipoCambioMSGERROR  = "";
				if( TIPD_TipoCambio == 0)
				{
					_isCorrect = false;
					TIPD_TipoCambioOK  = false;
					TIPD_TipoCambioMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de Cambio", "Tipificaciones");
               m_mensajeError += "* Debe ingresar el campo Tipo de Cambio" + Environment.NewLine;
				}
				TIPD_MontoDebeOK  = true;
				TIPD_MontoDebeMSGERROR  = "";
            TIPD_MontoHaberOK = true;
            TIPD_MontoHaberMSGERROR = "";

            if (TIPD_MontoDebe + TIPD_MontoHaber == 0)
				{
               if (TIPD_MontoDebe == 0)
               {
                  _isCorrect = false;
                  TIPD_MontoDebeOK = false;
                  TIPD_MontoDebeMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Un monto Valido en el campo Debe o Haber", "Tipificaciones");
                  m_mensajeError += "* Debe ingresar el campo Monto Debe" + Environment.NewLine;
               }
               if (TIPD_MontoHaber == 0)
               {
                  _isCorrect = false;
                  TIPD_MontoHaberOK = false;
                  TIPD_MontoHaberMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Un monto Valido en el campo Debe o Haber", "Tipificaciones");
                  m_mensajeError += "* Debe ingresar el campo Monto Haber" + Environment.NewLine;
               }
				}
				TIPD_TipoOK  = true;
				TIPD_TipoMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPD_Tipo) )
				{
					_isCorrect = false;
					TIPD_TipoOK  = false;
					TIPD_TipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Tipo", "Tipificaciones");
               m_mensajeError += "* Debe ingresar el campo Tipo" + Environment.NewLine;
				}
				TIPO_TabDESOK  = true;
				TIPO_TabDESMSGERROR  = "";
            //if( String.IsNullOrEmpty(TIPO_TabDES) )
            //{
            //   _isCorrect = false;
            //   TIPO_TabDESOK  = false;
            //   TIPO_TabDESMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_TabDES", "Tipificaciones");
            //   m_mensajeError += "* Debe ingresar el campo TIPO_TabDES" + Environment.NewLine;
            //}
				TIPO_CodDESOK  = true;
				TIPO_CodDESMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodDES) )
				{
					_isCorrect = false;
					TIPO_CodDESOK  = false;
					TIPO_CodDESMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de Tipificación", "Tipificaciones");
               m_mensajeError += "* Debe ingresar el campo Tipo de Tipificación" + Environment.NewLine;
				}
				TIPO_TabMNDOK  = true;
				TIPO_TabMNDMSGERROR  = "";
            //if( String.IsNullOrEmpty(TIPO_TabMND) )
            //{
            //   _isCorrect = false;
            //   TIPO_TabMNDOK  = false;
            //   TIPO_TabMNDMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_TabMND", "Tipificaciones");
            //   m_mensajeError += "* Debe ingresar el campo TIPO_TabMND" + Environment.NewLine;
            //}
            TIPD_CuentaOK = true;
            TIPD_CuentaMSGERROR = "";
            if (String.IsNullOrEmpty(TIPD_Cuenta))
            {
               _isCorrect = false;
               TIPD_CuentaOK = false;
               TIPD_CuentaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Cuenta Contable", "Tipificaciones");
               m_mensajeError += "* Debe ingresar el campo Cuenta Contable" + Environment.NewLine;
            }

				TIPO_CodMNDOK  = true;
				TIPO_CodMNDMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodMND) )
				{
					_isCorrect = false;
					TIPO_CodMNDOK  = false;
					TIPO_CodMNDMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de Moneda", "Tipificaciones");
               m_mensajeError += "* Debe ingresar el campo Tipo de Moneda" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
