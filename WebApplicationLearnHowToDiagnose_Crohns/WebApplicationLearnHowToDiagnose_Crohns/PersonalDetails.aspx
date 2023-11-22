<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonalDetails.aspx.cs" Inherits="WebApplication3.PersonalDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        .auto-style3{font-size:xx-large;}
       
        .auto-style4{font-size:x-large;}
 
    </style>
</head>
<body>
    <form id="form1" runat="server">
         
             <div  style="text-align:center;" class="auto-style3" ><strong><br />Personal Details<br />
            </strong> </div>   <br /> 
        
         <div  style="padding-left:28%;" class="auto-style1" >
              <asp:Panel ID="panel2" style="text-align:center;width: 70%; height:68%;"  runat="server"   BackColor="#FDE4C6" BorderStyle="Ridge" BorderColor="#FFE1E1">
       
                  <br /><asp:Label ID="LblGender" style="text-align:right;font-weight:700;" class="auto-style4" runat="server" Text="Label">
            Gender: </asp:Label><br />
       
               <asp:DropDownList  ID="DropDownListGender" style="font-size:large" runat="server" OnSelectedIndexChanged="DropDownListGender_SelectedIndexChanged">
             <asp:ListItem Text="-- Select one --" Value="-- Select one --" />
                   <asp:ListItem Text="Female" Value="Female" />
               <asp:ListItem Text="Male" Value="Male" />
                
        </asp:DropDownList>
 <br /> <br />
       <asp:Label ID="LblAge" style="text-align:right;font-weight:700;" class="auto-style4" runat="server" Text="Label">
          Age: </asp:Label><br />
         <asp:TextBox ID="TxtAge" style="text-align:center;font-size:large"     runat="server" Width="126px" OnTextChanged="TxtAge_TextChanged"></asp:TextBox> <br /><br />
          
                  <asp:Label ID="LblEducation" style="text-align:right;font-weight:700;" class="auto-style4" runat="server" Text="Label">
           Education: </asp:Label><br />

        <asp:DropDownList  ID="DropDownListEducation" style="text-align:center;font-size:large" runat="server" OnSelectedIndexChanged="DropDownListEducation_SelectedIndexChanged">
            
              <asp:ListItem Text=" -- Select one --" Value="0" />
           
            <asp:ListItem Text="Less than a high school diploma" Value="1" />
               <asp:ListItem Text="High school diploma or equivalent degree" Value="2" />
            <asp:ListItem Text="No degree" Value="3" />
             <asp:ListItem Text="Bachelor’s degree" Value="4" />
             <asp:ListItem Text="Master’s degree" Value="5" />
            
        </asp:DropDownList> <br /><br />
                  </asp:Panel> 
                   <asp:Panel ID="panel3" style="width: 70%; height:68%;"  runat="server"   BackColor="#FDE4C6" BorderStyle="Ridge" BorderColor="#FFE1E1">
       

        <br /> <asp:Label ID="Label1"  style="padding-left:20%;text-align:right;font-weight:700;" class="auto-style4" runat="server">	How much do you agree with the following:  </asp:Label>
         <br /><br />
                  <asp:Label ID="Label2"  style="padding-left:20%;font-weight:700;" class="auto-style4" runat="server">
          1) I have a good memory </asp:Label>
          <asp:RadioButtonList ID="RdbGoodMemory" style="padding-left:24%" class="auto-style1" runat="server"   RepeatDirection="Vertical" RepeatLayout="Table" >
                           <asp:ListItem>  Strongly disagree </asp:ListItem>
                           <asp:ListItem> Disagree</asp:ListItem>  
                           <asp:ListItem> Neutral</asp:ListItem> 
                           <asp:ListItem> Agree</asp:ListItem>  
                           <asp:ListItem> Strongly agree</asp:ListItem> 
             </asp:RadioButtonList><br />
 <asp:Label ID="Label3"  style="padding-left:20%;font-weight:700;" class="auto-style4" runat="server"> 2) I learn quickly </asp:Label>
          <asp:RadioButtonList ID="RdbLearnQuickly"  style="padding-left:24%" class="auto-style1" runat="server"   RepeatDirection="Vertical" RepeatLayout="Table"   >
                           <asp:ListItem>  Strongly disagree </asp:ListItem>
                           <asp:ListItem> Disagree</asp:ListItem>  
                           <asp:ListItem> Neutral</asp:ListItem> 
                           <asp:ListItem> Agree</asp:ListItem>  
                           <asp:ListItem> Strongly agree</asp:ListItem> 
             </asp:RadioButtonList><br />
          <asp:Label ID="Label4"  style="padding-left:20%;text-align:right;font-weight:700;" class="auto-style4" runat="server">
          3) I have a visual memory  </asp:Label>
          <asp:RadioButtonList ID="RdbGoodVisualMemory"  style="padding-left:24%" class="auto-style1" runat="server"   RepeatDirection="Vertical" RepeatLayout="Table" TextAlign="right">
                        <asp:ListItem>  Strongly disagree </asp:ListItem>
                        <asp:ListItem> Disagree</asp:ListItem>  
                        <asp:ListItem> Neutral</asp:ListItem> 
                        <asp:ListItem> Agree</asp:ListItem>  
                        <asp:ListItem> Strongly agree</asp:ListItem> 
             </asp:RadioButtonList><br />
            <asp:Label ID="Label5"  style="padding-left:20%;font-weight:700;" class="auto-style4" runat="server">
           4) I have more medical knowledge than most people </asp:Label>
          <asp:RadioButtonList ID="RdbMedicalKnowledge"  style="padding-left:24%" class="auto-style1" runat="server"   RepeatDirection="Vertical" RepeatLayout="Table" TextAlign="right">
                           <asp:ListItem>  Yes </asp:ListItem>
                           <asp:ListItem> No </asp:ListItem>  
                           <asp:ListItem> I don't know</asp:ListItem> 
                           
             </asp:RadioButtonList><br />

        <br /><br />
         <asp:Label ID="LblErrorDetails" ForeColor="Red" Visible="false" runat="server" Text="Label">
             Please make sure that all the fields are completed correctly </asp:Label>
        <br /> </asp:Panel>     
             </div>
        <br /><br /> <br />
            <asp:Button ID="BtnNext" runat="server" Text="NEXT" Height="6%" 
                              width ="8%"  OnClick="Btn1_Click" Font-Names="Guttman Yad-Brush" Font-Bold="True" style="margin-left:90%"/>
           
        <br /> <br />
       
    </form>
</body>
</html>
