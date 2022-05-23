/// <reference path="http://localhost:52859/Onili/Scripts/JQuery/jquery-1.7.2-vsdoc.js" />

/*****************************************************************************/
/********************** INICIALIZACIÓN GENERAL *******************************/
/*****************************************************************************/

$(document).ready(function () {
    $(document).ajaxStart(function () {
        $('body').addClass("loading");
    });

    $(document).ajaxStop(function () {
        $('body').removeClass("loading");
    });

});

/*****************************************************************************/
/********************** CONTROL BINDINGS **********************************/
ko.bindingHandlers.selectorValue = {
    init: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
        $(element).bind('catalogselectoritemloaded', function (e, data) {
            var value = valueAccessor();
            var Identity = 0;
            if (data.Identity != undefined)
                Identity = data.Identity;
            if (data.ID != undefined)
                Identity = data.ID;
            value(Identity);
        });
        $(element).bind('catalogselectorcleared', function (e) {
            var value = valueAccessor();
            value(0);
        });
    },
    update: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
        var value = valueAccessor();
        var Identity = ko.utils.unwrapObservable(value);
        //Obtener valor del selector para determinar si es diferente al view model
        var selectorValue = $(element).catalogselector("value");
        if (Identity != selectorValue) {
            if (Identity > 0)
                $(element).catalogselector("load", Identity);
            else
                $(element).catalogselector("clear");
        }
    }
};

ko.bindingHandlers.buttonEnabled = {
    update: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
        var value = valueAccessor(), bindings = allBindingsAccessor();
        var enable = ko.utils.unwrapObservable(value);
        if (bindings.index != undefined) {
            var buttonIndex = bindings.index;
            if (enable)
                $(element).toolbar('enableButton', buttonIndex);
            else
                $(element).toolbar('disableButton', buttonIndex);
        }
        else {
            var buttons = bindings.indexes;
            for (var i = 0; i < buttons.length; i++) {
                if (enable)
                    $(element).toolbar('enableButton', buttons[i]);
                else
                    $(element).toolbar('disableButton', buttons[i]);
            }
        }
    }
}

/*****************************************************************************/
/********************** VALIDACIÓN DE CONTROLES **********************************/

jQuery.validator.setDefaults({ignore:''});
//Agregar método para validar selectors
jQuery.validator.addMethod(
    "validSelection",
    function (value, element) {
        var valor = $(element).parent().parent().parent().catalogselector('value');
        return (valor > 0);
    },
    "Por favor seleccione una opción válida"
);


/*****************************************************************************/
/********************** CONTROLES DE KERNEL **********************************/
Kernel.Controls = {}

Kernel.Controls.PoblacionesSelector = function (element) {
    var ListColumns = [
                        { headerText: "ID", visible: false, dataKey: "ID" },
                        { headerText: "Codigo", width: 80, dataKey: "Codigo", dataType: "string", filterOperator: "BeginsWith" },
                        { headerText: "Pais", width: 80, dataKey: "Pais", dataType: "string", filterOperator: "BeginsWith" },
                        { headerText: "Nombre", width: 200, dataKey: "Nombre", dataType: "string", filterOperator: "BeginsWith" },
                        { headerText: "Estatus", width: 90, dataKey: "Estatus", dataType: "string", filterOperator: "BeginsWith" }
                    ];

    element.catalogselector({
        listColumns: ListColumns,
        catalogService: new Kernel.General.PoblacionService(),
        dialogTitle: "Catálogo de Poblaciones",
        width: 350,
        displayMember: function (item) {
            if (item.Estado != undefined)
                return item.Nombre + ', ' + item.Estado;
            else
                return item.Nombre + ', ' + item.Municipio.Estado.Nombre;
        }
    });
}

/*****************************************************************************/
/********************** DIALOGOS DE KERNEL **********************************/
Kernel.Dialogs = {}

Kernel.Dialogs.SucursalesList = function (element, multiSelect, selectionChangedCallback) {
    this.element = element;
    var self = this;

    var sucursalesColumns = [
                         { headerText: "Estado", dataKey: "Estado", visible: false, readOnly: true },
                         { headerText: "Activo", dataKey: "Activo", visible: false, readOnly: true },
                         { headerText: "Domicilio", dataKey: "Domicilio", visible: false, readOnly: true },                         
                         { headerText: "Código", dataKey: "Codigo", dataType: "string", width: 80, filterOperator: "BeginsWith", readOnly: true },
                         { headerText: "Empresa", dataKey: "Empresa", dataType: "string", width: 200, filterOperator: "BeginsWith", readOnly: true },
                         { headerText: "Sucursal", dataKey: "Sucursal", dataType: "string", width: 150, filterOperator: "BeginsWith", readOnly: true },
                         { headerText: "Poblacion", dataKey: "Poblacion", dataType: "string", width: 150, filterOperator: "BeginsWith", readOnly: true },
                         { headerText: "Estatus", dataKey: "Estatus", dataType: "string", width: 80, filterOperator: "BeginsWith", readOnly: true }
                         ]

    element.cataloglist({
        catalogService: new Kernel.Security.SucursalService(),
        listColumns: sucursalesColumns,
        multiSelect: multiSelect,
        selectionChanged: selectionChangedCallback,
        width: 750
    });

    this.Show = function () {
        self.element.cataloglist('show');
    }

    this.GetSelection = function () {
        return self.element.cataloglist('value');
    }

}

Kernel.Dialogs.UsuariosList = function (element, multiSelect, selectionChangedCallback) {
    this.element = element;
    var self = this;

    var usuariosColumns = [
                         { headerText: "Activo", dataKey: "Activo", visible: false, readOnly: true },                         
                         { headerText: "Usuario", dataKey: "Usuario", dataType: "string", width: 80, filterOperator: "BeginsWith", readOnly: true },
                         { headerText: "Nombre", dataKey: "Nombre", dataType: "string", width: 200, filterOperator: "BeginsWith", readOnly: true },
                         { headerText: "Dominio", dataKey: "Dominio", dataType: "string", width: 150, filterOperator: "BeginsWith", readOnly: true },                         
                         { headerText: "Estatus", dataKey: "Estatus", dataType: "string", width: 80, filterOperator: "BeginsWith", readOnly: true }
                         ]

    element.cataloglist({
        catalogService: new Kernel.Security.UsuarioService(),
        listColumns: usuariosColumns,
        multiSelect: multiSelect,
        selectionChanged: selectionChangedCallback,
        width: 600
    });

    this.Show = function () {
        self.element.cataloglist('show');
    }

    this.GetSelection = function () {
        return self.element.cataloglist('value');
    }

}

/*****************************************************************************/
/********************** FUNCIONES PARA GRID **********************************/
Kernel.GridServices = {}
Kernel.GridServices.GetSorting = function (grid) {
    var SortOrder = [];
    var Columns = grid.wijgrid('columns');
    var ColumnCount = Columns.length;
    for (i = 0; i < ColumnCount; i++) {
        var column = Columns[i];
        if (column.options.sortDirection != "none" && column.options.allowSort == true) {
            var direction = "asc";
            if (column.options.sortDirection == "ascending")
                direction = "asc";
            else
                direction = "desc";

            var SortField = { Field: column.options.dataKey, Direction: direction };
            SortOrder.push(SortField);
        }
    }
    return SortOrder;
}

Kernel.GridServices.GetOperator = function (filterOperator) {
    switch (filterOperator.toLowerCase()) {
        case "nofilter":
            return "";
        case "contains":
            return "like";
        case "notcontains":
            return "like";
        case "beginswith":
            return "like";
        case "endswith":
            return "like";
        case "equals":
            return "=";
        case "notequal":
            return "<>";
        case "greater":
            return ">";
        case "less":
            return "<";
        case "greaterorequal":
            return ">=";
        case "lessorequal":
            return "<=";
        default:
            return "=";

    }
}

Kernel.GridServices.GetFilter = function (grid) {
    var Filters = [];
    var Columns = grid.wijgrid('columns');
    var ColumnCount = Columns.length;
    for (i = 0; i < ColumnCount; i++) {
        var column = Columns[i];
        if (column.options.showFilter == true && column.options.filterValue != undefined && column.options.filterOperator.toLowerCase() != "nofilter") {
            var Filter = { Field: column.options.dataKey, Operator: this.GetOperator(column.options.filterOperator), Value: column.options.filterValue, ValueType: 'string' };
            Filters.push(Filter);            
        }
    }
    return Filters;
}

Kernel.GridServices.LocalizedFilterOperators =
    [{ name: "nofilter", displayName: "Quitar Filtro" },
    { name: "contains", displayName: "Contiene" },
    { name: "beginswith", displayName: "Inicie Con" },
    { name: "endswith", displayName: "Termine Con" },
    { name: "equals", displayName: "Igual a" },
    { name: "notequal", displayName: "Diferente de" },
    { name: "greater", displayName: "Mayor que" },
    { name: "less", displayName: "Menor que" },
    { name: "greaterorequal", displayName: "Mayor o Igual" },
    { name: "lessorequal", displayName: "Menor o Igual" },
    { name: "isempty", displayName: "Vacio" },
    { name: "notisempty", displayName: "No Vacio" },
    { name: "isnull", displayName: "Es nulo" },
    { name: "notisnull", displayName: "No es Nulo"}];


Kernel.Forms = {}

/*****************************************************************************/
/********************** FORMA DE CATALOGO ***********************************/
/*****************************************************************************/

Kernel.Forms.CatalogForm = function (options) {
    var thisForm = this;

    this.Service = null;
    this.Validator = null;
    this.MainDiv = null;
    this.CatalogList = null;
    this.EditForm = null;
    this.ListToolBar = null;
    this.EditToolBar = null;
    this.EditErrors = null;
    this.ListErrors = null;
    this._MsgBox = null;
    this.Estatus = null;
    this.DialogOnly = false;
    this.DialogID = 0;
    this.LoadingInfo = function (info) { };
    this.SavingInfo = function (info) { };
    this.InfoSaved = function (info) { };
    this.AddingItem = function (info) { };
    this.MsgBox = function (options) { };

    this.ViewModel = options.ViewModel;
    this._ValidatorOptions = options.ValidatorOptions;
    this.MainDiv = options.MainDiv;
    this.EditForm = options.EditForm;
    this.EditToolBar = options.EditToolBar;
    this.LoadingInfo = options.LoadingInfo;
    this.SavingInfo = options.SavingInfo;
    this.AddingItem = options.AddingItem;
    this.CloseOnSave = options.CloseOnSave;
    this.DialogWidth = 700;
    this.DialogHeight = 500;
    if (options.DialogWidth != undefined) this.DialogWidth = options.DialogWidth;
    if (options.DialogHeight != undefined) this.DialogHeight = options.DialogHeight;
    if (options.DialogOnly != undefined) {
        this.DialogOnly = options.DialogOnly;
        this.DialogID = options.DialogID;
        this.DialogTag = options.DialogTag;
    }

    //    
    var currentListRow;
    //Crear elementos basicos del formulario
    if (this.DialogOnly == false) {
        this.ListToolBar = this.MainDiv.prepend('<div id="ListToolBar"></div>');
        this.CatalogList = $('<table id="tblCatalogList"></table>').insertAfter(this.ListToolBar);
    }
    this._MsgBox = $('<div id="msgbox"></div>').appendTo(this.MainDiv);
    this.EditToolBar = $('<div id="tlbEdit"></div>').prependTo(this.EditForm);
    this._ValidationMessage = $('<div>Mensaje</div>').insertAfter(this.EditToolBar);
    this._ValidationMessage.hide();
    //Crear menú contextual para los elementos en el grid
    if (this.DialogOnly == false) {
        this.ContextMenuContainer = $('<div id="ContextMenuContainer"></div>').insertAfter(this.CatalogList);
        this.ContextMenu = $('<ul id="ItemMenu"></ul>').appendTo(this.ContextMenuContainer);
        this.ContextMenu.append('<li id="mnuEdit"><a href="#"><span class="ui-icon ui-icon-pencil"></span>Modificar</a></li>');
        this.ContextMenu.append('<li id="mnuDelete"><a href="#"><span class="ui-icon ui-icon-trash"></span>Eliminar</a></li>');
        this.ContextMenu.append('<li id="mnuChangeStatus"><a href="#">Desactivar</a></li>');
    }
    //Insertar elementos para mostrar indicador de carga
    this.MainDiv.append('<div class="modal"></div>');
    this.EditForm.append('<div class="modal"></div>');

    //Crear validador del formulario
    this.Validator = $('#form1').validate({
        rules: thisForm._ValidatorOptions.rules,
        messages: thisForm._ValidatorOptions.messages,
        ignore: '',
        errorClass: "ui-state-error",
        errorElement: "div",
        errorPlacement: function (error, element) {
            error.css('font-size', '10px');
            element.parent().append(error);
        }
    });

    //Crear instancia de Servicios para catálogos
    this.Service = new CatalogService({
        WebService: thisForm.ViewModel.CatalogService.WebService,
        CreateCallback: function (result) {
            thisForm.Validator.resetForm();
            thisForm.ViewModel.CatalogInfo.MapFields(result);
            $('.ui-state-error').removeClass('ui-state-error');
            thisForm.AddingItem(thisForm.ViewModel, result);
            if (thisForm.DialogOnly == false) $('#EditForm').dialog("open");
            $('.TextField:first').focus();
        },
        SearchCallback: function (result) {
            thisForm.CatalogList.wijgrid({ data: result.Rows, totalRows: result.TotalRows });
        },
        GetDetailCallback: function (result) {
            thisForm.Validator.resetForm();
            thisForm.ViewModel.CatalogInfo.MapFields(result);
            $('.ui-state-error').removeClass('ui-state-error');
            thisForm.LoadingInfo(thisForm.ViewModel, result);
            if (thisForm.DialogOnly == false) thisForm.EditForm.dialog("open");
            $('.TextField:first').focus();
        },
        UpdateCallback: function (result) {
            thisForm.ViewModel.CatalogInfo.MapFields(result);
            if (thisForm.CloseOnSave == undefined)
                thisForm.CloseOnSave = true;
            //Checar si se debe cerrar automaticamente la pantalla de edición o se debe preguntar al usuario            
            if (thisForm.CloseOnSave == true) {
                if (thisForm.DialogOnly == false) {
                    $('#EditForm').dialog("close");
                    thisForm.RefreshList();
                }
                else {
                    window.parent.CloseDialog(thisForm.DialogTag);
                }
            }
            else {
                thisForm.MsgBox({ title: "Confirmar Acción", message: "La ha información ha sido actualizada correctamente.\n ¿Desea cerrar la pantalla de edición?", icon: 'question', okButton: true, cancelButton: true,
                    dialogResult: function (e, data) {
                        if (data.resp == "Aceptar") {
                            $('#EditForm').dialog("close");
                            thisForm.RefreshList();
                        }
                    }
                });
            }
        },
        ChangeStatusCallback: function () {
            thisForm.RefreshList();
        },
        DeleteCallback: function () {
            thisForm.RefreshList();
        },
        ErrorCallback: function (e, source) {
            thisForm.MsgBox({ title: "Error", message: e.message, icon: "error", okButton: true });
        }
    });

    //Crear objeto y función para mensajes
    this._MsgBox.msgbox();
    this.MsgBox = function (options) {
        this._MsgBox.msgbox("show", options);
    }

    //Crear menú contextual
    if (this.DialogOnly == false) {
        this.ContextMenu.menu({
            select: function (e, ui) {
                thisForm.ContextMenuContainer.wijpopup('hide');
                switch (ui.item[0].id) {
                    case 'mnuEdit':
                        thisForm.Service.GetDetailByID(currentListRow.ID, false);
                        break;
                    case 'mnuDelete':
                        thisForm.MsgBox({ title: "Confirmar Acción", message: "¿Está seguro que desea eliminar éste elemento?", okButton: true, cancelButton: true, icon: "question",
                            dialogResult: function (e, data) {
                                if (data.resp == "Aceptar")
                                    thisForm.Service.Delete(currentListRow.ID);
                            }
                        });
                        break;
                    case 'mnuChangeStatus':
                        if (currentListRow.Activo == true)
                            thisForm.Service.ChangeStatus(currentListRow.ID, false);
                        else
                            thisForm.Service.ChangeStatus(currentListRow.ID, true);
                        break;
                }
            }
        });

        this.ContextMenuContainer.wijpopup({ autoHide: true, showEffect: 'blind' });
    }



    //Crear toolbar principal sobre la lista de elementos
    if (this.DialogOnly == false) {
        this.ListToolBar.toolbar({
            buttonHeight: 32, buttonWidth: 32,
            buttons:
                [{ text: "Nuevo", key: "btnNuevo", image: "General/AddItem_64.png"}],
            buttonClick: function (e, data) {
                if (data.key == "btnNuevo") {
                    thisForm.Service.Create();
                }
            }
        });
    }

    //Crear toolbar de la pantalla de edición
    this.EditToolBar.toolbar({
        buttonHeight: 32, buttonWidth: 32,
        buttons: [
                { text: "", tooltip: "Guardar Cambios", key: "btnGuardar", image: "General/Save_64.png" }
                ],
        buttonClick: function (e, data) {
            if (data.key == "btnGuardar") {
                if ($('#form1').valid()) {
                    thisForm.SavingInfo(thisForm.ViewModel);
                    var catalogInfo = ko.toJS(thisForm.ViewModel.CatalogInfo);
                    thisForm.Service.Update(catalogInfo);
                    thisForm._ValidationMessage.hide();
                }
                else {
                    thisForm._ValidationMessage.text("* Existe(n) " + thisForm.Validator.numberOfInvalids() + " campo(s) que requiere(n) información o tienen información incorrecta.");
                    thisForm._ValidationMessage.addClass('ui-state-error')
                    thisForm._ValidationMessage.show();
                }
            }
        }
    });

    if (this.DialogOnly == false) {
        this.EditForm.dialog({
            autoOpen: false,
            modal: true,
            width: thisForm.DialogWidth,
            height: thisForm.DialogHeight,
            show: "blind",
            title: "Edición de elemento",
            appendTo: "#form1"
        });
    }

    if (this.DialogOnly == false) {
        //Agregar columna de edición
        options.ListColumns.unshift(
                { headerText: "", width: 30, showFilter: false,
                    cellFormatter: function (args) {
                        if (args.row.type & $.wijmo.wijgrid.rowType.data) {
                            args.$container.attr('align', 'center');
                            args.$container.empty().append(
                            $("<a href='#'><img src='" + App.ImagePath + "/General/EditItem_16.png' alt='' class=''/></a>")
                                .click(function (e) {
                                    currentListRow = args.row.data;
                                    if (currentListRow.Activo == true)
                                        $('#mnuChangeStatus a').text('Desactivar');
                                    else
                                        $('#mnuChangeStatus a').text('Activar');
                                    thisForm.ContextMenuContainer.wijpopup("showAt", e.pageX, e.pageY);
                                    return false;
                                })
                            );
                            return true;
                        }
                    }
                },
                { headerText: "Active", visible: false, dataKey: "Activo" }
            );

        //Crear grid para el listado de los elementos del catálogo
        this.CatalogList.wijgrid({
            ensureColumnsPxWidth: true, culture: "es", allowPaging: true, pageSize: App.PageSize, allowSorting: true, showFilter: true,
            columns: options.ListColumns, filterOperatorsSortMode: "alphabeticalCustomFirst",
            pageIndexChanging: function (e, args) {
                var SortOrder = Kernel.GridServices.GetSorting(thisForm.CatalogList);
                var Conditions = Kernel.GridServices.GetFilter(thisForm.CatalogList);
                thisForm.Service.Search(App.DefaultBranch.Identity, Conditions, SortOrder, args.newPageIndex + 1);
            },
            pageIndexChanged: function (e) {
                thisForm.CatalogList.wijgrid('ensureControl', true);
            },
            sorted: function (e, args) {
                thisForm.RefreshList();
            },
            filtered: function (e, args) {
                var SortOrder = Kernel.GridServices.GetSorting(thisForm.CatalogList);
                var Conditions = Kernel.GridServices.GetFilter(thisForm.CatalogList);
                var filter = $('.wijmo-wijgrid-filterlist', thisForm.CatalogList);
                thisForm.CatalogList.wijgrid({ pageIndex: 0 });
                thisForm.Service.Search(App.DefaultBranch.Identity, Conditions, SortOrder, 1);
                thisForm.CatalogList.wijgrid('ensureControl', true);
            },
            loaded: function () {
                $('.wijmo-wijgrid-filter-input', thisForm.CatalogList).bind("keypress", function (e, args) {
                    if (e.keyCode == 13) {
                        //Obtener las columnas que tienen habilitado el filtro
                        var columnFilters = $('.wijmo-wijgrid-filter-input', thisForm.CatalogList);
                        //Obtener las columnas visibles del grid                                                        
                        var columns = thisForm.CatalogList.wijgrid('columns');
                        //Obtener el numero de columna que se está filtrando (de la colección de colmnas con filtro)
                        var colFilterIndex = columnFilters.index($(this));
                        //Obtener la columna (widget) visible que se está filtrando (de la colección de columnas visibles del grid)
                        //Sumando al indice de la columna con filtro, la diferencia entre columnas visibles y con filtro
                        var column = columns[colFilterIndex + (columns.length - columnFilters.length)];
                        //var GridColumns = thisForm.CatalogList.data("wijgrid").columns();
                        //Obtener valor del filtro
                        var filterValue = $('.wijmo-wijgrid-filter-input', thisForm.CatalogList).eq(colFilterIndex).val();
                        //Establecerlo en la columna (widget)
                        column.option('filterValue', filterValue);
                        var SortOrder = Kernel.GridServices.GetSorting(thisForm.CatalogList);
                        var Conditions = Kernel.GridServices.GetFilter(thisForm.CatalogList);
                        thisForm.CatalogList.wijgrid({ pageIndex: 0 });
                        thisForm.Service.Search(App.DefaultBranch.Identity, Conditions, SortOrder, 1);
                        thisForm.CatalogList.wijgrid('ensureControl', true);
                    }
                });
            }
        });

        //Llenar con la lista completa de elementos            
        this.Service.Search(App.DefaultBranch.Identity, null, null, 1);

        //Personalizar los operadores de filtro del grid
        thisForm.CatalogList.wijgrid().data().wijmoWijgrid._localizeFilterOperators(Kernel.GridServices.LocalizedFilterOperators);
    }


    ////////////// METODOS /////////////////////
    this.RefreshList = function () {
        var SortOrder = Kernel.GridServices.GetSorting(this.CatalogList);
        var Conditions = Kernel.GridServices.GetFilter(this.CatalogList);
        //Obtener la página actual para volver a obtener la misma página
        var CurrentPage = this.CatalogList.wijgrid("option", "pageIndex")
        this.Service.Search(App.DefaultBranch.Identity, Conditions, SortOrder, CurrentPage + 1);
        this.CatalogList.wijgrid('ensureControl', true);
    }

    ///// SI ESTÁ EN MODO EDICIÓN, CREAR O CARGAR ELEMENTO////
    if (this.DialogOnly == true) {
        if (this.DialogID == 0) {
            thisForm.Service.Create();
        }
        else {
            thisForm.Service.GetDetailByID(this.DialogID, false);
        }
    }
}


/*****************************************************************************/
/********************** FORMA DE JERARQUÍAS ***********************************/
/*****************************************************************************/

Kernel.Forms.HierarchyForm = function (options) {
    var self = this;

    this.Service = null;
    this.Validator = null;            
    this.EditErrors = null;    
    this._MsgBox = null;
    this.Estatus = null;
    this.LoadingInfo = function (info) { };
    this.SavingInfo = function (info) { };
    this.InfoSaved = function (info) { };
    this.AddingItem = function (info) { };
    this.MsgBox = function (options) { };

    this.MainDiv = options.MainDiv;
    this.ViewModel = options.ViewModel;
    this._ValidatorOptions = options.ValidatorOptions;
            
    this.LoadingInfo = options.LoadingInfo;
    this.SavingInfo = options.SavingInfo;
    this.AddingItem = options.AddingItem;
    this.CloseOnSave = options.CloseOnSave;
    this.DialogWidth = 700;
    this.DialogHeight = 500;
    if (options.DialogWidth != undefined) this.DialogWidth = options.DialogWidth;
    if (options.DialogHeight != undefined) this.DialogHeight = options.DialogHeight;

    //Definir metodos del view model
    this.ViewModel.LoadChildren = function (idParent, selectedID) {
        self.HierarchyService.LoadChildren(App.DefaultCompany.Identity, idParent)
                        .done(function (data) {
                            var ParentNode = null;
                            //Encontrar el nodo del que se cargarán sus hijos, si el padre es 0, entonces son nodos raíz
                            if (idParent > 0) {
                                ParentNode = self.FindNode(idParent);
                                ParentNode.nodes = [];
                            }
                            //Agregar nodos hijo al nodo padre o a la raíz según sea el caso
                            var Children = $.parseJSON(data);
                            $.each(Children, function (index, child) {
                                if (idParent > 0)
                                    ParentNode.nodes.push({ identity: child.Identity, idParent: child.IdPadre, text: child.Nombre, orden: child.Orden, nivel: child.Nivel, loaded: false, nodes: [] });
                                else
                                    self.Nodes.push({ identity: child.Identity, idParent: child.IdPadre, text: child.Nombre, orden: child.Orden, nivel: child.Nivel, loaded: false, nodes: [] });
                            });
                            if (ParentNode != null) {
                                ParentNode.loaded = true;
                                ParentNode.expanded = true;
                            }
                            //Si se especificó que se debe seleccionar un elemento
                            if (selectedID != undefined) {
                                var childNode = self.FindNode(selectedID);
                                self.CurrentNode = childNode;
                                childNode.selected = true;
                                if (ParentNode != null) ParentNode.selected = false;
                            }

                            if (idParent > 0) self.Nodes.valueHasMutated();
                        })
                        .fail(function (e) {
                            var x = e;
                        });
    }


    this.ViewModel.CreateAndSave = function (idParent) {
        self.HierarchyService.CreateAndSave(idParent)
                        .done(function (data) {
                            var Info = $.parseJSON(data);
                            validator.resetForm();
                            self.HierarchyInfo.MapFields(Info);
                            $('.ui-state-error').removeClass('ui-state-error');
                            $('.TextField:first').focus();
                            if (idParent > 0)
                                self.LoadChildren(idParent, Info.Identity);
                            else {
                                self.Nodes.push({ identity: Info.Identity, idParent: Info.IdPadre, text: Info.Nombre, orden: Info.Orden, nivel: Info.Nivel, loaded: false, nodes: [], selected: true });
                                self.CurrentNode = self.FindNode(Info.Identity);
                            }
                        })
                        .fail(function (e) {
                        });
    }

    this.ViewModel.GetDetail = function (itemID) {
        self.HierarchyService.GetDetailByID(itemID, false)
                        .done(function (data) {
                            var Info = $.parseJSON(data);
                            self.CurrentNode = self.FindNode(Info.Identity);
                            self.HierarchyInfo.MapFields(Info);
                            if (!self.CurrentNode.loaded)
                                self.LoadChildren(itemID);
                        })
                        .fail(function (e) {
                        });
    }

    this.ViewModel.Update = function () {
        var Info = ko.toJS(self.HierarchyInfo);
        self.HierarchyService.Update(Info)
                            .done(function (data) {
                                var updatedInfo = $.parseJSON(data);
                                self.HierarchyInfo.MapFields(updatedInfo);
                                self.CurrentNode = self.FindNode(updatedInfo.Identity);
                                self.CurrentNode.text = updatedInfo.Nombre;
                                self.Nodes.valueHasMutated();
                            })
                            .fail(function (e) {
                                var x = e;
                            });
    }

    this.ViewModel.MoveNode = function (nodeId, idParent, position) {
        self.HierarchyService.MoveNode(nodeId, idParent, position + 1)
                        .done(function (data) {

                        })
                        .fail(function (e) {
                        });
    }

    this.ViewModel.RemoveNode = function (nodeId) {
        self.HierarchyService.Delete(nodeId)
                        .done(function (data) {
                            self.LoadChildren(0);
                            self.CurrentNode = null;
                        })
                        .fail(function (e) {
                        });
    }

    this.ViewModel.CurrentNode = null;

    this.ViewModel.FindNode = function (nodeId) {
        return _FindNode(nodeId, self.Nodes());
    }

    function _FindNode(nodeId, nodes) {
        for (var i = 0; i < nodes.length; i++) {
            if (nodes[i].identity == nodeId)
                return nodes[i];
            //Si el el nodo actual no es el que se estaba buscando, buscar en los nodos hijo
            if (nodes[i].nodes.length > 0) {
                var childNode = _FindNode(nodeId, nodes[i].nodes);
                if (childNode != null) return childNode;
            }
        }
        return null;
    }

    //Crear elementos basicos del formulario
    this.TreeMenu = this.MainDiv.prepend('<div id="tlbTreeMenu"></div>');
    this.EditMenu = $('<div id="tlbEdit"></div>').prependTo(this.EditForm);    
    this._MsgBox = $('<div id="msgbox"></div>').appendTo(this.MainDiv);

    this._ValidationMessage = $('<div>Mensaje</div>').insertAfter(this.EditMenu);
    this._ValidationMessage.hide();

    //Crear validador del formulario
    this.Validator = $('#form1').validate({
        rules: thisForm._ValidatorOptions.rules,
        messages: thisForm._ValidatorOptions.messages,
        ignore: '',
        errorClass: "ui-state-error",
        errorElement: "div",
        errorPlacement: function (error, element) {
            error.css('font-size', '10px');
            element.parent().append(error);
        }
    });

    //Crear objeto y función para mensajes
    this._MsgBox.msgbox();
    this.MsgBox = function (options) {
        this._MsgBox.msgbox("show", options);
    }

    this.TreeMenu.toolbar({
        buttonHeight: 32, buttonWidth: 32,
        buttons: [
                    { text: "", key: "btnAgregar", image: "General/AddItem_64.png", tooltip: "Agregar nodo" },
                    { text: "", key: "btnEliminar", image: "General/Cross_32.png", tooltip: "Eliminar el nodo seleccionado" }
                    ],
        buttonClick: function (e, data) {
            var selectedNodes = $('#tree').wijtree('getSelectedNodes');
            if (data.key == "btnAgregar") {
                var idParent = 0;
                //If there is a selected node, add node as child of this
                if (selectedNodes.length > 0) idParent = selectedNodes[0].options.identity;
                HierarchyViewModel.CreateAndSave(idParent);
            }
            if (data.key == "btnEliminar") {
                if (selectedNodes.length > 0) {
                    if (selectedNodes.length > 0) {
                        HierarchyViewModel.RemoveNode(selectedNodes[0].options.identity);
                    }
                }
            }
        }
    });

    $('#tree').wijtree({ allowDrag: true, allowDrop: true,
        nodeClick: function (e, data) {
            var identity = data.element.wijtreenode('option', 'identity');
            //Verificar si ya se cargaron los nodos hijo del nodo seleccionado
            if (HierarchyViewModel.HierarchyInfo.Identity() != identity) {
                HierarchyViewModel.GetDetail(identity);
            }
        },
        selectedNodeChanged: function (e, args) {
            if (event.ctrlKey == true) {
                args.element.wijtreenode({ selected: false });
            }
        },
        nodeDropped: function (e, args) {
            var nodeId = args.draggable.wijtreenode('option', 'identity');
            var draggedNode = HierarchyViewModel.FindNode(nodeId);
            var targetParent = draggedNode.idParent;
            //Checar si el nodo se está moviendo a otro node padre o a la raíz
            if (!args.targetParent.hasClass('wijmo-wijtree-parent'))
                targetParent = 0;
            HierarchyViewModel.MoveNode(nodeId, targetParent, args.tIndex);
        }
    });

}


UI = {}
UI.Controls = {}

