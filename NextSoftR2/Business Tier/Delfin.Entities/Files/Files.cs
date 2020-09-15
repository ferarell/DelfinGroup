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
	[Serializable()]
	public partial class Files : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_file_codigo;
		private Int32 m_file_contentlenght;
		private String m_file_contenttype;
		private String m_file_filename;
		private byte[] m_file_inputstream;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Files.
		/// </summary>
		public Files()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: FILE_Codigo.
		/// </summary>
		[DataMember]
		public Int32 FILE_Codigo
		{
			get { return m_file_codigo; }
			set
			{
				if (m_file_codigo != value)
				{
					m_file_codigo = value;
					OnPropertyChanged("FILE_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FILE_ContentLenght.
		/// </summary>
		[DataMember]
		public Int32 FILE_ContentLenght
		{
			get { return m_file_contentlenght; }
			set
			{
				if (m_file_contentlenght != value)
				{
					m_file_contentlenght = value;
					OnPropertyChanged("FILE_ContentLenght");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FILE_ContentType.
		/// </summary>
		[DataMember]
		public String FILE_ContentType
		{
			get { return m_file_contenttype; }
			set
			{
				if (m_file_contenttype != value)
				{
					m_file_contenttype = value;
					OnPropertyChanged("FILE_ContentType");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FILE_FileName.
		/// </summary>
		[DataMember]
		public String FILE_FileName
		{
			get { return m_file_filename; }
			set
			{
				if (m_file_filename != value)
				{
					m_file_filename = value;
					OnPropertyChanged("FILE_FileName");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: FILE_InputStream.
		/// </summary>
		[DataMember]
		public byte[] FILE_InputStream
		{
			get { return m_file_inputstream; }
			set
			{
				if (m_file_inputstream != value)
				{
					m_file_inputstream = value;
					OnPropertyChanged("FILE_InputStream");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_UsrCrea.
		/// </summary>
		[DataMember]
		public String AUDI_UsrCrea
		{
			get { return m_audi_usrcrea; }
			set
			{
				if (m_audi_usrcrea != value)
				{
					m_audi_usrcrea = value;
					OnPropertyChanged("AUDI_UsrCrea");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_FecCrea.
		/// </summary>
		[DataMember]
		public DateTime AUDI_FecCrea
		{
			get { return m_audi_feccrea; }
			set
			{
				if (m_audi_feccrea != value)
				{
					m_audi_feccrea = value;
					OnPropertyChanged("AUDI_FecCrea");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_UsrMod.
		/// </summary>
		[DataMember]
		public String AUDI_UsrMod
		{
			get { return m_audi_usrmod; }
			set
			{
				if (m_audi_usrmod != value)
				{
					m_audi_usrmod = value;
					OnPropertyChanged("AUDI_UsrMod");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_FecMod.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> AUDI_FecMod
		{
			get { return m_audi_fecmod; }
			set
			{
				if (m_audi_fecmod != value)
				{
					m_audi_fecmod = value;
					OnPropertyChanged("AUDI_FecMod");
				}
			}
		}
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Files Item)
		{
			try
			{
				if (Item == null) { Item = new Files(); }
				Item.FILE_Codigo = this.FILE_Codigo;
				Item.FILE_ContentLenght = this.FILE_ContentLenght;
				Item.FILE_ContentType = this.FILE_ContentType;
				Item.FILE_FileName = this.FILE_FileName;
				Item.FILE_InputStream = this.FILE_InputStream;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
