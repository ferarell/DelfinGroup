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
   public partial class Transferencia
   {
      #region [ Variables Validación ]
      private Boolean m_empr_codigoOK;
      private String m_empr_codigoMSGERROR;
      private Boolean m_tran_codigoOK;
      private String m_tran_codigoMSGERROR;
      private Boolean m_tran_fechaOK;
      private String m_tran_fechaMSGERROR;
      private Boolean m_tran_glosaOK;
      private String m_tran_glosaMSGERROR;
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
            { m_empr_codigoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TRAN_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TRAN_CodigoOK
      {
         get { return m_tran_codigoOK; }
         set
         {
            if (m_tran_codigoOK != value)
            { m_tran_codigoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TRAN_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public String TRAN_CodigoMSGERROR
      {
         get { return m_tran_codigoMSGERROR; }
         set
         {
            if (m_tran_codigoMSGERROR != value)
            { m_tran_codigoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TRAN_Fecha.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TRAN_FechaOK
      {
         get { return m_tran_fechaOK; }
         set
         {
            if (m_tran_fechaOK != value)
            { m_tran_fechaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TRAN_Fecha.
      /// </summary>
      [IgnoreDataMember]
      public String TRAN_FechaMSGERROR
      {
         get { return m_tran_fechaMSGERROR; }
         set
         {
            if (m_tran_fechaMSGERROR != value)
            { m_tran_fechaMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TRAN_Glosa.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TRAN_GlosaOK
      {
         get { return m_tran_glosaOK; }
         set
         {
            if (m_tran_glosaOK != value)
            { m_tran_glosaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TRAN_Glosa.
      /// </summary>
      [IgnoreDataMember]
      public String TRAN_GlosaMSGERROR
      {
         get { return m_tran_glosaMSGERROR; }
         set
         {
            if (m_tran_glosaMSGERROR != value)
            { m_tran_glosaMSGERROR = value; }
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
            EMPR_CodigoOK = true;
            EMPR_CodigoMSGERROR = "";
            if (EMPR_Codigo == null)
            {
               _isCorrect = false;
               EMPR_CodigoOK = false;
               EMPR_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "Transferencia");
               m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
            }
            TRAN_CodigoOK = true;
            TRAN_CodigoMSGERROR = "";
            //if( TRAN_Codigo == 0)
            //{
            //   _isCorrect = false;
            //   TRAN_CodigoOK  = false;
            //   TRAN_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TRAN_Codigo", "Transferencia");
            //   m_mensajeError += "* Debe ingresar el campo TRAN_Codigo" + Environment.NewLine;
            //}
            TRAN_FechaOK = true;
            TRAN_FechaMSGERROR = "";
            if (TRAN_Fecha == null)
            {
               _isCorrect = false;
               TRAN_FechaOK = false;
               TRAN_FechaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Fecha", "Transferencia");
               m_mensajeError += "* Debe ingresar el campo Fecha" + Environment.NewLine;
            }
            TRAN_GlosaOK = true;
            TRAN_GlosaMSGERROR = "";
            if (String.IsNullOrEmpty(TRAN_Glosa))
            {
               _isCorrect = false;
               TRAN_GlosaOK = false;
               TRAN_GlosaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Glosa", "Transferencia");
               m_mensajeError += "* Debe ingresar el campo Glosa" + Environment.NewLine;
            }
            if (Diferencia != 0)
            {
               _isCorrect = false;
               m_mensajeError += "* No debe haber diferencia entre Debe y Haber en S/." + Environment.NewLine;
            }

            if (ListIngresos != null && ListEgresos != null)
            {
               if (ListIngresos.Count == 0 || ListEgresos.Count == 0)
               {
                  _isCorrect = false;
                  m_mensajeError += "* Debe ingresar registros en Ingresos / Egresos" + Environment.NewLine;
               }
            }
            else
            {
               _isCorrect = false; 
               m_mensajeError += "* Debe ingresar registros en Ingresos / Egresos" + Environment.NewLine;
            }

            return _isCorrect;
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
