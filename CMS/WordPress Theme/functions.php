<?php 

$sidebar_args = array(
		'id' => 'right-sidebar-1',
		'name' => 'Main Sidebar-1',
		);

$sidebar2_args = array(
		'id' => 'right-sidebar-2',
		'name' => 'Main Sidebar-2',
		);
register_sidebar($sidebar_args);
register_sidebar($sidebar2_args);

register_nav_menu ('top-site-menu','This is top side menu');
?>
