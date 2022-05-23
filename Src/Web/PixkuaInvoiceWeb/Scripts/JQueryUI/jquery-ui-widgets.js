
/// <reference path="http://localhost:52859/Onili/Scripts/JQuery/jquery-1.7.2-vsdoc.js" />

/*****************************************************************************/
/********************** TOOLBAR **********************************************/
/*****************************************************************************/

(function ($) {
    $.widget("ui.toolbar", {
        options: {
            buttons: [],
            buttonHeight: 64,
            buttonWidth: 64,
            fontSize: 10,
            _$Row: null
        },
        _create: function () {
            var thisWidget = this;
            //Fila única del toolbar
            this.options._$Row = $('<table width="100%"><tr></tr></table>');
            //Recorrer matriz de botones
            var buttonCount = this.options.buttons.length;
            for (i = 0; i < buttonCount; i++) {
                var Button = this.options.buttons[i];
                thisWidget._appendButton(Button);
            }
            this.options._$Row.append('<td></td>');
            this.element.append(this.options._$Row);
            this.element.addClass("ui-toolbar ui-widget ui-helper-reset ui-corner-all ui-state-default");
        },
        destroy: function () {
            $.Widget.prototype.destroy.call(this, arguments);
            this.element.removeClass("ui-toolbar ui-widget ui-helper-reset ui-corner-all ui-state-default");
            this.element.find(".ui-toolbar-button").unbind();
            this.element.children("tr").remove();
        },
        disable: function () {
            $.Widget.prototype.disable.call(this, arguments);
            this.element.find(".ui-toolbar-button").unbind();
        },
        enable: function () {
            $.Widget.prototype.enable.call(this, arguments);
            this.element.find(".ui-toolbar-button").bind("click", function (e) { this._buttonClick(e); });
        },
        disableButton: function (index) {
            var $Button = this.element.find('.ui-toolbar-button').eq(index);
            $Button.addClass('ui-state-disabled');
            var Button = $Button.data('button');
            Button.enabled = false;
        },
        enableButton: function (index) {
            var $Button = this.element.find('.ui-toolbar-button').eq(index);
            $Button.removeClass('ui-state-disabled');
            var Button = $Button.data('button');
            Button.enabled = true;
        },
        appendButton: function (button) {
            this.options.buttons.push(button);
            this._appendButton(button);
        },
        _buttonClick: function (e) {
            var clickedButton = $(e.currentTarget).data('button');
            if (clickedButton.enabled)
                this._trigger("buttonClick", e, { key: clickedButton.key });
        },
        _appendButton: function (button) {
            var thisWidget = this;
            if (button.enabled == undefined) button.enabled = true;
            if (button.tooltip == undefined) button.tooltip = "";
            if (button.text == undefined) button.text = "";
            if (button.separator == undefined) button.separator = false;
            //Agregar una celda por cada botón y dentro de éste un contenedor que represente el botón
            var $ButtonDiv = $('<td class="ui-toolbar-button ui-corner-all" style="width:' + this.options.buttonWidth + 'px; height:' + this.options.buttonHeight + 'px;"><div align="center"></div></td>');
            var $ButtonImage = $('<div align="center"><a href="#"><img src="' + App.ImagePath + '/' + button.image + '" width="' + this.options.buttonWidth + 'px" height="' + this.options.buttonHeight + 'px" alt="Nuevo" title="' + button.tooltip + '"/></a></div>');
            var $ButtonText = $('<div align="center"><a href="#" style="font-size:' + this.options.fontSize + 'px">' + button.text + '</a></div>');
            $ButtonDiv.append($ButtonImage);
            $ButtonDiv.append($ButtonText);
            $ButtonDiv.data('button', button);
            this.options._$Row.append($ButtonDiv);
            if (!button.enabled)
                $ButtonDiv.addClass('ui-state-disabled');
            if (button.separator)
                this.options._$Row.append('<td style="width:2px; background-color:#C0C0C0"></td>');
            //Agregar efecto para el botón con el mouse encima
            $ButtonDiv.hover(
                            function () {
                                var thisButton = $(this).data('button');
                                if (thisButton.enabled)
                                    $(this).addClass('ui-state-hover');
                            },
                            function () {
                                var thisButton = $(this).data('button');
                                if (thisButton.enabled)
                                    $(this).removeClass('ui-state-hover');
                            });

            //Agregar manejo para el click, lanzar evento con información del botón que se presionó
            $ButtonDiv.bind("click", function (e) { thisWidget._buttonClick(e); });
        }
    });
})(jQuery);

/*****************************************************************************/
/********************** ERROR SUMMARY ****************************************/
/*****************************************************************************/

(function ($) {
    $.widget("ui.errorsummary", {
        options: {
            errorTitle: "Se generaron los siguientes errores:",
            errors: [],
            $ErrorList: null
        },
        _create: function () {
            var thisWidget = this;
            //Fila única del toolbar
            var $Icon = $('<div class="ui-icon ui-icon-alert" style="float:left"></div>');
            var $Title = $('<p class="ui-helper-reset ui-state-error-text"><strong>' + thisWidget.options.errorTitle + '</strong></p>');
            this.options.$ErrorList = $('<ul></ul>');
            for (var i in thisWidget.options.errors) {
                this.options.$ErrorList.append('<li class="ui-state-error-text">' + thisWidget.options.errors[i] + '</li>');
            }
            //Recorrer matriz de botones
            this.element.append($Icon);
            this.element.append($Title);
            this.element.append(this.options.$ErrorList);
            this.element.addClass("ui-state-error ui-corner-all");
            this.element.hide();
        },
        destroy: function () {
            $.Widget.prototype.destroy.call(this, arguments);
            this.element.removeClass("ui-state-error ui-corner-all");
            this.element.children("<div>").remove();
            this.element.children("<ul>").remove();
            this.element.children("<p>").remove();
        },
        disable: function () {
            $.Widget.prototype.disable.call(this, arguments);
        },
        enable: function () {
            $.Widget.prototype.enable.call(this, arguments);
        },
        setErrors: function (errors) {
            this.options.errors = errors;
            this.options.$ErrorList.empty();
            for (var i in this.options.errors) {
                this.options.$ErrorList.append('<li class="ui-state-error-text">' + this.options.errors[i] + '</li>');
            }
            this.element.show();
        }
    });
})(jQuery);

/*****************************************************************************/
/********************** MSGBOX ***********************************************/
/*****************************************************************************/
(function ($) {
    $.widget("ui.msgbox", {
        options: {
            autoShow: false,
            title: "",
            message: "",
            okButton: false,
            cancelButton: false,
            yesButton: false,
            noButton: false,
            width: 450,
            height: 200,
            icon: 'info',
            dialogResult: function (e, data) { },
            $Dialog: null,
            $Message: null,
            $Icon: null
        },
        _create: function () {
            var thisWidget = this;
            //Fila única del toolbar
            this.options.$Dialog = $('<div></div>');
            //Agregar encabezado con icono y texto
            var $DivHeader = $('<div></div>');
            this.options.$Icon = $('<img style="float:left" src="' + App.ImagePath + '/General/Info_64.png" width="48px" height="48px" />');
            this.options.$Message = $('<div align="center" class="ui-msgbox-message"></div>');
            $DivHeader.append(this.options.$Icon);
            $DivHeader.append(this.options.$Message);
            //Agregar tabla como contenedor de botones
            var $TableButtons = $('<table width="100%"><tr></tr></table>');
            var $Buttons = $('<td align="center" colspan="2"></td>');
            var $OkButton = $('<input id="msgbox_okbutton" class="ui-msgbox-button" type="button" value="Aceptar" style="margin-right:30px;" />');
            var $CancelButton = $('<input id="msgbox_cancelbutton" class="ui-msgbox-button" type="button" value="Cancelar" />');
            var $YesButton = $('<input id="msgbox_yesbutton" class="ui-msgbox-button" type="button" value="Si" />');
            var $NoButton = $('<input id="msgbox_nobutton" class="ui-msgbox-button" type="button" value="No" />');
            //Crear jerarquía de elementos                    
            $Buttons.append($OkButton);
            $Buttons.append($CancelButton);
            $Buttons.append($YesButton);
            $Buttons.append($NoButton);
            $TableButtons.append($Buttons);
            this.options.$Dialog.append($DivHeader);
            this.options.$Dialog.append($TableButtons);
            this.element.append(this.options.$Dialog);
            //Enlazar función a evento click
            $('.ui-msgbox-button', this.element).bind("click", function (e) {
                thisWidget.options.$Dialog.wijdialog("close");
                var clickedButton = $(e.currentTarget);
                if (thisWidget.options.dialogResult != undefined) thisWidget.options.dialogResult(e, { resp: clickedButton.val() });
                thisWidget._buttonClick(e);
                return false;
            });
            //Aplicar tema a botones
            $('.ui-msgbox-button', this.element).button();
            //Definir propiedades de la ventana
            this.options.$Dialog.wijdialog({
                draggable: false, height: thisWidget.options.height, width: thisWidget.options.width,
                resizable: false, show: 'slide', modal: true, title: thisWidget.options.title, autoOpen: false,
                captionButtons: {
                    pin: { visible: false },
                    refresh: { visible: false },
                    toggle: { visible: false },
                    minimize: { visible: false },
                    maximize: { visible: false }
                }
            });
            //Si se estableció la propiedad auto show
            if (this.options.autoShow == true)
                this.show({
                    title: this.options.title,
                    message: this.options.message,
                    okButton: this.options.okButton,
                    cancelButton: this.options.okButton,
                    icon: this.options.icon
                });
        },
        destroy: function () {
            $.Widget.prototype.destroy.call(this, arguments);
        },
        disable: function () {
            $.Widget.prototype.disable.call(this, arguments);
            this.element.find(".ui-toolbar-button").unbind();
        },
        enable: function () {
            $.Widget.prototype.enable.call(this, arguments);
        },
        show: function (options) {
            this.options.$Message.text(options.message);
            this.options.$Dialog.wijdialog("option", "title", options.title);
            this.options.dialogResult = options.dialogResult;
            $('.ui-msgbox-button').hide();
            //Determinar los botones que se mostrarán
            if (options.okButton == true)
                $('#msgbox_okbutton.ui-msgbox-button').show();
            else
                $('#msgbox_okbutton.ui-msgbox-button').hide();

            if (options.cancelButton == true)
                $('#msgbox_cancelbutton.ui-msgbox-button').show();
            else
                $('#msgbox_cancelbutton.ui-msgbox-button').hide();

            if (options.yesButton == true)
                $('#msgbox_yesbutton.ui-msgbox-button').show();
            else
                $('#msgbox_yesbutton.ui-msgbox-button').hide();

            if (options.noButton == true)
                $('#msgbox_nobutton.ui-msgbox-button').show();
            else
                $('#msgbox_nobutton.ui-msgbox-button').hide();

            //Determinar el icono del mensaje
            if (options.icon == "info")
                this.options.$Icon.attr('src', App.ImagePath + '/General/Info_64.png');
            if (options.icon == "question")
                this.options.$Icon.attr('src', App.ImagePath + '/General/Question_64.png');
            if (options.icon == "error")
                this.options.$Icon.attr('src', App.ImagePath + '/General/Cross_64.png');
            this.options.$Dialog.wijdialog("open");
        },
        _buttonClick: function (e) {
            var clickedButton = $(e.currentTarget);
            this._trigger("optionSelected", e, { resp: clickedButton.val() });
        }
    });
})(jQuery);

/*****************************************************************************/
/********************** SWITCH ***********************************************/
/*****************************************************************************/

(function ($) {
    $.widget("ui.Switch", {
        options: {
            value: true            
        },
        _create: function () {
            var thisWidget = this;
            //Crear elementos visuales del switch
            var $Row = $('<table id="ui_switch_table" class="ui-widget-content ui-state-active ui-corner-all" border="0" cellpadding="0" cellspacing="0"><tr></tr></table>');
            $Row.append('<td><div class="ui-switch-text">Activo</div></td>');
            $Row.append('<td class="ui-widget-header"><a class="ui-switch-button" href="#"><img class="ui-switch-image" src="' + App.ImagePath + '/General/Disable_16.png" alt="" /></a></td>');
            this.element.append($Row);
            this.element.addClass("ui-widget ui-switch");
            //Enlazar evento del botón
            $('.ui-switch-button', this.element).bind("click", function (e) {
                thisWidget._buttonClick(e);
                return false;
            });
            this.value(this.options.value);
        },
        destroy: function () {
            $.Widget.prototype.destroy.call(this, arguments);
            this.element.removeClass("ui-widget ui-switch");
            this.element.find(".ui-switch-button").unbind();
            this.element.empty();
        },
        disable: function () {
            $.Widget.prototype.disable.call(this, arguments);
            this.element.find(".ui-switch-button").hide();
        },
        enable: function () {
            $.Widget.prototype.enable.call(this, arguments);
            var thisWidget=this;
            this.element.find('.ui-switch-button').show();
        },
        value: function (valor) {
            if (valor != undefined) this.options.value = valor;                    
            if (this.options.value == true) {
                $('.ui-switch-text', this.element).text('Activo');
                $('.ui-switch-image', this.element).attr("src", App.ImagePath + '/General/Disable_16.png');
                $('#ui_switch_table', this.element).removeClass('ui-state-error');
                $('#ui_switch_table', this.element).addClass('ui-state-active');
            }
            else {
                $('.ui-switch-text', this.element).text('Inactivo');
                $('.ui-switch-image', this.element).attr("src", App.ImagePath + '/General/Ok_16.png');
                $('#ui_switch_table', this.element).removeClass('ui-state-active');
                $('#ui_switch_table', this.element).addClass('ui-state-error');
            }            
            return this.options.value;
        },
        _buttonClick: function (e) {
            var newValue = !this.options.value;
            this.value(newValue);
            this._trigger("change", e, {value: this.options.value });            
        }
    });
})(jQuery);

/*****************************************************************************/
/********************** SELECTOR *********************************************/
/*****************************************************************************/
(function ($) {
    $.widget("ui.catalogselector", {
        options: {
            identity: 0,
            text: '',
            searchColumn: 'Nombre',
            displayMember: function(item){return item.Nombre},
            catalogService: null,
            width: 200,
            listColumns: [],
            dialogWidth: 700,
            dialogHeight: 500,
            dialogTitle: "Búsqueda en catálogo",
            _$Input: null,
            _$Grid: null,
            _$Dialog: null            
        },
        _create: function () {
            var thisWidget = this;            
            var elementName= this.element.attr('id');
            //Crear elementos visuales del selector                        
            var $Row = $('<table border="0" cellpadding="0" cellspacing="0" width="' + this.options.width + 'px"><tr></tr></table>');
            //Agregar text box
            var $tdInput = $('<td class="ui-catalogselector-input" style="width:' + (this.options.width - 40) + 'px"></td>').appendTo($Row);
            this.options._$Input = $('<input class="ui-catalogselector-input" type="text" name="' + elementName + '" style="width:' + (this.options.width - 35) + 'px" />').appendTo($tdInput);
            //Agregar botón de búsqueda
            var $tdButton = $('<td align="left" valign="middle" style="width:40px;" ></td>').appendTo($Row);
            var $Button = $('<div align="center" class="ui-state-default ui-corner-all ui-catalogselector-button" style="width:30px; height:23px; cursor: pointer;"></div>').appendTo($tdButton);
            var $ButtonImage = $('<img src="' + App.ImagePath + '/General/Find_16.png" height="16px" width="16px" alt="Buscar" class="ui-catalogselector-image" style="margin-top:2px;" />').appendTo($Button);
            this.element.append($Row);
            //Agregar cuadro de diálogo para búsquedas
            this.options._$Dialog = $('<div class="ui-catalogselector-dialog"></div>').appendTo(this.element);
            this.options._$Dialog.append('<div class="modal"></div>');
            this.options._$Grid = $('<table class="ui-catalogselector-grid"></table>').appendTo(this.options._$Dialog);
            //
            this.element.addClass("ui-widget ui-catalogselector");

           //Aplicar temas y crear objetos wijmo
           this.options._$Input.autocomplete({
                minLength: 3, autoFocus:true,
                source: function(request, response) {
                    //Crear array de condiciones con el término a buscar
                    var Conditions=[];
                    var Condition={ Field: thisWidget.options.searchColumn, Operator: 'like', Value: '%' + request.term, ValueType: 'string' }
                    Conditions.push(Condition);

                    thisWidget.options.catalogService.Search(App.DefaultBranch.Identity, Conditions, null, 1)
                        .done(function (data) {
                            var Result = $.parseJSON(data);
                            //Agregar columna label que debe ser igual al display member
                            $.each(Result.Rows, function(index, value){
                                value.label=thisWidget.options.displayMember(value);
                            });                            
                            response(Result.Rows);                            
                        })
                        .fail(function (jqXHR, textStatus, error) {
                            response(null);                            
                        });
                },
                change:function(e, ui){
                    if (ui.item == null) {
                        thisWidget.options.identity=0;
                        $(this).addClass('ui-state-error');
                        thisWidget._trigger("cleared", null, {}); 
                    }
                    else {
                        thisWidget.options.identity= ui.item.ID;                        
                        $(this).removeClass('ui-state-error');                        
                        thisWidget._trigger("itemLoaded", null, ui.item);
                        thisWidget.options._$Input.siblings('div.ui-state-error').hide();
                    }                    
                }
            });

            $Button.hover(function () { $(this).addClass('ui-state-hover'); }, function () { $(this).removeClass('ui-state-hover'); });
            //Crear cuadro de diálogo para las búsquedas
            thisWidget.options._$Dialog.dialog({
                autoOpen: false,
                modal: true,
                width: thisWidget.options.dialogWidth,
                height: thisWidget.options.dialogHeight,
                show: "blind",
                title: thisWidget.options.dialogTitle
            });

            //Agregar columna de selección
            thisWidget.options.listColumns.unshift(
                { headerText: "", width: 30, showFilter: false,
                    cellFormatter: function (args) {
                        if (args.row.type & $.wijmo.wijgrid.rowType.data) {
                            args.$container.attr('align', 'center');
                            args.$container.empty().append(
                                $("<a href='#'><img src='" + App.ImagePath + "/General/OK_16.png' alt='' class=''/></a>")
                                    .click(function (e) {
                                        thisWidget.options._$Input.val(thisWidget.options.displayMember(args.row.data));
                                        thisWidget.options.text=thisWidget.options.displayMember(args.row.data);
                                        thisWidget.options.identity=args.row.data.ID;
                                        thisWidget.element.removeClass('ui-state-error');
                                        thisWidget.options._$Dialog.dialog('close');                    
                                        thisWidget._trigger("itemLoaded", null, args.row.data);                           
                                        return false;
                                    })
                                );
                            return true;
                        }
                    }
                }
            );

            //Crear grid para el listado y búsqueda de elementos
            this.options._$Grid.wijgrid({
                ensureColumnsPxWidth: true, culture: "es", allowPaging: true, pageSize: App.PageSize, allowSorting: true, showFilter: true,
                columns: thisWidget.options.listColumns, filterOperatorsSortMode: "alphabeticalCustomFirst",
                pageIndexChanging: function (e, args) {
                    var SortOrder = Kernel.GridServices.GetSorting(thisWidget.options._$Grid);
                    var Conditions = Kernel.GridServices.GetFilter(thisWidget.options._$Grid);
                    thisWidget.options.catalogService.Search(App.DefaultBranch.Identity, Conditions, SortOrder, args.newPageIndex + 1)
                        .done(function (data) {
                            var result = $.parseJSON(data);
                            thisWidget.options._$Grid.wijgrid({ data: result.Rows, totalRows: result.TotalRows });                            
                        })
                        .fail(function (jqXHR, textStatus, error) {
                        });
                },
                pageIndexChanged: function (e) {
                    thisWidget.options._$Grid.wijgrid('ensureControl', true);
                },
                sorted: function (e, args) {
                    thisWidget._refreshList();
                },
                filtered: function (e, args) {
                    var SortOrder = Kernel.GridServices.GetSorting(thisWidget.options._$Grid);
                    var Conditions = Kernel.GridServices.GetFilter(thisWidget.options._$Grid);
                    var filter = $('.wijmo-wijgrid-filterlist', thisWidget.options._$Grid);
                    thisWidget.options._$Grid.wijgrid({ pageIndex: 0 });
                    thisWidget.options.catalogService.Search(App.DefaultBranch.Identity, Conditions, SortOrder, 1)
                        .done(function (data) {
                            var result = $.parseJSON(data);
                            thisWidget.options._$Grid.wijgrid({ data: result.Rows, totalRows: result.TotalRows });                            
                        })
                        .fail(function (jqXHR, textStatus, error) {
                        });
                    thisWidget.options._$Grid.wijgrid('ensureControl', true);
                },
                loaded: function () {
                    $('.wijmo-wijgrid-filter-input', thisWidget.options._$Grid).bind("keypress", function (e, args) {
                        if (e.keyCode == 13) {
                            //Obtener las columnas que tienen habilitado el filtro
                            var columnFilters = $('.wijmo-wijgrid-filter-input', thisWidget.options._$Grid);
                            //Obtener las columnas visibles del grid                                                        
                            var columns = thisWidget.options._$Grid.wijgrid('columns');
                            //Obtener el numero de columna que se está filtrando (de la colección de colmnas con filtro)
                            var colFilterIndex = columnFilters.index($(this));
                            //Obtener la columna (widget) visible que se está filtrando (de la colección de columnas visibles del grid)
                            //Sumando al indice de la columna con filtro, la diferencia entre columnas visibles y con filtro
                            var column = columns[colFilterIndex + (columns.length - columnFilters.length)];
                            //var GridColumns = thisForm.CatalogList.data("wijgrid").columns();
                            //Obtener valor del filtro
                            var filterValue = $('.wijmo-wijgrid-filter-input', thisWidget.options._$Grid).eq(colFilterIndex).val();
                            //Establecerlo en la columna (widget)
                            column.option('filterValue', filterValue);
                            var SortOrder = Kernel.GridServices.GetSorting(thisWidget.options._$Grid);
                            var Conditions = Kernel.GridServices.GetFilter(thisWidget.options._$Grid);
                            thisWidget.options._$Grid.wijgrid({ pageIndex: 0 });
                            thisWidget.options.catalogService.Search(App.DefaultBranch.Identity, Conditions, SortOrder, 1)
                                .done(function (data) {
                                    var result = $.parseJSON(data);
                                    thisWidget.options._$Grid.wijgrid({ data: result.Rows, totalRows: result.TotalRows });                            
                                })
                                .fail(function (jqXHR, textStatus, error) {
                                });
                            thisWidget.options._$Grid.wijgrid('ensureControl', true);
                        }
                    });
                }
            });
            //Asignar operadoes localizados
            this.options._$Grid.wijgrid().data().wijmoWijgrid._localizeFilterOperators(Kernel.GridServices.LocalizedFilterOperators);
            
            //Enlazar evento del botón
            $Button.bind("click", function (e) {
                thisWidget.options._$Grid.wijgrid({ pageIndex: 0 });                        
                thisWidget.options.catalogService.Search(App.DefaultBranch.Identity, null, null, 1)
                    .done(function (data) {
                        var result = $.parseJSON(data);
                        thisWidget.options._$Grid.wijgrid({ data: result.Rows, totalRows: result.TotalRows });                                                    
                    })
                    .fail(function (jqXHR, textStatus, error) {
                    });                                            
                thisWidget.options._$Dialog.dialog('open');
                return false;
            });

        },
        destroy: function () {
            $.Widget.prototype.destroy.call(this, arguments);
            this.element.removeClass("ui-widget ui-catalogselector");
            this.element.find(".ui-catalogselector-button").unbind();
            this.element.empty();
        },
        disable: function () {
            $.Widget.prototype.disable.call(this, arguments);
            this.element.find(".ui-catalogselector-button").unbind();
        },
        enable: function () {
            $.Widget.prototype.enable.call(this, arguments);
            var thisWidget = this;
            this.element.find('.ui-catalogselector-button', this.element).bind("click", function (e) {
                thisWidget._buttonClick(e);
            });
        },
        value: function () {
            return this.options.identity;
        },
        clear: function () {
            this.options._$Input.val('');
            this.options.identity = 0;
            this.options.text = '';
            this.element.removeClass('ui-state-error');
            this.element.removeClass('error');
            this._trigger("cleared", null, {}); 
        },
        load: function (identity) {
            var thisWidget = this;
            this.options.catalogService.GetDetailByID(identity, false)
                .done(function (data) {
                    var result = $.parseJSON(data);
                    thisWidget.options._$Input.val(thisWidget.options.displayMember(result));                                                                        
                    thisWidget.options.text=thisWidget.options.displayMember(result);
                    thisWidget.options.identity=result.Identity;
                    thisWidget.element.removeClass('ui-state-error');                    
                    thisWidget._trigger("itemLoaded", null, result);                                               
                })
                .fail(function (jqXHR, textStatus, error) {
                });
        },
        _buttonClick: function (e) {
            this._trigger("searching", e, { value: this.options.identity });
        },
        _refreshList: function () {   
            var thisWidget = this;         
            var SortOrder = Kernel.GridServices.GetSorting(this.options._$Grid);
            var Conditions = Kernel.GridServices.GetFilter(this.options._$Grid);
            //Obtener la página actual para volver a obtener la misma página
            var CurrentPage = this.options._$Grid.wijgrid("option", "pageIndex");
            this.options.catalogService.Search(App.DefaultBranch.Identity, Conditions, SortOrder, CurrentPage + 1)
                .done(function (data) {
                    var result = $.parseJSON(data);
                    thisWidget.options._$Grid.wijgrid({ data: result.Rows, totalRows: result.TotalRows });
                })
                .fail(function (jqXHR, textStatus, error) {
                });
            this.options._$Grid.wijgrid('ensureControl', true);
        }
    });
})(jQuery);


/*****************************************************************************/
/********************** CATALOG LIST ****************************************/
/*****************************************************************************/

(function ($) {
    $.widget("ui.cataloglist", {
        options: {
            identity: 0,
            selectedItems: [],                                    
            catalogService: null,            
            listColumns: [],
            multiSelect:false,
            width: 700,
            height: 500,
            title: "Listado de catálogo",            
            _$Grid: null,
            _$Dialog: null,
            _$Toolbar: null,
            _ViewModel: null
        },
        _create: function () {
            var thisWidget = this;
            var elementName= this.element.attr('id');
            //Crear view model del widget
            function WidgetViewModel(){
                var self=this;
                self.SearchResult=ko.observableArray([]);
                self.TotalRows=ko.observable(0);
                self.Search=function(conditions, sortOrder, pageIndex){
                    thisWidget.options.catalogService.Search(App.DefaultBranch.Identity, conditions, sortOrder, pageIndex)
                        .done(function (data) {
                            var result = $.parseJSON(data);
                            if (thisWidget.options.multiSelect){
                                $.each(result.Rows, function(index, item){
                                    item._Sel=false;
                                });
                            }
                            self.TotalRows(result.TotalRows);
                            self.SearchResult(result.Rows);
                        })
                        .fail(function (e, args) {
                        });                                                            
                }

            }
            thisWidget.options._ViewModel=new WidgetViewModel();            
            //Agregar cuadro de diálogo para búsquedas
            
            this.options._$Dialog = $('<div class="ui-cataloglist-dialog"></div>').appendTo(this.element);
            //Si es de selección múltiple, agregar toolbar
            if (thisWidget.options.multiSelect)
                this.options._$Dialog.append('<div class="modal"></div>');
            this.options._$Toolbar=$('<div></div>').appendTo(this.options._$Dialog);
            this.options._$Grid = $('<table class="ui-cataloglist-grid" data-bind="wijgrid: { data: SearchResult }"></table>').appendTo(this.options._$Dialog);
            
            //
            this.element.addClass("ui-widget ui-cataloglist");
            //
            //Crear cuadro de diálogo que contendrá la lista
            thisWidget.options._$Dialog.dialog({
                autoOpen: false,
                modal: true,
                width: thisWidget.options.width,
                height: thisWidget.options.height,
                show: "blind",
                title: thisWidget.options.title,
                appendTo:'#' + thisWidget.element.attr('id')
            });

            //Crear toolbar cuando está activada la selección múltiple
            if (thisWidget.options.multiSelect)
                this.options._$Toolbar.toolbar({
                    buttonHeight: 32, buttonWidth: 32,
                    buttons: [
                    { text: "Aceptar", key: "btnOK", image: "General/OK_32.png"},
                    { text: "Cancelar", key: "btnCancel", image: "General/Close_32.png"}
                    ],                    
                    buttonClick: function (e, data) {
                        if (data.key == "btnOK") {
                            thisWidget.options._$Grid.wijgrid('endEdit');
                            var SelectedItems=thisWidget.options._$Grid.wijgrid('data');
                            thisWidget.options.selectedItems=$.grep(SelectedItems, function(item, index){
                                return item._Sel;
                            });
                            thisWidget._selectionChanged(thisWidget.options.selectedItems);                            
                        }
                        if (data.key == "btnCancel")                            
                            thisWidget.options.identity=0;
                            thisWidget.options.selectedItems=[];
                            thisWidget.options._$Dialog.dialog('close');
                        }
            });
            
            //Ocultar columna de ID interno
            thisWidget.options.listColumns.unshift({headerText: "ID", visible:false, showFilter: false, dataKey: "ID"});
            //Si no es multie select, agregar columna de selección, si es multie select agregar columna de check box
            if (thisWidget.options.multiSelect){
                thisWidget.options.listColumns.unshift({headerText: "", width: 30, showFilter: false, dataType: "boolean", dataKey: "_Sel"});
            }
            else {
                thisWidget.options.listColumns.unshift(
                    { headerText: "", width: 30, showFilter: false,
                        cellFormatter: function (args) {
                            if (args.row.type & $.wijmo.wijgrid.rowType.data) {
                                args.$container.attr('align', 'center');
                                args.$container.empty().append(
                                    $("<a href='#'><img src='" + App.ImagePath + "/General/OK_16.png' alt='' class=''/></a>")
                                        .click(function (e) {                                                                                        
                                            thisWidget.options.identity=args.row.data.ID;                                                                
                                            thisWidget._selectionChanged(args.row.data);
                                            return false;
                                        })
                                    );
                                return true;
                            }
                        }
                    }
                );
            }

            //Crear grid para el listado y búsqueda de elementos
            this.options._$Grid.wijgrid({
                ensureColumnsPxWidth: true, culture: "es", allowPaging: true, pageSize: App.PageSize, allowSorting: true, showFilter: true, allowEditing: true,
                columns: thisWidget.options.listColumns, filterOperatorsSortMode: "alphabeticalCustomFirst",
                pageIndexChanging: function (e, args) {
                    thisWidget.options._$Grid.wijgrid('endEdit')
                }
            });
            //Asignar operadoes localizados
            this.options._$Grid.wijgrid().data().wijmoWijgrid._localizeFilterOperators(Kernel.GridServices.LocalizedFilterOperators);
            //Enlazar a view model
            ko.applyBindings(thisWidget.options._ViewModel, thisWidget.element[0]);
        },
        destroy: function () {
            $.Widget.prototype.destroy.call(this, arguments);
            this.element.removeClass("ui-widget ui-cataloglist");            
            this.element.empty();
        },
        disable: function () {
            $.Widget.prototype.disable.call(this, arguments);
        },
        enable: function () {
            $.Widget.prototype.enable.call(this, arguments);
        },
        show: function () {
            var thisWidget = this;

            thisWidget.options._$Grid.wijgrid({ pageIndex: 0 });
            thisWidget.options._ViewModel.Search(null, null, 0);
            thisWidget.options._$Dialog.dialog('open');
        },
        value: function() {            
            if (this.options.multiSelect)
                return this.options.selectedItems;
            else
                return this.options.identity;
        },
        _selectionChanged: function(selection) {                        
            this.options._$Dialog.dialog('close');
            this._trigger("selectionChanged", null, selection);
        }
    });
})(jQuery);








