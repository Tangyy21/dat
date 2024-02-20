<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TinhToan.aspx.cs" Inherits="WebApplication1.TinhToan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            tính toán đơn giản
            <br/>
            Nhập số 1<asp:TextBox ID="txtso1" runat="server"></asp:TextBox>
            <br/>
            Nhập Số 2<asp:TextBox ID="txtso2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="cộng" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="trừ" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="nhân" Width="42px" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="chia" OnClick="Button4_Click" />
            <br />
            Kết quả <asp:TextBox ID="txtkq" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
