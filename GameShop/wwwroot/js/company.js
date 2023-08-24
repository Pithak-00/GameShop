$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
	dataTable = $('#tblData').DataTable({
		"ajax": { url: '/admin/company/getall' },
		"columns": [
			{ "data": "name", "width": "15%" },
			{ "data": "phoneNumber", "width": "15%" },
			{ "data": "postalCode", "width": "15%" },
			{ "data": "state", "width": "15%" },
			{ "data": "city", "width": "15%" },
			{ "data": "streetAddress", "width": "15%" },
			{
				data: 'id',
				"render": function (data) {
					return `<div class="w-75 btn-group" role="group">
					<a herf = "/admin/company/upsert?id=${data}" class="btn btn-primary mx-2" ><i class="bi bi-pencil-square" > </i> Edit </a>
					<a onClick=Delete('/admin/company/delete/${data}' class="btn btn-danger mx-2" ><i class="bi bi-trash-fill" > </i> Delete </a>
					</div>`
				},
				"width": "15%"
			}
		]
	});
}