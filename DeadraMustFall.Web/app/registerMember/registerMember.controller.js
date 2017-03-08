define(["angularAMD"],
    function(angularAMD) {
        angularAMD
            .controller("registerMemberController", registerMemberController);

        registerMemberController.$inject = ["$scope","apiServices"];

        function registerMemberController(scope,apiServices) {
            var vm = this;

            vm.addNewMember = function() {
                apiServices.addNewMember("sdfff");
            };
        };
    });