define(["angularAMD"],
    function(angularAMD) {

        angularAMD
            .directive("characterBuild", characterBuild);

        function characterBuild() {
          var directive = {
              restrict: "E",
              controller: "buildController",
              controllerAs: "buildCtrl",
              link: link,
              bindToController: true,
              templateUrl:"app/CharacterBuild/CharacterBuildView.html"
          }

          return directive;

            function link(scope, el, attr, ctrl) {
                
            };

        };

    });