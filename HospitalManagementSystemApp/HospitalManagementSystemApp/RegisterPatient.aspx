<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HMS.Master" CodeBehind="RegisterPatient.aspx.cs" Inherits="HospitalManagementSystemApp.RegisterPatient" %>
<asp:Content ContentPlaceHolderID="Title" runat="server">
    Patient Registration
</asp:Content>
<asp:Content ContentPlaceHolderID="mainContent" ID="registerPatient" runat="server">


    <link href="Content/bootstrap.css" rel="stylesheet"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.js"></script>

    
<form id="form1" name="form1" class="form-control" style="width: 70%; height: 100%; margin: 10px auto" runat="server">

    <h2 style="text-align: center; color: navy">Patient Registration</h2>
    <asp:Label ID="lblRegSuccess" runat="server" Text="" style="text-align: center;" CssClass="h4" />
    <div class="form-group">
        <h4>First Name</h4>
        <asp:TextBox CssClass="form-control" ID="txtFirstName"  placeholder="First Name..." runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="FirstNameValidator" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First Name is Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtFirstName" ErrorMessage="Use Only Alphabets" ForeColor="red" ValidationExpression="^[a-zA-Z]+$"></asp:RegularExpressionValidator>
    </div>


    <div class="form-group">
        <h4>Last Name </h4>
        <asp:TextBox ID="txtLastName" name="txtLastName" class="form-control" placeholder="Last Name" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last Name is Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ControlToValidate="txtLastName" ErrorMessage="Use Only Alphabets" ForeColor="red" ID="RegularExpressionValidator6" runat="server" ValidationExpression="^[a-zA-Z]+$"></asp:RegularExpressionValidator>

         </div>

    <div class="form-group">
        <h4>Date Of Birth</h4>

        <asp:TextBox ID="txtDateOfBirth" name="txtDateOfBirth" class="form-control" format="dd/mm/yy" runat="server" TextMode="Date"  ToolTip="Select Date of Birth"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDateOfBirth" ErrorMessage="Date Of Birth Is Required" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <h4 >Phone Number</h4>

        <asp:TextBox ID="txtPhoneNumber" name="txtPhoneNumber" class="form-control" runat="server" TextMode="Phone"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPhoneNumber" ErrorMessage="Phone number is Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtPhoneNumber" ErrorMessage="Phone Number Should contain 11 digits" ForeColor="red" ValidationExpression="^(\d){11}$"></asp:RegularExpressionValidator>
    </div>
    <div class="form-group">
        <h4>Email</h4>

        <asp:TextBox ID="txtEmail" name="txtEmail" class="form-control" runat="server" TextMode="Email"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is Required " ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter Valid Email" ForeColor="red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

    </div>
    <div class="form-group">
        <h4 >State</h4>

        <asp:DropDownList ID="dpdState" name="dpdState" class="form-control" runat="server" CssClass="btn btn-default dropdown-toggle">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="dpdState" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <h4 > Insurance Plan</h4>
        <asp:DropDownList ID="dpdInsurancePlan" name="dpdInsurancePlan" class="form-control" runat="server" CssClass="btn btn-default dropdown-toggle">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="dpdInsurancePlan" ErrorMessage="RequiredFieldValidator" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" class="btn btn-success"/>

        <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset " class="btn btn-danger"/>

    </div>


</form>

</asp:Content>

