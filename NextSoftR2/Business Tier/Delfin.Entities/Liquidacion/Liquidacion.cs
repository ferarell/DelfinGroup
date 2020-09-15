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
	public partial class Liquidacion : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private String m_liqu_codigo;
		private Int32 m_liqu_numero;
		private String m_liqu_glosa;
		private Nullable<DateTime> m_liqu_fecha;
		private String m_liqu_estado;
		private String m_liqu_usraprobado;
		private Nullable<DateTime> m_liqu_fecaprobado;
		private String m_liqu_usranulado;
		private Nullable<DateTime> m_liqu_fecanulado;
		private Nullable<Int16> m_tipe_codigo;
		private Nullable<Int32> m_entc_codigo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Liquidacion.
		/// </summary>
		public Liquidacion()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: EMPR_Codigo.
		/// </summary>
		[DataMember]
		public Int16 EMPR_Codigo
		{
			get { return m_empr_codigo; }
			set
			{
				if (m_empr_codigo != value)
				{
					m_empr_codigo = value;
					OnPropertyChanged("EMPR_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LIQU_Codigo.
		/// </summary>
		[DataMember]
		public String LIQU_Codigo
		{
			get { return m_liqu_codigo; }
			set
			{
				if (m_liqu_codigo != value)
				{
					m_liqu_codigo = value;
					OnPropertyChanged("LIQU_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LIQU_Numero.
		/// </summary>
		[DataMember]
		public Int32 LIQU_Numero
		{
			get { return m_liqu_numero; }
			set
			{
				if (m_liqu_numero != value)
				{
					m_liqu_numero = value;
					OnPropertyChanged("LIQU_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LIQU_Glosa.
		/// </summary>
		[DataMember]
		public String LIQU_Glosa
		{
			get { return m_liqu_glosa; }
			set
			{
				if (m_liqu_glosa != value)
				{
					m_liqu_glosa = value;
					OnPropertyChanged("LIQU_Glosa");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LIQU_Fecha.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> LIQU_Fecha
		{
			get { return m_liqu_fecha; }
			set
			{
				if (m_liqu_fecha != value)
				{
					m_liqu_fecha = value;
					OnPropertyChanged("LIQU_Fecha");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LIQU_Estado.
		/// </summary>
		[DataMember]
		public String LIQU_Estado
		{
			get { return m_liqu_estado; }
			set
			{
				if (m_liqu_estado != value)
				{
					m_liqu_estado = value;
					OnPropertyChanged("LIQU_Estado");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LIQU_UsrAprobado.
		/// </summary>
		[DataMember]
		public String LIQU_UsrAprobado
		{
			get { return m_liqu_usraprobado; }
			set
			{
				if (m_liqu_usraprobado != value)
				{
					m_liqu_usraprobado = value;
					OnPropertyChanged("LIQU_UsrAprobado");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LIQU_FecAprobado.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> LIQU_FecAprobado
		{
			get { return m_liqu_fecaprobado; }
			set
			{
				if (m_liqu_fecaprobado != value)
				{
					m_liqu_fecaprobado = value;
					OnPropertyChanged("LIQU_FecAprobado");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LIQU_UsrAnulado.
		/// </summary>
		[DataMember]
		public String LIQU_UsrAnulado
		{
			get { return m_liqu_usranulado; }
			set
			{
				if (m_liqu_usranulado != value)
				{
					m_liqu_usranulado = value;
					OnPropertyChanged("LIQU_UsrAnulado");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LIQU_FecAnulado.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> LIQU_FecAnulado
		{
			get { return m_liqu_fecanulado; }
			set
			{
				if (m_liqu_fecanulado != value)
				{
					m_liqu_fecanulado = value;
					OnPropertyChanged("LIQU_FecAnulado");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPE_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> TIPE_Codigo
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
		/// Gets or sets el valor de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_Codigo
		{
			get { return m_entc_codigo; }
			set
			{
				if (m_entc_codigo != value)
				{
					m_entc_codigo = value;
					OnPropertyChanged("ENTC_Codigo");
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
		public void CopyTo(ref Liquidacion Item)
		{
			try
			{
				if (Item == null) { Item = new Liquidacion(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.LIQU_Codigo = this.LIQU_Codigo;
				Item.LIQU_Numero = this.LIQU_Numero;
				Item.LIQU_Glosa = this.LIQU_Glosa;
				Item.LIQU_Fecha = this.LIQU_Fecha;
				Item.LIQU_Estado = this.LIQU_Estado;
				Item.LIQU_UsrAprobado = this.LIQU_UsrAprobado;
				Item.LIQU_FecAprobado = this.LIQU_FecAprobado;
				Item.LIQU_UsrAnulado = this.LIQU_UsrAnulado;
				Item.LIQU_FecAnulado = this.LIQU_FecAnulado;
				Item.TIPE_Codigo = this.TIPE_Codigo;
				Item.ENTC_Codigo = this.ENTC_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
