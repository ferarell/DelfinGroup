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
	public partial class Tarifa
	{
		#region [ Variables ]
		Contrato m_itemContrato;
		ObservableCollection<Contrato> m_listContrato;
		Paquete m_itemPaquete;
		ObservableCollection<Paquete> m_listPaquete;
		Empresa m_itemEmpresa;
		ObservableCollection<Empresa> m_listEmpresa;
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
		/// Gets or sets el valor de: Paquete.
		/// </summary>
		[DataMember]
		public Paquete ItemPaquete
		{
			get { return  m_itemPaquete; }
			set {  m_itemPaquete = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Paquete.
		/// </summary>
		[DataMember]
		public ObservableCollection<Paquete> ListPaquete
		{
			get { return  m_listPaquete; }
			set {  m_listPaquete = value; }
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
		#endregion
	}
}
