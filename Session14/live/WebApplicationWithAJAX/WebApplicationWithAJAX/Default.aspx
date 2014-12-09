<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationWithAJAX.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        var readystatehandler = function (e) {
            if (e.target.readyState == 4) {
                var obj = JSON.parse(e.target.response);
                document.getElementById('list').innerHTML = '';
                for (var i = 0; i < obj.length; i++) {
                    document.getElementById('list').innerHTML += '<li>' + obj[i].Name + '</li>';
                }
            }
        };

        window.addEventListener('load', function () {
            var client = new XMLHttpRequest();
            client.addEventListener('readystatechange', readystatehandler, false);
            client.open('GET', '/ChinookService.svc/chinook/artists');
            client.send();
        }, false);
    </script>
</head>
<body>
    
    <ul id="list"></ul>
</body>
</html>
