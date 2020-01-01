﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestAppdesktop.aspx.cs" Inherits="WebApplication1.TestAppdesktop" %>



<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" type="text/css" href="css/HomePage.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.0/jquery.min.js"></script>

</head>

<body>
    <form id="f2" runat="server">
	<div id="first">

	<div class="wrapper">
		<div class="nav">
			<div class="logo" > 
				<img src="img/bahri1.png" style=" top:10px; width:150px;" height="100px;" />
			</div>
			<div class="menu"> 
				<ul>
					<li><a href="TDI.aspx">Examen</li>
					<li><a href="WebForm3.aspx" >Cours</a></li>
					<asp:button class="BTN_register" runat="server" Text="déconnecter" id="BTN_reg" OnClick="BTN_reg_Click"/>
                  <%--  <asp:Button CssClass="BTN_register" Text="Register" runat="server" />--%>
				</ul>
			</div>

            <div class="header1" >
                
                <div id="DivLandingPage" class="DivLandingPage DIVpos active" runat="server" >
				    <h2 class="H2" >développement Desktop - Question : 1-8</h2>
                    <div class="PQuastions">
                    <asp:Label ID="lbl1" CssClass="PQuastions" runat="server"></asp:Label>
                        <%-- <p class="PQuastions">suivant :</p>
				         <p class="PQuastions">Etant donnée la fonction racineSecurisee(a,b)</p>--%><br><br />
                    </div>
                     <p class="PQuastions">la zone de réponse </p>
                    <asp:Button ID="Button1" CssClass="BTNValider" runat="server" Text="Valider" OnClick="Button1_Click"  />
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Q1"  CssClass="Answer1" Text="Si le radicante (a) n’est pas negatif,renvoie Math.pow(a,1/b) ;"  /><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton2" runat="server" Text="Si non" GroupName="Q1"/><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton3" runat="server" GroupName="Q1" Text="Si l’index (b) est divisible par 2, alors le texte renvoyé pour  indiquer les résultats est imaginaire" /> <br /><br />
<%--                    <asp:RadioButton CssClass="Answer1" ID="RadioButton4" runat="server" GroupName="Q1" Text="Sinon, renvoie Math.pow(-a,1/b)" /><br />--%>
                   
                </div>
                <div id="DivLandingPage1" class="DivLandingPage DIVpos" runat="server" >
				    <h2 class="H2" >développement Desktop - Question : 2-8</h2>
                    <div class="PQuastions">
                     <asp:Label ID="Label2" CssClass="PQuastions" runat="server"></asp:Label>
                    </div>
                    <p class="PQuastions">la zone de réponse </p>
                    <asp:Button ID="Button2" CssClass="BTNValider" runat="server" Text="Valider" OnClick="Button2_Click"   />
                    <asp:RadioButton ID="RadioButton5" runat="server" GroupName="Q1"  CssClass="Answer1" Text="choice1"  /><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton6" runat="server" Text="choice2" GroupName="Q1"/><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton7" runat="server" GroupName="Q1" Text="choice3" /> <br /><br />
<%--                    <asp:RadioButton CssClass="Answer1" ID="RadioButton8" runat="server" GroupName="Q1" Text="choice4" /><br />--%>
                </div>
                 <div id="DivLandingPage2" class="DivLandingPage DIVpos" runat="server" >
				    <h2 class="H2" >développement Desktop - Question : 3-8</h2>
                    <div class="PQuastions">
                         <asp:Label ID="label3"  CssClass="PQuastions" runat="server"></asp:Label>
                           
                    </div>
                     <p class="PQuastions">la zone de réponse </p>
                    <asp:Button ID="Button3" CssClass="BTNValider" runat="server" Text="Valider" OnClick="Button3_Click" />
                    <asp:RadioButton ID="RadioButton9" runat="server" GroupName="Q1"  CssClass="Answer1" Text="choice1"  /><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton10" runat="server" Text="choice2" GroupName="Q1"/><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton11" runat="server" GroupName="Q1" Text="choice3" /> <br /><br />
<%--                    <asp:RadioButton CssClass="Answer1" ID="RadioButton12" runat="server" GroupName="Q1" Text="choice4" /><br />--%>
                   
                </div>
                <div id="Div1" class="DivLandingPage DIVpos" runat="server" >
				    <h2 class="H2" >développement Desktop - Question : 4-8</h2>
                    <div class="PQuastions">
                         <asp:Label ID="Label4"  CssClass="PQuastions" runat="server"></asp:Label>
                           <br><br />
                    </div>
                    <p class="PQuastions">la zone de réponse </p>
                    <asp:Button ID="Button4" CssClass="BTNValider" runat="server" Text="Valider" OnClick="Button4_Click" />
                    <asp:RadioButton ID="RadioButton13" runat="server" GroupName="Q1"  CssClass="Answer1" Text="choice1"  /><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton14" runat="server" Text="choice2" GroupName="Q1"/><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton15" runat="server" GroupName="Q1" Text="choice3" /> <br /><br />
<%--                    <asp:RadioButton CssClass="Answer1" ID="RadioButton16" runat="server" GroupName="Q1" Text="choice4" /><br />--%>
                  
                </div>
                 <div id="Div2" class="DivLandingPage DIVpos" runat="server" >
				    <h2 class="H2" >développement Desktop - Question : 5-8</h2>
                    <div class="PQuastions">
                         <asp:Label ID="Label5"  CssClass="PQuastions" runat="server"></asp:Label>
                           <br><br />
                    </div>
                     <p class="PQuastions">la zone de réponse </p>
                    <asp:Button ID="Button5" CssClass="BTNValider" runat="server" Text="Valider" OnClick="Button5_Click" />
                    <asp:RadioButton ID="RadioButton17" runat="server" GroupName="Q1"  CssClass="Answer1" Text="choice1"  /><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton18" runat="server" Text="choice2" GroupName="Q1"/><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton19" runat="server" GroupName="Q1" Text="choice3" /> <br /><br />
                 <%--   <asp:RadioButton CssClass="Answer1" ID="RadioButton20" runat="server" GroupName="Q1" Text="choice4" /><br /><br />--%>
                    
                </div>
                  <div id="Div4" class="DivLandingPage DIVpos" runat="server" >
				    <h2 class="H2" >développement Desktop - Question : 6-8</h2>
                    <div class="PQuastions">
                         <asp:Label ID="Label1"  CssClass="PQuastions" runat="server"></asp:Label>
                           <br><br />
                    </div>
                     <p class="PQuastions">la zone de réponse </p>
                    <asp:Button ID="Button6" CssClass="BTNValider" runat="server" Text="Valider" OnClick="Button6_Click" />
                    <asp:RadioButton ID="RadioButton4" runat="server" GroupName="Q1"  CssClass="Answer1" Text="choice1"  /><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton8" runat="server" Text="choice2" GroupName="Q1"/><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton12" runat="server" GroupName="Q1" Text="choice3" /> <br /><br />
                <%--    <asp:RadioButton CssClass="Answer1" ID="RadioButton16" runat="server" GroupName="Q1" Text="choice4" /><br /><br />--%>
                    
                </div>
                  <div id="Div5" class="DivLandingPage DIVpos" runat="server" >
				    <h2 class="H2" >développement Desktop - Question : 7-8</h2>
                    <div class="PQuastions">
                         <asp:Label ID="Label6"  CssClass="PQuastions" runat="server"></asp:Label>
                           <br><br />
                    </div>
                     <p class="PQuastions">la zone de réponse </p>
                    <asp:Button ID="Button7" CssClass="BTNValider" runat="server" Text="Valider" OnClick="Button7_Click" />
                    <asp:RadioButton ID="RadioButton21" runat="server" GroupName="Q1"  CssClass="Answer1" Text="choice1"  /><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton22" runat="server" Text="choice2" GroupName="Q1"/><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton23" runat="server" GroupName="Q1" Text="choice3" /> <br /><br />
                  <%--  <asp:RadioButton CssClass="Answer1" ID="RadioButton24" runat="server" GroupName="Q1" Text="choice4" /><br /><br />--%>
                    
                </div>
                  <div id="Div6" class="DivLandingPage DIVpos" runat="server" >
				    <h2 class="H2" >développement web - Question : 8-8</h2>
                    <div class="PQuastions">
                         <asp:Label ID="Label7"  CssClass="PQuastions" runat="server"></asp:Label>
                           <br><br />
                    </div>
                     <p class="PQuastions">la zone de réponse </p>
                    <asp:Button ID="Button8" CssClass="BTNValider" runat="server" Text="Valider" OnClick="Button8_Click" />
                    <asp:RadioButton ID="RadioButton25" runat="server" GroupName="Q1"  CssClass="Answer1" Text="choice1"  /><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton26" runat="server" Text="choice2" GroupName="Q1"/><br /><br />
                    <asp:RadioButton CssClass="Answer1" ID="RadioButton27" runat="server" GroupName="Q1" Text="choice3" /> <br /><br />
                 <%--   <asp:RadioButton CssClass="Answer1" ID="RadioButton28" runat="server" GroupName="Q1" Text="choice4" /><br /><br />--%>
                    
                </div>

                <%-- Resulta Final --%>
                <div class="DivLandingPage DIVpos" runat="server" id="Afficher_Resultat">
                    <asp:Button CssClass="BTNValider" runat="server"  Text="Impremer" OnClick="Unnamed1_Click" />
                    <div class="inner">
                        <asp:Panel ID="pnl1" runat="server">
                            <p class="PQuastions" id="success">BRAVO !! Tu as passer L'examen avec success</p><br/>

                            <br />
                           <asp:Label ID="nm" runat="server"></asp:Label>

                        </asp:Panel>

                        <asp:Panel ID="pnl2" runat="server">
                            <p class="PQuastions" id="refuser">Erreur !! Tu as echouer dans l'examen</p><br/>

                        </asp:Panel>

                        
                        <p class="PQuastions">Ton resultat final est <span>Note</span> : <asp:Label ID="note" runat="server"></asp:Label> </p> 
                    </div>
                </div>

            </div>
            </div>
		</div>
	</div>
    </form>

    <%--Style--%>
    <style>
        .DivLandingPage{background-color:white;    width : 850px;
                        border: 0px solid black;
                        border-radius:12px;
                        height: 300px; color:black;line-height:30px;

        }  
        .PQuastions{color:black;    line-height:20px; margin-top:10px; margin-left:10px; font-weight:300;}
        .H2{color:#fff; 	font-size: 32px; 	font-weight: 360; position:absolute; top:-65px;	letter-spacing: 1.5px;}
        .BTNValider
        {
	        color: #fff;
	        border: 1px solid #009f8b;
	        padding: 10px 20px;
	        border-radius: 5px;
	        background-color:  #009f8b;
            position:absolute; right:15px; top:250px;
            left: 737px;
        }
        .Answer1
        {
             margin-left:10px; font-weight:200;
        }
        .DivLandingPage:not(.active)
        {
            display:none;
        }
        
        .DIVpos
        {
	        line-height: 18px;
	        position: absolute;
	        top: 300%;left:18%;
	        font-size: 18px;
        }
        .inner
        {
            color:black;
            position: absolute;
            left: 50%;
            top: 50%;
            transform: translate(-50%, -50%);
            text-align:center;
        }
       @keyframes animate
        {

	        0%, 100%{ background-image: url(../img/BG1.jpg);}
	        


        }

       #refuser{
           color:red;
       }
       #success{
           color:green;
       }
    </style>
    <script>
        $http({
            url: "",
            method: "GET",
            headers: {
                "Content-type": "Certife/certificate_example.pdf"
            },
            responseType: "arraybuffer"
        }).success(function (data, status, headers, config) {
            var pdfFile = new Blob([data], {
                type: "Certife/certificate_example.pdf"
            });
            var pdfUrl = URL.createObjectURL(pdfFile);
            //window.open(pdfUrl);
            printJS(pdfUrl);
            //var printwWindow = $window.open(pdfUrl);
            //printwWindow.print();
        }).error(function (data, status, headers, config) {
            alert("Sorry, something went wrong")
        });
    </script>
</body>
</html>
    
