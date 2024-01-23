<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegDetails.aspx.cs" Inherits="MytestProj.RegDetails" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>List Student</title>
        <link rel="stylesheet" href="css/regDetails.css" />
    </head>
    <body>
        <h1>List of Registers</h1>
        <a href="Dashboard.aspx" rel="DataPage"> <h5>Back to Dashboard</h5></a>
        <span id="err_message" runat="server"></span>
        <br />
        <hr />
         <div id="Container">
         <form id="form1" runat="server">
               <div id="btnDelete" >
                     <asp:TextBox ID="inputId" runat="server" />
                     <asp:Button Text="Update List" ID="btnnUpdate" CssClass="delupButton" OnClick="btnnUpdate_Click" runat="server" />
                     <asp:Button Text="Delete List" ID="btnnDelete" CssClass="delupButton" OnClick="btnnDelete_Click" runat="server" />
                     
                 </div>
            <div id="gridcontainer">
                <asp:GridView runat="server" ID="gridListUser" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="ID" />
                        <asp:BoundField DataField="full_name" HeaderText="Name" />
                        <asp:BoundField DataField="email" HeaderText="Email" />
                        <asp:BoundField DataField="password" HeaderText="Password" />
                    </Columns>
                </asp:GridView>
            </div>
        </form>
         </div>
    </body>
</html>