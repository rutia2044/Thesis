<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InformedConsent.aspx.cs" Inherits="WebApplication3.InformedConsent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
    <script language="JavaScript" type="text/javascript">
        window.history.forward();
    </script>
    <title>Informed Consent </title>
     <script type="text/javascript">//language="javascript">
         //window.onload = function () {
         window.history.forward();
         function noBack() {
             window.history.forward();
         }
     </script>
     <style type="text/css">
          * {
padding: 0;
margin: 0;
}
html, body {
    onload="window.history.forward();";
height: 100%;
}
body {
    onload="window.history.forward();";
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
<body onload="window.history.forward();">
    <form id="form1" runat="server">
      <div    style="text-align:center;font-size:xx-large" class="auto-style1"   ><strong> Informed Consent   </strong> </div>   
<div style="padding-left:10%">
                       
        <asp:Panel ID="panel1" style="width: 90%; height:90%;"  runat="server" BorderStyle="Dashed" HorizontalAlign="NotSet" BackColor="#E6E1E6">
        <asp:Label ID="InformedLable"  style="font-size:large"  runat="server">                 
       <strong><br /> Dear participant,</strong><br /><br />
Thank you for accepting this HIT. This study is being done by Prof. David Sarne and lab members from Bar-Ilan University, and was approved by the Institutional Review Board (IRB) of Bar-Ilan University.

<br />The purpose of this research is to study the level of human absorption capacity in learning a classification task.<br /> The time the experiment will take and the reward for completing it are specified in the HIT description.<br /><br />

You may not directly benefit from this research; however, we hope that your participation in the study will help in better understanding some aspects of human absorption capacity, leading to the development of better and more effective tools and methods for humanity.

<br /><br />We believe there are no known risks associated with this research study; however, as with any online related activity the risk of a breach of confidentiality is always possible. To the best of our ability your answers in this study will remain confidential. We will minimize any risks by storing all data in a secured server. To save your anonymity, your MTurk Worker ID will be used only to distribute payment to you.

<br />Your participation in this study is completely voluntary and you can withdraw at any time. There will be no penalty for withdrawal (though you will not complete the HIT and get paid).

<br /><br /> sincerely appreciate your consideration and participation in this study.<br />

If you encounter any technical problem with the HIT, or have any questions or comments, please contact us by sending an email using the MTurk system.<br /> If you have research-related questions or want clarification regarding this research and/or your participation, please contact Prof. David Sarne at david.sarne@biu.ac.il

<br />By clicking “I agree” below you are indicating that you are at least 18 years old, have read and understood this consent form and agree to participate in this research study. It is advisable that you print a copy of this page for your records.<br /> 
       <br /> </asp:Label>
        </asp:Panel>
        </div>
        <br /><br />
        <div style="padding-left:10%;text-align:center">
                       
        <asp:Panel ID="panel2" style="width: 90%; height:90%;"  runat="server"   BackColor="#FDE4C6">
        <asp:Label ID="Label1"  style="font-size:large;text-align:center;"  runat="server">Please note that you can participate in this experiment only once.<br />
Thus, once you click the "I Agree" button, you will not be able to start the experiment again or open it in another window/tab.<br />
Also, to avoid potential problems, please do NOT click the refresh button nor the back button while participating in this experiment.
             <br /> </asp:Label>
        </asp:Panel>
        </div>
        <br />
         <asp:Button ID="BtnAgree" runat="server"  Font-Names="Guttman Yad-Brush" Text="I Agree" Height="6%" 
                              width ="8%"  style="margin-left:40%"  BackColor="#82FF82" BorderStyle="Solid" Font-Bold="True" OnClick="BtnAgree_Click" />
            
         <asp:Button ID="BtnNotAgree" runat="server" Font-Names="Guttman Yad-Brush" Text="I Do Not Agree" Height="6%" 
                              width ="8%"  style="margin-left:3%" BackColor="#FF5353" Font-Bold="True" BorderStyle="Solid" OnClick="BtnNotAgree_Click" />
        <br />
         <asp:Label  ID="LblError" style="font-size:large;text-align:center;" runat="server"  ForeColor="Red" Visible="false">You Have already did this experiment, You cant do it again. THANK YOU </asp:Label>

    </form>
</body>
</html>
