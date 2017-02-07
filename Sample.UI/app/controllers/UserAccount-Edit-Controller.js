app.controller('UserAccount-Edit-Controller',
    ['$scope', '$routeParams', '$location', 'UserAccountFactory',
    function ($scope, $routeParams, $location, UserAccountFactory) {

        $scope.userAccount = UserAccountFactory.show({ id: $routeParams.id });

        // callback for ng-click 'updateUser':
        $scope.updateUserAccount = function () {
            UserAccountFactory.update({ id: $routeParams.id }, $scope.userAccount).$promise.then(
                    //suvccess
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