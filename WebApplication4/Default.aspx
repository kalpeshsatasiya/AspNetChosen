<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/chosen.min.css" rel="stylesheet" />
    <br />
    <br />
    <br />
    <div class="row">
        <asp:DropDownList ID="DDLCOUNTRY" runat="server"  class="chosen-select" multiple style="Width:350px;" >
    </asp:DropDownList>
    </div>
    
    <script src="Content/chosen.jquery.js"></script>
    
    <script type="text/javascript">

        $(document).ready(function () {
            $(".chosen-select").chosen({ disable_search_threshold: 10 });
            $.ajax({
                url: "WebService1.asmx/GetCustomersNew",
                type: "POST",
                contentType: "application/json",
                datatype: "json",
                beforeSend: function () {
                    $("#<%= DDLCOUNTRY.ClientID %>").empty();
                }
            }).done(function (data) {
                $.map(data.d, function (item) {
                    $('#<%= DDLCOUNTRY.ClientID %>').append('<option value="' + item.CountryID + '">' + item.CountryName + '</option>');
                });

                $("#<%= DDLCOUNTRY.ClientID %>").trigger("chosen:updated");

            });
            });
    </script>
</asp:Content>
