<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webapp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="styles.css" />
</head>
<body style="height: 308px">
    <form id="form1" runat="server">
        <table border="1">
            <thead>
                <tr>
                    <th>&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;</th>
                    <th style="text-align: left">COMPONENTES</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Caja de Texto</td>
                    <td>
                        <input type="text" id="text" runat="server" />

                    </td>
                </tr>
                <tr>
                    <td>Combo</td>
                    <td>
                        <select id="combo" runat="server">
                            <option>Argentina</option>
                            <option>Italia</option>
                            <option>Alemania</option>
                            <option>Portugal</option>
                        </select></td>
                </tr>
                <tr>
                    <td>Imagen</td>
                    <td>
                        <input type="file" id="file" runat="server" /></td>
                </tr>
                <tr>
                    <td>CheckBox</td>
                    <td>
                        <input type="checkbox" id="checkboxSI" runat="server" />SI
                        <input type="checkbox" id="checkboxNO" runat="server" />NO
                    </td>
                </tr>
                <tr>
                    <td>Hipervínculo</td>
                    <td><a href="http://www.google.com" target="_blank" id="web" runat="server">Google</a></td>
                </tr>
                <tr>
                    <td>Radio Button</td>
                    <td>
                        <input type="radio" name="radio" id="alta" runat="server" />Alta
                        <input type="radio" name="radio" id="media" runat="server" />Media
                        <input type="radio" name="radio" id="baja" runat="server" />Baja
                    </td>
                </tr>
                <tr>
                    <td>Campo Oculto</td>
                    <td>
                        <input type="hidden" id="hidden" runat="server" /></td>
                </tr>
                <tr>
                    <td>Botón</td>
                    <td>
                        <input type="submit" id="submit" value="Button" onserverclick="submit_ServerClick" runat="server" /></td>
                </tr>
            </tbody>
        </table>
    </form>

    <table id="tabla2" runat="server" visible="false" border="1">
    </table>
</body>
</html>
