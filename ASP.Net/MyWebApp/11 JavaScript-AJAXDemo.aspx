<%@ Page Language="C#" AutoEventWireup="true" CodeFile="11 JavaScript-AJAXDemo.aspx.cs" Inherits="_11_AJAXDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.min.js"></script>
    <script>
        $(function() {
            $("#btnGetTime").click(function() {
                var xhr;
                if (XMLHttpRequest) {  //高版本的IE和chrome FF
                    xhr = new XMLHttpRequest();
                } else { //IE5.0, IE6.0
                    xhr = new ActiveXObject("Microsoft.XMLHTTP");
                }
                xhr.open("get", "11 AjaxDemo.ashx", true);     //true表示异步同步，false表示传统方式
                xhr.send();
                //回调函数：服务器处理完成以后，会将处理的结果返回给浏览器，那么浏览器会自动调用该回调函数，在回调函数中可以拿到从服务器返回的结果。
                xhr.onreadystatechange = function() {
                    if (xhr.readyState==4) {  //状态4表示数据已经从服务器返回给浏览器。
                        if (xhr.status == 200) { //200表示从服务端返回的响应状态码是200,200表示：服务端执行的代码没有出现异常
                            //这时浏览器端就可以呈现从服务器返回的数据了
                            alert(xhr.responseText);  //responseText: 拿到从服务器返回的数据（必须是字符串）
                            
                        }
                    }
                };
            });
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="button" value="GetTime" id="btnGetTime" />
        Ajax可以在纯html中使用
    </div>
    </form>
</body>
</html>
