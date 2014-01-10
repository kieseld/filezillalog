angular.module('filezillaLogApp')
    .controller('Log', [
        '$scope', 'Log', 'datepickerPopupConfig',
        function ($scope, Log, datepickerPopupConfig) {

            $scope.endDate = new Date();
            $scope.beginDate = new Date();
            $scope.beginDate.setDate($scope.endDate.getDate() - 2);
            $scope.loading = true;
            $scope.noResults = false;

            getLogs = function (beginDate, endDate) {
                $scope.loading = true;
                $scope.noResults = false;
                Log.GetLogs(beginDate, endDate).$promise.then(
                function (model) {
                    $scope.logs = model;
                    $scope.loading = false;
                    if ($scope.logs.length === 0) {
                        $scope.noResults = true;
                    }
                    else {
                        $scope.noResults = false;
                    }
                });
            };

            getLogs($scope.beginDate, $scope.endDate);

            $scope.$watch('endDate', function (newVal, oldVal) {
                if (newVal !== oldVal) {
                    getLogs($scope.beginDate, $scope.endDate);
                }
            })

            $scope.$watch('beginDate', function (newVal, oldVal) {
                if (newVal !== oldVal) {
                    getLogs($scope.beginDate, $scope.endDate);
                }
            })

            $scope.sortOrder = 'Date';

            $scope.toggleSort = function (sort, $event) {
                var element = angular.element($event.currentTarget.children[0]);
                element.removeClass();
                if (sort.indexOf('-') === -1) {
                    $scope.sortOrder = "-" + sort;
                    element.addClass('glyphicon glyphicon-sort-by-attributes-alt');
                }
                else {
                    $scope.sortOrder = sort;
                    element.addClass('glyphicon glyphicon-sort-by-attributes');
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