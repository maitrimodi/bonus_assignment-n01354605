<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="bonus_assignment_n01354605.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--User input x-axis-->
            <label for="user_x_axis">Enter X-axis</label>
            <asp:TextBox runat="server" ID="user_x_axis">
            </asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="user_x_axis" ErrorMessage="Please neter Y-axis">
            </asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" ControlToValidate="user_x_axis" ErrorMessage="Please enter value other than 0" OnServerValidate="Co_ordinate_validate">
            </asp:CustomValidator>
        </div>
        <div>
            <!--User input y-axis-->
            <label for="user_y_axis">Enter Y-axis</label>
            <asp:TextBox runat="server" ID="user_y_axis">
            </asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="user_y_axis" ErrorMessage="Please enter x-axis">
            </asp:RequiredFieldValidator>
            <asp:CustomValidator runat="server" ControlToValidate="user_y_axis" ErrorMessage="Please enter value other than 0" OnServerValidate="Co_ordinate_validate">
            </asp:CustomValidator>
        </div>
        <div>
           <!--Submit button-->
            <asp:Button runat="server" Text="Submit" />
        </div>
        <div runat="server" id="co_ordinate_summary">
        </div>
    </form>
</body>
</html>
