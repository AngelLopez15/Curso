<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" ClientIDMode="Static" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <h2><%: Title %>.</h2>
 <label><asp:Literal ID="ltrnombre" runat="server"></asp:Literal></label>
 <asp:Label ID="lblnombre" runat="server"></asp:Label>
 <asp:TextBox ID="txtnombre" runat="server" placeholder="Nombre"></asp:TextBox>
 <asp:TextBox ID="txtapellidos" runat="server" placeholder="apellidos"></asp:TextBox>
 <asp:TextBox ID="txtedad" runat="server" placeholder="Edad"></asp:TextBox>
 <button type="button" id="btn_guardar">Guardar</button>
 <div id="espera">Espere um momento</div>
 <div id="terminado">Guadado</div>
 <script src="js/script.js"></script>

</asp:Content>
