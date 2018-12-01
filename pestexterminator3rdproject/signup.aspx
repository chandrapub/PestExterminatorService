<%@ Page Title=""  Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="pestexterminator3rdproject.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="LabelHeader" style="size:50px" runat="server" Text="Create a New Customer"></asp:Label>
    <br />
    <br />
    <br />&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxCustomerFirstName" runat="server" OnTextChanged="TextBoxCustomerFirstName_TextChanged" ForeColor="Black" MaxLength="30"></asp:TextBox>

    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="LabelCustomerFirstName" runat="server" Text="First Name"></asp:Label><br />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" ControlToValidate="TextBoxCustomerFirstName" EnableClientScript="False" ErrorMessage="Name Only Char Type" ForeColor="Red">***</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidatorfirstName" runat="server" ControlToValidate="TextBoxCustomerFirstName" EnableClientScript="False" ErrorMessage="Name Only Alphabet" ForeColor="Red" ValidationExpression="^[a-zA-Z\s]+$">***</asp:RegularExpressionValidator>
    <br />
   &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxCustomerLastName" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="LabelCustomerLastName" runat="server" Text="Last Name"></asp:Label><br />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorlastName" runat="server" ControlToValidate="TextBoxCustomerLastName" EnableClientScript="False" ErrorMessage="Name Only Char Type" ForeColor="Red">***</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidatorlastname" runat="server" ControlToValidate="TextBoxCustomerLastName" EnableClientScript="False" ErrorMessage="Name only Alphabet" ForeColor="Red" ValidationExpression="^[a-zA-Z\s]+$">***</asp:RegularExpressionValidator>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxStreet" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="LabelStreet" runat="server" Text="Street"></asp:Label> <br />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorStreet" runat="server" ControlToValidate="TextBoxStreet" EnableClientScript="False" ErrorMessage="Stree Can Take only Char and Numeric" ForeColor="Red">***</asp:RequiredFieldValidator>
    <br />
  &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxHouseNo" runat="server" OnTextChanged="TextBoxHouseNo_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="LabelHouseNo" runat="server" Text="House No"></asp:Label> <br />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorHouseNo" runat="server" ControlToValidate="TextBoxHouseNo" EnableClientScript="False" ErrorMessage="Take only Numeric and Char" ForeColor="Red">***</asp:RequiredFieldValidator>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxZipCode" runat="server" OnTextChanged="TextBoxZipCode_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="LabelZipCode" runat="server" Text="Zip Code"></asp:Label><br />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorZipCode" runat="server" ControlToValidate="TextBoxZipCode" EnableClientScript="False" ErrorMessage="Zip Code Only Numeric and Char" ForeColor="Red">***</asp:RequiredFieldValidator>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxMobile" runat="server" OnTextChanged="TextBoxMobile_TextChanged"></asp:TextBox>
    &nbsp; &nbsp;&nbsp;&nbsp;
    <asp:Label ID="LabelMobile" runat="server" Text="Mobile"></asp:Label><br />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorMobile" runat="server" ControlToValidate="TextBoxMobile" EnableClientScript="False" ErrorMessage="Take Only Numeric Data" ForeColor="Red">***</asp:RequiredFieldValidator>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxHomePhone" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="LabelHomePhone" runat="server" Text="Home Phone"></asp:Label><br />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorHomePhone" runat="server" ControlToValidate="TextBoxHomePhone" EnableClientScript="False" ErrorMessage="Take Only Numeric Data" ForeColor="Red">***</asp:RequiredFieldValidator>
    <br />&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label><br />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ControlToValidate="TextBoxEmail" EnableClientScript="False" ErrorMessage="Required Valid Email Address" ForeColor="Red">***</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="TextBoxEmail" EnableClientScript="False" ErrorMessage="Write Valid Email Address" ForeColor="Red" ValidationExpression="^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+\.)+[a-z]{2,5}$">***</asp:RegularExpressionValidator>
    <br />&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label><br />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ControlToValidate="TextBoxPassword" EnableClientScript="False" ErrorMessage="Required a Valid Password" ForeColor="Red">***</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidatorPassword" runat="server" ControlToValidate="TextBoxPassword" EnableClientScript="False" ErrorMessage="Please Give 4-15 Char and Password Should be Combination of Numeric ,Char  and underscore" ForeColor="Red" ValidationExpression="^[a-zA-Z]\w{3,14}$">***</asp:RegularExpressionValidator>
    <br />&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxConfirmPassword" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="LabelConfirmPassword" runat="server" Text="Confirm Password"></asp:Label><br />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmPassword" runat="server" ControlToValidate="TextBoxConfirmPassword" EnableClientScript="False" ErrorMessage="Password Does Not Match" ForeColor="Red">***</asp:RequiredFieldValidator>
    <asp:CompareValidator ID="CompareValidatorPassword" runat="server" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxConfirmPassword" EnableClientScript="False" ErrorMessage="Password Does Not Match" ForeColor="Red">***</asp:CompareValidator>
    <br />
    <br />&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="ButtonSignup" runat="server" Height="40px" Text="Sign Up" Width="152px" OnClick="ButtonSignup_Click" />
    <br />
    <br />
    <%--<asp:Label ID="LabelInfo" runat="server" Text="Give Your Information "></asp:Label>--%>
    <br />
    <br />
    <asp:ValidationSummary ID="ValidationSummary" runat="server" EnableClientScript="False" ForeColor="Red" HeaderText="[&amp;nbsp;Error On The Page]" />
</asp:Content>
