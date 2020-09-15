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
	public partial class Rebate
	{
		#region [ Variables ]
		Contrato m_itemContrato;
		ObservableCollection<Contrato> m_listContrato;
		Empresa m_itemEmpresa;
		ObservableCollection<Empresa> m_listEmpresa;
      DetRebate m_itemDetRebate;
      ObservableCollection<DetRebate> m_listDetRebate;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Contrato.
		/// </summary>
		[DataMember]
		public Contrato ItemContrato
		{
			get { return  m_itemContrato; }
			set {  m_itemContrato = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Contrato.
		/// </summary>
		[DataMember]
		public ObservableCollection<Contrato> ListContrato
		{
			get { return  m_listContrato; }
			set {  m_listContrato = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Empresa.
		/// </summary>
		[DataMember]
		public Empresa ItemEmpresa
		{
			get { return  m_itemEmpresa; }
			set {  m_itemEmpresa = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Empresa.
		/// </summary>
		[DataMember]
		public ObservableCollection<Empresa> ListEmpresa
		{
			get { return  m_listEmpresa; }
			set {  m_listEmpresa = value; }
		}
      /// <summary>
      /// Gets or sets el valor de: DetRebate.
      /// </summary>
      [DataMember]
      public DetRebate ItemDetRebate
      {
         get { return m_itemDetRebate; }
         set { m_itemDetRebate = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: DetRebate.
      /// </summary>
      [DataMember]
      public ObservableCollection<DetRebate> ListDetRebate
      {
         get {
            if (m_listDetRebate == null) { m_listDetRebate = new ObservableCollection<DetRebate>(); }
            return m_listDetRebate; 
         }
         set { m_listDetRebate = value; }
      }
		#endregion
	}
}
