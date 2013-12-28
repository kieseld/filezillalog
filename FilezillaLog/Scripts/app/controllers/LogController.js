angular.module('filezillaLogApp')
    .controller('Log', [
        '$scope', 'Log',
        function ($scope, Log) {

            Log.GetLogs().$promise.then(
                function (model) {
                    $scope.logs = model;
                });

        }
    ]);