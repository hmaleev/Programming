<?php 

$sidebar_args = array(
		'id' => 'right-sidebar-1',
		'name' => 'Outer Right Sidebar',
		);

$sidebar2_args = array(
		'id' => 'right-sidebar-2',
		'name' => 'Inner Right Sidebar',
		);
register_sidebar($sidebar_args);
register_sidebar($sidebar2_args);

register_nav_menu ('top-site-menu','This is top side menu');