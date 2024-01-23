<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="MytestProj.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard</title>
    <link rel="stylesheet" href="css/dashboard.css" />
</head>
<body>
    <div id="navContainer">
        <div id="container">
            <h3>Welcome to dashboard</h3>
        </div>
         <div id="conButtons">
             <a href="Register.aspx" rel="Register">
                 <div class="Clickbuttons">Register</div>
             </a>
              <a href="RegDetails.aspx" rel="Register">
                  <div class="Clickbuttons">All Details</div>
             </a>
              <a href="" rel="Register">
                   <div class="Clickbuttons">Show Details</div>
             </a>
             
           
        </div>
    </div>
    
    <form id="form1" runat="server">
        <div id="mainContainer">
            <div class="contaierClass">
                <asp:Label Text="Name:" For="lblUsername" runat="server" />
                <span id="msgUsername" runat="server">Nabin Acharya</span>
            </div>
             <div class="contaierClass">
                 <asp:Label Text="Email:" For="lblUsername" runat="server" />
                 <span id="Span1" runat="server">nabin@gmail.com</span>
            </div>
             <div class="contaierClass">
              <asp:Label Text="Password:" For="lblUsername" runat="server" />
              <span id="Span2" runat="server">Nabn123</span>
            </div>
             <div id="btnregister">
                <asp:Button Text="Logout" ID="btnLogout" OnClick="btnLogout_Click" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
