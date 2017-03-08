define(["angularAMD"],
    function(angularAMD) {

        angularAMD
            .factory("apiServices", apiServices);

        apiServices.$inject = ["$http"];

        function apiServices(http) {
            return {
                addNewMember: addNewMember,
                getApiUrl: getApiUrl
            };

            function getApiUrl(apiName,callback) {
                $.get("app/services/ApiUrls.json",
                    function(data) {
                        
                        $.each(data.ApiUrls,
                            function(ref, value) {
                                if (value.Name === apiName) {
                                    return callback(value.Url);
                                };
                            });

                    });
            };

            function addNewMember(newMember) {
                getApiUrl("AddNewMember",function(url) {
                    return http.post(url, "'" + JSON.stringify(newMember) + "'", {
                        headers: {
                            "Content-Type": "text/plain"
                        }
                    }).then(callSuccess).catch(callFailure);
                });
                
            };

            function callSuccess(response) {
                return response;
            };

            function callFailure(error) {
                return error;
            }
        };

    });