<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Co-ordinate.aspx.cs" Inherits="bonus_assignment_n01354605.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        Co-ordinate
    </title>
    <style>
        .label-style {
            padding:10px;
            font-size: 20px;
            margin-top:30px;
        }
        .textbox-style {
            padding-left:20px;
            margin-top:30px;
        }
        .submit-button {
            padding:10px;
            margin-top:20px;
            margin-left:120px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--User input x-axis-->
            <label for="user_x_axis" class="label-style">Enter X-axis</label>
            <asp:TextBox runat="server" ID="user_x_axis" TextMode="Number" CssClass="textbox-style">
            </asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="user_x_axis" ErrorMessage="Please enter Y-axis">
            </asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" ControlToValidate="user_x_axis" ErrorMessage="Please enter value other than 0" OnServerValidate="Co_ordinate_validate">
            </asp:CustomValidator>
           
        </div>
        <div>
            <!--User input y-axis-->
            <label for="user_y_axis" class="label-style">Enter Y-axis</label>
            <asp:TextBox runat="server" ID="user_y_axis" TextMode="Number" CssClass="textbox-style">
            </asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="user_y_axis" ErrorMessage="Please enter x-axis">
            </asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" ControlToValidate="user_y_axis" ErrorMessage="Please enter value other than 0" OnServerValidate="Co_ordinate_validate">
            </asp:CustomValidator>
        </div>
        <div>
           <!--Submit button-->
            <asp:Button runat="server" Text="Submit" CssClass="submit-button" />
        </div>
        <div runat="server" id="co_ordinate_summary">
        </div>
    </form>
</body>
</html>
