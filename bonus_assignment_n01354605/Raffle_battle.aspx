<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Raffle_battle.aspx.cs" Inherits="bonus_assignment_n01354605.Raffle_battle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        Raffle Battle
    </title>
    <style>
        .label-style {
            margin-top:20px;
            font-size:20px;
        }
        .text-box-style {
            margin-left:20px;
        }
        .button-style {
            margin-top:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--USER INPUT FOR NUMBER OF TICKETS-->
            <label for="booking_tickets" class="label-style">How many tickets you want to order?</label>
            <asp:TextBox runat="server" ID="number_of_tickets_booked" TextMode="Number" CssClass="text-box-style"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="number_of_tickets_booked" ErrorMessage="Please enter number of tickets!">
            </asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Button runat="server" ID="submit_button" Text="Submit" CssClass="button-style"/>
        </div>
            <div runat="server" id="raffle_battle_summary">
            </div>
    </form>
</body>
</html>
