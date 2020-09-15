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
	public partial class Cab_Cotizacion
	{
		#region [ Variables Validación ]
		private Boolean m_ccot_codigoOK;
		private String m_ccot_codigoMSGERROR;
		private Boolean m_ccot_numdocOK;
		private String m_ccot_numdocMSGERROR;
		private Boolean m_ccot_fecemiOK;
		private String m_ccot_fecemiMSGERROR;
		private Boolean m_ccot_fecvctoOK;
		private String m_ccot_fecvctoMSGERROR;
		private Boolean m_ccot_observacionesOK;
		private String m_ccot_observacionesMSGERROR;
		private Boolean m_ccot_horalibreOK;
		private String m_ccot_horalibreMSGERROR;
		private Boolean m_entc_codigoOK;
		private String m_entc_codigoMSGERROR;
		private Boolean m_cons_codestadoOK;
		private String m_cons_codestadoMSGERROR;
		private Boolean m_cons_tabestadoOK;
		private String m_cons_tabestadoMSGERROR;
		private Boolean m_cons_codregOK;
		private String m_cons_codregMSGERROR;
		private Boolean m_cons_tabregOK;
		private String m_cons_tabregMSGERROR;
		private Boolean m_tipo_tabmndOK;
		private String m_tipo_tabmndMSGERROR;
		private Boolean m_tipo_codmndOK;
		private String m_tipo_codmndMSGERROR;
		private Boolean m_entc_codaduanaOK;
		private String m_entc_codaduanaMSGERROR;
		private Boolean m_entc_codlogisticoOK;
		private String m_entc_codlogisticoMSGERROR;
		private Boolean m_entc_codtransporteOK;
		private String m_entc_codtransporteMSGERROR;
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
		/// Gets or sets el valor de validación de: CCOT_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CCOT_CodigoOK
		{
			get { return m_ccot_codigoOK; }
			set
			{
				if (m_ccot_codigoOK != value)
				{
					m_ccot_codigoOK = value;
					OnPropertyChanged("CCOT_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Codigo.
		/// </summary>
		[DataMember]
		public String CCOT_CodigoMSGERROR
		{
			get { return m_ccot_codigoMSGERROR; }
			set
			{
				if (m_ccot_codigoMSGERROR != value)
				{
					m_ccot_codigoMSGERROR = value;
					OnPropertyChanged("CCOT_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_NumDoc.
		/// </summary>
		[DataMember]
		public Boolean CCOT_NumDocOK
		{
			get { return m_ccot_numdocOK; }
			set
			{
				if (m_ccot_numdocOK != value)
				{
					m_ccot_numdocOK = value;
					OnPropertyChanged("CCOT_NumDocOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_NumDoc.
		/// </summary>
		[DataMember]
		public String CCOT_NumDocMSGERROR
		{
			get { return m_ccot_numdocMSGERROR; }
			set
			{
				if (m_ccot_numdocMSGERROR != value)
				{
					m_ccot_numdocMSGERROR = value;
					OnPropertyChanged("CCOT_NumDocMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_FecEmi.
		/// </summary>
		[DataMember]
		public Boolean CCOT_FecEmiOK
		{
			get { return m_ccot_fecemiOK; }
			set
			{
				if (m_ccot_fecemiOK != value)
				{
					m_ccot_fecemiOK = value;
					OnPropertyChanged("CCOT_FecEmiOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_FecEmi.
		/// </summary>
		[DataMember]
		public String CCOT_FecEmiMSGERROR
		{
			get { return m_ccot_fecemiMSGERROR; }
			set
			{
				if (m_ccot_fecemiMSGERROR != value)
				{
					m_ccot_fecemiMSGERROR = value;
					OnPropertyChanged("CCOT_FecEmiMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_FecVcto.
		/// </summary>
		[DataMember]
		public Boolean CCOT_FecVctoOK
		{
			get { return m_ccot_fecvctoOK; }
			set
			{
				if (m_ccot_fecvctoOK != value)
				{
					m_ccot_fecvctoOK = value;
					OnPropertyChanged("CCOT_FecVctoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_FecVcto.
		/// </summary>
		[DataMember]
		public String CCOT_FecVctoMSGERROR
		{
			get { return m_ccot_fecvctoMSGERROR; }
			set
			{
				if (m_ccot_fecvctoMSGERROR != value)
				{
					m_ccot_fecvctoMSGERROR = value;
					OnPropertyChanged("CCOT_FecVctoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Observaciones.
		/// </summary>
		[DataMember]
		public Boolean CCOT_ObservacionesOK
		{
			get { return m_ccot_observacionesOK; }
			set
			{
				if (m_ccot_observacionesOK != value)
				{
					m_ccot_observacionesOK = value;
					OnPropertyChanged("CCOT_ObservacionesOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Observaciones.
		/// </summary>
		[DataMember]
		public String CCOT_ObservacionesMSGERROR
		{
			get { return m_ccot_observacionesMSGERROR; }
			set
			{
				if (m_ccot_observacionesMSGERROR != value)
				{
					m_ccot_observacionesMSGERROR = value;
					OnPropertyChanged("CCOT_ObservacionesMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_HoraLibre.
		/// </summary>
		[DataMember]
		public Boolean CCOT_HoraLibreOK
		{
			get { return m_ccot_horalibreOK; }
			set
			{
				if (m_ccot_horalibreOK != value)
				{
					m_ccot_horalibreOK = value;
					OnPropertyChanged("CCOT_HoraLibreOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_HoraLibre.
		/// </summary>
		[DataMember]
		public String CCOT_HoraLibreMSGERROR
		{
			get { return m_ccot_horalibreMSGERROR; }
			set
			{
				if (m_ccot_horalibreMSGERROR != value)
				{
					m_ccot_horalibreMSGERROR = value;
					OnPropertyChanged("CCOT_HoraLibreMSGERROR");
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
		/// Gets or sets el valor de validación de: CONS_CodEstado.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodEstadoOK
		{
			get { return m_cons_codestadoOK; }
			set
			{
				if (m_cons_codestadoOK != value)
				{
					m_cons_codestadoOK = value;
					OnPropertyChanged("CONS_CodEstadoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodEstado.
		/// </summary>
		[DataMember]
		public String CONS_CodEstadoMSGERROR
		{
			get { return m_cons_codestadoMSGERROR; }
			set
			{
				if (m_cons_codestadoMSGERROR != value)
				{
					m_cons_codestadoMSGERROR = value;
					OnPropertyChanged("CONS_CodEstadoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabEstado.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabEstadoOK
		{
			get { return m_cons_tabestadoOK; }
			set
			{
				if (m_cons_tabestadoOK != value)
				{
					m_cons_tabestadoOK = value;
					OnPropertyChanged("CONS_TabEstadoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabEstado.
		/// </summary>
		[DataMember]
		public String CONS_TabEstadoMSGERROR
		{
			get { return m_cons_tabestadoMSGERROR; }
			set
			{
				if (m_cons_tabestadoMSGERROR != value)
				{
					m_cons_tabestadoMSGERROR = value;
					OnPropertyChanged("CONS_TabEstadoMSGERROR");
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
		/// Gets or sets el valor de validación de: ENTC_CodAduana.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodAduanaOK
		{
			get { return m_entc_codaduanaOK; }
			set
			{
				if (m_entc_codaduanaOK != value)
				{
					m_entc_codaduanaOK = value;
					OnPropertyChanged("ENTC_CodAduanaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodAduana.
		/// </summary>
		[DataMember]
		public String ENTC_CodAduanaMSGERROR
		{
			get { return m_entc_codaduanaMSGERROR; }
			set
			{
				if (m_entc_codaduanaMSGERROR != value)
				{
					m_entc_codaduanaMSGERROR = value;
					OnPropertyChanged("ENTC_CodAduanaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodLogistico.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodLogisticoOK
		{
			get { return m_entc_codlogisticoOK; }
			set
			{
				if (m_entc_codlogisticoOK != value)
				{
					m_entc_codlogisticoOK = value;
					OnPropertyChanged("ENTC_CodLogisticoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodLogistico.
		/// </summary>
		[DataMember]
		public String ENTC_CodLogisticoMSGERROR
		{
			get { return m_entc_codlogisticoMSGERROR; }
			set
			{
				if (m_entc_codlogisticoMSGERROR != value)
				{
					m_entc_codlogisticoMSGERROR = value;
					OnPropertyChanged("ENTC_CodLogisticoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodTransporte.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodTransporteOK
		{
			get { return m_entc_codtransporteOK; }
			set
			{
				if (m_entc_codtransporteOK != value)
				{
					m_entc_codtransporteOK = value;
					OnPropertyChanged("ENTC_CodTransporteOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodTransporte.
		/// </summary>
		[DataMember]
		public String ENTC_CodTransporteMSGERROR
		{
			get { return m_entc_codtransporteMSGERROR; }
			set
			{
				if (m_entc_codtransporteMSGERROR != value)
				{
					m_entc_codtransporteMSGERROR = value;
					OnPropertyChanged("ENTC_CodTransporteMSGERROR");
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
				CCOT_CodigoOK  = true;
				CCOT_CodigoMSGERROR  = "";
                //if( CCOT_Codigo == null)
                //{
                //    _isCorrect = false;
                //    CCOT_CodigoOK  = false;
                //    CCOT_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Codigo", "Cab_Cotizacion");
                //    m_mensajeError += "* Debe ingresar el campo CCOT_Codigo" + Environment.NewLine;
                //}
				CCOT_NumDocOK  = true;
				CCOT_NumDocMSGERROR  = "";
                //if( String.IsNullOrEmpty(CCOT_NumDoc) )
                //{
                //    _isCorrect = false;
                //    CCOT_NumDocOK  = false;
                //    CCOT_NumDocMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_NumDoc", "Cab_Cotizacion");
                //    m_mensajeError += "* Debe ingresar el campo CCOT_NumDoc" + Environment.NewLine;
                //}
				CCOT_ObservacionesOK  = true;
				CCOT_ObservacionesMSGERROR  = "";
                //if( String.IsNullOrEmpty(CCOT_Observaciones) )
                //{
                //    _isCorrect = false;
                //    CCOT_ObservacionesOK  = false;
                //    CCOT_ObservacionesMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Observaciones", "Cab_Cotizacion");
                //    m_mensajeError += "* Debe ingresar el campo CCOT_Observaciones" + Environment.NewLine;
                //}
				CCOT_HoraLibreOK  = true;
				CCOT_HoraLibreMSGERROR  = "";
				if( CCOT_HoraLibre == null)
				{
					_isCorrect = false;
					CCOT_HoraLibreOK  = false;
					CCOT_HoraLibreMSGERROR  = String.Format("Debe ingresar la {0} de la {1}.", "Hora Libre", "Cotización");
					m_mensajeError += "* Debe ingresar el campo Hora Libre" + Environment.NewLine;
				}
                CCOT_FecEmiMSGERROR = "";
                if (CCOT_FecEmi == null)
                {
                    _isCorrect = false;
                    CCOT_FecEmiMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Fecha de Emisión", "Cotización");
                    m_mensajeError += "* Debe ingresar el campo Fecha Emisión." + Environment.NewLine;
                }
                else
                {
                    if (CCOT_FecEmi > CCOT_FecVcto)
                    {
                        _isCorrect = false;
                        CCOT_FecEmiMSGERROR = String.Format("La fecha de emisión no puede ser mayor a la fecha de vencimiento.");
                        m_mensajeError += "* La fecha de emisión no puede ser mayor a la fecha de vencimiento." + Environment.NewLine;
                    }
                }
                CCOT_FecVctoMSGERROR = "";
                if (CCOT_FecVcto == null)
                {
                    _isCorrect = false;
                    CCOT_FecVctoMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Fecha de Vencimiento", "Cotización");
                    m_mensajeError += "* Debe ingresar el campo Fecha de Vencimiento." + Environment.NewLine;
                }
                else
                {
                    if (CCOT_FecVcto < CCOT_FecEmi)
                    {
                        _isCorrect = false;
                        CCOT_FecEmiMSGERROR = String.Format("La fecha de vencimiento no puede ser menor a la fecha de emisión.");
                        m_mensajeError += "* La fecha de vencimiento no puede ser menor a la fecha de emisión." + Environment.NewLine;
                    }
                }
                ENTC_CodigoMSGERROR = "";
                if (ENTC_Codigo == null)
                {
                    _isCorrect = false;
                    ENTC_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Cliente", "Cotización");
                    m_mensajeError += "* Debe ingresar el campo Cliente." + Environment.NewLine;
                }

                CONS_CodEstadoMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_CodEstado))
                {
                    _isCorrect = false;
                    CONS_CodEstadoMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "Estado", "Cotización");
                    m_mensajeError += "* Debe selecionar el campo Estado." + Environment.NewLine;
                }

                CONS_CodRegMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_CodReg))
                {
                    _isCorrect = false;
                    CONS_CodRegMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "Régimen", "Cotización");
                    m_mensajeError += "* Debe selecionar el campo Régimen." + Environment.NewLine;
                }

				TIPO_TabMNDOK  = true;
				TIPO_TabMNDMSGERROR  = "";
                //if( String.IsNullOrEmpty(TIPO_TabMND) )
                //{
                //    _isCorrect = false;
                //    TIPO_TabMNDOK  = false;
                //    TIPO_TabMNDMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_TabMND", "Cab_Cotizacion");
                //    m_mensajeError += "* Debe ingresar el campo TIPO_TabMND" + Environment.NewLine;
                //}
				TIPO_CodMNDOK  = true;
				TIPO_CodMNDMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodMND) )
				{
					_isCorrect = false;
					TIPO_CodMNDOK  = false;
					TIPO_CodMNDMSGERROR  = String.Format("Debe seleccionar el {0} de la {1}.", "Tipo de Moneda", "Cotización");
                    m_mensajeError += "* Debe seleccionar el campo tipo de moneda" + Environment.NewLine;
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
