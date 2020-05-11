(function ($) {
    if ($(".kc-css-295048 .owl-carousel").length) {
        $(".kc-css-295048 .owl-carousel").owlCarousel({
            loop: false,
            margin: 0,
            nav: true,
            autoplay: false,
            navText: ['<i class="fa fa-angle-left"></i>', '<i class="fa fa-angle-right"></i>'],
            autoplayTimeout: 5000,
            lazyLoad: true,
            items: 1,
            responsive: {
                0: {
                    items: 1,
                },
                480: {
                    items: 2,
                },
                768: {
                    items: 3,
                },
                992: {
                    items: 3,
                },
                1200: {
                    items: 5,
                },
            },
        });
    }
})(jQuery);
