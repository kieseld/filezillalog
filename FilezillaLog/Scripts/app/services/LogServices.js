angular.module('filezillaLogApp')
    .service('Log', ['$resource',
        function ($resource) {
            var LogResource = $resource('api/log/');

            this.GetLogs = function () {
                return LogResource.query();
            };
        }
    ]);