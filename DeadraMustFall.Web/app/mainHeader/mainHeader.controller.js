define(["angularAMD"],
    function (angularAMD) {

        angularAMD
            .controller("mainHeaderController", mainHeaderController);

        mainHeaderController.$inject = ["$scope"];

        function mainHeaderController(scope) {
            var vm = this;

        };

    });