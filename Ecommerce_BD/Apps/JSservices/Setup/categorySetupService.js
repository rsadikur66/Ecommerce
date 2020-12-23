
app.service("categorySetupService", ["$http", function ($http) {
    var dataService = {
        //menudata: MenuData,
        //UserLogout: UserLogout,
        GetCategories: GetCategories,
        insertData: insertData,
        updateData: updateData,
        DeleteData: DeleteData

    };
    return dataService;


    function GetCategories() {
        try {
            var url = "/CategorySetup/GetAllCategoriesData";
            var params = {};
            return $http({
                url: url,
                method: "GET",
                data: params
            }).then(function (results) {
                return results.data;
            }).catch(function (ex) {
                throw ex;
            });
        } catch (ex) {
            throw ex;
        }
    }
    //Insert and Update Function start
    function insertData(cat) {

        try {
            var url = '/CategorySetup/InsertData';
            return $http({
                url: url,
                method: "POST",
                data: JSON.stringify(cat)
            }).then(function (results) {
                return results.data;
            }).catch(function (ex) {
                throw ex;
            });
        } catch (ex) {
            throw ex;
        }
    }

    function updateData (cat) {

        try {
            var url = '/CategorySetup/UpdateData';
            return $http({
                url: url,
                method: "POST",
                data: JSON.stringify(cat)
            }).then(function (results) {
                return results.data;
            }).catch(function (ex) {
                throw ex;
            });
        } catch (ex) {
            throw ex;
        }
    }
        //Insert and Update Function End

    function DeleteData(CATEGORY_ID) {

        try {
            var url = '/CategorySetup/DeleteCatData';
            return $http({
                url: url,
                method: "POST",
                data: { CATEGORY_ID: CATEGORY_ID}
            }).then(function (results) {
                return results.data;
            }).catch(function (ex) {
                throw ex;
            });
        } catch (ex) {
            throw ex;
        }
    }
}]);