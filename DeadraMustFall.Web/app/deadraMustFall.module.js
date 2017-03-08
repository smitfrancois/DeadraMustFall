define(["angularAMD",
    "angular",
    "bootstrap",
    "jquery",
    "mainContentController",
    "mainContentDirective",
    "mainMenuController",
    "mainMenuDirective",
    "registerMemberController",
    "registerMemberDirective"], function (angularAMD) {
        var app = angular.module("DeadraMustFallApp", []);

        return angularAMD.bootstrap(app);
    });