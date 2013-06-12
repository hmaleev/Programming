<!doctype html>
<html lang="en">
<head>
	<meta charset="utf-8" />
	<title>Telerik Academy</title>
	<link rel="stylesheet" type="text/css" media="screen"  href="<?php bloginfo( 'stylesheet_url' ); ?>"/>
	<!--[if IE]><script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script><![endif]-->
</head>
<body>
<div id="wrapper"><!-- #wrapper -->
	<header><!-- header -->
		<h1><a href="#">Telerik Academy</a></h1>
		<h2>Your compelling tag line goes here</h2>
		<img src="<?php echo get_template_directory_uri(); ?>/images/headerimg.jpg" width="940" height="200" alt=""><!-- header image -->
	</header><!-- end of header -->
	<!-- top nav -->
	
	<?php
	
	//echo '<nav>';

		//echo '</nav>';

	?>
	
	<?php
if ( has_nav_menu( 'top-side-menu') ) {
echo '<nav>';
		wp_nav_menu(array(
		
		'theme_location' => 'top-site-menu',
		'menu' => 'Top Menu',
		'container' =>'div',
		'container_class' =>'menu',
		));
echo'</nav>';}
else 
 echo '<nav>
		<div class="menu">
			<ul>
				<li><a href="#">Home</a></li>
				<li><a href="#">About</a></li>
				<li><a href="#">Products</a></li>
				<li><a href="#">Services</a></li>
				<li><a href="#">Support</a></li>
				<li><a href="#">Contact Us</a></li>
			</ul>
		</div>
	</nav>';
		?> 
	</nav>
 
	<!-- end of top nav -->
	
	