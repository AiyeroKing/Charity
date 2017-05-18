$(function () {
    $(":button").click(function () {
        if ($("#file1").val().length > 0) {
            ajaxFileUpload();
        }
        else {
            alert("请选择图片");
        }
    })
})
function ajaxFileUpload() {
    var ApplyArea = document.getElementById("ApplyArea").value;  
    var ApplyName = document.getElementById("ApplyName").value;  
    var ApplyPhone = document.getElementById("ApplyPhone").value;  
    var ApplyValue = document.getElementById("ApplyValue").value;  
    var ApplyInfo = document.getElementById("ApplyInfo").value;  
    $.ajaxFileUpload
        (
        {
            url: '/Home/AddPovertyMSG', //用于文件上传的服务器端请求地址
            type: 'post',
            data: {
                ApplyArea: ApplyArea,
                ApplyName: ApplyName,
                ApplyPhone: ApplyPhone,
                ApplyValue: ApplyValue,
                ApplyInfo: ApplyInfo
            }, //此参数非常严谨，写错一个引号都不行
            secureuri: false, //一般设置为false
            fileElementId: 'file1', //文件上传空间的id属性  <input type="file" id="file" name="file" />
            dataType: 'json', //返回值类型 一般设置为json
            success: function (data, status)  //服务器成功响应处理函数
            {
                $("#img1").attr("src", data.imgPath1);
                if (typeof (data.error) != 'undefined') {
                    if (data.error != '') {
                    } else {

                    }
                }
            },
            error: function (data, status, e)//服务器响应失败处理函数
            {
                alert(e);
            }
        }
        )
    return false;
}