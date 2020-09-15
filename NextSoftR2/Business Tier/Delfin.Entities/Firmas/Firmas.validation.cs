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
	public partial class Firmas
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_firm_codigoOK;
		private String m_firm_codigoMSGERROR;
		private Boolean m_cuba_codigoOK;
		private String m_cuba_codigoMSGERROR;
		private Boolean m_firm_nombreOK;
		private String m_firm_nombreMSGERROR;
		private Boolean m_firm_cargoOK;
		private String m_firm_cargoMSGERROR;
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
		/// Gets or sets el valor de validación de: EMPR_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean EMPR_CodigoOK
		{
			get { return m_empr_codigoOK; }
			set
			{
				if (m_empr_codigoOK != value)
				{ m_empr_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EMPR_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String EMPR_CodigoMSGERROR
		{
			get { return m_empr_codigoMSGERROR; }
			set
			{
				if (m_empr_codigoMSGERROR != value)
				{m_empr_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: FIRM_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean FIRM_CodigoOK
		{
			get { return m_firm_codigoOK; }
			set
			{
				if (m_firm_codigoOK != value)
				{ m_firm_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: FIRM_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String FIRM_CodigoMSGERROR
		{
			get { return m_firm_codigoMSGERROR; }
			set
			{
				if (m_firm_codigoMSGERROR != value)
				{m_firm_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CUBA_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CUBA_CodigoOK
		{
			get { return m_cuba_codigoOK; }
			set
			{
				if (m_cuba_codigoOK != value)
				{ m_cuba_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CUBA_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String CUBA_CodigoMSGERROR
		{
			get { return m_cuba_codigoMSGERROR; }
			set
			{
				if (m_cuba_codigoMSGERROR != value)
				{m_cuba_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: FIRM_Nombre.
		/// </summary>
		[IgnoreDataMember]
		public Boolean FIRM_NombreOK
		{
			get { return m_firm_nombreOK; }
			set
			{
				if (m_firm_nombreOK != value)
				{ m_firm_nombreOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: FIRM_Nombre.
		/// </summary>
		[IgnoreDataMember]
		public String FIRM_NombreMSGERROR
		{
			get { return m_firm_nombreMSGERROR; }
			set
			{
				if (m_firm_nombreMSGERROR != value)
				{m_firm_nombreMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: FIRM_Cargo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean FIRM_CargoOK
		{
			get { return m_firm_cargoOK; }
			set
			{
				if (m_firm_cargoOK != value)
				{ m_firm_cargoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: FIRM_Cargo.
		/// </summary>
		[IgnoreDataMember]
		public String FIRM_CargoMSGERROR
		{
			get { return m_firm_cargoMSGERROR; }
			set
			{
				if (m_firm_cargoMSGERROR != value)
				{m_firm_cargoMSGERROR = value; }
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
				EMPR_CodigoOK  = true;
				EMPR_CodigoMSGERROR  = "";
				if( EMPR_Codigo == null)
				{
					_isCorrect = false;
					EMPR_CodigoOK  = false;
					EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "Firmas");
					m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
				}
				FIRM_CodigoOK  = true;
				FIRM_CodigoMSGERROR  = "";
				if( FIRM_Codigo == 0)
				{
					_isCorrect = false;
					FIRM_CodigoOK  = false;
					FIRM_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "FIRM_Codigo", "Firmas");
					m_mensajeError += "* Debe ingresar el campo FIRM_Codigo" + Environment.NewLine;
				}
				CUBA_CodigoOK  = true;
				CUBA_CodigoMSGERROR  = "";
				if( String.IsNullOrEmpty(CUBA_Codigo) )
				{
					_isCorrect = false;
					CUBA_CodigoOK  = false;
					CUBA_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CUBA_Codigo", "Firmas");
					m_mensajeError += "* Debe ingresar el campo CUBA_Codigo" + Environment.NewLine;
				}
				FIRM_CargoOK  = true;
				FIRM_CargoMSGERROR  = "";
				if( String.IsNullOrEmpty(FIRM_Cargo) )
				{
					_isCorrect = false;
					FIRM_CargoOK  = false;
					FIRM_CargoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "FIRM_Cargo", "Firmas");
					m_mensajeError += "* Debe ingresar el campo FIRM_Cargo" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
