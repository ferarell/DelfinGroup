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
    public partial class Det_CNTR
    {
        #region [ Variables Validación ]
        private Boolean m_ccot_numeroOK;
        private String m_ccot_numeroMSGERROR;
        private Boolean m_ccot_tipoOK;
        private String m_ccot_tipoMSGERROR;
        private Boolean m_cmbl_codigoOK;
        private String m_cmbl_codigoMSGERROR;
        private Boolean m_pack_codigoOK;
        private String m_pack_codigoMSGERROR;
        private Boolean m_dhbl_pesobrutoOK;
        private String m_dhbl_pesobrutoMSGERROR;
        private Boolean m_dhbl_volumenOK;
        private String m_dhbl_volumenMSGERROR;
        private Boolean m_dhbl_cantbultosOK;
        private String m_dhbl_cantbultosMSGERROR;
        private Boolean m_dhbl_precintoOK;
        private String m_dhbl_precintoMSGERROR;
        private Boolean m_dhbl_descproductoOK;
        private String m_dhbl_descproductoMSGERROR;
        private Boolean m_dhbl_marcasnumerosOK;
        private String m_dhbl_marcasnumerosMSGERROR;
        private Boolean m_tipo_tabimoOK;
        private String m_tipo_tabimoMSGERROR;
        private Boolean m_tipo_codimoOK;
        private String m_tipo_codimoMSGERROR;
        private Boolean m_dhbl_esimoOK;
        private String m_dhbl_esimoMSGERROR;
        private Boolean m_dhbl_imounOK;
        private String m_dhbl_imounMSGERROR;
        private Boolean m_dhbl_contractnroOK;
        private String m_dhbl_contractnroMSGERROR;
        private Boolean m_dhbl_ppOK;
        private String m_dhbl_ppMSGERROR;
        private Boolean m_audi_usrcreaOK;
        private String m_audi_usrcreaMSGERROR;
        private Boolean m_audi_feccreaOK;
        private String m_audi_feccreaMSGERROR;
        private Boolean m_audi_usrmodOK;
        private String m_audi_usrmodMSGERROR;
        private Boolean m_audi_fecmodOK;
        private String m_audi_fecmodMSGERROR;
        private Boolean m_cntr_numeroOK;
        private String m_cntr_numeroMSGERROR;
        private Boolean m_dhbl_itemOK;
        private String m_dhbl_itemMSGERROR;
        private Boolean m_tipo_tabcdtOK;
        private String m_tipo_tabcdtMSGERROR;
        private Boolean m_tipo_codcdtOK;
        private String m_tipo_codcdtMSGERROR;
        private Boolean m_tipo_tabpacOK;
        private String m_tipo_tabpacMSGERROR;
        private Boolean m_tipo_codpacOK;
        private String m_tipo_codpacMSGERROR;
        #endregion

        #region [ Propiedades Validación ]
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
                { m_ccot_numeroMSGERROR = value; }
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
                { m_ccot_tipoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CMBL_codigo.
        /// </summary>
        [IgnoreDataMember]
        public Boolean CMBL_codigoOK
        {
            get { return m_cmbl_codigoOK; }
            set
            {
                if (m_cmbl_codigoOK != value)
                { m_cmbl_codigoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CMBL_codigo.
        /// </summary>
        [IgnoreDataMember]
        public String CMBL_codigoMSGERROR
        {
            get { return m_cmbl_codigoMSGERROR; }
            set
            {
                if (m_cmbl_codigoMSGERROR != value)
                { m_cmbl_codigoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: PACK_Codigo.
        /// </summary>
        [IgnoreDataMember]
        public Boolean PACK_CodigoOK
        {
            get { return m_pack_codigoOK; }
            set
            {
                if (m_pack_codigoOK != value)
                { m_pack_codigoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: PACK_Codigo.
        /// </summary>
        [IgnoreDataMember]
        public String PACK_CodigoMSGERROR
        {
            get { return m_pack_codigoMSGERROR; }
            set
            {
                if (m_pack_codigoMSGERROR != value)
                { m_pack_codigoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: DHBL_PesoBruto.
        /// </summary>
        [IgnoreDataMember]
        public Boolean DHBL_PesoBrutoOK
        {
            get { return m_dhbl_pesobrutoOK; }
            set
            {
                if (m_dhbl_pesobrutoOK != value)
                { m_dhbl_pesobrutoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: DHBL_PesoBruto.
        /// </summary>
        [IgnoreDataMember]
        public String DHBL_PesoBrutoMSGERROR
        {
            get { return m_dhbl_pesobrutoMSGERROR; }
            set
            {
                if (m_dhbl_pesobrutoMSGERROR != value)
                { m_dhbl_pesobrutoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: DHBL_Volumen.
        /// </summary>
        [IgnoreDataMember]
        public Boolean DHBL_VolumenOK
        {
            get { return m_dhbl_volumenOK; }
            set
            {
                if (m_dhbl_volumenOK != value)
                { m_dhbl_volumenOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: DHBL_Volumen.
        /// </summary>
        [IgnoreDataMember]
        public String DHBL_VolumenMSGERROR
        {
            get { return m_dhbl_volumenMSGERROR; }
            set
            {
                if (m_dhbl_volumenMSGERROR != value)
                { m_dhbl_volumenMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: DHBL_CantBultos.
        /// </summary>
        [IgnoreDataMember]
        public Boolean DHBL_CantBultosOK
        {
            get { return m_dhbl_cantbultosOK; }
            set
            {
                if (m_dhbl_cantbultosOK != value)
                { m_dhbl_cantbultosOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: DHBL_CantBultos.
        /// </summary>
        [IgnoreDataMember]
        public String DHBL_CantBultosMSGERROR
        {
            get { return m_dhbl_cantbultosMSGERROR; }
            set
            {
                if (m_dhbl_cantbultosMSGERROR != value)
                { m_dhbl_cantbultosMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: DHBL_Precinto.
        /// </summary>
        [IgnoreDataMember]
        public Boolean DHBL_PrecintoOK
        {
            get { return m_dhbl_precintoOK; }
            set
            {
                if (m_dhbl_precintoOK != value)
                { m_dhbl_precintoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: DHBL_Precinto.
        /// </summary>
        [IgnoreDataMember]
        public String DHBL_PrecintoMSGERROR
        {
            get { return m_dhbl_precintoMSGERROR; }
            set
            {
                if (m_dhbl_precintoMSGERROR != value)
                { m_dhbl_precintoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: DHBL_DescProducto.
        /// </summary>
        [IgnoreDataMember]
        public Boolean DHBL_DescProductoOK
        {
            get { return m_dhbl_descproductoOK; }
            set
            {
                if (m_dhbl_descproductoOK != value)
                { m_dhbl_descproductoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: DHBL_DescProducto.
        /// </summary>
        [IgnoreDataMember]
        public String DHBL_DescProductoMSGERROR
        {
            get { return m_dhbl_descproductoMSGERROR; }
            set
            {
                if (m_dhbl_descproductoMSGERROR != value)
                { m_dhbl_descproductoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: DHBL_MarcasNumeros.
        /// </summary>
        [IgnoreDataMember]
        public Boolean DHBL_MarcasNumerosOK
        {
            get { return m_dhbl_marcasnumerosOK; }
            set
            {
                if (m_dhbl_marcasnumerosOK != value)
                { m_dhbl_marcasnumerosOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: DHBL_MarcasNumeros.
        /// </summary>
        [IgnoreDataMember]
        public String DHBL_MarcasNumerosMSGERROR
        {
            get { return m_dhbl_marcasnumerosMSGERROR; }
            set
            {
                if (m_dhbl_marcasnumerosMSGERROR != value)
                { m_dhbl_marcasnumerosMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_TabIMO.
        /// </summary>
        [IgnoreDataMember]
        public Boolean TIPO_TabIMOOK
        {
            get { return m_tipo_tabimoOK; }
            set
            {
                if (m_tipo_tabimoOK != value)
                { m_tipo_tabimoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_TabIMO.
        /// </summary>
        [IgnoreDataMember]
        public String TIPO_TabIMOMSGERROR
        {
            get { return m_tipo_tabimoMSGERROR; }
            set
            {
                if (m_tipo_tabimoMSGERROR != value)
                { m_tipo_tabimoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_CodIMO.
        /// </summary>
        [IgnoreDataMember]
        public Boolean TIPO_CodIMOOK
        {
            get { return m_tipo_codimoOK; }
            set
            {
                if (m_tipo_codimoOK != value)
                { m_tipo_codimoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_CodIMO.
        /// </summary>
        [IgnoreDataMember]
        public String TIPO_CodIMOMSGERROR
        {
            get { return m_tipo_codimoMSGERROR; }
            set
            {
                if (m_tipo_codimoMSGERROR != value)
                { m_tipo_codimoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: DHBL_EsIMO.
        /// </summary>
        [IgnoreDataMember]
        public Boolean DHBL_EsIMOOK
        {
            get { return m_dhbl_esimoOK; }
            set
            {
                if (m_dhbl_esimoOK != value)
                { m_dhbl_esimoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: DHBL_EsIMO.
        /// </summary>
        [IgnoreDataMember]
        public String DHBL_EsIMOMSGERROR
        {
            get { return m_dhbl_esimoMSGERROR; }
            set
            {
                if (m_dhbl_esimoMSGERROR != value)
                { m_dhbl_esimoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: DHBL_ImoUN.
        /// </summary>
        [IgnoreDataMember]
        public Boolean DHBL_ImoUNOK
        {
            get { return m_dhbl_imounOK; }
            set
            {
                if (m_dhbl_imounOK != value)
                { m_dhbl_imounOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: DHBL_ImoUN.
        /// </summary>
        [IgnoreDataMember]
        public String DHBL_ImoUNMSGERROR
        {
            get { return m_dhbl_imounMSGERROR; }
            set
            {
                if (m_dhbl_imounMSGERROR != value)
                { m_dhbl_imounMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: DHBL_ContractNRO.
        /// </summary>
        [IgnoreDataMember]
        public Boolean DHBL_ContractNROOK
        {
            get { return m_dhbl_contractnroOK; }
            set
            {
                if (m_dhbl_contractnroOK != value)
                { m_dhbl_contractnroOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: DHBL_ContractNRO.
        /// </summary>
        [IgnoreDataMember]
        public String DHBL_ContractNROMSGERROR
        {
            get { return m_dhbl_contractnroMSGERROR; }
            set
            {
                if (m_dhbl_contractnroMSGERROR != value)
                { m_dhbl_contractnroMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: DHBL_PP.
        /// </summary>
        [IgnoreDataMember]
        public Boolean DHBL_PPOK
        {
            get { return m_dhbl_ppOK; }
            set
            {
                if (m_dhbl_ppOK != value)
                { m_dhbl_ppOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: DHBL_PP.
        /// </summary>
        [IgnoreDataMember]
        public String DHBL_PPMSGERROR
        {
            get { return m_dhbl_ppMSGERROR; }
            set
            {
                if (m_dhbl_ppMSGERROR != value)
                { m_dhbl_ppMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CNTR_Numero.
        /// </summary>
        [IgnoreDataMember]
        public Boolean CNTR_NumeroOK
        {
            get { return m_cntr_numeroOK; }
            set
            {
                if (m_cntr_numeroOK != value)
                { m_cntr_numeroOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CNTR_Numero.
        /// </summary>
        [IgnoreDataMember]
        public String CNTR_NumeroMSGERROR
        {
            get { return m_cntr_numeroMSGERROR; }
            set
            {
                if (m_cntr_numeroMSGERROR != value)
                { m_cntr_numeroMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: DHBL_Item.
        /// </summary>
        [IgnoreDataMember]
        public Boolean DHBL_ItemOK
        {
            get { return m_dhbl_itemOK; }
            set
            {
                if (m_dhbl_itemOK != value)
                { m_dhbl_itemOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: DHBL_Item.
        /// </summary>
        [IgnoreDataMember]
        public String DHBL_ItemMSGERROR
        {
            get { return m_dhbl_itemMSGERROR; }
            set
            {
                if (m_dhbl_itemMSGERROR != value)
                { m_dhbl_itemMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_TabCDT.
        /// </summary>
        [IgnoreDataMember]
        public Boolean TIPO_TabCDTOK
        {
            get { return m_tipo_tabcdtOK; }
            set
            {
                if (m_tipo_tabcdtOK != value)
                { m_tipo_tabcdtOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_TabCDT.
        /// </summary>
        [IgnoreDataMember]
        public String TIPO_TabCDTMSGERROR
        {
            get { return m_tipo_tabcdtMSGERROR; }
            set
            {
                if (m_tipo_tabcdtMSGERROR != value)
                { m_tipo_tabcdtMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_CodCDT.
        /// </summary>
        [IgnoreDataMember]
        public Boolean TIPO_CodCDTOK
        {
            get { return m_tipo_codcdtOK; }
            set
            {
                if (m_tipo_codcdtOK != value)
                { m_tipo_codcdtOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_CodCDT.
        /// </summary>
        [IgnoreDataMember]
        public String TIPO_CodCDTMSGERROR
        {
            get { return m_tipo_codcdtMSGERROR; }
            set
            {
                if (m_tipo_codcdtMSGERROR != value)
                { m_tipo_codcdtMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_TabPAC.
        /// </summary>
        [IgnoreDataMember]
        public Boolean TIPO_TabPACOK
        {
            get { return m_tipo_tabpacOK; }
            set
            {
                if (m_tipo_tabpacOK != value)
                { m_tipo_tabpacOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_TabPAC.
        /// </summary>
        [IgnoreDataMember]
        public String TIPO_TabPACMSGERROR
        {
            get { return m_tipo_tabpacMSGERROR; }
            set
            {
                if (m_tipo_tabpacMSGERROR != value)
                { m_tipo_tabpacMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_CodPAC.
        /// </summary>
        [IgnoreDataMember]
        public Boolean TIPO_CodPACOK
        {
            get { return m_tipo_codpacOK; }
            set
            {
                if (m_tipo_codpacOK != value)
                { m_tipo_codpacOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_CodPAC.
        /// </summary>
        [IgnoreDataMember]
        public String TIPO_CodPACMSGERROR
        {
            get { return m_tipo_codpacMSGERROR; }
            set
            {
                if (m_tipo_codpacMSGERROR != value)
                { m_tipo_codpacMSGERROR = value; }
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
        public Boolean Validar(Boolean ValidarFCL = true, Boolean ValidarMarcasNumeros = true, Boolean Documentado = false)
        {
            try
            {
                Boolean _isCorrect = true;
                m_mensajeError = "";

                CCOT_TipoOK = true;
                CCOT_TipoMSGERROR = "";
                if (CCOT_Tipo == null)
                {
                    _isCorrect = false;
                    CCOT_TipoOK = false;
                    CCOT_TipoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo OV", "Detalle Contenedor");
                    m_mensajeError += "     * Debe ingresar el campo Tipo OV" + Environment.NewLine;
                }
                CCOT_NumeroOK = true;
                CCOT_NumeroMSGERROR = "";
                if (CCOT_Numero == 0)
                {
                    _isCorrect = false;
                    CCOT_NumeroOK = false;
                    CCOT_NumeroMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Número", "Detalle Contenedor");
                    m_mensajeError += "     * Debe ingresar el campo Número" + Environment.NewLine;
                }
                DHBL_ItemOK = true;
                DHBL_ItemMSGERROR = "";
                if (DHBL_Item == 0)
                {
                    _isCorrect = false;
                    DHBL_ItemOK = false;
                    DHBL_ItemMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Item", "Detalle Contenedor");
                    m_mensajeError += "     * Debe ingresar el campo Item" + Environment.NewLine;
                }

                CNTR_NumeroOK = true;
                CNTR_NumeroMSGERROR = "";
                if (ValidarFCL)
                {
                    if (String.IsNullOrEmpty(CNTR_Numero))
                    {
                        _isCorrect = false;
                        CNTR_NumeroOK = false;
                        CNTR_NumeroMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Número Contenedor", "Detalle Contenedor");
                        m_mensajeError += "     * Debe ingresar el campo Número Contenedor" + Environment.NewLine;
                    }
                }
                DHBL_PrecintoOK = true;
                DHBL_PrecintoMSGERROR = "";
                if (ValidarFCL)
                {
                    if (String.IsNullOrEmpty(DHBL_Precinto))
                    {
                        _isCorrect = false;
                        DHBL_PrecintoOK = false;
                        DHBL_PrecintoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Precinto", "Detalle Contenedor");
                        m_mensajeError += "     * Debe ingresar el campo Precinto" + Environment.NewLine;
                    }
                }

                DHBL_DescProductoOK = true;
                DHBL_DescProductoMSGERROR = "";
                if (String.IsNullOrEmpty(DHBL_DescProducto))
                {
                    _isCorrect = false;
                    DHBL_DescProductoOK = false;
                    DHBL_DescProductoMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Descripción de la Carga", "Detalle Contenedor");
                    m_mensajeError += "     * Debe ingresar el campo Descripción de la Carga" + Environment.NewLine;
                }
                if (ValidarMarcasNumeros)
                {
                    DHBL_MarcasNumerosOK = true;
                    DHBL_MarcasNumerosMSGERROR = "";
                    if (String.IsNullOrEmpty(DHBL_MarcasNumeros))
                    {
                        _isCorrect = false;
                        DHBL_MarcasNumerosOK = false;
                        DHBL_MarcasNumerosMSGERROR = String.Format("Debe ingresar las {0} de la {1}.", "Marcas y Números", "Detalle Contenedor");
                        m_mensajeError += "     * Debe ingresar el campo Marcas y Números" + Environment.NewLine;
                    }
                }
                //DHBL_ContractNROOK  = true;
                //DHBL_ContractNROMSGERROR  = "";
                //if( String.IsNullOrEmpty(DHBL_ContractNRO) )
                //{
                //   _isCorrect = false;
                //   DHBL_ContractNROOK  = false;
                //   DHBL_ContractNROMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DHBL_ContractNRO", "Detalle Contenedor");
                //   m_mensajeError += "* Debe ingresar el campo DHBL_ContractNRO" + Environment.NewLine;
                //}

                if (DHBL_EsIMO.HasValue && DHBL_EsIMO.Value)
                {
                    TIPO_CodIMOOK = true;
                    TIPO_CodIMOMSGERROR = "";
                    if (String.IsNullOrEmpty(TIPO_CodIMO))
                    {
                        _isCorrect = false;
                        TIPO_CodIMOOK = false;
                        TIPO_CodIMOMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "IMO Class", "Detalle de Contenedor");
                        m_mensajeError += "     * Debe seleccionar el IMO Class" + Environment.NewLine;
                    }

                    DHBL_ImoUNOK = true;
                    DHBL_ImoUNMSGERROR = "";
                    if (String.IsNullOrEmpty(DHBL_ImoUN))
                    {
                        _isCorrect = false;
                        DHBL_ImoUNOK = false;
                        DHBL_ImoUNMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "IMO UN", "Detalle de Contenedor");
                        m_mensajeError += "     * Debe seleccionar el IMO UN" + Environment.NewLine;
                    }
                }

                /*TODOS LOS CASOS DOCUMENTADA*/
                if (Documentado)
                {
                    DHBL_CantBultosOK = true;
                    DHBL_CantBultosMSGERROR = "";
                    if (DHBL_CantBultos <= (Decimal)0.00 || !DHBL_CantBultos.HasValue)
                    {
                        _isCorrect = false;
                        DHBL_CantBultosOK = false;
                        DHBL_CantBultosMSGERROR = String.Format("Debe ingresar una cantidad mayor a cero en la {0} del {1}.", "Cantidad de bultos", "Detalle de Contenedor");
                        m_mensajeError += "     * Debe ingresar un cantidad mayor a cero en la Cantidad de Bultos" + Environment.NewLine;
                    }
                    DHBL_PesoBrutoOK = true;
                    DHBL_PesoBrutoMSGERROR = "";
                    if (DHBL_PesoBruto <= (Decimal)0.00 || !DHBL_PesoBruto.HasValue)
                    {
                        _isCorrect = false;
                        DHBL_PesoBrutoOK = false;
                        DHBL_PesoBrutoMSGERROR = String.Format("Debe ingresar una cantidad mayor a cero en el {0} del {1}.", "Peso", "Detalle de Contenedor");
                        m_mensajeError += "     * Debe ingresar un cantidad mayor a cero en el Peso" + Environment.NewLine;
                    }
                    DHBL_VolumenOK = true;
                    DHBL_VolumenMSGERROR = "";
                    //if (DHBL_Volumen <= (Decimal)0.00 || !DHBL_Volumen.HasValue)
                    //{
                    //    _isCorrect = false;
                    //    DHBL_VolumenOK = false;
                    //    DHBL_VolumenMSGERROR = String.Format("Debe ingresar una cantidad mayor a cero en el {0} del {1}.", "Volumen", "Detalle de Contenedor");
                    //    m_mensajeError += "     * Debe ingresar un cantidad mayor a cero en el Volumen" + Environment.NewLine;
                    //}
                    TIPO_TabCDTOK = true;
                    TIPO_CodCDTOK = true;
                    TIPO_TabCDTMSGERROR = "";
                    TIPO_CodCDTMSGERROR = "";
                    if (String.IsNullOrEmpty(TIPO_TabCDT) || String.IsNullOrEmpty(TIPO_CodCDT))
                    {
                        _isCorrect = false;
                        TIPO_TabCDTOK = false;
                        TIPO_CodCDTOK = false;
                        TIPO_TabCDTMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Comodity", "Detalle de Contenedor");
                        TIPO_CodCDTMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Comodity", "Detalle de Contenedor");
                        m_mensajeError += "     * Debe seleccionar un Comodity" + Environment.NewLine;
                    }
                    TIPO_TabPACOK = true;
                    TIPO_CodPACOK = true;
                    TIPO_TabPACMSGERROR = "";
                    TIPO_CodPACMSGERROR = "";
                    if (String.IsNullOrEmpty(TIPO_TabPAC) || String.IsNullOrEmpty(TIPO_CodPAC))
                    {
                        _isCorrect = false;
                        TIPO_TabPACOK = false;
                        TIPO_CodPACOK = false;
                        TIPO_TabPACMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo Bulto", "Detalle de Contenedor");
                        TIPO_CodPACMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo Bulto", "Detalle de Contenedor");
                        m_mensajeError += "     * Debe seleccionar un Tipo Bulto" + Environment.NewLine;
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
