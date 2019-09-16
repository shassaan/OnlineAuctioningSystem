$(document).ready(() => {
    $('.login').click(() => {
        $('#loader').show();
        $('#mymodal').modal('show');
        $.ajax({
            method: "GET",
            url: `/User/Index?formType=login&userType='customer'`,
            success: (htmlForm) => {
                $('#exampleModalLongTitle').html("Login Here");
                $('.modal-body').html(htmlForm);
            }
        })
    });

    $('.register').click(() => {
        $('#loader').show();
        $('#mymodal').modal('show');
        $.ajax({
            method: "GET",
            url: `/User/Index?formType=register&userType='customer'`,
            success: (htmlForm) => {
                $('#exampleModalLongTitle').html("Signup Here");

                $('.modal-body').html(htmlForm);
            }
        })
    });

    

});