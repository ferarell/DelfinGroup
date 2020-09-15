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
	public partial class Chequera : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int16 m_empr_codigo;
		private Int32 m_cheq_codigo;
		private String m_cuba_codigo;
		private Nullable<Int32> m_cheq_nrofinal;
		private Nullable<Int32> m_cheq_nroinicial;
		private Nullable<Int32> m_cheq_nroactual;
		private Nullable<Boolean> m_cheq_diferido;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;

      private String m_cheq_coordenadas;
      private String m_cheq_estado;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Chequera.
		/// </summary>
		public Chequera()
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
		/// Gets or sets el valor de: CHEQ_Codigo.
		/// </summary>
		[DataMember]
		public Int32 CHEQ_Codigo
		{
			get { return m_cheq_codigo; }
			set
			{
				if (m_cheq_codigo != value)
				{
					m_cheq_codigo = value;
					OnPropertyChanged("CHEQ_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CUBA_Codigo.
		/// </summary>
		[DataMember]
		public String CUBA_Codigo
		{
			get { return m_cuba_codigo; }
			set
			{
				if (m_cuba_codigo != value)
				{
					m_cuba_codigo = value;
					OnPropertyChanged("CUBA_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CHEQ_NroFinal.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CHEQ_NroFinal
		{
			get { return m_cheq_nrofinal; }
			set
			{
				if (m_cheq_nrofinal != value)
				{
					m_cheq_nrofinal = value;
					OnPropertyChanged("CHEQ_NroFinal");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CHEQ_NroInicial.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CHEQ_NroInicial
		{
			get { return m_cheq_nroinicial; }
			set
			{
				if (m_cheq_nroinicial != value)
				{
					m_cheq_nroinicial = value;
					OnPropertyChanged("CHEQ_NroInicial");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CHEQ_NroActual.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CHEQ_NroActual
		{
			get { return m_cheq_nroactual; }
			set
			{
				if (m_cheq_nroactual != value)
				{
					m_cheq_nroactual = value;
					OnPropertyChanged("CHEQ_NroActual");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CHEQ_Diferido.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> CHEQ_Diferido
		{
			get { return m_cheq_diferido; }
			set
			{
				if (m_cheq_diferido != value)
				{
					m_cheq_diferido = value;
					OnPropertyChanged("CHEQ_Diferido");
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
      /// <summary>
      /// Gets or sets el valor de: CHEQ_Coordenadas.
      /// </summary>
      [DataMember]
      public String CHEQ_Coordenadas
      {
         get { return m_cheq_coordenadas; }
         set
         {
            if (m_cheq_coordenadas != value)
            {
               m_cheq_coordenadas = value;
               OnPropertyChanged("CHEQ_Coordenadas");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CHEQ_Estado.
      /// </summary>
      [DataMember]
      public String CHEQ_Estado
      {
         get { return m_cheq_estado; }
         set
         {
            if (m_cheq_estado != value)
            {
               m_cheq_estado = value;
               OnPropertyChanged("CHEQ_Estado");
            }
         }
      }
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Chequera Item)
		{
			try
			{
				if (Item == null) { Item = new Chequera(); }
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.CHEQ_Codigo = this.CHEQ_Codigo;
				Item.CUBA_Codigo = this.CUBA_Codigo;
				Item.CHEQ_NroFinal = this.CHEQ_NroFinal;
				Item.CHEQ_NroInicial = this.CHEQ_NroInicial;
				Item.CHEQ_NroActual = this.CHEQ_NroActual;
				Item.CHEQ_Diferido = this.CHEQ_Diferido;
            Item.CHEQ_Coordenadas = this.CHEQ_Coordenadas;
            Item.CHEQ_Estado = this.CHEQ_Estado;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
