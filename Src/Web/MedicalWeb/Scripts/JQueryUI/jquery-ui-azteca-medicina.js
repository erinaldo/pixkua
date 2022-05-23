UI.Controls.Medicina = {}

UI.Controls.Medicina.PacienteSelector = function (element) {
    var ListColumns = [
                        { headerText: "ID", visible: false, dataKey: "ID" },
                        { headerText: "IdPaciente", visible: false, dataKey: "IdPaciente" },
                        { visible: false, dataKey: "Calle" },
                        { visible: false, dataKey: "NumExt" },
                        { visible: false, dataKey: "Colonia" },
                        { visible: false, dataKey: "CP" },
                        { visible: false, dataKey: "Poblacion" },
                        { headerText: "Codigo", width: 80, dataKey: "Codigo", dataType: "string", filterOperator: "BeginsWith" },
                        { headerText: "Nombre", width: 200, dataKey: "Nombre", dataType: "string", filterOperator: "BeginsWith" },
                        { headerText: "Sexo", width: 60, dataKey: "Sexo", dataType: "string", filterOperator: "BeginsWith" },
                        { headerText: "Ultima Consulta", width: 100, dataKey: "UltimaConsulta", dataType: "string", filterOperator: "BeginsWith" },
                        { headerText: "Estatus", width: 90, dataKey: "Estatus", dataType: "string", filterOperator: "BeginsWith" }
                    ];

    element.catalogselector({
        listColumns: ListColumns,
        catalogService: new Business.Medicina.PacienteService(),
        dialogTitle: "Catálogo de Pacientes",
        width: 350,
        displayMember: function (item) {
            if (item.Cliente != undefined)
                return item.Cliente.Nombre;
            else
                return item.Nombre;
        }
    });
}

UI.Controls.Medicina.DoctorSelector = function (element) {
    var ListColumns = [
                        { headerText: "ID", visible: false, dataKey: "ID" },
                        { headerText: "Codigo", width: 80, dataKey: "Codigo", dataType: "string", filterOperator: "BeginsWith" },
                        { headerText: "Nombre", width: 200, dataKey: "Nombre", dataType: "string", filterOperator: "BeginsWith" },
                        { headerText: "Estatus", width: 90, dataKey: "Estatus", dataType: "string", filterOperator: "BeginsWith" }
                    ];

    element.catalogselector({
        listColumns: ListColumns,
        catalogService: new Business.Medicina.DoctorService(),
        dialogTitle: "Catálogo de Doctores",
        width: 350,
        displayMember: function (item) {
            return item.Nombre;
        }
    });
}