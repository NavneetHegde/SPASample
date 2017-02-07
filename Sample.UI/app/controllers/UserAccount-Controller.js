app.controller("UserAccount-Controller",
    ["$scope", "$routeParams", "$location", "UserAccountsFactory", "UserAccountFactory",
    function ($scope, $routeParams, $location, UserAccountsFactory, UserAccountFactory) {

        $scope.userAccounts = UserAccountsFactory.query();

        $scope.editUserAccount = function (id) {
            $location.path('/edituseraccount/' + id);
        }

        $scope.createNewAccount = function () {
            $location.path('/newuseraccount');
        }

        $scope.deleteUserAccount = function (id) {
            UserAccountFactory.delete({ id: id }, null).$promise.then(
                //success
                function (value) {
                    $scope.userAccounts = UserAccountsFactory.query();
                },
                //error
                function (error) {
                    console.log(error);
                }
            );
        };


    }]);