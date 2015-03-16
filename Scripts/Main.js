$(document).ready(function () {

    $('body').on('click', '.ajax-link', function () {
        var btnClicked = $(this); 
        var btnID = $(this).attr('id')


        $.get($(this).data('url'), function (data) {
            if (btnClicked.hasClass('submenu')) {
                $('#subContainer').html(data);

                $('#container').find('.ajax-link').removeClass('active'); 
                btnClicked.addClass('active'); 
            }
            else {
                $('#container').html(data);
                $('header').find('.ajax-link').removeClass('active'); 
                $('#' + btnID).addClass('active'); 

            }
        });
    });

    $('body').on('submit', '.ajax-form', function (event) {

     
        event.preventDefault();

        $.post($(this).data('posturl'), $(this).serialize(), function (data) {
          
            $('#container').html(data);
        });
    });

});