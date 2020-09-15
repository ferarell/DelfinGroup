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
	public partial class Planillas : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private String m_plan_tipo;
		private String m_plan_codigo;
		private String m_cons_tabest;
		private String m_cons_codest;
		private Nullable<DateTime> m_plan_fechaemision;
		private String m_plan_concepto;
		private String m_plan_archivo;
		private String m_plan_lote;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Planillas.
		/// </summary>
		public Planillas()
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
		/// Gets or sets el valor de: PLAN_Tipo.
		/// </summary>
		[DataMember]
		public String PLAN_Tipo
		{
			get { return m_plan_tipo; }
			set
			{
				if (m_plan_tipo != value)
				{
					m_plan_tipo = value;
					OnPropertyChanged("PLAN_Tipo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PLAN_Codigo.
		/// </summary>
		[DataMember]
		public String PLAN_Codigo
		{
			get { return m_plan_codigo; }
			set
			{
				if (m_plan_codigo != value)
				{
					m_plan_codigo = value;
					OnPropertyChanged("PLAN_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabEST.
		/// </summary>
		[DataMember]
		public String CONS_TabEST
		{
			get { return m_cons_tabest; }
			set
			{
				if (m_cons_tabest != value)
				{
					m_cons_tabest = value;
					OnPropertyChanged("CONS_TabEST");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodEST.
		/// </summary>
		[DataMember]
		public String CONS_CodEST
		{
			get { return m_cons_codest; }
			set
			{
				if (m_cons_codest != value)
				{
					m_cons_codest = value;
					OnPropertyChanged("CONS_CodEST");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PLAN_FechaEmision.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> PLAN_FechaEmision
		{
			get { return m_plan_fechaemision; }
			set
			{
				if (m_plan_fechaemision != value)
				{
					m_plan_fechaemision = value;
					OnPropertyChanged("PLAN_FechaEmision");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PLAN_Concepto.
		/// </summary>
		[DataMember]
		public String PLAN_Concepto
		{
			get { return m_plan_concepto; }
			set
			{
				if (m_plan_concepto != value)
				{
					m_plan_concepto = value;
					OnPropertyChanged("PLAN_Concepto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PLAN_Archivo.
		/// </summary>
		[DataMember]
		public String PLAN_Archivo
		{
			get { return m_plan_archivo; }
			set
			{
				if (m_plan_archivo != value)
				{
					m_plan_archivo = value;
					OnPropertyChanged("PLAN_Archivo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PLAN_Lote.
		/// </summary>
		[DataMember]
		public String PLAN_Lote
		{
			get { return m_plan_lote; }
			set
			{
				if (m_plan_lote != value)
				{
					m_plan_lote = value;
					OnPropertyChanged("PLAN_Lote");
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
		public void CopyTo(ref Planillas Item)
		{
			try
			{
				if (Item == null) { Item = new Planillas(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.PLAN_Tipo = this.PLAN_Tipo;
				Item.PLAN_Codigo = this.PLAN_Codigo;
				Item.CONS_TabEST = this.CONS_TabEST;
				Item.CONS_CodEST = this.CONS_CodEST;
				Item.PLAN_FechaEmision = this.PLAN_FechaEmision;
				Item.PLAN_Concepto = this.PLAN_Concepto;
				Item.PLAN_Archivo = this.PLAN_Archivo;
				Item.PLAN_Lote = this.PLAN_Lote;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
