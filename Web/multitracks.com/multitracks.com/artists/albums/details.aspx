<%@ Page Language="C#" AutoEventWireup="true" CodeFile="details.aspx.cs" Inherits="artists_albums_details" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<!-- set the viewport width and initial-scale on mobile devices -->
	<meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no" />

	<!-- set the encoding of your site -->
	<meta charset="utf-8">
	<title>MultiTracks.com</title>
	<!-- include the site stylesheet -->

	<link media="all" rel="stylesheet" href="/pageToSync/css/index.css">
</head>
<body class="premium standard u-fix-fancybox-iframe">
	<form>
		<noscript>
			<div>Javascript must be enabled for the correct page display</div>
		</noscript>



		<div class="wrapper mod-standard mod-gray">
				<div class="discovery--container u-container">
							<main class="discovery--section">
								<div class="discovery--space-saver">
									<section class="standard--holder">
										<div class="discovery--section--header">
											<h1 runat="server" id="artist_title" style="text-align:center;"></h1>
											</div><!-- /.discovery-select -->

										<div class="discovery--grid-holder">

											<div class="ly-grid ly-grid-cranberries">
												<asp:ListView ID="AlbumsList" runat="server">
										            <ItemTemplate>

												<div class="media-item">
													<a runat="server" class="media-item--img--link" href="#" tabindex="0">

														<asp:Image 
															runat="server"
															ImageUrl=<%#Eval("albumURL") %>
															AlternateText=<%#Eval("alt_text") %>															
															class="media-item--img" 
															
														/>
														<span class="image-tag">Master</span>
													</a>
													<a runat="server" class="media-item--title" href="#" tabindex="0"><%# Eval("album_title")%></a>
													
												</div>
											</ItemTemplate>
											</asp:ListView>

											</div><!-- /.grid -->
										</div><!-- /.discovery-grid-holder -->
									</section><!-- /.songs-section -->
								</div>

								





			






					
				</main><!-- /.discovery-section -->
			</div><!-- /.standard-container -->
		</div><!-- /.wrapper -->







		
    </form>
</body>
</html>
