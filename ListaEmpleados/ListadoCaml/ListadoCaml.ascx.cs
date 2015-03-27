using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;

namespace ListaEmpleados.ListadoCaml
{
    [ToolboxItemAttribute(false)]
    public partial class ListadoCaml : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public ListadoCaml()
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
                using (var web = SPContext.Current.Web)
                {
                    var lista = web.Lists["Lista de empleados"];
                    var items = lista.GetItems();
                    lstEmpleados.DataSource = items.GetDataTable();
                    lstEmpleados.DataBind();
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
 var consulta = String.Format(@"<Where><Geq><FieldRef Name=""Salario"" />
                                            <Value Type=""Currency"">{0}</Value>
                                            </Geq></Where>", txtSal.Text);
            var query = new SPQuery();
            query.Query = consulta;

            using (var web = SPContext.Current.Web)
            {
                var lista = web.Lists["Lista de empleados"];
                var items = lista.GetItems(query);

                lstEmpleados.DataSource = items.GetDataTable();
                lstEmpleados.DataBind();

            }
        }
    }
}
