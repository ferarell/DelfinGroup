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
	public partial class Det_Cotizacion_OV_Novedad : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_ovno_codigo;
		private Int32 m_ccot_numero;
		private Int16 m_ccot_tipo;
		private Nullable<DateTime> m_ovno_fecha;
		private String m_ovno_descrip;
		private Nullable<Boolean> m_ovno_email;
		private String m_audi_usrcrea;
		private Nullable<DateTime> m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		private String m_cons_tabnot;
		private String m_cons_codnot;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Det_Cotizacion_OV_Novedad.
		/// </summary>
		public Det_Cotizacion_OV_Novedad()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: OVNO_Codigo.
		/// </summary>
		[DataMember]
		public Int32 OVNO_Codigo
		{
			get { return m_ovno_codigo; }
			set
			{
				if (m_ovno_codigo != value)
				{
					m_ovno_codigo = value;
					OnPropertyChanged("OVNO_Codigo");
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
		/// Gets or sets el valor de: OVNO_Fecha.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> OVNO_Fecha
		{
			get { return m_ovno_fecha; }
			set
			{
				if (m_ovno_fecha != value)
				{
					m_ovno_fecha = value;
					OnPropertyChanged("OVNO_Fecha");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OVNO_Descrip.
		/// </summary>
		[DataMember]
		public String OVNO_Descrip
		{
			get { return m_ovno_descrip; }
			set
			{
				if (m_ovno_descrip != value)
				{
					m_ovno_descrip = value;
					OnPropertyChanged("OVNO_Descrip");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: OVNO_Email.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> OVNO_Email
		{
			get { return m_ovno_email; }
			set
			{
				if (m_ovno_email != value)
				{
					m_ovno_email = value;
					OnPropertyChanged("OVNO_Email");
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
		public Nullable<DateTime> AUDI_FecCrea
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
		/// <summary>
		/// Gets or sets el valor de: CONS_TabNot.
		/// </summary>
		[DataMember]
		public String CONS_TabNot
		{
			get { return m_cons_tabnot; }
			set
			{
				if (m_cons_tabnot != value)
				{
					m_cons_tabnot = value;
					OnPropertyChanged("CONS_TabNot");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodNot.
		/// </summary>
		[DataMember]
		public String CONS_CodNot
		{
			get { return m_cons_codnot; }
			set
			{
				if (m_cons_codnot != value)
				{
					m_cons_codnot = value;
					OnPropertyChanged("CONS_CodNot");
				}
			}
		}
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Det_Cotizacion_OV_Novedad Item)
		{
			try
			{
				if (Item == null) { Item = new Det_Cotizacion_OV_Novedad(); }
				Item.OVNO_Codigo = this.OVNO_Codigo;
				Item.CCOT_Numero = this.CCOT_Numero;
				Item.CCOT_Tipo = this.CCOT_Tipo;
				Item.OVNO_Fecha = this.OVNO_Fecha;
				Item.OVNO_Descrip = this.OVNO_Descrip;
				Item.OVNO_Email = this.OVNO_Email;
				Item.CONS_TabNot = this.CONS_TabNot;
				Item.CONS_CodNot = this.CONS_CodNot;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
