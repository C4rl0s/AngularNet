(function () {
    'use strict';

    var app = angular.module('app', ['ngResource', 'ngRoute']);

    app.config(['$routeProvider', function ($routeProvider) {

        $routeProvider.when('/simplePaging', {
            templateUrl: '/Scripts/app/simple/simple.html',
            controller: 'simpleCtrl',
            caseInsensitiveMatch: true
        });
       
    }]);

    app.run([function () {
    }]);
})();