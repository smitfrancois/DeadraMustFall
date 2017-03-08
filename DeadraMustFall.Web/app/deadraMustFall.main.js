require.config({
    baseUrl: "",
    paths: {
        "angular": "scripts/angular",
        "angularAMD": "scripts/angularAMD",
        "bootstrap": "scripts/bootstrap",
        "jquery": "scripts/jquery-1.9.1",
        "mainContentController": "app/mainContent/mainContent.controller",
        "mainContentDirective": "app/mainContent/mainContent.directive",
        "mainMenuController": "app/mainMenu/mainMenu.controller",
        "mainMenuDirective": "app/mainMenu/mainMenu.directive",
        "registerMemberController": "app/registerMember/registerMember.controller",
        "registerMemberDirective": "app/registerMember/registerMember.directive",
        "mainHeaderController": "app/mainHeader/mainHeader.controller",
        "mainHeaderDirective":"app/mainHeader/mainHeader.directive"
    },
    shim: {
        "angular": "angular",
        "bootstrap": { deps: ["jquery"] }

    },
    deps: ["app/deadraMustFall.module"]
})