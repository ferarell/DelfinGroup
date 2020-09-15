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
    #region(variables)
    /// <summary>
    /// CRISTHIAN JOSE APAZA 
    /// ESTADO NAVE VIAJE
    /// </summary>
    public sealed class Estado
    {

        private Estado() { }
        //ESTADOS
        public const string Abierto = "A";
        public const string PreFacturado = "P";
        public const string Cerrado = "C";
    }
    #endregion
    public partial class NaveViaje
	{
		#region [ Variables Validación ]
        private Boolean m_nvia_codigoOK;
        private String m_nvia_codigoMSGERROR;
        private Boolean m_nvia_nroviajeOK;
        private String m_nvia_nroviajeMSGERROR;
        private Boolean m_nvia_feceta_impo_etd_expoOK;
        private String m_nvia_feceta_impo_etd_expoMSGERROR;
        private Boolean m_entc_codagenteport_expoOK;
        private String m_entc_codagenteport_expoMSGERROR;
        private Boolean m_entc_codtransportistaOK;
        private String m_entc_codtransportistaMSGERROR;
        private Boolean m_nave_codigoOK;
        private String m_nave_codigoMSGERROR;
        private Boolean m_audi_feccreaOK;
        private String m_audi_feccreaMSGERROR;
        private Boolean m_audi_usrcreaOK;
        private String m_audi_usrcreaMSGERROR;
        private Boolean m_audi_fecmodOK;
        private String m_audi_fecmodMSGERROR;
        private Boolean m_audi_usrmodOK;
        private String m_audi_usrmodMSGERROR;
        private Boolean m_nvia_feccutoff_expoOK;
        private String m_nvia_feccutoff_expoMSGERROR;
        private Boolean m_puer_codigoOK;
        private String m_puer_codigoMSGERROR;
        private Boolean m_tipo_tabtrfOK;
        private String m_tipo_tabtrfMSGERROR;
        private Boolean m_tipo_codtrfOK;
        private String m_tipo_codtrfMSGERROR;
        private Boolean m_cons_tabrgmOK;
        private String m_cons_tabrgmMSGERROR;
        private Boolean m_cons_codrgmOK;
        private String m_cons_codrgmMSGERROR;
        private Boolean m_entc_codtermportOK;
        private String m_entc_codtermportMSGERROR;
        private Boolean m_nvia_feccierreOK;
        private String m_nvia_feccierreMSGERROR;
        private Boolean m_nvia_fecllega_impo_zarpe_expoOK;
        private String m_nvia_fecllega_impo_zarpe_expoMSGERROR;
        private Boolean m_cons_tabviaOK;
        private String m_cons_tabviaMSGERROR;
        private Boolean m_cons_codviaOK;
        private String m_cons_codviaMSGERROR;
        private Boolean m_nvia_estadoOK;
        private String m_nvia_estadoMSGERROR;
        private Boolean m_nvia_feccierredire_impo_termemba_expoOK;
        private String m_nvia_feccierredire_impo_termemba_expoMSGERROR;
        
        private Boolean m_nvia_fecplazovistobuenoOK;
        private String m_nvia_fecplazovistobuenoMSGERROR;

        private Boolean m_nvia_fecdescarga_impoOK;
        private String m_nvia_fecdescarga_impoMSGERROR;
        private Boolean m_entc_codagenportvobo_impoOK;
        private String m_entc_codagenportvobo_impoMSGERROR;
        private Boolean m_entc_codagenportvobo2_impoOK;
        private String m_entc_codagenportvobo2_impoMSGERROR;
        private Boolean m_entc_fecrecogerdocsOK;
        private String m_entc_fecrecogerdocsMSGERROR;
        private Boolean m_nvia_usrprefacturaOK;
        private String m_nvia_usrprefacturaMSGERROR;
        private Boolean m_nvia_fecprefacturaOK;
        private String m_nvia_fecprefacturaMSGERROR;
        private Boolean m_nvia_usrcierrenaveOK;
        private String m_nvia_usrcierrenaveMSGERROR;
        private Boolean m_nvia_feccierrenaveOK;
        private String m_nvia_feccierrenaveMSGERROR;
        private Boolean m_nvia_nromanifiestoOK;
        private String m_nvia_nromanifiestoMSGERROR;
        private Boolean m_nvia_normanifiestodesconOK;
        private String m_nvia_normanifiestodesconMSGERROR;
		#endregion

        #region [ Propiedades Validación ]
        /// <summary>
        /// Gets or sets el valor de validación de: NVIA_Codigo.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_CodigoOK
        {
            get { return m_nvia_codigoOK; }
            set
            {
                if (m_nvia_codigoOK != value)
                { m_nvia_codigoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_Codigo.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_CodigoMSGERROR
        {
            get { return m_nvia_codigoMSGERROR; }
            set
            {
                if (m_nvia_codigoMSGERROR != value)
                { m_nvia_codigoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: NVIA_NroViaje.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_NroViajeOK
        {
            get { return m_nvia_nroviajeOK; }
            set
            {
                if (m_nvia_nroviajeOK != value)
                { m_nvia_nroviajeOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_NroViaje.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_NroViajeMSGERROR
        {
            get { return m_nvia_nroviajeMSGERROR; }
            set
            {
                if (m_nvia_nroviajeMSGERROR != value)
                { m_nvia_nroviajeMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: NVIA_FecETA_IMPO_ETD_EXPO.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_FecETA_IMPO_ETD_EXPOOK
        {
            get { return m_nvia_feceta_impo_etd_expoOK; }
            set
            {
                if (m_nvia_feceta_impo_etd_expoOK != value)
                { m_nvia_feceta_impo_etd_expoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_FecETA_IMPO_ETD_EXPO.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_FecETA_IMPO_ETD_EXPOMSGERROR
        {
            get { return m_nvia_feceta_impo_etd_expoMSGERROR; }
            set
            {
                if (m_nvia_feceta_impo_etd_expoMSGERROR != value)
                { m_nvia_feceta_impo_etd_expoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: ENTC_CodAgentePort_EXPO.
        /// </summary>
        [IgnoreDataMember]
        public Boolean ENTC_CodAgentePort_EXPOOK
        {
            get { return m_entc_codagenteport_expoOK; }
            set
            {
                if (m_entc_codagenteport_expoOK != value)
                { m_entc_codagenteport_expoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ENTC_CodAgentePort_EXPO.
        /// </summary>
        [IgnoreDataMember]
        public String ENTC_CodAgentePort_EXPOMSGERROR
        {
            get { return m_entc_codagenteport_expoMSGERROR; }
            set
            {
                if (m_entc_codagenteport_expoMSGERROR != value)
                { m_entc_codagenteport_expoMSGERROR = value; }
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
        /// Gets or sets el valor de validación de: NAVE_Codigo.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NAVE_CodigoOK
        {
            get { return m_nave_codigoOK; }
            set
            {
                if (m_nave_codigoOK != value)
                { m_nave_codigoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NAVE_Codigo.
        /// </summary>
        [IgnoreDataMember]
        public String NAVE_CodigoMSGERROR
        {
            get { return m_nave_codigoMSGERROR; }
            set
            {
                if (m_nave_codigoMSGERROR != value)
                { m_nave_codigoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: NVIA_FecCutOff_EXPO.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_FecCutOff_EXPOOK
        {
            get { return m_nvia_feccutoff_expoOK; }
            set
            {
                if (m_nvia_feccutoff_expoOK != value)
                { m_nvia_feccutoff_expoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_FecCutOff_EXPO.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_FecCutOff_EXPOMSGERROR
        {
            get { return m_nvia_feccutoff_expoMSGERROR; }
            set
            {
                if (m_nvia_feccutoff_expoMSGERROR != value)
                { m_nvia_feccutoff_expoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: PUER_Codigo.
        /// </summary>
        [IgnoreDataMember]
        public Boolean PUER_CodigoOK
        {
            get { return m_puer_codigoOK; }
            set
            {
                if (m_puer_codigoOK != value)
                { m_puer_codigoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: PUER_Codigo.
        /// </summary>
        [IgnoreDataMember]
        public String PUER_CodigoMSGERROR
        {
            get { return m_puer_codigoMSGERROR; }
            set
            {
                if (m_puer_codigoMSGERROR != value)
                { m_puer_codigoMSGERROR = value; }
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
        /// Gets or sets el valor de validación de: ENTC_CodTermPort.
        /// </summary>
        [IgnoreDataMember]
        public Boolean ENTC_CodTermPortOK
        {
            get { return m_entc_codtermportOK; }
            set
            {
                if (m_entc_codtermportOK != value)
                { m_entc_codtermportOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ENTC_CodTermPort.
        /// </summary>
        [IgnoreDataMember]
        public String ENTC_CodTermPortMSGERROR
        {
            get { return m_entc_codtermportMSGERROR; }
            set
            {
                if (m_entc_codtermportMSGERROR != value)
                { m_entc_codtermportMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: NVIA_FecCierre.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_FecCierreOK
        {
            get { return m_nvia_feccierreOK; }
            set
            {
                if (m_nvia_feccierreOK != value)
                { m_nvia_feccierreOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_FecCierre.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_FecCierreMSGERROR
        {
            get { return m_nvia_feccierreMSGERROR; }
            set
            {
                if (m_nvia_feccierreMSGERROR != value)
                { m_nvia_feccierreMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: NVIA_FecLlega_IMPO_Zarpe_EXPO.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_FecLlega_IMPO_Zarpe_EXPOOK
        {
            get { return m_nvia_fecllega_impo_zarpe_expoOK; }
            set
            {
                if (m_nvia_fecllega_impo_zarpe_expoOK != value)
                { m_nvia_fecllega_impo_zarpe_expoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_FecLlega_IMPO_Zarpe_EXPO.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_FecLlega_IMPO_Zarpe_EXPOMSGERROR
        {
            get { return m_nvia_fecllega_impo_zarpe_expoMSGERROR; }
            set
            {
                if (m_nvia_fecllega_impo_zarpe_expoMSGERROR != value)
                { m_nvia_fecllega_impo_zarpe_expoMSGERROR = value; }
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
        /// Gets or sets el valor de validación de: NVIA_Estado.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_EstadoOK
        {
            get { return m_nvia_estadoOK; }
            set
            {
                if (m_nvia_estadoOK != value)
                { m_nvia_estadoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_Estado.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_EstadoMSGERROR
        {
            get { return m_nvia_estadoMSGERROR; }
            set
            {
                if (m_nvia_estadoMSGERROR != value)
                { m_nvia_estadoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: NVIA_FecCierreDire_IMPO_TermEmba_EXPO.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_FecCierreDire_IMPO_TermEmba_EXPOOK
        {
            get { return m_nvia_feccierredire_impo_termemba_expoOK; }
            set
            {
                if (m_nvia_feccierredire_impo_termemba_expoOK != value)
                { m_nvia_feccierredire_impo_termemba_expoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_FecCierreDire_IMPO_TermEmba_EXPO.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_FecCierreDire_IMPO_TermEmba_EXPOMSGERROR
        {
            get { return m_nvia_feccierredire_impo_termemba_expoMSGERROR; }
            set
            {
                if (m_nvia_feccierredire_impo_termemba_expoMSGERROR != value)
                { m_nvia_feccierredire_impo_termemba_expoMSGERROR = value; }
            }
        }

        /// <summary>
        /// Gets or sets el valor de validación de: NVIA_FecPlazoVistoBueno.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_FecPlazoVistoBuenoOK
        {
            get { return m_nvia_fecplazovistobuenoOK; }
            set
            {
                if (m_nvia_fecplazovistobuenoOK != value)
                { m_nvia_fecplazovistobuenoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_FecPlazoVistoBueno.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_FecPlazoVistoBuenoMSGERROR
        {
            get { return m_nvia_fecplazovistobuenoMSGERROR; }
            set
            {
                if (m_nvia_fecplazovistobuenoMSGERROR != value)
                { m_nvia_fecplazovistobuenoMSGERROR = value; }
            }
        }

        /// <summary>
        /// Gets or sets el valor de validación de: NVIA_FecDescarga_IMPO.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_FecDescarga_IMPOOK
        {
            get { return m_nvia_fecdescarga_impoOK; }
            set
            {
                if (m_nvia_fecdescarga_impoOK != value)
                { m_nvia_fecdescarga_impoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_FecDescarga_IMPO.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_FecDescarga_IMPOMSGERROR
        {
            get { return m_nvia_fecdescarga_impoMSGERROR; }
            set
            {
                if (m_nvia_fecdescarga_impoMSGERROR != value)
                { m_nvia_fecdescarga_impoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: ENTC_CodAgenPortVoBo_IMPO.
        /// </summary>
        [IgnoreDataMember]
        public Boolean ENTC_CodAgenPortVoBo_IMPOOK
        {
            get { return m_entc_codagenportvobo_impoOK; }
            set
            {
                if (m_entc_codagenportvobo_impoOK != value)
                { m_entc_codagenportvobo_impoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ENTC_CodAgenPortVoBo_IMPO.
        /// </summary>
        [IgnoreDataMember]
        public String ENTC_CodAgenPortVoBo_IMPOMSGERROR
        {
            get { return m_entc_codagenportvobo_impoMSGERROR; }
            set
            {
                if (m_entc_codagenportvobo_impoMSGERROR != value)
                { m_entc_codagenportvobo_impoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: ENTC_CodAgenPortVoBo2_IMPO.
        /// </summary>
        [IgnoreDataMember]
        public Boolean ENTC_CodAgenPortVoBo2_IMPOOK
        {
            get { return m_entc_codagenportvobo2_impoOK; }
            set
            {
                if (m_entc_codagenportvobo2_impoOK != value)
                { m_entc_codagenportvobo2_impoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ENTC_CodAgenPortVoBo2_IMPO.
        /// </summary>
        [IgnoreDataMember]
        public String ENTC_CodAgenPortVoBo2_IMPOMSGERROR
        {
            get { return m_entc_codagenportvobo2_impoMSGERROR; }
            set
            {
                if (m_entc_codagenportvobo2_impoMSGERROR != value)
                { m_entc_codagenportvobo2_impoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: ENTC_FecRecogerDocs.
        /// </summary>
        [IgnoreDataMember]
        public Boolean ENTC_FecRecogerDocsOK
        {
            get { return m_entc_fecrecogerdocsOK; }
            set
            {
                if (m_entc_fecrecogerdocsOK != value)
                { m_entc_fecrecogerdocsOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ENTC_FecRecogerDocs.
        /// </summary>
        [IgnoreDataMember]
        public String ENTC_FecRecogerDocsMSGERROR
        {
            get { return m_entc_fecrecogerdocsMSGERROR; }
            set
            {
                if (m_entc_fecrecogerdocsMSGERROR != value)
                { m_entc_fecrecogerdocsMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: NVIA_UsrPreFactura.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_UsrPreFacturaOK
        {
            get { return m_nvia_usrprefacturaOK; }
            set
            {
                if (m_nvia_usrprefacturaOK != value)
                { m_nvia_usrprefacturaOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_UsrPreFactura.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_UsrPreFacturaMSGERROR
        {
            get { return m_nvia_usrprefacturaMSGERROR; }
            set
            {
                if (m_nvia_usrprefacturaMSGERROR != value)
                { m_nvia_usrprefacturaMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: NVIA_FecPreFactura.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_FecPreFacturaOK
        {
            get { return m_nvia_fecprefacturaOK; }
            set
            {
                if (m_nvia_fecprefacturaOK != value)
                { m_nvia_fecprefacturaOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_FecPreFactura.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_FecPreFacturaMSGERROR
        {
            get { return m_nvia_fecprefacturaMSGERROR; }
            set
            {
                if (m_nvia_fecprefacturaMSGERROR != value)
                { m_nvia_fecprefacturaMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: NVIA_UsrCierreNave.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_UsrCierreNaveOK
        {
            get { return m_nvia_usrcierrenaveOK; }
            set
            {
                if (m_nvia_usrcierrenaveOK != value)
                { m_nvia_usrcierrenaveOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_UsrCierreNave.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_UsrCierreNaveMSGERROR
        {
            get { return m_nvia_usrcierrenaveMSGERROR; }
            set
            {
                if (m_nvia_usrcierrenaveMSGERROR != value)
                { m_nvia_usrcierrenaveMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: NVIA_FecCierreNave.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_FecCierreNaveOK
        {
            get { return m_nvia_feccierrenaveOK; }
            set
            {
                if (m_nvia_feccierrenaveOK != value)
                { m_nvia_feccierrenaveOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_FecCierreNave.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_FecCierreNaveMSGERROR
        {
            get { return m_nvia_feccierrenaveMSGERROR; }
            set
            {
                if (m_nvia_feccierrenaveMSGERROR != value)
                { m_nvia_feccierrenaveMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: NVIA_NroManifiesto.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_NroManifiestoOK
        {
            get { return m_nvia_nromanifiestoOK; }
            set
            {
                if (m_nvia_nromanifiestoOK != value)
                { m_nvia_nromanifiestoOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_NroManifiesto.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_NroManifiestoMSGERROR
        {
            get { return m_nvia_nromanifiestoMSGERROR; }
            set
            {
                if (m_nvia_nromanifiestoMSGERROR != value)
                { m_nvia_nromanifiestoMSGERROR = value; }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: NVIA_NorManifiestoDescon.
        /// </summary>
        [IgnoreDataMember]
        public Boolean NVIA_NorManifiestoDesconOK
        {
            get { return m_nvia_normanifiestodesconOK; }
            set
            {
                if (m_nvia_normanifiestodesconOK != value)
                { m_nvia_normanifiestodesconOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: NVIA_NorManifiestoDescon.
        /// </summary>
        [IgnoreDataMember]
        public String NVIA_NorManifiestoDesconMSGERROR
        {
            get { return m_nvia_normanifiestodesconMSGERROR; }
            set
            {
                if (m_nvia_normanifiestodesconMSGERROR != value)
                { m_nvia_normanifiestodesconMSGERROR = value; }
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

                ENTC_CodTransportistaOK = true;
                ENTC_CodTransportistaMSGERROR = "";
                if (ENTC_CodTransportista == null)
                {
                    _isCorrect = false;
                    ENTC_CodTransportistaOK = false;
                    ENTC_CodTransportistaMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "Transportista", "Nave Viaje");
                    m_mensajeError += "* Debe seleccionar el Transportista de la Nave Viaje." + Environment.NewLine;
                }

                CONS_TabViaOK = true;
                CONS_TabViaMSGERROR = "";
                CONS_CodViaOK = true;
                CONS_CodViaMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_TabVia) || String.IsNullOrEmpty(CONS_CodVia))
                {
                    _isCorrect = false;
                    CONS_TabViaOK = false;
                    CONS_CodViaOK = false;
                    CONS_TabViaMSGERROR = String.Format("Debe seleccionar la {0} del {1}.", "Vía", "Nave Viaje");
                    CONS_CodViaMSGERROR = String.Format("Debe seleccionar la {0} del {1}.", "Vía", "Nave Viaje");
                    m_mensajeError += "* Debe seleccionar el campo Vía" + Environment.NewLine;
                }

                NVIA_CodigoOK = true;
                NVIA_CodigoMSGERROR = "";
                //if (NVIA_Codigo == 0)
                //{
                //    _isCorrect = false;
                //    NVIA_CodigoOK = false;
                //    NVIA_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "NVIA_Codigo", "NaveViaje");
                //    m_mensajeError += "* Debe ingresar el campo NVIA_Codigo" + Environment.NewLine;
                //}
                NVIA_NroViajeOK = true;
                NVIA_NroViajeMSGERROR = "";
                if (String.IsNullOrEmpty(NVIA_NroViaje))
                {
                    _isCorrect = false;
                    NVIA_NroViajeOK = false;
                    NVIA_NroViajeMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "NVIA_NroViaje", "Nave Viaje");
                    m_mensajeError += "* Debe ingresar el campo NVIA_NroViaje" + Environment.NewLine;
                }

                CONS_TabRGMOK = true;
                CONS_TabRGMMSGERROR = "";
                CONS_CodRGMOK = true;
                CONS_CodRGMMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_TabRGM) || String.IsNullOrEmpty(CONS_CodRGM))
                {
                    _isCorrect = false;
                    CONS_TabRGMOK = false;
                    CONS_CodRGMOK = false;
                    CONS_TabRGMMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Régimen", "Nave Viaje");
                    CONS_CodRGMMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Régimen", "Nave Viaje");
                    m_mensajeError += "* Debe seleccionar el campo Régimen" + Environment.NewLine;
                }

                PUER_CodigoOK = true;
                PUER_CodigoMSGERROR = "";
                if (PUER_Codigo == null)
                {
                    _isCorrect = false;
                    PUER_CodigoOK = false;
                    PUER_CodigoMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "Puerto ", "Nave Viaje");
                    m_mensajeError += "Debe seleccionar el Puerto de la Nave Viaje" + Environment.NewLine;
                }

                NVIA_EstadoOK = true;
                NVIA_EstadoMSGERROR = "";
                if (String.IsNullOrEmpty(NVIA_Estado))
                {
                    _isCorrect = false;
                    NVIA_EstadoOK = false;
                    NVIA_EstadoMSGERROR = String.Format("La Nave Viaje no cuenta con un Estado");
                }
                else
                {
                    if (NVIA_Estado == Estado.Cerrado)
                    {
                        
                        NVIA_NroManifiestoOK = true;
                        NVIA_NroManifiestoMSGERROR = "";
                        if (String.IsNullOrEmpty(NVIA_NroManifiesto))
                        {
                            _isCorrect = false;
                            NVIA_NroManifiestoOK = false;
                            NVIA_NroManifiestoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Nro de Manifiesto", "Nave Viaje");
                            m_mensajeError += "Debe ingresar el Nro de Manifiesto de la Nave Viaje" + Environment.NewLine;
                        }

                        if (CONS_CodVia != "002")
                        {
                            ENTC_CodTermPortOK = true;
                            ENTC_CodTermPortMSGERROR = "";
                            if (ENTC_CodTermPort == null)
                            {
                                _isCorrect = false;
                                ENTC_CodTermPortOK = false;
                                ENTC_CodTermPortMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "Terminal Portuario", "Nave Viaje");
                                m_mensajeError += "* Debe seleccionar el Terminal Portuario de la Nave Viaje." + Environment.NewLine;
                            }
                        }

                        TIPO_TabTRFOK = true;
                        TIPO_TabTRFMSGERROR = "";
                        TIPO_CodTRFOK = true;
                        TIPO_CodTRFMSGERROR = "";
                        //if (String.IsNullOrEmpty(TIPO_TabTRF) || String.IsNullOrEmpty(TIPO_CodTRF))
                        //{
                        //    _isCorrect = false;
                        //    TIPO_TabTRFOK = false;
                        //    TIPO_CodTRFOK = false;
                        //    TIPO_TabTRFMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "Trafico", "Nave Viaje");
                        //    TIPO_CodTRFMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "Trafico", "Nave Viaje");
                        //    m_mensajeError += "* Debe seleccionar el campo Tráfico" + Environment.NewLine;
                        //}

                        if (CONS_CodRGM == "002")/*EXPORTACIONES*/
                        {
                            NVIA_FecLlega_IMPO_Zarpe_EXPOOK = true;
                            NVIA_FecLlega_IMPO_Zarpe_EXPOMSGERROR = "";
                            if (NVIA_FecLlega_IMPO_Zarpe_EXPO == null)
                            {
                                _isCorrect = false;
                                NVIA_FecLlega_IMPO_Zarpe_EXPOOK = false;
                                NVIA_FecLlega_IMPO_Zarpe_EXPOMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Fecha de Zarpe", "Nave Viaje");
                                m_mensajeError += "Debe ingresar la fecha de Zarpe de la Nave Viaje" + Environment.NewLine;
                            }

                            NVIA_FecCierreDire_IMPO_TermEmba_EXPOOK = true;
                            NVIA_FecCierreDire_IMPO_TermEmba_EXPOMSGERROR = "";
                            if (NVIA_FecCierreDire_IMPO_TermEmba_EXPO == null)
                            {
                                _isCorrect = false;
                                NVIA_FecCierreDire_IMPO_TermEmba_EXPOOK = false;
                                NVIA_FecCierreDire_IMPO_TermEmba_EXPOMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Fecha de Termino de Embarque", "Nave Viaje");
                                m_mensajeError += "Debe ingresar la Fecha de Termino de Embarque de la Nave Viaje" + Environment.NewLine;
                            }
                            else
                            {

                                if (NVIA_FecLlega_IMPO_Zarpe_EXPOOK != false)
                                {
                                    if ((NVIA_FecCierreDire_IMPO_TermEmba_EXPO.Value.Date) > NVIA_FecLlega_IMPO_Zarpe_EXPO.Value.Date)
                                    {
                                        _isCorrect = false;
                                        NVIA_FecCierreDire_IMPO_TermEmba_EXPOOK = false;
                                        NVIA_FecCierreDire_IMPO_TermEmba_EXPOMSGERROR = String.Format("La Fec. Termino de embarque debe ser menor o igual a la Fecha de Zarpe");
                                    }
                                }
                            }
                            if (CONS_CodVia != "002")
                            {
                                NVIA_FecETA_IMPO_ETD_EXPOOK = true;
                                NVIA_FecETA_IMPO_ETD_EXPOMSGERROR = "";
                                if (NVIA_FecETA_IMPO_ETD_EXPO == null)
                                {
                                    _isCorrect = false;
                                    NVIA_FecETA_IMPO_ETD_EXPOOK = false;
                                    NVIA_FecETA_IMPO_ETD_EXPOMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Fecha ETD", "Nave Viaje");
                                    m_mensajeError += "Debe ingresar la fecha ETD de la Nave Viaje" + Environment.NewLine;
                                }
                                else
                                {
                                    if (NVIA_FecCierreDire_IMPO_TermEmba_EXPOOK != false)
                                    {
                                        if (NVIA_FecETA_IMPO_ETD_EXPO.Value.Date >= NVIA_FecCierreDire_IMPO_TermEmba_EXPO.Value.Date)
                                        {
                                            _isCorrect = false;
                                            NVIA_FecETA_IMPO_ETD_EXPOOK = false;
                                            NVIA_FecETA_IMPO_ETD_EXPOMSGERROR = String.Format("La Fec. ETD debe ser menor a la Fec. Termino de Embarque");
                                        }
                                    }
                                }
                                /**/
                                if (NVIA_FecETA_IMPO_ETD_EXPOOK == true && NVIA_FecLlega_IMPO_Zarpe_EXPOOK == true)
                                {
                                    if (NVIA_FecLlega_IMPO_Zarpe_EXPO.Value.Date > NVIA_FecETA_IMPO_ETD_EXPO.Value.Date)
                                    {
                                        _isCorrect = false;
                                        NVIA_FecLlega_IMPO_Zarpe_EXPOOK = false;
                                        NVIA_FecLlega_IMPO_Zarpe_EXPOMSGERROR = String.Format("La Fec. Zarpe debe ser menor o igual que la Fec. ETD");
                                    }
                                }
                                /**/
                                NVIA_FecCutOff_EXPOOK = true;
                                NVIA_FecCutOff_EXPOMSGERROR = "";
                                if (NVIA_FecCutOff_EXPO == null)
                                {
                                    _isCorrect = false;
                                    NVIA_FecCutOff_EXPOOK = false;
                                    NVIA_FecCutOff_EXPOMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Fecha CutOFF", "Nave Viaje");
                                    m_mensajeError += "Debe ingresar la fecha CutOFF de la Nave Viaje" + Environment.NewLine;
                                }
                                else
                                {
                                    if (NVIA_FecETA_IMPO_ETD_EXPOOK != false)
                                    {
                                        if (NVIA_FecCutOff_EXPO.Value.Date >= NVIA_FecETA_IMPO_ETD_EXPO.Value.Date)
                                        {
                                            _isCorrect = false;
                                            NVIA_FecCutOff_EXPOOK = false;
                                            NVIA_FecCutOff_EXPOMSGERROR = String.Format("La Fec. CutOFF debe ser menor a la Fec. ETD");
                                        }
                                    }
                                }

                                ENTC_CodAgentePort_EXPOOK = true;
                                ENTC_CodAgentePort_EXPOMSGERROR = "";
                                if (ENTC_CodAgentePort_EXPO == null)
                                {
                                    _isCorrect = false;
                                    ENTC_CodAgentePort_EXPOOK = false;
                                    ENTC_CodAgentePort_EXPOMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "Agente Portuario", "Nave Viaje");
                                    m_mensajeError += "* Debe seleccionar el Agente Portuario de la Nave Viaje." + Environment.NewLine;
                                }
                            }
                            ENTC_FecRecogerDocsOK = true;
                            ENTC_FecRecogerDocsMSGERROR = "";
                            if (ENTC_FecRecogerDocs == null)
                            {
                                _isCorrect = false;
                                ENTC_FecRecogerDocsOK = false;
                                ENTC_FecRecogerDocsMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Fecha de Recogo de Documentos", "Nave Viaje");
                                m_mensajeError += "Debe ingresar la Fecha de Recogo de Documentos de la Nave Viaje" + Environment.NewLine;
                            }
                            else 
                            {
                                if (NVIA_FecLlega_IMPO_Zarpe_EXPOOK != false)
                                {
                                    if (ENTC_FecRecogerDocs.Value.Date <= NVIA_FecLlega_IMPO_Zarpe_EXPO.Value.Date)
                                    {
                                        _isCorrect = false;
                                        ENTC_FecRecogerDocsOK = false;
                                        ENTC_FecRecogerDocsMSGERROR = String.Format("La Fec. Recogo de Documentos debe ser mayor a la Fec. Zarpe");
                                    }
                                }
                            }
                        }
                        if (CONS_CodRGM == "001")/*IMPORTACIONES*/
                        {
                            NVIA_FecETA_IMPO_ETD_EXPOOK = true;
                            NVIA_FecETA_IMPO_ETD_EXPOMSGERROR = "";
                            if (NVIA_FecETA_IMPO_ETD_EXPO == null)
                            {
                                _isCorrect = false;
                                NVIA_FecETA_IMPO_ETD_EXPOOK = false;
                                NVIA_FecETA_IMPO_ETD_EXPOMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Fecha ETA", "Nave Viaje");
                                m_mensajeError += "Debe ingresar la fecha ETA de la Nave Viaje" + Environment.NewLine;
                            }

                            NVIA_FecLlega_IMPO_Zarpe_EXPOOK = true;
                            NVIA_FecLlega_IMPO_Zarpe_EXPOMSGERROR = "";
                            if (NVIA_FecLlega_IMPO_Zarpe_EXPO == null)
                            {
                                _isCorrect = false;
                                NVIA_FecLlega_IMPO_Zarpe_EXPOOK = false;
                                NVIA_FecLlega_IMPO_Zarpe_EXPOMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Fecha de LLegada", "Nave Viaje");
                                m_mensajeError += "Debe ingresar la Fecha de LLegada de la Nave Viaje" + Environment.NewLine;
                            }
                            else
                            {
                                if (NVIA_FecETA_IMPO_ETD_EXPOOK != false)
                                {
                                    if (NVIA_FecLlega_IMPO_Zarpe_EXPO.Value.Date < NVIA_FecETA_IMPO_ETD_EXPO.Value.Date)
                                    {
                                        _isCorrect = false;
                                        NVIA_FecLlega_IMPO_Zarpe_EXPOOK = false;
                                        NVIA_FecLlega_IMPO_Zarpe_EXPOMSGERROR = String.Format("La Fec. de Llegada debe ser mayor o igual que la Fec. ETA");
                                    }
                                }
                            }

                            NVIA_FecDescarga_IMPOOK = true;
                            NVIA_FecDescarga_IMPOMSGERROR = "";
                            if (NVIA_FecDescarga_IMPO == null)
                            {
                                _isCorrect = false;
                                NVIA_FecDescarga_IMPOOK = false;
                                NVIA_FecDescarga_IMPOMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Fecha de Descarga", "Nave Viaje");
                                m_mensajeError += "Debe ingresar la Fecha de Descarga de la Nave Viaje" + Environment.NewLine;
                            }
                            else
                            {
                                if (NVIA_FecLlega_IMPO_Zarpe_EXPOOK != false)
                                {
                                    if ((NVIA_FecDescarga_IMPO.Value.Date < NVIA_FecLlega_IMPO_Zarpe_EXPO.Value.Date) || (NVIA_FecDescarga_IMPO.Value.Date > NVIA_FecLlega_IMPO_Zarpe_EXPO.Value.AddDays(10).Date))
                                    {
                                        _isCorrect = false;
                                        NVIA_FecDescarga_IMPOOK = false;
                                        NVIA_FecDescarga_IMPOMSGERROR = String.Format("La Fec. Descarga debe ser mayor como maximo en 10 dias a la Fec. de Llegada");
                                    }
                                }
                            }

                            if (CONS_CodVia != "002")
                            {
                                NVIA_FecCierreDire_IMPO_TermEmba_EXPOOK = true;
                                NVIA_FecCierreDire_IMPO_TermEmba_EXPOMSGERROR = "";
                                if (NVIA_FecCierreDire_IMPO_TermEmba_EXPO == null)
                                {
                                    _isCorrect = false;
                                    NVIA_FecCierreDire_IMPO_TermEmba_EXPOOK = false;
                                    NVIA_FecCierreDire_IMPO_TermEmba_EXPOMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Fec. de Cierre de Direccionamiento", "Nave Viaje");
                                    m_mensajeError += "Debe ingresar la Fec. de Cierre de Direccionmient de la Nave Viaje" + Environment.NewLine;
                                }
                                else
                                {
                                    if ((NVIA_FecETA_IMPO_ETD_EXPOOK != false) && (NVIA_FecLlega_IMPO_Zarpe_EXPOOK != false) && (NVIA_FecDescarga_IMPOOK != false))
                                    {
                                        if ((NVIA_FecCierreDire_IMPO_TermEmba_EXPO.Value.Date >= NVIA_FecETA_IMPO_ETD_EXPO.Value.Date) || (NVIA_FecCierreDire_IMPO_TermEmba_EXPO.Value.Date >= NVIA_FecLlega_IMPO_Zarpe_EXPO.Value.Date) || (NVIA_FecCierreDire_IMPO_TermEmba_EXPO.Value.Date >= NVIA_FecDescarga_IMPO.Value.Date))
                                        {
                                            _isCorrect = false;
                                            NVIA_FecCierreDire_IMPO_TermEmba_EXPOOK = false;
                                            NVIA_FecCierreDire_IMPO_TermEmba_EXPOMSGERROR = String.Format("La Fec. de Cierre de Direccionamiento debe ser menor a las fechas (ETA, Descarga, LLegada)");
                                        }
                                    }
                                }

                                NVIA_NorManifiestoDesconOK = true;
                                NVIA_NorManifiestoDesconMSGERROR = "";
                                if (String.IsNullOrEmpty(NVIA_NorManifiestoDescon))
                                {
                                    _isCorrect = false;
                                    NVIA_NorManifiestoDesconOK = false;
                                    NVIA_NorManifiestoDesconMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Nro de Manifiesto Desconsolidado", "Nave Viaje");
                                    m_mensajeError += "Debe ingresar el Nro de Manifiesto Desconsolidado de la Nave Viaje" + Environment.NewLine;
                                }

                                ENTC_CodAgenPortVoBo_IMPOOK = true;
                                ENTC_CodAgenPortVoBo_IMPOMSGERROR = "";
                                if (ENTC_CodAgenPortVoBo_IMPO == null)
                                {
                                    _isCorrect = false;
                                    ENTC_CodAgenPortVoBo_IMPOOK = false;
                                    ENTC_CodAgenPortVoBo_IMPOMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "Agente Portuario", "Nave Viaje");
                                    m_mensajeError += "* Debe seleccionar el Agente Portuario de la Nave Viaje." + Environment.NewLine;
                                }

                            }

                            
                            //ENTC_CodAgenPortVoBo2_IMPOOK = true;
                            //ENTC_CodAgenPortVoBo2_IMPOMSGERROR = "";
                            //if (ENTC_CodAgenPortVoBo2_IMPO == null)
                            //{
                            //    _isCorrect = false;
                            //    ENTC_CodAgenPortVoBo2_IMPOOK = false;
                            //    ENTC_CodAgenPortVoBo2_IMPOMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "Agente Portuario", "Nave Viaje");
                            //    m_mensajeError += "* Debe seleccionar el Agente Portuario de la Nave Viaje." + Environment.NewLine;
                            //}


                        }

                    }
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
