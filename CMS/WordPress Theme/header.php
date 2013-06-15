<!doctype html>
<html lang="en">
<head>
	<meta charset="utf-8" />
	<title>Telerik Academy</title>
	<link rel="stylesheet" type="text/css" media="screen"  href="<?php bloginfo( 'stylesheet_url' ); ?>"/>
	<!--[if IE]><script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script><![endif]-->
	 <?php wp_head(); ?>
</head>
<body>
<div id="wrapper"><!-- #wrapper -->
	<header><!-- header -->
		<h1 id="header">
			<a href="<?php bloginfo('url'); ?>"><?php bloginfo('name'); ?></a>
		</h1>
		<h2><?php bloginfo('description'); ?></h2>
		<!--<img src="<?php// echo get_template_directory_uri(); ?>/images/headerimg.jpg" width="940" height="200" alt=""><!-- header image -->
		<img src="<?php echo header_image(); ?>" height="<?php echo get_custom_header()->height; ?>" width="<?php echo get_custom_header()->width; ?>" alt="" />
	</header><!-- end of header -->
	<!-- top nav -->

	
	<?php
if ( has_nav_menu( 'top-side-menu') ) {
echo '<nav>';
		wp_nav_menu(array(
		
		'theme_location' => 'top-site-menu',
		'menu' => 'Top Menu',
		'container' =>'div',
		'container_class' =>'menu',
		'depth' => 0,
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
	
 
	<!-- end of top nav -->
	
	