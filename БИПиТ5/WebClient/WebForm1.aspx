<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label5" runat="server" Text="Таблица с заказами"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView><br />
            <div><asp:Label ID="Label1" runat="server" Text="Клиент: "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Value" DataValueField="Key">
            </asp:DropDownList></div><br />
            <div><asp:Label ID="Label3" runat="server" Text="Срок аренды: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Поле не должно быть пустым!" ForeColor="Red"></asp:RequiredFieldValidator><br />
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Число должно быть положительным!" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            </div><br />
            <div><asp:Label ID="Label2" runat="server" Text="Услуга: "></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" DataTextField="Value" DataValueField="Key">
            </asp:DropDownList></div><br />
            <div><asp:Label ID="Label4" runat="server" Text="Дата заказа: "></asp:Label>
            <asp:TextBox ID="DateO" runat="server" TextMode="Date" Width="152px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="DateO" runat="server" ErrorMessage=" Укажите дату!" ForeColor="Red"></asp:RequiredFieldValidator></div><br />
            <asp:Button ID="Button1" runat="server" BackColor="#6699FF" style="position:relative; left:420px" OnClick="Button1_Click" Text="Отправить" Height="46px" Width="170px" BorderColor="#6699FF" />
        </div>
    </form>
</body>
</html>
