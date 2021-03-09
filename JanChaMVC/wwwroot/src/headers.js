$(function(){
		//导航栏
	  //   $(".header_right>ul li").eq(1).hover(function(){
	  //   		$('ol').css('display','block');
	  //   		$("ol li").eq(1).css('display','block');
	  //   		$("ol li").eq(1).siblings().css('display','none');
	    	
	  //   })
	  //   $(".header_right>ul li").eq(3).hover(function(){
	  //   		$('ol').css('display','block');
	  //   		$("ol li").eq(3).css('display','block');
	  //   		$("ol li").eq(3).siblings().css('display','none');
	    	
	  //   })
	  //   var index;
	  //   $(".header_right>ul li").hover(function(){
	  //   	if($(this).index()==0||$(this).index()==2||$(this).index()==4){
	  //   		$("ol").css('display','none');
	  //   	}
	  //   	$(this).children().children('a').css('color','#fff');
	  //   	$(this).siblings().children().children('a').css('color','#747474');
	  //   	index=$(this).index();
	    	
	  //   	$(this).children().children('.bgs').stop().animate({
	  //   		'top':'15px'
	  //   	},200)
	  //   	$(this).siblings().children().children('.bgs').stop().animate({
	  //   		'top':'80px'
	  //   	},200)
	  //   },function(){
			// if($(this).index()==0||$(this).index()==2||$(this).index()==4){
			// 	$(this).children().children('a').css('color','#747474');
		 //    	$(this).children().children('.bgs').stop().animate({
		 //    		'top':'80px'
		 //    	},200)
		 //    	$('.a').stop().animate({
		 //    		'top':'15px'
		 //    	},200);
		 //    	$('.a').siblings().css('color','#fff');
	  //   	}
	  //   })
	    
	  //   $('ol').hover(function(){
	    	
	  //   },function(){
	  //   	$(this).css('display','none');
	  //   	$('.header_right>ul li').eq(index).children().children('a').css('color','#747474');
	  //   	$('.header_right>ul li').eq(index).children().children('.bgs').stop().animate({
	  //   		'top':'80px'
	  //   	},200)
	  //   	$('.a').stop().animate({
	  //   		'top':'15px'
	  //   	},200);
	  //   	$('.a').siblings().css('color','#fff');
	  //   })
	    //搜索框
	    $(".header_right_right .two ").hover(function(){
	    	/*$(this).css('display','none');
	    	$('.two').removeClass('twos');*/
	    	$(".header_right_right>.two .suo").stop().animate({
	    		'width':'130px',
	    		// 'left':'0px;'
	    	})
	    	// $(".header_right_right>.two .sou").stop().animate({'right':'-3px'})
		    // })

		// $("header").hover(function(){
		   		
		},function(){
		   $(".header_right_right>.two .suo").stop().animate({
	    		'width':'0px',
	    		// 'left':'4px;'
	    	})
	    	// $(".header_right_right>.two .sou").stop().animate({'right':'1px'})
	   		/*$('.one').css('display','inline');
	    	$('.two').addClass('twos');*/
	   })
	    //办公通道
	   	$(".three").hover(function(){
	    	$(this).stop().animate({
	    		'width':'260px'
	    	})
	    	// $(this).children('img').stop().animate({
	    	// 	'left':'-30px',
	    	// })
	    	// $(this).children('.pg').stop().animate({
	    	// 	'left':'-92px',
	    	// })
	    	$(this).children('p').stop().animate({
	    		'opacity':'1'
	    	})
	    },function(){
	    	$(this).stop().animate({
	    		'width':'92px'
	    	})
	    	// $(this).children('img').stop().animate({
	    	// 	'left':'6px',
	    	// })
	    	// $(this).children('.pg').stop().animate({
	    	// 	'left':'33px',
	    	// })
	    	$(this).children('p').stop().animate({
	    		'opacity':'0'
	    	})
	    })
	    



	    $(".sou").click(function(){
			var text = $(".suo").val();
//			console.log(text);
//			window.location.href = "search?text=" + text;window.event.returnValue = false;
 			$("#hdSearchText").val(text);
 			$("#searchForm").submit();
	    })
	    //滚动显示回到顶部
	    $(window).on('scroll', function () {//当滚动条的垂直位置大于浏览器所能看到的页面的那部分的高度时，回到顶部按钮就显示 
	        if ($(window).scrollTop() > $(window).height()-$(window).height())
	        	$(".back>.icon").fadeIn();
	        else
	        	$(".back>.icon").fadeOut();
	    });
	    $(window).trigger('scroll');
	    //回到顶部
	    $(".back>.icon").click(function(){
	    	
	        $('html,body').animate({
	            scrollTop: 0
	        }, 800);
	    })
	    
	    $(".map>.icon").click(function(){
	    	$(".menu").fadeToggle();
	    	$(".shades").fadeToggle();
	    })
	    $(".menu_title>img").click(function(){
	    	$(".menu").fadeToggle();
	    	$(".shades").fadeToggle();
	    })
	    $(".shades").click(function(){
	    	$(".menu").fadeToggle();
	    	$(".shades").fadeToggle();
	    })




})
