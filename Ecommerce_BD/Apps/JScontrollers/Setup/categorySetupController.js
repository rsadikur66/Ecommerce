app.controller('categorySetupController', ["$scope", "$window", "$location", "$filter", "$timeout", "categorySetupService", function ($scope, $window, $location, $filter, $timeout, categorySetupService) {
    $scope.obj = {};
    $scope.obj.cat = {};
    //getCategoriesData();
    //getBrandsData();
    function getCategoriesData() {
        var categoriesData = categorySetupService.GetCategories();
        categoriesData.then(function (data) {
            $scope.obj.categories = JSON.parse(data);
            console.log($scope.obj.categories);
        });

    }
    function getBrandsData() {
        var brandsData = productSetupService.GetBrands();
        brandsData.then(function (data) {
            $scope.obj.brands = JSON.parse(data);
            console.log($scope.obj.brands);
        });

    }
    $scope.Save = function () {
        var insert = categorySetupService.insertData($scope.obj.cat);
        insert.then(function (data) {
            if (data === "True") {
                alert('Data Save successfully!!!');
                clear();
            }
        });
    };

    function clear() {
        $scope.obj.cat = {};        
    }
}
]);