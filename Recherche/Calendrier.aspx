<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Calendrier.aspx.cs" Inherits="Recherche.Calendrier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style12 {
        width: 858px;
        height: 565px;
        position: absolute;
        top: 106px;
        left: 340px;
        z-index: 1;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script language="C#" runat="server">

        void DayRender(Object source, DayRenderEventArgs e)
        {
            DateTime dateAujourdhui = DateTime.Today;

            if (e.Day.Date < dateAujourdhui)
            {
                e.Day.IsSelectable = false;

            }
            else if (e.Day.Date > dateAujourdhui)
            {
                e.Day.IsSelectable = false;
            }
            else
            {
                e.Day.IsSelectable = true;
            }
        }

   </script>
     <br />
     <asp:Calendar ID="calendar1"
            OnDayRender="DayRender"
            runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" NextPrevFormat="ShortMonth" CssClass="auto-style12">

            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
            <DayStyle BackColor="#CCCCCC" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
            <TodayDayStyle BackColor="#999999" ForeColor="White" />

        </asp:Calendar>

<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
c

</asp:Content>
