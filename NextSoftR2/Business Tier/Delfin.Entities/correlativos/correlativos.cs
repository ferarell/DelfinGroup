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
   public partial class correlativos : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private String m_corr_servername;
		private String m_corr_codcorr;
		private Int32 m_corr_ultnum;
		private String m_corr_usrmod;
		private Nullable<DateTime> m_corr_fecmod;
		private String m_corr_desc;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase correlativos.
		/// </summary>
		public correlativos()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CORR_ServerName.
		/// </summary>
		[DataMember]
		public String CORR_ServerName
		{
			get { return m_corr_servername; }
			set
			{
				if (m_corr_servername != value)
				{
					m_corr_servername = value;
					OnPropertyChanged("CORR_ServerName");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CORR_CodCorr.
		/// </summary>
		[DataMember]
		public String CORR_CodCorr
		{
			get { return m_corr_codcorr; }
			set
			{
				if (m_corr_codcorr != value)
				{
					m_corr_codcorr = value;
					OnPropertyChanged("CORR_CodCorr");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CORR_UltNum.
		/// </summary>
		[DataMember]
		public Int32 CORR_UltNum
		{
			get { return m_corr_ultnum; }
			set
			{
				if (m_corr_ultnum != value)
				{
					m_corr_ultnum = value;
					OnPropertyChanged("CORR_UltNum");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CORR_UsrMod.
		/// </summary>
		[DataMember]
		public String CORR_UsrMod
		{
			get { return m_corr_usrmod; }
			set
			{
				if (m_corr_usrmod != value)
				{
					m_corr_usrmod = value;
					OnPropertyChanged("CORR_UsrMod");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CORR_FecMod.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CORR_FecMod
		{
			get { return m_corr_fecmod; }
			set
			{
				if (m_corr_fecmod != value)
				{
					m_corr_fecmod = value;
					OnPropertyChanged("CORR_FecMod");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CORR_Desc.
		/// </summary>
		[DataMember]
		public String CORR_Desc
		{
			get { return m_corr_desc; }
			set
			{
				if (m_corr_desc != value)
				{
					m_corr_desc = value;
					OnPropertyChanged("CORR_Desc");
				}
			}
		}
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref correlativos Item)
		{
			try
			{
				if (Item == null) { Item = new correlativos(); }
				Item.CORR_ServerName = this.CORR_ServerName;
				Item.CORR_CodCorr = this.CORR_CodCorr;
				Item.CORR_UltNum = this.CORR_UltNum;
				Item.CORR_Desc = this.CORR_Desc;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
