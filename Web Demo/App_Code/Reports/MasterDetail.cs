using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Base.Drawing;

namespace Reports
{
    
	public class MasterDetail : Stimulsoft.Report.StiReport
    {
        
		public MasterDetail()
        {
            this.InitializeComponent();
        }
        
        #region StiReport Designer generated code - do not modify
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentSuppliers;
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentCategories;
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentEmployees1;
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentShippers;
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentCustomers;
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentOrders;
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentProducts;
        public Stimulsoft.Report.Dictionary.StiDataRelation ParentEmployees;
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Components.StiPageFooterBand PageFooterBand1;
        public Stimulsoft.Report.Components.StiText Text7;
        public Stimulsoft.Report.Components.StiText Text8;
        public Stimulsoft.Report.Components.StiReportTitleBand ReportTitleBand1;
        public Stimulsoft.Report.Components.StiText Text5;
        public Stimulsoft.Report.Components.StiDataBand DataBand1;
        public Stimulsoft.Report.Components.StiText Text17;
        public Stimulsoft.Report.Components.StiText Text18;
        public Stimulsoft.Report.Components.StiDataBand DataBand2;
        public Stimulsoft.Report.Components.StiText Text1;
        public Stimulsoft.Report.Components.StiText Text2;
        public Stimulsoft.Report.Components.StiText Text3;
        public Stimulsoft.Report.Components.StiText Text4;
        public Stimulsoft.Report.Components.StiFooterBand FooterBand1;
        public Stimulsoft.Report.Components.StiText Text6;
        public Stimulsoft.Report.Dictionary.StiCountFunctionService Text6_Count;
        private CategoriesDataSource Categories;
        private CustomersDataSource Customers;
        private EmployeesDataSource Employees;
        private Order_DetailsDataSource Order_Details;
        private OrdersDataSource Orders;
        private ProductsDataSource Products;
        private ShippersDataSource Shippers;
        private SuppliersDataSource Suppliers;
        private CountriesDataSource Countries;
        
        public void Text7__GetHyperlink(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = "http://www.stimulsoft.com";
        }
        
        public void Text7__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "(c) 2004 Stimulsoft";
        }
        
        public void Text8__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "";
            e.StoreToPrinted = true;
        }
        
        public System.String Text8_GetValue_End(Stimulsoft.Report.Components.StiComponent component)
        {
            return (PageNofM).ToString();
        }
        
        public void Text5__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "Master-Detail";
        }
        
        public void DataBand1__GetBookmark(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = (Categories.CategoryName).ToString();
        }
        
        public void Text17__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = (Categories.CategoryName).ToString();
        }
        
        public void Text18__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = (Categories.Description).ToString();
        }
        
        public void DataBand2__GetBookmark(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            e.Value = (Products.ProductName).ToString();
        }
        
        private void Text1_HightLight(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            if ((Line & 1) == 1)
            {
                ((Stimulsoft.Report.Components.IStiTextBrush)(sender)).TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
                ((Stimulsoft.Report.Components.IStiBrush)(sender)).Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.PapayaWhip);
                ((Stimulsoft.Report.Components.IStiFont)(sender)).Font = new System.Drawing.Font("Arial", 10F);
            }
        }
        
        public void Text1__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = (Line).ToString() + "." + (Products.ProductName).ToString();
        }
        
        private void Text2_HightLight(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            if ((Line & 1) == 1)
            {
                ((Stimulsoft.Report.Components.IStiTextBrush)(sender)).TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
                ((Stimulsoft.Report.Components.IStiBrush)(sender)).Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.PapayaWhip);
                ((Stimulsoft.Report.Components.IStiFont)(sender)).Font = new System.Drawing.Font("Arial", 10F);
            }
        }
        
        public void Text2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text2.TextFormat.Format(Products.QuantityPerUnit);
        }
        
        private void Text3_HightLight(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            if ((Line & 1) == 1)
            {
                ((Stimulsoft.Report.Components.IStiTextBrush)(sender)).TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
                ((Stimulsoft.Report.Components.IStiBrush)(sender)).Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.PapayaWhip);
                ((Stimulsoft.Report.Components.IStiFont)(sender)).Font = new System.Drawing.Font("Arial", 10F);
            }
        }
        
        public void Text3__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text3.TextFormat.Format(Products.UnitPrice);
        }
        
        private void Text4_HightLight(object sender, Stimulsoft.Report.Events.StiValueEventArgs e)
        {
            if ((Line & 1) == 1)
            {
                ((Stimulsoft.Report.Components.IStiTextBrush)(sender)).TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
                ((Stimulsoft.Report.Components.IStiBrush)(sender)).Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.PapayaWhip);
                ((Stimulsoft.Report.Components.IStiFont)(sender)).Font = new System.Drawing.Font("Arial", 10F);
            }
        }
        
        public void Text4__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Text4.TextFormat.Format(Products.UnitsInStock);
        }
        
        public void Text6__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "";
            e.StoreToPrinted = true;
        }
        
        public System.String Text6_GetValue_End(Stimulsoft.Report.Components.StiComponent component)
        {
            return (((long)(this.Text6_Count.GetValue()))).ToString();
        }
        
        public void DataBand2__BeginRender(object sender, System.EventArgs e)
        {
            this.Text6_Count.Init();
            this.Text6.TextValue = "";
        }
        
        public void DataBand2__EndRender(object sender, System.EventArgs e)
        {
            this.Text6.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text6_GetValue_End));
        }
        
        public void DataBand2__Rendering(object sender, System.EventArgs e)
        {
            this.Text6_Count.CalcItem(null);
        }
        
        public void Report__EndRender(object sender, System.EventArgs e)
        {
            this.Text8.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text8_GetValue_End));
        }
        
        public void InitializeComponent()
        {
            this.Countries = new CountriesDataSource();
            this.Suppliers = new SuppliersDataSource();
            this.Shippers = new ShippersDataSource();
            this.Products = new ProductsDataSource();
            this.Orders = new OrdersDataSource();
            this.Order_Details = new Order_DetailsDataSource();
            this.Employees = new EmployeesDataSource();
            this.Customers = new CustomersDataSource();
            this.Categories = new CategoriesDataSource();
            this.ParentSuppliers = new Stimulsoft.Report.Dictionary.StiDataRelation("SuppliersProducts", "Suppliers", "Suppliers", this.Suppliers, this.Products, new System.String[] {
                        "SupplierID"}, new System.String[] {
                        "SupplierID"});
            this.ParentCategories = new Stimulsoft.Report.Dictionary.StiDataRelation("CategoriesProducts", "Categories", "Categories", this.Categories, this.Products, new System.String[] {
                        "CategoryID"}, new System.String[] {
                        "CategoryID"});
            this.ParentEmployees1 = new Stimulsoft.Report.Dictionary.StiDataRelation("EmployeesOrders", "Employees", "Employees", this.Employees, this.Orders, new System.String[] {
                        "EmployeeID"}, new System.String[] {
                        "EmployeeID"});
            this.ParentShippers = new Stimulsoft.Report.Dictionary.StiDataRelation("ShippersOrders", "Shippers", "Shippers", this.Shippers, this.Orders, new System.String[] {
                        "ShipperID"}, new System.String[] {
                        "ShipVia"});
            this.ParentCustomers = new Stimulsoft.Report.Dictionary.StiDataRelation("CustomersOrders", "Customers", "Customers", this.Customers, this.Orders, new System.String[] {
                        "CustomerID"}, new System.String[] {
                        "CustomerID"});
            this.ParentOrders = new Stimulsoft.Report.Dictionary.StiDataRelation("OrdersOrder_Details", "Orders", "Orders", this.Orders, this.Order_Details, new System.String[] {
                        "OrderID"}, new System.String[] {
                        "OrderID"});
            this.ParentProducts = new Stimulsoft.Report.Dictionary.StiDataRelation("ProductsOrder_Details", "Products", "Products", this.Products, this.Order_Details, new System.String[] {
                        "ProductID"}, new System.String[] {
                        "ProductID"});
            this.ParentEmployees = new Stimulsoft.Report.Dictionary.StiDataRelation("EmployeesEmployees", "Employees", "Employees", this.Employees, this.Employees, new System.String[] {
                        "EmployeeID"}, new System.String[] {
                        "ReportsTo"});
            this.NeedsCompiling = false;
            this.Text6_Count = new Stimulsoft.Report.Dictionary.StiCountFunctionService();
            this.ReferencedAssemblies = new System.String[] {
                    "System.Dll",
                    "System.Drawing.Dll",
                    "System.Windows.Forms.Dll",
                    "System.Data.Dll",
                    "System.Xml.Dll",
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Report.Dll"};
            this.ReportAlias = "Master-Detail";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new System.DateTime(2005, 12, 26, 16, 40, 0, 0);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new System.DateTime(2004, 5, 29, 10, 59, 0, 0);
            this.ReportName = "Report";
            this.ReportVersion = "1.50";
			this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.Name = "Page1";
            this.Page1.PageHeight = 29.7;
            this.Page1.PageWidth = 21;
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            // 
            // PageFooterBand1
            // 
            this.PageFooterBand1 = new Stimulsoft.Report.Components.StiPageFooterBand();
            this.PageFooterBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 26.9, 19, 0.8);
            this.PageFooterBand1.DockStyle = StiDockStyle.Bottom;
            this.PageFooterBand1.Name = "PageFooterBand1";
            // 
            // Text7
            // 
            this.Text7 = new Stimulsoft.Report.Components.StiText();
            this.Text7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 4.8, 0.8);
            this.Text7.DockStyle = StiDockStyle.Left;
            this.Text7.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text7.GetHyperlink += new Stimulsoft.Report.Events.StiValueEventHandler(this.Text7__GetHyperlink);
            this.Text7.Name = "Text7";
            this.Text7.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text7__GetValue);
            this.Text7.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Top, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text7.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SaddleBrown);
            this.Text7.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiGeneralFormatService();
            this.Text7.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text8
            // 
            this.Text8 = new Stimulsoft.Report.Components.StiText();
            this.Text8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.8, 0, 14.2, 0.8);
            this.Text8.DockStyle = StiDockStyle.Right;
            this.Text8.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text8.Name = "Text8";
            this.Text8.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text8__GetValue);
            this.Text8.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text8.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.Top, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text8.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text8.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SaddleBrown);
            this.Text8.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiGeneralFormatService();
            this.Text8.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // ReportTitleBand1
            // 
            this.ReportTitleBand1 = new Stimulsoft.Report.Components.StiReportTitleBand();
            this.ReportTitleBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 19, 1.4);
            this.ReportTitleBand1.DockStyle = StiDockStyle.Top;
            this.ReportTitleBand1.Name = "ReportTitleBand1";
            // 
            // Text5
            // 
            this.Text5 = new Stimulsoft.Report.Components.StiText();
            this.Text5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 19, 1.4);
            this.Text5.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text5.Name = "Text5";
            this.Text5.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text5__GetValue);
            this.Text5.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text5.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.Text5.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SaddleBrown);
            this.Text5.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiGeneralFormatService();
            this.Text5.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // DataBand1
            // 
            this.DataBand1 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand1.GetBookmark += new Stimulsoft.Report.Events.StiValueEventHandler(this.DataBand1__GetBookmark);
            this.DataBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 2.6, 19, 1.4);
            this.DataBand1.DataRelationName = "";
            this.DataBand1.DataSourceName = "Categories";
            this.DataBand1.DockStyle = StiDockStyle.Top;
            this.DataBand1.KeepChildTogether = true;
            this.DataBand1.Name = "DataBand1";
            this.DataBand1.Sort = new System.String[] {
                    "ASC",
                    "CategoryName"};
            // 
            // Text17
            // 
            this.Text17 = new Stimulsoft.Report.Components.StiText();
            this.Text17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 19, 0.6);
            this.Text17.Name = "Text17";
            this.Text17.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text17__GetValue);
            this.Text17.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Text17.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text17.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SaddleBrown);
            this.Text17.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiGeneralFormatService();
            this.Text17.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text18
            // 
            this.Text18 = new Stimulsoft.Report.Components.StiText();
            this.Text18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.6, 19, 0.8);
            this.Text18.Name = "Text18";
            this.Text18.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text18__GetValue);
            this.Text18.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Text18.Font = new System.Drawing.Font("Arial", 14F);
            this.Text18.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SaddleBrown);
            this.Text18.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiGeneralFormatService();
            this.Text18.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataBand1.MasterComponent = null;
            // 
            // DataBand2
            // 
            this.DataBand2 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand2.GetBookmark += new Stimulsoft.Report.Events.StiValueEventHandler(this.DataBand2__GetBookmark);
            this.DataBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 4.8, 19, 0.6);
            this.DataBand2.DataRelationName = "CategoriesProducts";
            this.DataBand2.DataSourceName = "Products";
            this.DataBand2.DockStyle = StiDockStyle.Top;
            this.DataBand2.KeepChildTogether = true;
            this.DataBand2.Name = "DataBand2";
            this.DataBand2.Sort = new System.String[] {
                    "ASC",
                    "ProductName"};
            // 
            // Text1
            // 
            this.Text1 = new Stimulsoft.Report.Components.StiText();
            this.Text1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 6.8, 0.6);
            this.Text1.TextProcess += new Stimulsoft.Report.Events.StiValueEventHandler(this.Text1_HightLight);
            this.Text1.Name = "Text1";
            this.Text1.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text1__GetValue);
            this.Text1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text1.Font = new System.Drawing.Font("Arial", 10F);
            this.Text1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text1.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiGeneralFormatService();
            this.Text1.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text2
            // 
            this.Text2 = new Stimulsoft.Report.Components.StiText();
            this.Text2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.8, 0, 5.2, 0.6);
            this.Text2.TextProcess += new Stimulsoft.Report.Events.StiValueEventHandler(this.Text2_HightLight);
            this.Text2.Name = "Text2";
            this.Text2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text2__GetValue);
            this.Text2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text2.Font = new System.Drawing.Font("Arial", 10F);
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text2.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ".", 2, ",", 3, true, true, " ");
            this.Text2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text3
            // 
            this.Text3 = new Stimulsoft.Report.Components.StiText();
            this.Text3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(12, 0, 3, 0.6);
            this.Text3.TextProcess += new Stimulsoft.Report.Events.StiValueEventHandler(this.Text3_HightLight);
            this.Text3.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text3.Name = "Text3";
            this.Text3.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text3__GetValue);
            this.Text3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text3.Font = new System.Drawing.Font("Arial", 10F);
            this.Text3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text3.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiCurrencyFormatService(0, 0, ".", 2, ",", 3, "$", true, true, " ");
            this.Text3.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text4
            // 
            this.Text4 = new Stimulsoft.Report.Components.StiText();
            this.Text4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(15, 0, 4, 0.6);
            this.Text4.TextProcess += new Stimulsoft.Report.Events.StiValueEventHandler(this.Text4_HightLight);
            this.Text4.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text4.Name = "Text4";
            this.Text4.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text4__GetValue);
            this.Text4.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text4.Font = new System.Drawing.Font("Arial", 10F);
            this.Text4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text4.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiNumberFormatService(1, ".", 2, ",", 3, true, true, " ");
            this.Text4.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // FooterBand1
            // 
            this.FooterBand1 = new Stimulsoft.Report.Components.StiFooterBand();
            this.FooterBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 6.2, 19, 1);
            this.FooterBand1.DockStyle = StiDockStyle.Top;
            this.FooterBand1.Name = "FooterBand1";
            // 
            // Text6
            // 
            this.Text6 = new Stimulsoft.Report.Components.StiText();
            this.Text6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 19, 0.6);
            this.Text6.Name = "Text6";
            // 
            // Text6_Count
            // 
            this.Text6.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text6__GetValue);
            this.Text6.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Wheat);
            this.Text6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Text6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SaddleBrown);
            this.Text6.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiGeneralFormatService();
            this.Text6.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(1, 1, 1, 1);
            this.Page1.ReportUnit = null;
            this.ReportAuthor = null;
            this.ReportDescription = null;
            this.Page1.Page = Page1;
            this.Page1.Report = this;
            this.PageFooterBand1.Page = Page1;
            this.PageFooterBand1.Parent = Page1;
            this.Text7.Page = Page1;
            this.Text7.Parent = PageFooterBand1;
            this.Text8.Page = Page1;
            this.Text8.Parent = PageFooterBand1;
            this.ReportTitleBand1.Page = Page1;
            this.ReportTitleBand1.Parent = Page1;
            this.Text5.Page = Page1;
            this.Text5.Parent = ReportTitleBand1;
            this.DataBand1.Page = Page1;
            this.DataBand1.Parent = Page1;
            this.Text17.Page = Page1;
            this.Text17.Parent = DataBand1;
            this.Text18.Page = Page1;
            this.Text18.Parent = DataBand1;
            this.DataBand2.MasterComponent = DataBand1;
            this.DataBand2.Page = Page1;
            this.DataBand2.Parent = Page1;
            this.Text1.Page = Page1;
            this.Text1.Parent = DataBand2;
            this.Text2.Page = Page1;
            this.Text2.Parent = DataBand2;
            this.Text3.Page = Page1;
            this.Text3.Parent = DataBand2;
            this.Text4.Page = Page1;
            this.Text4.Parent = DataBand2;
            this.FooterBand1.Page = Page1;
            this.FooterBand1.Parent = Page1;
            this.Text6.Page = Page1;
            this.Text6.Parent = FooterBand1;
            this.DataBand2.BeginRender += new System.EventHandler(this.DataBand2__BeginRender);
            this.DataBand2.EndRender += new System.EventHandler(this.DataBand2__EndRender);
            this.DataBand2.Rendering += new System.EventHandler(this.DataBand2__Rendering);
            this.EndRender += new System.EventHandler(this.Report__EndRender);
            this.AggregateFunctions = new object[] {
                    this.Text6_Count};
            // 
            // Add to PageFooterBand1.Components
            // 
            this.PageFooterBand1.Components.Clear();
            this.PageFooterBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        Text7,
                        Text8});
            // 
            // Add to ReportTitleBand1.Components
            // 
            this.ReportTitleBand1.Components.Clear();
            this.ReportTitleBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        Text5});
            // 
            // Add to DataBand1.Components
            // 
            this.DataBand1.Components.Clear();
            this.DataBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        Text17,
                        Text18});
            // 
            // Add to DataBand2.Components
            // 
            this.DataBand2.Components.Clear();
            this.DataBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        Text1,
                        Text2,
                        Text3,
                        Text4});
            // 
            // Add to FooterBand1.Components
            // 
            this.FooterBand1.Components.Clear();
            this.FooterBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        Text6});
            // 
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        PageFooterBand1,
                        ReportTitleBand1,
                        DataBand1,
                        DataBand2,
                        FooterBand1});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        Page1});
            this.Dictionary.Relations.Add(this.ParentEmployees);
            this.Dictionary.Relations.Add(this.ParentProducts);
            this.Dictionary.Relations.Add(this.ParentOrders);
            this.Dictionary.Relations.Add(this.ParentCustomers);
            this.Dictionary.Relations.Add(this.ParentShippers);
            this.Dictionary.Relations.Add(this.ParentEmployees1);
            this.Dictionary.Relations.Add(this.ParentCategories);
            this.Dictionary.Relations.Add(this.ParentSuppliers);
            this.Categories.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CategoryID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CategoryName", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Description", typeof(System.String))});
            this.DataSources.Add(this.Categories);
            this.Customers.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerID", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CompanyName", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ContactName", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ContactTitle", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Address", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("City", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Region", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PostalCode", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Country", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Phone", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Fax", typeof(System.String))});
            this.DataSources.Add(this.Customers);
            this.Employees.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("EmployeeID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("LastName", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("FirstName", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Title", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("BirthDate", typeof(System.DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("HireDate", typeof(System.DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Address", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("City", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Region", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PostalCode", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Country", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("HomePhone", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Notes", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ReportsTo", typeof(int))});
            this.DataSources.Add(this.Employees);
            this.Order_Details.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("OrderID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitPrice", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Quantity", typeof(short)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Discount", typeof(float))});
            this.DataSources.Add(this.Order_Details);
            this.Orders.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("OrderID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerID", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("EmployeeID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("OrderDate", typeof(System.DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("RequiredDate", typeof(System.DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShippedDate", typeof(System.DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipVia", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Freight", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipName", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipAddress", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipCity", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipRegion", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipPostalCode", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipCountry", typeof(System.String))});
            this.DataSources.Add(this.Orders);
            this.Products.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProductName", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("SupplierID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CategoryID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("QuantityPerUnit", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitPrice", typeof(decimal)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("UnitsInStock", typeof(short))});
            this.DataSources.Add(this.Products);
            this.Shippers.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ShipperID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CompanyName", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Phone", typeof(System.String))});
            this.DataSources.Add(this.Shippers);
            this.Suppliers.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("SupplierID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CompanyName", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ContactName", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ContactTitle", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Address", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("City", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Region", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PostalCode", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Country", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Phone", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Fax", typeof(System.String)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("HomePage", typeof(System.String))});
            this.DataSources.Add(this.Suppliers);
            this.Countries.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CountriesID", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Flag", typeof(byte[])),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CountryName", typeof(System.String))});
            this.DataSources.Add(this.Countries);
        }
        
        #region Relation ParentEmployees
        public class ParentEmployeesRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentEmployeesRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
                }
            }
            
            public virtual System.String LastName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["LastName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String FirstName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["FirstName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Title
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Title"], typeof(System.String), true)));
                }
            }
            
            public virtual System.DateTime BirthDate
            {
                get
                {
                    return ((System.DateTime)(Stimulsoft.Report.StiReport.ChangeType(this["BirthDate"], typeof(System.DateTime), true)));
                }
            }
            
            public virtual System.DateTime HireDate
            {
                get
                {
                    return ((System.DateTime)(Stimulsoft.Report.StiReport.ChangeType(this["HireDate"], typeof(System.DateTime), true)));
                }
            }
            
            public virtual System.String Address
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Address"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String City
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["City"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Region
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Region"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String PostalCode
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["PostalCode"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Country
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Country"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String HomePhone
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["HomePhone"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Notes
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Notes"], typeof(System.String), true)));
                }
            }
            
            public virtual int ReportsTo
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["ReportsTo"], typeof(int), true)));
                }
            }
            
            public virtual ParentEmployeesRelation Employees
            {
                get
                {
                    return new ParentEmployeesRelation(this.GetParentData("EmployeesEmployees"));
                }
            }
        }
        #endregion Relation ParentEmployees
        
        #region Relation ParentProducts
        public class ParentProductsRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentProductsRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int ProductID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["ProductID"], typeof(int), true)));
                }
            }
            
            public virtual System.String ProductName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ProductName"], typeof(System.String), true)));
                }
            }
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
                }
            }
            
            public virtual int CategoryID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["CategoryID"], typeof(int), true)));
                }
            }
            
            public virtual System.String QuantityPerUnit
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["QuantityPerUnit"], typeof(System.String), true)));
                }
            }
            
            public virtual decimal UnitPrice
            {
                get
                {
                    return ((decimal)(Stimulsoft.Report.StiReport.ChangeType(this["UnitPrice"], typeof(decimal), true)));
                }
            }
            
            public virtual short UnitsInStock
            {
                get
                {
                    return ((short)(Stimulsoft.Report.StiReport.ChangeType(this["UnitsInStock"], typeof(short), true)));
                }
            }
            
            public virtual ParentCategoriesRelation Categories
            {
                get
                {
                    return new ParentCategoriesRelation(this.GetParentData("CategoriesProducts"));
                }
            }
            
            public virtual ParentSuppliersRelation Suppliers
            {
                get
                {
                    return new ParentSuppliersRelation(this.GetParentData("SuppliersProducts"));
                }
            }
        }
        #endregion Relation ParentProducts
        
        #region Relation ParentOrders
        public class ParentOrdersRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentOrdersRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int OrderID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["OrderID"], typeof(int), true)));
                }
            }
            
            public virtual System.String CustomerID
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["CustomerID"], typeof(System.String), true)));
                }
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
                }
            }
            
            public virtual System.DateTime OrderDate
            {
                get
                {
                    return ((System.DateTime)(Stimulsoft.Report.StiReport.ChangeType(this["OrderDate"], typeof(System.DateTime), true)));
                }
            }
            
            public virtual System.DateTime RequiredDate
            {
                get
                {
                    return ((System.DateTime)(Stimulsoft.Report.StiReport.ChangeType(this["RequiredDate"], typeof(System.DateTime), true)));
                }
            }
            
            public virtual System.DateTime ShippedDate
            {
                get
                {
                    return ((System.DateTime)(Stimulsoft.Report.StiReport.ChangeType(this["ShippedDate"], typeof(System.DateTime), true)));
                }
            }
            
            public virtual int ShipVia
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["ShipVia"], typeof(int), true)));
                }
            }
            
            public virtual decimal Freight
            {
                get
                {
                    return ((decimal)(Stimulsoft.Report.StiReport.ChangeType(this["Freight"], typeof(decimal), true)));
                }
            }
            
            public virtual System.String ShipName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ShipName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ShipAddress
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ShipAddress"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ShipCity
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ShipCity"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ShipRegion
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ShipRegion"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ShipPostalCode
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ShipPostalCode"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ShipCountry
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ShipCountry"], typeof(System.String), true)));
                }
            }
            
            public virtual ParentCustomersRelation Customers
            {
                get
                {
                    return new ParentCustomersRelation(this.GetParentData("CustomersOrders"));
                }
            }
            
            public virtual ParentShippersRelation Shippers
            {
                get
                {
                    return new ParentShippersRelation(this.GetParentData("ShippersOrders"));
                }
            }
            
            public virtual ParentEmployeesRelation Employees
            {
                get
                {
                    return new ParentEmployeesRelation(this.GetParentData("EmployeesOrders"));
                }
            }
        }
        #endregion Relation ParentOrders
        
        #region Relation ParentCustomers
        public class ParentCustomersRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentCustomersRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual System.String CustomerID
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["CustomerID"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String CompanyName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["CompanyName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ContactName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ContactName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ContactTitle
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ContactTitle"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Address
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Address"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String City
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["City"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Region
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Region"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String PostalCode
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["PostalCode"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Country
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Country"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Phone
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Phone"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Fax
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Fax"], typeof(System.String), true)));
                }
            }
        }
        #endregion Relation ParentCustomers
        
        #region Relation ParentShippers
        public class ParentShippersRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentShippersRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int ShipperID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["ShipperID"], typeof(int), true)));
                }
            }
            
            public virtual System.String CompanyName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["CompanyName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Phone
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Phone"], typeof(System.String), true)));
                }
            }
        }
        #endregion Relation ParentShippers
        
        #region Relation ParentEmployees1
        public class ParentEmployees1Relation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentEmployees1Relation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
                }
            }
            
            public virtual System.String LastName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["LastName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String FirstName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["FirstName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Title
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Title"], typeof(System.String), true)));
                }
            }
            
            public virtual System.DateTime BirthDate
            {
                get
                {
                    return ((System.DateTime)(Stimulsoft.Report.StiReport.ChangeType(this["BirthDate"], typeof(System.DateTime), true)));
                }
            }
            
            public virtual System.DateTime HireDate
            {
                get
                {
                    return ((System.DateTime)(Stimulsoft.Report.StiReport.ChangeType(this["HireDate"], typeof(System.DateTime), true)));
                }
            }
            
            public virtual System.String Address
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Address"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String City
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["City"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Region
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Region"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String PostalCode
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["PostalCode"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Country
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Country"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String HomePhone
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["HomePhone"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Notes
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Notes"], typeof(System.String), true)));
                }
            }
            
            public virtual int ReportsTo
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["ReportsTo"], typeof(int), true)));
                }
            }
            
            public virtual ParentEmployeesRelation Employees
            {
                get
                {
                    return new ParentEmployeesRelation(this.GetParentData("EmployeesEmployees"));
                }
            }
        }
        #endregion Relation ParentEmployees1
        
        #region Relation ParentCategories
        public class ParentCategoriesRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentCategoriesRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int CategoryID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["CategoryID"], typeof(int), true)));
                }
            }
            
            public virtual System.String CategoryName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["CategoryName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Description
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Description"], typeof(System.String), true)));
                }
            }
        }
        #endregion Relation ParentCategories
        
        #region Relation ParentSuppliers
        public class ParentSuppliersRelation : Stimulsoft.Report.Dictionary.StiDataRow
        {
            
            public ParentSuppliersRelation(Stimulsoft.Report.Dictionary.StiDataRow dataRow) : 
                    base(dataRow)
            {
            }
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
                }
            }
            
            public virtual System.String CompanyName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["CompanyName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ContactName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ContactName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ContactTitle
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ContactTitle"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Address
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Address"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String City
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["City"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Region
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Region"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String PostalCode
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["PostalCode"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Country
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Country"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Phone
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Phone"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Fax
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Fax"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String HomePage
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["HomePage"], typeof(System.String), true)));
                }
            }
        }
        #endregion Relation ParentSuppliers
        
        #region DataSource Categories
        public class CategoriesDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public CategoriesDataSource() : 
                    base("Demo.Categories", "Categories")
            {
            }
            
            public virtual int CategoryID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["CategoryID"], typeof(int), true)));
                }
            }
            
            public virtual System.String CategoryName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["CategoryName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Description
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Description"], typeof(System.String), true)));
                }
            }
        }
        #endregion DataSource Categories
        
        #region DataSource Customers
        public class CustomersDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public CustomersDataSource() : 
                    base("Demo.Customers", "Customers")
            {
            }
            
            public virtual System.String CustomerID
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["CustomerID"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String CompanyName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["CompanyName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ContactName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ContactName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ContactTitle
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ContactTitle"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Address
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Address"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String City
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["City"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Region
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Region"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String PostalCode
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["PostalCode"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Country
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Country"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Phone
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Phone"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Fax
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Fax"], typeof(System.String), true)));
                }
            }
        }
        #endregion DataSource Customers
        
        #region DataSource Employees
        public class EmployeesDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public EmployeesDataSource() : 
                    base("Demo.Employees", "Employees")
            {
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
                }
            }
            
            public virtual System.String LastName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["LastName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String FirstName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["FirstName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Title
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Title"], typeof(System.String), true)));
                }
            }
            
            public virtual System.DateTime BirthDate
            {
                get
                {
                    return ((System.DateTime)(Stimulsoft.Report.StiReport.ChangeType(this["BirthDate"], typeof(System.DateTime), true)));
                }
            }
            
            public virtual System.DateTime HireDate
            {
                get
                {
                    return ((System.DateTime)(Stimulsoft.Report.StiReport.ChangeType(this["HireDate"], typeof(System.DateTime), true)));
                }
            }
            
            public virtual System.String Address
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Address"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String City
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["City"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Region
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Region"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String PostalCode
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["PostalCode"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Country
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Country"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String HomePhone
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["HomePhone"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Notes
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Notes"], typeof(System.String), true)));
                }
            }
            
            public virtual int ReportsTo
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["ReportsTo"], typeof(int), true)));
                }
            }
            
            public virtual ParentEmployeesRelation Employees
            {
                get
                {
                    return new ParentEmployeesRelation(this.GetParentData("EmployeesEmployees"));
                }
            }
        }
        #endregion DataSource Employees
        
        #region DataSource Order_Details
        public class Order_DetailsDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public Order_DetailsDataSource() : 
                    base("Demo.Order Details", "Order Details")
            {
            }
            
            public virtual int OrderID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["OrderID"], typeof(int), true)));
                }
            }
            
            public virtual int ProductID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["ProductID"], typeof(int), true)));
                }
            }
            
            public virtual decimal UnitPrice
            {
                get
                {
                    return ((decimal)(Stimulsoft.Report.StiReport.ChangeType(this["UnitPrice"], typeof(decimal), true)));
                }
            }
            
            public virtual short Quantity
            {
                get
                {
                    return ((short)(Stimulsoft.Report.StiReport.ChangeType(this["Quantity"], typeof(short), true)));
                }
            }
            
            public virtual float Discount
            {
                get
                {
                    return ((float)(Stimulsoft.Report.StiReport.ChangeType(this["Discount"], typeof(float), true)));
                }
            }
            
            public virtual ParentProductsRelation Products
            {
                get
                {
                    return new ParentProductsRelation(this.GetParentData("ProductsOrder_Details"));
                }
            }
            
            public virtual ParentOrdersRelation Orders
            {
                get
                {
                    return new ParentOrdersRelation(this.GetParentData("OrdersOrder_Details"));
                }
            }
        }
        #endregion DataSource Order_Details
        
        #region DataSource Orders
        public class OrdersDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public OrdersDataSource() : 
                    base("Demo.Orders", "Orders")
            {
            }
            
            public virtual int OrderID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["OrderID"], typeof(int), true)));
                }
            }
            
            public virtual System.String CustomerID
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["CustomerID"], typeof(System.String), true)));
                }
            }
            
            public virtual int EmployeeID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["EmployeeID"], typeof(int), true)));
                }
            }
            
            public virtual System.DateTime OrderDate
            {
                get
                {
                    return ((System.DateTime)(Stimulsoft.Report.StiReport.ChangeType(this["OrderDate"], typeof(System.DateTime), true)));
                }
            }
            
            public virtual System.DateTime RequiredDate
            {
                get
                {
                    return ((System.DateTime)(Stimulsoft.Report.StiReport.ChangeType(this["RequiredDate"], typeof(System.DateTime), true)));
                }
            }
            
            public virtual System.DateTime ShippedDate
            {
                get
                {
                    return ((System.DateTime)(Stimulsoft.Report.StiReport.ChangeType(this["ShippedDate"], typeof(System.DateTime), true)));
                }
            }
            
            public virtual int ShipVia
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["ShipVia"], typeof(int), true)));
                }
            }
            
            public virtual decimal Freight
            {
                get
                {
                    return ((decimal)(Stimulsoft.Report.StiReport.ChangeType(this["Freight"], typeof(decimal), true)));
                }
            }
            
            public virtual System.String ShipName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ShipName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ShipAddress
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ShipAddress"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ShipCity
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ShipCity"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ShipRegion
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ShipRegion"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ShipPostalCode
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ShipPostalCode"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ShipCountry
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ShipCountry"], typeof(System.String), true)));
                }
            }
            
            public virtual ParentCustomersRelation Customers
            {
                get
                {
                    return new ParentCustomersRelation(this.GetParentData("CustomersOrders"));
                }
            }
            
            public virtual ParentShippersRelation Shippers
            {
                get
                {
                    return new ParentShippersRelation(this.GetParentData("ShippersOrders"));
                }
            }
            
            public virtual ParentEmployeesRelation Employees
            {
                get
                {
                    return new ParentEmployeesRelation(this.GetParentData("EmployeesOrders"));
                }
            }
        }
        #endregion DataSource Orders
        
        #region DataSource Products
        public class ProductsDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public ProductsDataSource() : 
                    base("Demo.Products", "Products")
            {
            }
            
            public virtual int ProductID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["ProductID"], typeof(int), true)));
                }
            }
            
            public virtual System.String ProductName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ProductName"], typeof(System.String), true)));
                }
            }
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
                }
            }
            
            public virtual int CategoryID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["CategoryID"], typeof(int), true)));
                }
            }
            
            public virtual System.String QuantityPerUnit
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["QuantityPerUnit"], typeof(System.String), true)));
                }
            }
            
            public virtual decimal UnitPrice
            {
                get
                {
                    return ((decimal)(Stimulsoft.Report.StiReport.ChangeType(this["UnitPrice"], typeof(decimal), true)));
                }
            }
            
            public virtual short UnitsInStock
            {
                get
                {
                    return ((short)(Stimulsoft.Report.StiReport.ChangeType(this["UnitsInStock"], typeof(short), true)));
                }
            }
            
            public virtual ParentCategoriesRelation Categories
            {
                get
                {
                    return new ParentCategoriesRelation(this.GetParentData("CategoriesProducts"));
                }
            }
            
            public virtual ParentSuppliersRelation Suppliers
            {
                get
                {
                    return new ParentSuppliersRelation(this.GetParentData("SuppliersProducts"));
                }
            }
        }
        #endregion DataSource Products
        
        #region DataSource Shippers
        public class ShippersDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public ShippersDataSource() : 
                    base("Demo.Shippers", "Shippers")
            {
            }
            
            public virtual int ShipperID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["ShipperID"], typeof(int), true)));
                }
            }
            
            public virtual System.String CompanyName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["CompanyName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Phone
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Phone"], typeof(System.String), true)));
                }
            }
        }
        #endregion DataSource Shippers
        
        #region DataSource Suppliers
        public class SuppliersDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public SuppliersDataSource() : 
                    base("Demo.Suppliers", "Suppliers")
            {
            }
            
            public virtual int SupplierID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["SupplierID"], typeof(int), true)));
                }
            }
            
            public virtual System.String CompanyName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["CompanyName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ContactName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ContactName"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String ContactTitle
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["ContactTitle"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Address
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Address"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String City
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["City"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Region
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Region"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String PostalCode
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["PostalCode"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Country
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Country"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Phone
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Phone"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String Fax
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["Fax"], typeof(System.String), true)));
                }
            }
            
            public virtual System.String HomePage
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["HomePage"], typeof(System.String), true)));
                }
            }
        }
        #endregion DataSource Suppliers
        
        #region DataSource Countries
        public class CountriesDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public CountriesDataSource() : 
                    base("Demo.Countries", "Countries")
            {
            }
            
            public virtual int CountriesID
            {
                get
                {
                    return ((int)(Stimulsoft.Report.StiReport.ChangeType(this["CountriesID"], typeof(int), true)));
                }
            }
            
            public virtual byte[] Flag
            {
                get
                {
                    return ((byte[])(Stimulsoft.Report.StiReport.ChangeType(this["Flag"], typeof(byte[]), true)));
                }
            }
            
            public virtual System.String CountryName
            {
                get
                {
                    return ((System.String)(Stimulsoft.Report.StiReport.ChangeType(this["CountryName"], typeof(System.String), true)));
                }
            }
        }
        #endregion DataSource Countries
        #endregion StiReport Designer generated code - do not modify
    }
}