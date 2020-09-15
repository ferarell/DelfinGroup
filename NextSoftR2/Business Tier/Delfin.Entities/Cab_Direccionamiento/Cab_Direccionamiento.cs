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
	public partial class Cab_Direccionamiento : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_cdir_codigo;
		private String m_cdir_hbl;
		private String m_cdir_mbl;
		private Nullable<DateTime> m_cdir_fecarribo;
		private String m_cdir_observaciones;
		private Nullable<Int32> m_entc_codcliente;
		private Nullable<Int32> m_entc_codlinea;
		private Nullable<Int32> m_entc_codtemporal;
		private Nullable<DateTime> m_cdir_fecemision;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
      private String m_cdir_viaje;
      private String m_cdir_nave;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Cab_Direccionamiento.
		/// </summary>
		public Cab_Direccionamiento()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CDIR_Codigo.
		/// </summary>
		[DataMember]
		public Int32 CDIR_Codigo
		{
			get { return m_cdir_codigo; }
			set
			{
				if (m_cdir_codigo != value)
				{
					m_cdir_codigo = value;
					OnPropertyChanged("CDIR_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CDIR_HBL.
		/// </summary>
		[DataMember]
		public String CDIR_HBL
		{
			get { return m_cdir_hbl; }
			set
			{
				if (m_cdir_hbl != value)
				{
					m_cdir_hbl = value;
					OnPropertyChanged("CDIR_HBL");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CDIR_MBL.
		/// </summary>
		[DataMember]
		public String CDIR_MBL
		{
			get { return m_cdir_mbl; }
			set
			{
				if (m_cdir_mbl != value)
				{
					m_cdir_mbl = value;
					OnPropertyChanged("CDIR_MBL");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CDIR_FecArribo.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CDIR_FecArribo
		{
			get { return m_cdir_fecarribo; }
			set
			{
				if (m_cdir_fecarribo != value)
				{
					m_cdir_fecarribo = value;
					OnPropertyChanged("CDIR_FecArribo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CDIR_Observaciones.
		/// </summary>
		[DataMember]
		public String CDIR_Observaciones
		{
			get { return m_cdir_observaciones; }
			set
			{
				if (m_cdir_observaciones != value)
				{
					m_cdir_observaciones = value;
					OnPropertyChanged("CDIR_Observaciones");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodCliente.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodCliente
		{
			get { return m_entc_codcliente; }
			set
			{
				if (m_entc_codcliente != value)
				{
					m_entc_codcliente = value;
					OnPropertyChanged("ENTC_CodCliente");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodLinea.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodLinea
		{
			get { return m_entc_codlinea; }
			set
			{
				if (m_entc_codlinea != value)
				{
					m_entc_codlinea = value;
					OnPropertyChanged("ENTC_CodLinea");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodTemporal.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodTemporal
		{
			get { return m_entc_codtemporal; }
			set
			{
				if (m_entc_codtemporal != value)
				{
					m_entc_codtemporal = value;
					OnPropertyChanged("ENTC_CodTemporal");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CDIR_FecEmision.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CDIR_FecEmision
		{
			get { return m_cdir_fecemision; }
			set
			{
				if (m_cdir_fecemision != value)
				{
					m_cdir_fecemision = value;
					OnPropertyChanged("CDIR_FecEmision");
				}
			}
		}
     
      /// <summary>
      /// Gets or sets el valor de: CDIR_Nave.
      /// </summary>
      [DataMember]
      public String CDIR_Nave
      {
         get { return m_cdir_nave; }
         set
         {
            if (m_cdir_nave != value)
            {
               m_cdir_nave = value;
               OnPropertyChanged("CDIR_Nave");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CDIR_Viaje.
      /// </summary>
      [DataMember]
      public String CDIR_Viaje
      {
         get { return m_cdir_viaje; }
         set
         {
            if (m_cdir_viaje != value)
            {
               m_cdir_viaje = value;
               OnPropertyChanged("CDIR_Viaje");
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
		public void CopyTo(ref Cab_Direccionamiento Item)
		{
			try
			{
				if (Item == null) { Item = new Cab_Direccionamiento(); }
				Item.CDIR_Codigo = this.CDIR_Codigo;
				Item.CDIR_HBL = this.CDIR_HBL;
				Item.CDIR_MBL = this.CDIR_MBL;
				Item.CDIR_FecArribo = this.CDIR_FecArribo;
				Item.CDIR_Observaciones = this.CDIR_Observaciones;
				Item.ENTC_CodCliente = this.ENTC_CodCliente;
				Item.ENTC_CodLinea = this.ENTC_CodLinea;
				Item.ENTC_CodTemporal = this.ENTC_CodTemporal;
				Item.CDIR_FecEmision = this.CDIR_FecEmision;
				Item.CDIR_Nave = this.CDIR_Nave;
            Item.CDIR_Viaje = this.CDIR_Viaje;  
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
