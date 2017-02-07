'use strict';

// create the module and name it sampleUI
// also include ngRoute for all our routing needs
var app = angular.module("sampleUI",
    ["ngRoute", "ngResource"]
);

// configure  routes
app.config(function ($routeProvider, $locationProvider) {
    $routeProvider
        .when('/useraccounts', {
            controller: 'UserAccount-Controller',
            templateUrl: 'app/templates/userAccount.html'
        })
        .when('/edituseraccount/:id', {
            controller: 'UserAccount-Edit-Controller',
            templateUrl: 'app/templates/userAccountEdit.html'
        })
        .when('/newuseraccount', {
            controller: 'UserAccount-New-Controller',
            templateUrl: 'app/templates/userAccountNew.html'
        })
        .otherwise({
            redirectTo: '/'
        }); //fallback is index.html

    //html5 mode to remove hash from url
    $locationProvider.html5Mode(true);

});


