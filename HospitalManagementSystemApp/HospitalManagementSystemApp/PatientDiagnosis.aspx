<%@ Page Title="" Language="C#" MasterPageFile="~/HMS.Master" AutoEventWireup="true" CodeBehind="PatientDiagnosis.aspx.cs" Inherits="HospitalManagementSystemApp.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    Patient Diagnosis
</asp:Content>

<asp:Content ID="script" ContentPlaceHolderID="scriptHolder" runat="server">
       <script type="text/javascript">
           function myFunction() {
               var x = document.getElementById("rdbFollowUp");
           if (x.checked.value=="Y") {
               document.getElementById("txtDateOfFollowUp").readOnly = false;
           }
           else
           {
               document.getElementById("txtDateOfFollowUp").readOnly = true;
            }
           }

          
       </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    
    <form id="PatientDiagnosis" class="form-control" style="height : 100%;width: 70% " runat="server">
        
         <div class="form-group">
            <asp:Label ID="Label7" runat="server" Text="Patient Id "></asp:Label>
             <asp:DropDownList ID="dpdPatientId" runat="server"></asp:DropDownList>
        </div>
              
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Symptoms"></asp:Label>
            <asp:TextBox ID="txtSymptoms" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Diagnosis Provided"></asp:Label>
            <asp:TextBox ID="txtDiagnosisProvided" runat="server"></asp:TextBox> 
            
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Administered By"></asp:Label>
            <asp:DropDownList ID="dpdAdministeredBy" runat="server"></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Date of Diagnosis "></asp:Label>
            <asp:TextBox ID="txtDate" runat="server" TextMode="Date"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Follow Up Required ?" onclick="myFunction()"></asp:Label>
            <asp:RadioButtonList ID="rdbFollowUp" runat="server">
            <asp:ListItem Text="Yes" Value="Y"></asp:ListItem>
            <asp:ListItem Text="No" Value="N"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="Date of Follow up "></asp:Label>
            <asp:TextBox ID="txtDateOfFollowUp" runat="server" TextMode="Date" ReadOnly="True" AutoPostBack="True"></asp:TextBox>
        </div>
        
       
    </form>

</asp:Content>
