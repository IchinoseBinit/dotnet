<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="Form.aspx.cs" Inherits="Form" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
        <br />
        <div class="container">
            <div class="row">
                <div class="col-md-6">                    
                    <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
                </div>
                <div class="col-md-6">                    
                    <asp:TextBox ID="txtBoxName" runat="server"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-6">                   
                    <asp:Label ID="Label2" runat="server" Text="Address: "></asp:Label>
                </div>
                <div class="col-md-6">                   
                    <asp:TextBox ID="txtBoxAddress" runat="server"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-6">
                    <asp:Label ID="Label3" runat="server" Text="Age: "></asp:Label>
                </div>
                <div class="col-md-6">
                     <asp:TextBox ID="txtBoxAge" runat="server"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row" >
                <div class="col-lg-12">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn btn-primary" />
                </div>
            </div>

            <asp:Label ID="lblDetails" runat="server" Text=""></asp:Label>


        </div>
    
</asp:Content>
