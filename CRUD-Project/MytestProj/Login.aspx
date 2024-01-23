<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MytestProj.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="css/register.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="mainContent">
            <h1>Login to Your Account</h1>
            <a href="Register.aspx" rel="DataPage"> <h5>Didnot have account Register</h5></a>
            <br />
            <span id="error_message" runat="server"></span>
            <br />
            <div id="Container">
                 <div class="Content">
                    <div class="lvlcontent"><asp:Label Text="Email" For="lblEmail" runat="server" /></div>
                   <div class="inputcontainer">
                       <asp:TextBox ID="textEmail" TextMode="Email" placeholder="Enter Your Email" runat="server" />
                        <span id="errEmail" class="error" runat="server"></span>
                   </div>
                </div>
             
                 <div class="Content">
                <div class="lvlcontent">
                    <asp:Label Text="Password" For="lblPassword" runat="server" /></div>
               <div class="inputcontainer">
                   <asp:TextBox ID="textPassword" TextMode="Password" placeholder="Enter Password" runat="server" />
                    <span id="errPassword" class="error" runat="server"></span>
               </div>
            </div>
                <div id="btnregister">
                    <asp:Button Text="Login" ID="btnLogin" OnClick="btnLogin_Click" runat="server" />
                </div>

            </div>
        </div>
    </form>
</body>
</html>
