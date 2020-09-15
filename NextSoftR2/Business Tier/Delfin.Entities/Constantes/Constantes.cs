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
   public partial class Constantes : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private String m_cons_codtabla;
		private String m_cons_codtipo;
		private String m_cons_desc_spa;
		private String m_cons_desc_eng;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Constantes.
		/// </summary>
		public Constantes()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CONS_CodTabla.
		/// </summary>
		[DataMember]
		public String CONS_CodTabla
		{
			get { return m_cons_codtabla; }
			set
			{
				if (m_cons_codtabla != value)
				{
					m_cons_codtabla = value;
					OnPropertyChanged("CONS_CodTabla");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodTipo.
		/// </summary>
        [DataMember]
        public String CONS_CodTipo
        {
            get { return m_cons_codtipo; }
            set
            {
                if (m_cons_codtipo != value)
                {
                    m_cons_codtipo = value;
                    OnPropertyChanged("CONS_CodTipo");
                }
            }
        }
		/// <summary>
		/// Gets or sets el valor de: CONS_Desc_SPA.
		/// </summary>
		[DataMember]
		public String CONS_Desc_SPA
		{
			get { return m_cons_desc_spa; }
			set
			{
				if (m_cons_desc_spa != value)
				{
					m_cons_desc_spa = value;
					OnPropertyChanged("CONS_Desc_SPA");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_Desc_ENG.
		/// </summary>
		[DataMember]
		public String CONS_Desc_ENG
		{
			get { return m_cons_desc_eng; }
			set
			{
				if (m_cons_desc_eng != value)
				{
					m_cons_desc_eng = value;
					OnPropertyChanged("CONS_Desc_ENG");
				}
			}
		}
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Constantes Item)
		{
			try
			{
				if (Item == null) { Item = new Constantes(); }
				Item.CONS_CodTabla = this.CONS_CodTabla;
				Item.CONS_CodTipo = this.CONS_CodTipo;
				Item.CONS_Desc_SPA = this.CONS_Desc_SPA;
				Item.CONS_Desc_ENG = this.CONS_Desc_ENG;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

        //public void set_CONS_CodTipo(string p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
