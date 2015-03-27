<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication1.WebForm6" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #TextArea1 {
            width: 110px;
        }
        #Select1 {
            width: 75px;
        }
        #Button1 {
            width: 55px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        幾歲：<input id="age" type="text" />
        <select id="YearFormat" name="D1">
            <option value=0>民國</option>
            <option value=1>西元</option>
        </select><input id="Button1" type="button" value="計算" OnClick="year_Click"  /><br />
        <br />
        取得：<asp:Label ID="GetBirthYear" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
