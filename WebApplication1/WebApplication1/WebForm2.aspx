<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>



<!DOCTYPE html>
<html>
<head>
	<title></title>
	<link rel="stylesheet" type="text/css" href="css/HomePage.css">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
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
					<li><a href="#">Home</li>
					<li><a href="#">Exam</li>
					<li><a href="#">Cours</li>
					<button class="BTN_register">Register</button>
                  <%--  <asp:Button CssClass="BTN_register" Text="Register" runat="server" />--%>
				</ul>
			</div>
			

			<div class="header1" >
				<div id="DivLandingPage">
				<h1 class="H">Welcome!</h1>
				<p>Create your account within munites</p>
				<p>Already a member?</p>
                <asp:Button CssClass="BTN_register" ID="Button1" Text="Login" runat="server" OnClick="Button1_Click1"  />
				</div>
				<%--<button class="BTN_register" id="Login" onclick="f1()">Login</button>--%>
				<div class="CardLogeIN" style="height:32em;" id="DivCRLO" runat="server">
					<p id="P1">Sign up <p>
                        

					<div class="Content">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="Input"   placeholder="Nom Complete" ></asp:TextBox><br>
                       
                        
                              <br />
                         
                        
					 <asp:TextBox ID="TextBox2" runat="server" CssClass="Input"  placeholder="dd/mm/yyyy" ></asp:TextBox>
					<br>	
					 <asp:TextBox ID="TextBox3" runat="server" CssClass="Input"  placeholder="Email"></asp:TextBox><br>  
					 <asp:TextBox ID="TextBox4" runat="server" CssClass="Input"    placeholder="Password" TextMode="Password"></asp:TextBox><br>
                        <asp:CheckBox ID="ch1"  name="ViewPassword" Text="Show password" runat="server" />
					<br>
                        <asp:Label ID="lb1" runat="server"></asp:Label>
                  <br />
                       
					<br>
					<asp:button class="BTN_register" runat="server"  Text="Sign up"  style="width: 220px;" OnClick="Unnamed3_Click"/>
					</div>

				</div>
			</div>
		</div>

		
	</div>
 	
	
	
</div>
        </form>
</body>

</html>

