
    function initTable(results) {
        table = $('#applicationTable').DataTable({
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
                        return `<a class="btn btn-primary" role="button" href="ApplicationDetails?applicationId=${data}">Detale</a>`;
                    }
                }
            ],
            columnDefs: [
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
