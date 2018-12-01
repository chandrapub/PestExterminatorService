<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrator.aspx.cs" Inherits="pestexterminator3rdproject.Administrator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    body {
            background-color:#ccffdd;
   			/*background: url(pest-exterminator1.jpg) no-repeat center center;
			background-size: cover;*/
		}
        </style>
</head>
<body>
    <form id="form1" runat="server" style=" padding-left:35%; padding-top:3% ">
        <div>
            <asp:GridView ID="GridViewAdmin" runat="server" OnSelectedIndexChanged="GridViewAdmin_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:Label ID="LabelError" runat="server" Text="No Error"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownListAdmin" runat="server" OnSelectedIndexChanged="DropDownListAdmin_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            <asp:Label ID="LabelName" runat="server" Text="Pest Name"></asp:Label>
            <br />
            <asp:TextBox ID="TextBoxPrice" runat="server"></asp:TextBox>
            <asp:Label ID="LabelPrice" runat="server" Text="Pest Price"></asp:Label>
            <br />
            <asp:TextBox ID="TextBoxPicture" runat="server"></asp:TextBox>
            <asp:Label ID="LabelPicture" runat="server" Text="Picture"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonCreate" runat="server" OnClick="ButtonCreate_Click" Text="Create" />
            <asp:Button ID="ButtonUpdate" runat="server" Text="Update" OnClick="ButtonUpdate_Click" />
            <asp:Button ID="ButtonDelete" runat="server" Text="Delete" OnClick="ButtonDelete_Click" />
            <asp:Button ID="Buttonlogout" runat="server" OnClick="Buttonlogout_Click" Text="Logout" />
        </div>
    </form>
</body>
</html>
