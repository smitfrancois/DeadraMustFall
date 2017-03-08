define(["angularAMD",
    "angular",
    "bootstrap",
    "jquery",
    "mainContentController",
    "mainContentDirective"], function (angularAMD) {
        var app = angular.module("DeadraMustFallApp", []);

        return angularAMD.bootstrap(app);
    });