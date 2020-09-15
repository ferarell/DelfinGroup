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
	public partial class Entidad
	{
		#region [ Variables Validación ]
		private Boolean m_entc_codigoOK;
		private String m_entc_codigoMSGERROR;
		private Boolean m_tipo_tabtdiOK;
		private String m_tipo_tabtdiMSGERROR;
		private Boolean m_tipo_codtdiOK;
		private String m_tipo_codtdiMSGERROR;
		private Boolean m_entc_tipentOK;
		private String m_entc_tipentMSGERROR;
		private Boolean m_entc_docidenOK;
		private String m_entc_docidenMSGERROR;
		private Boolean m_entc_domiciliadoOK;
		private String m_entc_domiciliadoMSGERROR;
		private Boolean m_entc_nombresOK;
		private String m_entc_nombresMSGERROR;
		private Boolean m_entc_apepatOK;
		private String m_entc_apepatMSGERROR;
		private Boolean m_entc_apematOK;
		private String m_entc_apematMSGERROR;
		private Boolean m_entc_nomcompletoOK;
		private String m_entc_nomcompletoMSGERROR;
		private Boolean m_entc_nomcomercialOK;
		private String m_entc_nomcomercialMSGERROR;
		private Boolean m_entc_razonsocialOK;
		private String m_entc_razonsocialMSGERROR;
		private Boolean m_entc_activoOK;
		private String m_entc_activoMSGERROR;
		private Boolean m_entc_fecnacOK;
		private String m_entc_fecnacMSGERROR;
		private Boolean m_entc_fecingOK;
		private String m_entc_fecingMSGERROR;
		private Boolean m_entc_vipOK;
		private String m_entc_vipMSGERROR;
		private Boolean m_entc_notasOK;
		private String m_entc_notasMSGERROR;
		private Boolean m_entc_sexoOK;
		private String m_entc_sexoMSGERROR;
		private Boolean m_entc_emailOK;
		private String m_entc_emailMSGERROR;
        private String m_entc_email2MSGERROR;
		private Boolean m_entc_webOK;
		private String m_entc_webMSGERROR;
		private Boolean m_entc_propioOK;
		private String m_entc_propioMSGERROR;
		private Boolean m_entc_telef1OK;
		private String m_entc_telef1MSGERROR;
		private Boolean m_entc_telef2OK;
		private String m_entc_telef2MSGERROR;
		private Boolean m_entc_telef3OK;
		private String m_entc_telef3MSGERROR;
		private Boolean m_entc_telef4OK;
		private String m_entc_telef4MSGERROR;
		private Boolean m_entc_beneficiarioOK;
		private String m_entc_beneficiarioMSGERROR;
		private Boolean m_entc_areaOK;
		private String m_entc_areaMSGERROR;
		private Boolean m_entc_cargoOK;
		private String m_entc_cargoMSGERROR;
		private Boolean m_user_codusrOK;
		private String m_user_codusrMSGERROR;
		private Boolean m_tipo_tabpaiOK;
		private String m_tipo_tabpaiMSGERROR;
		private Boolean m_tipo_codpaiOK;
		private String m_tipo_codpaiMSGERROR;
		private Boolean m_tipo_tabholOK;
		private String m_tipo_tabholMSGERROR;
		private Boolean m_tipo_codholOK;
		private String m_tipo_codholMSGERROR;
		private Boolean m_cons_codtftOK;
		private String m_cons_codtftMSGERROR;
		private Boolean m_cons_tabtftOK;
		private String m_cons_tabtftMSGERROR;
		private Boolean m_tipo_tabciuOK;
		private String m_tipo_tabciuMSGERROR;
		private Boolean m_tipo_codciuOK;
		private String m_tipo_codciuMSGERROR;
		private Boolean m_entc_prospectoOK;
		private String m_entc_prospectoMSGERROR;
		private Boolean m_tipo_tabdtmOK;
		private String m_tipo_tabdtmMSGERROR;
		private Boolean m_tipo_coddtmOK;
		private String m_tipo_coddtmMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;

        private string m_m_ENTC_DiasCreditoMSGERROR;
        private string m_ENTC_FechaCreditoMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodigoOK
		{
			get { return m_entc_codigoOK; }
			set
			{
				if (m_entc_codigoOK != value)
				{
					m_entc_codigoOK = value;
					OnPropertyChanged("ENTC_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public String ENTC_CodigoMSGERROR
		{
			get { return m_entc_codigoMSGERROR; }
			set
			{
				if (m_entc_codigoMSGERROR != value)
				{
					m_entc_codigoMSGERROR = value;
					OnPropertyChanged("ENTC_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabTDI.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabTDIOK
		{
			get { return m_tipo_tabtdiOK; }
			set
			{
				if (m_tipo_tabtdiOK != value)
				{
					m_tipo_tabtdiOK = value;
					OnPropertyChanged("TIPO_TabTDIOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabTDI.
		/// </summary>
		[DataMember]
		public String TIPO_TabTDIMSGERROR
		{
			get { return m_tipo_tabtdiMSGERROR; }
			set
			{
				if (m_tipo_tabtdiMSGERROR != value)
				{
					m_tipo_tabtdiMSGERROR = value;
					OnPropertyChanged("TIPO_TabTDIMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodTDI.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodTDIOK
		{
			get { return m_tipo_codtdiOK; }
			set
			{
				if (m_tipo_codtdiOK != value)
				{
					m_tipo_codtdiOK = value;
					OnPropertyChanged("TIPO_CodTDIOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodTDI.
		/// </summary>
		[DataMember]
		public String TIPO_CodTDIMSGERROR
		{
			get { return m_tipo_codtdiMSGERROR; }
			set
			{
				if (m_tipo_codtdiMSGERROR != value)
				{
					m_tipo_codtdiMSGERROR = value;
					OnPropertyChanged("TIPO_CodTDIMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_TipEnt.
		/// </summary>
		[DataMember]
		public Boolean ENTC_TipEntOK
		{
			get { return m_entc_tipentOK; }
			set
			{
				if (m_entc_tipentOK != value)
				{
					m_entc_tipentOK = value;
					OnPropertyChanged("ENTC_TipEntOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_TipEnt.
		/// </summary>
		[DataMember]
		public String ENTC_TipEntMSGERROR
		{
			get { return m_entc_tipentMSGERROR; }
			set
			{
				if (m_entc_tipentMSGERROR != value)
				{
					m_entc_tipentMSGERROR = value;
					OnPropertyChanged("ENTC_TipEntMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_DocIden.
		/// </summary>
		[DataMember]
		public Boolean ENTC_DocIdenOK
		{
			get { return m_entc_docidenOK; }
			set
			{
				if (m_entc_docidenOK != value)
				{
					m_entc_docidenOK = value;
					OnPropertyChanged("ENTC_DocIdenOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_DocIden.
		/// </summary>
		[DataMember]
		public String ENTC_DocIdenMSGERROR
		{
			get { return m_entc_docidenMSGERROR; }
			set
			{
				if (m_entc_docidenMSGERROR != value)
				{
					m_entc_docidenMSGERROR = value;
					OnPropertyChanged("ENTC_DocIdenMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Domiciliado.
		/// </summary>
		[DataMember]
		public Boolean ENTC_DomiciliadoOK
		{
			get { return m_entc_domiciliadoOK; }
			set
			{
				if (m_entc_domiciliadoOK != value)
				{
					m_entc_domiciliadoOK = value;
					OnPropertyChanged("ENTC_DomiciliadoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Domiciliado.
		/// </summary>
		[DataMember]
		public String ENTC_DomiciliadoMSGERROR
		{
			get { return m_entc_domiciliadoMSGERROR; }
			set
			{
				if (m_entc_domiciliadoMSGERROR != value)
				{
					m_entc_domiciliadoMSGERROR = value;
					OnPropertyChanged("ENTC_DomiciliadoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Nombres.
		/// </summary>
		[DataMember]
		public Boolean ENTC_NombresOK
		{
			get { return m_entc_nombresOK; }
			set
			{
				if (m_entc_nombresOK != value)
				{
					m_entc_nombresOK = value;
					OnPropertyChanged("ENTC_NombresOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Nombres.
		/// </summary>
		[DataMember]
		public String ENTC_NombresMSGERROR
		{
			get { return m_entc_nombresMSGERROR; }
			set
			{
				if (m_entc_nombresMSGERROR != value)
				{
					m_entc_nombresMSGERROR = value;
					OnPropertyChanged("ENTC_NombresMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_ApePat.
		/// </summary>
		[DataMember]
		public Boolean ENTC_ApePatOK
		{
			get { return m_entc_apepatOK; }
			set
			{
				if (m_entc_apepatOK != value)
				{
					m_entc_apepatOK = value;
					OnPropertyChanged("ENTC_ApePatOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_ApePat.
		/// </summary>
		[DataMember]
		public String ENTC_ApePatMSGERROR
		{
			get { return m_entc_apepatMSGERROR; }
			set
			{
				if (m_entc_apepatMSGERROR != value)
				{
					m_entc_apepatMSGERROR = value;
					OnPropertyChanged("ENTC_ApePatMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_ApeMat.
		/// </summary>
		[DataMember]
		public Boolean ENTC_ApeMatOK
		{
			get { return m_entc_apematOK; }
			set
			{
				if (m_entc_apematOK != value)
				{
					m_entc_apematOK = value;
					OnPropertyChanged("ENTC_ApeMatOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_ApeMat.
		/// </summary>
		[DataMember]
		public String ENTC_ApeMatMSGERROR
		{
			get { return m_entc_apematMSGERROR; }
			set
			{
				if (m_entc_apematMSGERROR != value)
				{
					m_entc_apematMSGERROR = value;
					OnPropertyChanged("ENTC_ApeMatMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_NomCompleto.
		/// </summary>
		[DataMember]
		public Boolean ENTC_NomCompletoOK
		{
			get { return m_entc_nomcompletoOK; }
			set
			{
				if (m_entc_nomcompletoOK != value)
				{
					m_entc_nomcompletoOK = value;
					OnPropertyChanged("ENTC_NomCompletoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_NomCompleto.
		/// </summary>
		[DataMember]
		public String ENTC_NomCompletoMSGERROR
		{
			get { return m_entc_nomcompletoMSGERROR; }
			set
			{
				if (m_entc_nomcompletoMSGERROR != value)
				{
					m_entc_nomcompletoMSGERROR = value;
					OnPropertyChanged("ENTC_NomCompletoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_NomComercial.
		/// </summary>
		[DataMember]
		public Boolean ENTC_NomComercialOK
		{
			get { return m_entc_nomcomercialOK; }
			set
			{
				if (m_entc_nomcomercialOK != value)
				{
					m_entc_nomcomercialOK = value;
					OnPropertyChanged("ENTC_NomComercialOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_NomComercial.
		/// </summary>
		[DataMember]
		public String ENTC_NomComercialMSGERROR
		{
			get { return m_entc_nomcomercialMSGERROR; }
			set
			{
				if (m_entc_nomcomercialMSGERROR != value)
				{
					m_entc_nomcomercialMSGERROR = value;
					OnPropertyChanged("ENTC_NomComercialMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_RazonSocial.
		/// </summary>
		[DataMember]
		public Boolean ENTC_RazonSocialOK
		{
			get { return m_entc_razonsocialOK; }
			set
			{
				if (m_entc_razonsocialOK != value)
				{
					m_entc_razonsocialOK = value;
					OnPropertyChanged("ENTC_RazonSocialOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_RazonSocial.
		/// </summary>
		[DataMember]
		public String ENTC_RazonSocialMSGERROR
		{
			get { return m_entc_razonsocialMSGERROR; }
			set
			{
				if (m_entc_razonsocialMSGERROR != value)
				{
					m_entc_razonsocialMSGERROR = value;
					OnPropertyChanged("ENTC_RazonSocialMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Activo.
		/// </summary>
		[DataMember]
		public Boolean ENTC_ActivoOK
		{
			get { return m_entc_activoOK; }
			set
			{
				if (m_entc_activoOK != value)
				{
					m_entc_activoOK = value;
					OnPropertyChanged("ENTC_ActivoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Activo.
		/// </summary>
		[DataMember]
		public String ENTC_ActivoMSGERROR
		{
			get { return m_entc_activoMSGERROR; }
			set
			{
				if (m_entc_activoMSGERROR != value)
				{
					m_entc_activoMSGERROR = value;
					OnPropertyChanged("ENTC_ActivoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_FecNac.
		/// </summary>
		[DataMember]
		public Boolean ENTC_FecNacOK
		{
			get { return m_entc_fecnacOK; }
			set
			{
				if (m_entc_fecnacOK != value)
				{
					m_entc_fecnacOK = value;
					OnPropertyChanged("ENTC_FecNacOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_FecNac.
		/// </summary>
		[DataMember]
		public String ENTC_FecNacMSGERROR
		{
			get { return m_entc_fecnacMSGERROR; }
			set
			{
				if (m_entc_fecnacMSGERROR != value)
				{
					m_entc_fecnacMSGERROR = value;
					OnPropertyChanged("ENTC_FecNacMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_FecIng.
		/// </summary>
		[DataMember]
		public Boolean ENTC_FecIngOK
		{
			get { return m_entc_fecingOK; }
			set
			{
				if (m_entc_fecingOK != value)
				{
					m_entc_fecingOK = value;
					OnPropertyChanged("ENTC_FecIngOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_FecIng.
		/// </summary>
		[DataMember]
		public String ENTC_FecIngMSGERROR
		{
			get { return m_entc_fecingMSGERROR; }
			set
			{
				if (m_entc_fecingMSGERROR != value)
				{
					m_entc_fecingMSGERROR = value;
					OnPropertyChanged("ENTC_FecIngMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_VIP.
		/// </summary>
		[DataMember]
		public Boolean ENTC_VIPOK
		{
			get { return m_entc_vipOK; }
			set
			{
				if (m_entc_vipOK != value)
				{
					m_entc_vipOK = value;
					OnPropertyChanged("ENTC_VIPOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_VIP.
		/// </summary>
		[DataMember]
		public String ENTC_VIPMSGERROR
		{
			get { return m_entc_vipMSGERROR; }
			set
			{
				if (m_entc_vipMSGERROR != value)
				{
					m_entc_vipMSGERROR = value;
					OnPropertyChanged("ENTC_VIPMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Notas.
		/// </summary>
		[DataMember]
		public Boolean ENTC_NotasOK
		{
			get { return m_entc_notasOK; }
			set
			{
				if (m_entc_notasOK != value)
				{
					m_entc_notasOK = value;
					OnPropertyChanged("ENTC_NotasOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Notas.
		/// </summary>
		[DataMember]
		public String ENTC_NotasMSGERROR
		{
			get { return m_entc_notasMSGERROR; }
			set
			{
				if (m_entc_notasMSGERROR != value)
				{
					m_entc_notasMSGERROR = value;
					OnPropertyChanged("ENTC_NotasMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Sexo.
		/// </summary>
		[DataMember]
		public Boolean ENTC_SexoOK
		{
			get { return m_entc_sexoOK; }
			set
			{
				if (m_entc_sexoOK != value)
				{
					m_entc_sexoOK = value;
					OnPropertyChanged("ENTC_SexoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Sexo.
		/// </summary>
		[DataMember]
		public String ENTC_SexoMSGERROR
		{
			get { return m_entc_sexoMSGERROR; }
			set
			{
				if (m_entc_sexoMSGERROR != value)
				{
					m_entc_sexoMSGERROR = value;
					OnPropertyChanged("ENTC_SexoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_EMail.
		/// </summary>
		[DataMember]
		public Boolean ENTC_EMailOK
		{
			get { return m_entc_emailOK; }
			set
			{
				if (m_entc_emailOK != value)
				{
					m_entc_emailOK = value;
					OnPropertyChanged("ENTC_EMailOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_EMail.
		/// </summary>
		[DataMember]
		public String ENTC_EMailMSGERROR
		{
			get { return m_entc_emailMSGERROR; }
			set
			{
				if (m_entc_emailMSGERROR != value)
				{
					m_entc_emailMSGERROR = value;
					OnPropertyChanged("ENTC_EMailMSGERROR");
				}
			}
		}
        /// <summary>
        /// Gets or sets el mensaje de validación de: ENTC_EMail2.
        /// </summary>
        [DataMember]
        public String ENTC_EMail2MSGERROR
        {
            get { return m_entc_email2MSGERROR; }
            set
            {
                if (m_entc_email2MSGERROR != value)
                {
                    m_entc_email2MSGERROR = value;
                    OnPropertyChanged("ENTC_EMail2MSGERROR");
                }
            }
        }
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Web.
		/// </summary>
		[DataMember]
		public Boolean ENTC_WebOK
		{
			get { return m_entc_webOK; }
			set
			{
				if (m_entc_webOK != value)
				{
					m_entc_webOK = value;
					OnPropertyChanged("ENTC_WebOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Web.
		/// </summary>
		[DataMember]
		public String ENTC_WebMSGERROR
		{
			get { return m_entc_webMSGERROR; }
			set
			{
				if (m_entc_webMSGERROR != value)
				{
					m_entc_webMSGERROR = value;
					OnPropertyChanged("ENTC_WebMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Propio.
		/// </summary>
		[DataMember]
		public Boolean ENTC_PropioOK
		{
			get { return m_entc_propioOK; }
			set
			{
				if (m_entc_propioOK != value)
				{
					m_entc_propioOK = value;
					OnPropertyChanged("ENTC_PropioOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Propio.
		/// </summary>
		[DataMember]
		public String ENTC_PropioMSGERROR
		{
			get { return m_entc_propioMSGERROR; }
			set
			{
				if (m_entc_propioMSGERROR != value)
				{
					m_entc_propioMSGERROR = value;
					OnPropertyChanged("ENTC_PropioMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Telef1.
		/// </summary>
		[DataMember]
		public Boolean ENTC_Telef1OK
		{
			get { return m_entc_telef1OK; }
			set
			{
				if (m_entc_telef1OK != value)
				{
					m_entc_telef1OK = value;
					OnPropertyChanged("ENTC_Telef1OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Telef1.
		/// </summary>
		[DataMember]
		public String ENTC_Telef1MSGERROR
		{
			get { return m_entc_telef1MSGERROR; }
			set
			{
				if (m_entc_telef1MSGERROR != value)
				{
					m_entc_telef1MSGERROR = value;
					OnPropertyChanged("ENTC_Telef1MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Telef2.
		/// </summary>
		[DataMember]
		public Boolean ENTC_Telef2OK
		{
			get { return m_entc_telef2OK; }
			set
			{
				if (m_entc_telef2OK != value)
				{
					m_entc_telef2OK = value;
					OnPropertyChanged("ENTC_Telef2OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Telef2.
		/// </summary>
		[DataMember]
		public String ENTC_Telef2MSGERROR
		{
			get { return m_entc_telef2MSGERROR; }
			set
			{
				if (m_entc_telef2MSGERROR != value)
				{
					m_entc_telef2MSGERROR = value;
					OnPropertyChanged("ENTC_Telef2MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Telef3.
		/// </summary>
		[DataMember]
		public Boolean ENTC_Telef3OK
		{
			get { return m_entc_telef3OK; }
			set
			{
				if (m_entc_telef3OK != value)
				{
					m_entc_telef3OK = value;
					OnPropertyChanged("ENTC_Telef3OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Telef3.
		/// </summary>
		[DataMember]
		public String ENTC_Telef3MSGERROR
		{
			get { return m_entc_telef3MSGERROR; }
			set
			{
				if (m_entc_telef3MSGERROR != value)
				{
					m_entc_telef3MSGERROR = value;
					OnPropertyChanged("ENTC_Telef3MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Telef4.
		/// </summary>
		[DataMember]
		public Boolean ENTC_Telef4OK
		{
			get { return m_entc_telef4OK; }
			set
			{
				if (m_entc_telef4OK != value)
				{
					m_entc_telef4OK = value;
					OnPropertyChanged("ENTC_Telef4OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Telef4.
		/// </summary>
		[DataMember]
		public String ENTC_Telef4MSGERROR
		{
			get { return m_entc_telef4MSGERROR; }
			set
			{
				if (m_entc_telef4MSGERROR != value)
				{
					m_entc_telef4MSGERROR = value;
					OnPropertyChanged("ENTC_Telef4MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Beneficiario.
		/// </summary>
		[DataMember]
		public Boolean ENTC_BeneficiarioOK
		{
			get { return m_entc_beneficiarioOK; }
			set
			{
				if (m_entc_beneficiarioOK != value)
				{
					m_entc_beneficiarioOK = value;
					OnPropertyChanged("ENTC_BeneficiarioOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Beneficiario.
		/// </summary>
		[DataMember]
		public String ENTC_BeneficiarioMSGERROR
		{
			get { return m_entc_beneficiarioMSGERROR; }
			set
			{
				if (m_entc_beneficiarioMSGERROR != value)
				{
					m_entc_beneficiarioMSGERROR = value;
					OnPropertyChanged("ENTC_BeneficiarioMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Area.
		/// </summary>
		[DataMember]
		public Boolean ENTC_AreaOK
		{
			get { return m_entc_areaOK; }
			set
			{
				if (m_entc_areaOK != value)
				{
					m_entc_areaOK = value;
					OnPropertyChanged("ENTC_AreaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Area.
		/// </summary>
		[DataMember]
		public String ENTC_AreaMSGERROR
		{
			get { return m_entc_areaMSGERROR; }
			set
			{
				if (m_entc_areaMSGERROR != value)
				{
					m_entc_areaMSGERROR = value;
					OnPropertyChanged("ENTC_AreaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Cargo.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CargoOK
		{
			get { return m_entc_cargoOK; }
			set
			{
				if (m_entc_cargoOK != value)
				{
					m_entc_cargoOK = value;
					OnPropertyChanged("ENTC_CargoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Cargo.
		/// </summary>
		[DataMember]
		public String ENTC_CargoMSGERROR
		{
			get { return m_entc_cargoMSGERROR; }
			set
			{
				if (m_entc_cargoMSGERROR != value)
				{
					m_entc_cargoMSGERROR = value;
					OnPropertyChanged("ENTC_CargoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: USER_CodUsr.
		/// </summary>
		[DataMember]
		public Boolean USER_CodUsrOK
		{
			get { return m_user_codusrOK; }
			set
			{
				if (m_user_codusrOK != value)
				{
					m_user_codusrOK = value;
					OnPropertyChanged("USER_CodUsrOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: USER_CodUsr.
		/// </summary>
		[DataMember]
		public String USER_CodUsrMSGERROR
		{
			get { return m_user_codusrMSGERROR; }
			set
			{
				if (m_user_codusrMSGERROR != value)
				{
					m_user_codusrMSGERROR = value;
					OnPropertyChanged("USER_CodUsrMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabPai.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabPaiOK
		{
			get { return m_tipo_tabpaiOK; }
			set
			{
				if (m_tipo_tabpaiOK != value)
				{
					m_tipo_tabpaiOK = value;
					OnPropertyChanged("TIPO_TabPaiOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabPai.
		/// </summary>
		[DataMember]
		public String TIPO_TabPaiMSGERROR
		{
			get { return m_tipo_tabpaiMSGERROR; }
			set
			{
				if (m_tipo_tabpaiMSGERROR != value)
				{
					m_tipo_tabpaiMSGERROR = value;
					OnPropertyChanged("TIPO_TabPaiMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodPai.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodPaiOK
		{
			get { return m_tipo_codpaiOK; }
			set
			{
				if (m_tipo_codpaiOK != value)
				{
					m_tipo_codpaiOK = value;
					OnPropertyChanged("TIPO_CodPaiOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodPai.
		/// </summary>
		[DataMember]
		public String TIPO_CodPaiMSGERROR
		{
			get { return m_tipo_codpaiMSGERROR; }
			set
			{
				if (m_tipo_codpaiMSGERROR != value)
				{
					m_tipo_codpaiMSGERROR = value;
					OnPropertyChanged("TIPO_CodPaiMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabHol.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabHolOK
		{
			get { return m_tipo_tabholOK; }
			set
			{
				if (m_tipo_tabholOK != value)
				{
					m_tipo_tabholOK = value;
					OnPropertyChanged("TIPO_TabHolOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabHol.
		/// </summary>
		[DataMember]
		public String TIPO_TabHolMSGERROR
		{
			get { return m_tipo_tabholMSGERROR; }
			set
			{
				if (m_tipo_tabholMSGERROR != value)
				{
					m_tipo_tabholMSGERROR = value;
					OnPropertyChanged("TIPO_TabHolMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodHol.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodHolOK
		{
			get { return m_tipo_codholOK; }
			set
			{
				if (m_tipo_codholOK != value)
				{
					m_tipo_codholOK = value;
					OnPropertyChanged("TIPO_CodHolOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodHol.
		/// </summary>
		[DataMember]
		public String TIPO_CodHolMSGERROR
		{
			get { return m_tipo_codholMSGERROR; }
			set
			{
				if (m_tipo_codholMSGERROR != value)
				{
					m_tipo_codholMSGERROR = value;
					OnPropertyChanged("TIPO_CodHolMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodTFT.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodTFTOK
		{
			get { return m_cons_codtftOK; }
			set
			{
				if (m_cons_codtftOK != value)
				{
					m_cons_codtftOK = value;
					OnPropertyChanged("CONS_CodTFTOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodTFT.
		/// </summary>
		[DataMember]
		public String CONS_CodTFTMSGERROR
		{
			get { return m_cons_codtftMSGERROR; }
			set
			{
				if (m_cons_codtftMSGERROR != value)
				{
					m_cons_codtftMSGERROR = value;
					OnPropertyChanged("CONS_CodTFTMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabTFT.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabTFTOK
		{
			get { return m_cons_tabtftOK; }
			set
			{
				if (m_cons_tabtftOK != value)
				{
					m_cons_tabtftOK = value;
					OnPropertyChanged("CONS_TabTFTOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabTFT.
		/// </summary>
		[DataMember]
		public String CONS_TabTFTMSGERROR
		{
			get { return m_cons_tabtftMSGERROR; }
			set
			{
				if (m_cons_tabtftMSGERROR != value)
				{
					m_cons_tabtftMSGERROR = value;
					OnPropertyChanged("CONS_TabTFTMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabCiu.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabCiuOK
		{
			get { return m_tipo_tabciuOK; }
			set
			{
				if (m_tipo_tabciuOK != value)
				{
					m_tipo_tabciuOK = value;
					OnPropertyChanged("TIPO_TabCiuOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabCiu.
		/// </summary>
		[DataMember]
		public String TIPO_TabCiuMSGERROR
		{
			get { return m_tipo_tabciuMSGERROR; }
			set
			{
				if (m_tipo_tabciuMSGERROR != value)
				{
					m_tipo_tabciuMSGERROR = value;
					OnPropertyChanged("TIPO_TabCiuMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodCiu.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodCiuOK
		{
			get { return m_tipo_codciuOK; }
			set
			{
				if (m_tipo_codciuOK != value)
				{
					m_tipo_codciuOK = value;
					OnPropertyChanged("TIPO_CodCiuOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodCiu.
		/// </summary>
		[DataMember]
		public String TIPO_CodCiuMSGERROR
		{
			get { return m_tipo_codciuMSGERROR; }
			set
			{
				if (m_tipo_codciuMSGERROR != value)
				{
					m_tipo_codciuMSGERROR = value;
					OnPropertyChanged("TIPO_CodCiuMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Prospecto.
		/// </summary>
		[DataMember]
		public Boolean ENTC_ProspectoOK
		{
			get { return m_entc_prospectoOK; }
			set
			{
				if (m_entc_prospectoOK != value)
				{
					m_entc_prospectoOK = value;
					OnPropertyChanged("ENTC_ProspectoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Prospecto.
		/// </summary>
		[DataMember]
		public String ENTC_ProspectoMSGERROR
		{
			get { return m_entc_prospectoMSGERROR; }
			set
			{
				if (m_entc_prospectoMSGERROR != value)
				{
					m_entc_prospectoMSGERROR = value;
					OnPropertyChanged("ENTC_ProspectoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabDTM.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabDTMOK
		{
			get { return m_tipo_tabdtmOK; }
			set
			{
				if (m_tipo_tabdtmOK != value)
				{
					m_tipo_tabdtmOK = value;
					OnPropertyChanged("TIPO_TabDTMOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabDTM.
		/// </summary>
		[DataMember]
		public String TIPO_TabDTMMSGERROR
		{
			get { return m_tipo_tabdtmMSGERROR; }
			set
			{
				if (m_tipo_tabdtmMSGERROR != value)
				{
					m_tipo_tabdtmMSGERROR = value;
					OnPropertyChanged("TIPO_TabDTMMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodDTM.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodDTMOK
		{
			get { return m_tipo_coddtmOK; }
			set
			{
				if (m_tipo_coddtmOK != value)
				{
					m_tipo_coddtmOK = value;
					OnPropertyChanged("TIPO_CodDTMOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodDTM.
		/// </summary>
		[DataMember]
		public String TIPO_CodDTMMSGERROR
		{
			get { return m_tipo_coddtmMSGERROR; }
			set
			{
				if (m_tipo_coddtmMSGERROR != value)
				{
					m_tipo_coddtmMSGERROR = value;
					OnPropertyChanged("TIPO_CodDTMMSGERROR");
				}
			}
		}

        [DataMember]
        public string ENTC_FechaCreditoMSGERROR
        {
            get { return m_ENTC_FechaCreditoMSGERROR; }
            set { m_ENTC_FechaCreditoMSGERROR = value; }
        }
        [DataMember]
        public string M_ENTC_DiasCreditoMSGERROR
        {
            get { return m_m_ENTC_DiasCreditoMSGERROR; }
            set { m_m_ENTC_DiasCreditoMSGERROR = value; }
        }
		#endregion

		#region [ Validacion ]
		private String m_mensajeError;
		
		[DataMember]
		public String MensajeError
		{
			get { return m_mensajeError; }
            set { m_mensajeError = value; }
		}
		public Boolean Validar()
		{
			try
			{
				Boolean _isCorrect = true;
				m_mensajeError = "";
				ENTC_CodigoOK  = true;
				ENTC_CodigoMSGERROR  = "";
				if( ENTC_Codigo == null)
				{
					_isCorrect = false;
					ENTC_CodigoOK  = false;
					ENTC_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ENTC_Codigo", "Entidad");
					m_mensajeError += "* Debe ingresar el campo ENTC_Codigo" + Environment.NewLine;
				}
				TIPO_CodTDIOK  = true;
				TIPO_CodTDIMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodTDI) )
				{
					_isCorrect = false;
					TIPO_CodTDIOK  = false;
					TIPO_CodTDIMSGERROR  = String.Format("Debe seleccionar el {0} de la {1}.", "tipo documento", "Entidad");
                    m_mensajeError += "* Debe seleccionar el campo tipo documento" + Environment.NewLine;
				}
				ENTC_TipEntOK  = true;
				ENTC_TipEntMSGERROR  = "";
				if( String.IsNullOrEmpty(ENTC_TipEnt) )
				{
					_isCorrect = false;
					ENTC_TipEntOK  = false;
					ENTC_TipEntMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ENTC_TipEnt", "Entidad");
					m_mensajeError += "* Debe ingresar el campo ENTC_TipEnt" + Environment.NewLine;
				}
				ENTC_DocIdenOK  = true;
				ENTC_DocIdenMSGERROR  = "";
				if( String.IsNullOrEmpty(ENTC_DocIden) && ValidarDocIden)
				{
					_isCorrect = false;
					ENTC_DocIdenOK  = false;
					ENTC_DocIdenMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "número de documento", "Entidad");
                    m_mensajeError += "* Debe ingresar el campo número de documento" + Environment.NewLine;
				}
				ENTC_DomiciliadoOK  = true;
				ENTC_DomiciliadoMSGERROR  = "";
				if( ENTC_Domiciliado == null)
				{
					_isCorrect = false;
					ENTC_DomiciliadoOK  = false;
					ENTC_DomiciliadoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ENTC_Domiciliado", "Entidad");
					m_mensajeError += "* Debe ingresar el campo ENTC_Domiciliado" + Environment.NewLine;
				}
				ENTC_VIPOK  = true;
				ENTC_VIPMSGERROR  = "";
				if( ENTC_VIP == null)
				{
					_isCorrect = false;
					ENTC_VIPOK  = false;
					ENTC_VIPMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ENTC_VIP", "Entidad");
					m_mensajeError += "* Debe ingresar el campo ENTC_VIP" + Environment.NewLine;
				}
				ENTC_SexoOK  = true;
				ENTC_SexoMSGERROR  = "";
				if( String.IsNullOrEmpty(ENTC_Sexo) )
				{
					_isCorrect = false;
					ENTC_SexoOK  = false;
					ENTC_SexoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ENTC_Sexo", "Entidad");
					m_mensajeError += "* Debe ingresar el campo ENTC_Sexo" + Environment.NewLine;
				}
                if (ENTC_TipEnt.Equals("J")) /* Persona Juridica */
                {
                    ENTC_RazonSocialMSGERROR = "";
                    if (String.IsNullOrEmpty(ENTC_RazonSocial))
                    {
                        _isCorrect = false;
                        ENTC_RazonSocialMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "razón social", "Entidad");
                        m_mensajeError += "* Debe ingresar el campo razón social" + Environment.NewLine;
                    }
                }
                else   /* Persona Natural */
                {
                    //ENTC_ApePatMSGERROR = "";
                    //if (String.IsNullOrEmpty(ENTC_ApePat))
                    //{
                    //    _isCorrect = false;
                    //    ENTC_ApePatMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "apellido paterno", "Entidad");
                    //    m_mensajeError += "* Debe ingresar el campo apellido paterno" + Environment.NewLine;
                    //}
                    //ENTC_ApeMatMSGERROR = "";
                    //if (String.IsNullOrEmpty(ENTC_ApeMat))
                    //{
                    //    _isCorrect = false;
                    //    ENTC_ApeMatMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "apellido materno", "Entidad");
                    //    m_mensajeError += "* Debe ingresar el campo apellido materno" + Environment.NewLine;
                    //}
                    ENTC_NombresMSGERROR = "";
                    if (String.IsNullOrEmpty(ENTC_Nombres))
                    {
                        _isCorrect = false;
                        ENTC_NombresMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "nombre", "Entidad");
                        m_mensajeError += "* Debe ingresar el campo nombre" + Environment.NewLine;
                    }
                }

                ENTC_FechaCreditoMSGERROR = "";
                if ((ENTC_DiasCredito != null && ENTC_DiasCredito.Value > 0) && ENTC_FechaCredito == null)
                {
                    _isCorrect = false;
                    ENTC_FechaCreditoMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "fecha crédito", "Entidad");
                    m_mensajeError += "* Debe ingresar el campo fecha crédito" + Environment.NewLine;
                }
                M_ENTC_DiasCreditoMSGERROR = "";
                if (ENTC_DiasCredito == null  && ENTC_FechaCredito != null)
                {
                    _isCorrect = false;
                    M_ENTC_DiasCreditoMSGERROR = String.Format("Debe ingresar los {0} de la {1}.", "días crédito", "Entidad");
                    m_mensajeError += "* Debe ingresar el campo días crédito" + Environment.NewLine;
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
