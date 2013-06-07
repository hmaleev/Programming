<!doctype html>
<html lang="en">
<head>
	<meta charset="utf-8" />
	<title>Telerik Academy</title>
	<link rel="stylesheet" href="<?php echo get_template_directory_uri(); ?>/page.css" type="text/css" media="screen" />
	<!--[if IE]><script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script><![endif]-->
</head>
<body>
<div id="wrapper"><!-- #wrapper -->
	<header><!-- header -->
		<h1><a href="#">Telerik Academy</a></h1>
		<h2>Your compelling tag line goes here</h2>
		<!-- <img src="images/headerimg.jpg" width="940" height="200" alt=""> -->
		<!-- header image -->
	</header><!-- end of header -->
	<nav>
	<?php 
		wp_nav_menu(array(
		'theme_location' => 'top-site-menu',
		'container' =>'div',
		'container_class' => 'menu',)) 
	?>
	</nav>
	<section id="main"><!-- #main content and sidebar area -->

			<section id="content"><!-- #content -->
			<?php
	if(have_posts()):
		while (have_posts()):
			the_post();
			?>	
			<h2><?php the_title(); ?></h2>
			<?php the_content(); ?>
	<?php 
		endwhile;
	endif;
	?>					
	<!-- end dynamic part -->	
		</section><!-- end of #content -->
		 <?php comments_template('',true); ?> 
	</section><!-- end of #main content and sidebar-->
<?php get_footer() ?>
