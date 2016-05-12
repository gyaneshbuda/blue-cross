<%@ Page Language="C#" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Receive Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th>Receiver page
                    </th>
                    <th></th>
                </tr>
                <tr>
                    <td>First name: </td>
                    <td>

                        <%=Request.Form["txtFirstName"] %>

                    </td>
                </tr>
                <tr>
                    <td>Last name: </td>
                    <td>

                        <%=Request.Form["txtLastName"] %>
                    </td>
                </tr>
                <tr>
                    <td>Address: </td>
                    <td>

                        <%=Request.Form["txtAddress"] %>
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
