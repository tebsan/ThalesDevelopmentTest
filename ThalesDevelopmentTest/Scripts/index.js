$(document).ready(function () {
    $("#getDataBtn").on("click", function () {
        var employeeId = $("#employeeId").val().trim();
        var apiUrl = employeeId ? "https://localhost:7245/api/Employee/" + employeeId : "https://localhost:7245/api/Employee";

        $.ajax({
            url: apiUrl,
            method: "GET",
            dataType: "json",
            success: function (data) {
                if (data && data.length > 0) {
                    showDataTable(data);
                } else {
                    hideDataTable();
                }
            },
            error: function (error) {
                alert("Error occurred while fetching data from the API.");
                hideDataTable();
            }
        });
    });

    function showDataTable(data) {
        var tableData = "";
        data.forEach(function (employee) {
            tableData += "<tr>" +
                "<td>" + employee.id + "</td>" +
                "<td>" + employee.employee_name + "</td>" +
                "<td>" + employee.employee_age + "</td>" +
                "<td>" + employee.employee_salary + "</td>" +
                "<td>" + employee.employee_annual_salary + "</td>" +
                "</tr>";
        });
        $("#dataTable tbody").html(tableData);
        $("#dataTable").show();
    }

    function hideDataTable() {
        $("#dataTable tbody").empty();
        $("#dataTable").hide();
    }

    $("#employeeId").on("input", function () {
        this.value = this.value.replace(/[^0-9]/g, "");
    });
});