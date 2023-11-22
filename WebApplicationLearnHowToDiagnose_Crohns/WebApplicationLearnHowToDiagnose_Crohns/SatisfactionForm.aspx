<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SatisfactionForm.aspx.cs" Inherits="WebApplication3.FinishedForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LEARN HOW TO DIAGNOSE CROHN'S </title>
     <style type="text/css">
            * {
padding: 0;
margin: 1;
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
margin: 0 auto ;
}
* html #container {
height: 100%;
}
#form1
{
	height:100%;
	}

    
        .auto-style1{font-size:large;}
        .auto-style3{font-size:xx-large;}
        .auto-style2 {
           height: 2%;
        }
        .auto-style4{font-size:x-large;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
        <div  style="text-align:center;" class="auto-style3" ><strong><br />WELL DONE!!!<br />
            You have completed the testing phase.<br /></strong> </div>   <br /> <br />
       <asp:Label ID="Label9"  class="auto-style4" runat="server"><strong> 
      &nbsp Please rate your experience:  </strong><br /></asp:Label>
                          
         
         <asp:Label ID="LblErr" runat="server"  class="auto-style1" Text="Label" ForeColor="Red" Visible="false">You must answer  the questions before you finish</asp:Label>
        <br />
            <asp:Label ID="Label2"  style="text-align:right;font-weight:700;" class="auto-style4" runat="server">
          &nbsp 1) It was easy for me to learn all the conditions and rules. </asp:Label>
          <asp:RadioButtonList ID="RadioButtonList1" class="auto-style1" runat="server"   RepeatDirection="Vertical" RepeatLayout="Table" TextAlign="right">
                           <asp:ListItem>  Strongly disagree </asp:ListItem>
                             <asp:ListItem> Disagree</asp:ListItem>  
                              <asp:ListItem> Neutral</asp:ListItem> 
                              <asp:ListItem> Agree</asp:ListItem>  
                              <asp:ListItem> Strongly agree</asp:ListItem> 
             </asp:RadioButtonList>
               
     <br />  <br />
           
             <asp:Label ID="Label4"  style="text-align:right;font-weight:700;" class="auto-style4" runat="server">
         &nbsp 2) I am capable of learning more conditions/rules. </asp:Label>

              <asp:RadioButtonList ID="RadioButtonList2" class="auto-style1" runat="server"   RepeatDirection="Vertical" RepeatLayout="Table" TextAlign="right">
                              <asp:ListItem> Strongly disagree </asp:ListItem>
                              <asp:ListItem> Disagree</asp:ListItem>  
                              <asp:ListItem> Neutral</asp:ListItem> 
                              <asp:ListItem> Agree</asp:ListItem>  
                              <asp:ListItem> Strongly agree</asp:ListItem> 
                            
               
                         </asp:RadioButtonList>
        <br />  <br />

         <asp:Label ID="Label1"  style="text-align:right;font-weight:700;" class="auto-style4" runat="server">
         &nbsp 3) More examples in the learning phase would improve the diagnosis. </asp:Label>

              <asp:RadioButtonList ID="RadioButtonList3" class="auto-style1" runat="server"   RepeatDirection="Vertical" RepeatLayout="Table" TextAlign="right">
                              <asp:ListItem> Strongly disagree </asp:ListItem>
                              <asp:ListItem> Disagree</asp:ListItem>  
                              <asp:ListItem> Neutral</asp:ListItem> 
                              <asp:ListItem> Agree</asp:ListItem>  
                              <asp:ListItem> Strongly agree</asp:ListItem> 
                            
               
                         </asp:RadioButtonList>
        <br />  <br />

         <asp:Label ID="lbl1"  style="text-align:right;font-weight:700;" class="auto-style4" runat="server">
           &nbsp 4) The experiment met its goal of teaching me the correct diagnosis.  </asp:Label>
      <asp:RadioButtonList ID="RadioButtonList4" runat="server" class="auto-style1"   RepeatDirection="Vertical" RepeatLayout="Table" TextAlign="right">
                              <asp:ListItem> Strongly disagree </asp:ListItem>
                              <asp:ListItem> Disagree</asp:ListItem>  
                              <asp:ListItem> Neutral</asp:ListItem> 
                              <asp:ListItem> Agree</asp:ListItem>  
                              <asp:ListItem> Strongly agree</asp:ListItem> 
                         </asp:RadioButtonList>
        <br />  <br />
         <asp:Label ID="Label7"  style="text-align:right;font-weight:700;" class="auto-style4" runat="server">
           &nbsp 5) I trust diagnosis using  the model.  </asp:Label>
      <asp:RadioButtonList ID="RadioButtonList5" runat="server" class="auto-style1"   RepeatDirection="Vertical" RepeatLayout="Table" TextAlign="right">
                              <asp:ListItem> Strongly disagree </asp:ListItem>
                              <asp:ListItem> Disagree</asp:ListItem>  
                              <asp:ListItem> Neutral</asp:ListItem> 
                              <asp:ListItem> Agree</asp:ListItem>  
                              <asp:ListItem> Strongly agree</asp:ListItem> 
                         </asp:RadioButtonList>
        <br />  <br />

        <asp:Label ID="Label5" style="text-align:right;font-weight:700;" class="auto-style4" runat="server" Text="Label">
           &nbsp 6)   How many rules/conditions do you think you are able to learn? (press a number)</asp:Label><br /><br />
       &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp  <asp:TextBox ID="TextBox_NumRules" class="auto-style1"    runat="server"></asp:TextBox> <br /><br /><br />
         
        <asp:Label ID="Label3" style="text-align:right;font-weight:700;" class="auto-style4" runat="server" Text="Label">
            &nbsp  7) What is your opinion on the level of detail of the model you have learned? </asp:Label> <br /><br />
          &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
        <asp:DropDownList  ID="DropDownListSatisfied" style="text-align:center;font-size:large" runat="server" >
             <asp:ListItem Text="-- Select one --" Value="0" />
                   <asp:ListItem Text="The model was not detailed enough, it is necessary to add more rules" Value="1" />
               <asp:ListItem Text="The level of detail of the model was good, but more rules can be added" Value="2" />
                <asp:ListItem Text="The level of detail of the model was good, but no more rules can be added" Value="3" />
         <asp:ListItem Text="The model was too detailed, no more rules can be added" Value="4" />
              
        
        </asp:DropDownList>
        <br /><br /><br />
         
        <asp:Label ID="Label6" style="text-align:right;font-weight:700;" class="auto-style4" runat="server" Text="Label">
        
               &nbsp 8)  What changes would you recommend in order to improve the experiment?</asp:Label>
                   
      
        <br /> <br />
        &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp <asp:TextBox ID="UserCommentTxt" Style="text-align:left ; font-weight: 700; width: 45%;height:10%;" class="auto-style1"   TextMode="MultiLine" runat="server"> </asp:TextBox>
        <br /> <br /> <br />
        
                        
        <asp:Button ID="BtnFinished" runat="server" Height="6%" 
                              width ="8%"  style="margin-left:90%" Text="FINISHED" OnClick="BtnFinished_Click" Font-Names="Guttman Yad-Brush" />        
   <br />
        </form>
</body>
</html>
