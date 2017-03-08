define(["angularAMD"],
    function(angularAMD) {

        angularAMD
            .controller("mainMenuController", mainMenuController);

        mainMenuController.$inject = ["$scope"];

        function mainMenuController(scope) {
            var vm = this;

        };

    });