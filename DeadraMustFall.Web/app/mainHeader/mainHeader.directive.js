define(["angularAMD"],
    function (angularAMD) {

        angularAMD
            .directive("mainHeader", mainHeader);

        function mainHeader() {
            var directive = {
                restrict: "E",
                templateUrl: "app/mainHeader/mainHeaderView.html",
                controller: "mainHeaderController",
                controllerAs: "mainHeaderCtrl",
                bindToController: true,
                link: link
            };

            return directive;

            function link(scope, el, attr, ctrl) {

            };
        };

    });