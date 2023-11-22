<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExampleOnTheModelPage.aspx.cs" Inherits="WebApplication3.ExampleOnTheModelPage" %>

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
 .auto-style4{font-size:x-large;}
        .auto-style1{font-size:large;}
         .auto-style3{font-size:xx-large;}
        .auto-style2 {
           height: 2%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      
                     
               <div  style="text-align:center;" class="auto-style3" ><strong> EXAMPLE OF THE LEARNING PHASE<br /></strong> </div>
  <br />
               <asp:Label ID="ExplainTheExampleLabel"   runat="server"   style="text-align:center; font-size:x-large"> </asp:Label>
        <br /><br />
         <asp:Label ID="Label2"   runat="server"   style="text-align:center; font-size:x-large"> 
         &nbsp The patient data highlighted in green background (in the left column) are the answers of the current patient to the diagram questions in the green rectangles(right column).
              </asp:Label>
                <table style="width: 100%;height:40%;"  border="1" >
                 <tr>
                     <td  style="width: 35%;height:100%;">
                         <div class="auto-style1"><strong>&nbsp PATIENT DATA:<br /></strong>
                             <asp:Panel ID="panel1" runat="server"  Height="90%" Width="100%" BackColor="#F0F0F0">
                                 <asp:Label ID="Label_1_a"  runat="server" BackColor="LightGreen">&nbsp IS THERE CROHN'S IN THE FAMILY?: </asp:Label>&nbsp<asp:Label ID="lblYearsSinceAcidTasteStart" BackColor="LightGreen"  runat="server"></asp:Label><br/><br/>
                                 <asp:Label ID="LabelStom_2_a"   runat="server">&nbsp HEADACHE LEVEL: </asp:Label>&nbsp<asp:Label ID="lblStonachPain"  class="auto-style1"  runat="server"></asp:Label><br/><br/>
                                 <asp:Label ID="Label_2_b" runat="server">&nbsp WEIGHT: </asp:Label>&nbsp <asp:Label ID="lblGender" runat="server"></asp:Label><br/><br/>
                                 <asp:Label ID="Label_3_a" runat="server">&nbsp AGE: </asp:Label>&nbsp<asp:Label ID="lblAge" runat="server"></asp:Label><br/><br/>                                
                                  <asp:Label ID="LabelChest_3_c" runat="server">&nbsp CHEST PAIN LEVEL: </asp:Label>&nbsp<asp:Label ID="lblChestPain" runat="server"></asp:Label><br/><br/>
                                 
                                 <br /> <asp:Label ID="Label13" BackColor="LightGreen" runat="server">&nbsp DIAGNOSIS: </asp:Label>&nbsp<strong><asp:Label ID="lblClassification" BackColor="LightGreen" runat="server"></asp:Label></strong>

                             </asp:Panel>

                         </div>
                     </td>

                       <td>
                         <div class="auto-style1"><strong> &nbsp DIAGRAM: </strong>     </div>
                           <asp:Image ID="Image1" runat="server" Height="85%" Width="100%" ImageAlign="AbsMiddle"
                               ImageUrl="~/Images/IndepandentExampleDiagram.png" /><br /><br />
                     </td>
                
                 </tr>
              
                  </table> 
             
               
  <br />
         <asp:Label  ID="Label11" runat="server"   style="font-size:x-large; color:red"  >  Please note: This is just an example diagram,  later you will be given a different diagram. </asp:Label>
                  
                   <asp:Button ID="BtnBeginLearning" runat="server" Font-Names="Guttman Yad-Brush" Text="MOVE TO LEARNING" Height="6%" 
                              width ="11%"  style="margin-left:88%" OnClick="BtnBeginLearning_Click"/>
     
    </form>
</body>
</html>
