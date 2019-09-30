$(document).ready(function () {
    //GetEmployeeData();
    GetEmployeeClick();
   

});

function GetEmployeeClick() {
    $('#find').click(function () {
        var requestId = $("#search").val();
        if (requestId == null || requestId == '') {
            requestId = "0"
        }
            
        GetEmployeeDataById(requestId);
    });
}

function ClearData() {   
    $("#records_table > tbody").html("");

}
function GetEmployeeDataById(requestId) {
    
    $.ajax({
        type: "GET",
        url: "/api/Employee/" + requestId,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {            
            ClearData();          
           
            var trHTML = '';
            $.each(data, function (i, item) {
                trHTML += '<tr>' +
                    "<td id='Id'>" + item.id + "</td>" +
                    "<td id='Name'>" + item.name + "</td>" +
                    "<td id='ContractTypeName'>" + item.contractTypeName + "</td>" +
                    "<td id='roleId'>" + item.roleId + "</td>" +
                    "<td id='RoleName'>" + item.roleName + "</td>" +
                    "<td id='RoleDescription'>" + item.roleDescription + "</td>" +
                    "<td id='HourlySalary'>" + item.hourlySalary + "</td>" +
                    "<td id='monthlySalary'>" + item.monthlySalary + "</td>" +
                    "<td id='anualSalary'>" + item.anualSalary + "</td>" +
                    "</tr>";
            });

            $('#records_table > tbody').append(trHTML);            
        }, 

        failure: function (data) {
            alert(data.responseText);
        }, 
        error: function (data) {
            alert(data.responseText);
        } 

    });
}  

function GetEmployeeData() {

    $.ajax({
        type: "GET",
        url: "/api/Employee/",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
                  
            
            var trHTML = '';
            $.each(data, function (i, item) {
                trHTML += '<tr>' +
                    "<td id='Id'>" + item.id + "</td>" +
                    "<td id='Name'>" + item.name + "</td>" +
                    "<td id='ContractTypeName'>" + item.contractTypeName + "</td>" +
                    "<td id='roleId'>" + item.roleId + "</td>" +
                    "<td id='RoleName'>" + item.roleName + "</td>" +
                    "<td id='RoleDescription'>" + item.roleDescription + "</td>" +
                    "<td id='HourlySalary'>" + item.hourlySalary + "</td>" +
                    "<td id='monthlySalary'>" + item.monthlySalary + "</td>" +
                    "<td id='anualSalary'>" + item.anualSalary + "</td>" +
                    "</tr>";
            });

            $('#records_table > tbody').append(trHTML);
           
        }, 

        failure: function (data) {
            alert(data.responseText);
        }, 
        error: function (data) {
            alert(data.responseText);
        } 

    });
}  
