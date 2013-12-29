angular.module('filezillaLogApp')
    .service('Log', ['$resource',
        function ($resource) {
            var LogResource = $resource('api/log/', {}, {
                fetch: {
                    method: "GET",
                    isArray: true,
                    params: {
                        beginDate: '@beginDate',
                        endDate: '@endDate'
                    }
                }
            });

            this.GetLogs = function (beginDate, endDate) {
                beginDate.setMilliseconds(0);
                beginDate.setSeconds(0);
                beginDate.setMinutes(0);
                beginDate.setHours(0);
                var begin = beginDate.toISOString();

                endDate.setDate(endDate.getDate() + 1);
                endDate.setMilliseconds(0);
                endDate.setSeconds(0);
                endDate.setMinutes(0);
                endDate.setHours(0);
                var end = endDate.toISOString();

                return LogResource.fetch({ beginDate: begin, endDate: end });
            };
        }
    ]);