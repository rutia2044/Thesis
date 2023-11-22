<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

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
table{height:60%;
      width:100%;
}
#form1
{
	height:100%;
	}

        .auto-style1{font-size:large;}
        .auto-style2 {
           height: 2%;
        }
           .auto-style3{font-size:xx-large;}
            .auto-style4{font-size:x-large;}
 
    </style>
</head>
<body>
    <form id="form1" style="height:100%;" runat="server">
         <div  style="text-align:center;" class="auto-style3" ><strong>THE LEARNING PHASE<br /></strong> </div>

               <asp:Label ID="Label20"   runat="server"   style="text-align:center; font-size:x-large" >Please observe the patient data presented to you and understand the diagnosis made for him by the diagram. </asp:Label>
        <br />
         <asp:Label ID="Labe21"   runat="server"   style="text-align:center; font-size:x-large"> 
        The patient data highlighted in green background (in the left column) are the answers of the current patient to the diagram questions in the green rectangles (right column).
         </asp:Label>
       <table style="width:100%; height:70%;" border="1" >
                     <tr>
                     <td  style="width:30%; height:100%;">
                         <div class="auto-style1"><strong>&nbsp PATIENT DATA:<br /></strong><br/>
                             <asp:Panel ID="panel1" runat="server" Height="100%" Width="100%" BackColor="LightGray">
                                  <asp:Label ID="lblRectalMucusQ" runat="server">&nbsp IS THERE RECTAL MUCUS? </asp:Label>&nbsp<asp:Label ID="lblRectalMucus" runat="server"></asp:Label><br/><br/>
                                  <asp:Label ID="lblBowelChangeQ" runat="server">&nbsp  IS THERE BOWEL CHANGE? </asp:Label>&nbsp<asp:Label ID="lblBowelChange" runat="server"></asp:Label><br/><br/>
                                 <asp:Label ID="lblFatigueQ" runat="server">&nbsp IS THERE FATIGUE? </asp:Label>&nbsp<asp:Label ID="lblFatigue" runat="server"></asp:Label><br/><br/>
                                 <asp:Label ID="lblSufferedFromGI_ProblemsQ" runat="server">&nbsp HAS THE PATIENT SUFFERED FROM GI PROBLEMS?  </asp:Label>&nbsp<asp:Label ID="lblSufferedFromGI_Problems" runat="server"></asp:Label><br/><br/>                               
                                  <asp:Label ID="lblOverWeightQ" runat="server">&nbsp HAS THE PATIENT EVER BEEN OVERWEIGHT? </asp:Label>&nbsp<asp:Label ID="lblOverWeight" runat="server"></asp:Label><br/><br/>
                                  <asp:Label ID="lblClassificationQ" runat="server">&nbsp DIAGNOSIS: </asp:Label>&nbsp<strong><asp:Label ID="lblClassification" runat="server"></asp:Label></strong><br/><br/>
                             </asp:Panel>

                         </div>
                     </td>

                       <td>
                         <asp:Label ID="Labe23" class="auto-style1" runat="server"><strong>&nbsp  DIAGRAM: </strong>     </asp:Label><br />
                           <asp:Image ID="Image1" runat="server" Height="90%" Width="100%" ImageAlign="AbsMiddle" /><br />
                     </td>
                    
                 </tr>
                  </table>
        <br/>
                  <asp:Label ID="Label2"  style="font-size:x-large" runat="server">&nbsp After you understand the case and result, proceed to the next case.(click on the  NEXT CASE button)</asp:Label>            
      <br />  <asp:Label ID="LblMone" runat="server"   style="margin-left:50%; font-size:x-large" ></asp:Label>
      
          <asp:Button ID="Btn1" runat="server" Text="NEXT CASE" Height="6%" 
                              width ="8%" OnClick="Btn1_Click" style="margin-left:90%"  Font-Names="Guttman Yad-Brush"/>
       
    
    </form>
</body>
</html>
