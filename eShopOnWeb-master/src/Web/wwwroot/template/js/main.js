(function($){
	"use strict";
	
	//Tool-tips
	function wc_tooltip(element, content) {
		if (content == 'html') {
			var tipText = element.html();
		} else {
			var tipText = element.attr('title');
		}
		element.on('mouseover', function() {
			if ($('.wc_tooltip').length == 0) {
				element.before('<span class="wc_tooltip">' + tipText + '</span>');

				var tipWidth = $('.wc_tooltip').outerWidth(true);
				var tipPush = -(tipWidth / 2 - element.outerWidth(true) / 2);
				$('.wc_tooltip').css('margin-left', tipPush);
			}
		});
		element.on('mouseleave', function() {
			$('.wc_tooltip').remove();
		});
	}
    //Tooltip
    $('.product-action .yith-wcwl-add-to-wishlist a').each(function() {
        wc_tooltip($(this), 'title');
    });
    $('.product-action .compare').each(function() {
        wc_tooltip($(this), 'title');
    });
    $('.product-action a.add_to_cart_button').each(function() {
        wc_tooltip($(this), 'html');
    });
    $('.product-action a.product_type_grouped').each(function() {
        wc_tooltip($(this), 'html');
    });
    $('.product-action a.product_type_external').each(function() {
        wc_tooltip($(this), 'html');
    });
    $('.product-action a.product_type_variable').each(function() {
        wc_tooltip($(this), 'html');
    });
    $('.product-action a.product_type_simple').each(function() {
        wc_tooltip($(this), 'html');
    });
    $('.product-action a.added_to_cart').each(function() {
        wc_tooltip($(this), 'html');
    });
    $('.product-action .quickviewbtn a').each(function() {
        wc_tooltip($(this), 'html');
    });

	/**
	* Header Area start
	*/
	$("body.header-sticky header").addClass("animated");
	$(window).on('scroll',function() {    
		var scroll = $(window).scrollTop();
		if (scroll < 245) {
			$("body.header-sticky header").removeClass("is-sticky");
		}else{
			$("body.header-sticky header").addClass("is-sticky");
		}
	}); 

	$("header.header-sticky").addClass("animated");
	$(window).on('scroll',function() {    
		var scroll = $(window).scrollTop();
		if (scroll < 245) {
			$("header.header-sticky").removeClass("is-sticky");
		}else{
			$("header.header-sticky").addClass("is-sticky");
		}
	}); 


	if ( $('body').hasClass('logged-in') ) {
		var top_offset = $('.header-area').height() + 32;
	} else {
		var top_offset = $('.header-area').height() - 0;
	}

	$('.primary-nav-one-page nav').onePageNav({
	     scrollOffset: top_offset,
		 scrollSpeed: 750,
		 easing: 'swing',
		 currentClass: 'active',
	});

	$('body').scrollspy({target: ".primary-nav-wrap nav"});

	$(".primary-nav-one-page nav ul li:first-child").addClass("active"); 

	$('.primary-nav-wrap > nav > ul > li').slice(-2).addClass('last-elements');
	
    /*-- Mobile Menu --*/

    $('.primary-nav-wrap nav,.main-menu nav').meanmenu({
        // meanScreenWidth: mobile_menu_data.menu_width,
        meanScreenWidth: 991,
        meanMenuContainer: '.mobile-menu',
        meanDisplay: 'table-cell'
    });
    
	/*
    * Header Transparent 
    */
    function headerTransparentTopbar(){
    	var headerTopbarHeight = $('.header-top-area').innerHeight(),
    		trigger = $('.main-header.header-transparent'),
    		bodyTrigger = $('body.logged-in .main-header.header-transparent');
    	if( trigger.parents().find('.header-top-area') ){
    		trigger.css('top', headerTopbarHeight + 'px');
    	}
    	if( bodyTrigger.parents().find('.header-top-area') ){
    		bodyTrigger.css('top', (headerTopbarHeight + 32) + 'px' );
    	}
    }
    headerTransparentTopbar();

    /**
    * ScrollUp
    */
	function backToTop(){

		var didScroll = false,
			scrollTrigger = $('#back-to-top');
		
		scrollTrigger.on('click',function(e) {
			$('body,html').animate({ scrollTop: "0" });
			e.preventDefault();
		});
		
		$(window).scroll(function() {
			didScroll = true;
		});

		setInterval(function() {
			if( didScroll ) {
				didScroll = false;
		
				if( $(window).scrollTop() > 250 ) {
					scrollTrigger.css('right',20);
				} else {
					scrollTrigger.css('right','-50px');
				}
			}
		}, 250);
	}
	backToTop();


	/**
	* Magnific Popup video popup 
	*/
	$('a.video-popup').magnificPopup({
		type: 'iframe',
		closeOnContentClick: false,
		closeBtnInside: false,
		mainClass: 'mfp-with-zoom mfp-img-mobile',
		image: {
			verticalFit: true,
			titleSrc: function(item) {
				return item.el.attr('title') + ' &middot; <a class="image-source-link" href="'+item.el.attr('data-source')+'" target="_blank">image source</a>';
			}
		},
		gallery: {
			enabled: false
		},
		zoom: {
			enabled: true,
			duration: 300, // don't foget to change the duration also in CSS
			opener: function(element) {
				return element.find('img');
			}
		}
		
	});

	/**
	* Blog Gallery Post
	*/
	$('.blog-gallery').owlCarousel({
	    loop:true,
	    nav:true,
	    navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
	    responsive:{
	        0:{
	            items:1
	        },
	        768:{
	            items:1
	        },
	        1000:{
	            items:1
	        }
	    }
	});

	/**
	* Enable Footer Fixed effect
	*/
	function fixedFooter(){
		var fooCheck = $('footer').hasClass('fixed-footer-enable');
		if(fooCheck){
			$('.site-wrapper').addClass('fixed-footer-active'); 
		}
		var FooterHeight = $('footer.fixed-footer-enable').height(),
			winWidth = $(window).width();
		if( winWidth > 991 ){
			$('.fixed-footer-active').css({'margin-bottom': FooterHeight});
			$('.fixed-footer-active .site-content').css({'background': '#ffffff'});
		} else{
			$('footer').removeClass('fixed-footer-enable');
		}
	}
	fixedFooter();

	/**
	* Page Preloading Effects
	*/
	$(window).on('load', function(){
		$(".loading-init").fadeOut(500);
	});


	/**
	* Blog Masonry
	*/
	$('.blog-masonry').imagesLoaded( function() {
		// init Isotope
		var $grid = $('.blog-masonry').isotope({
		  itemSelector: '.grid-item',
		  percentPosition: true,
		  masonry: {
			// use outer width of grid-sizer for columnWidth
			columnWidth: '.grid-item',
		  }
		});

	});


	/**
	* Shop Masonry
	*/
	$('.post-type-archive-product .row.grid_view.products').imagesLoaded( function() {
		  var container = document.querySelector('.post-type-archive-product .row.grid_view.products');
		  var msnry = new Masonry( container, {
		    itemSelector: '.product',
		    columnWidth: '.product',                
		  });

		  $(".shop-tab li:first-child").click(function(){
	          window.location.reload();
	      });
	});


	
	// sophie

	/* slider-active */
	$('.flex-control-nav').owlCarousel({
	    loop:true,
	    nav:true,
		navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
		dots:true,
	    responsive:{
	        0:{
	            items:1
	        },
	        767:{
	            items:1
	        },
	        1000:{
	            items:1
	        }
	    }
	});

	if(typeof sophie_localize !== 'undefined'){
		var $per_row_related = sophie_localize.per_row_related;
	} else {
		$per_row_related = '5';
	}

	/* product-active */
	$('.related_carousel_activate').owlCarousel({
	    loop:true,
	    nav:true,
		navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
	    responsive:{
	        0:{
	            items:1
	        },
	        767:{
	            items:3
	        },
	        1000:{
	            items:4
	        },
	        1200:{
	            items:$per_row_related
	        }
	    }
	});

	$('.upsell_carousel_activate').owlCarousel({
	    loop:true,
	    nav:true,
		navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
	    responsive:{
	        0:{
	            items:1
	        },
	        767:{
	            items:3
	        },
	        1000:{
	            items:4
	        },
	        1200:{
	            items:$per_row_related
	        }
	    }
	});

	/* product-active */
	$('.trendy-product-active').owlCarousel({
	    loop:true,
	    nav:true,
		navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
	    responsive:{
	        0:{
	            items:1
	        },
	        767:{
	            items:3
	        },
	        1000:{
	            items:3
	        }
	    }
	});

	 /* tooltip */
	 $('[data-toggle="tooltip"]').tooltip();


	/* brand-active */
	$('.product-img-active').owlCarousel({
	    loop:true,
	    nav:true,
		navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
	    responsive:{
	        0:{
	            items:2
	        },
	        767:{
	            items:3
	        },
	        1000:{
	            items:4
	        }
	    }
	});



	/* details-tab */ 
	$('.details-tab').owlCarousel({
		loop:false,
		margin:10,
		nav:true,
		navText:['<i class="fa fa-long-arrow-left"></i>','<i class="fa fa-long-arrow-right"></i>'],
		responsive:{
			0:{
				items:3
			},
			450:{
				items:3
			},
			767:{
				items:3
			},
			1000:{
				items:4
			}
		}
	});	

	$('.video-popup').magnificPopup({
	  type: 'iframe'
	});


	/* team-active */
	$('.team-active').owlCarousel({
		loop:true,
		nav:false,
		responsive:{
			 0:{
	            items:1
	        },
	        767:{
	            items:3
	        },
	        1000:{
	            items:4
			}
		}
	});	


	/* counter */
	$('.counter').counterUp({
	    delay: 10,
	    time: 1000
	});

	/* showlogin toggle function */
	 $( '#showlogin' ).on('click', function() {
		$( '#checkout-login' ).slideToggle(900);
	 }); 
		
	/* showcoupon toggle function */
	 $( '#showcoupon' ).on('click', function() {
		$( '#checkout_coupon' ).slideToggle(900);
	 });
		 
	/* Create an account toggle function */
	 $( '#cbox' ).on('click', function() {
		$( '#cbox_info' ).slideToggle(900);
	 });
		 
	/* Create an account toggle function */
	 $( '#ship-box' ).on('click', function() {
		$( '#ship-box-info' ).slideToggle(1000);
	 });

	/* countdown */
	 if($('.countdown-wrapper').length){
		$('[data-countdown]').each(function() {
		  var $this = $(this), finalDate = $(this).data('countdown');
		  $this.countdown(finalDate, function(event) {
			$this.html(event.strftime('<span class="cdown days"><span class="time-count">%-D</span> <p>Days</p></span> <span class="cdown hour"><span class="time-count">%-H</span> <p>Hour</p></span> <span class="cdown minutes"><span class="time-count">%M</span> <p>Min</p></span> <span class="cdown second"> <span class="time-count">%S</span> <p>Sec</p></span>'));
		  });
		});
	}	 
	 
	 /* image-link */
	$('.image-link,.popup-link').magnificPopup({
	  type: 'image',
	  gallery:{
	    enabled:true
	  }
	});


	/* slider-range */ 
	$( "#slider-range" ).slider({
		range: true,
		min: 0,
		max: 500,
		values: [ 75, 300 ],
		slide: function( event, ui ) {
			$( "#amount" ).val( "$" + ui.values[ 0 ] + " - $" + ui.values[ 1 ] );
		}
	});

	$( "#amount" ).val( "$" + $( "#slider-range" ).slider( "values", 0 ) +
	" - $" + $( "#slider-range" ).slider( "values", 1 ) );

	$('header .serch-container i').on('click', function() {
		if($(this).hasClass('fa fa-close')){

			$(this).removeClass('fa fa-close').addClass('fa fa-search');
			$('.blog-search').removeClass('active');

		}else {

			$(this).removeClass('fa fa-search').addClass('fa fa-close');
			$('.blog-search').addClass('active');
		}

	})

	
})(jQuery);