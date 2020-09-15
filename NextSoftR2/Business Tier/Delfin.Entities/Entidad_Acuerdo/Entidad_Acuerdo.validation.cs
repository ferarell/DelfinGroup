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
	public partial class Entidad_Acuerdo
	{
		#region [ Variables Validación ]
		private Boolean m_acue_codigoOK;
		private String m_acue_codigoMSGERROR;
		private Boolean m_tipe_codigoOK;
		private String m_tipe_codigoMSGERROR;
		private Boolean m_entc_codigoOK;
		private String m_entc_codigoMSGERROR;
		private Boolean m_acue_fecemiOK;
		private String m_acue_fecemiMSGERROR;
		private Boolean m_acue_feciniOK;
		private String m_acue_feciniMSGERROR;
		private Boolean m_acue_activoOK;
		private String m_acue_activoMSGERROR;
		private Boolean m_acue_valorOK;
		private String m_acue_valorMSGERROR;
		private Boolean m_cons_tabacuOK;
		private String m_cons_tabacuMSGERROR;
		private Boolean m_cons_codacuOK;
		private String m_cons_codacuMSGERROR;
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
		/// Gets or sets el valor de validación de: ACUE_Codigo.
		/// </summary>
		[DataMember]
		public Boolean ACUE_CodigoOK
		{
			get { return m_acue_codigoOK; }
			set
			{
				if (m_acue_codigoOK != value)
				{
					m_acue_codigoOK = value;
					OnPropertyChanged("ACUE_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ACUE_Codigo.
		/// </summary>
		[DataMember]
		public String ACUE_CodigoMSGERROR
		{
			get { return m_acue_codigoMSGERROR; }
			set
			{
				if (m_acue_codigoMSGERROR != value)
				{
					m_acue_codigoMSGERROR = value;
					OnPropertyChanged("ACUE_CodigoMSGERROR");
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
		/// Gets or sets el valor de validación de: ACUE_FecEmi.
		/// </summary>
		[DataMember]
		public Boolean ACUE_FecEmiOK
		{
			get { return m_acue_fecemiOK; }
			set
			{
				if (m_acue_fecemiOK != value)
				{
					m_acue_fecemiOK = value;
					OnPropertyChanged("ACUE_FecEmiOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ACUE_FecEmi.
		/// </summary>
		[DataMember]
		public String ACUE_FecEmiMSGERROR
		{
			get { return m_acue_fecemiMSGERROR; }
			set
			{
				if (m_acue_fecemiMSGERROR != value)
				{
					m_acue_fecemiMSGERROR = value;
					OnPropertyChanged("ACUE_FecEmiMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ACUE_FecIni.
		/// </summary>
		[DataMember]
		public Boolean ACUE_FecIniOK
		{
			get { return m_acue_feciniOK; }
			set
			{
				if (m_acue_feciniOK != value)
				{
					m_acue_feciniOK = value;
					OnPropertyChanged("ACUE_FecIniOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ACUE_FecIni.
		/// </summary>
		[DataMember]
		public String ACUE_FecIniMSGERROR
		{
			get { return m_acue_feciniMSGERROR; }
			set
			{
				if (m_acue_feciniMSGERROR != value)
				{
					m_acue_feciniMSGERROR = value;
					OnPropertyChanged("ACUE_FecIniMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ACUE_Activo.
		/// </summary>
		[DataMember]
		public Boolean ACUE_ActivoOK
		{
			get { return m_acue_activoOK; }
			set
			{
				if (m_acue_activoOK != value)
				{
					m_acue_activoOK = value;
					OnPropertyChanged("ACUE_ActivoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ACUE_Activo.
		/// </summary>
		[DataMember]
		public String ACUE_ActivoMSGERROR
		{
			get { return m_acue_activoMSGERROR; }
			set
			{
				if (m_acue_activoMSGERROR != value)
				{
					m_acue_activoMSGERROR = value;
					OnPropertyChanged("ACUE_ActivoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ACUE_Valor.
		/// </summary>
		[DataMember]
		public Boolean ACUE_ValorOK
		{
			get { return m_acue_valorOK; }
			set
			{
				if (m_acue_valorOK != value)
				{
					m_acue_valorOK = value;
					OnPropertyChanged("ACUE_ValorOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ACUE_Valor.
		/// </summary>
		[DataMember]
		public String ACUE_ValorMSGERROR
		{
			get { return m_acue_valorMSGERROR; }
			set
			{
				if (m_acue_valorMSGERROR != value)
				{
					m_acue_valorMSGERROR = value;
					OnPropertyChanged("ACUE_ValorMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabACU.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabACUOK
		{
			get { return m_cons_tabacuOK; }
			set
			{
				if (m_cons_tabacuOK != value)
				{
					m_cons_tabacuOK = value;
					OnPropertyChanged("CONS_TabACUOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabACU.
		/// </summary>
		[DataMember]
		public String CONS_TabACUMSGERROR
		{
			get { return m_cons_tabacuMSGERROR; }
			set
			{
				if (m_cons_tabacuMSGERROR != value)
				{
					m_cons_tabacuMSGERROR = value;
					OnPropertyChanged("CONS_TabACUMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodACU.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodACUOK
		{
			get { return m_cons_codacuOK; }
			set
			{
				if (m_cons_codacuOK != value)
				{
					m_cons_codacuOK = value;
					OnPropertyChanged("CONS_CodACUOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodACU.
		/// </summary>
		[DataMember]
		public String CONS_CodACUMSGERROR
		{
			get { return m_cons_codacuMSGERROR; }
			set
			{
				if (m_cons_codacuMSGERROR != value)
				{
					m_cons_codacuMSGERROR = value;
					OnPropertyChanged("CONS_CodACUMSGERROR");
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
				ACUE_CodigoOK  = true;
				ACUE_CodigoMSGERROR  = "";
				if( ACUE_Codigo == null)
				{
					_isCorrect = false;
					ACUE_CodigoOK  = false;
					ACUE_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ACUE_Codigo", "Entidad_Acuerdo");
					m_mensajeError += "* Debe ingresar el campo ACUE_Codigo" + Environment.NewLine;
				}
				ENTC_CodigoOK  = true;
				ENTC_CodigoMSGERROR  = "";
				if( ENTC_Codigo == null)
				{
					_isCorrect = false;
					ENTC_CodigoOK  = false;
					ENTC_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ENTC_Codigo", "Entidad_Acuerdo");
					m_mensajeError += "* Debe ingresar el campo ENTC_Codigo" + Environment.NewLine;
				}
				ACUE_ActivoOK  = true;
				ACUE_ActivoMSGERROR  = "";
				if( ACUE_Activo == null)
				{
					_isCorrect = false;
					ACUE_ActivoOK  = false;
					ACUE_ActivoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ACUE_Activo", "Entidad_Acuerdo");
					m_mensajeError += "* Debe ingresar el campo ACUE_Activo" + Environment.NewLine;
				}
				ACUE_ValorOK  = true;
				ACUE_ValorMSGERROR  = "";
				if( ACUE_Valor == null)
				{
					_isCorrect = false;
					ACUE_ValorOK  = false;
					ACUE_ValorMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ACUE_Valor", "Entidad_Acuerdo");
					m_mensajeError += "* Debe ingresar el campo ACUE_Valor" + Environment.NewLine;
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
