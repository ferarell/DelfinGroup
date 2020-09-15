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
   public partial class Tarifa : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_tari_codigo;
		private Nullable<Int16> m_empr_codigo;
		private Nullable<Decimal> m_tari_costo;
		private Nullable<Decimal> m_tari_profit1;
      private Nullable<Decimal> m_tari_profit2;
      private Nullable<Decimal> m_tari_profit3;
      private Nullable<Decimal> m_tari_profit4;
		private Nullable<Decimal> m_tari_pventa1;
		private Nullable<Decimal> m_tari_pventa2;
		private Nullable<Decimal> m_tari_pventa3;
		private Nullable<Decimal> m_tari_pventa4;
		private Nullable<Decimal> m_tari_peso;
		private Nullable<Decimal> m_tari_volum;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private Nullable<Int32> m_cont_codigo;
		private String m_cons_tabbas;
		private String m_cons_codbas;
      private Nullable<Int32> m_puer_codorigen;
      private Nullable<Int32> m_puer_coddestino;
		private Int32 m_pack_codigo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Tarifa.
		/// </summary>
		public Tarifa()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: TARI_Codigo.
		/// </summary>
		[DataMember]
      public Int32 TARI_Codigo
		{
			get { return m_tari_codigo; }
			set
			{
				if (m_tari_codigo != value)
				{
					m_tari_codigo = value;
					OnPropertyChanged("TARI_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EMPR_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> EMPR_Codigo
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
		/// Gets or sets el valor de: TARI_Costo.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> TARI_Costo
		{
			get { return m_tari_costo; }
			set
			{
				if (m_tari_costo != value)
				{
					m_tari_costo = value;

               if (m_tari_costo.HasValue)
               {
                  if (!TARI_Profit1.HasValue)
                  {
                     TARI_Profit1 = 0;
                     TARI_PVenta1 = m_tari_costo + TARI_Profit1;
                  }
                  if (!TARI_Profit2.HasValue)
                  {
                     TARI_Profit2 = 0;
                     TARI_PVenta2 = m_tari_costo + TARI_Profit2;
                  }
                  if (!TARI_Profit3.HasValue)
                  {
                     TARI_Profit3 = 0;
                     TARI_PVenta3 = m_tari_costo + TARI_Profit3;
                  }
                  if (!TARI_Profit4.HasValue)
                  {
                     TARI_Profit4 = 0;
                     TARI_PVenta4 = m_tari_costo + TARI_Profit4;
                  }
               }

					OnPropertyChanged("TARI_Costo");
				}
			}
		}
		/// <summary>
      /// Gets or sets el valor de: TARI_Profit1.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> TARI_Profit1
		{
			get { return m_tari_profit1; }
			set
			{
				if (m_tari_profit1 != value)
				{
					m_tari_profit1 = value;
               OnPropertyChanged("TARI_Profit1");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: TARI_Profit2.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> TARI_Profit2
      {
         get { return m_tari_profit2; }
         set
         {
            if (m_tari_profit2 != value)
            {
               m_tari_profit2 = value;
               OnPropertyChanged("TARI_Profit2");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TARI_Profit3.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> TARI_Profit3
      {
         get { return m_tari_profit3; }
         set
         {
            if (m_tari_profit3 != value)
            {
               m_tari_profit3 = value;
               OnPropertyChanged("TARI_Profit3");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TARI_Profit4.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> TARI_Profit4
      {
         get { return m_tari_profit4; }
         set
         {
            if (m_tari_profit4 != value)
            {
               m_tari_profit4 = value;
               OnPropertyChanged("TARI_Profit4");
            }
         }
      }
		/// <summary>
		/// Gets or sets el valor de: TARI_PVenta1.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> TARI_PVenta1
		{
			get { return m_tari_pventa1; }
			set
			{
				if (m_tari_pventa1 != value)
				{
					m_tari_pventa1 = value;
					OnPropertyChanged("TARI_PVenta1");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TARI_PVenta2.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> TARI_PVenta2
		{
			get { return m_tari_pventa2; }
			set
			{
				if (m_tari_pventa2 != value)
				{
					m_tari_pventa2 = value;
					OnPropertyChanged("TARI_PVenta2");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TARI_PVenta3.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> TARI_PVenta3
		{
			get { return m_tari_pventa3; }
			set
			{
				if (m_tari_pventa3 != value)
				{
					m_tari_pventa3 = value;
					OnPropertyChanged("TARI_PVenta3");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TARI_PVenta4.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> TARI_PVenta4
		{
			get { return m_tari_pventa4; }
			set
			{
				if (m_tari_pventa4 != value)
				{
					m_tari_pventa4 = value;
					OnPropertyChanged("TARI_PVenta4");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TARI_Peso.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> TARI_Peso
		{
			get { return m_tari_peso; }
			set
			{
				if (m_tari_peso != value)
				{
					m_tari_peso = value;
					OnPropertyChanged("TARI_Peso");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TARI_Volum.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> TARI_Volum
		{
			get { return m_tari_volum; }
			set
			{
				if (m_tari_volum != value)
				{
					m_tari_volum = value;
					OnPropertyChanged("TARI_Volum");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabMnd.
		/// </summary>
		[DataMember]
		public String TIPO_TabMnd
		{
			get { return m_tipo_tabmnd; }
			set
			{
				if (m_tipo_tabmnd != value)
				{
					m_tipo_tabmnd = value;
					OnPropertyChanged("TIPO_TabMnd");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodMnd.
		/// </summary>
		[DataMember]
		public String TIPO_CodMnd
		{
			get { return m_tipo_codmnd; }
			set
			{
				if (m_tipo_codmnd != value)
				{
					m_tipo_codmnd = value;
					OnPropertyChanged("TIPO_CodMnd");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONT_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CONT_Codigo
		{
			get { return m_cont_codigo; }
			set
			{
				if (m_cont_codigo != value)
				{
					m_cont_codigo = value;
					OnPropertyChanged("CONT_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabBas.
		/// </summary>
		[DataMember]
		public String CONS_TabBas
		{
			get { return m_cons_tabbas; }
			set
			{
				if (m_cons_tabbas != value)
				{
					m_cons_tabbas = value;
					OnPropertyChanged("CONS_TabBas");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodBas.
		/// </summary>
		[DataMember]
		public String CONS_CodBas
		{
			get { return m_cons_codbas; }
			set
			{
				if (m_cons_codbas != value)
				{
					m_cons_codbas = value;
					OnPropertyChanged("CONS_CodBas");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PUER_CodOrigen.
		/// </summary>
		[DataMember]
		public Nullable<Int32> PUER_CodOrigen
		{
			get { return m_puer_codorigen; }
			set
			{
				if (m_puer_codorigen != value)
				{
					m_puer_codorigen = value;
					OnPropertyChanged("PUER_CodOrigen");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PUER_CodDestino.
		/// </summary>
		[DataMember]
      public Nullable<Int32> PUER_CodDestino
		{
			get { return m_puer_coddestino; }
			set
			{
				if (m_puer_coddestino != value)
				{
					m_puer_coddestino = value;
					OnPropertyChanged("PUER_CodDestino");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public Int32 PACK_Codigo
		{
			get { return m_pack_codigo; }
			set
			{
				if (m_pack_codigo != value)
				{
					m_pack_codigo = value;
					OnPropertyChanged("PACK_Codigo");
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
		public void CopyTo(ref Tarifa Item)
		{
			try
			{
				if (Item == null) { Item = new Tarifa(); }
				Item.TARI_Codigo = this.TARI_Codigo;
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.TARI_Costo = this.TARI_Costo;
				Item.TARI_Profit1 = this.TARI_Profit1;
            Item.TARI_Profit2 = this.TARI_Profit2;
            Item.TARI_Profit3 = this.TARI_Profit3;
            Item.TARI_Profit4 = this.TARI_Profit4;
				Item.TARI_PVenta1 = this.TARI_PVenta1;
				Item.TARI_PVenta2 = this.TARI_PVenta2;
				Item.TARI_PVenta3 = this.TARI_PVenta3;
				Item.TARI_PVenta4 = this.TARI_PVenta4;
				Item.TARI_Peso = this.TARI_Peso;
				Item.TARI_Volum = this.TARI_Volum;
				Item.TIPO_TabMnd = this.TIPO_TabMnd;
				Item.TIPO_CodMnd = this.TIPO_CodMnd;
				Item.CONT_Codigo = this.CONT_Codigo;
				Item.CONS_TabBas = this.CONS_TabBas;
				Item.CONS_CodBas = this.CONS_CodBas;
				Item.PUER_CodOrigen = this.PUER_CodOrigen;
				Item.PUER_CodDestino = this.PUER_CodDestino;
				Item.PACK_Codigo = this.PACK_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
