<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnimationForm.aspx.cs" Inherits="WebApplication3.AnimationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>LEARN HOW TO DIAGNOSE CROHN'S </title>
     <style type="text/css">
            * {
padding: 0;
margin: 0;
}
html, body {
height: 100%;
}
body {

font-size: 75%;
}
h1 {
font-size: 1.4em;
padding: 10px 10px 0;
}
p {
padding: 0 10px 1em;
}

* html #container {
height: 100%;
}
#form1
{
	height:95%;
    width:100%;
	}

        .auto-style1{font-size:large;}
        .auto-style2 {
           height: 2%;
        }
          .auto-style3{font-size:xx-large;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div  style="text-align:center;" class="auto-style3" ><strong> EXAMPLE:  Follow patient's symptoms/data and diagnosis:  </strong> </div> 
         <asp:Label ID="Labe21"   runat="server"   style="text-align:center; font-size:x-large"> 
        The patient data highlighted in green (in the left column) are the answers to the diagram questions in the green rectangles (right column).
         </asp:Label>
        <video  autoplay loop controls="controls" style="width: 100%;height:80%;" >
            <source  id="src1" src="~/Images/‏‏animation3.mp4"  type="video/mp4" runat="server"  /></video><br/>
           <asp:Label  ID="ExplainTheDiagramLbl1" runat="server"  style="font-size:x-large;text-align:center"  >
</asp:Label><br />
                <asp:Label  ID="Label11" runat="server"   style="font-size:x-large; color:red"  > &nbsp Please note: This is just an example diagram,  later you will be given a different diagram. </asp:Label>
                     
                   <asp:Button ID="BtnNext" runat="server" Font-Names="Guttman Yad-Brush" Text="NEXT" Height="6%" 
                              width ="9%"  style="margin-left:88%" OnClick="BtnNext_Click"/>
     
    </form>
</body>
</html>
