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
	public partial class Cab_Tarifa
	{
		#region [ Variables Validación ]
		private Boolean m_ctar_codigoOK;
		private String m_ctar_codigoMSGERROR;
		private Boolean m_ctar_numeroOK;
		private String m_ctar_numeroMSGERROR;
		private Boolean m_ctar_descripOK;
		private String m_ctar_descripMSGERROR;
		private Boolean m_ctar_fecemiOK;
		private String m_ctar_fecemiMSGERROR;
		private Boolean m_ctar_feciniOK;
		private String m_ctar_feciniMSGERROR;
		private Boolean m_ctar_fecfinOK;
		private String m_ctar_fecfinMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		private Boolean m_ctar_tipoOK;
		private String m_ctar_tipoMSGERROR;
		private Boolean m_tipo_tabmndOK;
		private String m_tipo_tabmndMSGERROR;
		private Boolean m_tipo_codmndOK;
		private String m_tipo_codmndMSGERROR;
		private Boolean m_entc_codigoOK;
		private String m_entc_codigoMSGERROR;
		private Boolean m_ctar_agmaritimoOK;
		private String m_ctar_agmaritimoMSGERROR;
		private Boolean m_ctar_deptemporalOK;
		private String m_ctar_deptemporalMSGERROR;
		private Boolean m_ctar_depvacioOK;
		private String m_ctar_depvacioMSGERROR;
		private Boolean m_cons_codregOK;
		private String m_cons_codregMSGERROR;
		private Boolean m_cons_tabregOK;
		private String m_cons_tabregMSGERROR;
		private Boolean m_ctar_profitOK;
		private String m_ctar_profitMSGERROR;
		private Boolean m_ctar_montolnavieraOK;
		private String m_ctar_montolnavieraMSGERROR;
		private Boolean m_ctar_montodtemporalOK;
		private String m_ctar_montodtemporalMSGERROR;
		private Boolean m_tipe_codigoOK;
		private String m_tipe_codigoMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: CTAR_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CTAR_CodigoOK
		{
			get { return m_ctar_codigoOK; }
			set
			{
				if (m_ctar_codigoOK != value)
				{
					m_ctar_codigoOK = value;
					OnPropertyChanged("CTAR_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_Codigo.
		/// </summary>
		[DataMember]
		public String CTAR_CodigoMSGERROR
		{
			get { return m_ctar_codigoMSGERROR; }
			set
			{
				if (m_ctar_codigoMSGERROR != value)
				{
					m_ctar_codigoMSGERROR = value;
					OnPropertyChanged("CTAR_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CTAR_Numero.
		/// </summary>
		[DataMember]
		public Boolean CTAR_NumeroOK
		{
			get { return m_ctar_numeroOK; }
			set
			{
				if (m_ctar_numeroOK != value)
				{
					m_ctar_numeroOK = value;
					OnPropertyChanged("CTAR_NumeroOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_Numero.
		/// </summary>
		[DataMember]
		public String CTAR_NumeroMSGERROR
		{
			get { return m_ctar_numeroMSGERROR; }
			set
			{
				if (m_ctar_numeroMSGERROR != value)
				{
					m_ctar_numeroMSGERROR = value;
					OnPropertyChanged("CTAR_NumeroMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CTAR_Descrip.
		/// </summary>
		[DataMember]
		public Boolean CTAR_DescripOK
		{
			get { return m_ctar_descripOK; }
			set
			{
				if (m_ctar_descripOK != value)
				{
					m_ctar_descripOK = value;
					OnPropertyChanged("CTAR_DescripOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_Descrip.
		/// </summary>
		[DataMember]
		public String CTAR_DescripMSGERROR
		{
			get { return m_ctar_descripMSGERROR; }
			set
			{
				if (m_ctar_descripMSGERROR != value)
				{
					m_ctar_descripMSGERROR = value;
					OnPropertyChanged("CTAR_DescripMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CTAR_FecEmi.
		/// </summary>
		[DataMember]
		public Boolean CTAR_FecEmiOK
		{
			get { return m_ctar_fecemiOK; }
			set
			{
				if (m_ctar_fecemiOK != value)
				{
					m_ctar_fecemiOK = value;
					OnPropertyChanged("CTAR_FecEmiOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_FecEmi.
		/// </summary>
		[DataMember]
		public String CTAR_FecEmiMSGERROR
		{
			get { return m_ctar_fecemiMSGERROR; }
			set
			{
				if (m_ctar_fecemiMSGERROR != value)
				{
					m_ctar_fecemiMSGERROR = value;
					OnPropertyChanged("CTAR_FecEmiMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CTAR_FecIni.
		/// </summary>
		[DataMember]
		public Boolean CTAR_FecIniOK
		{
			get { return m_ctar_feciniOK; }
			set
			{
				if (m_ctar_feciniOK != value)
				{
					m_ctar_feciniOK = value;
					OnPropertyChanged("CTAR_FecIniOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_FecIni.
		/// </summary>
		[DataMember]
		public String CTAR_FecIniMSGERROR
		{
			get { return m_ctar_feciniMSGERROR; }
			set
			{
				if (m_ctar_feciniMSGERROR != value)
				{
					m_ctar_feciniMSGERROR = value;
					OnPropertyChanged("CTAR_FecIniMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CTAR_FecFin.
		/// </summary>
		[DataMember]
		public Boolean CTAR_FecFinOK
		{
			get { return m_ctar_fecfinOK; }
			set
			{
				if (m_ctar_fecfinOK != value)
				{
					m_ctar_fecfinOK = value;
					OnPropertyChanged("CTAR_FecFinOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_FecFin.
		/// </summary>
		[DataMember]
		public String CTAR_FecFinMSGERROR
		{
			get { return m_ctar_fecfinMSGERROR; }
			set
			{
				if (m_ctar_fecfinMSGERROR != value)
				{
					m_ctar_fecfinMSGERROR = value;
					OnPropertyChanged("CTAR_FecFinMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CTAR_Tipo.
		/// </summary>
		[DataMember]
		public Boolean CTAR_TipoOK
		{
			get { return m_ctar_tipoOK; }
			set
			{
				if (m_ctar_tipoOK != value)
				{
					m_ctar_tipoOK = value;
					OnPropertyChanged("CTAR_TipoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_Tipo.
		/// </summary>
		[DataMember]
		public String CTAR_TipoMSGERROR
		{
			get { return m_ctar_tipoMSGERROR; }
			set
			{
				if (m_ctar_tipoMSGERROR != value)
				{
					m_ctar_tipoMSGERROR = value;
					OnPropertyChanged("CTAR_TipoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabMnd.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabMndOK
		{
			get { return m_tipo_tabmndOK; }
			set
			{
				if (m_tipo_tabmndOK != value)
				{
					m_tipo_tabmndOK = value;
					OnPropertyChanged("TIPO_TabMndOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabMnd.
		/// </summary>
		[DataMember]
		public String TIPO_TabMndMSGERROR
		{
			get { return m_tipo_tabmndMSGERROR; }
			set
			{
				if (m_tipo_tabmndMSGERROR != value)
				{
					m_tipo_tabmndMSGERROR = value;
					OnPropertyChanged("TIPO_TabMndMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodMnd.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodMndOK
		{
			get { return m_tipo_codmndOK; }
			set
			{
				if (m_tipo_codmndOK != value)
				{
					m_tipo_codmndOK = value;
					OnPropertyChanged("TIPO_CodMndOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodMnd.
		/// </summary>
		[DataMember]
		public String TIPO_CodMndMSGERROR
		{
			get { return m_tipo_codmndMSGERROR; }
			set
			{
				if (m_tipo_codmndMSGERROR != value)
				{
					m_tipo_codmndMSGERROR = value;
					OnPropertyChanged("TIPO_CodMndMSGERROR");
				}
			}
		}
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
		/// Gets or sets el valor de validación de: CTAR_AgMaritimo.
		/// </summary>
		[DataMember]
		public Boolean CTAR_AgMaritimoOK
		{
			get { return m_ctar_agmaritimoOK; }
			set
			{
				if (m_ctar_agmaritimoOK != value)
				{
					m_ctar_agmaritimoOK = value;
					OnPropertyChanged("CTAR_AgMaritimoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_AgMaritimo.
		/// </summary>
		[DataMember]
		public String CTAR_AgMaritimoMSGERROR
		{
			get { return m_ctar_agmaritimoMSGERROR; }
			set
			{
				if (m_ctar_agmaritimoMSGERROR != value)
				{
					m_ctar_agmaritimoMSGERROR = value;
					OnPropertyChanged("CTAR_AgMaritimoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CTAR_DepTemporal.
		/// </summary>
		[DataMember]
		public Boolean CTAR_DepTemporalOK
		{
			get { return m_ctar_deptemporalOK; }
			set
			{
				if (m_ctar_deptemporalOK != value)
				{
					m_ctar_deptemporalOK = value;
					OnPropertyChanged("CTAR_DepTemporalOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_DepTemporal.
		/// </summary>
		[DataMember]
		public String CTAR_DepTemporalMSGERROR
		{
			get { return m_ctar_deptemporalMSGERROR; }
			set
			{
				if (m_ctar_deptemporalMSGERROR != value)
				{
					m_ctar_deptemporalMSGERROR = value;
					OnPropertyChanged("CTAR_DepTemporalMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CTAR_DepVacio.
		/// </summary>
		[DataMember]
		public Boolean CTAR_DepVacioOK
		{
			get { return m_ctar_depvacioOK; }
			set
			{
				if (m_ctar_depvacioOK != value)
				{
					m_ctar_depvacioOK = value;
					OnPropertyChanged("CTAR_DepVacioOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_DepVacio.
		/// </summary>
		[DataMember]
		public String CTAR_DepVacioMSGERROR
		{
			get { return m_ctar_depvacioMSGERROR; }
			set
			{
				if (m_ctar_depvacioMSGERROR != value)
				{
					m_ctar_depvacioMSGERROR = value;
					OnPropertyChanged("CTAR_DepVacioMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodReg.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodRegOK
		{
			get { return m_cons_codregOK; }
			set
			{
				if (m_cons_codregOK != value)
				{
					m_cons_codregOK = value;
					OnPropertyChanged("CONS_CodRegOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodReg.
		/// </summary>
		[DataMember]
		public String CONS_CodRegMSGERROR
		{
			get { return m_cons_codregMSGERROR; }
			set
			{
				if (m_cons_codregMSGERROR != value)
				{
					m_cons_codregMSGERROR = value;
					OnPropertyChanged("CONS_CodRegMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabReg.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabRegOK
		{
			get { return m_cons_tabregOK; }
			set
			{
				if (m_cons_tabregOK != value)
				{
					m_cons_tabregOK = value;
					OnPropertyChanged("CONS_TabRegOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabReg.
		/// </summary>
		[DataMember]
		public String CONS_TabRegMSGERROR
		{
			get { return m_cons_tabregMSGERROR; }
			set
			{
				if (m_cons_tabregMSGERROR != value)
				{
					m_cons_tabregMSGERROR = value;
					OnPropertyChanged("CONS_TabRegMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CTAR_Profit.
		/// </summary>
		[DataMember]
		public Boolean CTAR_ProfitOK
		{
			get { return m_ctar_profitOK; }
			set
			{
				if (m_ctar_profitOK != value)
				{
					m_ctar_profitOK = value;
					OnPropertyChanged("CTAR_ProfitOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_Profit.
		/// </summary>
		[DataMember]
		public String CTAR_ProfitMSGERROR
		{
			get { return m_ctar_profitMSGERROR; }
			set
			{
				if (m_ctar_profitMSGERROR != value)
				{
					m_ctar_profitMSGERROR = value;
					OnPropertyChanged("CTAR_ProfitMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CTAR_MontoLNaviera.
		/// </summary>
		[DataMember]
		public Boolean CTAR_MontoLNavieraOK
		{
			get { return m_ctar_montolnavieraOK; }
			set
			{
				if (m_ctar_montolnavieraOK != value)
				{
					m_ctar_montolnavieraOK = value;
					OnPropertyChanged("CTAR_MontoLNavieraOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_MontoLNaviera.
		/// </summary>
		[DataMember]
		public String CTAR_MontoLNavieraMSGERROR
		{
			get { return m_ctar_montolnavieraMSGERROR; }
			set
			{
				if (m_ctar_montolnavieraMSGERROR != value)
				{
					m_ctar_montolnavieraMSGERROR = value;
					OnPropertyChanged("CTAR_MontoLNavieraMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CTAR_MontoDTemporal.
		/// </summary>
		[DataMember]
		public Boolean CTAR_MontoDTemporalOK
		{
			get { return m_ctar_montodtemporalOK; }
			set
			{
				if (m_ctar_montodtemporalOK != value)
				{
					m_ctar_montodtemporalOK = value;
					OnPropertyChanged("CTAR_MontoDTemporalOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CTAR_MontoDTemporal.
		/// </summary>
		[DataMember]
		public String CTAR_MontoDTemporalMSGERROR
		{
			get { return m_ctar_montodtemporalMSGERROR; }
			set
			{
				if (m_ctar_montodtemporalMSGERROR != value)
				{
					m_ctar_montodtemporalMSGERROR = value;
					OnPropertyChanged("CTAR_MontoDTemporalMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPE_Codigo.
		/// </summary>
		[DataMember]
		public Boolean TIPE_CodigoOK
		{
			get { return m_tipe_codigoOK; }
			set
			{
				if (m_tipe_codigoOK != value)
				{
					m_tipe_codigoOK = value;
					OnPropertyChanged("TIPE_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPE_Codigo.
		/// </summary>
		[DataMember]
		public String TIPE_CodigoMSGERROR
		{
			get { return m_tipe_codigoMSGERROR; }
			set
			{
				if (m_tipe_codigoMSGERROR != value)
				{
					m_tipe_codigoMSGERROR = value;
					OnPropertyChanged("TIPE_CodigoMSGERROR");
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
				CTAR_CodigoOK  = true;
				CTAR_CodigoMSGERROR  = "";
                //if( CTAR_Codigo == null)
                //{
                //    _isCorrect = false;
                //    CTAR_CodigoOK  = false;
                //    CTAR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CTAR_Codigo", "Cab_Tarifa");
                //    m_mensajeError += "* Debe ingresar el campo CTAR_Codigo" + Environment.NewLine;
                //}
				CTAR_NumeroOK  = true;
				CTAR_NumeroMSGERROR  = "";
                //if( String.IsNullOrEmpty(CTAR_Numero) )
                //{
                //    _isCorrect = false;
                //    CTAR_NumeroOK  = false;
                //    CTAR_NumeroMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CTAR_Numero", "Cab_Tarifa");
                //    m_mensajeError += "* Debe ingresar el campo CTAR_Numero" + Environment.NewLine;
                //}
                CTAR_ProfitMSGERROR = "";
                if (CTAR_Profit ==null && CTAR_Tipo != "L")
                {
                    _isCorrect = false;
                    CTAR_ProfitMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Profit", "Tarifa");
                    m_mensajeError += "* Debe ingresar el campo Profit" + Environment.NewLine;
                }
				CTAR_DescripOK  = true;
				CTAR_DescripMSGERROR  = "";
				if( String.IsNullOrEmpty(CTAR_Descrip) )
				{
					_isCorrect = false;
					CTAR_DescripOK  = false;
					CTAR_DescripMSGERROR  = String.Format("Debe ingresar la {0} de la {1}.", "Descripción", "Tarifa");
                    m_mensajeError += "* Debe ingresar una descripción" + Environment.NewLine;
				}
				CTAR_FecEmiOK  = true;
				CTAR_FecEmiMSGERROR  = "";
				if( CTAR_FecEmi == null)
				{
					_isCorrect = false;
					CTAR_FecEmiOK  = false;
					CTAR_FecEmiMSGERROR  = String.Format("Debe seleccionar la {0} de la {1}.", "Fecha de Emisión", "Tarifa");
                    m_mensajeError += "* Debe seleccionar la fecha de emisión" + Environment.NewLine;
                }
                else
                {
                    if (CTAR_FecIni < CTAR_FecEmi)
                    {
                        _isCorrect = false;
                        CTAR_FecEmiMSGERROR = String.Format("La fecha de inicio de vigencia no puede ser menor a la fecha de emisión.");
                        m_mensajeError += "* La fecha de inicio de vigencia no puede ser menor a la fecha de emisión." + Environment.NewLine;
                    }
                }

				CTAR_FecIniOK  = true;
				CTAR_FecIniMSGERROR  = "";
				if( CTAR_FecIni == null)
				{
					_isCorrect = false;
					CTAR_FecIniOK  = false;
                    CTAR_FecIniMSGERROR = String.Format("Debe seleccionar la {0} de la {1}.", "Fecha de Inicio", "Tarifa");
                    m_mensajeError += "* Debe seleccionar la fecha de inicio" + Environment.NewLine;
				}
				CTAR_FecFinOK  = true;
				CTAR_FecFinMSGERROR  = "";
				if( CTAR_FecFin == null)
				{
					_isCorrect = false;
					CTAR_FecFinOK  = false;
                    CTAR_FecFinMSGERROR = String.Format("Debe seleccionar la {0} de la {1}.", "Fecha de Fin", "Tarifa");
                    m_mensajeError += "* Debe seleccionar la fecha fin" + Environment.NewLine;
				}
                if (CTAR_FecFin < CTAR_FecIni  )
                {
                    _isCorrect = false;
                    CTAR_FecFinMSGERROR = String.Format("La fecha de fin de vigencia no puede ser menor al inicial.");
                    m_mensajeError += "* La fecha de fin de vigencia no puede ser menor al inicial." + Environment.NewLine;
                }
				CTAR_TipoOK  = true;
				CTAR_TipoMSGERROR  = "";
				if( String.IsNullOrEmpty(CTAR_Tipo) )
				{
					_isCorrect = false;
					CTAR_TipoOK  = false;
					CTAR_TipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de Tarifario", "Tarifa");
                    m_mensajeError += "* Debe ingresar el campo Tipo de Tarifario" + Environment.NewLine;
				}
				CTAR_MontoLNavieraOK  = true;
				CTAR_MontoLNavieraMSGERROR  = "";
				if( CTAR_MontoLNaviera == null)
				{
					_isCorrect = false;
					CTAR_MontoLNavieraOK  = false;
					CTAR_MontoLNavieraMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Monto de la Linea Naviera", "Tarifa");
                    m_mensajeError += "* Debe ingresar el campo Monto de la Linea Naviera" + Environment.NewLine;
				}
				CTAR_MontoDTemporalOK  = true;
				CTAR_MontoDTemporalMSGERROR  = "";
				if( CTAR_MontoDTemporal == null)
				{
					_isCorrect = false;
					CTAR_MontoDTemporalOK  = false;
					CTAR_MontoDTemporalMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Monto del Depósito Temporal", "Tarifa");
                    m_mensajeError += "* Debe ingresar el campo Monto del Depósito Temporal" + Environment.NewLine;
				}
                TIPO_CodMndMSGERROR = "";
                if (string.IsNullOrEmpty(TIPO_CodMnd))
                {
                    _isCorrect = false;
                    TIPO_CodMndMSGERROR = String.Format("Debe seleccionar un {0} para la {1}.", "Tipo de Moneda", "Tarifa");
                    m_mensajeError += "* Debe seleccionar un Tipo de Moneda" + Environment.NewLine;
                }
                CONS_CodRegMSGERROR = "";
                if (CTAR_Tipo.Equals("L"))
                {
                    if (string.IsNullOrEmpty(CONS_CodReg))
                    {
                        _isCorrect = false;
                        CONS_CodRegMSGERROR = String.Format("Debe seleccionar un {0} para la {1}.", "Tipo de Regimen", "Tarifa");
                        m_mensajeError += "* Debe seleccionar un Tipo de Regimen" + Environment.NewLine;
                    } 
                }
                ENTC_CodigoMSGERROR = "";
                if (ENTC_Codigo== null)
                {
                    _isCorrect = false;
                    ENTC_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de Entidad", "Tarifa");
                    m_mensajeError += "* Debe ingresar el campo Tipo de Entidad" + Environment.NewLine;
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
