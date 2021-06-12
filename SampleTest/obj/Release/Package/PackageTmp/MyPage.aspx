<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="SampleTest.MyPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th>Id</th>
                    <th><asp:TextBox runat="server" ></asp:TextBox></th>
                </tr>
                <tr>
                    <td>
                        <asp:Button runat="server" Text="Submit" ID="btb_submit" style="height: 26px" OnClick="btb_submit_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                    <asp:Label runat="server" ID="lbl_id"  />
                    
                    </td>

                    <td>
                    <asp:Label runat="server" ID="lbl_pwd"  />
                    
                    </td>
                   
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
