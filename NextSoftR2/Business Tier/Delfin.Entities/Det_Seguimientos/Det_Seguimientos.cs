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
	public partial class Det_Seguimientos : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_cseg_codigo;
		private Int32 m_dseg_item;
		private DateTime? m_dseg_fechaarribo;
		private DateTime? m_dseg_fecingresodep;
		private Nullable<DateTime> m_dseg_fecretirodep;
		private Nullable<DateTime> m_dseg_fecpago;
		private String m_dseg_nrocontenedor;
		private Boolean m_dseg_tarja;
		private String m_cons_codess;
		private String m_cons_tabess;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Det_Seguimientos.
		/// </summary>
		public Det_Seguimientos()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CSEG_Codigo.
		/// </summary>
		[DataMember]
		public Int32 CSEG_Codigo
		{
			get { return m_cseg_codigo; }
			set
			{
				if (m_cseg_codigo != value)
				{
					m_cseg_codigo = value;
					OnPropertyChanged("CSEG_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DSEG_Item.
		/// </summary>
		[DataMember]
		public Int32 DSEG_Item
		{
			get { return m_dseg_item; }
			set
			{
				if (m_dseg_item != value)
				{
					m_dseg_item = value;
					OnPropertyChanged("DSEG_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DSEG_FechaArribo.
		/// </summary>
		[DataMember]
		public DateTime? DSEG_FechaArribo
		{
			get { return m_dseg_fechaarribo; }
			set
			{
				if (m_dseg_fechaarribo != value)
				{
					m_dseg_fechaarribo = value;
					OnPropertyChanged("DSEG_FechaArribo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DSEG_FecIngresoDep.
		/// </summary>
		[DataMember]
		public DateTime? DSEG_FecIngresoDep
		{
			get { return m_dseg_fecingresodep; }
			set
			{
				if (m_dseg_fecingresodep != value)
				{
					m_dseg_fecingresodep = value;
					OnPropertyChanged("DSEG_FecIngresoDep");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DSEG_FecRetiroDep.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> DSEG_FecRetiroDep
		{
			get { return m_dseg_fecretirodep; }
			set
			{
				if (m_dseg_fecretirodep != value)
				{
					m_dseg_fecretirodep = value;
					OnPropertyChanged("DSEG_FecRetiroDep");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DSEG_FecPago.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> DSEG_FecPago
		{
			get { return m_dseg_fecpago; }
			set
			{
				if (m_dseg_fecpago != value)
				{
					m_dseg_fecpago = value;
					OnPropertyChanged("DSEG_FecPago");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DSEG_NroContenedor.
		/// </summary>
		[DataMember]
		public String DSEG_NroContenedor
		{
			get { return m_dseg_nrocontenedor; }
			set
			{
				if (m_dseg_nrocontenedor != value)
				{
					m_dseg_nrocontenedor = value;
					OnPropertyChanged("DSEG_NroContenedor");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: DSEG_Tarja.
		/// </summary>
		[DataMember]
		public Boolean DSEG_Tarja
		{
			get { return m_dseg_tarja; }
			set
			{
				if (m_dseg_tarja != value)
				{
					m_dseg_tarja = value;
					OnPropertyChanged("DSEG_Tarja");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodESS.
		/// </summary>
		[DataMember]
		public String CONS_CodESS
		{
			get { return m_cons_codess; }
			set
			{
				if (m_cons_codess != value)
				{
					m_cons_codess = value;
					OnPropertyChanged("CONS_CodESS");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabESS.
		/// </summary>
		[DataMember]
		public String CONS_TabESS
		{
			get { return m_cons_tabess; }
			set
			{
				if (m_cons_tabess != value)
				{
					m_cons_tabess = value;
					OnPropertyChanged("CONS_TabESS");
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
		public void CopyTo(ref Det_Seguimientos Item)
		{
			try
			{
				if (Item == null) { Item = new Det_Seguimientos(); }
				Item.CSEG_Codigo = this.CSEG_Codigo;
				Item.DSEG_Item = this.DSEG_Item;
				Item.DSEG_FechaArribo = this.DSEG_FechaArribo;
				Item.DSEG_FecIngresoDep = this.DSEG_FecIngresoDep;
				Item.DSEG_FecRetiroDep = this.DSEG_FecRetiroDep;
				Item.DSEG_FecPago = this.DSEG_FecPago;
				Item.DSEG_NroContenedor = this.DSEG_NroContenedor;
				Item.DSEG_Tarja = this.DSEG_Tarja;
				Item.CONS_CodESS = this.CONS_CodESS;
				Item.CONS_TabESS = this.CONS_TabESS;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
