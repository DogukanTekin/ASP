﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="question_integer.aspx.vb" Inherits="question1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="RangeValidator"></asp:RangeValidator>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
