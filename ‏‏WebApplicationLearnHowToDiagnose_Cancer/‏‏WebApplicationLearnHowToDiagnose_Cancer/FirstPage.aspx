<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="WebApplication3.FirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LEARN HOW TO DIAGNOSE CANCER </title>
    <script type="text/javascript"> 
        window.history.forward();
        function noBack() {
            window.history.forward();
        }
    </script>
     <style type="text/css">
          * {
padding: 0;
margin: 0;
}
html, body {
    onload="window.history.forward();";
height: 100%;

}
body {
onload="window.history.forward();";
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
    <script language="JavaScript" type="text/javascript">
window.history.forward();              
    </script>
</head>
<body onload="window.history.forward();";>
    <form id="form1" runat="server">
       
            <table style="width: 100%; height:86%;" border="1" >
                 <tr  style="width: 100%;height:5%;">
                     
                     <th colspan="3" style="text-align:center;font-weight:700;font-size:xx-large" class="auto-style2">  LEARN HOW TO DIAGNOSE CANCER  </th>
            
                 </tr>
                 <tr  style="width: 100%;height:100%;">
                   
                     <td  style="width: 55%;height:100%;"><br />
                         <div  style="font-size:x-large" class="auto-style1"><strong><br />OUR GOAL:</strong><br />
                             <asp:Panel ID="panel1" style="width: 100%; height:100%;"  runat="server" >
                                 <asp:Label ID="MainGoalLable"  style="text-align:right;font-weight:700;font-size:x-large" class="auto-style2" runat="server"></asp:Label>
                               <asp:Label  ID="UserRoleLable" ForeColor= style="text-align:right;font-weight:700;font-size:x-large" class="auto-style2" runat="server"></asp:Label></asp:Panel>

                             
                         </div>
                     </td>
                         
                    
                       
                     <td>
                              <asp:Image ID="ImageDoctor" runat="server"  style="width: 90%;height:90%;"  ImageAlign="Middle"
                               ImageUrl="~/Images/Diagnos.jpg" />
                         
                          
                       
                     </td>
                 </tr>
                  </table><br />
                   <asp:Button ID="BtnNextPage1" runat="server" Text="NEXT PAGE"  Height="6%" 
                              width ="8%" OnClick="BtnNextPage1_Click" style="margin-left:90%" Font-Names="Guttman Yad-Brush"  />
      
       
    </form>
</body>
</html>
