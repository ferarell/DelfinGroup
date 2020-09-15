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
	public partial class DetRebate
	{
		#region [ Variables Validación ]
		private Boolean m_pack_codigoOK;
		private String m_pack_codigoMSGERROR;
		private Boolean m_reba_codigoOK;
		private String m_reba_codigoMSGERROR;
		private Boolean m_dreb_valorOK;
		private String m_dreb_valorMSGERROR;
		private Boolean m_dreb_codigoOK;
		private String m_dreb_codigoMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public Boolean PACK_CodigoOK
		{
			get { return m_pack_codigoOK; }
			set
			{
				if (m_pack_codigoOK != value)
				{
					m_pack_codigoOK = value;
					OnPropertyChanged("PACK_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public String PACK_CodigoMSGERROR
		{
			get { return m_pack_codigoMSGERROR; }
			set
			{
				if (m_pack_codigoMSGERROR != value)
				{
					m_pack_codigoMSGERROR = value;
					OnPropertyChanged("PACK_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: REBA_Codigo.
		/// </summary>
		[DataMember]
		public Boolean REBA_CodigoOK
		{
			get { return m_reba_codigoOK; }
			set
			{
				if (m_reba_codigoOK != value)
				{
					m_reba_codigoOK = value;
					OnPropertyChanged("REBA_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: REBA_Codigo.
		/// </summary>
		[DataMember]
		public String REBA_CodigoMSGERROR
		{
			get { return m_reba_codigoMSGERROR; }
			set
			{
				if (m_reba_codigoMSGERROR != value)
				{
					m_reba_codigoMSGERROR = value;
					OnPropertyChanged("REBA_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DREB_Valor.
		/// </summary>
		[DataMember]
		public Boolean DREB_ValorOK
		{
			get { return m_dreb_valorOK; }
			set
			{
				if (m_dreb_valorOK != value)
				{
					m_dreb_valorOK = value;
					OnPropertyChanged("DREB_ValorOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DREB_Valor.
		/// </summary>
		[DataMember]
		public String DREB_ValorMSGERROR
		{
			get { return m_dreb_valorMSGERROR; }
			set
			{
				if (m_dreb_valorMSGERROR != value)
				{
					m_dreb_valorMSGERROR = value;
					OnPropertyChanged("DREB_ValorMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DREB_Codigo.
		/// </summary>
		[DataMember]
		public Boolean DREB_CodigoOK
		{
			get { return m_dreb_codigoOK; }
			set
			{
				if (m_dreb_codigoOK != value)
				{
					m_dreb_codigoOK = value;
					OnPropertyChanged("DREB_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DREB_Codigo.
		/// </summary>
		[DataMember]
		public String DREB_CodigoMSGERROR
		{
			get { return m_dreb_codigoMSGERROR; }
			set
			{
				if (m_dreb_codigoMSGERROR != value)
				{
					m_dreb_codigoMSGERROR = value;
					OnPropertyChanged("DREB_CodigoMSGERROR");
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
				PACK_CodigoOK  = true;
				PACK_CodigoMSGERROR  = "";
				if( PACK_Codigo == null)
				{
					_isCorrect = false;
					PACK_CodigoOK  = false;
					PACK_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PACK_Codigo", "DetRebate");
					m_mensajeError += "* Debe ingresar el campo PACK_Codigo" + Environment.NewLine;
				}
				REBA_CodigoOK  = true;
				REBA_CodigoMSGERROR  = "";
				if( REBA_Codigo == null)
				{
					_isCorrect = false;
					REBA_CodigoOK  = false;
					REBA_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "REBA_Codigo", "DetRebate");
					m_mensajeError += "* Debe ingresar el campo REBA_Codigo" + Environment.NewLine;
				}
				DREB_ValorOK  = true;
				DREB_ValorMSGERROR  = "";
				if( DREB_Valor == null)
				{
					_isCorrect = false;
					DREB_ValorOK  = false;
					DREB_ValorMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DREB_Valor", "DetRebate");
					m_mensajeError += "* Debe ingresar el campo DREB_Valor" + Environment.NewLine;
				}
				DREB_CodigoOK  = true;
				DREB_CodigoMSGERROR  = "";
				if( DREB_Codigo == null)
				{
					_isCorrect = false;
					DREB_CodigoOK  = false;
					DREB_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DREB_Codigo", "DetRebate");
					m_mensajeError += "* Debe ingresar el campo DREB_Codigo" + Environment.NewLine;
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
