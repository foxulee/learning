<%@ Page Language="C#" AutoEventWireup="true" CodeFile="11 JQuery-AJAXDemo.aspx.cs" Inherits="_11_JQuery_AJAXDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.min.js"></script>
   <script>
       $(function() {
           $("#btnGet").click(function () {
               //发送GET请求，第一个参数：请求的URL地址；第二个参数：碧昂服务端发送的数据，键值对，可以为空；第三个参数：回调函数，服务端返回的结果以后会自动执行该回调函数，并且将返回的结果交给了该回调函数中的data参数;第四个参数默认为"text"，可以不写，
               $.get("11 AjaxDemo.ashx", {"name":"testName"},function(data) {
                   alert(data);
               });
           });

           $("#btnPost").click(function () {
               //发送Post请求
               $.post("11 AjaxDemo.ashx",{"name":"testName"},function(data) {
                   alert(data);
               });
           });


           $("#btnAjax").click(function() {
               $.ajax({
                   type: "POST",
                   url: "11 AjaxDemo.ashx",
                   data: "name=testName",
                   success: function(data) {
                       alert(data);
                   }
               });
           });
       })
   </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="button" value="Get" id="btnGet"/><br/>
        <input type="button"  value="Post" id="btnPost" /> <br/>
        <input type="button"  value="Ajax" id="btnAjax" />
    </div>
    </form>
</body>
</html>
