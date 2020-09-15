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
	public partial class Entidad : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_entc_codigo;
		private String m_tipo_tabtdi;
		private String m_tipo_codtdi;
		private String m_entc_tipent;
		private String m_entc_dociden;
		private Boolean m_entc_domiciliado;
		private String m_entc_nombres;
		private String m_entc_apepat;
		private String m_entc_apemat;
		private String m_entc_nomcompleto;
		private String m_entc_nomcomercial;
		private String m_entc_razonsocial;
		private Nullable<Boolean> m_entc_activo;
		private Nullable<DateTime> m_entc_fecnac;
		private Nullable<DateTime> m_entc_fecing;
		private Boolean m_entc_vip;
		private String m_entc_notas;
		private String m_entc_sexo;
		private String m_entc_email;
		private String m_entc_web;
		private Nullable<Boolean> m_entc_propio;
		private String m_entc_telef1;
		private String m_entc_telef2;
		private String m_entc_telef3;
		private String m_entc_telef4;
		private String m_entc_beneficiario;
		private String m_entc_area;
		private String m_entc_cargo;
		private String m_user_codusr;
		private String m_tipo_tabpai;
		private String m_tipo_codpai;
		private String m_tipo_tabhol;
		private String m_tipo_codhol;
		private String m_cons_codtft;
		private String m_cons_tabtft;
		private String m_tipo_tabciu;
		private String m_tipo_codciu;
		private Nullable<Boolean> m_entc_prospecto;
		private String m_tipo_tabdtm;
		private String m_tipo_coddtm;
		private Nullable<Decimal> m_entc_valrebate;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private Nullable<Decimal> m_entc_valtarja;
		private Nullable<Int16> m_entc_diascredito;
		private Nullable<DateTime> m_entc_fechacredito;
		private Nullable<Boolean> m_entc_tarja;
		private String m_entc_codaduana;
		private String m_cons_codcre;
		private String m_cons_tabcre;
		private String m_entc_email2;
        private String m_entc_emailFE;
		private String m_entc_obser;
		private String m_entc_interbancariosol;
		private String m_entc_interbancariodol;
		private String m_entc_cuentadetraccion;
		private Boolean m_entc_serviciologistico;
		private Boolean m_entc_ocultarshipper;
		private String m_entc_obsfinanzascliente;
		private Nullable<Boolean> m_entc_bloqueofinanzascliente;
		private String m_entc_usrbloqueocliente;
		private Nullable<DateTime> m_entc_fecbloqueocliente;
		private String m_entc_emailfinanzas;
		private String m_entc_obsbloqueocliente;
		private Nullable<Boolean> m_entc_otrostraficos;
		private Nullable<Boolean> m_entc_mandato;
		private Nullable<Boolean> m_entc_sli;
		private Nullable<Boolean> m_entc_exportacion;
		private String m_entc_usrbloqueoproveedor;
		private Nullable<DateTime> m_entc_fecbloqueoproveedor;
		private Nullable<Boolean> m_entc_bloqueofinanzasproveedor;
		private String m_entc_obsfinanzasproveedor;
		private String m_entc_obsbloqueoproveedor;
		private Boolean m_entc_provasumedetraccion;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
        private string m_entc_origen;
        private String m_tipo_codseg;
        private String m_entc_codsap_c;
        private String m_entc_codsap_p;
        private Nullable<DateTime> m_entc_fecactsap;
        private Boolean m_entc_estactsap;

        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Entidad.
        /// </summary>
        public Entidad()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Int32 ENTC_Codigo
		{
			get { return m_entc_codigo; }
			set
			{
				if (m_entc_codigo != value)
				{
					m_entc_codigo = value;
					OnPropertyChanged("ENTC_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabTDI.
		/// </summary>
		[DataMember]
		public String TIPO_TabTDI
		{
			get { return m_tipo_tabtdi; }
			set
			{
				if (m_tipo_tabtdi != value)
				{
					m_tipo_tabtdi = value;
					OnPropertyChanged("TIPO_TabTDI");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodTDI.
		/// </summary>
		[DataMember]
		public String TIPO_CodTDI
		{
			get { return m_tipo_codtdi; }
			set
			{
				if (m_tipo_codtdi != value)
				{
					m_tipo_codtdi = value;
					OnPropertyChanged("TIPO_CodTDI");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_TipEnt.
		/// </summary>
		[DataMember]
		public String ENTC_TipEnt
		{
			get { return m_entc_tipent; }
			set
			{
				if (m_entc_tipent != value)
				{
					m_entc_tipent = value;
					OnPropertyChanged("ENTC_TipEnt");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_DocIden.
		/// </summary>
		[DataMember]
		public String ENTC_DocIden
		{
			get { return m_entc_dociden; }
			set
			{
				if (m_entc_dociden != value)
				{
					m_entc_dociden = value;
					OnPropertyChanged("ENTC_DocIden");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Domiciliado.
		/// </summary>
		[DataMember]
		public Boolean ENTC_Domiciliado
		{
			get { return m_entc_domiciliado; }
			set
			{
				if (m_entc_domiciliado != value)
				{
					m_entc_domiciliado = value;
					OnPropertyChanged("ENTC_Domiciliado");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Nombres.
		/// </summary>
		[DataMember]
		public String ENTC_Nombres
		{
			get { return m_entc_nombres; }
			set
			{
				if (m_entc_nombres != value)
				{
					m_entc_nombres = value;
					OnPropertyChanged("ENTC_Nombres");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_ApePat.
		/// </summary>
		[DataMember]
		public String ENTC_ApePat
		{
			get { return m_entc_apepat; }
			set
			{
				if (m_entc_apepat != value)
				{
					m_entc_apepat = value;
					OnPropertyChanged("ENTC_ApePat");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_ApeMat.
		/// </summary>
		[DataMember]
		public String ENTC_ApeMat
		{
			get { return m_entc_apemat; }
			set
			{
				if (m_entc_apemat != value)
				{
					m_entc_apemat = value;
					OnPropertyChanged("ENTC_ApeMat");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_NomCompleto.
		/// </summary>
		[DataMember]
		public String ENTC_NomCompleto
		{
			get { return m_entc_nomcompleto; }
			set
			{
				if (m_entc_nomcompleto != value)
				{
					m_entc_nomcompleto = value;
					OnPropertyChanged("ENTC_NomCompleto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_NomComercial.
		/// </summary>
		[DataMember]
		public String ENTC_NomComercial
		{
			get { return m_entc_nomcomercial; }
			set
			{
				if (m_entc_nomcomercial != value)
				{
					m_entc_nomcomercial = value;
					OnPropertyChanged("ENTC_NomComercial");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_RazonSocial.
		/// </summary>
		[DataMember]
		public String ENTC_RazonSocial
		{
			get { return m_entc_razonsocial; }
			set
			{
				if (m_entc_razonsocial != value)
				{
					m_entc_razonsocial = value;
					OnPropertyChanged("ENTC_RazonSocial");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Activo.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> ENTC_Activo
		{
			get { return m_entc_activo; }
			set
			{
				if (m_entc_activo != value)
				{
					m_entc_activo = value;
					OnPropertyChanged("ENTC_Activo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_FecNac.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> ENTC_FecNac
		{
			get { return m_entc_fecnac; }
			set
			{
				if (m_entc_fecnac != value)
				{
					m_entc_fecnac = value;
					OnPropertyChanged("ENTC_FecNac");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_FecIng.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> ENTC_FecIng
		{
			get { return m_entc_fecing; }
			set
			{
				if (m_entc_fecing != value)
				{
					m_entc_fecing = value;
					OnPropertyChanged("ENTC_FecIng");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_VIP.
		/// </summary>
		[DataMember]
		public Boolean ENTC_VIP
		{
			get { return m_entc_vip; }
			set
			{
				if (m_entc_vip != value)
				{
					m_entc_vip = value;
					OnPropertyChanged("ENTC_VIP");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Notas.
		/// </summary>
		[DataMember]
		public String ENTC_Notas
		{
			get { return m_entc_notas; }
			set
			{
				if (m_entc_notas != value)
				{
					m_entc_notas = value;
					OnPropertyChanged("ENTC_Notas");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Sexo.
		/// </summary>
		[DataMember]
		public String ENTC_Sexo
		{
			get { return m_entc_sexo; }
			set
			{
				if (m_entc_sexo != value)
				{
					m_entc_sexo = value;
					OnPropertyChanged("ENTC_Sexo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_EMail.
		/// </summary>
		[DataMember]
		public String ENTC_EMail
		{
			get { return m_entc_email; }
			set
			{
				if (m_entc_email != value)
				{
					m_entc_email = value;
					OnPropertyChanged("ENTC_EMail");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Web.
		/// </summary>
		[DataMember]
		public String ENTC_Web
		{
			get { return m_entc_web; }
			set
			{
				if (m_entc_web != value)
				{
					m_entc_web = value;
					OnPropertyChanged("ENTC_Web");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Propio.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> ENTC_Propio
		{
			get { return m_entc_propio; }
			set
			{
				if (m_entc_propio != value)
				{
					m_entc_propio = value;
					OnPropertyChanged("ENTC_Propio");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Telef1.
		/// </summary>
		[DataMember]
		public String ENTC_Telef1
		{
			get { return m_entc_telef1; }
			set
			{
				if (m_entc_telef1 != value)
				{
					m_entc_telef1 = value;
					OnPropertyChanged("ENTC_Telef1");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Telef2.
		/// </summary>
		[DataMember]
		public String ENTC_Telef2
		{
			get { return m_entc_telef2; }
			set
			{
				if (m_entc_telef2 != value)
				{
					m_entc_telef2 = value;
					OnPropertyChanged("ENTC_Telef2");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Telef3.
		/// </summary>
		[DataMember]
		public String ENTC_Telef3
		{
			get { return m_entc_telef3; }
			set
			{
				if (m_entc_telef3 != value)
				{
					m_entc_telef3 = value;
					OnPropertyChanged("ENTC_Telef3");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Telef4.
		/// </summary>
		[DataMember]
		public String ENTC_Telef4
		{
			get { return m_entc_telef4; }
			set
			{
				if (m_entc_telef4 != value)
				{
					m_entc_telef4 = value;
					OnPropertyChanged("ENTC_Telef4");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Beneficiario.
		/// </summary>
		[DataMember]
		public String ENTC_Beneficiario
		{
			get { return m_entc_beneficiario; }
			set
			{
				if (m_entc_beneficiario != value)
				{
					m_entc_beneficiario = value;
					OnPropertyChanged("ENTC_Beneficiario");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Area.
		/// </summary>
		[DataMember]
		public String ENTC_Area
		{
			get { return m_entc_area; }
			set
			{
				if (m_entc_area != value)
				{
					m_entc_area = value;
					OnPropertyChanged("ENTC_Area");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Cargo.
		/// </summary>
		[DataMember]
		public String ENTC_Cargo
		{
			get { return m_entc_cargo; }
			set
			{
				if (m_entc_cargo != value)
				{
					m_entc_cargo = value;
					OnPropertyChanged("ENTC_Cargo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: USER_CodUsr.
		/// </summary>
		[DataMember]
		public String USER_CodUsr
		{
			get { return m_user_codusr; }
			set
			{
				if (m_user_codusr != value)
				{
					m_user_codusr = value;
					OnPropertyChanged("USER_CodUsr");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabPai.
		/// </summary>
		[DataMember]
		public String TIPO_TabPai
		{
			get { return m_tipo_tabpai; }
			set
			{
				if (m_tipo_tabpai != value)
				{
					m_tipo_tabpai = value;
					OnPropertyChanged("TIPO_TabPai");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodPai.
		/// </summary>
		[DataMember]
		public String TIPO_CodPai
		{
			get { return m_tipo_codpai; }
			set
			{
				if (m_tipo_codpai != value)
				{
					m_tipo_codpai = value;
					OnPropertyChanged("TIPO_CodPai");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabHol.
		/// </summary>
		[DataMember]
		public String TIPO_TabHol
		{
			get { return m_tipo_tabhol; }
			set
			{
				if (m_tipo_tabhol != value)
				{
					m_tipo_tabhol = value;
					OnPropertyChanged("TIPO_TabHol");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodHol.
		/// </summary>
		[DataMember]
		public String TIPO_CodHol
		{
			get { return m_tipo_codhol; }
			set
			{
				if (m_tipo_codhol != value)
				{
					m_tipo_codhol = value;
					OnPropertyChanged("TIPO_CodHol");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodTFT.
		/// </summary>
		[DataMember]
		public String CONS_CodTFT
		{
			get { return m_cons_codtft; }
			set
			{
				if (m_cons_codtft != value)
				{
					m_cons_codtft = value;
					OnPropertyChanged("CONS_CodTFT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabTFT.
		/// </summary>
		[DataMember]
		public String CONS_TabTFT
		{
			get { return m_cons_tabtft; }
			set
			{
				if (m_cons_tabtft != value)
				{
					m_cons_tabtft = value;
					OnPropertyChanged("CONS_TabTFT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabCiu.
		/// </summary>
		[DataMember]
		public String TIPO_TabCiu
		{
			get { return m_tipo_tabciu; }
			set
			{
				if (m_tipo_tabciu != value)
				{
					m_tipo_tabciu = value;
					OnPropertyChanged("TIPO_TabCiu");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodCiu.
		/// </summary>
		[DataMember]
		public String TIPO_CodCiu
		{
			get { return m_tipo_codciu; }
			set
			{
				if (m_tipo_codciu != value)
				{
					m_tipo_codciu = value;
					OnPropertyChanged("TIPO_CodCiu");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Prospecto.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> ENTC_Prospecto
		{
			get { return m_entc_prospecto; }
			set
			{
				if (m_entc_prospecto != value)
				{
					m_entc_prospecto = value;
					OnPropertyChanged("ENTC_Prospecto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabDTM.
		/// </summary>
		[DataMember]
		public String TIPO_TabDTM
		{
			get { return m_tipo_tabdtm; }
			set
			{
				if (m_tipo_tabdtm != value)
				{
					m_tipo_tabdtm = value;
					OnPropertyChanged("TIPO_TabDTM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodDTM.
		/// </summary>
		[DataMember]
		public String TIPO_CodDTM
		{
			get { return m_tipo_coddtm; }
			set
			{
				if (m_tipo_coddtm != value)
				{
					m_tipo_coddtm = value;
					OnPropertyChanged("TIPO_CodDTM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_ValRebate.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> ENTC_ValRebate
		{
			get { return m_entc_valrebate; }
			set
			{
				if (m_entc_valrebate != value)
				{
					m_entc_valrebate = value;
					OnPropertyChanged("ENTC_ValRebate");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabMnd.
		/// </summary>
		[DataMember]
		public String TIPO_TabMnd
		{
			get { return m_tipo_tabmnd; }
			set
			{
				if (m_tipo_tabmnd != value)
				{
					m_tipo_tabmnd = value;
					OnPropertyChanged("TIPO_TabMnd");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodMnd.
		/// </summary>
		[DataMember]
		public String TIPO_CodMnd
		{
			get { return m_tipo_codmnd; }
			set
			{
				if (m_tipo_codmnd != value)
				{
					m_tipo_codmnd = value;
					OnPropertyChanged("TIPO_CodMnd");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_ValTarja.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> ENTC_ValTarja
		{
			get { return m_entc_valtarja; }
			set
			{
				if (m_entc_valtarja != value)
				{
					m_entc_valtarja = value;
					OnPropertyChanged("ENTC_ValTarja");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_DiasCredito.
		/// </summary>
		[DataMember]
		public Nullable<Int16> ENTC_DiasCredito
		{
			get { return m_entc_diascredito; }
			set
			{
				if (m_entc_diascredito != value)
				{
					m_entc_diascredito = value;
					OnPropertyChanged("ENTC_DiasCredito");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_FechaCredito.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> ENTC_FechaCredito
		{
			get { return m_entc_fechacredito; }
			set
			{
				if (m_entc_fechacredito != value)
				{
					m_entc_fechacredito = value;
					OnPropertyChanged("ENTC_FechaCredito");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Tarja.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> ENTC_Tarja
		{
			get { return m_entc_tarja; }
			set
			{
				if (m_entc_tarja != value)
				{
					m_entc_tarja = value;
					OnPropertyChanged("ENTC_Tarja");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodAduana.
		/// </summary>
		[DataMember]
		public String ENTC_CodAduana
		{
			get { return m_entc_codaduana; }
			set
			{
				if (m_entc_codaduana != value)
				{
					m_entc_codaduana = value;
					OnPropertyChanged("ENTC_CodAduana");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodCre.
		/// </summary>
		[DataMember]
		public String CONS_CodCre
		{
			get { return m_cons_codcre; }
			set
			{
				if (m_cons_codcre != value)
				{
					m_cons_codcre = value;
					OnPropertyChanged("CONS_CodCre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabCre.
		/// </summary>
		[DataMember]
		public String CONS_TabCre
		{
			get { return m_cons_tabcre; }
			set
			{
				if (m_cons_tabcre != value)
				{
					m_cons_tabcre = value;
					OnPropertyChanged("CONS_TabCre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_EMail2.
		/// </summary>
		[DataMember]
		public String ENTC_EMail2
		{
			get { return m_entc_email2; }
			set
			{
				if (m_entc_email2 != value)
				{
					m_entc_email2 = value;
					OnPropertyChanged("ENTC_EMail2");
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: ENTC_EMailFE.
        /// </summary>
        [DataMember]
        public String ENTC_EmailReceptorFE
        {
            get { return m_entc_emailFE; }
            set
            {
                if (m_entc_emailFE != value)
                {
                    m_entc_emailFE = value;
                    OnPropertyChanged("ENTC_EmailReceptorFE");
                }
            }
        }
		/// <summary>
		/// Gets or sets el valor de: ENTC_Obser.
		/// </summary>
		[DataMember]
		public String ENTC_Obser
		{
			get { return m_entc_obser; }
			set
			{
				if (m_entc_obser != value)
				{
					m_entc_obser = value;
					OnPropertyChanged("ENTC_Obser");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_InterbancarioSol.
		/// </summary>
		[DataMember]
		public String ENTC_InterbancarioSol
		{
			get { return m_entc_interbancariosol; }
			set
			{
				if (m_entc_interbancariosol != value)
				{
					m_entc_interbancariosol = value;
					OnPropertyChanged("ENTC_InterbancarioSol");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_InterbancarioDol.
		/// </summary>
		[DataMember]
		public String ENTC_InterbancarioDol
		{
			get { return m_entc_interbancariodol; }
			set
			{
				if (m_entc_interbancariodol != value)
				{
					m_entc_interbancariodol = value;
					OnPropertyChanged("ENTC_InterbancarioDol");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CuentaDetraccion.
		/// </summary>
		[DataMember]
		public String ENTC_CuentaDetraccion
		{
			get { return m_entc_cuentadetraccion; }
			set
			{
				if (m_entc_cuentadetraccion != value)
				{
					m_entc_cuentadetraccion = value;
					OnPropertyChanged("ENTC_CuentaDetraccion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_ServicioLogistico.
		/// </summary>
		[DataMember]
		public Boolean ENTC_ServicioLogistico
		{
			get { return m_entc_serviciologistico; }
			set
			{
				if (m_entc_serviciologistico != value)
				{
					m_entc_serviciologistico = value;
					OnPropertyChanged("ENTC_ServicioLogistico");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_OcultarShipper.
		/// </summary>
		[DataMember]
		public Boolean ENTC_OcultarShipper
		{
			get { return m_entc_ocultarshipper; }
			set
			{
				if (m_entc_ocultarshipper != value)
				{
					m_entc_ocultarshipper = value;
					OnPropertyChanged("ENTC_OcultarShipper");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_ObsFinanzasCliente.
		/// </summary>
		[DataMember]
		public String ENTC_ObsFinanzasCliente
		{
			get { return m_entc_obsfinanzascliente; }
			set
			{
				if (m_entc_obsfinanzascliente != value)
				{
					m_entc_obsfinanzascliente = value;
					OnPropertyChanged("ENTC_ObsFinanzasCliente");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_BloqueoFinanzasCliente.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> ENTC_BloqueoFinanzasCliente
		{
			get { return m_entc_bloqueofinanzascliente; }
			set
			{
				if (m_entc_bloqueofinanzascliente != value)
				{
					m_entc_bloqueofinanzascliente = value;
					OnPropertyChanged("ENTC_BloqueoFinanzasCliente");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_UsrBloqueoCliente.
		/// </summary>
		[DataMember]
		public String ENTC_UsrBloqueoCliente
		{
			get { return m_entc_usrbloqueocliente; }
			set
			{
				if (m_entc_usrbloqueocliente != value)
				{
					m_entc_usrbloqueocliente = value;
					OnPropertyChanged("ENTC_UsrBloqueoCliente");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_FecBloqueoCliente.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> ENTC_FecBloqueoCliente
		{
			get { return m_entc_fecbloqueocliente; }
			set
			{
				if (m_entc_fecbloqueocliente != value)
				{
					m_entc_fecbloqueocliente = value;
					OnPropertyChanged("ENTC_FecBloqueoCliente");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_EmailFinanzas.
		/// </summary>
		[DataMember]
		public String ENTC_EmailFinanzas
		{
			get { return m_entc_emailfinanzas; }
			set
			{
				if (m_entc_emailfinanzas != value)
				{
					m_entc_emailfinanzas = value;
					OnPropertyChanged("ENTC_EmailFinanzas");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_ObsBloqueoCliente.
		/// </summary>
		[DataMember]
		public String ENTC_ObsBloqueoCliente
		{
			get { return m_entc_obsbloqueocliente; }
			set
			{
				if (m_entc_obsbloqueocliente != value)
				{
					m_entc_obsbloqueocliente = value;
					OnPropertyChanged("ENTC_ObsBloqueoCliente");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_OtrosTraficos.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> ENTC_OtrosTraficos
		{
			get { return m_entc_otrostraficos; }
			set
			{
				if (m_entc_otrostraficos != value)
				{
					m_entc_otrostraficos = value;
					OnPropertyChanged("ENTC_OtrosTraficos");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Mandato.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> ENTC_Mandato
		{
			get { return m_entc_mandato; }
			set
			{
				if (m_entc_mandato != value)
				{
					m_entc_mandato = value;
					OnPropertyChanged("ENTC_Mandato");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_SLI.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> ENTC_SLI
		{
			get { return m_entc_sli; }
			set
			{
				if (m_entc_sli != value)
				{
					m_entc_sli = value;
					OnPropertyChanged("ENTC_SLI");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Exportacion.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> ENTC_Exportacion
		{
			get { return m_entc_exportacion; }
			set
			{
				if (m_entc_exportacion != value)
				{
					m_entc_exportacion = value;
					OnPropertyChanged("ENTC_Exportacion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_UsrBloqueoProveedor.
		/// </summary>
		[DataMember]
		public String ENTC_UsrBloqueoProveedor
		{
			get { return m_entc_usrbloqueoproveedor; }
			set
			{
				if (m_entc_usrbloqueoproveedor != value)
				{
					m_entc_usrbloqueoproveedor = value;
					OnPropertyChanged("ENTC_UsrBloqueoProveedor");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_FecBloqueoProveedor.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> ENTC_FecBloqueoProveedor
		{
			get { return m_entc_fecbloqueoproveedor; }
			set
			{
				if (m_entc_fecbloqueoproveedor != value)
				{
					m_entc_fecbloqueoproveedor = value;
					OnPropertyChanged("ENTC_FecBloqueoProveedor");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_BloqueoFinanzasProveedor.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> ENTC_BloqueoFinanzasProveedor
		{
			get { return m_entc_bloqueofinanzasproveedor; }
			set
			{
				if (m_entc_bloqueofinanzasproveedor != value)
				{
					m_entc_bloqueofinanzasproveedor = value;
					OnPropertyChanged("ENTC_BloqueoFinanzasProveedor");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_ObsFinanzasProveedor.
		/// </summary>
		[DataMember]
		public String ENTC_ObsFinanzasProveedor
		{
			get { return m_entc_obsfinanzasproveedor; }
			set
			{
				if (m_entc_obsfinanzasproveedor != value)
				{
					m_entc_obsfinanzasproveedor = value;
					OnPropertyChanged("ENTC_ObsFinanzasProveedor");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_ObsBloqueoProveedor.
		/// </summary>
		[DataMember]
		public String ENTC_ObsBloqueoProveedor
		{
			get { return m_entc_obsbloqueoproveedor; }
			set
			{
				if (m_entc_obsbloqueoproveedor != value)
				{
					m_entc_obsbloqueoproveedor = value;
					OnPropertyChanged("ENTC_ObsBloqueoProveedor");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_ProvAsumeDetraccion.
		/// </summary>
		[DataMember]
		public Boolean ENTC_ProvAsumeDetraccion
		{
			get { return m_entc_provasumedetraccion; }
			set
			{
				if (m_entc_provasumedetraccion != value)
				{
					m_entc_provasumedetraccion = value;
					OnPropertyChanged("ENTC_ProvAsumeDetraccion");
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
		/// Gets or sets el valor de: ENTC_Origen.
		/// </summary>
		[DataMember]
        public String ENTC_Origen
        {
            get { return m_entc_origen; }
            set
            {
                if (m_entc_origen != value)
                {
                    m_entc_origen = value;
                    OnPropertyChanged("ENTC_Origen");
                }
            }
        }


        /// <summary>
		/// Gets or sets el valor de: ENTC_Origen.
		/// </summary>
		[DataMember]
        public String TIPO_CodSEG
        {
            get { return m_tipo_codseg; }
            set
            {
                if (m_tipo_codseg != value)
                {
                    m_tipo_codseg = value;
                    OnPropertyChanged("TIPO_CodSEG");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ENTC_CodSAP_C.
        /// </summary>
        [DataMember]
        public String ENTC_CodSAP_C
        {
            get { return m_entc_codsap_c; }
            set
            {
                if (m_entc_codsap_c != value)
                {
                    m_entc_codsap_c = value;
                    OnPropertyChanged("ENTC_CodSAP_C");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ENTC_CodSAP_P.
        /// </summary>
        [DataMember]
        public String ENTC_CodSAP_P
        {
            get { return m_entc_codsap_p; }
            set
            {
                if (m_entc_codsap_p != value)
                {
                    m_entc_codsap_p = value;
                    OnPropertyChanged("ENTC_CodSAP_P");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: AUDI_FecMod.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> ENTC_FecActSAP
        {
            get { return m_entc_fecactsap; }
            set
            {
                if (m_entc_fecactsap != value)
                {
                    m_entc_fecactsap = value;
                    OnPropertyChanged("ENTC_FecActSAP");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ENTC_EstActSAP.
        /// </summary>
        [DataMember]
        public Boolean ENTC_EstActSAP
        {
            get { return m_entc_estactsap; }
            set
            {
                if (m_entc_estactsap != value)
                {
                    m_entc_estactsap = value;
                    OnPropertyChanged("ENTC_EstActSAP");
                }
            }
        }


        #endregion

        #region [ CopyTo ]
        public void CopyTo(ref Entidad Item)
		{
			try
			{
				if (Item == null) { Item = new Entidad(); }
				Item.ENTC_Codigo = this.ENTC_Codigo;
				Item.TIPO_TabTDI = this.TIPO_TabTDI;
				Item.TIPO_CodTDI = this.TIPO_CodTDI;
				Item.ENTC_TipEnt = this.ENTC_TipEnt;
				Item.ENTC_DocIden = this.ENTC_DocIden;
				Item.ENTC_Domiciliado = this.ENTC_Domiciliado;
				Item.ENTC_Nombres = this.ENTC_Nombres;
				Item.ENTC_ApePat = this.ENTC_ApePat;
				Item.ENTC_ApeMat = this.ENTC_ApeMat;
				Item.ENTC_NomCompleto = this.ENTC_NomCompleto;
				Item.ENTC_NomComercial = this.ENTC_NomComercial;
				Item.ENTC_RazonSocial = this.ENTC_RazonSocial;
				Item.ENTC_Activo = this.ENTC_Activo;
				Item.ENTC_FecNac = this.ENTC_FecNac;
				Item.ENTC_FecIng = this.ENTC_FecIng;
				Item.ENTC_VIP = this.ENTC_VIP;
				Item.ENTC_Notas = this.ENTC_Notas;
				Item.ENTC_Sexo = this.ENTC_Sexo;
				Item.ENTC_EMail = this.ENTC_EMail;
				Item.ENTC_Web = this.ENTC_Web;
				Item.ENTC_Propio = this.ENTC_Propio;
				Item.ENTC_Telef1 = this.ENTC_Telef1;
				Item.ENTC_Telef2 = this.ENTC_Telef2;
				Item.ENTC_Telef3 = this.ENTC_Telef3;
				Item.ENTC_Telef4 = this.ENTC_Telef4;
				Item.ENTC_Beneficiario = this.ENTC_Beneficiario;
				Item.ENTC_Area = this.ENTC_Area;
				Item.ENTC_Cargo = this.ENTC_Cargo;
				Item.USER_CodUsr = this.USER_CodUsr;
				Item.TIPO_TabPai = this.TIPO_TabPai;
				Item.TIPO_CodPai = this.TIPO_CodPai;
				Item.TIPO_TabHol = this.TIPO_TabHol;
				Item.TIPO_CodHol = this.TIPO_CodHol;
				Item.CONS_CodTFT = this.CONS_CodTFT;
				Item.CONS_TabTFT = this.CONS_TabTFT;
				Item.TIPO_TabCiu = this.TIPO_TabCiu;
				Item.TIPO_CodCiu = this.TIPO_CodCiu;
				Item.ENTC_Prospecto = this.ENTC_Prospecto;
				Item.TIPO_TabDTM = this.TIPO_TabDTM;
				Item.TIPO_CodDTM = this.TIPO_CodDTM;
				Item.ENTC_ValRebate = this.ENTC_ValRebate;
				Item.TIPO_TabMnd = this.TIPO_TabMnd;
				Item.TIPO_CodMnd = this.TIPO_CodMnd;
				Item.ENTC_ValTarja = this.ENTC_ValTarja;
				Item.ENTC_DiasCredito = this.ENTC_DiasCredito;
				Item.ENTC_FechaCredito = this.ENTC_FechaCredito;
				Item.ENTC_Tarja = this.ENTC_Tarja;
				Item.ENTC_CodAduana = this.ENTC_CodAduana;
				Item.CONS_CodCre = this.CONS_CodCre;
				Item.CONS_TabCre = this.CONS_TabCre;
				Item.ENTC_EMail2 = this.ENTC_EMail2;
				Item.ENTC_Obser = this.ENTC_Obser;
				Item.ENTC_InterbancarioSol = this.ENTC_InterbancarioSol;
				Item.ENTC_InterbancarioDol = this.ENTC_InterbancarioDol;
				Item.ENTC_CuentaDetraccion = this.ENTC_CuentaDetraccion;
				Item.ENTC_ServicioLogistico = this.ENTC_ServicioLogistico;
				Item.ENTC_OcultarShipper = this.ENTC_OcultarShipper;
				Item.ENTC_ObsFinanzasCliente = this.ENTC_ObsFinanzasCliente;
				Item.ENTC_BloqueoFinanzasCliente = this.ENTC_BloqueoFinanzasCliente;
				Item.ENTC_UsrBloqueoCliente = this.ENTC_UsrBloqueoCliente;
				Item.ENTC_FecBloqueoCliente = this.ENTC_FecBloqueoCliente;
				Item.ENTC_EmailFinanzas = this.ENTC_EmailFinanzas;
				Item.ENTC_ObsBloqueoCliente = this.ENTC_ObsBloqueoCliente;
				Item.ENTC_OtrosTraficos = this.ENTC_OtrosTraficos;
				Item.ENTC_Mandato = this.ENTC_Mandato;
				Item.ENTC_SLI = this.ENTC_SLI;
				Item.ENTC_Exportacion = this.ENTC_Exportacion;
				Item.ENTC_UsrBloqueoProveedor = this.ENTC_UsrBloqueoProveedor;
				Item.ENTC_FecBloqueoProveedor = this.ENTC_FecBloqueoProveedor;
				Item.ENTC_BloqueoFinanzasProveedor = this.ENTC_BloqueoFinanzasProveedor;
				Item.ENTC_ObsFinanzasProveedor = this.ENTC_ObsFinanzasProveedor;
				Item.ENTC_ObsBloqueoProveedor = this.ENTC_ObsBloqueoProveedor;
				Item.ENTC_ProvAsumeDetraccion = this.ENTC_ProvAsumeDetraccion;
                Item.TIPO_CodSEG = this.TIPO_CodSEG;
                Item.ENTC_CodSAP_C = this.ENTC_CodSAP_C;
                Item.ENTC_CodSAP_P = this.ENTC_CodSAP_P;
                Item.ENTC_FecActSAP = this.ENTC_FecActSAP;
                Item.ENTC_EstActSAP = this.ENTC_EstActSAP;
            }
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
