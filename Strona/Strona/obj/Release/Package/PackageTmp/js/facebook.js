(function () {

    window.fbAsyncInit = function () {
        FB.init({
            appId: '809360925801214',
            xfbml: true,
            version: 'v2.3'
        });

        FB.getLoginStatus(function (response) {
            if (response.status === 'connected') {

                FB.api('/me', function (response) {
                    document.getElementById('imie').innerHTML = response.first_name;
                    document.getElementById('nazwisko').innerHTML = response.last_name;
                    document.getElementById('link').innerHTML = response.link;
                    console.log(response);
                });
            } else {
               // FB.login();

            }
        });
    };

    (function (d, s, id) {
        var js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) { return; }
        js = d.createElement(s); js.id = id;
        js.src = "//connect.facebook.net/en_US/sdk.js";
        fjs.parentNode.insertBefore(js, fjs);
    }(document, 'script', 'facebook-jssdk'));
})();