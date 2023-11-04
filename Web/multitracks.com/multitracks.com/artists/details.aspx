<%@ Page Language="C#" AutoEventWireup="true" CodeFile="details.aspx.cs" Inherits="artists_details" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<!-- set the viewport width and initial-scale on mobile devices -->
	<meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no" />

	<!-- set the encoding of your site -->
	<meta charset="utf-8">
	<title>MultiTracks.com</title>
	<!-- include the site stylesheet -->
    <link href="../PageToSync/css/index.css" rel="stylesheet" />
    <link href="../PageToSync/css/styles.css" rel="stylesheet" />
	
</head>
<body class="premium standard u-fix-fancybox-iframe">
	<form>
		<noscript>
			<div>Javascript must be enabled for the correct page display</div>
		</noscript>

		

		<div class="wrapper mod-standard mod-gray">
			
			


			<div class="discovery--container u-container">
							<main class="discovery--section">
								<section class="standard--holder">
						<div class="discovery--section--header">
							<h1 runat="server" id="artist_title" style="text-align:center;"></h1>
						</div><!-- /.discovery-section-header -->

						<div class="artist-details--biography biography">
							<div class="read-more-container">
								<div class="container">
									<asp:ListView ID="artist_biography" runat="server">
										<ItemTemplate>
											<p runat="server"><%# Eval("first_part")%>
										    	<span runat="server" class="read-more-text" ><%# Eval("second_part")%></span>
								         	</p>
											<span class="read-more-btn">Read More...</span>
										</ItemTemplate>
										
									</asp:ListView>
									
								</div>
							</div>
							
						</div>
					</section><!-- /.biography-section -->
				</main><!-- /.discovery-section -->
			</div><!-- /.standard-container -->
		</div><!-- /.wrapper -->
		


		

		
           

	</form>
    <script src="../PageToSync/js/script.js"></script>
	
 	

</body>
</html>
