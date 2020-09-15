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
	public partial class Det_Cotizacion_OV_Archivo : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_ovar_codigo;
		private Int32 m_ccot_numero;
		private Int16 m_ccot_tipo;
		private String m_ovar_descrip;
		private Nullable<DateTime> m_ovar_fecemi;
		private byte[] m_ovar_archivo;
      private String m_ovar_observacion;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Det_Cotizacion_OV_Archivo.
		/// </summary>
		public Det_Cotizacion_OV_Archivo()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: OVAR_Codigo.
		/// </summary>
		[DataMember]
		public Int32 OVAR_Codigo
		{
			get { return m_ovar_codigo; }
			set
			{
				if (m_ovar_codigo != value)
				{
					m_ovar_codigo = value;
					OnPropertyChanged("OVAR_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public Int32 CCOT_Numero
		{
			get { return m_ccot_numero; }
			set
			{
				if (m_ccot_numero != value)
				{
					m_ccot_numero = value;
					OnPropertyChanged("CCOT_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public Int16 CCOT_Tipo
		{
			get { return m_ccot_tipo; }
			set
			{
				if (m_ccot_tipo != value)
				{
					m_ccot_tipo = value;
					OnPropertyChanged("CCOT_Tipo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OVAR_Descrip.
		/// </summary>
		[DataMember]
		public String OVAR_Descrip
		{
			get { return m_ovar_descrip; }
			set
			{
				if (m_ovar_descrip != value)
				{
					m_ovar_descrip = value;
					OnPropertyChanged("OVAR_Descrip");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OVAR_FecEmi.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> OVAR_FecEmi
		{
			get { return m_ovar_fecemi; }
			set
			{
				if (m_ovar_fecemi != value)
				{
					m_ovar_fecemi = value;
					OnPropertyChanged("OVAR_FecEmi");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OVAR_Archivo.
		/// </summary>
		[DataMember]
		public byte[] OVAR_Archivo
		{
			get { return m_ovar_archivo; }
			set
			{
				if (m_ovar_archivo != value)
				{
					m_ovar_archivo = value;
					OnPropertyChanged("OVAR_Archivo");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: OVAR_Observacion.
      /// </summary>
      [DataMember]
      public String OVAR_Observacion
      {
         get { return m_ovar_observacion; }
         set
         {
            if (m_ovar_observacion != value)
            {
               m_ovar_observacion = value;
               OnPropertyChanged("OVAR_Observacion");
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
		public void CopyTo(ref Det_Cotizacion_OV_Archivo Item)
		{
			try
			{
				if (Item == null) { Item = new Det_Cotizacion_OV_Archivo(); }
				Item.OVAR_Codigo = this.OVAR_Codigo;
				Item.CCOT_Numero = this.CCOT_Numero;
				Item.CCOT_Tipo = this.CCOT_Tipo;
				Item.OVAR_Descrip = this.OVAR_Descrip;
				Item.OVAR_FecEmi = this.OVAR_FecEmi;
				Item.OVAR_Archivo = this.OVAR_Archivo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
