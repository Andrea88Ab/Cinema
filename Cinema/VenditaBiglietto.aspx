<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VenditaBiglietto.aspx.cs" Inherits="YourNamespace.VenditaBiglietto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vendita Biglietto</title>
    <!-- Puoi aggiungere qui il tuo CSS o riferimenti esterni -->
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Vendita Biglietto</h2>
        <asp:Label ID="LabelNome" runat="server" Text="Nome:"></asp:Label>
        <asp:TextBox ID="TextBoxNomei" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LabelCognome" runat="server" Text="Cognome:"></asp:Label>
        <asp:TextBox ID="TextBoxCognome" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LabelSala" runat="server" Text="Sala:"></asp:Label>
        <asp:DropDownList ID="DropDownListSala" runat="server">
            <asp:ListItem Text="SALA NORD" Value="SALA NORD"></asp:ListItem>
            <asp:ListItem Text="SALA EST" Value="SALA EST"></asp:ListItem>
            <asp:ListItem Text="SALA SUD" Value="SALA SUD"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="LabelTipoBiglietto" runat="server" Text="Tipo Biglietto:"></asp:Label>
        <asp:DropDownList ID="DropDownListTipoBiglietto" runat="server">
            <asp:ListItem Text="Intero" Value="Intero"></asp:ListItem>
            <asp:ListItem Text="Ridotto" Value="Ridotto"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="ButtonVendi" runat="server" Text="Vendi Biglietto" OnClick="ButtonVendi_Click" />
        <!-- Eventuali messaggi di validazione o conferma -->
        <asp:Label ID="LabelMessaggio" runat="server" /></asp:Label>
    </div>
    </form>
</body>
</html>
