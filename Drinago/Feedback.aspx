<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="Drinago.Views.Home.Feedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            width: 417px;
            height: 370px;
            margin-right: 0px;
        }
    </style>
</head>
<body class="feedbackform">
    <div>
        <form id="form1" runat="server">
            <h2 align="center" style="width: auto"><br />Please, leave your feedback here.</h2>
        </form>
        <p style="width: auto">
            <textarea id="TextArea" name="S1"></textarea>
        </p>
        <p class="feedbackformtxt" style="width: auto"><br />Your feedback will help us add or resolve issues around the website.<br />
        I am just a feedback form, i am not pretty though.<br />
        I dont have any styling applied either. This is just for testing purposes.</p>
        <p class="dugme" style="width: 419px"><input id="Submit" type="submit" value="Submit your feedback" /></p>
    </div>
    <style>

        .feedbackform {
            background-color: orange;
            margin-right: 20px;
            margin-left: 20px;
        }
        .dugme {
            margin-right: 20px;
            margin-left: 20px;
        }
        h2, .feedbackformtxt {
            background-color: white;
            box-shadow: 0 1px 3px rgba(0, 0, 0, 0.12), 0 1px 2px rgba(0, 0, 0, 0.24);
            padding-left: 1em;
            padding-right: 1em;
            padding-top: 0.1em;
            padding-bottom: 0.1em;
            font-family: 'Roboto', sans-serif;
            color: black;
            align-content:center;
            margin-right: 20px;
            margin-left: 20px;
        }

        #TextArea {
            margin-right: 20px;
            margin-left: 20px;
        }
    </style>

</body>
</html>
