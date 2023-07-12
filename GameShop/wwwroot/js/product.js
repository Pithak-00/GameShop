$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'title', "width": "15%" },
            { data: 'brand', "width": "15%" },
            { data: 'platform.name', "width": "10%" },
            { data: 'listPrice', "width": "10%" },
            { data: 'description', "width": "25%" }
        ]
    });
}