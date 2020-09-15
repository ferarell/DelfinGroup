using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Delfin.Principal.Mantenimientos.MAN009Entidad
{
    public partial class MAN009ViewTipoSocio : DevExpress.XtraEditors.XtraForm
    {
        //public MAN009LView oMAN009LView { get; set; }
        public String _TipoSocio = "";
        
        public MAN009ViewTipoSocio()
        {
            InitializeComponent();            
        }
        
        private void btnCliente_Click(object sender, EventArgs e)
        {
            _TipoSocio = "C";
            this.Close();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            _TipoSocio = "P";
            this.Close();
        }
    }
}