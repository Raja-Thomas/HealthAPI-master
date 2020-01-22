
// on load get the data from Api to jquery datatable

$(document).ready(function () {

    $("#demoGrid").DataTable({
        
        "pageLength": 50,

        ajax: {
            "url": "https://localhost:44397/api/patients",
            "type": "GET",
            "datatype": "json",
            "dataSrc": ''
        },

        columns: [
            { "data": "firstName" },
            { "data": "lastName" },
            { "data": "nickName" },
            {
                "render": function (data, type, row, meta) { return '<a id="' + row.id + '" onclick="Editclick(this)"> <img src="images/Editpng.png" style="cursor:pointer" height=20 width=20 ></a>'; }
            },
            {
                "render": function (data, type, row) {
                    return '<a id="' + row.id + '" onclick="Deleteclick(this)"><img src="images/Deleteicon.png" style="cursor:pointer" height=20 width=20 ></a>';
                }
            }

        ]

    });
});


// Call the partialview From Ajax for Post Method

$('#createmodelId').click(function () {
    $.ajax({
        type: "GET",
        url: '/Home/CreateorUpdate',
        cache: false,
        dataType: "html",
        success: function (responseText) {
            $('#editor-content-container').html(responseText);
            console.log(responseText);
            $('#editor-container').modal('show');
        }
    });
})

// Post the data to Api from Client Side 
function Add() {
    //$.validator.unobtrusive.parse('#frmClient');
    var validator = $('#frmClient').validate();
    if ($('#frmClient').valid()) {
        var empObj = {
            firstName:          $('#firstName').val(),
            lastName:           $('#lastName').val(),
            nickName:           $('#nickName').val(),
            Email:              $('#email').val(),
            city:               $('#city').val(),
            State:              $('#state').val(),
            country:            $('#country').val(),
            mobile:             $('#mobile').val(),
            password:           $('#password').val(),
            ConfirmPassword:    $('#confirmpassword').val(),
            Address:            $('#address').val()
        };
        $.ajax({
            url: "https://localhost:44397/api/patients/",
            data: JSON.stringify(empObj),
            type: "POST",
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (result) {
                $('#editor-container').modal('hide');
                $('#create-modal').modal('toggle');
            },
            error: function (errormessage) {
                console.log(errormessage);
            }
        });
    }
    else {
        validator.focusInvalid();
    }
}


// get the Empoyee details by Id from Api (PARTIAL VIEW)
function Editclick(obj) {
    var rowID = $(obj).attr('id');
    $.ajax({
        url: `https://localhost:44397/api/patients/ ${rowID}`,
        type: 'GET',
        success: function (response) {
            $.ajax({
                type: "GET",
                url: '/Home/CreateorUpdate',
                cache: false,
                data:response,
                dataType: "html",
                success: function (responseText) {
                    $('#editor-content-container').html(responseText);
                    console.log(responseText);
                    $('#editor-container').modal('show');
                }
            });
        },
    });
}

// update the Empoyee details by Id from Api 
function UpdateContact() {
    var validator =     $('#frmClient').validate();
    if ($('#frmClient').valid()) {
        var id =        $('#firstId').val();
        var empObj = {
            Id:                 $('#firstId').val(),
            firstName:          $('#firstName').val(),
            lastName:           $('#lastName').val(),
            nickName:           $('#nickName').val(),
            Email:              $('#email').val(),
            city:               $('#city').val(),
            State:              $('#state').val(),
            country:            $('#country').val(),
            mobile:             $('#mobile').val(),
            password:           $('#password').val(),
            ConfirmPassword:    $('#confirmpassword').val(),
            Address:            $('#address').val()
        };
        $.ajax({
            url: `https://localhost:44397/api/patients/${id}`,
            type: 'PUT',
            data: JSON.stringify(empObj),
            contentType: "application/json;charset=utf-8",
            success: function (data) {
                $('#editor-container').modal('hide');
                window.location.href = window.location;
            },
            error: function (data) {
                console.log(data);
                alert('Contact was not Added');
            }
        });
    }
    else { 
        validator.focusInvalid();
    }
}

// Delete Action Performed here
function Deleteclick(obj) {
    var rowID = $(obj).attr('id');
                $('#deleteId').val(rowID);
                $('#modal-delete-id').modal('show');
}

function Delete() {
    var data = $('#deleteId').val();
    $('#modal-delete-id').modal('hide')
    $.ajax({
        url: `https://localhost:44397/api/patients/${data}`,
        type: 'DELETE',
        success: function (response) {
            console.log(response);
            window.location.href = window.location;
        }
    });
}

// reinitialize unobtrusive validation
$(document).ajaxStop(function () {
    $.validator.unobtrusive.parse("#frmClient");
});

function reloadpage() {
    window.location.reload();
}