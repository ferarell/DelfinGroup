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
	public partial class Anexos : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_anex_item;
		private Int32 m_ccot_numero;
		private Int16 m_ccot_tipo;
		private String m_anex_mromanifiesto;
		private Nullable<DateTime> m_anex_fecllegada;
		private Nullable<DateTime> m_anex_fecsalida;
		private String m_anex_numerohbl;
		private Nullable<DateTime> m_anex_fecdescarga;
		private Nullable<DateTime> m_anex_fecembarque;
		private String m_anex_tipo;
      private String m_anex_tiporectificacion;
		private String m_anex_observaciones;
		private String m_anex_dondedice;
		private String m_anex_debedecir;
      private String m_anex_fundamentos;
		private String m_anex_documentos;
		private String m_audi_usrcrea;
		private Nullable<DateTime> m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Anexos.
		/// </summary>
		public Anexos()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: ANEX_Item.
		/// </summary>
		[DataMember]
		public Int16 ANEX_Item
		{
			get { return m_anex_item; }
			set
			{
				if (m_anex_item != value)
				{
					m_anex_item = value;
					OnPropertyChanged("ANEX_Item");
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
		/// Gets or sets el valor de: ANEX_MroManifiesto.
		/// </summary>
		[DataMember]
		public String ANEX_MroManifiesto
		{
			get { return m_anex_mromanifiesto; }
			set
			{
				if (m_anex_mromanifiesto != value)
				{
					m_anex_mromanifiesto = value;
					OnPropertyChanged("ANEX_MroManifiesto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ANEX_FecLlegada.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> ANEX_FecLlegada
		{
			get { return m_anex_fecllegada; }
			set
			{
				if (m_anex_fecllegada != value)
				{
					m_anex_fecllegada = value;
					OnPropertyChanged("ANEX_FecLlegada");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ANEX_FecSalida.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> ANEX_FecSalida
		{
			get { return m_anex_fecsalida; }
			set
			{
				if (m_anex_fecsalida != value)
				{
					m_anex_fecsalida = value;
					OnPropertyChanged("ANEX_FecSalida");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ANEX_NumeroHBL.
		/// </summary>
		[DataMember]
		public String ANEX_NumeroHBL
		{
			get { return m_anex_numerohbl; }
			set
			{
				if (m_anex_numerohbl != value)
				{
					m_anex_numerohbl = value;
					OnPropertyChanged("ANEX_NumeroHBL");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ANEX_FecDescarga.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> ANEX_FecDescarga
		{
			get { return m_anex_fecdescarga; }
			set
			{
				if (m_anex_fecdescarga != value)
				{
					m_anex_fecdescarga = value;
					OnPropertyChanged("ANEX_FecDescarga");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ANEX_FecEmbarque.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> ANEX_FecEmbarque
		{
			get { return m_anex_fecembarque; }
			set
			{
				if (m_anex_fecembarque != value)
				{
					m_anex_fecembarque = value;
					OnPropertyChanged("ANEX_FecEmbarque");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ANEX_Tipo.
		/// </summary>
		[DataMember]
		public String ANEX_Tipo
		{
			get { return m_anex_tipo; }
			set
			{
				if (m_anex_tipo != value)
				{
					m_anex_tipo = value;
					OnPropertyChanged("ANEX_Tipo");
				}
			}
		}
		/// <summary>
      /// Gets or sets el valor de: ANEX_TipoRectificacion.
		/// </summary>
		[DataMember]
      public String ANEX_TipoRectificacion
		{
         get { return m_anex_tiporectificacion; }
			set
			{
            if (m_anex_tiporectificacion != value)
				{
               m_anex_tiporectificacion = value;
               OnPropertyChanged("ANEX_TipoRectificacion");
				}
			}
		}
      /// <summary>
		/// Gets or sets el valor de: ANEX_Observaciones.
		/// </summary>
		[DataMember]
		public String ANEX_Observaciones
		{
			get { return m_anex_observaciones; }
			set
			{
				if (m_anex_observaciones != value)
				{
					m_anex_observaciones = value;
					OnPropertyChanged("ANEX_Observaciones");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ANEX_DondeDice.
		/// </summary>
		[DataMember]
		public String ANEX_DondeDice
		{
			get { return m_anex_dondedice; }
			set
			{
				if (m_anex_dondedice != value)
				{
					m_anex_dondedice = value;
					OnPropertyChanged("ANEX_DondeDice");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ANEX_DebeDecir.
		/// </summary>
		[DataMember]
		public String ANEX_DebeDecir
		{
			get { return m_anex_debedecir; }
			set
			{
				if (m_anex_debedecir != value)
				{
					m_anex_debedecir = value;
					OnPropertyChanged("ANEX_DebeDecir");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: ANEX_Fundamentos.
      /// </summary>
      [DataMember]
      public String ANEX_Fundamentos
      {
         get { return m_anex_fundamentos; }
         set
         {
            if (m_anex_fundamentos != value)
            {
               m_anex_fundamentos = value;
               OnPropertyChanged("ANEX_Fundamentos");
            }
         }
      }
		/// <summary>
		/// Gets or sets el valor de: ANEX_Documentos.
		/// </summary>
		[DataMember]
		public String ANEX_Documentos
		{
			get { return m_anex_documentos; }
			set
			{
				if (m_anex_documentos != value)
				{
					m_anex_documentos = value;
					OnPropertyChanged("ANEX_Documentos");
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Anexos Item)
		{
			try
			{
				if (Item == null) { Item = new Anexos(); }
				Item.ANEX_Item = this.ANEX_Item;
				Item.CCOT_Numero = this.CCOT_Numero;
				Item.CCOT_Tipo = this.CCOT_Tipo;
				Item.ANEX_MroManifiesto = this.ANEX_MroManifiesto;
				Item.ANEX_FecLlegada = this.ANEX_FecLlegada;
				Item.ANEX_FecSalida = this.ANEX_FecSalida;
				Item.ANEX_NumeroHBL = this.ANEX_NumeroHBL;
				Item.ANEX_FecDescarga = this.ANEX_FecDescarga;
				Item.ANEX_FecEmbarque = this.ANEX_FecEmbarque;
				Item.ANEX_Tipo = this.ANEX_Tipo;
            Item.ANEX_TipoRectificacion = this.ANEX_TipoRectificacion;
				Item.ANEX_Observaciones = this.ANEX_Observaciones;
				Item.ANEX_DondeDice = this.ANEX_DondeDice;
				Item.ANEX_DebeDecir = this.ANEX_DebeDecir;
            Item.ANEX_Fundamentos = this.ANEX_Fundamentos;
				Item.ANEX_Documentos = this.ANEX_Documentos;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
