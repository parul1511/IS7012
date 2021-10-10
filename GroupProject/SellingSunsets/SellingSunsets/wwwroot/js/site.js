// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

// desktop version sliding menus

//enable menu animation if the screen is set to desktop
function enableMenus() {
    //create shortcut for nav element
    var menu = $('#siteNav');
    //check to see if we are on desktop .vs tablet or mobile
    if ($(document).width() > 768) {
        //strip out no-js class if jQuery is running the animation
        if ($('body').hasClass('no-js')) {
            $('body').removeClass('no-js');
        };
        //attach a listener to each li that has a child ul, and then slide submenus down or up depending upon mouse position
        menu.find('li').each(function () {
            if ($(this).find('ul').length > 0) {
                // strip any existing events
                $(this).unbind();
                /*$(this).mouseenter(function () {
                    $(this).find('ul').stop(true, true).slideDown('fast');
                });*/
                $(this).mouseenter(function () {
                    $(this).find('ul').stop(true, true).slideDown('slow');
                });
                
            };
        });
    } else {
        menu.find('li').each(function () {
            if ($(this).find('ul').length > 0) {
                // strip any existing events
                $(this).unbind();
            };
        });
        if ($('body').hasClass('no-js') ==
            false) {
            $('body').addClass('no-js');
        };
    };
};
$(document).ready(function () {
    enableMenus();
});
$(window).resize(function () {
    enableMenus();
});

jQuery(document).ready(function ($) {

    
        setInterval(function () {
            moveRight();
        }, 3000);
    

    var slideCount = $('#slider ul li').length;
    var slideWidth = $('#slider ul li').width();
    var slideHeight = $('#slider ul li').height();
    var sliderUlWidth = slideCount * slideWidth;

    $('#slider').css({ width: slideWidth, height: slideHeight });

    $('#slider ul').css({ width: sliderUlWidth, marginLeft: - slideWidth });

    $('#slider ul li:last-child').prependTo('#slider ul');

    function moveLeft() {
        $('#slider ul').animate({
            left: + slideWidth
        }, 200, function () {
            $('#slider ul li:last-child').prependTo('#slider ul');
            $('#slider ul').css('left', '');
        });
    };

    function moveRight() {
        $('#slider ul').animate({
            left: - slideWidth
        }, 200, function () {
            $('#slider ul li:first-child').appendTo('#slider ul');
            $('#slider ul').css('left', '');
        });
    };

    $('a.control_prev').click(function () {
        moveLeft();
    });

    $('a.control_next').click(function () {
        moveRight();
    });

});