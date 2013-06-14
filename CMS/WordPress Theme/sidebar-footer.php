<?php
/**
 * The Footer widget areas.
 *
 * @package WordPress
 * @subpackage Twenty_Eleven
 * @since Twenty Eleven 1.0
 */
?>

<?php
	/* The footer widget area is triggered if any of the areas
	 * have widgets. So let's check that first.
	 *
	 * If none of the sidebars have widgets, then let's bail early.
	 */
	if (   ! is_active_sidebar( 'footer-sidebar-1'  )
		&& ! is_active_sidebar( 'footer-sidebar-2' )
		&& ! is_active_sidebar( 'footer-sidebar-3' )
		&& ! is_active_sidebar( 'footer-sidebar-4' )
	)
		return;
	// If we get this far, we have widgets. Let do this.
?>

	<?php if ( is_active_sidebar( 'footer-sidebar-1' ) ) : ?>
	<div id="first" class="widget-area" role="complementary">
		<?php dynamic_sidebar( 'footer-sidebar-1' ); ?>
	</div><!-- #first .widget-area -->
	<?php endif; ?>

	<?php if ( is_active_sidebar( 'footer-sidebar-2' ) ) : ?>
	<div id="second" class="widget-area" role="complementary">
		<?php dynamic_sidebar( 'footer-sidebar-2' ); ?>
	</div><!-- #second .widget-area -->
	<?php endif; ?>

		<?php if ( is_active_sidebar( 'footer-sidebar-3' ) ) : ?>
	<div id="first" class="widget-area" role="complementary">
		<?php dynamic_sidebar( 'footer-sidebar-3' ); ?>
	</div><!-- #first .widget-area -->
	<?php endif; ?>

	<?php if ( is_active_sidebar( 'footer-sidebar-4' ) ) : ?>
	<div id="second" class="widget-area" role="complementary">
		<?php dynamic_sidebar( 'footer-sidebar-4' ); ?>
	</div><!-- #second .widget-area -->
	<?php endif; ?>
