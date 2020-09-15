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
	public partial class Anexos
	{
		#region [ Variables Validación ]
		private Boolean m_anex_itemOK;
		private String m_anex_itemMSGERROR;
		private Boolean m_ccot_numeroOK;
		private String m_ccot_numeroMSGERROR;
		private Boolean m_ccot_tipoOK;
		private String m_ccot_tipoMSGERROR;
		private Boolean m_anex_mromanifiestoOK;
		private String m_anex_mromanifiestoMSGERROR;
		private Boolean m_anex_fecllegadaOK;
		private String m_anex_fecllegadaMSGERROR;
		private Boolean m_anex_fecsalidaOK;
		private String m_anex_fecsalidaMSGERROR;
		private Boolean m_anex_numerohblOK;
		private String m_anex_numerohblMSGERROR;
		private Boolean m_anex_fecdescargaOK;
		private String m_anex_fecdescargaMSGERROR;
		private Boolean m_anex_fecembarqueOK;
		private String m_anex_fecembarqueMSGERROR;
		private Boolean m_anex_tipoOK;
		private String m_anex_tipoMSGERROR;
      private Boolean m_anex_tiporectificacionOK;
      private String m_anex_tiporectificacionMSGERROR;
		private Boolean m_anex_observacionesOK;
		private String m_anex_observacionesMSGERROR;
		private Boolean m_anex_dondediceOK;
		private String m_anex_dondediceMSGERROR;
		private Boolean m_anex_debedecirOK;
		private String m_anex_debedecirMSGERROR;
      private Boolean m_anex_fundamentosOK;
      private String m_anex_fundamentosMSGERROR;
		private Boolean m_anex_documentosOK;
		private String m_anex_documentosMSGERROR;
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
		/// Gets or sets el valor de validación de: ANEX_Item.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ANEX_ItemOK
		{
			get { return m_anex_itemOK; }
			set
			{
				if (m_anex_itemOK != value)
				{ m_anex_itemOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ANEX_Item.
		/// </summary>
		[IgnoreDataMember]
		public String ANEX_ItemMSGERROR
		{
			get { return m_anex_itemMSGERROR; }
			set
			{
				if (m_anex_itemMSGERROR != value)
				{m_anex_itemMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Numero.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CCOT_NumeroOK
		{
			get { return m_ccot_numeroOK; }
			set
			{
				if (m_ccot_numeroOK != value)
				{ m_ccot_numeroOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Numero.
		/// </summary>
		[IgnoreDataMember]
		public String CCOT_NumeroMSGERROR
		{
			get { return m_ccot_numeroMSGERROR; }
			set
			{
				if (m_ccot_numeroMSGERROR != value)
				{m_ccot_numeroMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CCOT_TipoOK
		{
			get { return m_ccot_tipoOK; }
			set
			{
				if (m_ccot_tipoOK != value)
				{ m_ccot_tipoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public String CCOT_TipoMSGERROR
		{
			get { return m_ccot_tipoMSGERROR; }
			set
			{
				if (m_ccot_tipoMSGERROR != value)
				{m_ccot_tipoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ANEX_MroManifiesto.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ANEX_MroManifiestoOK
		{
			get { return m_anex_mromanifiestoOK; }
			set
			{
				if (m_anex_mromanifiestoOK != value)
				{ m_anex_mromanifiestoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ANEX_MroManifiesto.
		/// </summary>
		[IgnoreDataMember]
		public String ANEX_MroManifiestoMSGERROR
		{
			get { return m_anex_mromanifiestoMSGERROR; }
			set
			{
				if (m_anex_mromanifiestoMSGERROR != value)
				{m_anex_mromanifiestoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ANEX_FecLlegada.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ANEX_FecLlegadaOK
		{
			get { return m_anex_fecllegadaOK; }
			set
			{
				if (m_anex_fecllegadaOK != value)
				{ m_anex_fecllegadaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ANEX_FecLlegada.
		/// </summary>
		[IgnoreDataMember]
		public String ANEX_FecLlegadaMSGERROR
		{
			get { return m_anex_fecllegadaMSGERROR; }
			set
			{
				if (m_anex_fecllegadaMSGERROR != value)
				{m_anex_fecllegadaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ANEX_FecSalida.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ANEX_FecSalidaOK
		{
			get { return m_anex_fecsalidaOK; }
			set
			{
				if (m_anex_fecsalidaOK != value)
				{ m_anex_fecsalidaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ANEX_FecSalida.
		/// </summary>
		[IgnoreDataMember]
		public String ANEX_FecSalidaMSGERROR
		{
			get { return m_anex_fecsalidaMSGERROR; }
			set
			{
				if (m_anex_fecsalidaMSGERROR != value)
				{m_anex_fecsalidaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ANEX_NumeroHBL.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ANEX_NumeroHBLOK
		{
			get { return m_anex_numerohblOK; }
			set
			{
				if (m_anex_numerohblOK != value)
				{ m_anex_numerohblOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ANEX_NumeroHBL.
		/// </summary>
		[IgnoreDataMember]
		public String ANEX_NumeroHBLMSGERROR
		{
			get { return m_anex_numerohblMSGERROR; }
			set
			{
				if (m_anex_numerohblMSGERROR != value)
				{m_anex_numerohblMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ANEX_FecDescarga.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ANEX_FecDescargaOK
		{
			get { return m_anex_fecdescargaOK; }
			set
			{
				if (m_anex_fecdescargaOK != value)
				{ m_anex_fecdescargaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ANEX_FecDescarga.
		/// </summary>
		[IgnoreDataMember]
		public String ANEX_FecDescargaMSGERROR
		{
			get { return m_anex_fecdescargaMSGERROR; }
			set
			{
				if (m_anex_fecdescargaMSGERROR != value)
				{m_anex_fecdescargaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ANEX_FecEmbarque.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ANEX_FecEmbarqueOK
		{
			get { return m_anex_fecembarqueOK; }
			set
			{
				if (m_anex_fecembarqueOK != value)
				{ m_anex_fecembarqueOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ANEX_FecEmbarque.
		/// </summary>
		[IgnoreDataMember]
		public String ANEX_FecEmbarqueMSGERROR
		{
			get { return m_anex_fecembarqueMSGERROR; }
			set
			{
				if (m_anex_fecembarqueMSGERROR != value)
				{m_anex_fecembarqueMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ANEX_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ANEX_TipoOK
		{
			get { return m_anex_tipoOK; }
			set
			{
				if (m_anex_tipoOK != value)
				{ m_anex_tipoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ANEX_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public String ANEX_TipoMSGERROR
		{
			get { return m_anex_tipoMSGERROR; }
			set
			{
				if (m_anex_tipoMSGERROR != value)
				{m_anex_tipoMSGERROR = value; }
			}
		}
      /// <summary>
      /// Gets or sets el valor de validación de: ANEX_TipoRectificacion.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ANEX_TipoRectificacionOK
      {
         get { return m_anex_tiporectificacionOK; }
         set
         {
            if (m_anex_tiporectificacionOK != value)
            { m_anex_tiporectificacionOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ANEX_TipoRectificacion.
      /// </summary>
      [IgnoreDataMember]
      public String ANEX_TipoRectificacionMSGERROR
      {
         get { return m_anex_tiporectificacionMSGERROR; }
         set
         {
            if (m_anex_tiporectificacionMSGERROR != value)
            { m_anex_tiporectificacionMSGERROR = value; }
         }
      }
		/// <summary>
		/// Gets or sets el valor de validación de: ANEX_Observaciones.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ANEX_ObservacionesOK
		{
			get { return m_anex_observacionesOK; }
			set
			{
				if (m_anex_observacionesOK != value)
				{ m_anex_observacionesOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ANEX_Observaciones.
		/// </summary>
		[IgnoreDataMember]
		public String ANEX_ObservacionesMSGERROR
		{
			get { return m_anex_observacionesMSGERROR; }
			set
			{
				if (m_anex_observacionesMSGERROR != value)
				{m_anex_observacionesMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ANEX_DondeDice.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ANEX_DondeDiceOK
		{
			get { return m_anex_dondediceOK; }
			set
			{
				if (m_anex_dondediceOK != value)
				{ m_anex_dondediceOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ANEX_DondeDice.
		/// </summary>
		[IgnoreDataMember]
		public String ANEX_DondeDiceMSGERROR
		{
			get { return m_anex_dondediceMSGERROR; }
			set
			{
				if (m_anex_dondediceMSGERROR != value)
				{m_anex_dondediceMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ANEX_DebeDecir.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ANEX_DebeDecirOK
		{
			get { return m_anex_debedecirOK; }
			set
			{
				if (m_anex_debedecirOK != value)
				{ m_anex_debedecirOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ANEX_DebeDecir.
		/// </summary>
		[IgnoreDataMember]
		public String ANEX_DebeDecirMSGERROR
		{
			get { return m_anex_debedecirMSGERROR; }
			set
			{
				if (m_anex_debedecirMSGERROR != value)
				{m_anex_debedecirMSGERROR = value; }
			}
		}
      /// <summary>
      /// Gets or sets el valor de validación de: ANEX_Fundamentos.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ANEX_FundamentosOK
      {
         get { return m_anex_fundamentosOK; }
         set
         {
            if (m_anex_fundamentosOK != value)
            { m_anex_fundamentosOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ANEX_Fundamentos.
      /// </summary>
      [IgnoreDataMember]
      public String ANEX_FundamentosMSGERROR
      {
         get { return m_anex_fundamentosMSGERROR; }
         set
         {
            if (m_anex_fundamentosMSGERROR != value)
            { m_anex_fundamentosMSGERROR = value; }
         }
      }
		/// <summary>
		/// Gets or sets el valor de validación de: ANEX_Documentos.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ANEX_DocumentosOK
		{
			get { return m_anex_documentosOK; }
			set
			{
				if (m_anex_documentosOK != value)
				{ m_anex_documentosOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ANEX_Documentos.
		/// </summary>
		[IgnoreDataMember]
		public String ANEX_DocumentosMSGERROR
		{
			get { return m_anex_documentosMSGERROR; }
			set
			{
				if (m_anex_documentosMSGERROR != value)
				{m_anex_documentosMSGERROR = value; }
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
				ANEX_ItemOK  = true;
				ANEX_ItemMSGERROR  = "";
				if( ANEX_Item == null)
				{
					_isCorrect = false;
					ANEX_ItemOK  = false;
					ANEX_ItemMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Item", "Anexos");
					m_mensajeError += "* Debe ingresar el campo Item" + Environment.NewLine;
				}
				CCOT_NumeroOK  = true;
				CCOT_NumeroMSGERROR  = "";
				if( CCOT_Numero == 0)
				{
					_isCorrect = false;
					CCOT_NumeroOK  = false;
					CCOT_NumeroMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Número Orden de Venta", "Anexos");
               m_mensajeError += "* Debe ingresar el campo Número Orden de Venta" + Environment.NewLine;
				}
				CCOT_TipoOK  = true;
				CCOT_TipoMSGERROR  = "";
				if( CCOT_Tipo == null)
				{
					_isCorrect = false;
					CCOT_TipoOK  = false;
					CCOT_TipoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Tipo Orden de Venta", "Anexos");
					m_mensajeError += "* Debe ingresar el campo Tipo Orden de Venta" + Environment.NewLine;
				}
				ANEX_MroManifiestoOK  = true;
				ANEX_MroManifiestoMSGERROR  = "";
				if( String.IsNullOrEmpty(ANEX_MroManifiesto) )
				{
					_isCorrect = false;
					ANEX_MroManifiestoOK  = false;
					ANEX_MroManifiestoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Nro. Manifiesto", "Anexos");
					m_mensajeError += "* Debe ingresar el campo Nro. Manifiesto" + Environment.NewLine;
				}
				ANEX_NumeroHBLOK  = true;
				ANEX_NumeroHBLMSGERROR  = "";
				if( String.IsNullOrEmpty(ANEX_NumeroHBL) )
				{
					_isCorrect = false;
					ANEX_NumeroHBLOK  = false;
					ANEX_NumeroHBLMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Numero HBL", "Anexos");
					m_mensajeError += "* Debe ingresar el campo HBL" + Environment.NewLine;
				}
				ANEX_TipoOK  = true;
				ANEX_TipoMSGERROR  = "";
				if( String.IsNullOrEmpty(ANEX_Tipo) )
				{
					_isCorrect = false;
					ANEX_TipoOK  = false;
					ANEX_TipoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Tipo", "Anexos");
					m_mensajeError += "* Debe ingresar el campo Tipo" + Environment.NewLine;
				}
            if (ANEX_Tipo == "R")
            {
               ANEX_TipoRectificacionOK = true;
               ANEX_TipoRectificacionMSGERROR = "";
               if (String.IsNullOrEmpty(ANEX_TipoRectificacion))
               {
                  _isCorrect = false;
                  ANEX_TipoRectificacionOK = false;
                  ANEX_TipoRectificacionMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Tipo de Rectificación", "Anexos");
                  m_mensajeError += "* Debe ingresar el campo Tipo de Rectificación" + Environment.NewLine;
               }
               ANEX_ObservacionesOK = true;
               ANEX_ObservacionesMSGERROR = "";
               if (String.IsNullOrEmpty(ANEX_Observaciones))
               {
                  _isCorrect = false;
                  ANEX_ObservacionesOK = false;
                  ANEX_ObservacionesMSGERROR = String.Format("Debe ingresar las {0} del {1}.", "Observaciones", "Anexos");
                  m_mensajeError += "* Debe ingresar el campo Observaciones" + Environment.NewLine;
               }
               ANEX_DondeDiceOK = true;
               ANEX_DondeDiceMSGERROR = "";
               if (String.IsNullOrEmpty(ANEX_DondeDice))
               {
                  _isCorrect = false;
                  ANEX_DondeDiceOK = false;
                  ANEX_DondeDiceMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Donde Dice", "Anexos");
                  m_mensajeError += "* Debe ingresar el campo Donde Dice" + Environment.NewLine;
               }
               ANEX_DebeDecirOK = true;
               ANEX_DebeDecirMSGERROR = "";
               if (String.IsNullOrEmpty(ANEX_DebeDecir))
               {
                  _isCorrect = false;
                  ANEX_DebeDecirOK = false;
                  ANEX_DebeDecirMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Debe Decir", "Anexos");
                  m_mensajeError += "* Debe ingresar el campo Debe Decir" + Environment.NewLine;
               }
            }
				ANEX_DocumentosOK  = true;
				ANEX_DocumentosMSGERROR  = "";
				if( String.IsNullOrEmpty(ANEX_Documentos) )
				{
					_isCorrect = false;
					ANEX_DocumentosOK  = false;
					ANEX_DocumentosMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Documentos", "Anexos");
					m_mensajeError += "* Debe ingresar el campo Documentos" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
