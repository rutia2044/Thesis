<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExperimentalProcess.aspx.cs" Inherits="WebApplication3.ExperimentalProcess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script language="JavaScript" type="text/javascript">
window.history.forward();              
    </script>
    <title> Experimental process</title>
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
        .auto-style2 {
           height: 2%;
        }
        .auto-style4{font-size:x-large;}
 
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
              <div  style="text-align:center;" class="auto-style3" ><strong><br /> EXPERIMENT PROCESS
<br /></strong> </div>   <br /> 
      
                          
     
   
        <div  style="margin-left:1%" class="auto-style4" ><strong>
      It is possible to diagnose whether a patient has Crohn's  by answers to a few questions/conditions.<br /><br />
            The questions/conditions will be presented by a diagram. <br /><br />
            According to the patient's data for these questions/conditions - we will get a diagnostic result.
                                                                   </strong><br /></div>
           
      <br />        
  <asp:Label ID="Label2" style="margin-left:1%" class="auto-style3" runat="server"><strong> 
     <br />The experiment will be performed in two phases:  </strong><br /></asp:Label>
              <br />              
        
  <div  style="margin-left:3%" class="auto-style4" ><strong>
      1. The learning phase:</strong><br /> In this phase you will be presented with cases of patients diagnosed using the diagram (12 cases).
    <br /> you should look at the cases that will be presented one after another <br />and understand their diagnosis according to the diagram.  <br /></div>
       

 <br /> 
 <div  style="margin-left:3%" class="auto-style4" ><strong>
 2. The testing phase:</strong><br />In this phase you will be presented with cases of patients who need to be diagnosed (12 cases).<br />
     You should  diagnose them according to what you learned in the learning phase
     <br />and mark your answers accordingly. <br /></div><br /> 
       <asp:Button ID="BtnNext" runat="server" Height="6%" 
                              width ="8%"  style="margin-left:90%" Text="NEXT"  Font-Names="Guttman Yad-Brush" OnClick="BtnNext_Click" />        
 
    </form>
</body>
</html>
