<?php get_header(); ?>
	
	<section id="main"><!-- #main content and sidebar area -->
		<section id="content"><!-- #content -->
		<!-- Start dynamic part -->
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

		<?php get_sidebar('right-sidebar'); ?>
		 <?php comments_template('',true); ?> 
	</section><!-- end of #main content and sidebar-->
	

<?php get_footer(); ?>