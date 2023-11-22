﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExampleOfTest.aspx.cs" Inherits="WebApplication3.ExampleOfTest" %>

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

#form1
{
	height:100%;
	}
 .auto-style3{font-size:medium;}
        .auto-style1{font-size:large;}
        .auto-style2 {
           height: 2%;
        }
         .auto-style5{font-size:x-large;}
         .auto-style4{font-size:xx-large;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
               
                <div    style="text-align:center" class="auto-style4"   ><strong> EXAMPLE OF THE TESTING PHASE </strong> </div>
   
         <asp:Label ID="ExplainTheExampleLbl"  style="margin-left:2%" class="auto-style5"  runat="server"> </asp:Label>

                <table style="width: 100%; height:54%;"  border="1" >
                
                 <tr>
                     <td style="width: 35%;height:47%;">
                         <div class="auto-style1"><strong>&nbsp PATIENT DATA:</strong>
                             <asp:Panel ID="panel1" runat="server" BackColor="#F0F0F0">
                                  <asp:Label ID="Label_1_a" runat="server">&nbsp IS THERE RECTAL MUCUS? </asp:Label>&nbsp<asp:Label ID="lblRectalMucusE" runat="server"></asp:Label><br/><br/>
                                  <asp:Label ID="Label_2_a" runat="server">&nbsp IS THERE BOWEL CHANGE?  </asp:Label>&nbsp<asp:Label ID="lblBowelChangeE" runat="server"></asp:Label><br/><br/>
                                   <asp:Label ID="Label_2_b" runat="server">&nbsp IS THERE FATIGUE? </asp:Label>&nbsp<asp:Label ID="lblFatigueE" runat="server"></asp:Label><br/><br/>
                                 <asp:Label ID="Label_3_a" runat="server">&nbsp HAS THE PATIENT SUFFERED FROM GI PROBLEMS? </asp:Label>&nbsp<asp:Label ID="lblSuggerGI_ProblemsE" runat="server"></asp:Label><br/><br/>
                                 <asp:Label ID="Label_3_b" runat="server">&nbsp HAS THE PATIENT EVER BEEN OVERWEIGHT? </asp:Label>&nbsp<asp:Label ID="lblEverBennOverweightE" runat="server"></asp:Label><br/><br/>
                                  
                             </asp:Panel>

                         </div>
                     </td>

                       
                     <td style="width: 65%;height:47%;">
                         <div class="auto-style1"><strong>&nbsp What is your diagnosis?</strong></div>
                     

                         <asp:RadioButtonList ID="RadBtn_classification"  class="auto-style3" runat="server" >
                                 <asp:ListItem>&nbsp NORMAL</asp:ListItem>
                             <asp:ListItem> &nbspSUSPECTED CROHN'S</asp:ListItem>  
                              <asp:ListItem>&nbsp DON'T KNOW</asp:ListItem> 
                         </asp:RadioButtonList>

                         <br />
                        <asp:Label ID="Label_which" class="auto-style1" runat="server"><strong>&nbsp  Which patient's data according to the diagram you learned are the basis of your diagnosis?</strong></asp:Label>
                           <asp:Label ID="Label20" class="auto-style1" runat="server"> <strong> &nbsp (You can select more than one option)</strong><br /></asp:Label>
                        <asp:CheckBoxList ID="CheckBoxList1" class="auto-style3" runat="server" >
                      <asp:ListItem>&nbsp IS THERE RECTAL MUCUS</asp:ListItem>
                      <asp:ListItem> &nbsp IS THERE BOWEL CHANGE</asp:ListItem>
                     <asp:ListItem>&nbsp IS THERE FATIGUE</asp:ListItem>
                     <asp:ListItem>&nbsp HAS THE PATIENT SUFFERED FROM GI PROBLEMS</asp:ListItem>
                      <asp:ListItem>&nbsp HEIGHT</asp:ListItem>
                       <asp:ListItem>&nbsp HAS THE PATIENT EVER BEEN OVERWEIGHT</asp:ListItem>
                     
                         </asp:CheckBoxList>                     
                        
                     </td>
                 </tr>
                  </table>
                 
                  <asp:Button ID="Btn1" runat="server" Font-Names="Guttman Yad-Brush" Text="BEGIN TEST" Height="6%" 
                              width ="8%"  style="margin-left:90%" OnClick="Btn1_Click"/>
      
       
    </form>
</body>
</html>
