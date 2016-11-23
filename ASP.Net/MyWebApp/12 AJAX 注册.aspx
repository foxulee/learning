<%@ Page Language="C#" AutoEventWireup="true" CodeFile="12 AJAX 注册.aspx.cs" Inherits="_12_AJAX_注册" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.min.js"></script>
    <script type="text/javascript">
        $(function() {
            $("#btnName").blur(function () {
                $("#nameMsg").css("color", "red");
                var userName = $(this).val();
                if (userName!='') {
                    $.post("12 validateUserName.ashx", { "name": userName }, function(data) {
                        $("#nameMsg").text(data);
                        if (data == "此用户名可用") {
                            $("#nameMsg").css("color","green");
                        }
                    });
                } else {
                    $("#nameMsg").text("用户名不能为空");
                }
            });
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    用户名：<input type="text" name="txtName" id="btnName" /><span id="nameMsg" style="font-size: 14px; color: red"></span><br/>
        密码：<input type="password" name="txtPwd"  /><br/>
        <input type="submit"  value="注册" />
    </div>
    </form> 
</body>
</html>
