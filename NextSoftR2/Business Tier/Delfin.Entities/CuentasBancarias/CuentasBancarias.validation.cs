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
   public partial class CuentasBancarias
   {
      #region [ Variables Validación ]
      private Boolean m_empr_codigoOK;
      private String m_empr_codigoMSGERROR;
      private Boolean m_cuba_codigoOK;
      private String m_cuba_codigoMSGERROR;
      private Boolean m_sucr_codigoOK;
      private String m_sucr_codigoMSGERROR;
      private Boolean m_tipo_tabbcoOK;
      private String m_tipo_tabbcoMSGERROR;
      private Boolean m_tipo_codbcoOK;
      private String m_tipo_codbcoMSGERROR;
      private Boolean m_tipo_tabmndOK;
      private String m_tipo_tabmndMSGERROR;
      private Boolean m_tipo_codmndOK;
      private String m_tipo_codmndMSGERROR;
      private Boolean m_cuba_nrocuentaOK;
      private String m_cuba_nrocuentaMSGERROR;
      private Boolean m_cuba_tipocuentaOK;
      private String m_cuba_tipocuentaMSGERROR;
      private Boolean m_cuba_cuenpuenteOK;
      private String m_cuba_cuenpuenteMSGERROR;
      private Boolean m_cuba_cuencontableOK;
      private String m_cuba_cuencontableMSGERROR;
      private Boolean m_cuba_ctaporcobrarOK;
      private String m_cuba_ctaporcobrarMSGERROR;
      private Boolean m_cuba_ctaporpagarOK;
      private String m_cuba_ctaporpagarMSGERROR;
      private Boolean m_cuba_fechacierreOK;
      private String m_cuba_fechacierreMSGERROR;
      private Boolean m_cuba_bloqueoOK;
      private String m_cuba_bloqueoMSGERROR;
      private Boolean m_cuba_permchequeblancoOK;
      private String m_cuba_permchequeblancoMSGERROR;
      private Boolean m_cuba_permimprautomaticaOK;
      private String m_cuba_permimprautomaticaMSGERROR;
      private Boolean m_cuba_codagenciaOK;
      private String m_cuba_codagenciaMSGERROR;
      private Boolean m_cuba_mediovirtualOK;
      private String m_cuba_mediovirtualMSGERROR;
      private Boolean m_cuba_descripcionOK;
      private String m_cuba_descripcionMSGERROR;
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
      /// Gets or sets el valor de validación de: CUBA_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CUBA_CodigoOK
      {
         get { return m_cuba_codigoOK; }
         set
         {
            if (m_cuba_codigoOK != value)
            { m_cuba_codigoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CUBA_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public String CUBA_CodigoMSGERROR
      {
         get { return m_cuba_codigoMSGERROR; }
         set
         {
            if (m_cuba_codigoMSGERROR != value)
            { m_cuba_codigoMSGERROR = value; }
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
      /// Gets or sets el valor de validación de: TIPO_TabBCO.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPO_TabBCOOK
      {
         get { return m_tipo_tabbcoOK; }
         set
         {
            if (m_tipo_tabbcoOK != value)
            { m_tipo_tabbcoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_TabBCO.
      /// </summary>
      [IgnoreDataMember]
      public String TIPO_TabBCOMSGERROR
      {
         get { return m_tipo_tabbcoMSGERROR; }
         set
         {
            if (m_tipo_tabbcoMSGERROR != value)
            { m_tipo_tabbcoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_CodBCO.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPO_CodBCOOK
      {
         get { return m_tipo_codbcoOK; }
         set
         {
            if (m_tipo_codbcoOK != value)
            { m_tipo_codbcoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_CodBCO.
      /// </summary>
      [IgnoreDataMember]
      public String TIPO_CodBCOMSGERROR
      {
         get { return m_tipo_codbcoMSGERROR; }
         set
         {
            if (m_tipo_codbcoMSGERROR != value)
            { m_tipo_codbcoMSGERROR = value; }
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
      /// <summary>
      /// Gets or sets el valor de validación de: CUBA_NroCuenta.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CUBA_NroCuentaOK
      {
         get { return m_cuba_nrocuentaOK; }
         set
         {
            if (m_cuba_nrocuentaOK != value)
            { m_cuba_nrocuentaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CUBA_NroCuenta.
      /// </summary>
      [IgnoreDataMember]
      public String CUBA_NroCuentaMSGERROR
      {
         get { return m_cuba_nrocuentaMSGERROR; }
         set
         {
            if (m_cuba_nrocuentaMSGERROR != value)
            { m_cuba_nrocuentaMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CUBA_TipoCuenta.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CUBA_TipoCuentaOK
      {
         get { return m_cuba_tipocuentaOK; }
         set
         {
            if (m_cuba_tipocuentaOK != value)
            { m_cuba_tipocuentaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CUBA_TipoCuenta.
      /// </summary>
      [IgnoreDataMember]
      public String CUBA_TipoCuentaMSGERROR
      {
         get { return m_cuba_tipocuentaMSGERROR; }
         set
         {
            if (m_cuba_tipocuentaMSGERROR != value)
            { m_cuba_tipocuentaMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CUBA_CuenPuente.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CUBA_CuenPuenteOK
      {
         get { return m_cuba_cuenpuenteOK; }
         set
         {
            if (m_cuba_cuenpuenteOK != value)
            { m_cuba_cuenpuenteOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CUBA_CuenPuente.
      /// </summary>
      [IgnoreDataMember]
      public String CUBA_CuenPuenteMSGERROR
      {
         get { return m_cuba_cuenpuenteMSGERROR; }
         set
         {
            if (m_cuba_cuenpuenteMSGERROR != value)
            { m_cuba_cuenpuenteMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CUBA_CuenContable.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CUBA_CuenContableOK
      {
         get { return m_cuba_cuencontableOK; }
         set
         {
            if (m_cuba_cuencontableOK != value)
            { m_cuba_cuencontableOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CUBA_CuenContable.
      /// </summary>
      [IgnoreDataMember]
      public String CUBA_CuenContableMSGERROR
      {
         get { return m_cuba_cuencontableMSGERROR; }
         set
         {
            if (m_cuba_cuencontableMSGERROR != value)
            { m_cuba_cuencontableMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CUBA_CtaPorCobrar.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CUBA_CtaPorCobrarOK
      {
         get { return m_cuba_ctaporcobrarOK; }
         set
         {
            if (m_cuba_ctaporcobrarOK != value)
            { m_cuba_ctaporcobrarOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CUBA_CtaPorCobrar.
      /// </summary>
      [IgnoreDataMember]
      public String CUBA_CtaPorCobrarMSGERROR
      {
         get { return m_cuba_ctaporcobrarMSGERROR; }
         set
         {
            if (m_cuba_ctaporcobrarMSGERROR != value)
            { m_cuba_ctaporcobrarMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CUBA_CtaPorPagar.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CUBA_CtaPorPagarOK
      {
         get { return m_cuba_ctaporpagarOK; }
         set
         {
            if (m_cuba_ctaporpagarOK != value)
            { m_cuba_ctaporpagarOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CUBA_CtaPorPagar.
      /// </summary>
      [IgnoreDataMember]
      public String CUBA_CtaPorPagarMSGERROR
      {
         get { return m_cuba_ctaporpagarMSGERROR; }
         set
         {
            if (m_cuba_ctaporpagarMSGERROR != value)
            { m_cuba_ctaporpagarMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CUBA_FechaCierre.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CUBA_FechaCierreOK
      {
         get { return m_cuba_fechacierreOK; }
         set
         {
            if (m_cuba_fechacierreOK != value)
            { m_cuba_fechacierreOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CUBA_FechaCierre.
      /// </summary>
      [IgnoreDataMember]
      public String CUBA_FechaCierreMSGERROR
      {
         get { return m_cuba_fechacierreMSGERROR; }
         set
         {
            if (m_cuba_fechacierreMSGERROR != value)
            { m_cuba_fechacierreMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CUBA_Bloqueo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CUBA_BloqueoOK
      {
         get { return m_cuba_bloqueoOK; }
         set
         {
            if (m_cuba_bloqueoOK != value)
            { m_cuba_bloqueoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CUBA_Bloqueo.
      /// </summary>
      [IgnoreDataMember]
      public String CUBA_BloqueoMSGERROR
      {
         get { return m_cuba_bloqueoMSGERROR; }
         set
         {
            if (m_cuba_bloqueoMSGERROR != value)
            { m_cuba_bloqueoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CUBA_PermChequeBlanco.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CUBA_PermChequeBlancoOK
      {
         get { return m_cuba_permchequeblancoOK; }
         set
         {
            if (m_cuba_permchequeblancoOK != value)
            { m_cuba_permchequeblancoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CUBA_PermChequeBlanco.
      /// </summary>
      [IgnoreDataMember]
      public String CUBA_PermChequeBlancoMSGERROR
      {
         get { return m_cuba_permchequeblancoMSGERROR; }
         set
         {
            if (m_cuba_permchequeblancoMSGERROR != value)
            { m_cuba_permchequeblancoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CUBA_PermImprAutomatica.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CUBA_PermImprAutomaticaOK
      {
         get { return m_cuba_permimprautomaticaOK; }
         set
         {
            if (m_cuba_permimprautomaticaOK != value)
            { m_cuba_permimprautomaticaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CUBA_PermImprAutomatica.
      /// </summary>
      [IgnoreDataMember]
      public String CUBA_PermImprAutomaticaMSGERROR
      {
         get { return m_cuba_permimprautomaticaMSGERROR; }
         set
         {
            if (m_cuba_permimprautomaticaMSGERROR != value)
            { m_cuba_permimprautomaticaMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CUBA_CodAgencia.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CUBA_CodAgenciaOK
      {
         get { return m_cuba_codagenciaOK; }
         set
         {
            if (m_cuba_codagenciaOK != value)
            { m_cuba_codagenciaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CUBA_CodAgencia.
      /// </summary>
      [IgnoreDataMember]
      public String CUBA_CodAgenciaMSGERROR
      {
         get { return m_cuba_codagenciaMSGERROR; }
         set
         {
            if (m_cuba_codagenciaMSGERROR != value)
            { m_cuba_codagenciaMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CUBA_MedioVirtual.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CUBA_MedioVirtualOK
      {
         get { return m_cuba_mediovirtualOK; }
         set
         {
            if (m_cuba_mediovirtualOK != value)
            { m_cuba_mediovirtualOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CUBA_MedioVirtual.
      /// </summary>
      [IgnoreDataMember]
      public String CUBA_MedioVirtualMSGERROR
      {
         get { return m_cuba_mediovirtualMSGERROR; }
         set
         {
            if (m_cuba_mediovirtualMSGERROR != value)
            { m_cuba_mediovirtualMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CUBA_Descripcion.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CUBA_DescripcionOK
      {
         get { return m_cuba_descripcionOK; }
         set
         {
            if (m_cuba_descripcionOK != value)
            { m_cuba_descripcionOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CUBA_Descripcion.
      /// </summary>
      [IgnoreDataMember]
      public String CUBA_DescripcionMSGERROR
      {
         get { return m_cuba_descripcionMSGERROR; }
         set
         {
            if (m_cuba_descripcionMSGERROR != value)
            { m_cuba_descripcionMSGERROR = value; }
         }
      }
      #endregion

      #region [ Validacion ]
      private String m_mensajeError;

      public void SetMensajeError(String msg)
      {
         if (m_mensajeError == null) { m_mensajeError = ""; }
         m_mensajeError += (msg ?? "");
      }

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
               EMPR_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Código Empresa", "Cuenta Bancaria");
               m_mensajeError += "* Debe ingresar el campo Código Empresa" + Environment.NewLine;
            }
            CUBA_CodigoOK = true;
            CUBA_CodigoMSGERROR = "";
            if (String.IsNullOrEmpty(CUBA_Codigo))
            {
               _isCorrect = false;
               CUBA_CodigoOK = false;
               CUBA_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Código", "Cuenta Bancaria");
               m_mensajeError += "* Debe ingresar el campo Código" + Environment.NewLine;
            }
            //TIPO_TabMNDOK = true;
            //TIPO_TabMNDMSGERROR = "";
            //if (String.IsNullOrEmpty(TIPO_TabMND))
            //{
            //   _isCorrect = false;
            //   TIPO_TabMNDOK = false;
            //   TIPO_TabMNDMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo Tabla Moneda", "Cuenta Bancaria");
            //   m_mensajeError += "* Debe ingresar el campo Tipo Tabla Moneda" + Environment.NewLine;
            //}
            TIPO_CodMNDOK = true;
            TIPO_CodMNDMSGERROR = "";
            if (String.IsNullOrEmpty(TIPO_CodMND))
            {
               _isCorrect = false;
               TIPO_CodMNDOK = false;
               TIPO_CodMNDMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo Moneda", "Cuenta Bancaria");
               m_mensajeError += "* Debe ingresar el campo Tipo Moneda" + Environment.NewLine;
            }
            //TIPO_TabBCOOK = true;
            //TIPO_TabBCOMSGERROR = "";
            //if (String.IsNullOrEmpty(TIPO_TabBCO))
            //{
            //   _isCorrect = false;
            //   TIPO_TabBCOOK = false;
            //   TIPO_TabBCOMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo Tabla Banco", "Cuenta Bancaria");
            //   m_mensajeError += "* Debe ingresar el campo Tipo Tabla Banco" + Environment.NewLine;
            //}
            TIPO_CodBCOOK = true;
            TIPO_CodBCOMSGERROR = "";
            if (String.IsNullOrEmpty(TIPO_CodBCO))
            {
               _isCorrect = false;
               TIPO_CodBCOOK = false;
               TIPO_CodBCOMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo Banco", "Cuenta Bancaria");
               m_mensajeError += "* Debe ingresar el campo Tipo Banco" + Environment.NewLine;
            }
            CUBA_NroCuentaOK = true;
            CUBA_NroCuentaMSGERROR = "";
            if (String.IsNullOrEmpty(CUBA_NroCuenta))
            {
               _isCorrect = false;
               CUBA_NroCuentaOK = false;
               CUBA_NroCuentaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Número de Cuenta", "Cuenta Bancaria");
               m_mensajeError += "* Debe ingresar el campo Número de Cuenta" + Environment.NewLine;
            }
            CUBA_TipoCuentaOK = true;
            CUBA_TipoCuentaMSGERROR = "";
            if (String.IsNullOrEmpty(CUBA_TipoCuenta))
            {
               _isCorrect = false;
               CUBA_TipoCuentaOK = false;
               CUBA_TipoCuentaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de Cuenta", "Cuenta Bancaria");
               m_mensajeError += "* Debe ingresar el campo Tipo de Cuenta" + Environment.NewLine;
            }
            //CUBA_MedioVirtualOK = true;
            //CUBA_MedioVirtualMSGERROR = "";
            //if (CUBA_MedioVirtual == null)
            //{
            //   _isCorrect = false;
            //   CUBA_MedioVirtualOK = false;
            //   CUBA_MedioVirtualMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Medio Virtual", "Cuenta Bancaria");
            //   m_mensajeError += "* Debe ingresar el campo Medio Virtual" + Environment.NewLine;
            //}
            CUBA_DescripcionOK = true;
            CUBA_DescripcionMSGERROR = "";
            if (String.IsNullOrEmpty(CUBA_Descripcion))
            {
               _isCorrect = false;
               CUBA_DescripcionOK = false;
               CUBA_DescripcionMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Descripción", "Cuenta Bancaria");
               m_mensajeError += "* Debe ingresar el campo Descripción" + Environment.NewLine;
            }

            if (ListChequera != null && ListChequera.Count > 0)
            {
               int Normal = 0, Diferido = 0; ;
               foreach (Entities.Chequera item in ListChequera)
               {
                  if (item.CHEQ_Estado.Equals("U") && !item.CHEQ_Diferido.Value) { Normal++; }
                  if (item.CHEQ_Estado.Equals("U") && item.CHEQ_Diferido.Value) { Diferido++; }
               }
               if (Normal > 1) { _isCorrect = false; m_mensajeError += "* Solo puede tener una chequera Normal en Uso" + Environment.NewLine; }
               if (Diferido > 1) { _isCorrect = false; m_mensajeError += "* Solo puede tener una chequera Diferida en Uso" + Environment.NewLine; }
            }
            if (ListFirmas != null && ListFirmas.Count > 0)
            {
                int count = 0;
                foreach (Entities.Firmas item in ListFirmas)
                {
                    if (string.IsNullOrEmpty(item.FIRM_Cargo))
                    {
                        count++;
                    }
                    
                }
                if (count > 0) { _isCorrect = false; m_mensajeError += "* " + count.ToString() + " Registros de Firma no incluyen el campo Cargo" + Environment.NewLine; } 
            }
            return _isCorrect;
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
