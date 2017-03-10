define(["angularAMD"],
    function(angularAMD) {
        angularAMD
            .controller("registerMemberController", registerMemberController);

        registerMemberController.$inject = ["$scope","apiServices"];

        function registerMemberController(scope,apiServices) {
            var vm = this;

            vm.newMember = {
                ESOHandle: null,
                EmailAddress: null,
                Password:null
            }

            vm.addNewMember = function() {
               return apiServices.addNewMember(vm.newMember).then(function(response) {
                    
                }).catch(function(error) {
                    
                });
            };
        };
    });