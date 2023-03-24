jQuery(function($){
	
   //chain
	$("#chain-box").customChain({
		previous: ".arrow3-left",
		next: ".arrow3-right",
		target: ".chain li"
	});
	$("#chain-box-2").customChain({
		previous: ".arrow3-left",
		next: ".arrow3-right",
		target: ".chain li",
		totalDisplay: 4
	});
	$(".chain-box").mouseover(function(e){
		$target = $(e.target);
		if($target.is(".image img")){
			$target.animate({"opacity":0.6});
		}
	});
	$(".chain-box").mouseout(function(e){
		$target = $(e.target);
		if($target.is(".image img")){
			$target.animate({"opacity":1});
		}
	});
});
$(window).load(function(){
	$("body").width("auto");
	
});
//customChain
(function($){	
	$.fn.customChain = function(opt){
		
		var defaults = {
			target: "li",
			previous: ".previous",
			next: ".next",
			speed: 400,
			totalDisplay: 3
		};
		
		var o = $.extend(defaults, opt);
		
		return this.each(function(){
			
			var $this = $(this);
			var $next = $(o.next, $this);
			var $previous = $(o.previous, $this);
			var $target = $(o.target, $this);
			var total  = $target.length;
			var animation = true;
			var current = 0;
			var prev = 0;
			
			stimulateIn(current);
			
			$next.click(function(){
				if(animation){
					return false;
				}
				current += o.totalDisplay;
				if(current>=total){
					current = 0;
				}
				showFrom();
				return false;
			});
			$previous.click(function(){
				if(animation){
					return false;
				}
				current -= o.totalDisplay;
				if(current<0){
					var mod = total%o.totalDisplay;
					if(mod>0){
						current = total-(total%o.totalDisplay);
					}else{
						current = total-o.totalDisplay;
					}
				}
				showFrom();
				return false;
			});
			
			
			function showFrom(){
				animation = true;
				for(i = prev,j = 0,k = 0; j<o.totalDisplay; i++, j++){
					$target.eq(i).delay(j*120).animate({"top":220}, o.speed, function(){
						k++;
						//alert(total);
						if(k>=o.totalDisplay || i > total){
							stimulateIn();
						};
					});
				};				
			};
			
			function stimulateIn(){
				$target.hide();
				for(i = current,j =0; j<o.totalDisplay; i++, j++){
						$target.eq(i).delay(j*120).animate({"top":0, "opacity":"show"}, o.speed);
				}
				prev = current;
				animation = false;
			}
			
		});
		
	}
	
})(jQuery);


jQuery(function($){
	
   //chain
	$("#chain-box1s").customChain({
		previous: ".arrow3-left1s",
		next: ".arrow3-right1s",
		target: ".chain1s li"
	});
	$("#chain-box-21s").customChain({
		previous: ".arrow3-left1s",
		next: ".arrow3-right1s",
		target: ".chain1s li",
		totalDisplay: 4
	});
	$(".chain-box1s").mouseover(function(e){
		$target = $(e.target);
		if($target.is(".image img")){
			$target.animate({"opacity":0.6});
		}
	});
	$(".chain-box1s").mouseout(function(e){
		$target = $(e.target);
		if($target.is(".image img")){
			$target.animate({"opacity":1});
		}
	});
});
$(window).load(function(){
	$("body").width("auto");
	
});
//customChain
(function($){	
	$.fn.customChain = function(opt){
		
		var defaults = {
			target: "li",
			previous: ".previous",
			next: ".next",
			speed: 400,
			totalDisplay: 3
		};
		
		var o = $.extend(defaults, opt);
		
		return this.each(function(){
			
			var $this = $(this);
			var $next = $(o.next, $this);
			var $previous = $(o.previous, $this);
			var $target = $(o.target, $this);
			var total  = $target.length;
			var animation = true;
			var current = 0;
			var prev = 0;
			
			stimulateIn1(current);
			
			$next.click(function(){
				if(animation){
					return false;
				}
				current += o.totalDisplay;
				if(current>=total){
					current = 0;
				}
				showFrom1();
				return false;
			});
			$previous.click(function(){
				if(animation){
					return false;
				}
				current -= o.totalDisplay;
				if(current<0){
					var mod = total%o.totalDisplay;
					if(mod>0){
						current = total-(total%o.totalDisplay);
					}else{
						current = total-o.totalDisplay;
					}
				}
				showFrom1();
				return false;
			});
			
			
			function showFrom1(){
				animation = true;
				for(i = prev,j = 0,k = 0; j<o.totalDisplay; i++, j++){
					$target.eq(i).delay(j*120).animate({"top":220}, o.speed, function(){
						k++;
						//alert(total);
						if(k>=o.totalDisplay || i > total){
							stimulateIn1();
						};
					});
				};				
			};
			
			function stimulateIn1(){
				$target.hide();
				for(i = current,j =0; j<o.totalDisplay; i++, j++){
						$target.eq(i).delay(j*120).animate({"top":0, "opacity":"show"}, o.speed);
				}
				prev = current;
				animation = false;
			}
			
		});
		
	}
	
})(jQuery);


jQuery(function($){
	
   //chain
	$("#chain-box2s").customChain({
		previous: ".arrow3-left2s",
		next: ".arrow3-right2s",
		target: ".chain2s li"
	});
	$("#chain-box-22s").customChain({
		previous: ".arrow3-left2s",
		next: ".arrow3-right2s",
		target: ".chain2s li",
		totalDisplay: 4
	});
	$(".chain-box2s").mouseover(function(e){
		$target = $(e.target);
		if($target.is(".image img")){
			$target.animate({"opacity":0.6});
		}
	});
	$(".chain-box2s").mouseout(function(e){
		$target = $(e.target);
		if($target.is(".image img")){
			$target.animate({"opacity":1});
		}
	});
});
$(window).load(function(){
	$("body").width("auto");
	
});
//customChain
(function($){	
	$.fn.customChain = function(opt){
		
		var defaults = {
			target: "li",
			previous: ".previous",
			next: ".next",
			speed: 400,
			totalDisplay: 3
		};
		
		var o = $.extend(defaults, opt);
		
		return this.each(function(){
			
			var $this = $(this);
			var $next = $(o.next, $this);
			var $previous = $(o.previous, $this);
			var $target = $(o.target, $this);
			var total  = $target.length;
			var animation = true;
			var current = 0;
			var prev = 0;
			
			stimulateIn2(current);
			
			$next.click(function(){
				if(animation){
					return false;
				}
				current += o.totalDisplay;
				if(current>=total){
					current = 0;
				}
				showFrom2();
				return false;
			});
			$previous.click(function(){
				if(animation){
					return false;
				}
				current -= o.totalDisplay;
				if(current<0){
					var mod = total%o.totalDisplay;
					if(mod>0){
						current = total-(total%o.totalDisplay);
					}else{
						current = total-o.totalDisplay;
					}
				}
				showFrom2();
				return false;
			});
			
			
			function showFrom2(){
				animation = true;
				for(i = prev,j = 0,k = 0; j<o.totalDisplay; i++, j++){
					$target.eq(i).delay(j*120).animate({"top":220}, o.speed, function(){
						k++;
						//alert(total);
						if(k>=o.totalDisplay || i > total){
							stimulateIn2();
						};
					});
				};				
			};
			
			function stimulateIn2(){
				$target.hide();
				for(i = current,j =0; j<o.totalDisplay; i++, j++){
						$target.eq(i).delay(j*120).animate({"top":0, "opacity":"show"}, o.speed);
				}
				prev = current;
				animation = false;
			}
			
		});
		
	}
	
})(jQuery);