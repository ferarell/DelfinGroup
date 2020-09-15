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
	public partial class LoadingList_Files
	{
		#region [ Variables Validación ]
		private Boolean m_load_codigoOK;
		private String m_load_codigoMSGERROR;
		private Boolean m_file_codigoOK;
		private String m_file_codigoMSGERROR;
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
		/// Gets or sets el valor de validación de: LOAD_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_CodigoOK
		{
			get { return m_load_codigoOK; }
			set
			{
				if (m_load_codigoOK != value)
				{ m_load_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_CodigoMSGERROR
		{
			get { return m_load_codigoMSGERROR; }
			set
			{
				if (m_load_codigoMSGERROR != value)
				{m_load_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: FILE_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean FILE_CodigoOK
		{
			get { return m_file_codigoOK; }
			set
			{
				if (m_file_codigoOK != value)
				{ m_file_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: FILE_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String FILE_CodigoMSGERROR
		{
			get { return m_file_codigoMSGERROR; }
			set
			{
				if (m_file_codigoMSGERROR != value)
				{m_file_codigoMSGERROR = value; }
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
				LOAD_CodigoOK  = true;
				LOAD_CodigoMSGERROR  = "";
				if( LOAD_Codigo == 0)
				{
					_isCorrect = false;
					LOAD_CodigoOK  = false;
					LOAD_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LOAD_Codigo", "LoadingList_Files");
					m_mensajeError += "* Debe ingresar el campo LOAD_Codigo" + Environment.NewLine;
				}
				FILE_CodigoOK  = true;
				FILE_CodigoMSGERROR  = "";
				if( FILE_Codigo == 0)
				{
					_isCorrect = false;
					FILE_CodigoOK  = false;
					FILE_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "FILE_Codigo", "LoadingList_Files");
					m_mensajeError += "* Debe ingresar el campo FILE_Codigo" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
