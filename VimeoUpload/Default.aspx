<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VimeoUpload._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <div class="row" style="margin-top:50px;margin-left:100px">
        <div class="col-md-4">
            <asp:FileUpload ID="fuVideoFile" runat="server" />
            <p>
                <asp:Button runat="server" ID="upload_btn" Text="Upload" OnClick="upload_btn_Click" class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948"/>
            </p>
        </div>
      
    </div>

</asp:Content>
