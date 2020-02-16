<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="VimeoUploadVideo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

    <div class="row" style="margin-top:50px;margin-left:100px">
        <div class="col-md-4">
           
            <p>
                <asp:Button runat="server" ID="upload_btn" OnClick="upload_btn_Click" class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Upload</asp:Button>
            </p>
        </div>
      
    </div>

</asp:Content>
