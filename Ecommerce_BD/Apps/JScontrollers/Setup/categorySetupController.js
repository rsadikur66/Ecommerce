app.controller('categorySetupController', ["$scope", "$window", "$location", "$filter", "$timeout", "categorySetupService", function ($scope, $window, $location, $filter, $timeout, categorySetupService) {
    $scope.obj = {};
    $scope.obj.cat = {};
    getCategoriesData();
    $scope.buttonText = "Save";
    //document.getElementById('#txtBanglaName').hidden = true;
    //Get Category List();
    function getCategoriesData() {        
        var categoriesData = categorySetupService.GetCategories();
        categoriesData.then(function (data) {
            $scope.obj.categories = JSON.parse(data);
            console.log($scope.obj.categories);
        });
    }    
    //Get Category List end

    //Category Insert & update Starts----
    $scope.Save = function () {
        if ($scope.buttonText == "Save") {
            if ($scope.obj.cat.T_LANG2_NAME != undefined && $scope.obj.cat.T_LANG1_NAME != undefined) {
                var insert = categorySetupService.insertData($scope.obj.cat);
                insert.then(function (data) {
                    alert(data);
                    getCategoriesData();
                    clear();
                })
            } else {
                alert("You Must input both field.")
            };
        } else if ($scope.buttonText == "Update") {
            if ($scope.obj.cat.T_LANG2_NAME != undefined && $scope.obj.cat.T_LANG1_NAME != undefined) {
                var update = categorySetupService.updateData($scope.obj.cat);
                update.then(function (data) {
                    alert(data);
                    getCategoriesData();
                    clear();
                })
            } else {
                alert("You Must input both field.")
            };
        }
               
    };
    //Category Insert & update Ends----

    $scope.Delete = function () {
        var DeleteCatData = categorySetupService.DeleteData($scope.obj.cat.CATEGORY_ID);
        DeleteCatData.then(function (data) {
            alert(data);
            getCategoriesData();
            clear();
        })
    }
    //$scope.rowSelect = function (data) {
    //    $scope.obj.cat.CATEGORY_ID = data.CATEGORY_ID;
    //    $scope.obj.cat.T_LANG2_NAME = data.T_LANG2_NAME;
    //    $scope.obj.cat.T_LANG1_NAME = data.T_LANG1_NAME;
    //    $scope.buttonText = "Update";
    //};

    //For Print Service start---
    $scope.Print = function () {
        //$window.open("../Q74001/R74001ReportWaittingAmbulance? popup",
        //    "width= 600, height = 600, left = 100, top = 50");
        $window.open("../CategorySetup/PrintReport?popup","width = 600,height=600,left = 100, top = 50")
    }
    //For Print Service end

    function clear() {
        $scope.obj.cat.T_LANG1_NAME = "";
        $scope.obj.cat.T_LANG2_NAME = "";
    }
}
]);