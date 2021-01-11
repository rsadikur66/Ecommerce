// <reference path="../scripts/angular.min.js" />
var app = angular.module('EcommerceBD', ['ui.bootstrap']);

app.run(function ($rootScope, $templateCache) {
    $rootScope.$on('$routeChangeStart', function (event, next, current) {
        if (typeof (current) !== 'undefined') {
            $templateCache.remove(current.templateUrl);
        }
    });
});
app.factory('Data', function () {
    return { obj: '' };
});


//'ui.grid.selection', 'ui.grid', 'ui.grid.pagination', 'ui.grid.exporter', 'datatables', 'angularUtils.directives.dirPagination', 'ngSanitize', 'ui.select', 'angularModalService', 'akFileUploader', '720kb.datepicker'