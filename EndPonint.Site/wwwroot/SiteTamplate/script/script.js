// JavaScript Document
$(document).ready(function(e) {
    $(".main .main_top .main_top_bottom ul li").hover(function(e) {
        $("ul",this).css("display","block");
	},
		function(e)
		{
			$("ul",this).css("display","");
    });
});