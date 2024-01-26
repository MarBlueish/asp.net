<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insere.aspx.cs" Inherits="exer4.insere" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Button1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_nome" runat="server" Text="Nome:"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_nome" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lbl_npag" runat="server" Text="Nº de Páginas:"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_npag" runat="server"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="lbl_tam" runat="server" Text="Tamanho:"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_tam" runat="server"></asp:TextBox>
            <br /><br />
            <input id="Button1" type="button" value="inserir" onclick="Button1_Click()" /></div>
    </form>
</body>
</html>
