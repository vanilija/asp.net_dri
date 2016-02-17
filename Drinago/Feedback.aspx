<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="Drinago.Views.Home.Feedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            width: 1273px;
            height: 370px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2 align="center">Please, leave your feedback here.</h2>
    </div>
    </form>
    <p>
        <textarea id="TextArea1" name="S1"></textarea></p>
    <p>
        Your feedback will help us add or resolve issues around the website.
        I am just a feedback form, i am not pretty though.

        I dont have any styling applied either. This is just for testing purposes.
    </p>
</body>
</html>
