angular.module('filezillaLogApp')
    .controller('Log', [
        '$scope', 'Log', 'datepickerPopupConfig',
        function ($scope, Log, datepickerPopupConfig) {

            $scope.endDate = new Date();
            $scope.beginDate = new Date();
            $scope.beginDate.setDate($scope.endDate.getDate() - 2);

            Log.GetLogs($scope.beginDate, $scope.endDate).$promise.then(
                function (model) {
                    $scope.logs = model;
                });

            $scope.$watch('endDate', function (newVal, oldVal) {
                if (newVal !== oldVal) {
                    Log.GetLogs($scope.beginDate, $scope.endDate).$promise.then(
                        function (model) {
                            $scope.logs = model;
                        });
                }
            })

            $scope.$watch('beginDate', function (newVal, oldVal) {
                if (newVal !== oldVal) {
                    Log.GetLogs($scope.beginDate, $scope.endDate).$promise.then(
                        function (model) {
                            $scope.logs = model;
                        });
                }
            })

            $scope.sortOrder = '-Date';

            $scope.toggleSort = function (sort) {
                if (sort === $scope.sortOrder) {
                    $scope.sortOrder = "-" + sort;
                }
                else {
                    $scope.sortOrder = sort;
                }
                console.log($scope.sortOrder);
            }

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