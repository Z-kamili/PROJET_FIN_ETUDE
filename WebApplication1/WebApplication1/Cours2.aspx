<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cours2.aspx.cs" Inherits="WebApplication1.Cours2" %>



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
					<li><a href="TDI.aspx">Examen</a></li>
					<li><a href="WebForm3.aspx" >Cours</a></li>
					<asp:button class="BTN_register" runat="server" Text="déconnecter" id="BTN_reg" OnClick="BTN_reg_Click" />
                  <%--  <asp:Button CssClass="BTN_register" Text="Register" runat="server" />--%>
				</ul>
			</div>

                <%-- Resulta Final --%>
                <div class="DivLandingPage DIVpos" runat="server" id="Afficher_Resultats1">
                    <%--<asp:Button CssClass="BTNValider" runat="server"  Text="Telecharger" OnClick="Unnamed1_Click"   />--%>
                    <asp:Button CssClass="BTNValider" runat="server" ID="btn"  Text="Telecharger" OnClick="Unnamed1_Click1"/>
                    <div class="inner">
                        <asp:Panel ID="pnl1" runat="server">
                            <p class="PQuastions" id="success">Developpement mobile le  Cour complets</p><br/>
                            <p class="PQuastions">Vous devez vous telecharger</p><br/>

                            <br />
                           <asp:Label ID="nm" runat="server"></asp:Label>

                        </asp:Panel>
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
             position:absolute; left:360px; top:200px;
            /*left: 737px;*/
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
       #btn{
           cursor:pointer;
       }
       #refuser{
           color:red;
       }
       #success{
         font-weight:bold;
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
