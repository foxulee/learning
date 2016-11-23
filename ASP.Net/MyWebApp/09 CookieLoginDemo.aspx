<%@ Page Language="C#" AutoEventWireup="true" CodeFile="09 CookieLoginDemo.aspx.cs" Inherits="_09_CookieLoginDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Username: <input type="text" name="txtName" value="<%=UserName %>" /> <br />
        Password: <input type="password" name="txtPwd" value="<%=UserPwd %>" /><br/>
        <input type="submit" value="Login" />
    </div>
    </form>
</body>
</html>
