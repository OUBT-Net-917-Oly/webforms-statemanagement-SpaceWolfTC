<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebForms_StateManagement._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Working with cookies (Client side state management)</h2>
            <%--Implement an onclick event for btnAddCookie that saves the text in txtCookieMessage into a cookie--%>
            Message: <asp:TextBox ID="txtCookieMessage" runat="server"></asp:TextBox>
            <asp:Button id="btnAddCookieMessage" Text="Add cookie" runat="server" /><br />
            <br />

            <%--Implement an onclick event for btnGetCookie that displays the cookie message in lblCookieMessage --%>
            <asp:Button ID="btnGetCookie" Text="Get cookie" runat="server" />
            <asp:Label ID="lblCookieMessage"></asp:Label><br />
            <br />

            <%--Implement an onclick event for btnExpireCookie that expires the cookie you created in btnAddCookie--%>
            <asp:Button ID="btnExpireCookie" Text="Expire cookie" runat="server" />
        </div>
        <div>
            <h2>Working with Session state (Server side state management)</h2>
            <%--Implement an onclick event for btnAddSessionMessage that saves the text in txtSessionMessage--%>
            <%--After creating the session data your method should redirect to a new page called "SessionState.aspx" in the "Pages" folder--%>
            <%--On SessionState.aspx use the page_load event to write the session variable out to a label called lblSessionStateMessage--%>
            Message: <asp:TextBox ID="txtSessionMessage" runat="server"></asp:TextBox>
            <asp:Button id="btnAddSessionMessage" Text="Add session message" runat="server" /><br />
            <br />
        </div>
    </form>
</body>
</html>
