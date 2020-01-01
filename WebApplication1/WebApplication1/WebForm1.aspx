<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
<html>
<head runat="server">
	<title></title>
	<link rel="stylesheet" type="text/css" href="~/css/HomePage.css">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
   
</head>
<body>
    <form id="f1" runat="server">
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
				</ul>
			</div>
			
			<div class="header">
				<div id="DivLandingPage">
				<h1 class="H">Welcome Back!</h1>
				<p>Login to access your account</p>
				<p>Not a member?</p>
				
                    <asp:Button ID="Register" CssClass="BTN_register" runat="server" Text="Login" OnClick="Register_Click"   />
				</div>
				
				
				<div class="CardLogeIN" style="height: 21em;"  >
					<p id="P1">Login<p>
					<div class="Content">
						 <asp:TextBox ID="TextBox2" runat="server" CssClass="Input"  placeholder="Enter your email" ></asp:TextBox>
					 <asp:TextBox ID="TextBox1" runat="server" CssClass="Input"  placeholder="password" TextMode="Password" ></asp:TextBox><br/>
					<input type="checkbox" name="ViewPassword" runat="server">Show password<br><br><br>
                        <asp:Button CssClass="BTN_register" style="width: 220px;" ID="btn1" runat="server" Text="Sign in" OnClick="btn1_Click" />
					</div>

				</div>
			</div>

	

		
	</div>
 	
	
	
</div>
        </form>
</body>
 

    </html>>
