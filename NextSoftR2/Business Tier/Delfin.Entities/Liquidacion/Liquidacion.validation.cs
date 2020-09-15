using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using Infrastructure.Aspect.Collections;
using Infrastructure.Aspect;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.Entities
{
	public partial class Liquidacion
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_liqu_codigoOK;
		private String m_liqu_codigoMSGERROR;
		private Boolean m_liqu_numeroOK;
		private String m_liqu_numeroMSGERROR;
		private Boolean m_liqu_glosaOK;
		private String m_liqu_glosaMSGERROR;
		private Boolean m_liqu_fechaOK;
		private String m_liqu_fechaMSGERROR;
		private Boolean m_liqu_estadoOK;
		private String m_liqu_estadoMSGERROR;
		private Boolean m_liqu_usraprobadoOK;
		private String m_liqu_usraprobadoMSGERROR;
		private Boolean m_liqu_fecaprobadoOK;
		private String m_liqu_fecaprobadoMSGERROR;
		private Boolean m_liqu_usranuladoOK;
		private String m_liqu_usranuladoMSGERROR;
		private Boolean m_liqu_fecanuladoOK;
		private String m_liqu_fecanuladoMSGERROR;
      private Boolean m_tipe_codigoOK;
      private String m_tipe_codigoMSGERROR;
      private Boolean m_entc_codigoOK;
      private String m_entc_codigoMSGERROR;
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
		/// Gets or sets el valor de validación de: LIQU_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LIQU_CodigoOK
		{
			get { return m_liqu_codigoOK; }
			set
			{
				if (m_liqu_codigoOK != value)
				{ m_liqu_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LIQU_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String LIQU_CodigoMSGERROR
		{
			get { return m_liqu_codigoMSGERROR; }
			set
			{
				if (m_liqu_codigoMSGERROR != value)
				{m_liqu_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LIQU_Numero.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LIQU_NumeroOK
		{
			get { return m_liqu_numeroOK; }
			set
			{
				if (m_liqu_numeroOK != value)
				{ m_liqu_numeroOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LIQU_Numero.
		/// </summary>
		[IgnoreDataMember]
		public String LIQU_NumeroMSGERROR
		{
			get { return m_liqu_numeroMSGERROR; }
			set
			{
				if (m_liqu_numeroMSGERROR != value)
				{m_liqu_numeroMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LIQU_Glosa.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LIQU_GlosaOK
		{
			get { return m_liqu_glosaOK; }
			set
			{
				if (m_liqu_glosaOK != value)
				{ m_liqu_glosaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LIQU_Glosa.
		/// </summary>
		[IgnoreDataMember]
		public String LIQU_GlosaMSGERROR
		{
			get { return m_liqu_glosaMSGERROR; }
			set
			{
				if (m_liqu_glosaMSGERROR != value)
				{m_liqu_glosaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LIQU_Fecha.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LIQU_FechaOK
		{
			get { return m_liqu_fechaOK; }
			set
			{
				if (m_liqu_fechaOK != value)
				{ m_liqu_fechaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LIQU_Fecha.
		/// </summary>
		[IgnoreDataMember]
		public String LIQU_FechaMSGERROR
		{
			get { return m_liqu_fechaMSGERROR; }
			set
			{
				if (m_liqu_fechaMSGERROR != value)
				{m_liqu_fechaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LIQU_Estado.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LIQU_EstadoOK
		{
			get { return m_liqu_estadoOK; }
			set
			{
				if (m_liqu_estadoOK != value)
				{ m_liqu_estadoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LIQU_Estado.
		/// </summary>
		[IgnoreDataMember]
		public String LIQU_EstadoMSGERROR
		{
			get { return m_liqu_estadoMSGERROR; }
			set
			{
				if (m_liqu_estadoMSGERROR != value)
				{m_liqu_estadoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LIQU_UsrAprobado.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LIQU_UsrAprobadoOK
		{
			get { return m_liqu_usraprobadoOK; }
			set
			{
				if (m_liqu_usraprobadoOK != value)
				{ m_liqu_usraprobadoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LIQU_UsrAprobado.
		/// </summary>
		[IgnoreDataMember]
		public String LIQU_UsrAprobadoMSGERROR
		{
			get { return m_liqu_usraprobadoMSGERROR; }
			set
			{
				if (m_liqu_usraprobadoMSGERROR != value)
				{m_liqu_usraprobadoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LIQU_FecAprobado.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LIQU_FecAprobadoOK
		{
			get { return m_liqu_fecaprobadoOK; }
			set
			{
				if (m_liqu_fecaprobadoOK != value)
				{ m_liqu_fecaprobadoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LIQU_FecAprobado.
		/// </summary>
		[IgnoreDataMember]
		public String LIQU_FecAprobadoMSGERROR
		{
			get { return m_liqu_fecaprobadoMSGERROR; }
			set
			{
				if (m_liqu_fecaprobadoMSGERROR != value)
				{m_liqu_fecaprobadoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LIQU_UsrAnulado.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LIQU_UsrAnuladoOK
		{
			get { return m_liqu_usranuladoOK; }
			set
			{
				if (m_liqu_usranuladoOK != value)
				{ m_liqu_usranuladoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LIQU_UsrAnulado.
		/// </summary>
		[IgnoreDataMember]
		public String LIQU_UsrAnuladoMSGERROR
		{
			get { return m_liqu_usranuladoMSGERROR; }
			set
			{
				if (m_liqu_usranuladoMSGERROR != value)
				{m_liqu_usranuladoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LIQU_FecAnulado.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LIQU_FecAnuladoOK
		{
			get { return m_liqu_fecanuladoOK; }
			set
			{
				if (m_liqu_fecanuladoOK != value)
				{ m_liqu_fecanuladoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LIQU_FecAnulado.
		/// </summary>
		[IgnoreDataMember]
		public String LIQU_FecAnuladoMSGERROR
		{
			get { return m_liqu_fecanuladoMSGERROR; }
			set
			{
				if (m_liqu_fecanuladoMSGERROR != value)
				{m_liqu_fecanuladoMSGERROR = value; }
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
            { m_tipe_codigoMSGERROR = value; }
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
            { m_entc_codigoMSGERROR = value; }
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
            //   EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "Liquidacion");
            //   m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
            //}
				LIQU_CodigoOK  = true;
				LIQU_CodigoMSGERROR  = "";
            //if( String.IsNullOrEmpty(LIQU_Codigo) )
            //{
            //   _isCorrect = false;
            //   LIQU_CodigoOK  = false;
            //   LIQU_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LIQU_Codigo", "Liquidacion");
            //   m_mensajeError += "* Debe ingresar el campo LIQU_Codigo" + Environment.NewLine;
            //}
				LIQU_NumeroOK  = true;
				LIQU_NumeroMSGERROR  = "";
            //if( LIQU_Numero == 0)
            //{
            //   _isCorrect = false;
            //   LIQU_NumeroOK  = false;
            //   LIQU_NumeroMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LIQU_Numero", "Liquidacion");
            //   m_mensajeError += "* Debe ingresar el campo LIQU_Numero" + Environment.NewLine;
            //}
				LIQU_EstadoOK  = true;
				LIQU_EstadoMSGERROR  = "";
				if( String.IsNullOrEmpty(LIQU_Estado) )
				{
					_isCorrect = false;
					LIQU_EstadoOK  = false;
					LIQU_EstadoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Estado", "Liquidacion");
               m_mensajeError += "* Debe ingresar el campo Estado de la Liquidación" + Environment.NewLine;
				}
            LIQU_FechaOK = true;
            LIQU_FechaMSGERROR = "";
            if (LIQU_Fecha == null)
            {
               _isCorrect = false;
               LIQU_FechaOK = false;
               LIQU_FechaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Fecha", "Liquidacion");
               m_mensajeError += "* Debe ingresar el campo Fecha de Liquidación" + Environment.NewLine;
            }
            LIQU_GlosaOK = true;
            LIQU_GlosaMSGERROR = "";
            if (String.IsNullOrEmpty(LIQU_Glosa))
            {
               _isCorrect = false;
               LIQU_GlosaOK = false;
               LIQU_GlosaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Glosa", "Liquidacion");
               m_mensajeError += "* Debe ingresar el campo Glosa" + Environment.NewLine;
            }
            ENTC_CodigoOK = true;
            ENTC_CodigoMSGERROR = "";
            if (ENTC_Codigo == null)
            {
               _isCorrect = false;
               ENTC_CodigoOK = false;
               ENTC_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Agente", "Liquidacion");
               m_mensajeError += "* Debe ingresar el campo Agente" + Environment.NewLine;
            }

            if (ListCtaCte.Where(Reg => Reg.Seleccionar).ToObservableCollection().Count == 0)
            {
               _isCorrect = false;
               m_mensajeError += "* Se debe seleccionar al menos un registro para poder graba una liquidación." + Environment.NewLine;
            }

				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
