<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RDestinatario.aspx.cs" Inherits="ProjectoCarta.Registros.RDestinatario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel" style="background-color: black">
        <div class="panel-heading" style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: medium; color: white">
            Registro de destinatario
        </div>
    </div>
    <div class="panel-body">
        <div class="form-horizontal col-md-12" role="form">
            <div class="form-group">
                <label for="DestinatarioIdTextBox" class="col-md-3 control-label input-sm" style="font-size: large">Id de destinatario</label>
                <div class="col-md-1 col-sm-2 col-xs-4">
                    <asp:TextBox ID="DestinatarioIdTextBox" runat="server" placeholder="0" class="form-control input-sm" Style="font-size: large" TextMode="Number"></asp:TextBox>
                </div>
                <asp:RegularExpressionValidator ID="ValidaID" runat="server" ErrorMessage='El Campo "Id de destinatario" solo acepta numeros' ControlToValidate="DestinatarioIdTextBox" ValidationExpression="^[0-9]*" Text="*" ForeColor="Red" Display="Dynamic" ToolTip="Entrada no valida" ValidationGroup="Guardar"></asp:RegularExpressionValidator>
                <div class="col-md-1 col-sm-2 col-xs-4">
                    <asp:Button ID="BuscarButton" runat="server" Text="Buscar" class="btn btn-info btn-sm" OnClick="BuscarButton_Click" />
                </div>
            </div>
            <div class="form-group">
                <label for="NombreTextBox" class="col-md-3 control-label input-sm" style="font-size: large">Nombre</label>
                <div class="col-md-3">
                    <asp:TextBox ID="NombreTextBox" runat="server" class="form-control input-sm" Style="font-size: large"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ValidaNombre" runat="server" ErrorMessage="El campo &quot;Nombre&quot; Esta vacio" ControlToValidate="NombreTextBox" ForeColor="Red" Display="Dynamic" ToolTip="Campo Nombre es obligatorio" ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                </div>
                <label for="CantidadTextBox" class="col-md-1 control-label input-sm" style="font-size: large">Cantidad</label>
                <div class="col-md-3">
                    <asp:TextBox ID="CantidadTextBox" runat="server" class="form-control input-sm" Style="font-size: large" ReadOnly="true"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-8">
                    <asp:TextBox ID="FechaTextBox" TextMode="Date" runat="server" class="form-control input-sm" Style="font-size: large" Visible="false"></asp:TextBox>
                </div>
            </div>
            <div class="panel">
                <div class="text-center">
                    <div class="form-group">
                        <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" class="btn btn-primary btn-md" OnClick="NuevoButton_Click" />
                        <asp:Button ID="GuardarButton" runat="server" Text="Guardar" class="btn btn-success btn-md" ValidationGroup="Guardar" OnClick="GuardarButton_Click" />
                        <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" class="btn btn-danger btn-md" OnClick="EliminarButton_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

