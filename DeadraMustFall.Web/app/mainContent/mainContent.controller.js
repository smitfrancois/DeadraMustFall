define(["angularAMD"],
    function(angularAMD) {

        angularAMD
            .controller("mainContentController", mainContentController);

        mainContentController.$inject = ["$scope"];

        function mainContentController(scope) {
            var vm = this;
        };

    });