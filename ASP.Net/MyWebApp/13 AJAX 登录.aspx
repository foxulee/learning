<%@ Page Language="C#" AutoEventWireup="true" CodeFile="13 AJAX 登录.aspx.cs" Inherits="_13_AJAX_登录" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.min.js"></script>
    <script>
        $(function () {
            $("#btnLogin").click(function () {
                UserLogin();
            });
        });

        function UserLogin() {
            var userName = $("#name").val();
            var userPwd = $("#pwd").val();
            if (userName == "" || userPwd == "") {
                $("#msg").text("用户名或者密码不能为空");
            } else {
                $.post("13 validateUserNamePwd.ashx", {"name":userName,"pwd":userPwd}, function(data) {
                    if (data=="yes") {
                        window.location.href = "/CRUD/UserInfoList.ashx";
                    } else {
                        $("#msg").text("用户名或者密码错误");
                    }
                });
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名：<input type="text" name="txtName" id="name" /><br />
            密码：<input type="password" name="txtPwd" id="pwd" /><br />
            <input type="button" value="登录" id="btnLogin" /><span style="font-size: 14px; color: red" id="msg"></span>
        </div>
    </form>
</body>
</html>
