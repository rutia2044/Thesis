<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExitForm.aspx.cs" Inherits="WebApplication3.ExitForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>LEARN HOW TO DIAGNOSE CROHN'S </title>
     <style type="text/css">
 * {
padding: 0;
margin: 0;
}

/*body {
 background-image: url('Images/thank-you2.jpg');
     background-image: url('Images/ThankTime2.jpg');
    background-repeat: no-repeat;
    background-size:initial; /* will auto resize to fill the screen 
    font-size: 75%;
}*/
h1 {
font-size: 1.4em;
padding: 10px 10px 0;
}
p {
padding: 0 10px 1em;
}



#form1
{
	height:100%;
	}

    
   
}
 .auto-style3{font-size:medium;}
        .auto-style1{font-size:xx-large;}
        .auto-style2 {
          font-size:large;
        }
    </style> 
    <script type = "text/javascript">  
        function setAction() {
          //  var x = document.getElementById("form_action").selectedIndex;
            var action = document.getElementById("myAssignment").value;
           // if (action !== "") {
            document.getElementById("form1").action = action;
          //  alert("update action");
                document.getElementById("form1").submit();
           
        }
    </script>  
    </head>
<body>
       
    <form id="form1"   method="post" runat="server">
    
        <input type="hidden" runat="server" id="myAssignment"  />
     
        <br /> <br />
        
            
      <asp:Label ID="LabelPlease" style="text-align:center;margin-left:15%" class="auto-style1"  runat="server"><strong> Please click on Submit button to save your answers and end the experiment </strong></asp:Label> <br />
    
        <br />
           <input runat="server" type="submit" onclick = "setAction()"  style="margin-left:45%;height:50px; width:150px ;background-color:greenyellow;color:red;font-size:xx-large"   
                 value = "  Submit  "   id="btn_submit_input" /> 
      <br />
         <asp:Label ID="Label44" style="margin-left:1%" class="auto-style3" Visible="false" runat="server">dfsdgf</asp:Label> <br />
      <asp:Image ID="ImageThank" runat="server"  style="width:67%;height:30%; margin-left:15%"  ImageAlign="Bottom"
                               ImageUrl="~/Images/ThankTime1.jpg" />
         
                  
        
    </form>
</body>
</html>
