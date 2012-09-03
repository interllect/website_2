<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SectionLevel.ascx.cs" Inherits="UserControls_SectionLevel" %>
<asp:Repeater ID="My_Nav" runat="server" EnableViewState="False">
    <HeaderTemplate><ul></HeaderTemplate>
    <ItemTemplate>
        <li>
			<asp:HyperLink runat="server" NavigateUrl='<%# Eval("Url") %>' Text='<%# Eval("Title") %>'></asp:HyperLink>
            - <%# Eval("Description") %>
		</li>
    </ItemTemplate>
    <FooterTemplate></ul></FooterTemplate>
</asp:Repeater>