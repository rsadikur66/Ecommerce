app.controller('menuController', ["$scope", "$window", "$location", "$filter", "$timeout", "menuService", function ($scope, $window, $location, $filter, $timeout, menuService) {
    $scope.name = 'sDokan';
    $scope.obj = {};
    $scope.obj.Virus = {};
    getgriddata();
    function getgriddata() {
        $scope.menudata = [];
        var gridData = menuService.GetMenuData();
        gridData.then(function (data) {
            $scope.obj.Virus = JSON.parse(data);
            console.log($scope.obj.Virus);
        });
    }
}
]);



