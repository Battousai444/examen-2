<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebMartriculas.aspx.cs" Inherits="WebMatricula.webparcial2.WebMartriculas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
&nbsp;<table class="nav-justified" style="width: 89%; height: 456px">
            <tr>
                <td class="text-center" colspan="2" style="font-size: xx-large; color: #0000FF"><strong>MATRICULAS</strong></td>
            </tr>
            <tr>
                <td style="font-size: x-large; width: 634px; height: 34px"><strong>CARRERA:</strong></td>
                <td class="text-center" style="height: 34px">
                    <asp:DropDownList ID="DDLCarrera" runat="server" style="font-size: x-large">
                        <asp:ListItem>TECNOLOGIA</asp:ListItem>
                        <asp:ListItem>INGENIERIA</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large; height: 34px; width: 634px"><strong>HORAS:</strong></td>
                <td class="text-center" style="height: 34px">
                    <asp:TextBox ID="TXTHoras" runat="server" style="font-size: x-large" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large; width: 634px"><strong>ESTRATO:</strong></td>
                <td class="text-center"><strong>
                    <asp:DropDownList ID="DDLEstrato" runat="server" style="font-size: x-large">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                    </asp:DropDownList>
                    </strong></td>
            </tr>
            <tr>
                <td class="text-center" colspan="2">
                    <asp:Button ID="BTNCalcular" runat="server" BackColor="#66FFFF" ForeColor="Black" OnClick="BTNCalcular_Click" style="font-size: x-large" Text="CALCULAR" />
                    <asp:Button ID="BTNLimpiar" runat="server" BackColor="#99FF66" OnClick="BTNLimpiar_Click" style="font-size: x-large" Text="LIMPIAR" />
                </td>
            </tr>
            <tr>
                <td style="width: 634px"><strong>
                    <asp:Label ID="LBLError" runat="server" style="font-size: large; color: #FF0066"></asp:Label>
                    </strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="font-size: x-large; height: 41px; width: 634px"><strong>PORCENTAJE DESCUENTO:</strong></td>
                <td class="text-center" style="height: 41px"><strong>
                    <asp:Label ID="LBLPorcentajeDescuento" runat="server" style="font-size: x-large" Text="-"></asp:Label>
                    </strong></td>
            </tr>
            <tr>
                <td style="font-size: x-large; width: 634px"><strong>VALOR DESCUENTO:</strong></td>
                <td class="text-center"><strong>
                    <asp:Label ID="LBLValorDescuento" runat="server" style="font-size: x-large" Text="-"></asp:Label>
                    </strong></td>
            </tr>
            <tr>
                <td style="font-size: x-large; width: 634px"><strong>VALOR SIN DESCUENTO:</strong></td>
                <td class="text-center"><strong>
                    <asp:Label ID="LBLValorPagar" runat="server" style="font-size: x-large" Text="-"></asp:Label>
                    </strong></td>
            </tr>
            <tr>
                <td style="font-size: x-large; height: 45px; width: 634px"><strong>TOTAL A PAGAR</strong></td>
                <td class="text-center" style="height: 45px"><strong>
                    <asp:Label ID="LBLTotalPagar" runat="server" style="font-size: x-large" Text="-"></asp:Label>
                    </strong></td>
            </tr>
            <tr>
                <td style="width: 634px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        &nbsp;</p>
    <p>
        <div class="text-center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        &nbsp;</p>
</asp:Content>
