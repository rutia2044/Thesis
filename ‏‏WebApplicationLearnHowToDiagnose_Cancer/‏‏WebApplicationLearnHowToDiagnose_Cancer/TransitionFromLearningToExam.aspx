<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransitionFromLearningToExam.aspx.cs" Inherits="WebApplication3.TransitionFromLearningToExam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>MOVING FROM THE LEARNING PHASE TO TESTING PHASE </title>
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
     <table style="width: 100%; height:90%;" border="1" >
                 <tr style="width:100%;height:3%;">
                     
                     <th colspan="3" style="text-align:center;font-weight:700;font-size:xx-large" > MOVING FROM THE LEARNING PHASE TO TESTING PHASE  </th>
            
                 </tr>
                 <tr style="width:100%;height:90%;">
                   
                     <td style="width: 55%;">
                         <div  style="text-align:center;font-size:xx-large" ><strong>WELL DONE!<br /> <br />You have completed the learning phase.<br /><br />
                        We will now move on to the testing phase.<br /><br /></strong>
                             
                         </div>
                        <div  style="text-align:center;font-size:xx-large" > At this phase you will be presented with 12 cases of different patients and you will need to diagnose them according to what you have learned.
                        <br />You will be given a bonus salary according to your level of success in the diagnosis you will perform, therefore you should  answer according to what you remember and not guess, if you do not know the answer you can choose the "don't know" option.
                            </div>    
                     </td>
                         
                    
                       
                     <td>
                              <asp:Image ID="ImageTest" runat="server" style="width: 85%;height:90%;" ImageAlign="Baseline"
                               ImageUrl="~/Images/testImage.png" /><br />
                         
                          
                       
                     </td>
                 </tr>
                  </table>
                   <asp:Button ID="BtnBeginTest" runat="server" Font-Names="Guttman Yad-Brush" Text="NEXT" Height="6%" 
                              width ="8%"  style="margin-left:90%"  OnClick="BtnBeginTest_Click"  />
   
  
    </form>
</body>
</html>
