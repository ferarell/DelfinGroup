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
	public partial class Cab_Tarjas
	{
		#region [ Variables Validación ]
		private Boolean m_tarj_codigoOK;
		private String m_tarj_codigoMSGERROR;
		private Boolean m_tarj_hblOK;
		private String m_tarj_hblMSGERROR;
		private Boolean m_tarj_numeroOK;
		private String m_tarj_numeroMSGERROR;
		private Boolean m_tarj_valorOK;
		private String m_tarj_valorMSGERROR;
		private Boolean m_entc_clienteOK;
		private String m_entc_clienteMSGERROR;
		private Boolean m_entc_deptemporalOK;
		private String m_entc_deptemporalMSGERROR;
		private Boolean m_tipo_tabmndOK;
		private String m_tipo_tabmndMSGERROR;
		private Boolean m_tipo_codmndOK;
		private String m_tipo_codmndMSGERROR;
		private Boolean m_cons_codectOK;
		private String m_cons_codectMSGERROR;
		private Boolean m_cons_tabectOK;
		private String m_cons_tabectMSGERROR;
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
		/// Gets or sets el valor de validación de: TARJ_Codigo.
		/// </summary>
		[DataMember]
		public Boolean TARJ_CodigoOK
		{
			get { return m_tarj_codigoOK; }
			set
			{
				if (m_tarj_codigoOK != value)
				{
					m_tarj_codigoOK = value;
					OnPropertyChanged("TARJ_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARJ_Codigo.
		/// </summary>
		[DataMember]
		public String TARJ_CodigoMSGERROR
		{
			get { return m_tarj_codigoMSGERROR; }
			set
			{
				if (m_tarj_codigoMSGERROR != value)
				{
					m_tarj_codigoMSGERROR = value;
					OnPropertyChanged("TARJ_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TARJ_HBL.
		/// </summary>
		[DataMember]
		public Boolean TARJ_HBLOK
		{
			get { return m_tarj_hblOK; }
			set
			{
				if (m_tarj_hblOK != value)
				{
					m_tarj_hblOK = value;
					OnPropertyChanged("TARJ_HBLOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARJ_HBL.
		/// </summary>
		[DataMember]
		public String TARJ_HBLMSGERROR
		{
			get { return m_tarj_hblMSGERROR; }
			set
			{
				if (m_tarj_hblMSGERROR != value)
				{
					m_tarj_hblMSGERROR = value;
					OnPropertyChanged("TARJ_HBLMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TARJ_Numero.
		/// </summary>
		[DataMember]
		public Boolean TARJ_NumeroOK
		{
			get { return m_tarj_numeroOK; }
			set
			{
				if (m_tarj_numeroOK != value)
				{
					m_tarj_numeroOK = value;
					OnPropertyChanged("TARJ_NumeroOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARJ_Numero.
		/// </summary>
		[DataMember]
		public String TARJ_NumeroMSGERROR
		{
			get { return m_tarj_numeroMSGERROR; }
			set
			{
				if (m_tarj_numeroMSGERROR != value)
				{
					m_tarj_numeroMSGERROR = value;
					OnPropertyChanged("TARJ_NumeroMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TARJ_Valor.
		/// </summary>
		[DataMember]
		public Boolean TARJ_ValorOK
		{
			get { return m_tarj_valorOK; }
			set
			{
				if (m_tarj_valorOK != value)
				{
					m_tarj_valorOK = value;
					OnPropertyChanged("TARJ_ValorOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARJ_Valor.
		/// </summary>
		[DataMember]
		public String TARJ_ValorMSGERROR
		{
			get { return m_tarj_valorMSGERROR; }
			set
			{
				if (m_tarj_valorMSGERROR != value)
				{
					m_tarj_valorMSGERROR = value;
					OnPropertyChanged("TARJ_ValorMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Cliente.
		/// </summary>
		[DataMember]
		public Boolean ENTC_ClienteOK
		{
			get { return m_entc_clienteOK; }
			set
			{
				if (m_entc_clienteOK != value)
				{
					m_entc_clienteOK = value;
					OnPropertyChanged("ENTC_ClienteOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Cliente.
		/// </summary>
		[DataMember]
		public String ENTC_ClienteMSGERROR
		{
			get { return m_entc_clienteMSGERROR; }
			set
			{
				if (m_entc_clienteMSGERROR != value)
				{
					m_entc_clienteMSGERROR = value;
					OnPropertyChanged("ENTC_ClienteMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_DepTemporal.
		/// </summary>
		[DataMember]
		public Boolean ENTC_DepTemporalOK
		{
			get { return m_entc_deptemporalOK; }
			set
			{
				if (m_entc_deptemporalOK != value)
				{
					m_entc_deptemporalOK = value;
					OnPropertyChanged("ENTC_DepTemporalOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_DepTemporal.
		/// </summary>
		[DataMember]
		public String ENTC_DepTemporalMSGERROR
		{
			get { return m_entc_deptemporalMSGERROR; }
			set
			{
				if (m_entc_deptemporalMSGERROR != value)
				{
					m_entc_deptemporalMSGERROR = value;
					OnPropertyChanged("ENTC_DepTemporalMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabMND.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabMNDOK
		{
			get { return m_tipo_tabmndOK; }
			set
			{
				if (m_tipo_tabmndOK != value)
				{
					m_tipo_tabmndOK = value;
					OnPropertyChanged("TIPO_TabMNDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabMND.
		/// </summary>
		[DataMember]
		public String TIPO_TabMNDMSGERROR
		{
			get { return m_tipo_tabmndMSGERROR; }
			set
			{
				if (m_tipo_tabmndMSGERROR != value)
				{
					m_tipo_tabmndMSGERROR = value;
					OnPropertyChanged("TIPO_TabMNDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodMND.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodMNDOK
		{
			get { return m_tipo_codmndOK; }
			set
			{
				if (m_tipo_codmndOK != value)
				{
					m_tipo_codmndOK = value;
					OnPropertyChanged("TIPO_CodMNDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodMND.
		/// </summary>
		[DataMember]
		public String TIPO_CodMNDMSGERROR
		{
			get { return m_tipo_codmndMSGERROR; }
			set
			{
				if (m_tipo_codmndMSGERROR != value)
				{
					m_tipo_codmndMSGERROR = value;
					OnPropertyChanged("TIPO_CodMNDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodECT.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodECTOK
		{
			get { return m_cons_codectOK; }
			set
			{
				if (m_cons_codectOK != value)
				{
					m_cons_codectOK = value;
					OnPropertyChanged("CONS_CodECTOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodECT.
		/// </summary>
		[DataMember]
		public String CONS_CodECTMSGERROR
		{
			get { return m_cons_codectMSGERROR; }
			set
			{
				if (m_cons_codectMSGERROR != value)
				{
					m_cons_codectMSGERROR = value;
					OnPropertyChanged("CONS_CodECTMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabECT.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabECTOK
		{
			get { return m_cons_tabectOK; }
			set
			{
				if (m_cons_tabectOK != value)
				{
					m_cons_tabectOK = value;
					OnPropertyChanged("CONS_TabECTOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabECT.
		/// </summary>
		[DataMember]
		public String CONS_TabECTMSGERROR
		{
			get { return m_cons_tabectMSGERROR; }
			set
			{
				if (m_cons_tabectMSGERROR != value)
				{
					m_cons_tabectMSGERROR = value;
					OnPropertyChanged("CONS_TabECTMSGERROR");
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
				TARJ_CodigoOK  = true;
				TARJ_CodigoMSGERROR  = "";
                //if( TARJ_Codigo == null)
                //{
                //    _isCorrect = false;
                //    TARJ_CodigoOK  = false;
                //    TARJ_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TARJ_Codigo", "Cab_Tarjas");
                //    m_mensajeError += "* Debe ingresar el campo TARJ_Codigo" + Environment.NewLine;
                //}
				TARJ_ValorOK  = true;
				TARJ_ValorMSGERROR  = "";
				if( TARJ_Valor == 0)
				{
					_isCorrect = false;
					TARJ_ValorMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Valor", "Tarja");
					m_mensajeError += "* Debe ingresar el campo Valor" + Environment.NewLine;
				}
			    TIPO_CodMNDMSGERROR = "";
                if (String.IsNullOrEmpty(TIPO_CodMND))
			    {
                    _isCorrect = false;
                    TIPO_CodMNDMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "Tipo de Moneda", "Tarja");
                    m_mensajeError += "* Debe seleccionar el campo Moneda" + Environment.NewLine;
			    }
			    ENTC_ClienteMSGERROR = "";
                if (ENTC_Cliente == null)
			    {
                    _isCorrect = false;
                    ENTC_ClienteMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Cliente", "Tarja");
                    m_mensajeError += "* Debe ingresar el campo Cliente" + Environment.NewLine;  
			    }
                ENTC_DepTemporalMSGERROR= "";
                if (ENTC_DepTemporal == null)
                {
                    _isCorrect = false;
                    ENTC_DepTemporalMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Deposito Temporal", "Tarja");
                    m_mensajeError += "* Debe ingresar el campo Deposito Temporal" + Environment.NewLine;
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
