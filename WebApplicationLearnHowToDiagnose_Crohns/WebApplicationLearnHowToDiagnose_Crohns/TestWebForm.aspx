<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestWebForm.aspx.cs" Inherits="WebApplication3.TestWebForm1" %>

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
#TestForm
{
	height:100%;
	}



        .auto-style1{font-size:large;}
        .auto-style3{font-size:x-large;}
        .auto-style5{font-size:medium;}
        .auto-style2 {
           height: 2%;
        }
          .auto-style4{font-size:xx-large;}
    </style>
</head>
<body>
    <form id="TestForm" runat="server">
           <div  style="text-align:center;" class="auto-style4" id="divTitle"><strong>THE TESTING PHASE<br /></strong> </div>

               <asp:Label ID="Label2"   runat="server"   style="text-align:center; font-size:x-large" >Please mark your diagnosis in the right column for the patient whose data appears in the left column based on what you have learned.<br /> </asp:Label>
        <br />
      <table style="width: 100%;height:78%;" border="1" >
                
                 <tr>
                    <td  style="width: 45%;height:100%;">
                         <div class="auto-style3"><strong>PATIENT DATA:<br /><br /></strong>
                             <asp:Panel ID="panel1" runat="server" BackColor="#F0F0F0">
                                 <asp:Label ID="Label_1_a" runat="server">&nbsp IS THERE RECTAL MUCUS? </asp:Label>&nbsp<asp:Label ID="lblRectalMucus" runat="server"></asp:Label><br/><br/>
                                  <asp:Label ID="Label_2_a" runat="server">&nbsp IS THERE BOWEL CHANGE?  </asp:Label>&nbsp<asp:Label ID="lblBowelChange" runat="server"></asp:Label><br/><br/>
                                   <asp:Label ID="Label_2_b" runat="server">&nbsp IS THERE FATIGUE? </asp:Label>&nbsp<asp:Label ID="lblFatigueT" runat="server"></asp:Label><br/><br/>
                                 <asp:Label ID="Label_3_a" runat="server">&nbsp HAS THE PATIENT SUFFERED FROM GI PROBLEMS? </asp:Label>&nbsp<asp:Label ID="lblSuggerGI_Problems" runat="server"></asp:Label><br/><br/>
                                 <asp:Label ID="Label_3_b" runat="server">&nbsp HAS THE PATIENT EVER BEEN OVERWEIGHT? </asp:Label>&nbsp<asp:Label ID="lblEverBennOverweight" runat="server"></asp:Label><br/><br/>
                                  
                             </asp:Panel>

                         </div>
                     </td>

                       
                     <td > 
                         <div class="auto-style3"><strong>&nbsp What is your diagnosis?</strong></div>
                        <br />

                         <asp:RadioButtonList class="auto-style1"  ID="RadBtn_classification" runat="server"  >
                                <asp:ListItem>&nbsp NORMAL</asp:ListItem>
                              <asp:ListItem>&nbsp SUSPECTED CROHN'S</asp:ListItem>  
                             <asp:ListItem>&nbsp DON'T KNOW</asp:ListItem> 
                         </asp:RadioButtonList>
                         <asp:Label ID="LblErr" runat="server"  class="auto-style1" Text="Label" ForeColor="Red" Visible="false">You need to answer what your diagnosis is</asp:Label>
                         <br /><br /> <br />
                         <asp:Label ID="Label_which" class="auto-style3" runat="server"><strong> &nbsp Which patient's data according to the diagram you learned are the basis of your diagnosis?</strong></asp:Label>
                        <asp:Label ID="Label20" class="auto-style3" runat="server"> <strong> &nbsp (You can select more than one option)</strong><br /></asp:Label><br />
                         <asp:CheckBoxList class="auto-style1"  ID="CheckBoxList1" runat="server" >

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
         <asp:Label ID="LblMone" runat="server"   style="margin-left:50%; font-size:x-large" > </asp:Label>
                  <asp:Button ID="Btn1" runat="server" Text="NEXT CASE" Height="6%" 
                              width ="8%"  OnClick="Btn1_Click" Font-Names="Guttman Yad-Brush" style="margin-left:90%"/>
      
    
    </form>
</body>
</html>
