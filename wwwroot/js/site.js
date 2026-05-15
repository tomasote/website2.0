window.getScreenWidth = () => {
    return window.innerWidth;
};

window.getScreenHeight = () => {
    return window.innerHeight;
}

window.disableBodyScroll = () => {
    document.body.style.overflow = 'hidden';
};

window.enableBodyScroll = () => {
    document.body.style.overflow = '';
};

window.scrollWatcher = {
    observe: function (dotnetHelper) {

        window.addEventListener("scroll", function () {

            const isAtTop = window.scrollY === 0;

            dotnetHelper.invokeMethodAsync(
                "OnScrollStateChanged",
                isAtTop
            );
        });
    }
};