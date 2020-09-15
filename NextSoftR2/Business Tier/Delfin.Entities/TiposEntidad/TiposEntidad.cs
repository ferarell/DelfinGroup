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
   [KnownType(typeof(MasterBusinessEntity))]
   public partial class TiposEntidad : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_tipe_codigo;
		private String m_tipe_descripcion;
		private Nullable<Int16> m_tipe_nivel;
		private Nullable<Int16> m_tipe_padre;
		private Boolean m_tipe_activo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase TiposEntidad.
		/// </summary>
		public TiposEntidad()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: TIPE_Codigo.
		/// </summary>
		[DataMember]
		public Int16 TIPE_Codigo
		{
			get { return m_tipe_codigo; }
			set
			{
				if (m_tipe_codigo != value)
				{
					m_tipe_codigo = value;
					OnPropertyChanged("TIPE_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPE_Descripcion.
		/// </summary>
		[DataMember]
		public String TIPE_Descripcion
		{
			get { return m_tipe_descripcion; }
			set
			{
				if (m_tipe_descripcion != value)
				{
					m_tipe_descripcion = value;
					OnPropertyChanged("TIPE_Descripcion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPE_Nivel.
		/// </summary>
		[DataMember]
		public Nullable<Int16> TIPE_Nivel
		{
			get { return m_tipe_nivel; }
			set
			{
				if (m_tipe_nivel != value)
				{
					m_tipe_nivel = value;
					OnPropertyChanged("TIPE_Nivel");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPE_Padre.
		/// </summary>
		[DataMember]
		public Nullable<Int16> TIPE_Padre
		{
			get { return m_tipe_padre; }
			set
			{
				if (m_tipe_padre != value)
				{
					m_tipe_padre = value;
					OnPropertyChanged("TIPE_Padre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPE_Activo.
		/// </summary>
		[DataMember]
		public Boolean TIPE_Activo
		{
			get { return m_tipe_activo; }
			set
			{
				if (m_tipe_activo != value)
				{
					m_tipe_activo = value;
					OnPropertyChanged("TIPE_Activo");
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
		public void CopyTo(ref TiposEntidad Item)
		{
			try
			{
				if (Item == null) { Item = new TiposEntidad(); }
				Item.TIPE_Codigo = this.TIPE_Codigo;
				Item.TIPE_Descripcion = this.TIPE_Descripcion;
				Item.TIPE_Nivel = this.TIPE_Nivel;
				Item.TIPE_Padre = this.TIPE_Padre;
				Item.TIPE_Activo = this.TIPE_Activo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
