<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionTimeout.aspx.cs" Inherits="AdminPresentation.SessionTimeout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Session Timeout</title>
    <meta http-equiv="Pragma" content="no-cache" />
    <meta http-equiv="Expires" content="-1" />
    <meta http-equiv="CACHE-CONTROL" content="NO-CACHE" />
    <link href="css/404_Session.css" rel="stylesheet" />
    <script>
        window.location.hash = "no-back-button";
        window.location.hash = "Again-No-back-button";  //again because google chrome don't insert first hash into history
        window.onhashchange = function () { window.location.hash = "no-back-button"; }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">
            <h1>Session Time-Out</h1>
        </div>
        <div id="content">
            <div class="content-container">
                <h2>Session has been Expired...!</h2>
                <h3>The page you are looking at has been timedout, You must
                    <asp:HyperLink runat="server" ID="hl1" NavigateUrl="~/Login.aspx" Style="color: black">Re-Login.</asp:HyperLink>
                </h3>
            </div>
            <br />
            <br />
            <div style="width: 300px; margin: 0 auto;">
                <img runat="server" id="img1" src="~/images/Session_Timeout.gif" alt="" />
            </div>
        </div>
    </form>
</body>
</html>
