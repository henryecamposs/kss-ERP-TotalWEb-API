var ViewModel = function () {
    var self = this;
    self.productos = ko.observableArray();
    self.error = ko.observable();
    self.producto = ko.observable();
    self.authors = ko.observableArray();
    self.newProducto = {
        Producto: ko.observable(),
        MontoPrecio1: ko.observable(),
        id_Productos: ko.observable(),
        CodigoBarras: ko.observable(),
        esActivo: ko.observable()
    }

    var productosuri = '/api/productos/';
    var authorsUri = '/api/authors/';

    function ajaxHelper(uri, method, data) {
        self.error(''); // Clear error message
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null
        }).fail(function (jqXHR, textStatus, errorThrown) {
            self.error(errorThrown);
        });
    }

    function getAllproductos() {
        ajaxHelper(productosuri, 'GET').done(function (data) {
            self.productos(data);
        });
    }

    self.getproductoDetail = function (item) {
        ajaxHelper(productosuri + item.Id, 'GET').done(function (data) {
            self.detail(data);
        });
    }

    function getAuthors() {
        ajaxHelper(authorsUri, 'GET').done(function (data) {
            self.authors(data);
        });
    }


    self.addproducto = function (formElement) {
        var producto = {
            AuthorId: self.newproducto.Author().Id,
            Genre: self.newproducto.Genre(),
            Price: self.newproducto.Price(),
            Title: self.newproducto.Title(),
            Year: self.newproducto.Year()
        };

        ajaxHelper(productosUri, 'POST', producto).done(function (item) {
            self.productos.push(item);
        });
    }

    // Fetch the initial data.
    getAllproductos();
    getAuthors();
};

ko.applyBindings(new ViewModel());