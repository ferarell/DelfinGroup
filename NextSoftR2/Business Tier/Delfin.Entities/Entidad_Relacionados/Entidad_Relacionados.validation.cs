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
   public partial class Entidad_Relacionados
   {
      #region [ Variables Validación ]
      private Boolean m_rela_codigoOK;
      private String m_rela_codigoMSGERROR;
      private Boolean m_entc_codpadreOK;
      private String m_entc_codpadreMSGERROR;
      private Boolean m_entc_codhijoOK;
      private String m_entc_codhijoMSGERROR;
      private Boolean m_cons_tabrgmOK;
      private String m_cons_tabrgmMSGERROR;
      private Boolean m_cons_codrgmOK;
      private String m_cons_codrgmMSGERROR;
      private Boolean m_rela_activoOK;
      private String m_rela_activoMSGERROR;
      private Boolean m_audi_feccreaOK;
      private String m_audi_feccreaMSGERROR;
      private Boolean m_audi_usrcreaOK;
      private String m_audi_usrcreaMSGERROR;
      private Boolean m_audi_fecmodOK;
      private String m_audi_fecmodMSGERROR;
      private Boolean m_audi_usrmodOK;
      private String m_audi_usrmodMSGERROR;
      private Boolean m_tipo_tabtrfOK;
      private String m_tipo_tabtrfMSGERROR;
      private Boolean m_tipo_codtrfOK;
      private String m_tipo_codtrfMSGERROR;
      private Boolean m_rela_tiposOK;
      private String m_rela_tiposMSGERROR;
      private Boolean m_rela_deptemnegociaagenteOK;
      private String m_rela_deptemnegociaagenteMSGERROR;
      private Boolean m_tipe_codpadreOK;
      private String m_tipe_codpadreMSGERROR;
      private Boolean m_tipe_codhijoOK;
      private String m_tipe_codhijoMSGERROR;
      #endregion

      #region [ Propiedades Validación ]
      /// <summary>
      /// Gets or sets el valor de validación de: RELA_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean RELA_CodigoOK
      {
         get { return m_rela_codigoOK; }
         set
         {
            if (m_rela_codigoOK != value)
            { m_rela_codigoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: RELA_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public String RELA_CodigoMSGERROR
      {
         get { return m_rela_codigoMSGERROR; }
         set
         {
            if (m_rela_codigoMSGERROR != value)
            { m_rela_codigoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: ENTC_CodPadre.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ENTC_CodPadreOK
      {
         get { return m_entc_codpadreOK; }
         set
         {
            if (m_entc_codpadreOK != value)
            { m_entc_codpadreOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENTC_CodPadre.
      /// </summary>
      [IgnoreDataMember]
      public String ENTC_CodPadreMSGERROR
      {
         get { return m_entc_codpadreMSGERROR; }
         set
         {
            if (m_entc_codpadreMSGERROR != value)
            { m_entc_codpadreMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: ENTC_CodHijo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ENTC_CodHijoOK
      {
         get { return m_entc_codhijoOK; }
         set
         {
            if (m_entc_codhijoOK != value)
            { m_entc_codhijoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENTC_CodHijo.
      /// </summary>
      [IgnoreDataMember]
      public String ENTC_CodHijoMSGERROR
      {
         get { return m_entc_codhijoMSGERROR; }
         set
         {
            if (m_entc_codhijoMSGERROR != value)
            { m_entc_codhijoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CONS_TabRGM.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CONS_TabRGMOK
      {
         get { return m_cons_tabrgmOK; }
         set
         {
            if (m_cons_tabrgmOK != value)
            { m_cons_tabrgmOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CONS_TabRGM.
      /// </summary>
      [IgnoreDataMember]
      public String CONS_TabRGMMSGERROR
      {
         get { return m_cons_tabrgmMSGERROR; }
         set
         {
            if (m_cons_tabrgmMSGERROR != value)
            { m_cons_tabrgmMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CONS_CodRGM.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CONS_CodRGMOK
      {
         get { return m_cons_codrgmOK; }
         set
         {
            if (m_cons_codrgmOK != value)
            { m_cons_codrgmOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CONS_CodRGM.
      /// </summary>
      [IgnoreDataMember]
      public String CONS_CodRGMMSGERROR
      {
         get { return m_cons_codrgmMSGERROR; }
         set
         {
            if (m_cons_codrgmMSGERROR != value)
            { m_cons_codrgmMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: RELA_Activo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean RELA_ActivoOK
      {
         get { return m_rela_activoOK; }
         set
         {
            if (m_rela_activoOK != value)
            { m_rela_activoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: RELA_Activo.
      /// </summary>
      [IgnoreDataMember]
      public String RELA_ActivoMSGERROR
      {
         get { return m_rela_activoMSGERROR; }
         set
         {
            if (m_rela_activoMSGERROR != value)
            { m_rela_activoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_TabTRF.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPO_TabTRFOK
      {
         get { return m_tipo_tabtrfOK; }
         set
         {
            if (m_tipo_tabtrfOK != value)
            { m_tipo_tabtrfOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_TabTRF.
      /// </summary>
      [IgnoreDataMember]
      public String TIPO_TabTRFMSGERROR
      {
         get { return m_tipo_tabtrfMSGERROR; }
         set
         {
            if (m_tipo_tabtrfMSGERROR != value)
            { m_tipo_tabtrfMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_CodTRF.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPO_CodTRFOK
      {
         get { return m_tipo_codtrfOK; }
         set
         {
            if (m_tipo_codtrfOK != value)
            { m_tipo_codtrfOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_CodTRF.
      /// </summary>
      [IgnoreDataMember]
      public String TIPO_CodTRFMSGERROR
      {
         get { return m_tipo_codtrfMSGERROR; }
         set
         {
            if (m_tipo_codtrfMSGERROR != value)
            { m_tipo_codtrfMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: RELA_Tipos.
      /// </summary>
      [IgnoreDataMember]
      public Boolean RELA_TiposOK
      {
         get { return m_rela_tiposOK; }
         set
         {
            if (m_rela_tiposOK != value)
            { m_rela_tiposOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: RELA_Tipos.
      /// </summary>
      [IgnoreDataMember]
      public String RELA_TiposMSGERROR
      {
         get { return m_rela_tiposMSGERROR; }
         set
         {
            if (m_rela_tiposMSGERROR != value)
            { m_rela_tiposMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: RELA_DepTemNegociaAgente.
      /// </summary>
      [IgnoreDataMember]
      public Boolean RELA_DepTemNegociaAgenteOK
      {
         get { return m_rela_deptemnegociaagenteOK; }
         set
         {
            if (m_rela_deptemnegociaagenteOK != value)
            { m_rela_deptemnegociaagenteOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: RELA_DepTemNegociaAgente.
      /// </summary>
      [IgnoreDataMember]
      public String RELA_DepTemNegociaAgenteMSGERROR
      {
         get { return m_rela_deptemnegociaagenteMSGERROR; }
         set
         {
            if (m_rela_deptemnegociaagenteMSGERROR != value)
            { m_rela_deptemnegociaagenteMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPE_CodPadre.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPE_CodPadreOK
      {
         get { return m_tipe_codpadreOK; }
         set
         {
            if (m_tipe_codpadreOK != value)
            { m_tipe_codpadreOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPE_CodPadre.
      /// </summary>
      [IgnoreDataMember]
      public String TIPE_CodPadreMSGERROR
      {
         get { return m_tipe_codpadreMSGERROR; }
         set
         {
            if (m_tipe_codpadreMSGERROR != value)
            { m_tipe_codpadreMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPE_CodHijo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPE_CodHijoOK
      {
         get { return m_tipe_codhijoOK; }
         set
         {
            if (m_tipe_codhijoOK != value)
            { m_tipe_codhijoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPE_CodHijo.
      /// </summary>
      [IgnoreDataMember]
      public String TIPE_CodHijoMSGERROR
      {
         get { return m_tipe_codhijoMSGERROR; }
         set
         {
            if (m_tipe_codhijoMSGERROR != value)
            { m_tipe_codhijoMSGERROR = value; }
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
            RELA_CodigoOK = true;
            RELA_CodigoMSGERROR = "";
            if (RELA_Codigo == 0)
            {
               _isCorrect = false;
               RELA_CodigoOK = false;
               RELA_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de Relación", "Entidad Relacionados");
               m_mensajeError += "* Debe ingresar el campo Código de Relación" + Environment.NewLine;
            }
            RELA_ActivoOK = true;
            RELA_ActivoMSGERROR = "";
            if (RELA_Activo == null)
            {
               _isCorrect = false;
               RELA_ActivoOK = false;
               RELA_ActivoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "RELA_Activo", "Entidad_Relacionados");
               m_mensajeError += "* Debe ingresar el campo RELA_Activo" + Environment.NewLine;
            }
            RELA_TiposOK = true;
            RELA_TiposMSGERROR = "";
            if (String.IsNullOrEmpty(RELA_Tipos))
            {
               _isCorrect = false;
               RELA_TiposOK = false;
               RELA_TiposMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de Relación", "Entidad Relacionados");
               m_mensajeError += "* Debe ingresar el campo Tipo de Relación de Entidad Relacionados" + Environment.NewLine;
            }

            TIPE_CodHijoOK = true;
            TIPE_CodHijoMSGERROR = "";
            if (TIPE_CodHijo == null)
            {
               _isCorrect = false;
               TIPE_CodHijoOK = false;
               TIPE_CodHijoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de entidad Relacionada", "Entidad Relacionados");
               m_mensajeError += "* Debe ingresar el campo Tipo de entidad Relacionada de Entidad Relacionados" + Environment.NewLine;
            }

            ENTC_CodHijoOK = true;
            ENTC_CodHijoMSGERROR = "";
            if (ENTC_CodHijo == null)
            {
               _isCorrect = false;
               ENTC_CodHijoOK = false;
               ENTC_CodHijoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Registro Entidad Relacionada", "Entidad_Relacionados");
               m_mensajeError += "* Debe ingresar el campo Registro Entidad Relacionada" + Environment.NewLine;
            }

            //if(RELA_Tipos.Equals("CON"))
            //{
               CONS_CodRGMOK = true;
               CONS_CodRGMMSGERROR = "";
               if (CONS_CodRGM == null)
               {
                  _isCorrect = false;
                  CONS_CodRGMOK = false;
                  CONS_CodRGMMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Régimen", "Entidad_Relacionados");
                  m_mensajeError += "* Debe ingresar el campo Régimen" + Environment.NewLine;
               }
            //}

            switch (RELA_Tipos)
            {
               case "CON":
               case "CSE":
               case "VEN":
                  TIPO_CodTRFOK = true;
                  TIPO_CodTRFMSGERROR = "";
                  if (TIPO_CodTRF == null)
                  {
                     _isCorrect = false;
                     TIPO_CodTRFOK = false;
                     TIPO_CodTRFMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de tráfico", "Entidad_Relacionados");
                     m_mensajeError += "* Debe ingresar el campo Tipo de tráfico" + Environment.NewLine;
                  }
                  break;
               case "DVA":
               case "AGE":
               case "DTE":
                  TIPO_CodTRFOK = true;
                  TIPO_CodTRFMSGERROR = "";
                  break;

            }

            return _isCorrect;
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
