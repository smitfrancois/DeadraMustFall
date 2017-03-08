define(["angularAMD"],
    function(angularAMD) {
        angularAMD
            .directive("registerMember", registerMember);

        function registerMember() {
            var directive = {
                restrict: "E",
                controller: "registerMemberController",
                controllerAs: "registerMemberCtrl",
                templateUrl: "app/registerMember/registerMemberView.html",
                link: link,
                bindToController: true
            };

            return directive;

            function link(scope, el, attr, ctrl) {
                
            };
        };
    });