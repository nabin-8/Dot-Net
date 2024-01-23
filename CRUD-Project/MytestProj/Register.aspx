<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MytestProj.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <link rel="stylesheet" href="css/register.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="mainContent">
            <h1>Register Your Account</h1>
            <a href="Dashboard.aspx" rel="DataPage"> <h5>Back to Dashboard</h5></a>
            <br />
            <span id="error_message" runat="server"></span>
            <br />
            <div id="Container">
                <div class="Content">
                    <div class="lvlcontent"><asp:Label Text="Full Name" For="lblUsername" runat="server" /></div>
                    <div class="inputcontainer">
                        <asp:TextBox ID="textUsername" placeholder="Enter Your Full Name" runat="server" />
                        <span id="errUsername" class="error" runat="server"></span>
                    </div>
                </div>
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
                    <asp:Button Text="Register" ID="btnRegister" OnClick="btnRegister_Click" runat="server" />
                </div>

            </div>
        </div>
    </form>
</body>
</html>
