define(["angularAMD"],
    function(angularAMD) {

        angularAMD
            .directive("mainMenu", mainMenu);

        function mainMenu() {
            var directive = {
                restrict: "E",
                templateUrl:"app/mainMenu/mainMenuView.html",
                controller: "mainMenuController",
                controllerAs: "mainMenuCtrl",
                bindToController: true,
                link:link
            };

            return directive;

            function link(scope, el, attr, ctrl) {
                
            };
        };

    });