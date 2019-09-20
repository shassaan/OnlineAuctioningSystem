$(document).ready((e) => {
    $('#signupbtn').click(function(e){
        e.preventDefault();
        $('#signupbtn').attr('disabled', true);
        $.notify("Signing up...", "success");
        let data = $('form').serialize();
        //console.log(data);
        $.ajax({
            method: "POST",
            url: `/User/Signup`,
            data: JSON.stringify(data),
            success: (response) => {
                if (response === "success") {
                    window.location.reload();
                }
            }
        });
    });
});