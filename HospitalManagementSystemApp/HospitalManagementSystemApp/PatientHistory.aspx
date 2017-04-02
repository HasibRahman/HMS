<%@ Page Title="" Language="C#" MasterPageFile="~/HMS.Master" AutoEventWireup="true" CodeBehind="PatientHistory.aspx.cs" Inherits="HospitalManagementSystemApp.WebForm3" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    Patient History
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="scriptHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    
    <form id="searchPatient" class="form-control" style="width: 90%; height: 100%; margin: 10px auto" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        
        <div>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Value="1">Search By Id</asp:ListItem>
                <asp:ListItem Value="2">Search By Name</asp:ListItem>    

            </asp:RadioButtonList>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="RadioButtonList1" runat="server" ErrorMessage=""></asp:RequiredFieldValidator>                                   
            
            <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator1_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator1">
            </ajaxToolkit:ValidatorCalloutExtender> 
        </div>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
            <asp:TextBox CssClass="form-control" ID="txtId" runat="server" TextMode="Number"></asp:TextBox>
            

                     
            
        </div>

        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <asp:TextBox CssClass="form-control" ID="txtFirstName" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
        </div>
        <div class="form-group">
            <asp:Button ID="btnSearch" runat="server" Text="Search"  class="btn btn-success" OnClick="btnSearch_Click"/>

            <asp:Button ID="btnReset" runat="server"  Text="Reset " class="btn btn-danger" OnClick="btnReset_Click"/>

        </div>
        
        <div>
        <asp:Label ID="lblSearchResult" runat="server" Text="Search Result"></asp:Label> 
    </div>
        <div>
            <asp:Label ID="lblnoResult"  runat="server" Text="Label" BackColor="White"></asp:Label>  
        </div>
    <div>
        <asp:GridView ID="GridView" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>  

    </div>
    </form>
    


</asp:Content>
