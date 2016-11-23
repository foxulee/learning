<%@ Page Language="C#" AutoEventWireup="true" CodeFile="14 JsonAjaxDemo.aspx.cs" Inherits="_14_JsonAjaxDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.min.js"></script>
    <script>
        $(function() {
            $("#btnJson").click(function() {
                //写法1：
                //$.post("14 JsonAjaxDemo.ashx", {}, function(data) {
                //    alert(data.Name);
                //},"json");

                //写法2：
                //$.post("14 JsonAjaxDemo.ashx", {},function(data) {
                //    var serverData = $.parseJSON(data); //将Json字符串转成JSON对象
                //    alert(serverData.Name);
                //});

                //写法3：
                $.getJSON("14 JsonAjaxDemo.ashx", {}, function(data) {
                    alert(data.Name);
                });

            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="button" name="name" id="btnJson" value="Get JSON Data" />
    </div>
    </form>
</body>
</html>
