<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiagramExplanation.aspx.cs" Inherits="WebApplication3.DiagramExplanation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>LEARN HOW TO DIAGNOSE CANCER </title>
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
#container {
min-height: 100%;
background-color: #DDD;
border-left: 2px solid #666;
border-right: 2px solid #666;
width: 676px;
margin: 0 auto;
}
* html #container {
height: 100%;
}
#form1
{
	height:100%;
	}

        .auto-style1{font-size:large;}
        .auto-style2 {
           height: 2%;
        }
    </style>
</head>
<body>
      <form id="form1" runat="server">
        
            <table style=" height:90%;width: 100%;"   border="0" >
                 <tr>
                     
                     <th colspan="3" style="text-align:center;font-size:xx-large" class="auto-style2"> DIAGRAM  &nbsp  EXAMPLE  &nbsp EXPLANATION  <br /></th>
            
                 </tr>
                <tr> <th colspan="3"  style="text-align:left" >
                     <asp:Label  ID="ExplainTheDiagramLbl" runat="server"   style="font-size:x-large"  > </asp:Label>
                   <asp:Label  ID="Label11" runat="server"   style="font-size:x-large; color:red"  > &nbsp Please note: This is just an example diagram, 
                    Later you will be given a different diagram.
                   </asp:Label>
                  
                    </th>
                </tr>
                 <tr>
                   <td align="center">   
                       <br />
                           <asp:Image ID="Image1" runat="server" style="width: 80%; height:90%;" ImageAlign="Middle" 
                               ImageUrl="~/Images/ExampleOfDiagram.png" />
                     </td>
                
                 </tr>
                  </table>
                 

                  
                 <asp:Button ID="BtnNext" runat="server" Text="NEXT"  Height="6%" 
                              width ="8%" style="margin-left:90%" Font-Names="Guttman Yad-Brush"  OnClick="BtnNext_Click" />
      
    </form>
</body>
</html>
