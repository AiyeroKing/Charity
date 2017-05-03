var user = user || function () { };

user.addUser = function () {

    var formdata = $('#UserRegisterForm input').serialize();
    $.ajax({
        type: "POST",
        url: "/User/AddUserMSG",
        data: formdata,// 你的formid
        async: false,
        error: function (request) {
            alert("Connection error");
        },
        success: function (data) {
            alert("Connection 成功");
        }
    });
};