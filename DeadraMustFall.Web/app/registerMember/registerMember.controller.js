define(["angularAMD"],
    function(angularAMD) {
        angularAMD
            .controller("registerMemberController", registerMemberController);

        registerMemberController.$inject = ["$scope"];

        function registerMemberController(scope) {
            var vm = this;
        };
    });