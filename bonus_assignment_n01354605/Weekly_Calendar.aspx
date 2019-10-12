<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weekly_Calendar.aspx.cs" Inherits="bonus_assignment_n01354605.Weekly_Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Weekly Calendar</title>
    <style>
        .summary {
            margin-top:30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--Ask user for their work/study schedule-->
            Select how many days you work/study?
            <asp:CheckBoxList ID="user_work_days" runat="server" TextAlign="Right">
                <asp:ListItem Value="1" >Monday</asp:ListItem>
                <asp:ListItem Value="2">Tuesday</asp:ListItem>
                <asp:ListItem Value="3">Wednesday</asp:ListItem>
                <asp:ListItem Value="4">Thursday</asp:ListItem>
                <asp:ListItem Value="5">Friday</asp:ListItem>
                <asp:ListItem Value="6">Saturday</asp:ListItem>
                <asp:ListItem Value="7">Sunday</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div>
            <asp:Button runat="server" Text="Submit" />
        </div>
        <div runat="server" id="weekly_calendar_summary">
        </div>
    </form>
</body>
</html>
