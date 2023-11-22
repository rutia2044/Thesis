<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LEARN HOW TO DIAGNOSE CROHN'S </title>
     <style type="text/css">
 * {
padding: 0;
margin: 0;
}

body {
    background-image: url('Images/ImgLogIn.jpg');
    background-repeat: no-repeat;
    background-size: cover; /* will auto resize to fill the screen */
    font-size: 75%;
}
h1 {
font-size: 1.4em;
padding: 10px 10px 0;
}
p {
padding: 0 10px 1em;
}



#form1
{
	height:100%;
	}
 .auto-style3{font-size:medium;}
        .auto-style1{font-size:xx-large;}
        .auto-style2 {
          font-size:large;
        }
    </style>  

</head>
<body>
    <form id="form1" runat="server"  style="text-align:center;">
         <div><br /><br /><br /><br />
              <h2 class="auto-style1" style="text-align:center;font-weight:700 "> LOG IN </h2>

                <!-- Icon -->
                <div class="fadeIn first">
                    <img src="https://img.icons8.com/ultraviolet/40/000000/administrator-male.png" style="width: 6%; height:6%;" alt="User Icon" />
                </div>
               <br />
             <asp:Label class="auto-style2"  runat="server"  ID="Lbl_text"   >Enter your ID:</asp:Label>
                 <br />
            <asp:TextBox class="auto-style2" ID="TextBox1" OnTextChanged="Txt1change" Height="25%" 
                              width ="18%" runat="server"></asp:TextBox>
            <br />
            <asp:Label class="auto-style2" ID="Lbl_error" runat="server"  ForeColor="Red" Visible="false">An ID that exists in the database or is empty is invalid, Try again </asp:Label>
             <br />
             <asp:Button class="auto-style2" ID="BtnNext" runat="server" Text="ENTER" Height="25%" 
                              width ="18%" OnClick="BtnNext_Click" Font-Names="Guttman Yad-Brush"/>
        </div>
    </form>
</body>
</html>
