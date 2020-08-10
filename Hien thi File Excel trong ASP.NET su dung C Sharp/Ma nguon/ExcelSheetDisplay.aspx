<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExcelSheetDisplay.aspx.cs" Inherits="ExcelSheetDisplay" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Excel Sheet / Chart Display</title>
</head>
<body>
    <form id="frmExcelSheet" runat="server">
    <div>
    <table>
        <tr>
            <td style="width: 970px">
                <asp:Label ID="lblHeading" runat="server" Text="Chọn File Excel để hiển thị" ForeColor="Blue" />
                <br />
                <asp:Panel ID="pnlTopPane" runat="server" Width="800px">
                    <input type="file" id="txtfileValue" name="txtfileValue" runat="server" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnAvailableShtAndChrt" runat="server" Text="List.." OnClick="btnAvailableShtAndChrt_Click" Height="21px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="drpShtAndChrt" runat="server" Width="270px"></asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnDisplay" runat="server" Text="Display" OnClick="btnDisplay_Click" Height="20px" />
                    <br />
                    <asp:Label ID="lblErrText" runat="server" />
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td style="width: 970px">
                <asp:Panel ID="pnlBottPane" runat="server" Height="510px" ScrollBars="Auto" Width="970px" BorderWidth="1px">
                </asp:Panel>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
