<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>
<html>
<head>
	<title></title>
	<link rel="stylesheet" type="text/css" href="css/HomePage.css">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
      <style>
        .CardLogeIN:hover, .CN3:hover, .CN2:hover
{
	transform: rotateX(22deg)  scale(1.03);
    transition: transform .4s ease-out;
        z-index:3;
}
    </style>
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
					<li><a href="#">Cours</li>
					<asp:button class="BTN_register" runat="server" Text="déconnecter" id="BTN_reg" OnClick="BTN_reg_Click" />
                  <%--  <asp:Button CssClass="BTN_register" Text="Register" runat="server" />--%>
				</ul>
			</div>
			

			<div class="header1" >
				<div id="DivLandingPage">
				<h1 class="H">Voila Les Cours</h1>
				<p>choisissez l'un des modules pour Etudier avant de passer votre test</p>
                
				</div>
                
                <div id="Div2emeannes" runat="server">
				<div class="CardLogeIN" style="height:6em;" id="DivCRLO" runat="server">
				   <img src="../img/Web.png" style="margin-top:21px; margin-left:21px; float:left"  height="50px" />
                    <asp:Button runat="server" ID="btn1" style="line-height:10px; margin-top:26px; position:absolute; left:78px; color:black;" text="developpement web">
                        
                        <%--<asp:Label style="color:black;">html, css, javascript, asp.net</p>--%>
                       <%-- html, css, javascript, asp.net--%>
                        
				    </asp:Button>
                </div>
                <div class="CN3" style="height:6em; background-color: white; width: 350px; border-radius: 15px; position: fixed; top: 48%; left: 60%; " id="Div11" runat="server">
				    <img src="../img/android.png" style="margin-top:21px; margin-left:21px; float:left"  height="50px" />
                    <div style="line-height:10px; margin-top:26px; position:absolute; left:78px; color:black;">
                        <b>développement Mobile</b>
                        <p style="color:black;">Android studio - java</p>
				    </div>
                </div>
                <div class="CN2"  style="height:6em; background-color: white; width: 350px; border-radius: 15px; position: fixed; top: 70%; left: 60%; " id="Div2" runat="server" onclick="loadCour3()">
				    <img src="../img/SQL.png" style="margin-top:21px; margin-left:21px; float:left"  height="50px" />
                    <div style="line-height:10px; margin-top:26px; position:absolute; left:78px; color:black;">
                        <b>Developpemet WEB</b>
                        <p style="color:black;"> La technologie Asp.net</p>
				    </div>
                </div>
                </div>

                 <%--1er annees developmetn--%>
                <div id="Div1erannes" runat="server">
                <div class="CardLogeIN" style="height:6em;" id="Div33" runat="server" onclick="loadcours1()" >
				   <img src="../img/csharp.png" style="margin-top:21px; margin-left:21px; float:left"  height="50px"  />
                    <div ID="btn2"   style="line-height:10px; margin-top:26px; position:absolute; left:78px; color:black;" Text ="développement Desktop">
                        <b>développement Desktop</b>
                    <p style="color:black;">  Programmation orientée objet C# </p>
				    </div>
                </div>
                      <div class="CN3" style="height:6em; background-color: white; width: 350px;  border-radius: 15px; position: fixed; top: 48%; left: 60%; " id="Div44" onclick="loadCours2()" runat="server">
				    <img src="../img/android.png" style="margin-top:21px; margin-left:21px; float:left"  height="50px" />
                    <div style="line-height:10px; margin-top:26px; position:absolute; left:78px; color:black;">
                        <b>développement Mobile</b>
                        <p style="color:black;">Android studio - java</p>
				    </div>
                </div>
              <%--  <div class="CN3" style="height:6em; background-color: white; width: 350px; border-radius: 15px; position: fixed; top: 48%; left: 60%; " id="Div4" runat="server">
				    <img src="../img/c.png" style="margin-top:21px; margin-left:21px; float:left"  height="50px" />
                    <div style="line-height:10px; margin-top:26px; position:absolute; left:78px; color:black;">
                        <b>langage c</b>
                        <p style="color:black;">programmation - console application</p>
				    </div>
                </div>--%>
                    </div>
                </div>



				</div>
			</div>
		</div>

		
	</div>
 	
	
	
</div>
        </form>
    <script>

      
        function loadcours1() {
            window.location.href = "http://localhost:2094/Cours1.aspx";
        }
        function loadCours2() {

            window.location.href = "http://localhost:2094/Cours2.aspx";

        }
        function loadCour3() {
            window.location.href = "http://localhost:2094/Cours3.aspx";
        }
       

    </script>
</body>
    

</html>
