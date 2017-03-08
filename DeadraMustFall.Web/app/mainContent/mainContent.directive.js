define(["angularAMD"],
    function(angularAMD) {

        angularAMD
            .directive("mainContent", mainContent);

        function mainContent() {
            var directive = {
                restrict: "E",
                templateUrl: "app/mainContent/mainContentView.html",
                controller: "mainContentController",
                controllerAs: "mainContentCtrl",
                bindToController: true,
                link:link
            };
            return directive;

            function link(scope, el, attr, ctrl) {
                
            };
        };

    });