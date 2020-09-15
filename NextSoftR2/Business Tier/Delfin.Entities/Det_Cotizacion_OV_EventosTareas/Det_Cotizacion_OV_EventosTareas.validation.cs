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
	public partial class Det_Cotizacion_OV_EventosTareas
	{
		#region [ Variables Validación ]
		private Boolean m_ccot_numeroOK;
		private String m_ccot_numeroMSGERROR;
		private Boolean m_ccot_tipoOK;
		private String m_ccot_tipoMSGERROR;
		private Boolean m_even_itemOK;
		private String m_even_itemMSGERROR;
		private Boolean m_even_fechaOK;
		private String m_even_fechaMSGERROR;
		private Boolean m_even_cumnplidaOK;
		private String m_even_cumnplidaMSGERROR;
		private Boolean m_even_usuarioOK;
		private String m_even_usuarioMSGERROR;
		private Boolean m_even_observacionesOK;
		private String m_even_observacionesMSGERROR;
		private Boolean m_tipo_tabeveOK;
		private String m_tipo_tabeveMSGERROR;
		private Boolean m_tipo_codeveOK;
		private String m_tipo_codeveMSGERROR;
		private Boolean m_cons_tabmodOK;
		private String m_cons_tabmodMSGERROR;
		private Boolean m_cons_codmodOK;
		private String m_cons_codmodMSGERROR;
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
		/// Gets or sets el valor de validación de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public Boolean CCOT_NumeroOK
		{
			get { return m_ccot_numeroOK; }
			set
			{
				if (m_ccot_numeroOK != value)
				{
					m_ccot_numeroOK = value;
					OnPropertyChanged("CCOT_NumeroOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public String CCOT_NumeroMSGERROR
		{
			get { return m_ccot_numeroMSGERROR; }
			set
			{
				if (m_ccot_numeroMSGERROR != value)
				{
					m_ccot_numeroMSGERROR = value;
					OnPropertyChanged("CCOT_NumeroMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public Boolean CCOT_TipoOK
		{
			get { return m_ccot_tipoOK; }
			set
			{
				if (m_ccot_tipoOK != value)
				{
					m_ccot_tipoOK = value;
					OnPropertyChanged("CCOT_TipoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public String CCOT_TipoMSGERROR
		{
			get { return m_ccot_tipoMSGERROR; }
			set
			{
				if (m_ccot_tipoMSGERROR != value)
				{
					m_ccot_tipoMSGERROR = value;
					OnPropertyChanged("CCOT_TipoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EVEN_Item.
		/// </summary>
		[DataMember]
		public Boolean EVEN_ItemOK
		{
			get { return m_even_itemOK; }
			set
			{
				if (m_even_itemOK != value)
				{
					m_even_itemOK = value;
					OnPropertyChanged("EVEN_ItemOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EVEN_Item.
		/// </summary>
		[DataMember]
		public String EVEN_ItemMSGERROR
		{
			get { return m_even_itemMSGERROR; }
			set
			{
				if (m_even_itemMSGERROR != value)
				{
					m_even_itemMSGERROR = value;
					OnPropertyChanged("EVEN_ItemMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EVEN_Fecha.
		/// </summary>
		[DataMember]
		public Boolean EVEN_FechaOK
		{
			get { return m_even_fechaOK; }
			set
			{
				if (m_even_fechaOK != value)
				{
					m_even_fechaOK = value;
					OnPropertyChanged("EVEN_FechaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EVEN_Fecha.
		/// </summary>
		[DataMember]
		public String EVEN_FechaMSGERROR
		{
			get { return m_even_fechaMSGERROR; }
			set
			{
				if (m_even_fechaMSGERROR != value)
				{
					m_even_fechaMSGERROR = value;
					OnPropertyChanged("EVEN_FechaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EVEN_Cumplida.
		/// </summary>
		[DataMember]
		public Boolean EVEN_CumplidaOK
		{
			get { return m_even_cumnplidaOK; }
			set
			{
				if (m_even_cumnplidaOK != value)
				{
					m_even_cumnplidaOK = value;
					OnPropertyChanged("EVEN_CumplidaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EVEN_Cumplida.
		/// </summary>
		[DataMember]
		public String EVEN_CumplidaMSGERROR
		{
			get { return m_even_cumnplidaMSGERROR; }
			set
			{
				if (m_even_cumnplidaMSGERROR != value)
				{
					m_even_cumnplidaMSGERROR = value;
					OnPropertyChanged("EVEN_CumplidaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EVEN_Usuario.
		/// </summary>
		[DataMember]
		public Boolean EVEN_UsuarioOK
		{
			get { return m_even_usuarioOK; }
			set
			{
				if (m_even_usuarioOK != value)
				{
					m_even_usuarioOK = value;
					OnPropertyChanged("EVEN_UsuarioOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EVEN_Usuario.
		/// </summary>
		[DataMember]
		public String EVEN_UsuarioMSGERROR
		{
			get { return m_even_usuarioMSGERROR; }
			set
			{
				if (m_even_usuarioMSGERROR != value)
				{
					m_even_usuarioMSGERROR = value;
					OnPropertyChanged("EVEN_UsuarioMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EVEN_Observaciones.
		/// </summary>
		[DataMember]
		public Boolean EVEN_ObservacionesOK
		{
			get { return m_even_observacionesOK; }
			set
			{
				if (m_even_observacionesOK != value)
				{
					m_even_observacionesOK = value;
					OnPropertyChanged("EVEN_ObservacionesOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EVEN_Observaciones.
		/// </summary>
		[DataMember]
		public String EVEN_ObservacionesMSGERROR
		{
			get { return m_even_observacionesMSGERROR; }
			set
			{
				if (m_even_observacionesMSGERROR != value)
				{
					m_even_observacionesMSGERROR = value;
					OnPropertyChanged("EVEN_ObservacionesMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabEVE.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabEVEOK
		{
			get { return m_tipo_tabeveOK; }
			set
			{
				if (m_tipo_tabeveOK != value)
				{
					m_tipo_tabeveOK = value;
					OnPropertyChanged("TIPO_TabEVEOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabEVE.
		/// </summary>
		[DataMember]
		public String TIPO_TabEVEMSGERROR
		{
			get { return m_tipo_tabeveMSGERROR; }
			set
			{
				if (m_tipo_tabeveMSGERROR != value)
				{
					m_tipo_tabeveMSGERROR = value;
					OnPropertyChanged("TIPO_TabEVEMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodEVE.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodEVEOK
		{
			get { return m_tipo_codeveOK; }
			set
			{
				if (m_tipo_codeveOK != value)
				{
					m_tipo_codeveOK = value;
					OnPropertyChanged("TIPO_CodEVEOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodEVE.
		/// </summary>
		[DataMember]
		public String TIPO_CodEVEMSGERROR
		{
			get { return m_tipo_codeveMSGERROR; }
			set
			{
				if (m_tipo_codeveMSGERROR != value)
				{
					m_tipo_codeveMSGERROR = value;
					OnPropertyChanged("TIPO_CodEVEMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabMOD.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabMODOK
		{
			get { return m_cons_tabmodOK; }
			set
			{
				if (m_cons_tabmodOK != value)
				{
					m_cons_tabmodOK = value;
					OnPropertyChanged("CONS_TabMODOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabMOD.
		/// </summary>
		[DataMember]
		public String CONS_TabMODMSGERROR
		{
			get { return m_cons_tabmodMSGERROR; }
			set
			{
				if (m_cons_tabmodMSGERROR != value)
				{
					m_cons_tabmodMSGERROR = value;
					OnPropertyChanged("CONS_TabMODMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodMOD.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodMODOK
		{
			get { return m_cons_codmodOK; }
			set
			{
				if (m_cons_codmodOK != value)
				{
					m_cons_codmodOK = value;
					OnPropertyChanged("CONS_CodMODOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodMOD.
		/// </summary>
		[DataMember]
		public String CONS_CodMODMSGERROR
		{
			get { return m_cons_codmodMSGERROR; }
			set
			{
				if (m_cons_codmodMSGERROR != value)
				{
					m_cons_codmodMSGERROR = value;
					OnPropertyChanged("CONS_CodMODMSGERROR");
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
				CCOT_NumeroOK  = true;
				CCOT_NumeroMSGERROR  = "";
            //if( CCOT_Numero == null)
            //{
            //   _isCorrect = false;
            //   CCOT_NumeroOK  = false;
            //   CCOT_NumeroMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Numero", "DetEventosTareas");
            //   m_mensajeError += "* Debe ingresar el campo CCOT_Numero" + Environment.NewLine;
            //}
				CCOT_TipoOK  = true;
				CCOT_TipoMSGERROR  = "";
            //if( CCOT_Tipo == null)
            //{
            //   _isCorrect = false;
            //   CCOT_TipoOK  = false;
            //   CCOT_TipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Tipo", "DetEventosTareas");
            //   m_mensajeError += "* Debe ingresar el campo CCOT_Tipo" + Environment.NewLine;
            //}
				EVEN_ItemOK  = true;
				EVEN_ItemMSGERROR  = "";
            //if( EVEN_Item == null)
            //{
            //   _isCorrect = false;
            //   EVEN_ItemOK  = false;
            //   EVEN_ItemMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EVEN_Item", "DetEventosTareas");
            //   m_mensajeError += "* Debe ingresar el campo EVEN_Item" + Environment.NewLine;
            //}
				EVEN_FechaOK  = true;
				EVEN_FechaMSGERROR  = "";
				if( EVEN_Fecha == null)
				{
					_isCorrect = false;
					EVEN_FechaOK  = false;
					EVEN_FechaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EVEN_Fecha", "DetEventosTareas");
					m_mensajeError += "* Debe ingresar el campo EVEN_Fecha" + Environment.NewLine;
				}
				EVEN_CumplidaOK  = true;
				EVEN_CumplidaMSGERROR  = "";
				if( EVEN_Cumplida == null)
				{
					_isCorrect = false;
					EVEN_CumplidaOK  = false;
					EVEN_CumplidaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EVEN_Cumplida", "DetEventosTareas");
					m_mensajeError += "* Debe ingresar el campo EVEN_Cumplida" + Environment.NewLine;
				}
				EVEN_UsuarioOK  = true;
				EVEN_UsuarioMSGERROR  = "";
				if( String.IsNullOrEmpty(EVEN_Usuario) )
				{
					_isCorrect = false;
					EVEN_UsuarioOK  = false;
					EVEN_UsuarioMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EVEN_Usuario", "DetEventosTareas");
					m_mensajeError += "* Debe ingresar el campo EVEN_Usuario" + Environment.NewLine;
				}
				EVEN_ObservacionesOK  = true;
				EVEN_ObservacionesMSGERROR  = "";
				if( String.IsNullOrEmpty(EVEN_Observaciones) )
				{
					_isCorrect = false;
					EVEN_ObservacionesOK  = false;
					EVEN_ObservacionesMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EVEN_Observaciones", "DetEventosTareas");
					m_mensajeError += "* Debe ingresar el campo EVEN_Observaciones" + Environment.NewLine;
				}
				TIPO_TabEVEOK  = true;
				TIPO_TabEVEMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_TabEVE) )
				{
					_isCorrect = false;
					TIPO_TabEVEOK  = false;
					TIPO_TabEVEMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_TabEVE", "DetEventosTareas");
					m_mensajeError += "* Debe ingresar el campo TIPO_TabEVE" + Environment.NewLine;
				}
				TIPO_CodEVEOK  = true;
				TIPO_CodEVEMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodEVE) )
				{
					_isCorrect = false;
					TIPO_CodEVEOK  = false;
					TIPO_CodEVEMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_CodEVE", "DetEventosTareas");
					m_mensajeError += "* Debe ingresar el campo TIPO_CodEVE" + Environment.NewLine;
				}
				CONS_TabMODOK  = true;
				CONS_TabMODMSGERROR  = "";
				if( String.IsNullOrEmpty(CONS_TabMOD) )
				{
					_isCorrect = false;
					CONS_TabMODOK  = false;
					CONS_TabMODMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONS_TabMOD", "DetEventosTareas");
					m_mensajeError += "* Debe ingresar el campo CONS_TabMOD" + Environment.NewLine;
				}
				CONS_CodMODOK  = true;
				CONS_CodMODMSGERROR  = "";
				if( String.IsNullOrEmpty(CONS_CodMOD) )
				{
					_isCorrect = false;
					CONS_CodMODOK  = false;
					CONS_CodMODMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONS_CodMOD", "DetEventosTareas");
					m_mensajeError += "* Debe ingresar el campo CONS_CodMOD" + Environment.NewLine;
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
