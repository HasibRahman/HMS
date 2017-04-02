<%@ Page Title="" Language="C#" MasterPageFile="~/HMS.Master" AutoEventWireup="true" CodeBehind="RegisterPhysician.aspx.cs" Inherits="HospitalManagementSystemApp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    Register Physician
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <form id="RegisterPhysicianForm" class="form-control" style="width: 70%; height: 100%; margin: 10px auto" runat="server">
        
        <h2 style="text-align: center; color: navy">Physician Registration</h2>
        <asp:Label ID="lblRegSuccess" runat="server" Text="" style="text-align: center;" CssClass="h4" />
        
        <div class="form-group">
            <h4>First Name</h4>
            <asp:TextBox CssClass="form-control" ID="txtFirstNamePhysician" runat="server"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstNamePhysician" ErrorMessage="Required"></asp:RequiredFieldValidator>

        </div>
        
        <div class="form-group">
            <h4>Last Name</h4>
            <asp:TextBox CssClass="form-control" ID="txtLastNamePhysician" runat="server"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastNamePhysician" ErrorMessage="Required"></asp:RequiredFieldValidator>

        </div>

        <div class="form-group">
            <h4>Department </h4>
            <asp:DropDownList class="form-control" CssClass="btn btn-default dropdown-toogle" ID="dpdDepartment" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator CssClass="form-control" ID="RequiredFieldValidator4" runat="server" ControlToValidate="dpdDepartment" ErrorMessage="Required"></asp:RequiredFieldValidator>

        </div>
        <div class="form-group">
            <h4>Qualifications</h4>
            <asp:TextBox CssClass="form-control" ID="txtQualification" runat="server"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtQualification" ErrorMessage="Required"></asp:RequiredFieldValidator>

        </div>
        <div class="form-group">
            <h4>Experience</h4>
            <asp:TextBox class="form-control" CssClass="btn btn-default" ID="txtExperience" runat="server" TextMode="Number"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtExperience" ErrorMessage="Required"></asp:RequiredFieldValidator>

        </div>
        <div class="form-group">
            <h4>State</h4>
            <asp:DropDownList class="form-control" CssClass="btn btn-default dropdown-toogle" ID="dpdStatePhysician" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="dpdStatePhysician" ErrorMessage="Required"></asp:RequiredFieldValidator>

        </div>
        <div class="form-group">
            <h4>Plan</h4>
            <asp:DropDownList class="form-control" CssClass="btn btn-default dropdown-toogle" ID="dpdPlanPhysician" runat="server"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="dpdPlanPhysician" ErrorMessage="Required"></asp:RequiredFieldValidator>

        </div>
        <asp:Button ID="btnRegisterPhysician" CssClass="btn btn-success" runat="server" Text="Register" OnClick="btnRegisterPhysician_Click" />
        <asp:Button ID="btnResetPhysician" cssClass="btn btn-danger" runat="server" Text="Reset" OnClick="btnResetPhysician_Click" />
    </form>
</asp:Content>
