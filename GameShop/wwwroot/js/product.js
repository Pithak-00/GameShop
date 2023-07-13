$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
	dataTable = $('#tblData').DataTable({
		"ajax": { url: '/admin/product/getall' },
		"columns": [
			{ data: 'title', "width": "15%" },
			{ data: 'brand', "width": "10%" },
			{ data: 'platform.name', "width": "5%" },
			{ data: 'listPrice', "width": "5%" },
			{ data: 'description', "width": "40%" },
			{
				data: 'id',
				"render": function (data) {
					return '<div class="w-75 btn-group" role="group"><a herf = "/admin/product/upsert?id=${data}" class="btn btn-primary mx-2" ><i class="bi bi-pencil-square" > </i> Edit </a><a href="/admin/delete/${data}" class="btn btn-danger mx-2" ><i class="bi bi-trash-fill" > </i> Delete </a></div>'
				},
				"width": "15%"
			}
		]
	});
}