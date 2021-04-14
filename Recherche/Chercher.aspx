<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Chercher.aspx.cs" Inherits="Recherche.Chercher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style16 {
            text-align: center;
        }
        .auto-style17 {
            width: 760px;
            height: 287px;
            position: absolute;
            top: 77px;
            left: 415px;
            z-index: 1;
        }
        .auto-style18:hover{
            box-shadow: 2px 2px 2px #cacaca inset;
            //box-shadow:2px 2px 2px #cacaca;
        }
        .auto-style19 {
            position: absolute;
            top: 430px;
            left: 1037px;
            z-index: 1;
            right: 382px;
           border-radius : 8px;
            height: 40px;
        }
        .auto-style19:hover
        {
            background-color:cadetblue;
            border-color : blue;
        }
        .auto-style20 {
            position: absolute;
            top: -96px;
            left: 1336px;
            z-index: 1;
            height: 922px;
            width: 170px;
            margin-bottom: 49px;
            margin-left: 0px;
        }
        .auto-style21 {
            position: absolute;
            top: 143px;
            left: 163px;
            z-index: 1;
        }
        .auto-style22 {
            position: absolute;
            top: 117px;
            left: 131px;
            z-index: 1;
        }
        .auto-style23 {
            position: absolute;
            top: 145px;
            left: 127px;
            z-index: 1;
        }
    .auto-style24 {
        position: absolute;
        top: 604px;
        left: 1287px;
        z-index: 1;
        width: 212px;
        height: 163px;
    }
    .auto-style25{
        border-radius:10px;
        padding-left:1.5em;
            position: absolute;
            top: 433px;
            left: 455px;
            z-index: 1;
        }
    .auto-style25:hover{
        box-shadow:1.5px 1.5px 3px #cacaca;
    }
        .auto-style26 {
            position: absolute;
            top: 473px;
            left: 455px;
            z-index: 1;
            font-style: italic;
            font-size: medium;
            color: #0000FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style16">
        <img alt="" src="12.png" class="auto-style20" /><img alt="" src="fiirst.png" class="auto-style17" /></p>
    <p class="auto-style16">
        &nbsp;</p>
    <p class="auto-style16">
        <asp:Button ID="btnRecherche" runat="server" BackColor="#E6DACE" CssClass="auto-style19" Text="Rechercher" OnClick="btnRecherche_Click" />
        <asp:TextBox ID="bxRecherche" runat="server" Height="30px" Width="532px" CssClass="auto-style25" placeHolder="Taper ici votre recherche"></asp:TextBox>
    </p>
    <p class="auto-style16">
        &nbsp;</p>
    <p class="auto-style16">
        <img alt="" height="45px" src="m3.png" class="auto-style21" /><img alt="" height="55px" src="m3.png" class="auto-style22" /><img alt="" height="50px" src="m1.png" class="auto-style23" /><img alt="" src="lotus.png" class="auto-style24" /><asp:Label ID="lblR" runat="server" CssClass="auto-style26" Text="Saisir une recherche :) !!" Visible="False"></asp:Label>
    </p>
    <p class="auto-style16">
        &nbsp;</p>
    <p class="auto-style16">
        &nbsp;</p>
   
</asp:Content>
