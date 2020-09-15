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
	public partial class GRR_Contrato : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private String m_reba_tipo;
		private Int32 m_reba_codigo;
      private String m_cont_numero;
      private String m_cont_numeroequivalente;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase GRR_Contrato.
		/// </summary>
		public GRR_Contrato()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: REBA_Tipo.
		/// </summary>
		[DataMember]
		public String REBA_Tipo
		{
			get { return m_reba_tipo; }
			set
			{
				if (m_reba_tipo != value)
				{
					m_reba_tipo = value;
					OnPropertyChanged("REBA_Tipo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: REBA_Codigo.
		/// </summary>
		[DataMember]
		public Int32 REBA_Codigo
		{
			get { return m_reba_codigo; }
			set
			{
				if (m_reba_codigo != value)
				{
					m_reba_codigo = value;
					OnPropertyChanged("REBA_Codigo");
				}
			}
		}
		/// <summary>
      /// Gets or sets el valor de: CONT_Numero.
		/// </summary>
		[DataMember]
		public String CONT_Numero
		{
			get { return m_cont_numero; }
			set
			{
				if (m_cont_numero != value)
				{
					m_cont_numero = value;
               OnPropertyChanged("CONT_Numero");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: CONT_NumeroEquivalente.
      /// </summary>
      [DataMember]
      public String CONT_NumeroEquivalente
      {
         get { return m_cont_numeroequivalente; }
         set
         {
            if (m_cont_numeroequivalente != value)
            {
               m_cont_numeroequivalente = value;
               OnPropertyChanged("CONT_NumeroEquivalente");
            }
         }
      }
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref GRR_Contrato Item)
		{
			try
			{
				if (Item == null) { Item = new GRR_Contrato(); }
				Item.REBA_Tipo = this.REBA_Tipo;
				Item.REBA_Codigo = this.REBA_Codigo;
            Item.CONT_Numero = this.CONT_Numero;
            Item.CONT_NumeroEquivalente = this.CONT_NumeroEquivalente;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
