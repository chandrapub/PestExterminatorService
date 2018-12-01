<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="pestexterminator3rdproject.Domestic"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LabelInfo" runat="server" Text="Pest Control and Exterminator"></asp:Label>
    <br />
    <br />
    
    <asp:Repeater ID="RepeaterPestImage"  runat="server" OnItemCommand="RepeaterPestImage_ItemCommand">
       
        <HeaderTemplate>
                    <table class="mytable" style ="background: url(pest-exterminator2.jpg) no-repeat center center;
			background-size: cover; display:flex">
                        <tr>
                            <td class="myheader">PestID</td>
                            <td class="myheader">PestName</td>
                            <td class="myheader">PestPrice</td>
                            <td class="myheader">Picture</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td class="myitem"><%# Eval("PestID") %></td>
                        <td class="myitem"><%# Eval("PestName") %></td>
                        <td class="myitem"><%# Eval("PestPrice") %></td>
                        <td class="myitem"><img src="Picture/<%# Eval("Picture") %>" alt="Pest" /></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
    </asp:Repeater>
    <br />
    <br />
    <asp:Label ID="LabelTotal" runat="server" Text="Number of Pest"></asp:Label>
    <br />
    <br />
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
   

    <asp:Label ID="LabelSignIn" runat="server" Text="Are You Registered Customer?"></asp:Label>
&nbsp;&nbsp;
    <asp:Button ID="ButtonSignIn" runat="server" OnClick="ButtonSignIn_Click" Text="Sign In" Width="68px" />
</asp:Content>

   
