using System;
using System.ComponentModel;
using System.Linq;
using System.Web.UI.WebControls.WebParts;

namespace ListaEmpleados.BusquedaEmpleadosLinq
{
    [ToolboxItemAttribute(false)]
    public partial class BusquedaEmpleadosLinq : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public BusquedaEmpleadosLinq()
        {
        }
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            if (!Page.IsPostBack)
            {
                using (var ctx = new ModeloDataContext("http://localhost"))
                {

                    lstEmpleados.DataSource = ctx.ListaDeEmpleados;
                    lstEmpleados.DataBind();
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {


            using (var ctx = new ModeloDataContext("http://localhost"))
            {
                var s = Convert.ToInt32(txtSal.Text);
                var data = ctx.ListaDeEmpleados.Where(o => o.Salario >= s);


                lstEmpleados.DataSource = data;
                lstEmpleados.DataBind();

            }
        }
    }
}
