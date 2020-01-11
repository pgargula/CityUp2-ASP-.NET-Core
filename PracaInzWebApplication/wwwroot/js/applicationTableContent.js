var table;
    function initTable(results) {
        table = $('#applicationTable').DataTable({
            destroy: true,
            data: results,
            autoWidth: true,
            columns: [
                {
                    data: 'title'
                },
                {
                    data: 'category.name'
                },
                {
                    data: 'adress.street'
                },
                {
                    data: 'applicationPictures.0.picturePath',
                    render: function (data) {
                        return '<img style="width: 150px; height: 150px"  src="' + data + '"/>';
                    }
                },
                {
                    data: "applicationId",
                    render: function (data) {
                        return `<a class="btn btn-outline-secondary" role="button" href="/Application/ApplicationDetails?applicationId=${data}">Detale  <i class="fas fa-info-circle"></i></a>`;
                    }
                },
                {
                    data: "adress.city.name"
                }

            ],
            columnDefs: [
                {
                    targets: [5],
                    visible: false
                },
                {
                    targets: [4],
                    className: 'dt-body-center action-column',
                    width: "130px",
                    orderable: false,
                    searchable: false
                },
                {
                    targets: [3],
                    orderable: false,
                    searchable: false
                },
                {
                    targets: [0],
                    width: "250px"
                }
            ]
        });
        
}

