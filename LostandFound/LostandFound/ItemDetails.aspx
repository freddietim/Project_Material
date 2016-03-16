<%@ Page Title="Item Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemDetails.aspx.cs" Inherits="LostandFound.ItemDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<asp:FormView ID="itemDetail" runat="server" ItemType="LostandFound.Models.Item" SelectMethod ="GetItem" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.ItemName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Catalog/Images/images1/C&Q.png<%#:Item.ImagePath %>" style="border:solid; height:300px" alt="<%#:Item.ItemName %>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Description:</b><br /><%#:Item.Description %>                      
                        <span><b>Product Number:</b>&nbsp;<%#:Item.ItemID %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
