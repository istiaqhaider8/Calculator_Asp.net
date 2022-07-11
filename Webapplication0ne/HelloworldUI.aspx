<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloworldUI.aspx.cs" Inherits="Webapplication0ne.HelloworldUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        First Number
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="firstNumberTextBox"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        Second Number
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="secondNumberTextBox"></asp:TextBox>
                    </td>
                </tr>

                 <tr>
                    <td>
                        Result: 
                    </td>
                    <td>
                        <asp:Label runat="server" ID="resultLabel"></asp:Label>
                    </td>
                </tr>

                  <tr>
                    <td>
                      
                    </td>
                    <td>
                        <asp:Button runat="server" ID="addButton" Text="Add" OnClick="addButton_Click"/>
                        <asp:Button runat="server" ID="subtractButton" Text="Subtract" OnClick="subtractButton_Click"/>
                        <asp:Button runat="server" ID="multiplyButton" Text="Multiply" OnClick="multiplyButton_Click"/>
                        <asp:Button runat="server" ID="divisionButton" Text="Division" OnClick="divisionButton_Click"/>
                    </td>
                </tr>
                
            </table>
           
        </div>
    </form>
</body>
</html>
