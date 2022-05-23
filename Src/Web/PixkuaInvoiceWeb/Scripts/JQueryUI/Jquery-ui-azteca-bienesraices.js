/*****************************************************************************/
/********************** CONTROLES DE BIENES RAICES **********************************/
  UI.Controls.BienesRaices = {}

  UI.Controls.BienesRaices.PropietariosSelector = function (element) {
    var ListColumns = [
                        { headerText: "ID", visible: false, dataKey: "ID" },
                        { headerText: "Codigo", width: 80, dataKey: "Codigo", dataType: "string", filterOperator: "BeginsWith" },
                        { headerText: "Nombre", width: 200, dataKey: "Nombre", dataType: "string", filterOperator: "BeginsWith" },
                        { headerText: "Estatus", width: 90, dataKey: "Estatus", dataType: "string", filterOperator: "BeginsWith" }
                    ];

    element.catalogselector({
        listColumns: ListColumns,
        catalogService: new Business.BienesRaices.PropietarioService(),
        dialogTitle: "Catálogo de Propietarios",
        width: 350,
        displayMember: function (item) {
                 return item.Nombre ;            
        }
    });
}
