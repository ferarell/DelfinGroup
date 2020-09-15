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
	public partial class Transferencia : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private Int32 m_tran_codigo;
		private Nullable<DateTime> m_tran_fecha;
		private String m_tran_glosa;
		private String m_tran_estado;
      private String m_tran_tipo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Transferencia.
		/// </summary>
		public Transferencia()
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
		/// Gets or sets el valor de: TRAN_Codigo.
		/// </summary>
		[DataMember]
		public Int32 TRAN_Codigo
		{
			get { return m_tran_codigo; }
			set
			{
				if (m_tran_codigo != value)
				{
					m_tran_codigo = value;
					OnPropertyChanged("TRAN_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TRAN_Fecha.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> TRAN_Fecha
		{
			get { return m_tran_fecha; }
			set
			{
				if (m_tran_fecha != value)
				{
					m_tran_fecha = value;
					OnPropertyChanged("TRAN_Fecha");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TRAN_Glosa.
		/// </summary>
		[DataMember]
		public String TRAN_Glosa
		{
			get { return m_tran_glosa; }
			set
			{
				if (m_tran_glosa != value)
				{
					m_tran_glosa = value;
					OnPropertyChanged("TRAN_Glosa");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TRAN_Estado.
		/// </summary>
		[DataMember]
		public String TRAN_Estado
		{
			get { return m_tran_estado; }
			set
			{
				if (m_tran_estado != value)
				{
					m_tran_estado = value;
					OnPropertyChanged("TRAN_Estado");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: TRAN_Tipo.
      /// </summary>
      [DataMember]
      public String TRAN_Tipo
      {
         get { return m_tran_tipo; }
         set
         {
            if (m_tran_tipo != value)
            {
               m_tran_tipo = value;
               OnPropertyChanged("TRAN_Tipo");
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
		public void CopyTo(ref Transferencia Item)
		{
			try
			{
				if (Item == null) { Item = new Transferencia(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.TRAN_Codigo = this.TRAN_Codigo;
				Item.TRAN_Fecha = this.TRAN_Fecha;
				Item.TRAN_Glosa = this.TRAN_Glosa;
				Item.TRAN_Estado = this.TRAN_Estado;
            Item.TRAN_Tipo = this.TRAN_Tipo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
