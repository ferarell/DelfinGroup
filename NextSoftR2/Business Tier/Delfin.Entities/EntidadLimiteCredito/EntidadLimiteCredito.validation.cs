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
   public partial class EntidadLimiteCredito
   {
      #region [ Variables Validación ]
      private Boolean m_entc_codigoOK;
      private String m_entc_codigoMSGERROR;
      private Boolean m_tipe_codigoOK;
      private String m_tipe_codigoMSGERROR;
      private Boolean m_enli_tiposOK;
      private String m_enli_tiposMSGERROR;
      private Boolean m_enli_montoOK;
      private String m_enli_montoMSGERROR;
      private Boolean m_enli_diasduracionOK;
      private String m_enli_diasduracionMSGERROR;
      private Boolean m_enli_fechaOK;
      private String m_enli_fechaMSGERROR;
      private Boolean m_enli_notasOK;
      private String m_enli_notasMSGERROR;
      private Boolean m_enli_fecinicioOK;
      private String m_enli_fecinicioMSGERROR;
      private Boolean m_enli_fecvencimientoOK;
      private String m_enli_fecvencimientoMSGERROR;
      private Boolean m_tipo_tabmndOK;
      private String m_tipo_tabmndMSGERROR;
      private Boolean m_tipo_codmndOK;
      private String m_tipo_codmndMSGERROR;
      private Boolean m_audi_usrcreaOK;
      private String m_audi_usrcreaMSGERROR;
      private Boolean m_audi_usrmodOK;
      private String m_audi_usrmodMSGERROR;
      private Boolean m_audi_feccreaOK;
      private String m_audi_feccreaMSGERROR;
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
            { m_entc_codigoMSGERROR = value; }
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
      /// Gets or sets el valor de validación de: ENLI_Tipos.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ENLI_TiposOK
      {
         get { return m_enli_tiposOK; }
         set
         {
            if (m_enli_tiposOK != value)
            { m_enli_tiposOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENLI_Tipos.
      /// </summary>
      [IgnoreDataMember]
      public String ENLI_TiposMSGERROR
      {
         get { return m_enli_tiposMSGERROR; }
         set
         {
            if (m_enli_tiposMSGERROR != value)
            { m_enli_tiposMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: ENLI_Monto.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ENLI_MontoOK
      {
         get { return m_enli_montoOK; }
         set
         {
            if (m_enli_montoOK != value)
            { m_enli_montoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENLI_Monto.
      /// </summary>
      [IgnoreDataMember]
      public String ENLI_MontoMSGERROR
      {
         get { return m_enli_montoMSGERROR; }
         set
         {
            if (m_enli_montoMSGERROR != value)
            { m_enli_montoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: ENLI_DiasDuracion.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ENLI_DiasDuracionOK
      {
         get { return m_enli_diasduracionOK; }
         set
         {
            if (m_enli_diasduracionOK != value)
            { m_enli_diasduracionOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENLI_DiasDuracion.
      /// </summary>
      [IgnoreDataMember]
      public String ENLI_DiasDuracionMSGERROR
      {
         get { return m_enli_diasduracionMSGERROR; }
         set
         {
            if (m_enli_diasduracionMSGERROR != value)
            { m_enli_diasduracionMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: ENLI_Fecha.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ENLI_FechaOK
      {
         get { return m_enli_fechaOK; }
         set
         {
            if (m_enli_fechaOK != value)
            { m_enli_fechaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENLI_Fecha.
      /// </summary>
      [IgnoreDataMember]
      public String ENLI_FechaMSGERROR
      {
         get { return m_enli_fechaMSGERROR; }
         set
         {
            if (m_enli_fechaMSGERROR != value)
            { m_enli_fechaMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: ENLI_Notas.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ENLI_NotasOK
      {
         get { return m_enli_notasOK; }
         set
         {
            if (m_enli_notasOK != value)
            { m_enli_notasOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENLI_Notas.
      /// </summary>
      [IgnoreDataMember]
      public String ENLI_NotasMSGERROR
      {
         get { return m_enli_notasMSGERROR; }
         set
         {
            if (m_enli_notasMSGERROR != value)
            { m_enli_notasMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: ENLI_FecInicio.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ENLI_FecInicioOK
      {
         get { return m_enli_fecinicioOK; }
         set
         {
            if (m_enli_fecinicioOK != value)
            { m_enli_fecinicioOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENLI_FecInicio.
      /// </summary>
      [IgnoreDataMember]
      public String ENLI_FecInicioMSGERROR
      {
         get { return m_enli_fecinicioMSGERROR; }
         set
         {
            if (m_enli_fecinicioMSGERROR != value)
            { m_enli_fecinicioMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: ENLI_FecVencimiento.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ENLI_FecVencimientoOK
      {
         get { return m_enli_fecvencimientoOK; }
         set
         {
            if (m_enli_fecvencimientoOK != value)
            { m_enli_fecvencimientoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENLI_FecVencimiento.
      /// </summary>
      [IgnoreDataMember]
      public String ENLI_FecVencimientoMSGERROR
      {
         get { return m_enli_fecvencimientoMSGERROR; }
         set
         {
            if (m_enli_fecvencimientoMSGERROR != value)
            { m_enli_fecvencimientoMSGERROR = value; }
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
            { m_tipo_tabmndMSGERROR = value; }
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
            { m_tipo_codmndMSGERROR = value; }
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
            ENTC_CodigoOK = true;
            ENTC_CodigoMSGERROR = "";
            //if( ENTC_Codigo == 0)
            //{
            //   _isCorrect = false;
            //   ENTC_CodigoOK  = false;
            //   ENTC_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ENTC_Codigo", "Entidad de Limite Credito");
            //   m_mensajeError += "* Debe ingresar el campo ENTC_Codigo" + Environment.NewLine;
            //}
            TIPE_CodigoOK = true;
            TIPE_CodigoMSGERROR = "";
            //if( TIPE_Codigo == 0)
            //{
            //   _isCorrect = false;
            //   TIPE_CodigoOK  = false;
            //   TIPE_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPE_Codigo", "Entidad de Limite Credito");
            //   m_mensajeError += "* Debe ingresar el campo TIPE_Codigo" + Environment.NewLine;
            //}

            ENLI_DiasDuracionOK = true;
            ENLI_DiasDuracionMSGERROR = "";

            ENLI_FecInicioOK = true;
            ENLI_FecInicioMSGERROR = "";

            ENLI_FecVencimientoOK = true;
            ENLI_FecVencimientoMSGERROR = "";

            ENLI_FechaOK = true;
            ENLI_FechaMSGERROR = "";
            switch (m_tipe_codigo)
            {
               case 1:
                  if (ENLI_DiasDuracion == null)
                  {
                     _isCorrect = false;
                     ENLI_DiasDuracionOK = false;
                     ENLI_DiasDuracionMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Dias de Duración", "Entidad de Limite Credito");
                     m_mensajeError += "* Debe ingresar el campo Dias de Duración" + Environment.NewLine;
                  }
                  if (ENLI_Fecha == null)
                  {
                     _isCorrect = false;
                     ENLI_FechaOK = false;
                     ENLI_FechaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Fecha", "Entidad de Limite Credito");
                     m_mensajeError += "* Debe ingresar el campo Fecha" + Environment.NewLine;
                  }
                  break;
               case 2:
                  if (ENLI_FecInicio == null)
                  {
                     _isCorrect = false;
                     ENLI_FecInicioOK = false;
                     ENLI_FecInicioMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Fecha de Inicio", "Entidad de Limite Credito");
                     m_mensajeError += "* Debe ingresar el campo Fecha de Inicio" + Environment.NewLine;
                  }
                  if (ENLI_FecVencimiento == null)
                  {
                     _isCorrect = false;
                     ENLI_FecVencimientoOK = false;
                     ENLI_FecVencimientoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Fecha de Vencimiento", "Entidad de Limite Credito");
                     m_mensajeError += "* Debe ingresar el campo Fecha de Vencimiento" + Environment.NewLine;
                  }
                  break;
            }
            
          

            ENLI_TiposOK = true;
            ENLI_TiposMSGERROR = "";
            if (String.IsNullOrEmpty(ENLI_Tipos))
            {
               _isCorrect = false;
               ENLI_TiposOK = false;
               ENLI_TiposMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo", "Entidad de Limite Credito");
               m_mensajeError += "* Debe ingresar el campo Tipo" + Environment.NewLine;
            }
            ENLI_MontoOK = true;
            ENLI_MontoMSGERROR = "";
            if (ENLI_Monto == null)
            {
               _isCorrect = false;
               ENLI_MontoOK = false;
               ENLI_MontoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Monto", "Entidad de Limite Credito");
               m_mensajeError += "* Debe ingresar el campo Monto" + Environment.NewLine;
            }

            TIPO_TabMNDOK = true;
            TIPO_TabMNDMSGERROR = "";
            //if (String.IsNullOrEmpty(TIPO_TabMND))
            //{
            //   _isCorrect = false;
            //   TIPO_TabMNDOK = false;
            //   TIPO_TabMNDMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Moneda", "Entidad de Limite Credito");
            //   m_mensajeError += "* Debe ingresar el campo Moneda" + Environment.NewLine;
            //}
            TIPO_CodMNDOK = true;
            TIPO_CodMNDMSGERROR = "";
            if (String.IsNullOrEmpty(TIPO_CodMND))
            {
               _isCorrect = false;
               TIPO_CodMNDOK = false;
               TIPO_CodMNDMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Moneda", "Entidad de Limite Credito");
               m_mensajeError += "* Debe ingresar el campo Moneda" + Environment.NewLine;
            }
            return _isCorrect;
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
