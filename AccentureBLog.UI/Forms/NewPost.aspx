<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewPost.aspx.cs" Inherits="AccentureBLog.UI.Forms.NewPost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h4>Crear nuevo post.</h4>
    <hr>
    <div class="validation-summary-valid text-danger" data-valmsg-summary="true">
        <ul>
            <li style="display: none"></li>
        </ul>
    </div>
    <div class="form-group">
        <label class="col-md-2 control-label" for="Title">Titulo</label>
        <div class="col-md-10">
            <input class="form-control" data-val="true" id="txtTitle" name="txtTitle" type="text" runat="server">
        </div>
    </div>
    <div class="form-group">
        <label class="col-md-2 control-label" for="Content">Contenido</label>
        <div class="col-md-10">
            <textarea name="txtContent" id="txtContent" cols="40" rows="5" runat="server"></textarea>

        </div>
    </div>
    <div class="form-group">
        <label class="col-md-2 control-label" for="Author">Autor</label>
        <div class="col-md-10">
            <input class="form-control" data-val="true" id="txtAuthor" name="txtAuthor" runat="server">
        </div>
    </div>
    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <asp:Button Text="Guardar" class="btn btn-default" runat="server" ID="btnSave" OnClick="btnSave_Click" />
        </div>
    </div>

    <!-- Modal -->
    <div class="modal fade" id="myModal" role="dialog">
        <div class="modal-dialog">

            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">Confirmación</h4>
                </div>
                <div class="modal-body">
                    <p>
                        <asp:Label Text="text" runat="server"  ID="txtMessage"/></p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                </div>
            </div>

        </div>
    </div>


</asp:Content>
