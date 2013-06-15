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
		<h1 id="header">
			<a href="<?php bloginfo('url'); ?>"><?php bloginfo('name'); ?></a>
		</h1>
		<h2><?php bloginfo('description'); ?></h2>
		<!--<img src="<?php// echo get_template_directory_uri(); ?>/images/headerimg.jpg" width="940" height="200" alt=""><!-- header image -->
		<img src="<?php echo header_image(); ?>" height="<?php echo get_custom_header()->height; ?>" width="<?php echo get_custom_header()->width; ?>" alt="" />
	</header><!-- end of header -->
	<nav>
	<?php 
		wp_nav_menu(array(
		'theme_location' => 'top-site-menu',
		'menu' =>'Top Menu',
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
		<h2><a href="<?php the_permalink();?>"> <?php the_title(); ?></a></h2>
			<?php the_content(); ?>
	<?php 
		endwhile;
	endif;
	?>					
	<!-- end dynamic part -->
	</section><!-- end of #content -->


		<aside id="sidebar2"><!-- sidebar2 -->
			<?php 
				if(!dynamic_sidebar('page-sidebar-1')) :
			?>
				<h3>Stuff</h3>
					<ul>
						<li><a href="#">Curabitur sodales</a></li>
						<li><a href="#">Sed dignissim</a></li>
						<li><a href="#">Fusce nec</a></li>
						<li><a href="#">Nulla quis</a></li>
					</ul>

				<h3>More Stuff</h3>
					<ul>
						<li><a href="#">Blah, blah and all blah</a></li>
						<li><a href="#">More blah</a></li>
					</ul>

				<h3>S'more Goodies</h3>
					<ul>
						<li><a href="#">Curabitur sodales</a></li>
						<li><a href="#">Sed dignissim</a></li>
						<li><a href="#">Fusce nec</a></li>
						<li><a href="#">Nulla quis</a></li>
						<li><a href="#">Curabitur sodales</a></li>
						<li><a href="#">Sed dignissim</a></li>
						<li><a href="#">Fusce nec</a></li>
						<li><a href="#">Nulla quis</a></li>
					</ul>

				<h3>Did You Know?</h3>
					<ul>
						<li><a href="#">Curabitur sodales</a></li>
						<li><a href="#">Sed dignissim</a></li>
						<li><a href="#">Fusce nec</a></li>
						<li><a href="#">Nulla quis</a></li>
						<li><a href="#">Curabitur sodales</a></li>
						<li><a href="#">Sed dignissim</a></li>
						<li><a href="#">Fusce nec</a></li>
						<li><a href="#">Nulla quis</a></li>
					</ul>

				<h3>FAQ</h3>
					<ul>
						<li><a href="#">Curabitur sodales</a></li>
						<li><a href="#">Sed dignissim</a></li>
						<li><a href="#">Fusce nec</a></li>
						<li><a href="#">Nulla quis</a></li>
						<li><a href="#">Curabitur sodales</a></li>
						<li><a href="#">Sed dignissim</a></li>
						<li><a href="#">Fusce nec</a></li>
						<li><a href="#">Nulla quis</a></li>
					</ul>
				<?php endif; ?>
		</aside><!-- end of sidebar -->

		 <?php comments_template('',true); ?> 
	</section><!-- end of #main content and sidebar-->
<?php get_footer() ?>
