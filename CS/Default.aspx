<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EditableDetails._Default" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dxwgv:ASPxGridView ID="masterGrid" runat="server" AutoGenerateColumns="true" KeyFieldName="ID">
                <Templates>
                    <DetailRow>
                        <dxwgv:ASPxGridView ID="detailGrid" runat="server" AutoGenerateColumns="true"
                            KeyFieldName="ID" OnBeforePerformDataSelect="detailGrid_BeforePerformDataSelect">
                        </dxwgv:ASPxGridView>
                    </DetailRow>
                </Templates>
                <SettingsDetail ShowDetailRow="True" />
            </dxwgv:ASPxGridView>
        </div>
    </form>
</body>
</html>
