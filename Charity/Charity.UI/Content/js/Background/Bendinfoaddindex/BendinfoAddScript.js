var bendInfoAdd = bendInfoAdd || function () { };

bendInfoAdd.addbendInfoAdd = function () {

    var formdata = $('#BendInfoAddForm').serialize();
    //var formdataTare = $('#BendInfoAddForm ').serialize();
    $.ajax({
        type: "POST",
        url: "/BendInfo/AddBendInfoMSG",
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