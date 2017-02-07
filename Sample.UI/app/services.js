
app.factory("UserAccountsFactory", ["$resource", function ($resource) {

    return $resource('http://localhost:58215/api/account', {}, {
        query: { method: 'GET', isArray: true },
        create: { method: 'POST' }
    });

}]);

app.factory("UserAccountFactory", ["$resource", function ($resource) {

    return $resource('http://localhost:58215/api/account/:id', {}, {
        show: { method: 'GET' },
        update: { method: 'PUT', params: { id: '@id' } },
        delete: { method: 'DELETE', params: { id: '@id' } }
    });

}]);

