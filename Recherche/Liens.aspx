<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Liens.aspx.cs" Inherits="Recherche.Liens" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style16 {
            position: relative;
            left: 434px;
            top: 3px;
            width: 562px;
            height: 36px;
            border-radius : 10px;
            padding-left: 20px;

        }
        .auto-style17 {
            position: relative;
            left: 1075px;
            top: 10px;
        }
        .auto-style18 {
            font-family: Georgia, "Times New Roman", Times, serif;
            font-weight: bold;
            font-size: large;
        }
        .auto-style19 {
            font-style: italic;
            font-size: medium;
            color: #CC0000;
        }
        .auto-style20 {
            font-family: "Times New Roman", Times, serif;
            font-size: small;
        }
        .auto-style24 {
        font-family: "Times New Roman", Times, serif;
        font-size: x-large;
        color: #00A600;
        text-shadow: 2px 2px 4px #ffffff;

    }
    .auto-style25 {
        font-family: Georgia, "Times New Roman", Times, serif;
        font-weight: bold;
        font-size: x-large;
    }
        .auto-style27 {
        float: right;
            width: 214px;
            height: 200px;
            position: absolute;
            top: 361px;
            left: 1291px;
            z-index: 1;
        }
        .auto-style28{
            margin-left:25px;
        }
        .auto-style29 {
            font-style: italic;
            font-size: medium;
            color: #0000FF;
            position: absolute;
            top: 329px;
            left: 613px;
            z-index: 1;
            font-family: "Times New Roman";
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ImageButton ID="ImageButton7" runat="server" CssClass="auto-style17" ImageUrl="~/2.png" OnClick="ImageButton7_Click1" />
    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style16" OnTextChanged="TextBox1_TextChanged" style="position: relative"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" CssClass="auto-style29" Text="Saisir une recherche !!"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp; <span class="auto-style25">&nbsp;<span class="auto-style18"><asp:Label ID="lblRes" runat="server" CssClass="auto-style24" Text="Résultats :"></asp:Label>
</span> 
    </span><span class="auto-style18">
    <br />
    <br />
    <div class="auto-style28">
<asp:ScriptManager ID="ScriptManager1" runat="server"  >
    </asp:ScriptManager>
        </div>
</span> 
    <br class="auto-style20" />
&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:Label ID="Label1" runat="server" CssClass="auto-style19" Text="Aucun lien ne correspond aux termes de recherche spécifiés !!"></asp:Label>
    <br />
    <img alt="" height="200px" src="m4.png" class="auto-style27" /><br />
<br />
<br />
<br />
</asp:Content>
