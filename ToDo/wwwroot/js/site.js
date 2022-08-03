// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//heres the fuction of delete action which is used via java script 
function deleteTodo(i) {
    $.ajax({
        url: 'Home/Delete',
        type: 'POST',
        data: {
            id: i
        },
        success: function () {
            window.location.reload();
        }
    });
}

//function populateForm(i) {

//    $.ajax({
//        url: 'Home/PopulateForm',
//        type: 'GET',
//        data: {
//            id: i
//        },
//        dataType: 'json',
//        success: function (response) {
//            $("#Todo_Name").val(response.name);
//            $("#Todo_Id").val(response.id);
//            $("#form-button").val("Update Todo");
//            $("#form-action").attr("action", "/Home/Update");
//        }
//    });
//}

//heres the fuction of Todo is Complete or not action which is used via java script
function completeTodo(i) {
    $.ajax({
        url: 'Home/completeTodo',
        type: 'POST',
        data: {
            id: i
        },
        success: function () {
            window.location.reload();
        }
    });
}

//function completeTodo(i) {

//    $.ajax({
//        url: 'Home/completeTodo',
//        type: 'GET',
//        data: {
//            id: i
//        },
//        dataType: 'json',
//        success: function (response) {
//            $("#Todo_Name").val(response.name);
//            $("#Todo_Id").val(response.id);
//            $("#form-action").attr("action", "/Home/Complete");
//        }
//    });
//}