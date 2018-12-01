<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Servicerequest.aspx.cs" Inherits="pestexterminator3rdproject.Servicerequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
     body {
			background: url(pest-exterminator1.jpg) no-repeat center center;
			background-size: cover;

		}
    </style>
</head>
<body>
    <form id="form1" style="padding-left:35%" runat="server">
        <div>
        &nbsp;<br />
            <asp:Label style="padding-left:2%; font-size:25px" ID="LabelDate" runat="server" Text="Select Date for Service"></asp:Label><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged1"></asp:Calendar>
            <asp:Label ID="LabelPest" runat="server" Text="Pest List"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownListPestName" runat="server" OnSelectedIndexChanged="DropDownListPestName_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <asp:Label ID="LabelTime" runat="server" Text="Choose Your Time"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownListTime" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="ButtonUpdate" runat="server" Text="Update Order" />
            <asp:Button ID="ButtonDelete" runat="server" Text="Delete Order" />
            <asp:Button ID="ButtonPestName" runat="server" Text="Create Order" OnClick="ButtonOrder_Click" />
&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="LabelOrder" runat="server" Text="Your Requested Service"></asp:Label>
            <br />
            <asp:GridView ID="GridViewRequest" runat="server" OnSelectedIndexChanged="GridViewRequest_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
