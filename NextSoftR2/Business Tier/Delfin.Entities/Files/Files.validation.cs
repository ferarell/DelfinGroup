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
	public partial class Files
	{
		#region [ Variables Validación ]
		private Boolean m_file_codigoOK;
		private String m_file_codigoMSGERROR;
		private Boolean m_file_contentlenghtOK;
		private String m_file_contentlenghtMSGERROR;
		private Boolean m_file_contenttypeOK;
		private String m_file_contenttypeMSGERROR;
		private Boolean m_file_filenameOK;
		private String m_file_filenameMSGERROR;
		private Boolean m_file_inputstreamOK;
		private String m_file_inputstreamMSGERROR;
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
		/// <summary>
		/// Gets or sets el valor de validación de: FILE_ContentLenght.
		/// </summary>
		[IgnoreDataMember]
		public Boolean FILE_ContentLenghtOK
		{
			get { return m_file_contentlenghtOK; }
			set
			{
				if (m_file_contentlenghtOK != value)
				{ m_file_contentlenghtOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: FILE_ContentLenght.
		/// </summary>
		[IgnoreDataMember]
		public String FILE_ContentLenghtMSGERROR
		{
			get { return m_file_contentlenghtMSGERROR; }
			set
			{
				if (m_file_contentlenghtMSGERROR != value)
				{m_file_contentlenghtMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: FILE_ContentType.
		/// </summary>
		[IgnoreDataMember]
		public Boolean FILE_ContentTypeOK
		{
			get { return m_file_contenttypeOK; }
			set
			{
				if (m_file_contenttypeOK != value)
				{ m_file_contenttypeOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: FILE_ContentType.
		/// </summary>
		[IgnoreDataMember]
		public String FILE_ContentTypeMSGERROR
		{
			get { return m_file_contenttypeMSGERROR; }
			set
			{
				if (m_file_contenttypeMSGERROR != value)
				{m_file_contenttypeMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: FILE_FileName.
		/// </summary>
		[IgnoreDataMember]
		public Boolean FILE_FileNameOK
		{
			get { return m_file_filenameOK; }
			set
			{
				if (m_file_filenameOK != value)
				{ m_file_filenameOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: FILE_FileName.
		/// </summary>
		[IgnoreDataMember]
		public String FILE_FileNameMSGERROR
		{
			get { return m_file_filenameMSGERROR; }
			set
			{
				if (m_file_filenameMSGERROR != value)
				{m_file_filenameMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: FILE_InputStream.
		/// </summary>
		[IgnoreDataMember]
		public Boolean FILE_InputStreamOK
		{
			get { return m_file_inputstreamOK; }
			set
			{
				if (m_file_inputstreamOK != value)
				{ m_file_inputstreamOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: FILE_InputStream.
		/// </summary>
		[IgnoreDataMember]
		public String FILE_InputStreamMSGERROR
		{
			get { return m_file_inputstreamMSGERROR; }
			set
			{
				if (m_file_inputstreamMSGERROR != value)
				{m_file_inputstreamMSGERROR = value; }
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
				FILE_CodigoOK  = true;
				FILE_CodigoMSGERROR  = "";
				if( FILE_Codigo == 0)
				{
					_isCorrect = false;
					FILE_CodigoOK  = false;
					FILE_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "FILE_Codigo", "Files");
					m_mensajeError += "* Debe ingresar el campo FILE_Codigo" + Environment.NewLine;
				}
				FILE_ContentLenghtOK  = true;
				FILE_ContentLenghtMSGERROR  = "";
				if( FILE_ContentLenght == 0)
				{
					_isCorrect = false;
					FILE_ContentLenghtOK  = false;
					FILE_ContentLenghtMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "FILE_ContentLenght", "Files");
					m_mensajeError += "* Debe ingresar el campo FILE_ContentLenght" + Environment.NewLine;
				}
				FILE_ContentTypeOK  = true;
				FILE_ContentTypeMSGERROR  = "";
				if( String.IsNullOrEmpty(FILE_ContentType) )
				{
					_isCorrect = false;
					FILE_ContentTypeOK  = false;
					FILE_ContentTypeMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "FILE_ContentType", "Files");
					m_mensajeError += "* Debe ingresar el campo FILE_ContentType" + Environment.NewLine;
				}
				FILE_FileNameOK  = true;
				FILE_FileNameMSGERROR  = "";
				if( String.IsNullOrEmpty(FILE_FileName) )
				{
					_isCorrect = false;
					FILE_FileNameOK  = false;
					FILE_FileNameMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "FILE_FileName", "Files");
					m_mensajeError += "* Debe ingresar el campo FILE_FileName" + Environment.NewLine;
				}
				FILE_InputStreamOK  = true;
				FILE_InputStreamMSGERROR  = "";
				if( FILE_InputStream == null)
				{
					_isCorrect = false;
					FILE_InputStreamOK  = false;
					FILE_InputStreamMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "FILE_InputStream", "Files");
					m_mensajeError += "* Debe ingresar el campo FILE_InputStream" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
