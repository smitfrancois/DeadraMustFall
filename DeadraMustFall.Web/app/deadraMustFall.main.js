﻿require.config({
    baseUrl: "",
    paths: {
        "angular": "scripts/angular",
        "angularAMD": "scripts/angularAMD",
        "bootstrap": "scripts/bootstrap",
        "jquery": "scripts/jquery-1.9.1",
        "mainContentController": "app/mainContent/mainContent.controller",
        "mainContentDirective":"app/mainContent/mainContent.directive"
    },
    shim: {
        "angular": "angular",
        "bootstrap": { deps: ["jquery"] }

    },
    deps: ["app/deadraMustFall.module"]
})