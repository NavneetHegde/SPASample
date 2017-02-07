app.controller('UserAccount-New-Controller',
    ['$scope', 'UserAccountsFactory', '$location',
    function ($scope, UserAccountsFactory, $location) {

        // callback for ng-click 'createNewUser':
        $scope.createNewUserAccount = function () {
            UserAccountsFactory.create($scope.userAccount).$promise.then(
                    //success
                    function (value) {
                        $location.path('/useraccounts');
                    },
                    //error
                    function (error) {
                        console.log(error);
                    }
                );
        }

        // callback for ng-click 'cancel':
        $scope.cancel = function () {
            $location.path('/useraccounts');
        };

    }]);