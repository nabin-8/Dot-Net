<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditStudent.aspx.cs" Inherits="MytestProj.EditStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Registration</title>
    <link rel="stylesheet" href="css/register.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="mainContent">
     <h1>Register Your Account</h1>
     <a href="RegDetails.aspx" rel="DataPage"> <h5>Back to Details</h5></a>
     <br />
     <span id="error_message" runat="server"></span>
     <br />
         <asp:HiddenField ID="txtId" runat="server" />
     <div id="Container">
         <div class="Content">
             <div class="lvlcontent"><asp:Label Text="Name" For="lblUsername" runat="server" /></div>
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
             <asp:Button Text="Update" ID="btnUpdate" OnClick="btnUpdate_Click" runat="server" />
         </div>

     </div>
 </div>
    </form>
</body>
</html>
