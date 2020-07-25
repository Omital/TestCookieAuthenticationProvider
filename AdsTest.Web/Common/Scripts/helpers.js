var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('AdsTest');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);