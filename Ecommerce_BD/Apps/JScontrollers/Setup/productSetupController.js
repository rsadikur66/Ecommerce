app.controller('productSetupController', ["$scope", "$window", "$location", "$filter", "$timeout", "productSetupService", function ($scope, $window, $location, $filter, $timeout, productSetupService) {
    $scope.obj = {};
    $scope.obj.ambulance = [];
    getHomeData();
    function getHomeData() {
        var categoriesData = productSetupService.GetCategories();
        categoriesData.then(function (data) {
            $scope.obj.ambulance = JSON.parse(data);
            console.log($scope.obj.ambulance);
        });
       
    }
}
]);


app.filter('propsFilter', function () {
    return function (items, props) {
        var out = [];

        if (angular.isArray(items)) {
            var keys = Object.keys(props);

            items.forEach(function (item) {
                var itemMatches = false;

                for (var i = 0; i < keys.length; i++) {
                    var prop = keys[i];
                    var text = props[prop].toLowerCase();
                    if (item[prop].toString().toLowerCase().indexOf(text) !== -1) {
                        itemMatches = true;
                        break;
                    }
                }

                if (itemMatches) {
                    out.push(item);
                }
            });
        } else {
            // Let the output be the input untouched
            out = items;
        }

        return out;
    };
});