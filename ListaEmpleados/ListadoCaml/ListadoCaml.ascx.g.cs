﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListaEmpleados.ListadoCaml {
    using System.Web.UI.WebControls.Expressions;
    using System.Web.UI.HtmlControls;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebPartPages;
    using System.Web.SessionState;
    using System.Configuration;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using Microsoft.SharePoint.WebControls;
    using System.CodeDom.Compiler;
    
    
    public partial class ListadoCaml {
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        protected global::System.Web.UI.WebControls.Label lblSalario;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        protected global::System.Web.UI.WebControls.TextBox txtSal;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        protected global::System.Web.UI.WebControls.Button btnBuscar;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        protected global::System.Web.UI.WebControls.ListView lstEmpleados;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebPartCodeGenerator", "12.0.0.0")]
        public static implicit operator global::System.Web.UI.TemplateControl(ListadoCaml target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControllblSalario() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblSalario = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblSalario";
            @__ctrl.Text = "Salario:";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.WebControls.TextBox @__BuildControltxtSal() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.txtSal = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "txtSal";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.WebControls.Button @__BuildControlbtnBuscar() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.btnBuscar = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "btnBuscar";
            @__ctrl.Text = "Buscar";
            @__ctrl.Click -= new System.EventHandler(this.btnBuscar_Click1);
            @__ctrl.Click += new System.EventHandler(this.btnBuscar_Click1);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlTableCell @__BuildControl__control7() {
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTableCell("th");
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("DNI"));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlTableCell @__BuildControl__control8() {
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTableCell("th");
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("Nombre"));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlTableCell @__BuildControl__control9() {
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTableCell("th");
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("Puesto"));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlTableCell @__BuildControl__control10() {
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTableCell("th");
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("Fecha de alta"));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private void @__BuildControl__control6(System.Web.UI.HtmlControls.HtmlTableCellCollection @__ctrl) {
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control7();
            @__ctrl.Add(@__ctrl1);
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl2;
            @__ctrl2 = this.@__BuildControl__control8();
            @__ctrl.Add(@__ctrl2);
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl3;
            @__ctrl3 = this.@__BuildControl__control9();
            @__ctrl.Add(@__ctrl3);
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl4;
            @__ctrl4 = this.@__BuildControl__control10();
            @__ctrl.Add(@__ctrl4);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlTableRow @__BuildControl__control5() {
            global::System.Web.UI.HtmlControls.HtmlTableRow @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTableRow();
            this.@__BuildControl__control6(@__ctrl.Cells);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlTableRow @__BuildControl__control11() {
            global::System.Web.UI.HtmlControls.HtmlTableRow @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTableRow();
            @__ctrl.ID = "itemPlaceHolder";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private void @__BuildControl__control4(System.Web.UI.HtmlControls.HtmlTableRowCollection @__ctrl) {
            global::System.Web.UI.HtmlControls.HtmlTableRow @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control5();
            @__ctrl.Add(@__ctrl1);
            global::System.Web.UI.HtmlControls.HtmlTableRow @__ctrl2;
            @__ctrl2 = this.@__BuildControl__control11();
            @__ctrl.Add(@__ctrl2);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlTable @__BuildControl__control3() {
            global::System.Web.UI.HtmlControls.HtmlTable @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTable();
            @__ctrl.TemplateControl = this;
            @__ctrl.ID = "tblDatos";
            this.@__BuildControl__control4(@__ctrl.Rows);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private void @__BuildControl__control2(System.Web.UI.Control @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n     "));
            global::System.Web.UI.HtmlControls.HtmlTable @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control3();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("   \r\n    "));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControl__control16() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.DataBinding += new System.EventHandler(this.@__DataBinding__control16);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        public void @__DataBinding__control16(object sender, System.EventArgs e) {
            System.Web.UI.WebControls.Label dataBindingExpressionBuilderTarget;
            System.Web.UI.WebControls.ListViewDataItem Container;
            dataBindingExpressionBuilderTarget = ((System.Web.UI.WebControls.Label)(sender));
            Container = ((System.Web.UI.WebControls.ListViewDataItem)(dataBindingExpressionBuilderTarget.BindingContainer));
            dataBindingExpressionBuilderTarget.Text = global::System.Convert.ToString( Eval("Title") , global::System.Globalization.CultureInfo.CurrentCulture);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlTableCell @__BuildControl__control15() {
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTableCell("td");
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                "));
            global::System.Web.UI.WebControls.Label @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control16();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            "));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControl__control18() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.DataBinding += new System.EventHandler(this.@__DataBinding__control18);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        public void @__DataBinding__control18(object sender, System.EventArgs e) {
            System.Web.UI.WebControls.Label dataBindingExpressionBuilderTarget;
            System.Web.UI.WebControls.ListViewDataItem Container;
            dataBindingExpressionBuilderTarget = ((System.Web.UI.WebControls.Label)(sender));
            Container = ((System.Web.UI.WebControls.ListViewDataItem)(dataBindingExpressionBuilderTarget.BindingContainer));
            dataBindingExpressionBuilderTarget.Text = global::System.Convert.ToString( Eval("_x0062_183") , global::System.Globalization.CultureInfo.CurrentCulture);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlTableCell @__BuildControl__control17() {
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTableCell("td");
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                "));
            global::System.Web.UI.WebControls.Label @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control18();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            "));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControl__control20() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.DataBinding += new System.EventHandler(this.@__DataBinding__control20);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        public void @__DataBinding__control20(object sender, System.EventArgs e) {
            System.Web.UI.WebControls.Label dataBindingExpressionBuilderTarget;
            System.Web.UI.WebControls.ListViewDataItem Container;
            dataBindingExpressionBuilderTarget = ((System.Web.UI.WebControls.Label)(sender));
            Container = ((System.Web.UI.WebControls.ListViewDataItem)(dataBindingExpressionBuilderTarget.BindingContainer));
            dataBindingExpressionBuilderTarget.Text = global::System.Convert.ToString( Eval("edyu") , global::System.Globalization.CultureInfo.CurrentCulture);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlTableCell @__BuildControl__control19() {
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTableCell("td");
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                "));
            global::System.Web.UI.WebControls.Label @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control20();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            "));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControl__control22() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.DataBinding += new System.EventHandler(this.@__DataBinding__control22);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        public void @__DataBinding__control22(object sender, System.EventArgs e) {
            System.Web.UI.WebControls.Label dataBindingExpressionBuilderTarget;
            System.Web.UI.WebControls.ListViewDataItem Container;
            dataBindingExpressionBuilderTarget = ((System.Web.UI.WebControls.Label)(sender));
            Container = ((System.Web.UI.WebControls.ListViewDataItem)(dataBindingExpressionBuilderTarget.BindingContainer));
            dataBindingExpressionBuilderTarget.Text = global::System.Convert.ToString( Eval("s2z3") , global::System.Globalization.CultureInfo.CurrentCulture);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlTableCell @__BuildControl__control21() {
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTableCell("td");
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                "));
            global::System.Web.UI.WebControls.Label @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control22();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            "));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private void @__BuildControl__control14(System.Web.UI.HtmlControls.HtmlTableCellCollection @__ctrl) {
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control15();
            @__ctrl.Add(@__ctrl1);
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl2;
            @__ctrl2 = this.@__BuildControl__control17();
            @__ctrl.Add(@__ctrl2);
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl3;
            @__ctrl3 = this.@__BuildControl__control19();
            @__ctrl.Add(@__ctrl3);
            global::System.Web.UI.HtmlControls.HtmlTableCell @__ctrl4;
            @__ctrl4 = this.@__BuildControl__control21();
            @__ctrl.Add(@__ctrl4);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlTableRow @__BuildControl__control13() {
            global::System.Web.UI.HtmlControls.HtmlTableRow @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTableRow();
            @__ctrl.TemplateControl = this;
            this.@__BuildControl__control14(@__ctrl.Cells);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private void @__BuildControl__control12(System.Web.UI.Control @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        "));
            global::System.Web.UI.HtmlControls.HtmlTableRow @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control13();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    "));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private global::System.Web.UI.WebControls.ListView @__BuildControllstEmpleados() {
            global::System.Web.UI.WebControls.ListView @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListView();
            this.lstEmpleados = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.LayoutTemplate = new System.Web.UI.CompiledTemplateBuilder(new System.Web.UI.BuildTemplateMethod(this.@__BuildControl__control2));
            @__ctrl.ItemTemplate = new System.Web.UI.CompiledBindableTemplateBuilder(new System.Web.UI.BuildTemplateMethod(this.@__BuildControl__control12), null);
            @__ctrl.ID = "lstEmpleados";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private void @__BuildControlTree(global::ListaEmpleados.ListadoCaml.ListadoCaml @__ctrl) {
            global::System.Web.UI.WebControls.Label @__ctrl1;
            @__ctrl1 = this.@__BuildControllblSalario();
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n"));
            global::System.Web.UI.WebControls.TextBox @__ctrl2;
            @__ctrl2 = this.@__BuildControltxtSal();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n"));
            global::System.Web.UI.WebControls.Button @__ctrl3;
            @__ctrl3 = this.@__BuildControlbtnBuscar();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n"));
            global::System.Web.UI.WebControls.ListView @__ctrl4;
            @__ctrl4 = this.@__BuildControllstEmpleados();
            @__parser.AddParsedSubObject(@__ctrl4);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\r\n"));
        }
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "12.0.0.0")]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
