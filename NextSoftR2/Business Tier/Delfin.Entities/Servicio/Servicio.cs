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
    [Serializable()]
    [KnownType(typeof(MasterBusinessEntity))]
    public partial class Servicio : MasterBusinessEntity, INotifyPropertyChanged
    {
        #region [ Variables ]
        private Int32 m_serv_codigo;
        private String m_serv_nombre_spa;
        private String m_serv_nombre_eng;
        private Nullable<Boolean> m_serv_afeigv;
        private Nullable<Boolean> m_serv_flete;
        private Nullable<Boolean> m_serv_excesoflete;
        private Nullable<Boolean> m_serv_afedet;
        private String m_cons_tabvia;
        private String m_cons_codvia;
        private String m_cons_tabrgm;
        private String m_cons_codrgm;
        private Nullable<Boolean> m_serv_activo;
        private String m_serv_cuevta;
        private String m_serv_cuegas;
        private String m_serv_agrup1;
        private String m_serv_agrup2;
        private Decimal m_serv_pordet;
        private String m_serv_tipo;
        private Decimal m_serv_valor;
        private Decimal m_serv_cobmin;
        private Nullable<Boolean> m_serv_autom;
        private String m_serv_frecfac;
        private String m_tipo_tabunt;
        private String m_tipo_codunt;
        private String m_serv_cueningreso;
        private String m_serv_cuencosto;
        private String m_serv_cuenpuente;
        private String m_tipo_tabdet;
        private String m_tipo_coddet;
        private String m_serv_nombrecorto;
        private String m_serv_glosa;
        private String m_serv_observaciones;
        private String m_serv_definidopor;
        private String m_serv_tipomov;
        private String m_cons_tabbas;
        private String m_cons_codbas;
        private String m_tipo_tabmnd;
        private String m_tipo_codmnd;
        private String m_cons_tablng;
        private String m_cons_codlng;

        private String m_cent_ano;
        private String m_cent_codigo;
        private String m_tipo_tabope;
        private String m_tipo_codope;
        private String m_tipo_tabope_Costo;
        private String m_tipo_codope_Costo;

        private String m_audi_usrcrea;
        private DateTime m_audi_feccrea;
        private String m_audi_usrmod;
        private Nullable<DateTime> m_audi_fecmod;

        //SAP
        private Nullable<Boolean> m_serv_agrupado;
        private Int32 m_serv_codunificador;
        private Int32 m_serv_codagrupador;
        private string m_serv_codsap;





        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Servicio.
        /// </summary>
        public Servicio()
        { }
        #endregion

        #region [ Propiedades ]
        /// <summary>
        /// Gets or sets el valor de: SERV_Codigo.
        /// </summary>
        [DataMember]
        public Int32 SERV_Codigo
        {
            get { return m_serv_codigo; }
            set
            {
                if (m_serv_codigo != value)
                {
                    m_serv_codigo = value;
                    OnPropertyChanged("SERV_Codigo");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_Nombre_SPA.
        /// </summary>
        [DataMember]
        public String SERV_Nombre_SPA
        {
            get { return m_serv_nombre_spa; }
            set
            {
                if (m_serv_nombre_spa != value)
                {
                    m_serv_nombre_spa = value;
                    OnPropertyChanged("SERV_Nombre_SPA");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_Nombre_ENG.
        /// </summary>
        [DataMember]
        public String SERV_Nombre_ENG
        {
            get { return m_serv_nombre_eng; }
            set
            {
                if (m_serv_nombre_eng != value)
                {
                    m_serv_nombre_eng = value;
                    OnPropertyChanged("SERV_Nombre_ENG");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_AfeIgv.
        /// </summary>
        [DataMember]
        public Nullable<Boolean> SERV_AfeIgv
        {
            get { return m_serv_afeigv; }
            set
            {
                if (m_serv_afeigv != value)
                {
                    m_serv_afeigv = value;
                    OnPropertyChanged("SERV_AfeIgv");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_Flete.
        /// </summary>
        [DataMember]
        public Nullable<Boolean> SERV_Flete
        {
            get { return m_serv_flete; }
            set
            {
                if (m_serv_flete != value)
                {
                    m_serv_flete = value;
                    OnPropertyChanged("SERV_Flete");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_ExcesoFlete.
        /// </summary>
        [DataMember]
        public Nullable<Boolean> SERV_ExcesoFlete
        {
            get { return m_serv_excesoflete; }
            set
            {
                if (m_serv_excesoflete != value)
                {
                    m_serv_excesoflete = value;
                    OnPropertyChanged("SERV_ExcesoFlete");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_AfeDet.
        /// </summary>
        /// <summary>
        /// Gets or sets el valor de: SERV_AfeDet.
        /// </summary>
        [DataMember]
        public Nullable<Boolean> SERV_AfeDet
        {
            get { return m_serv_afedet; }
            set
            {
                if (m_serv_afedet != value)
                {
                    m_serv_afedet = value;
                    OnPropertyChanged("SERV_AfeDet");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CONS_TabVia.
        /// </summary>
        [DataMember]
        public String CONS_TabVia
        {
            get { return m_cons_tabvia; }
            set
            {
                if (m_cons_tabvia != value)
                {
                    m_cons_tabvia = value;
                    OnPropertyChanged("CONS_TabVia");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CONS_CodVia.
        /// </summary>
        [DataMember]
        public String CONS_CodVia
        {
            get { return m_cons_codvia; }
            set
            {
                if (m_cons_codvia != value)
                {
                    m_cons_codvia = value;
                    OnPropertyChanged("CONS_CodVia");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CONS_TabRGM.
        /// </summary>
        [DataMember]
        public String CONS_TabRGM
        {
            get { return m_cons_tabrgm; }
            set
            {
                if (m_cons_tabrgm != value)
                {
                    m_cons_tabrgm = value;
                    OnPropertyChanged("CONS_TabRGM");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CONS_CodRGM.
        /// </summary>
        [DataMember]
        public String CONS_CodRGM
        {
            get { return m_cons_codrgm; }
            set
            {
                if (m_cons_codrgm != value)
                {
                    m_cons_codrgm = value;
                    OnPropertyChanged("CONS_CodRGM");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_Activo.
        /// </summary>
        [DataMember]
        public Nullable<Boolean> SERV_Activo
        {
            get { return m_serv_activo; }
            set
            {
                if (m_serv_activo != value)
                {
                    m_serv_activo = value;
                    OnPropertyChanged("SERV_Activo");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_CueVta.
        /// </summary>
        /*[DataMember]
        public String SERV_CueVta
        {
            get { return m_serv_cuevta; }
            set
            {
                if (m_serv_cuevta != value)
                {
                    m_serv_cuevta = value;
                    OnPropertyChanged("SERV_CueVta");
                }
            }
        }*/
        /// <summary>
        /// Gets or sets el valor de: SERV_CueGas.
        /// </summary>
        /*[DataMember]
        public String SERV_CueGas
        {
            get { return m_serv_cuegas; }
            set
            {
                if (m_serv_cuegas != value)
                {
                    m_serv_cuegas = value;
                    OnPropertyChanged("SERV_CueGas");
                }
            }
        }*/
        /// <summary>
        /// Gets or sets el valor de: SERV_Agrup1.
        /// </summary>
        [DataMember]
        public String SERV_Agrup1
        {
            get { return m_serv_agrup1; }
            set
            {
                if (m_serv_agrup1 != value)
                {
                    m_serv_agrup1 = value;
                    OnPropertyChanged("SERV_Agrup1");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_Agrup2.
        /// </summary>
        [DataMember]
        public String SERV_Agrup2
        {
            get { return m_serv_agrup2; }
            set
            {
                if (m_serv_agrup2 != value)
                {
                    m_serv_agrup2 = value;
                    OnPropertyChanged("SERV_Agrup2");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_PorDet.
        /// </summary>
        [DataMember]
        public Decimal SERV_PorDet
        {
            get { return m_serv_pordet; }
            set
            {
                if (m_serv_pordet != value)
                {
                    m_serv_pordet = value;
                    OnPropertyChanged("SERV_PorDet");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_Tipo.
        /// </summary>
        [DataMember]
        public String SERV_Tipo
        {
            get { return m_serv_tipo; }
            set
            {
                if (m_serv_tipo != value)
                {
                    m_serv_tipo = value;
                    OnPropertyChanged("SERV_Tipo");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_Valor.
        /// </summary>
        [DataMember]
        public Decimal SERV_Valor
        {
            get { return m_serv_valor; }
            set
            {
                if (m_serv_valor != value)
                {
                    m_serv_valor = value;
                    OnPropertyChanged("SERV_Valor");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_CobMin.
        /// </summary>
        [DataMember]
        public Decimal SERV_CobMin
        {
            get { return m_serv_cobmin; }
            set
            {
                if (m_serv_cobmin != value)
                {
                    m_serv_cobmin = value;
                    OnPropertyChanged("SERV_CobMin");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_Autom.
        /// </summary>
        [DataMember]
        public Nullable<Boolean> SERV_Autom
        {
            get { return m_serv_autom; }
            set
            {
                if (m_serv_autom != value)
                {
                    m_serv_autom = value;
                    OnPropertyChanged("SERV_Autom");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_FrecFac.
        /// </summary>
        [DataMember]
        public String SERV_FrecFac
        {
            get { return m_serv_frecfac; }
            set
            {
                if (m_serv_frecfac != value)
                {
                    m_serv_frecfac = value;
                    OnPropertyChanged("SERV_FrecFac");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: TIPO_TabUNT.
        /// </summary>
        [DataMember]
        public String TIPO_TabUNT
        {
            get { return m_tipo_tabunt; }
            set
            {
                if (m_tipo_tabunt != value)
                {
                    m_tipo_tabunt = value;
                    OnPropertyChanged("TIPO_TabUNT");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: TIPO_CodUNT.
        /// </summary>
        [DataMember]
        public String TIPO_CodUNT
        {
            get { return m_tipo_codunt; }
            set
            {
                if (m_tipo_codunt != value)
                {
                    m_tipo_codunt = value;
                    OnPropertyChanged("TIPO_CodUNT");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_CuenIngreso.
        /// </summary>
        [DataMember]
        public String SERV_CuenIngreso
        {
            get { return m_serv_cueningreso; }
            set
            {
                if (m_serv_cueningreso != value)
                {
                    m_serv_cueningreso = value;
                    OnPropertyChanged("SERV_CuenIngreso");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_CuenCosto.
        /// </summary>
        [DataMember]
        public String SERV_CuenCosto
        {
            get { return m_serv_cuencosto; }
            set
            {
                if (m_serv_cuencosto != value)
                {
                    m_serv_cuencosto = value;
                    OnPropertyChanged("SERV_CuenCosto");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_CuenPuente.
        /// </summary>
        [DataMember]
        public String SERV_CuenPuente
        {
            get { return m_serv_cuenpuente; }
            set
            {
                if (m_serv_cuenpuente != value)
                {
                    m_serv_cuenpuente = value;
                    OnPropertyChanged("SERV_CuenPuente");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: TIPO_TabDET.
        /// </summary>
        [DataMember]
        public String TIPO_TabDET
        {
            get { return m_tipo_tabdet; }
            set
            {
                if (m_tipo_tabdet != value)
                {
                    m_tipo_tabdet = value;
                    OnPropertyChanged("TIPO_TabDET");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: TIPO_CodDET.
        /// </summary>
        [DataMember]
        public String TIPO_CodDET
        {
            get { return m_tipo_coddet; }
            set
            {
                if (m_tipo_coddet != value)
                {
                    m_tipo_coddet = value;
                    OnPropertyChanged("TIPO_CodDET");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_NombreCorto.
        /// </summary>
        [DataMember]
        public String SERV_NombreCorto
        {
            get { return m_serv_nombrecorto; }
            set
            {
                if (m_serv_nombrecorto != value)
                {
                    m_serv_nombrecorto = value;
                    OnPropertyChanged("SERV_NombreCorto");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_Glosa.
        /// </summary>
        [DataMember]
        public String SERV_Glosa
        {
            get { return m_serv_glosa; }
            set
            {
                if (m_serv_glosa != value)
                {
                    m_serv_glosa = value;
                    OnPropertyChanged("SERV_Glosa");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_Observaciones.
        /// </summary>
        [DataMember]
        public String SERV_Observaciones
        {
            get { return m_serv_observaciones; }
            set
            {
                if (m_serv_observaciones != value)
                {
                    m_serv_observaciones = value;
                    OnPropertyChanged("SERV_Observaciones");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_DefinidoPor.
        /// </summary>
        [DataMember]
        public String SERV_DefinidoPor
        {
            get { return m_serv_definidopor; }
            set
            {
                if (m_serv_definidopor != value)
                {
                    m_serv_definidopor = value;
                    OnPropertyChanged("SERV_DefinidoPor");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: SERV_TipoMov.
        /// </summary>
        [DataMember]
        public String SERV_TipoMov
        {
            get { return m_serv_tipomov; }
            set
            {
                if (m_serv_tipomov != value)
                {
                    m_serv_tipomov = value;
                    OnPropertyChanged("SERV_TipoMov");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CONS_TabBAS.
        /// </summary>
        [DataMember]
        public String CONS_TabBAS
        {
            get { return m_cons_tabbas; }
            set
            {
                if (m_cons_tabbas != value)
                {
                    m_cons_tabbas = value;
                    OnPropertyChanged("CONS_TabBAS");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CONS_CodBAS.
        /// </summary>
        [DataMember]
        public String CONS_CodBAS
        {
            get { return m_cons_codbas; }
            set
            {
                if (m_cons_codbas != value)
                {
                    m_cons_codbas = value;
                    OnPropertyChanged("CONS_CodBAS");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: TIPO_TabMND.
        /// </summary>
        [DataMember]
        public String TIPO_TabMND
        {
            get { return m_tipo_tabmnd; }
            set
            {
                if (m_tipo_tabmnd != value)
                {
                    m_tipo_tabmnd = value;
                    OnPropertyChanged("TIPO_TabMND");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: TIPO_CodMND.
        /// </summary>
        [DataMember]
        public String TIPO_CodMND
        {
            get { return m_tipo_codmnd; }
            set
            {
                if (m_tipo_codmnd != value)
                {
                    m_tipo_codmnd = value;
                    OnPropertyChanged("TIPO_CodMND");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CONS_TabLNG.
        /// </summary>
        [DataMember]
        public String CONS_TabLNG
        {
            get { return m_cons_tablng; }
            set
            {
                if (m_cons_tablng != value)
                {
                    m_cons_tablng = value;
                    OnPropertyChanged("CONS_TabLNG");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CONS_CodLNG.
        /// </summary>
        [DataMember]
        public String CONS_CodLNG
        {
            get { return m_cons_codlng; }
            set
            {
                if (m_cons_codlng != value)
                {
                    m_cons_codlng = value;
                    OnPropertyChanged("CONS_CodLNG");
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: CENT_Ano.
        /// </summary>
        [DataMember]
        public String CENT_Ano
        {
           get { return m_cent_ano; }
           set
           {
              if (m_cent_ano != value)
              {
                 m_cent_ano = value;
                 OnPropertyChanged("CENT_Ano");
              }
           }
        }
        /// <summary>
        /// Gets or sets el valor de: CENT_Codigo.
        /// </summary>
        [DataMember]
        public String CENT_Codigo
        {
           get { return m_cent_codigo; }
           set
           {
              if (m_cent_codigo != value)
              {
                 m_cent_codigo = value;
                 OnPropertyChanged("CENT_Codigo");
              }
           }
        }
        /// <summary>
        /// Gets or sets el valor de: TIPO_TabOPE.
        /// </summary>
        [DataMember]
        public String TIPO_TabOPE
        {
           get { return m_tipo_tabope; }
           set
           {
              if (m_tipo_tabope != value)
              {
                 m_tipo_tabope = value;
                 OnPropertyChanged("TIPO_TabOPE");
              }
           }
        }
        /// <summary>
        /// Gets or sets el valor de: TIPO_CodOPE.
        /// </summary>
        [DataMember]
        public String TIPO_CodOPE
        {
           get { return m_tipo_codope; }
           set
           {
              if (m_tipo_codope != value)
              {
                 m_tipo_codope = value;
                 OnPropertyChanged("TIPO_CodOPE");
              }
           }
        }

        /// <summary>
        /// Gets or sets el valor de: TIPO_TabOPE_Costo.
        /// </summary>
        [DataMember]
        public String TIPO_TabOPE_Costo
        {
            get { return m_tipo_tabope_Costo; }
            set
            {
                if (m_tipo_tabope_Costo != value)
                {
                    m_tipo_tabope_Costo = value;
                    OnPropertyChanged("TIPO_TabOPE_Costo");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: TIPO_CodOPE.
        /// </summary>
        [DataMember]
        public String TIPO_CodOPE_Costo
        {
            get { return m_tipo_codope_Costo; }
            set
            {
                if (m_tipo_codope_Costo != value)
                {
                    m_tipo_codope_Costo = value;
                    OnPropertyChanged("TIPO_CodOPE_Costo");
                }
            }
        }


        /// <summary>
        /// Gets or sets el valor de: AUDI_UsrCrea.
        /// </summary>
        [DataMember]
        public String AUDI_UsrCrea
        {
            get { return m_audi_usrcrea; }
            set
            {
                if (m_audi_usrcrea != value)
                {
                    m_audi_usrcrea = value;
                    OnPropertyChanged("AUDI_UsrCrea");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: AUDI_FecCrea.
        /// </summary>
        [DataMember]
        public DateTime AUDI_FecCrea
        {
            get { return m_audi_feccrea; }
            set
            {
                if (m_audi_feccrea != value)
                {
                    m_audi_feccrea = value;
                    OnPropertyChanged("AUDI_FecCrea");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: AUDI_UsrMod.
        /// </summary>
        [DataMember]
        public String AUDI_UsrMod
        {
            get { return m_audi_usrmod; }
            set
            {
                if (m_audi_usrmod != value)
                {
                    m_audi_usrmod = value;
                    OnPropertyChanged("AUDI_UsrMod");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: AUDI_FecMod.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> AUDI_FecMod
        {
            get { return m_audi_fecmod; }
            set
            {
                if (m_audi_fecmod != value)
                {
                    m_audi_fecmod = value;
                    OnPropertyChanged("AUDI_FecMod");
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: SERV_Agrupado.
        /// </summary>
        [DataMember]
        public Nullable<Boolean> SERV_Agrupado
        {
            get { return m_serv_agrupado; }
            set
            {
                if (m_serv_agrupado != value)
                {
                    m_serv_agrupado = value;
                    OnPropertyChanged("SERV_Agrupado");
                }
            }
        }


        /// <summary>
        /// Gets or sets el valor de: SERV_CodUnificador.
        /// </summary>
        [DataMember]
        public Int32 SERV_CodUnificador
        {
            get { return m_serv_codunificador; }
            set
            {
                if (m_serv_codunificador != value)
                {
                    m_serv_codunificador = value;
                    OnPropertyChanged("SERV_CodUnificador");
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: SERV_CodSAP.
        /// </summary>
        [DataMember]
        public string SERV_CodSAP
        {
            get { return m_serv_codsap; }
            set
            {
                if (m_serv_codsap != value)
                {
                    m_serv_codsap = value;
                    OnPropertyChanged("SERV_CodSAP");
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: SERV_CodAgrupador.
        /// </summary>
        [DataMember]
        public Int32 SERV_CodAgrupador
        {
            get { return m_serv_codagrupador; }
            set
            {
                if (m_serv_codagrupador != value)
                {
                    m_serv_codagrupador = value;
                    OnPropertyChanged("SERV_CodAgrupador");
                }
            }
        }



        #endregion

        #region [ CopyTo ]
        public void CopyTo(ref Servicio Item)
        {
            try
            {
                if (Item == null) { Item = new Servicio(); }
                Item.SERV_Codigo = this.SERV_Codigo;
                Item.SERV_Nombre_SPA = this.SERV_Nombre_SPA;
                Item.SERV_Nombre_ENG = this.SERV_Nombre_ENG;
                Item.SERV_AfeIgv = this.SERV_AfeIgv;
                Item.SERV_Flete = this.SERV_Flete;
                Item.SERV_ExcesoFlete = this.SERV_ExcesoFlete;
                Item.SERV_AfeDet = this.SERV_AfeDet;
                Item.CONS_TabVia = this.CONS_TabVia;
                Item.CONS_CodVia = this.CONS_CodVia;
                Item.CONS_TabRGM = this.CONS_TabRGM;
                Item.CONS_CodRGM = this.CONS_CodRGM;
                Item.SERV_Activo = this.SERV_Activo;
                //Item.SERV_CueVta = this.SERV_CueVta;
                //Item.SERV_CueGas = this.SERV_CueGas;
                Item.SERV_Agrup1 = this.SERV_Agrup1;
                Item.SERV_Agrup2 = this.SERV_Agrup2;
                Item.SERV_PorDet = this.SERV_PorDet;
                Item.SERV_Tipo = this.SERV_Tipo;
                Item.SERV_Valor = this.SERV_Valor;
                Item.SERV_CobMin = this.SERV_CobMin;
                Item.SERV_Autom = this.SERV_Autom;
                Item.SERV_FrecFac = this.SERV_FrecFac;
                Item.TIPO_TabUNT = this.TIPO_TabUNT;
                Item.TIPO_CodUNT = this.TIPO_CodUNT;

                /// <summary>
                /// Cristhian Jose Apaza
                /// </summary>

                Item.SERV_CuenIngreso = this.SERV_CuenIngreso;
                Item.SERV_CuenCosto = this.SERV_CuenCosto;
                Item.SERV_CuenPuente = this.SERV_CuenPuente;
                Item.TIPO_TabDET = this.TIPO_TabDET;
                Item.TIPO_CodDET = this.TIPO_CodDET;
                Item.SERV_NombreCorto = this.SERV_NombreCorto;
                Item.SERV_Glosa = this.SERV_Glosa;
                Item.SERV_Observaciones = this.SERV_Observaciones;
                Item.SERV_DefinidoPor = this.SERV_DefinidoPor;
                Item.SERV_TipoMov = this.SERV_TipoMov;
                Item.CONS_TabBAS = this.CONS_TabBAS;
                Item.CONS_CodBAS = this.CONS_CodBAS;
                Item.TIPO_TabMND = this.TIPO_TabMND;
                Item.TIPO_CodMND = this.TIPO_CodMND;
                Item.CONS_TabLNG = this.CONS_TabLNG;
                Item.CONS_CodLNG = this.CONS_CodLNG;

                Item.ViaRegimenServicio = this.ViaRegimenServicio;

                Item.CENT_Ano = this.CENT_Ano;
                Item.CENT_Codigo = this.CENT_Codigo;

                //SAP mcomun

                Item.SERV_Agrupado = this.SERV_Agrupado;
                Item.SERV_CodUnificador = this.SERV_CodUnificador;
                Item.SERV_CodAgrupador = this.SERV_CodAgrupador;
                Item.SERV_CodSAP = this.SERV_CodSAP;





            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
