<?php get_header(); ?>
	
	<section id="main"><!-- #main content and sidebar area -->
		<section id="content"><!-- #content -->
		<!-- Start dynamic part -->
<?php
	if(have_posts()):
		while (have_posts()):
			the_post();
			?>	
			<h2><a href="<?php the_permalink();?>"> <?php the_title(); ?></a></h2>		
			<?php the_content(); ?>
			<p><?php the_tags(); ?><p>
				<?php 
		endwhile;
	endif;
	?>	

	<p><?php next_posts_link(); ?></p>
	<!-- end dynamic part -->	
		</section><!-- end of #content -->

		<?php get_sidebar('right-sidebar'); ?>
		 <?php comments_template('',true); ?> 
	</section><!-- end of #main content and sidebar-->
	

<?php get_footer(); ?>