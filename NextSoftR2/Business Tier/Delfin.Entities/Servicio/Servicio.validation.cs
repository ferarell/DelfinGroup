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
	public partial class Servicio
	{
        #region [ Variables Validación ]
        private Boolean m_serv_codigoOK;
        private String m_serv_codigoMSGERROR;
        private Boolean m_serv_nombre_spaOK;
        private String m_serv_nombre_spaMSGERROR;
        private Boolean m_serv_nombre_engOK;
        private String m_serv_nombre_engMSGERROR;
        private Boolean m_serv_afeigvOK;
        private String m_serv_afeigvMSGERROR;
        private Boolean m_serv_fleteOK;
        private String m_serv_fleteMSGERROR;
        private Boolean m_serv_afedetOK;
        private String m_serv_afedetMSGERROR;
        private Boolean m_cons_tabviaOK;
        private String m_cons_tabviaMSGERROR;
        private Boolean m_cons_codviaOK;
        private String m_cons_codviaMSGERROR;
        private Boolean m_serv_activoOK;
        private String m_serv_activoMSGERROR;
        private Boolean m_serv_cuevtaOK;
        private String m_serv_cuevtaMSGERROR;
        private Boolean m_serv_cuegasOK;
        private String m_serv_cuegasMSGERROR;
        private Boolean m_serv_agrup1OK;
        private String m_serv_agrup1MSGERROR;
        private Boolean m_serv_agrup2OK;
        private String m_serv_agrup2MSGERROR;
        private Boolean m_serv_pordetOK;
        private String m_serv_pordetMSGERROR;
        private Boolean m_serv_tipoOK;
        private String m_serv_tipoMSGERROR;
        private Boolean m_serv_valorOK;
        private String m_serv_valorMSGERROR;
        private Boolean m_serv_cobminOK;
        private String m_serv_cobminMSGERROR;
        private Boolean m_serv_automOK;
        private String m_serv_automMSGERROR;
        private Boolean m_serv_frecfacOK;
        private String m_serv_frecfacMSGERROR;
        private Boolean m_tipo_tabuntOK;
        private String m_tipo_tabuntMSGERROR;
        private Boolean m_tipo_coduntOK;
        private String m_tipo_coduntMSGERROR;
        private Boolean m_audi_usrcreaOK;
        private String m_audi_usrcreaMSGERROR;
        private Boolean m_audi_feccreaOK;
        private String m_audi_feccreaMSGERROR;
        private Boolean m_audi_usrmodOK;
        private String m_audi_usrmodMSGERROR;
        private Boolean m_audi_fecmodOK;
        private String m_audi_fecmodMSGERROR;
        private Boolean m_cons_tabrgmOK;
        private String m_cons_tabrgmMSGERROR;
        private Boolean m_cons_codrgmOK;
        private String m_cons_codrgmMSGERROR;
        private Boolean m_serv_cueningresoOK;
        private String m_serv_cueningresoMSGERROR;
        private Boolean m_serv_cuencostoOK;
        private String m_serv_cuencostoMSGERROR;
        private Boolean m_serv_cuenpuenteOK;
        private String m_serv_cuenpuenteMSGERROR;
        private Boolean m_tipo_tabdetOK;
        private String m_tipo_tabdetMSGERROR;
        private Boolean m_tipo_coddetOK;
        private String m_tipo_coddetMSGERROR;
        private Boolean m_serv_nombrecortoOK;
        private String m_serv_nombrecortoMSGERROR;
        private Boolean m_serv_glosaOK;
        private String m_serv_glosaMSGERROR;
        private Boolean m_serv_observacionesOK;
        private String m_serv_observacionesMSGERROR;
        private Boolean m_serv_tipomovOK;
        private String m_serv_tipomovMSGERROR;
        private Boolean m_cons_tabbasOK;
        private String m_cons_tabbasMSGERROR;
        private Boolean m_cons_codbasOK;
        private String m_cons_codbasMSGERROR;
        private Boolean m_tipo_tabmndOK;
        private String m_tipo_tabmndMSGERROR;
        private Boolean m_tipo_codmndOK;
        private String m_tipo_codmndMSGERROR;
        private Boolean m_cons_tablngOK;
        private String m_cons_tablngMSGERROR;
        private Boolean m_cons_codlngOK;
        private String m_cons_codlngMSGERROR;

        private Boolean m_itemsserviciodocumentosOK;
        private String m_itemsserviciodocumentosMSGERROR;

        #endregion

        #region [ Propiedades Validación ]
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_Codigo.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_CodigoOK
        {
            get { return m_serv_codigoOK; }
            set
            {
                if (m_serv_codigoOK != value)
                { m_serv_codigoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_Codigo.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_CodigoMSGERROR
        {
            get { return m_serv_codigoMSGERROR; }
            set
            {
                if (m_serv_codigoMSGERROR != value)
                { m_serv_codigoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_Nombre_SPA.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_Nombre_SPAOK
        {
            get { return m_serv_nombre_spaOK; }
            set
            {
                if (m_serv_nombre_spaOK != value)
                { m_serv_nombre_spaOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_Nombre_SPA.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_Nombre_SPAMSGERROR
        {
            get { return m_serv_nombre_spaMSGERROR; }
            set
            {
                if (m_serv_nombre_spaMSGERROR != value)
                { m_serv_nombre_spaMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_Nombre_ENG.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_Nombre_ENGOK
        {
            get { return m_serv_nombre_engOK; }
            set
            {
                if (m_serv_nombre_engOK != value)
                { m_serv_nombre_engOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_Nombre_ENG.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_Nombre_ENGMSGERROR
        {
            get { return m_serv_nombre_engMSGERROR; }
            set
            {
                if (m_serv_nombre_engMSGERROR != value)
                { m_serv_nombre_engMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_AfeIgv.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_AfeIgvOK
        {
            get { return m_serv_afeigvOK; }
            set
            {
                if (m_serv_afeigvOK != value)
                { m_serv_afeigvOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_AfeIgv.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_AfeIgvMSGERROR
        {
            get { return m_serv_afeigvMSGERROR; }
            set
            {
                if (m_serv_afeigvMSGERROR != value)
                { m_serv_afeigvMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_Flete.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_FleteOK
        {
            get { return m_serv_fleteOK; }
            set
            {
                if (m_serv_fleteOK != value)
                { m_serv_fleteOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_Flete.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_FleteMSGERROR
        {
            get { return m_serv_fleteMSGERROR; }
            set
            {
                if (m_serv_fleteMSGERROR != value)
                { m_serv_fleteMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_AfeDet.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_AfeDetOK
        {
            get { return m_serv_afedetOK; }
            set
            {
                if (m_serv_afedetOK != value)
                { m_serv_afedetOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_AfeDet.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_AfeDetMSGERROR
        {
            get { return m_serv_afedetMSGERROR; }
            set
            {
                if (m_serv_afedetMSGERROR != value)
                { m_serv_afedetMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CONS_TabVia.
        /// </summary>
        [IgnoreDataMember]
        public Boolean CONS_TabViaOK
        {
            get { return m_cons_tabviaOK; }
            set
            {
                if (m_cons_tabviaOK != value)
                { m_cons_tabviaOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_TabVia.
        /// </summary>
        [IgnoreDataMember]
        public String CONS_TabViaMSGERROR
        {
            get { return m_cons_tabviaMSGERROR; }
            set
            {
                if (m_cons_tabviaMSGERROR != value)
                { m_cons_tabviaMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CONS_CodVia.
        /// </summary>
        [IgnoreDataMember]
        public Boolean CONS_CodViaOK
        {
            get { return m_cons_codviaOK; }
            set
            {
                if (m_cons_codviaOK != value)
                { m_cons_codviaOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_CodVia.
        /// </summary>
        [IgnoreDataMember]
        public String CONS_CodViaMSGERROR
        {
            get { return m_cons_codviaMSGERROR; }
            set
            {
                if (m_cons_codviaMSGERROR != value)
                { m_cons_codviaMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_Activo.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_ActivoOK
        {
            get { return m_serv_activoOK; }
            set
            {
                if (m_serv_activoOK != value)
                { m_serv_activoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_Activo.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_ActivoMSGERROR
        {
            get { return m_serv_activoMSGERROR; }
            set
            {
                if (m_serv_activoMSGERROR != value)
                { m_serv_activoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_CueVta.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_CueVtaOK
        {
            get { return m_serv_cuevtaOK; }
            set
            {
                if (m_serv_cuevtaOK != value)
                { m_serv_cuevtaOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_CueVta.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_CueVtaMSGERROR
        {
            get { return m_serv_cuevtaMSGERROR; }
            set
            {
                if (m_serv_cuevtaMSGERROR != value)
                { m_serv_cuevtaMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_CueGas.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_CueGasOK
        {
            get { return m_serv_cuegasOK; }
            set
            {
                if (m_serv_cuegasOK != value)
                { m_serv_cuegasOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_CueGas.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_CueGasMSGERROR
        {
            get { return m_serv_cuegasMSGERROR; }
            set
            {
                if (m_serv_cuegasMSGERROR != value)
                { m_serv_cuegasMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_Agrup1.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_Agrup1OK
        {
            get { return m_serv_agrup1OK; }
            set
            {
                if (m_serv_agrup1OK != value)
                { m_serv_agrup1OK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_Agrup1.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_Agrup1MSGERROR
        {
            get { return m_serv_agrup1MSGERROR; }
            set
            {
                if (m_serv_agrup1MSGERROR != value)
                { m_serv_agrup1MSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_Agrup2.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_Agrup2OK
        {
            get { return m_serv_agrup2OK; }
            set
            {
                if (m_serv_agrup2OK != value)
                { m_serv_agrup2OK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_Agrup2.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_Agrup2MSGERROR
        {
            get { return m_serv_agrup2MSGERROR; }
            set
            {
                if (m_serv_agrup2MSGERROR != value)
                { m_serv_agrup2MSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_PorDet.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_PorDetOK
        {
            get { return m_serv_pordetOK; }
            set
            {
                if (m_serv_pordetOK != value)
                { m_serv_pordetOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_PorDet.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_PorDetMSGERROR
        {
            get { return m_serv_pordetMSGERROR; }
            set
            {
                if (m_serv_pordetMSGERROR != value)
                { m_serv_pordetMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_Tipo.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_TipoOK
        {
            get { return m_serv_tipoOK; }
            set
            {
                if (m_serv_tipoOK != value)
                { m_serv_tipoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_Tipo.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_TipoMSGERROR
        {
            get { return m_serv_tipoMSGERROR; }
            set
            {
                if (m_serv_tipoMSGERROR != value)
                { m_serv_tipoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_Valor.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_ValorOK
        {
            get { return m_serv_valorOK; }
            set
            {
                if (m_serv_valorOK != value)
                { m_serv_valorOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_Valor.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_ValorMSGERROR
        {
            get { return m_serv_valorMSGERROR; }
            set
            {
                if (m_serv_valorMSGERROR != value)
                { m_serv_valorMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_CobMin.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_CobMinOK
        {
            get { return m_serv_cobminOK; }
            set
            {
                if (m_serv_cobminOK != value)
                { m_serv_cobminOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_CobMin.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_CobMinMSGERROR
        {
            get { return m_serv_cobminMSGERROR; }
            set
            {
                if (m_serv_cobminMSGERROR != value)
                { m_serv_cobminMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_Autom.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_AutomOK
        {
            get { return m_serv_automOK; }
            set
            {
                if (m_serv_automOK != value)
                { m_serv_automOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_Autom.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_AutomMSGERROR
        {
            get { return m_serv_automMSGERROR; }
            set
            {
                if (m_serv_automMSGERROR != value)
                { m_serv_automMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_FrecFac.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_FrecFacOK
        {
            get { return m_serv_frecfacOK; }
            set
            {
                if (m_serv_frecfacOK != value)
                { m_serv_frecfacOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_FrecFac.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_FrecFacMSGERROR
        {
            get { return m_serv_frecfacMSGERROR; }
            set
            {
                if (m_serv_frecfacMSGERROR != value)
                { m_serv_frecfacMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_TabUNT.
        /// </summary>
        [IgnoreDataMember]
        public Boolean TIPO_TabUNTOK
        {
            get { return m_tipo_tabuntOK; }
            set
            {
                if (m_tipo_tabuntOK != value)
                { m_tipo_tabuntOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_TabUNT.
        /// </summary>
        [IgnoreDataMember]
        public String TIPO_TabUNTMSGERROR
        {
            get { return m_tipo_tabuntMSGERROR; }
            set
            {
                if (m_tipo_tabuntMSGERROR != value)
                { m_tipo_tabuntMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_CodUNT.
        /// </summary>
        [IgnoreDataMember]
        public Boolean TIPO_CodUNTOK
        {
            get { return m_tipo_coduntOK; }
            set
            {
                if (m_tipo_coduntOK != value)
                { m_tipo_coduntOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_CodUNT.
        /// </summary>
        [IgnoreDataMember]
        public String TIPO_CodUNTMSGERROR
        {
            get { return m_tipo_coduntMSGERROR; }
            set
            {
                if (m_tipo_coduntMSGERROR != value)
                { m_tipo_coduntMSGERROR = value; }
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
        /// Gets or sets el valor de validación de: SERV_CuenIngreso.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_CuenIngresoOK
        {
            get { return m_serv_cueningresoOK; }
            set
            {
                if (m_serv_cueningresoOK != value)
                { m_serv_cueningresoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_CuenIngreso.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_CuenIngresoMSGERROR
        {
            get { return m_serv_cueningresoMSGERROR; }
            set
            {
                if (m_serv_cueningresoMSGERROR != value)
                { m_serv_cueningresoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_CuenCosto.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_CuenCostoOK
        {
            get { return m_serv_cuencostoOK; }
            set
            {
                if (m_serv_cuencostoOK != value)
                { m_serv_cuencostoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_CuenCosto.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_CuenCostoMSGERROR
        {
            get { return m_serv_cuencostoMSGERROR; }
            set
            {
                if (m_serv_cuencostoMSGERROR != value)
                { m_serv_cuencostoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_CuenPuente.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_CuenPuenteOK
        {
            get { return m_serv_cuenpuenteOK; }
            set
            {
                if (m_serv_cuenpuenteOK != value)
                { m_serv_cuenpuenteOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_CuenPuente.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_CuenPuenteMSGERROR
        {
            get { return m_serv_cuenpuenteMSGERROR; }
            set
            {
                if (m_serv_cuenpuenteMSGERROR != value)
                { m_serv_cuenpuenteMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_TabDET.
        /// </summary>
        [IgnoreDataMember]
        public Boolean TIPO_TabDETOK
        {
            get { return m_tipo_tabdetOK; }
            set
            {
                if (m_tipo_tabdetOK != value)
                { m_tipo_tabdetOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_TabDET.
        /// </summary>
        [IgnoreDataMember]
        public String TIPO_TabDETMSGERROR
        {
            get { return m_tipo_tabdetMSGERROR; }
            set
            {
                if (m_tipo_tabdetMSGERROR != value)
                { m_tipo_tabdetMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_CodDET.
        /// </summary>
        [IgnoreDataMember]
        public Boolean TIPO_CodDETOK
        {
            get { return m_tipo_coddetOK; }
            set
            {
                if (m_tipo_coddetOK != value)
                { m_tipo_coddetOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_CodDET.
        /// </summary>
        [IgnoreDataMember]
        public String TIPO_CodDETMSGERROR
        {
            get { return m_tipo_coddetMSGERROR; }
            set
            {
                if (m_tipo_coddetMSGERROR != value)
                { m_tipo_coddetMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_NombreCorto.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_NombreCortoOK
        {
            get { return m_serv_nombrecortoOK; }
            set
            {
                if (m_serv_nombrecortoOK != value)
                { m_serv_nombrecortoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_NombreCorto.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_NombreCortoMSGERROR
        {
            get { return m_serv_nombrecortoMSGERROR; }
            set
            {
                if (m_serv_nombrecortoMSGERROR != value)
                { m_serv_nombrecortoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_Glosa.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_GlosaOK
        {
            get { return m_serv_glosaOK; }
            set
            {
                if (m_serv_glosaOK != value)
                { m_serv_glosaOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_Glosa.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_GlosaMSGERROR
        {
            get { return m_serv_glosaMSGERROR; }
            set
            {
                if (m_serv_glosaMSGERROR != value)
                { m_serv_glosaMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_Observaciones.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_ObservacionesOK
        {
            get { return m_serv_observacionesOK; }
            set
            {
                if (m_serv_observacionesOK != value)
                { m_serv_observacionesOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_Observaciones.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_ObservacionesMSGERROR
        {
            get { return m_serv_observacionesMSGERROR; }
            set
            {
                if (m_serv_observacionesMSGERROR != value)
                { m_serv_observacionesMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: SERV_TipoMov.
        /// </summary>
        [IgnoreDataMember]
        public Boolean SERV_TipoMovOK
        {
            get { return m_serv_tipomovOK; }
            set
            {
                if (m_serv_tipomovOK != value)
                { m_serv_tipomovOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: SERV_TipoMov.
        /// </summary>
        [IgnoreDataMember]
        public String SERV_TipoMovMSGERROR
        {
            get { return m_serv_tipomovMSGERROR; }
            set
            {
                if (m_serv_tipomovMSGERROR != value)
                { m_serv_tipomovMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CONS_TabBAS.
        /// </summary>
        [IgnoreDataMember]
        public Boolean CONS_TabBASOK
        {
            get { return m_cons_tabbasOK; }
            set
            {
                if (m_cons_tabbasOK != value)
                { m_cons_tabbasOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_TabBAS.
        /// </summary>
        [IgnoreDataMember]
        public String CONS_TabBASMSGERROR
        {
            get { return m_cons_tabbasMSGERROR; }
            set
            {
                if (m_cons_tabbasMSGERROR != value)
                { m_cons_tabbasMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CONS_CodBAS.
        /// </summary>
        [IgnoreDataMember]
        public Boolean CONS_CodBASOK
        {
            get { return m_cons_codbasOK; }
            set
            {
                if (m_cons_codbasOK != value)
                { m_cons_codbasOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_CodBAS.
        /// </summary>
        [IgnoreDataMember]
        public String CONS_CodBASMSGERROR
        {
            get { return m_cons_codbasMSGERROR; }
            set
            {
                if (m_cons_codbasMSGERROR != value)
                { m_cons_codbasMSGERROR = value; }
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
        /// Gets or sets el valor de validación de: CONS_TabLNG.
        /// </summary>
        [IgnoreDataMember]
        public Boolean CONS_TabLNGOK
        {
            get { return m_cons_tablngOK; }
            set
            {
                if (m_cons_tablngOK != value)
                { m_cons_tablngOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_TabLNG.
        /// </summary>
        [IgnoreDataMember]
        public String CONS_TabLNGMSGERROR
        {
            get { return m_cons_tablngMSGERROR; }
            set
            {
                if (m_cons_tablngMSGERROR != value)
                { m_cons_tablngMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CONS_CodLNG.
        /// </summary>
        [IgnoreDataMember]
        public Boolean CONS_CodLNGOK
        {
            get { return m_cons_codlngOK; }
            set
            {
                if (m_cons_codlngOK != value)
                { m_cons_codlngOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_CodLNG.
        /// </summary>
        [IgnoreDataMember]
        public String CONS_CodLNGMSGERROR
        {
            get { return m_cons_codlngMSGERROR; }
            set
            {
                if (m_cons_codlngMSGERROR != value)
                { m_cons_codlngMSGERROR = value; }
            }
        }

        /// <summary>
        /// Gets or sets el valor de validación de: ItemsServicioDoc.
        /// </summary>
        [DataMember]
        public Boolean ItemsServicioDocumentosOK
        {
            get { return m_itemsserviciodocumentosOK; }
            set
            {
                if (m_itemsserviciodocumentosOK != value)
                {
                    m_itemsserviciodocumentosOK = value;
                    OnPropertyChanged("ItemsServicioDocumentosOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ItemsServicio.
        /// </summary>
        [DataMember]
        public String ItemsServicioDocumentosMSGERROR
        {
            get { return m_itemsserviciodocumentosMSGERROR; }
            set
            {
                if (m_itemsserviciodocumentosMSGERROR != value)
                {
                    m_itemsserviciodocumentosMSGERROR = value;
                    OnPropertyChanged("ItemsServicioDocumentosMSGERROR");
                }
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
            SERV_CodigoOK = true;
            SERV_CodigoMSGERROR = "";
            //if (SERV_Codigo == null)
            //{
            //   _isCorrect = false;
            //   SERV_CodigoOK = false;
            //   SERV_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "SERV_Codigo", "Servicio");
            //   m_mensajeError += "* Debe ingresar el campo SERV_Codigo" + Environment.NewLine;
            //}
            
            //CONS_CodLNGOK = true;
            //CONS_CodLNGMSGERROR = "";
            //if (String.IsNullOrEmpty(CONS_TabVia) || String.IsNullOrEmpty(CONS_CodVia))
            //{
            //    _isCorrect = false;
            //    CONS_TabLNGOK = false;
            //    CONS_CodLNGOK = false;
            //    CONS_TabLNGMSGERROR = String.Format("Debe seleccionar la {0} de {1}.", "Linea", "Negocio");
            //    CONS_CodLNGMSGERROR = String.Format("Debe seleccionar la {0} de {1}.", "Linea", "Negocio");
            //    m_mensajeError += "* Debe seleccionar el campo Linea de Negocio" + Environment.NewLine;
            //}

            SERV_TipoMovOK = true;
            SERV_TipoMovMSGERROR = "";
            if (String.IsNullOrEmpty(SERV_TipoMov))
            {
                _isCorrect = false;
                SERV_TipoMovOK = false;
                SERV_TipoMovMSGERROR = String.Format("Debe seleccionar el {0} de {1}.", "Tipo", "Movimiento");
                m_mensajeError += "* Debe ingresar el campo Tipo de Movimiento" + Environment.NewLine;
            }

            TIPO_TabMNDOK = true;
            TIPO_TabMNDMSGERROR = "";
            TIPO_CodMNDOK = true;
            TIPO_CodMNDMSGERROR = "";
            if (String.IsNullOrEmpty(TIPO_TabMND) || String.IsNullOrEmpty(TIPO_CodMND))
            {
                _isCorrect = false;
                TIPO_CodMNDOK = false;
                TIPO_CodMNDOK = false;
                TIPO_CodMNDMSGERROR = String.Format("Debe seleccionar el {0} de {1}.", "Tipo", "Moneda");
                TIPO_CodMNDMSGERROR = String.Format("Debe seleccionar el {0} de {1}.", "Tipo", "Moneda");
                m_mensajeError += "* Debe seleccionar el Tipo de Moneda" + Environment.NewLine;
            }

            CONS_TabBASOK = true;
            CONS_TabBASMSGERROR = "";
            CONS_CodBASOK = true;
            CONS_CodBASMSGERROR = "";
            if (String.IsNullOrEmpty(CONS_TabBAS) || String.IsNullOrEmpty(CONS_CodBAS))
            {
                _isCorrect = false;
                CONS_TabBASOK = false;
                CONS_CodBASOK = false;
                CONS_TabBASMSGERROR = String.Format("Debe seleccionar la {0} de {1}.", "Base", "Cálculo");
                CONS_CodBASMSGERROR = String.Format("Debe seleccionar la {0} de {1}.", "Base", "Cálculo");
                m_mensajeError += "* Debe seleccionar la Base de Cálculo" + Environment.NewLine;
            }

            SERV_NombreCortoOK = true;
            SERV_NombreCortoMSGERROR = "";
            if (String.IsNullOrEmpty(SERV_NombreCorto))
            {
                _isCorrect = false;
                SERV_NombreCortoOK = false;
                SERV_NombreCortoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Nombre Corto ", "Servicio");
                m_mensajeError += "* Debe ingresar el campo Nombre Corto" + Environment.NewLine;
            }


				SERV_Nombre_SPAOK  = true;
				SERV_Nombre_SPAMSGERROR  = "";
				if( String.IsNullOrEmpty(SERV_Nombre_SPA) )
				{
					_isCorrect = false;
					SERV_Nombre_SPAOK  = false;
					SERV_Nombre_SPAMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Nombre en Español", "Servicio");
					m_mensajeError += "* Debe ingresar el campo Nombre Español" + Environment.NewLine;
				}

                SERV_Nombre_ENGOK  = true;
                SERV_Nombre_ENGMSGERROR  = "";
                //if( String.IsNullOrEmpty(SERV_Nombre_ENG) )
                //{
                //    _isCorrect = false;
                //    SERV_Nombre_ENGOK  = false;
                //    SERV_Nombre_ENGMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Nombre en Ingles", "Servicio");
                //    m_mensajeError += "* Debe ingresar el campo Nombre Ingles" + Environment.NewLine;
                //}

				SERV_ActivoOK  = true;
				SERV_ActivoMSGERROR  = "";
				if( SERV_Activo == null)
				{
					_isCorrect = false;
					SERV_ActivoOK  = false;
					SERV_ActivoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SERV_Activo", "Servicio");
					m_mensajeError += "* Debe ingresar el campo SERV_Activo" + Environment.NewLine;
				}
				SERV_PorDetOK  = true;
				SERV_PorDetMSGERROR  = "";
				if( SERV_PorDet == null)
				{
					_isCorrect = false;
					SERV_PorDetOK  = false;
					SERV_PorDetMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SERV_PorDet", "Servicio");
					m_mensajeError += "* Debe ingresar el campo SERV_PorDet" + Environment.NewLine;
				}
                
                SERV_TipoOK  = true;
				SERV_TipoMSGERROR  = "";
            //if( String.IsNullOrEmpty(SERV_Tipo) )
            //{
            //   _isCorrect = false;
            //   SERV_TipoOK  = false;
            //   SERV_TipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SERV_Tipo", "Servicio");
            //   m_mensajeError += "* Debe ingresar el campo SERV_Tipo" + Environment.NewLine;
            //}
				SERV_ValorOK  = true;
				SERV_ValorMSGERROR  = "";
                if (SERV_Valor < 0)
				{
					_isCorrect = false;
					SERV_ValorOK  = false;
					SERV_ValorMSGERROR  = String.Format("Debe ingresar un {0} a {1}.", "Valor mayor", "Cero");
					m_mensajeError += "* Debe ingresar un Valor mayoro igual a Cero" + Environment.NewLine;
				}
				SERV_CobMinOK  = true;
				SERV_CobMinMSGERROR  = "";
                if (SERV_CobMin < 0) 
                {
                    _isCorrect = false;
                    SERV_CobMinOK = false;
                    SERV_CobMinMSGERROR = String.Format("Debe ingresar un {0} a {1}.", "Valor mayor", "Cero");
                    m_mensajeError += "* Debe ingresar un Valor mayor igual a Cero" + Environment.NewLine;
                }

            SERV_FrecFacOK = true;
            SERV_FrecFacMSGERROR = "";
            //if (String.IsNullOrEmpty(SERV_FrecFac))
            //{
            //   //_isCorrect = false;
            //   //SERV_FrecFacOK = false;
            //   //SERV_FrecFacMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "SERV_FrecFac", "Servicio");
            //   //m_mensajeError += "* Debe ingresar el campo SERV_FrecFac" + Environment.NewLine;
            //}

            //CONS_TabRGMOK = true;
            //CONS_TabRGMMSGERROR = "";
            //CONS_CodRGMOK = true;
            //CONS_CodRGMMSGERROR = "";
            //if (String.IsNullOrEmpty(CONS_TabRGM) || String.IsNullOrEmpty(CONS_CodRGM))
            //{
            //   _isCorrect = false;
            //   CONS_TabRGMOK = false;
            //   CONS_CodRGMOK = false;
            //   CONS_TabRGMMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Régimen", "Servicio");
            //   CONS_CodRGMMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Régimen", "Servicio");
            //   m_mensajeError += "* Debe seleccionar el campo Régimen" + Environment.NewLine;
            //}

            //CONS_TabViaOK = true;
            //CONS_TabViaMSGERROR = "";
            //CONS_CodViaOK = true;
            //CONS_CodViaMSGERROR = "";
            //if (String.IsNullOrEmpty(CONS_TabVia) || String.IsNullOrEmpty(CONS_CodVia))
            //{
            //   _isCorrect = false;
            //   CONS_TabViaOK = false;
            //   CONS_CodViaOK = false;
            //   CONS_TabViaMSGERROR = String.Format("Debe seleccionar la {0} del {1}.", "Vía", "Servicio");
            //   CONS_CodViaMSGERROR = String.Format("Debe seleccionar la {0} del {1}.", "Vía", "Servicio");
            //   m_mensajeError += "* Debe seleccionar el campo Vía" + Environment.NewLine;
            //}

            ItemsServicioDocumentosOK = true;
            ItemsServicioDocumentosMSGERROR = "";
            Int32 _item = 1;
            foreach (ServiciosDocumentos _itemServicioDoc in ServiciosDocumentos)
            {
                String _menssage = String.Empty;
                if (String.IsNullOrEmpty(_itemServicioDoc.SEDO_Tipo))
                {
                    _menssage += "        * Debe seleccionar un Tipo de Movimiento" + Environment.NewLine;
                    ItemsServicioDocumentosOK = false;
                    _isCorrect = false;
                }
                if (String.IsNullOrEmpty(_itemServicioDoc.TIPO_TabTDO) || String.IsNullOrEmpty(_itemServicioDoc.TIPO_CodTDO))
                {
                    _menssage += "        * Debe seleccionar un Tipo de Documento" + Environment.NewLine;
                    ItemsServicioDocumentosOK = false;
                    _isCorrect = false;
                }
                if (!_isCorrect)
                {
                    ItemsServicioDocumentosMSGERROR += "    * Item: " + _item.ToString() + Environment.NewLine;
                    ItemsServicioDocumentosMSGERROR += _menssage;
                }
                _item++;
            }
            if (!ItemsServicioDocumentosOK)
            {
                m_mensajeError += "* La Grilla de Documentos contiene los siguientes errores: " + Environment.NewLine;
                m_mensajeError += ItemsServicioDocumentosMSGERROR + Environment.NewLine;
            }

            OnPropertyChanged("MensajeError");
            return _isCorrect;
         }
			
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
