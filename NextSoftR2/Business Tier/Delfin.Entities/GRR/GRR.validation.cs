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
    public partial class GRR
    {
        #region [ Variables Validación ]
        private Boolean m_reba_tipoOK;
        private String m_reba_tipoMSGERROR;
        private Boolean m_reba_codigoOK;
        private String m_reba_codigoMSGERROR;
        private Boolean m_reba_feciniOK;
        private String m_reba_feciniMSGERROR;
        private Boolean m_reba_fecfinOK;
        private String m_reba_fecfinMSGERROR;
        private Boolean m_reba_valorOK;
        private String m_reba_valorMSGERROR;
        private Boolean m_reba_limitesupOK;
        private String m_reba_limitesupMSGERROR;
        private Boolean m_reba_limiteinfOK;
        private String m_reba_limiteinfMSGERROR;
        private Boolean m_reba_costofleteOK;
        private String m_reba_costofleteMSGERROR;
        private Boolean m_reba_costofletedesOK;
        private String m_reba_costofletedesMSGERROR;
        private Boolean m_empr_codigoOK;
        private String m_empr_codigoMSGERROR;
        private Boolean m_entc_codtransportistaOK;
        private String m_entc_codtransportistaMSGERROR;
        private Boolean m_tipo_tabmndOK;
        private String m_tipo_tabmndMSGERROR;
        private Boolean m_tipo_codmndOK;
        private String m_tipo_codmndMSGERROR;
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
        /// Gets or sets el valor de validación de: REBA_Tipo.
        /// </summary>
        [IgnoreDataMember]
        public Boolean REBA_TipoOK
        {
            get { return m_reba_tipoOK; }
            set
            {
                if (m_reba_tipoOK != value)
                { m_reba_tipoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: REBA_Tipo.
        /// </summary>
        [IgnoreDataMember]
        public String REBA_TipoMSGERROR
        {
            get { return m_reba_tipoMSGERROR; }
            set
            {
                if (m_reba_tipoMSGERROR != value)
                { m_reba_tipoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: REBA_Codigo.
        /// </summary>
        [IgnoreDataMember]
        public Boolean REBA_CodigoOK
        {
            get { return m_reba_codigoOK; }
            set
            {
                if (m_reba_codigoOK != value)
                { m_reba_codigoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: REBA_Codigo.
        /// </summary>
        [IgnoreDataMember]
        public String REBA_CodigoMSGERROR
        {
            get { return m_reba_codigoMSGERROR; }
            set
            {
                if (m_reba_codigoMSGERROR != value)
                { m_reba_codigoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: REBA_FecIni.
        /// </summary>
        [IgnoreDataMember]
        public Boolean REBA_FecIniOK
        {
            get { return m_reba_feciniOK; }
            set
            {
                if (m_reba_feciniOK != value)
                { m_reba_feciniOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: REBA_FecIni.
        /// </summary>
        [IgnoreDataMember]
        public String REBA_FecIniMSGERROR
        {
            get { return m_reba_feciniMSGERROR; }
            set
            {
                if (m_reba_feciniMSGERROR != value)
                { m_reba_feciniMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: REBA_FecFin.
        /// </summary>
        [IgnoreDataMember]
        public Boolean REBA_FecFinOK
        {
            get { return m_reba_fecfinOK; }
            set
            {
                if (m_reba_fecfinOK != value)
                { m_reba_fecfinOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: REBA_FecFin.
        /// </summary>
        [IgnoreDataMember]
        public String REBA_FecFinMSGERROR
        {
            get { return m_reba_fecfinMSGERROR; }
            set
            {
                if (m_reba_fecfinMSGERROR != value)
                { m_reba_fecfinMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: REBA_Valor.
        /// </summary>
        [IgnoreDataMember]
        public Boolean REBA_ValorOK
        {
            get { return m_reba_valorOK; }
            set
            {
                if (m_reba_valorOK != value)
                { m_reba_valorOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: REBA_Valor.
        /// </summary>
        [IgnoreDataMember]
        public String REBA_ValorMSGERROR
        {
            get { return m_reba_valorMSGERROR; }
            set
            {
                if (m_reba_valorMSGERROR != value)
                { m_reba_valorMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: REBA_LimiteSup.
        /// </summary>
        [IgnoreDataMember]
        public Boolean REBA_LimiteSupOK
        {
            get { return m_reba_limitesupOK; }
            set
            {
                if (m_reba_limitesupOK != value)
                { m_reba_limitesupOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: REBA_LimiteSup.
        /// </summary>
        [IgnoreDataMember]
        public String REBA_LimiteSupMSGERROR
        {
            get { return m_reba_limitesupMSGERROR; }
            set
            {
                if (m_reba_limitesupMSGERROR != value)
                { m_reba_limitesupMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: REBA_LimiteInf.
        /// </summary>
        [IgnoreDataMember]
        public Boolean REBA_LimiteInfOK
        {
            get { return m_reba_limiteinfOK; }
            set
            {
                if (m_reba_limiteinfOK != value)
                { m_reba_limiteinfOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: REBA_LimiteInf.
        /// </summary>
        [IgnoreDataMember]
        public String REBA_LimiteInfMSGERROR
        {
            get { return m_reba_limiteinfMSGERROR; }
            set
            {
                if (m_reba_limiteinfMSGERROR != value)
                { m_reba_limiteinfMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: REBA_CostoFlete.
        /// </summary>
        [IgnoreDataMember]
        public Boolean REBA_CostoFleteOK
        {
            get { return m_reba_costofleteOK; }
            set
            {
                if (m_reba_costofleteOK != value)
                { m_reba_costofleteOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: REBA_CostoFlete.
        /// </summary>
        [IgnoreDataMember]
        public String REBA_CostoFleteMSGERROR
        {
            get { return m_reba_costofleteMSGERROR; }
            set
            {
                if (m_reba_costofleteMSGERROR != value)
                { m_reba_costofleteMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: REBA_CostoFleteDes.
        /// </summary>
        [IgnoreDataMember]
        public Boolean REBA_CostoFleteDesOK
        {
            get { return m_reba_costofletedesOK; }
            set
            {
                if (m_reba_costofletedesOK != value)
                { m_reba_costofletedesOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: REBA_CostoFleteDes.
        /// </summary>
        [IgnoreDataMember]
        public String REBA_CostoFleteDesMSGERROR
        {
            get { return m_reba_costofletedesMSGERROR; }
            set
            {
                if (m_reba_costofletedesMSGERROR != value)
                { m_reba_costofletedesMSGERROR = value; }
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
                { m_empr_codigoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: ENTC_CodTransportista.
        /// </summary>
        [IgnoreDataMember]
        public Boolean ENTC_CodTransportistaOK
        {
            get { return m_entc_codtransportistaOK; }
            set
            {
                if (m_entc_codtransportistaOK != value)
                { m_entc_codtransportistaOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ENTC_CodTransportista.
        /// </summary>
        [IgnoreDataMember]
        public String ENTC_CodTransportistaMSGERROR
        {
            get { return m_entc_codtransportistaMSGERROR; }
            set
            {
                if (m_entc_codtransportistaMSGERROR != value)
                { m_entc_codtransportistaMSGERROR = value; }
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
                REBA_TipoOK = true;
                REBA_TipoMSGERROR = "";
                if (String.IsNullOrEmpty(REBA_Tipo))
                {
                    _isCorrect = false;
                    REBA_TipoOK = false;
                    REBA_TipoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo", "Rebate y GRR");
                    m_mensajeError += "* Debe seleccionar el campo Tipo" + Environment.NewLine;
                }
                REBA_CodigoOK = true;
                REBA_CodigoMSGERROR = "";
                //if( REBA_Codigo == 0)
                //{
                //   _isCorrect = false;
                //   REBA_CodigoOK  = false;
                //   REBA_CodigoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Código", "Rebate y GRR");
                //   m_mensajeError += "* Debe ingresar el campo Código" + Environment.NewLine;
                //}
                ENTC_CodTransportistaOK = true;
                ENTC_CodTransportistaMSGERROR = "";
                if (!ENTC_CodTransportista.HasValue)
                {
                    _isCorrect = false;
                    ENTC_CodTransportistaOK = false;
                    ENTC_CodTransportistaMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Transportista", "Rebate y GRR");
                    m_mensajeError += "* Debe seleccinar el campo Transportista" + Environment.NewLine;
                }
                REBA_FecIniOK = true;
                REBA_FecIniMSGERROR = "";
                if (!REBA_FecIni.HasValue)
                {
                    _isCorrect = false;
                    REBA_FecIniOK = false;
                    REBA_FecIniMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Fecha Inicio", "Rebate y GRR");
                    m_mensajeError += "* Debe ingresar el campo Fecha Inicio" + Environment.NewLine;
                }
                REBA_FecFinOK = true;
                REBA_FecFinMSGERROR = "";
                if (!REBA_FecFin.HasValue)
                {
                    _isCorrect = false;
                    REBA_FecFinOK = false;
                    REBA_FecFinMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Fecha Final", "Rebate y GRR");
                    m_mensajeError += "* Debe ingresar el campo Fecha Final" + Environment.NewLine;
                }
                if (REBA_TipoOK && REBA_Tipo == "R")
                {
                   TIPO_TabMNDOK = true;
                   TIPO_TabMNDMSGERROR = "";
                   TIPO_CodMNDOK = true;
                   TIPO_CodMNDMSGERROR = "";
                   if (String.IsNullOrEmpty(TIPO_TabMND) || String.IsNullOrEmpty(TIPO_CodMND))
                   {
                      _isCorrect = false;
                      TIPO_TabMNDOK = false;
                      TIPO_TabMNDMSGERROR = String.Format("Debe seleccionar la {0} del {1}.", "Moneda", "Rebate y GRR");
                      TIPO_CodMNDOK = false;
                      TIPO_CodMNDMSGERROR = String.Format("Debe seleccionar la {0} del {1}.", "Moneda", "Rebate y GRR");
                      m_mensajeError += "* Debe seleccionar el campo Moneda" + Environment.NewLine;
                   }
                   REBA_ValorOK = true;
                   REBA_ValorMSGERROR = "";
                   REBA_CostoFleteOK = true;
                   REBA_CostoFleteMSGERROR = string.Empty;
                   REBA_CostoFleteDesOK = true;
                   REBA_CostoFleteDesMSGERROR = string.Empty;
                   REBA_LimiteInfOK = true;
                   REBA_LimiteInfMSGERROR = string.Empty;
                   REBA_LimiteSupOK = true;
                   REBA_LimiteSupMSGERROR = string.Empty;
                   if (REBA_Valor == 0)
                   {
                      if (REBA_CostoFlete < 0)
                      {
                         _isCorrect = false;
                         REBA_CostoFleteOK = false;
                         REBA_CostoFleteMSGERROR = String.Format("Debe ingresar un valor mayor o igual a {0} en el {1}.", "Cero", "Costo Flete");
                         m_mensajeError += "* Debe ingresar un valor mayor o igual a Cero en el Costo Flete" + Environment.NewLine;
                      }
                      if (REBA_CostoFleteDes < 0)
                      {
                         _isCorrect = false;
                         REBA_CostoFleteDesOK = false;
                         REBA_CostoFleteDesMSGERROR = String.Format("Debe ingresar un valor mayor o igual a {0} en el {1}.", "Cero", "Descuento Flete Costo x CNTR");
                         m_mensajeError += "* Debe ingresar un valor mayor o igual a Cero en el Costo Flete" + Environment.NewLine;
                      }
                      if (REBA_LimiteInf < 0)
                      {
                         _isCorrect = false;
                         REBA_LimiteInfOK = false;
                         REBA_LimiteInfMSGERROR = String.Format("Debe ingresar un valor mayor o igual a {0} en el {1}.", "Cero", "Límite Inferior");
                         m_mensajeError += "* Debe ingresar un valor mayor o igual a Cero en el Costo Flete" + Environment.NewLine;
                      }
                      if (REBA_LimiteSup <= 0)
                      {
                         _isCorrect = false;
                         REBA_LimiteSupOK = false;
                         REBA_LimiteSupMSGERROR = String.Format("Debe ingresar un valor mayor a {0} en el {1}.", "Cero", "Límite Superior");
                         m_mensajeError += "* Debe ingresar un valor mayor a Cero en el Costo Flete" + Environment.NewLine;
                      }
                   }
                   else if (REBA_Valor < 0)
                   {
                      _isCorrect = false;
                      REBA_ValorOK = false;
                      REBA_ValorMSGERROR = String.Format("Debe ingresar un valor mayor a {0} en el {1}.", "Cero", "Valor de Rebate");
                      m_mensajeError += "* Debe ingresar un valor mayor a Cero en el Valor de Rebate" + Environment.NewLine;
                   }
                }
                else if (REBA_TipoOK && REBA_Tipo == "G")
                { 
                   if (REBA_Valor <= 0)
                   {
                      _isCorrect = false;
                      REBA_ValorOK = false;
                      REBA_ValorMSGERROR = String.Format("Debe ingresar un valor mayor a {0} en el {1}.", "Cero", "Valor de GRR (%)");
                      m_mensajeError += "* Debe ingresar un valor mayor a Cero en el Valor de GRR (%)" + Environment.NewLine;
                   }
                }
                return _isCorrect;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
