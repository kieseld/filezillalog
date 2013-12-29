'use strict';

/* App Module */

angular.module('filezillaLogApp', ['ngRoute', 'ngResource', 'ui.bootstrap']).
    config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        $locationProvider.html5Mode(true);

        $routeProvider.when('/', {
            templateUrl: 'scripts/app/templates/index.html'
            , controller: 'Log'
        });

        $routeProvider.otherwise({
            redirectTo: '/'
        });
    }]);