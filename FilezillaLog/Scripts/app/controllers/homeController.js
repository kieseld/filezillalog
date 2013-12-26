angular.module('filezillaLogApp')
    .controller('Home', [
        '$scope', 'Log',
        function ($scope, Log) {

            Log.GetLogs().$promise.then(
                function (model) {
                    $scope.logs = model;
                });

        }
    ]);