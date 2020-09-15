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
    public partial class CabPerfilAsientos
    {
        #region [ Variables Validación ]
        private Boolean m_cabp_anoOK;
        private String m_cabp_anoMSGERROR;
        private Boolean m_cabp_codigoOK;
        private String m_cabp_codigoMSGERROR;
        private Boolean m_cabp_descOK;
        private String m_cabp_descMSGERROR;
        private Boolean m_tipo_codregOK;
        private String m_tipo_codregMSGERROR;
        private Boolean m_tipo_tabregOK;
        private String m_tipo_tabregMSGERROR;
        private Boolean m_cabp_valorrefOK;
        private String m_cabp_valorrefMSGERROR;
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
                { m_cabp_anoMSGERROR = value; }
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
                { m_cabp_codigoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CABP_Desc.
        /// </summary>
        [IgnoreDataMember]
        public Boolean CABP_DescOK
        {
            get { return m_cabp_descOK; }
            set
            {
                if (m_cabp_descOK != value)
                { m_cabp_descOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CABP_Desc.
        /// </summary>
        [IgnoreDataMember]
        public String CABP_DescMSGERROR
        {
            get { return m_cabp_descMSGERROR; }
            set
            {
                if (m_cabp_descMSGERROR != value)
                { m_cabp_descMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_CodREG.
        /// </summary>
        [IgnoreDataMember]
        public Boolean TIPO_CodREGOK
        {
            get { return m_tipo_codregOK; }
            set
            {
                if (m_tipo_codregOK != value)
                { m_tipo_codregOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_CodREG.
        /// </summary>
        [IgnoreDataMember]
        public String TIPO_CodREGMSGERROR
        {
            get { return m_tipo_codregMSGERROR; }
            set
            {
                if (m_tipo_codregMSGERROR != value)
                { m_tipo_codregMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_TabREG.
        /// </summary>
        [IgnoreDataMember]
        public Boolean TIPO_TabREGOK
        {
            get { return m_tipo_tabregOK; }
            set
            {
                if (m_tipo_tabregOK != value)
                { m_tipo_tabregOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_TabREG.
        /// </summary>
        [IgnoreDataMember]
        public String TIPO_TabREGMSGERROR
        {
            get { return m_tipo_tabregMSGERROR; }
            set
            {
                if (m_tipo_tabregMSGERROR != value)
                { m_tipo_tabregMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CABP_ValorRef.
        /// </summary>
        [IgnoreDataMember]
        public Boolean CABP_ValorRefOK
        {
            get { return m_cabp_valorrefOK; }
            set
            {
                if (m_cabp_valorrefOK != value)
                { m_cabp_valorrefOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CABP_ValorRef.
        /// </summary>
        [IgnoreDataMember]
        public String CABP_ValorRefMSGERROR
        {
            get { return m_cabp_valorrefMSGERROR; }
            set
            {
                if (m_cabp_valorrefMSGERROR != value)
                { m_cabp_valorrefMSGERROR = value; }
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
                CABP_AnoOK = true;
                CABP_AnoMSGERROR = "";
                if (String.IsNullOrEmpty(CABP_Ano))
                {
                    _isCorrect = false;
                    CABP_AnoOK = false;
                    CABP_AnoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Periodo", "CabPerfilAsientos");
                    m_mensajeError += "* Debe ingresar el campo Periodo" + Environment.NewLine;
                }
                CABP_CodigoOK = true;
                CABP_CodigoMSGERROR = "";
                //if (String.IsNullOrEmpty(CABP_Codigo))
                //{
                //    _isCorrect = false;
                //    CABP_CodigoOK = false;
                //    CABP_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Código", "CabPerfilAsientos");
                //    m_mensajeError += "* Debe ingresar el campo Código" + Environment.NewLine;
                //}
                CABP_DescOK = true;
                CABP_DescMSGERROR = "";
                if (String.IsNullOrEmpty(CABP_Desc))
                {
                    _isCorrect = false;
                    CABP_DescOK = false;
                    CABP_DescMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Descripción", "CabPerfilAsientos");
                    m_mensajeError += "* Debe ingresar el campo Descripción" + Environment.NewLine;
                }
                TIPO_CodREGOK = true;
                TIPO_CodREGMSGERROR = "";
                //if( String.IsNullOrEmpty(TIPO_CodREG) )
                //{
                //   _isCorrect = false;
                //   TIPO_CodREGOK  = false;
                //   TIPO_CodREGMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_CodREG", "CabPerfilAsientos");
                //   m_mensajeError += "* Debe ingresar el campo TIPO_CodREG" + Environment.NewLine;
                //}
                TIPO_TabREGOK = true;
                TIPO_TabREGMSGERROR = "";
                //if( String.IsNullOrEmpty(TIPO_TabREG) )
                //{
                //   _isCorrect = false;
                //   TIPO_TabREGOK  = false;
                //   TIPO_TabREGMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_TabREG", "CabPerfilAsientos");
                //   m_mensajeError += "* Debe ingresar el campo TIPO_TabREG" + Environment.NewLine;
                //}
                CABP_ValorRefOK = true;
                CABP_ValorRefMSGERROR = "";
                //if( CABP_ValorRef == 0)
                //{
                //   _isCorrect = false;
                //   CABP_ValorRefOK  = false;
                //   CABP_ValorRefMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Valor Referencial", "CabPerfilAsientos");
                //   m_mensajeError += "* Debe ingresar el campo CABP_ValorRef" + Environment.NewLine;
                //}
                Boolean ItemsDetPerfilAsientosOK = true;
                String ItemsDetPerfilAsientosMSGERROR = "";
                if (ListDetPerfilAsientos != null && ListDetPerfilAsientos.Count > 0)
                {
                    Int32 _item = 1;
                    foreach (Entities.DetPerfilAsientos item in ListDetPerfilAsientos)
                    {
                        String _menssage = String.Empty;
                        if (string.IsNullOrEmpty(item.CUEN_Codigo))
                        {
                            _menssage += "        * Debe ingresar una cuenta" + Environment.NewLine;
                            ItemsDetPerfilAsientosOK = false;
                            _isCorrect = false;
                        }
                        if (string.IsNullOrEmpty(item.DETP_Glosa))
                        {
                            _menssage += "        * Debe ingresar una glosa" + Environment.NewLine;
                            ItemsDetPerfilAsientosOK = false;
                            _isCorrect = false;
                        }
                        if (!item.DETP_DebePorc.HasValue && !item.DETP_HaberPorc.HasValue)
                        {
                            _menssage += "        * Debe Ingresar un valor en el campo Debe o Haber" + Environment.NewLine;
                            ItemsDetPerfilAsientosOK = false;
                            _isCorrect = false;
                        }
                        else
                        {
                            if (item.DETP_DebePorc.HasValue && item.DETP_HaberPorc.HasValue)
                            {
                                _menssage += "        * Solo se permite ingresar un valor o en el Debe o en el Haber" + Environment.NewLine;
                                ItemsDetPerfilAsientosOK = false;
                                _isCorrect = false;
                            }
                            else
                            {
                                Decimal dec = (Decimal)0.00;
                                if (item.DETP_DebePorc.HasValue)
                                {
                                    if (item.DETP_DebePorc <= dec)
                                    {
                                        _menssage += "        * Debe ingresar un valor mayor a cero en el Debe" + Environment.NewLine;
                                        ItemsDetPerfilAsientosOK = false;
                                        _isCorrect = false;
                                    }
                                }
                                if (item.DETP_HaberPorc.HasValue)
                                {
                                    if (item.DETP_HaberPorc <= dec)
                                    {
                                        _menssage += "        * Debe ingresar un valor mayor a cero en el Haber" + Environment.NewLine;
                                        ItemsDetPerfilAsientosOK = false;
                                        _isCorrect = false;
                                    }
                                }
                            }
                        }
                        if (!_isCorrect)
                        {
                            ItemsDetPerfilAsientosMSGERROR += "    * Item: " + _item.ToString() + Environment.NewLine;
                            ItemsDetPerfilAsientosMSGERROR += _menssage;
                        }
                        _item++;
                    }
                }
                if (!ItemsDetPerfilAsientosOK)
                {
                    m_mensajeError += "* La Grilla de Detalles contiene los siguientes errores: " + Environment.NewLine;
                    m_mensajeError += ItemsDetPerfilAsientosMSGERROR + Environment.NewLine;
                }
                return _isCorrect;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
