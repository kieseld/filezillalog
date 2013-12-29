angular.module('filezillaLogApp')
    .controller('Log', [
        '$scope', 'Log', 'datepickerPopupConfig',
        function ($scope, Log, datepickerPopupConfig) {

            $scope.endDate = new Date();
            $scope.beginDate = new Date();
            $scope.beginDate.setDate($scope.endDate.getDate() - 2);

            $scope.$watch('endDate', function () {
                Log.GetLogs($scope.beginDate, $scope.endDate).$promise.then(
                    function (model) {
                        $scope.logs = model;
                    });
            })

            $scope.openBegin = function ($event) {
                $event.preventDefault();
                $event.stopPropagation();
                $scope.openedBegin = true;
            };

            $scope.openEnd = function ($event) {
                $event.preventDefault();
                $event.stopPropagation();
                $scope.openedEnd = true;
            };

            $scope.format = 'dd-MMMM-yyyy'

        }
    ]);