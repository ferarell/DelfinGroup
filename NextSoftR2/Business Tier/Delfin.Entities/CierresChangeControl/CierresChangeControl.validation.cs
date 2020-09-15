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
   public partial class CierresChangeControl
   {
      #region [ Variables Validación ]
      private Boolean m_empr_codigoOK;
      private String m_empr_codigoMSGERROR;
      private Boolean m_sucr_codigoOK;
      private String m_sucr_codigoMSGERROR;
      private Boolean m_chan_anioOK;
      private String m_chan_anioMSGERROR;
      private Boolean m_chan_mesOK;
      private String m_chan_mesMSGERROR;
      private Boolean m_chan_estadoOK;
      private String m_chan_estadoMSGERROR;
      private Boolean m_chan_usuariocierreOK;
      private String m_chan_usuariocierreMSGERROR;
      private Boolean m_chan_fechacierreOK;
      private String m_chan_fechacierreMSGERROR;
      private Boolean m_chan_usuarioaperturaOK;
      private String m_chan_usuarioaperturaMSGERROR;
      private Boolean m_chan_fechaaperturaOK;
      private String m_chan_fechaaperturaMSGERROR;
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
      /// Gets or sets el valor de validación de: SUCR_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean SUCR_CodigoOK
      {
         get { return m_sucr_codigoOK; }
         set
         {
            if (m_sucr_codigoOK != value)
            { m_sucr_codigoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: SUCR_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public String SUCR_CodigoMSGERROR
      {
         get { return m_sucr_codigoMSGERROR; }
         set
         {
            if (m_sucr_codigoMSGERROR != value)
            { m_sucr_codigoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CHAN_Anio.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CHAN_AnioOK
      {
         get { return m_chan_anioOK; }
         set
         {
            if (m_chan_anioOK != value)
            { m_chan_anioOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CHAN_Anio.
      /// </summary>
      [IgnoreDataMember]
      public String CHAN_AnioMSGERROR
      {
         get { return m_chan_anioMSGERROR; }
         set
         {
            if (m_chan_anioMSGERROR != value)
            { m_chan_anioMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CHAN_Mes.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CHAN_MesOK
      {
         get { return m_chan_mesOK; }
         set
         {
            if (m_chan_mesOK != value)
            { m_chan_mesOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CHAN_Mes.
      /// </summary>
      [IgnoreDataMember]
      public String CHAN_MesMSGERROR
      {
         get { return m_chan_mesMSGERROR; }
         set
         {
            if (m_chan_mesMSGERROR != value)
            { m_chan_mesMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CHAN_Estado.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CHAN_EstadoOK
      {
         get { return m_chan_estadoOK; }
         set
         {
            if (m_chan_estadoOK != value)
            { m_chan_estadoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CHAN_Estado.
      /// </summary>
      [IgnoreDataMember]
      public String CHAN_EstadoMSGERROR
      {
         get { return m_chan_estadoMSGERROR; }
         set
         {
            if (m_chan_estadoMSGERROR != value)
            { m_chan_estadoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CHAN_UsuarioCierre.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CHAN_UsuarioCierreOK
      {
         get { return m_chan_usuariocierreOK; }
         set
         {
            if (m_chan_usuariocierreOK != value)
            { m_chan_usuariocierreOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CHAN_UsuarioCierre.
      /// </summary>
      [IgnoreDataMember]
      public String CHAN_UsuarioCierreMSGERROR
      {
         get { return m_chan_usuariocierreMSGERROR; }
         set
         {
            if (m_chan_usuariocierreMSGERROR != value)
            { m_chan_usuariocierreMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CHAN_FechaCierre.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CHAN_FechaCierreOK
      {
         get { return m_chan_fechacierreOK; }
         set
         {
            if (m_chan_fechacierreOK != value)
            { m_chan_fechacierreOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CHAN_FechaCierre.
      /// </summary>
      [IgnoreDataMember]
      public String CHAN_FechaCierreMSGERROR
      {
         get { return m_chan_fechacierreMSGERROR; }
         set
         {
            if (m_chan_fechacierreMSGERROR != value)
            { m_chan_fechacierreMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CHAN_UsuarioApertura.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CHAN_UsuarioAperturaOK
      {
         get { return m_chan_usuarioaperturaOK; }
         set
         {
            if (m_chan_usuarioaperturaOK != value)
            { m_chan_usuarioaperturaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CHAN_UsuarioApertura.
      /// </summary>
      [IgnoreDataMember]
      public String CHAN_UsuarioAperturaMSGERROR
      {
         get { return m_chan_usuarioaperturaMSGERROR; }
         set
         {
            if (m_chan_usuarioaperturaMSGERROR != value)
            { m_chan_usuarioaperturaMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CHAN_FechaApertura.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CHAN_FechaAperturaOK
      {
         get { return m_chan_fechaaperturaOK; }
         set
         {
            if (m_chan_fechaaperturaOK != value)
            { m_chan_fechaaperturaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CHAN_FechaApertura.
      /// </summary>
      [IgnoreDataMember]
      public String CHAN_FechaAperturaMSGERROR
      {
         get { return m_chan_fechaaperturaMSGERROR; }
         set
         {
            if (m_chan_fechaaperturaMSGERROR != value)
            { m_chan_fechaaperturaMSGERROR = value; }
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
            if (EMPR_Codigo <= 0)
            {
               _isCorrect = false;
               EMPR_CodigoOK = false;
               EMPR_CodigoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Empresa", "Cierre de Change Control");
               m_mensajeError += "* Debe ingresar el campo Empresa" + Environment.NewLine;
            }
            SUCR_CodigoOK = true;
            SUCR_CodigoMSGERROR = "";
            if (SUCR_Codigo <= 0)
            {
               _isCorrect = false;
               SUCR_CodigoOK = false;
               SUCR_CodigoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Sucursal", "Cierre de Change Control");
               m_mensajeError += "* Debe ingresar el campo Sucursal" + Environment.NewLine;
            }
            CHAN_AnioOK = true;
            CHAN_AnioMSGERROR = "";
            if (CHAN_Anio <= 0)
            {
               _isCorrect = false;
               CHAN_AnioOK = false;
               CHAN_AnioMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Año", "Cierre de Change Control");
               m_mensajeError += "* Debe ingresar el campo Año" + Environment.NewLine;
            }
            CHAN_MesOK = true;
            CHAN_MesMSGERROR = "";
            if (CHAN_Mes <= 0)
            {
               _isCorrect = false;
               CHAN_MesOK = false;
               CHAN_MesMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Mes", "Cierre de Change Control");
               m_mensajeError += "* Debe ingresar el campo Mes" + Environment.NewLine;
            }
            CHAN_EstadoOK = true;
            CHAN_EstadoMSGERROR = "";
            if (String.IsNullOrEmpty(CHAN_Estado))
            {
               _isCorrect = false;
               CHAN_EstadoOK = false;
               CHAN_EstadoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Estado", "Cierre de Change Control");
               m_mensajeError += "* Debe ingresar el campo Estado" + Environment.NewLine;
            }
            return _isCorrect;
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}