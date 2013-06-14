

		<footer>
		<section id="footer-area">

			<section id="footer-outer-block">
			<?php //get_sidebar( 'footer' ); ?>
					<aside class="footer-segment">
					<?php 
						if(!dynamic_sidebar('footer-sidebar-1')) :
					?>
							<h4>Friends</h4>
								<ul>
									<li><a href="#">one linkylink</a></li>
									<li><a href="#">two linkylinks</a></li>
									<li><a href="#">three linkylinks</a></li>
								</ul>
					<?php endif;?>
					</aside><!-- end of #first footer segment -->

					<aside class="footer-segment">
					<?php 
						if(!dynamic_sidebar('footer-sidebar-2')) :
					?>
							<h4>Awesome Stuff</h4>
								<ul>
									<li><a href="#">one linkylink</a></li>
									<li><a href="#">two linkylinks</a></li>
									<li><a href="#">three linkylinks</a></li>
								</ul>
						<?php endif; ?>
					</aside><!-- end of #second footer segment -->

					<aside class="footer-segment">
					<?php 
						if(!dynamic_sidebar('footer-sidebar-3')) :
					?>
							<h4>Coolness</h4>
								<ul>
									<li><a href="#">one linkylink</a></li>
									<li><a href="#">two linkylinks</a></li>
									<li><a href="#">three linkylinks</a></li>
								</ul>
								<?php endif; ?>
					</aside><!-- end of #third footer segment -->
					
					<aside class="footer-segment">
					<?php 
						if(!dynamic_sidebar('footer-sidebar-4')) :
					?>
							<h4>Blahdyblah</h4>
								<p>&copy; 2010 <a href="#">yoursite.com</a> Praesent libero. Sed cursus ante dapibus diam. Sed nisi.</p>
								<?php endif; ?>
					</aside><!-- end of #fourth footer segment -->

			</section><!-- end of footer-outer-block -->

		</section><!-- end of footer-area -->
	</footer>
	
</div><!-- #wrapper -->
<?php wp_footer(); ?> 
</body>
</html>
