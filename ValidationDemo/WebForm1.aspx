<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ValidationDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="4"><h1>Your Details</h1></td>
                </tr>
                <tr>
                    <td>Name:</td>
                    <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ForeColor="#ff3300" ControlToValidate="txtName" ErrorMessage="Please give you Name">*</asp:RequiredFieldValidator>
                    </td>
                    <td>Username:</td>
                    <td><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ForeColor="#ff3300" runat="server" ControlToValidate="txtUsername" ErrorMessage="Please write username" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtUsername" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="r" MinimumValue="d">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>Email:</td>
                    <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Please enter a valid Email address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic">*</asp:RegularExpressionValidator>
                    </td>
                    <td>Password:</td>
                    <td><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="#ff3300" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please write password" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtPassword" ErrorMessage="CustomValidator" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" Display="Dynamic">*</asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>Mobile:</td>
                    <td><asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txtMobile"
                            ForeColor="#ff3300"
                            ErrorMessage="Please enter your mobile number" Display="Dynamic">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtMobile" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="9999999999" MinimumValue="1111111111" Type="Double" Display="Dynamic">*</asp:RangeValidator>
                    </td>
                    <td class="auto-style1">Confirm password:</td>
                    <td class="auto-style1"><asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtConfirmPassword" ControlToValidate="txtPassword" ErrorMessage="Password and Confirm Password Must be same" ForeColor="Red" Display="Dynamic">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Button ID="btnSubmit" runat="server" Text ="Submit" OnClick="btnSubmit_Click" /></td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
