app.service("categorySetupService", ["$http", function ($http) {
    var dataService = {
        //menudata: MenuData,
        //UserLogout: UserLogout,
        //GetCategories: GetCategories,
        insertData: insertData

    };
    return dataService;

    function LangName() {
        try {
            var url = vrtlDirr + 'LangName';
            var params = {};
            return $http({
                url: url,
                method: "POST",
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

    function GetCategories() {
        try {
            var url = "/ProductSetup/GetCategories";
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
    function GetBrands() {
        try {
            var url = "/ProductSetup/GetBrands";
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

    //For Save and Update Function  Start 
    function insertData(cat) {
        try {
            var url = '/T74038/InsertData';//AddItem from controller T74038Controller
            return $http.post(url, _T74038)
                .then(function (results) {
                    return results.data;
                }).catch(function (e) { });
        } catch (ex) {
            throw ex;
        }
    }
    //For Save and Update Function  End 

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
        //Insert and Update Function End
}]);