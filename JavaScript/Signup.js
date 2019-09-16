$(document).ready((e) => {
    $('#signupbtn').click(function(e){
        e.preventDefault();
        $('#signupbtn').html("signing in....");
        $('#signupbtn').attr('disabled',true);
        let data = $('form').serialize();
        //console.log(data);
        $.ajax({
            method: "POST",
            url: `/User/Signup`,
            data: JSON.stringify(data),
            success: (response) => {
                console.log(response);
            }
        });
    });
});