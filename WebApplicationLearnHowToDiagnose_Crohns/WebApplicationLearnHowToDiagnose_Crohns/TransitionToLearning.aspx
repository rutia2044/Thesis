<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransitionToLearning.aspx.cs" Inherits="WebApplication3.TransitionToLearning" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>MOVING TO LEARNING  PHASE </title>
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
           height: 2%;        }
           .auto-style3{font-size:xx-large;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <table style="width: 100%; height:87%;" border="1" >
                 <tr style="width:100%;height:3%;">
                     
                     <th colspan="3" style="text-align:center;font-weight:700;font-size:xx-large" >  MOVING TO THE LEARNING  PHASE </th>
            
                 </tr>
                 <tr style="width:100%;height:90%;">
                   
                     <td style="width: 55%;">
                         <div  style="text-align:center;font-size:xx-large" ><strong><br /><br />You are going to start the learning phase. <br /> <br /></strong>
                             In this phase you will be presented with 12 cases of patients diagnosed using the diagram. <br /><br />As mentioned, you will now have a new diagram.                          
                             <br />
                       you should look at the cases that will be presented one after another and understand their diagnosis according to the diagram.
                             
                               <br /><br /><br /><br /><br />
                             
                         </div>
                        
                              
                     </td>
                         
                    
                       
                     <td>
                              <asp:Image ID="ImageTest" runat="server" style="width: 85%;height:90%;" ImageAlign="Baseline"
                               ImageUrl="~/Images/lerningImg.png" /><br />
                         
                          
                       
                     </td>
                 </tr>
                  </table><br />
                   <asp:Button ID="BtnBeginLearning" runat="server" Font-Names="Guttman Yad-Brush" Text="BEGIN LEARNING" Height="6%" 
                              width ="10%"  style="margin-left:90%"  OnClick="BtnBeginLearning_Click"  />
   
  
    </form>
</body>
</html>
