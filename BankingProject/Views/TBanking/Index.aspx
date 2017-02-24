<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Index</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th>
            ProductName
        </th>
        <th>
            Price
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.ProductName) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Price) %>
        </td>
        <td>
    <fieldset>
    <legend>Banking Services</legend>
    <div><%: Html.ActionLink("Account Details", "AccountDetails", new { id = "C100" })%> </div>
    <div><%: Html.ActionLink("Transfer Funds","TransferFunds") %> </div>
    <div><%: Html.ActionLink("View Transactions","ViewTransactions") %> </div>
    <div><%: Html.ActionLink("Pay Bills","PayBills") %> </div>
    </fieldset>
    

</asp:Content>
